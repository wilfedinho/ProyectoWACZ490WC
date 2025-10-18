; Script generado con las correcciones y la integración de SQL LocalDB.
; --- Adaptado para usar permisos BUILTIN\Users para evitar problemas de UAC ---

#define MyAppName "Fertech490WC"
#define MyAppVersion "1.5"
#define MyAppPublisher "CZ Enterprise"
#define MyAppExeName "Fertech.exe"

; Define la ruta a los instaladores de requisitos previos (Ajusta esta ruta a donde los tengas)
#define PrereqsPath "C:\GitHubCarpetaDiploma\ProyectoWACZ490WC\CampoWACZ490WC\GUI490WC\bin\Debug"

; Define el nombre de tu base de datos
#define MyDbName "BD_PROYECTO_2025490WC"

; Ruta a las herramientas de línea de comandos (sqlcmd.exe)
#define SqlCmdPath "{commonpf64}\Microsoft SQL Server\Client SDK\ODBC\170\Tools\Binn"


[Setup]
AppId={{E973F20A-D10E-4F07-B099-ECD1A6E8EB8D}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
UninstallDisplayIcon={app}\{#MyAppExeName}
DisableProgramGroupPage=yes
OutputBaseFilename=FertechInstaller
SolidCompression=yes
WizardStyle=modern
; Requerimos privilegios de administrador para instalar dependencias y configurar la BD
PrivilegesRequired=admin


[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"


[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked


; --- Nuevas secciones requeridas para la base de datos ---

[CustomMessages]
english.DbSetupPageTitle=Database Setup
spanish.DbSetupPageTitle=Configuración de Base de Datos
english.DbSetupPageDesc=Restore DataBase?
spanish.DbSetupPageDesc=¿Reinstalar Base de Datos?


[Files]
; Archivos de tu proyecto
Source: "C:\GitHubCarpetaDiploma\ProyectoWACZ490WC\CampoWACZ490WC\GUI490WC\bin\Debug\*"; DestDir: "{app}"; Flags: ignoreversion

; Instaladores de requisitos previos (Deben estar en la ruta definida en #define PrereqsPath)
Source: "{#PrereqsPath}\VC_redist.x64.exe"; DestDir: "{tmp}"; Flags: deleteafterinstall
Source: "{#PrereqsPath}\SqlLocalDB.msi"; DestDir: "{tmp}"; Flags: deleteafterinstall
Source: "{#PrereqsPath}\msodbcsql.msi"; DestDir: "{tmp}"; Flags: deleteafterinstall
Source: "{#PrereqsPath}\MsSqlCmdLnUtils.msi"; DestDir: "{tmp}"; Flags: deleteafterinstall

; Scripts SQL
Source: "C:\GitHubCarpetaDiploma\ProyectoWACZ490WC\CampoWACZ490WC\GUI490WC\bin\Debug\01_Create_DB.sql"; DestDir: "{app}"
; Asegúrate de que el script 02 también esté aquí si lo usas en el paso 8
Source: "C:\GitHubCarpetaDiploma\ProyectoWACZ490WC\CampoWACZ490WC\GUI490WC\bin\Debug\02_Schema_Data_Permisos.sql"; DestDir: "{app}"

; Archivos de lenguajes
Source: "C:\GitHubCarpetaDiploma\ProyectoWACZ490WC\CampoWACZ490WC\GUI490WC\bin\Debug\Lenguajes\*"; DestDir: "{app}\Lenguajes"; Flags: recursesubdirs createallsubdirs ignoreversion


[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon


; --- Bloque [Run] completamente actualizado ---
[Run]
; 1. Instalar Visual C++ Redistributable
Filename: "{tmp}\VC_redist.x64.exe"; Parameters: "/install /quiet /norestart"; StatusMsg: "Instalando componentes de Microsoft..."; Flags: runhidden waituntilterminated; Check: IsVCRedistNeeded()

; 2. Instalar SQL LocalDB
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\SqlLocalDB.msi"" /qn IACCEPTSQLLOCALDBLICENSETERMS=YES"; StatusMsg: "Instalando motor LocalDB..."; Flags: runhidden waituntilterminated

; 3. Instalar ODBC Driver
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\msodbcsql.msi"" /qn IACCEPTMSODBCSQLLICENSETERMS=YES"; StatusMsg: "Instalando controlador de conexión..."; Flags: runhidden waituntilterminated

; 4. Instalar herramientas de línea de comandos (Contiene sqlcmd.exe)
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\MsSqlCmdLnUtils.msi"" /qn IACCEPTMSSQLCMDLNUTILSLICENSETERMS=YES"; StatusMsg: "Instalando herramientas de base de datos..."; Flags: runhidden waituntilterminated

; 5. Crear y Arrancar instancia LocalDB (MSSQLLocalDB es el nombre por defecto)
Filename: "{commonpf64}\Microsoft SQL Server\160\Tools\Binn\sqllocaldb.exe"; Parameters: "create MSSQLLocalDB"; Flags: runhidden waituntilterminated;

Filename: "{commonpf64}\Microsoft SQL Server\160\Tools\Binn\sqllocaldb.exe"; Parameters: "start MSSQLLocalDB"; Flags: runhidden waituntilterminated;

; 6. Eliminar base de datos antigua
Filename: "{#SqlCmdPath}\sqlcmd.exe"; Parameters: "-S (LocalDB)\MSSQLLocalDB -Q ""IF EXISTS (SELECT name FROM sys.databases WHERE name = '{#MyDbName}') BEGIN ALTER DATABASE {#MyDbName} SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE {#MyDbName}; END"" -E"; StatusMsg: "Eliminando base de datos antigua..."; Flags: runhidden; Check: ShouldPerformDbSetup()

; 7. Crear la base de datos (Usando 01_Create_DB.sql)
Filename: "{#SqlCmdPath}\sqlcmd.exe"; Parameters: "-S (LocalDB)\MSSQLLocalDB -i ""{app}\01_Create_DB.sql"" -E"; StatusMsg: "Creando la base de datos..."; Flags: runhidden; Check: ShouldPerformDbSetup()

; 8. Ejecutar script SQL (Estructura y datos)
Filename: "{#SqlCmdPath}\sqlcmd.exe"; Parameters: "-S (LocalDB)\MSSQLLocalDB -d {#MyDbName} -i ""{app}\02_Schema_Data_Permisos.sql"" -E"; StatusMsg: "Configurando estructura y permisos..."; Flags: runhidden; Check: ShouldPerformDbSetup()

; 9. **SOLUCIÓN DE PERMISOS:** Asignar permisos al grupo BUILTIN\Users.
; Esto garantiza que CUALQUIER usuario de Windows en la máquina pueda acceder a la DB,
; resolviendo el problema de la ejecución elevada (Admin) vs la ejecución normal (Usuario).
Filename: "{#SqlCmdPath}\sqlcmd.exe"; Parameters: "-S (LocalDB)\MSSQLLocalDB -d {#MyDbName} -Q ""IF NOT EXISTS (SELECT name FROM sys.server_principals WHERE name = N'BUILTIN\Users') CREATE LOGIN [BUILTIN\Users] FROM WINDOWS; IF NOT EXISTS (SELECT name FROM sys.database_principals WHERE name = N'BUILTIN\Users') CREATE USER [BUILTIN\Users] FOR LOGIN [BUILTIN\Users]; EXEC sp_addrolemember 'db_owner', N'BUILTIN\Users'"" -E"; StatusMsg: "Asignando permisos generales para la aplicación..."; Flags: runhidden; Check: ShouldPerformDbSetup()

; 10. Iniciar la aplicación
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent


[Code]

var
DbSetupPage: TNewCheckBox; // Checkbox para preguntar si configurar la DB

// Esta función chequea si VC++ Redistributable ya está instalado.
function IsVCRedistNeeded(): Boolean;
begin
Result := not RegKeyExists(HKLM64, 'SOFTWARE\Microsoft\VisualStudio\14.0\VC\Runtimes\x64');
end;

function GetCurrentUser(Param: string): string;
begin
Result := GetEnv('USERNAME');
end;

// Crea la página de la opción de configuración de BD
procedure CreateDbSetupPage;
begin
DbSetupPage := TNewCheckBox.Create(WizardForm);
DbSetupPage.Caption := CustomMessage('DbSetupPageDesc');
DbSetupPage.Checked := True;
DbSetupPage.Parent := WizardForm;
DbSetupPage.Visible := False;
end;

// Maneja los cambios de página para mostrar/ocultar y posicionar el checkbox
procedure CurPageChanged(CurPageID: Integer);
begin
// Muestra el checkbox en la página de Tareas
if CurPageID = wpSelectTasks then
begin
 // Posicionamos el checkbox
DbSetupPage.Top := WizardForm.ClientHeight - DbSetupPage.Height - ScaleY(10);
DbSetupPage.Left := ScaleX(20);
DbSetupPage.Visible := True;
end else begin
 DbSetupPage.Visible := False;
 end;
end;

// Se llama antes de la página de tareas para crear el checkbox.
procedure InitializeWizard;
begin
CreateDbSetupPage;
end;

// Chequea si el usuario marcó la opción de configurar la BD.
function ShouldPerformDbSetup(): Boolean;
begin
 Result := DbSetupPage.Checked;
end;