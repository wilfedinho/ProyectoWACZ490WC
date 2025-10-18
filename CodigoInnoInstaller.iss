; Script generado con las correcciones y la integración de SQL LocalDB.

#define MyAppName "Fertech490WC"
#define MyAppVersion "1.5"
#define MyAppPublisher "CZ Enterprise"
#define MyAppExeName "Fertech.exe"
; Define la ruta a los instaladores de requisitos previos (Ajusta esta ruta a donde los tengas)
#define PrereqsPath "C:\GitHubCarpetaDiploma\ProyectoWACZ490WC\CampoWACZ490WC\GUI490WC\bin\Debug"
; Define el nombre de tu base de datos
#define MyDbName "BD_PROYECTO_2025490WC"
; Asegúrate de que esta línea esté en la cabecera de tu script, antes de [Setup]
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
; Archivos de tu proyecto (La línea corregida del error anterior)
Source: "C:\GitHubCarpetaDiploma\ProyectoWACZ490WC\CampoWACZ490WC\GUI490WC\bin\Debug\*"; DestDir: "{app}"; Flags: ignoreversion
; Necesitas añadir los instaladores de requisitos previos a la sección [Files] para que se empaqueten.
; **Asegúrate de tener estos archivos en la ruta definida en #define PrereqsPath**
Source: "{#PrereqsPath}\VC_redist.x64.exe"; DestDir: "{tmp}"; Flags: deleteafterinstall
Source: "{#PrereqsPath}\SqlLocalDB.msi"; DestDir: "{tmp}"; Flags: deleteafterinstall
Source: "{#PrereqsPath}\msodbcsql.msi"; DestDir: "{tmp}"; Flags: deleteafterinstall
Source: "{#PrereqsPath}\MsSqlCmdLnUtils.msi"; DestDir: "{tmp}"; Flags: deleteafterinstall
; Necesitas el script SQL que crea la base de datos.
; **Asegúrate de tener este archivo en la ruta y de que el archivo exista**
Source: "C:\GitHubCarpetaDiploma\ProyectoWACZ490WC\CampoWACZ490WC\GUI490WC\bin\Debug\01_Create_DB.sql"; DestDir: "{app}"
Source: "C:\GitHubCarpetaDiploma\ProyectoWACZ490WC\CampoWACZ490WC\GUI490WC\bin\Debug\Lenguajes\*"; \
DestDir: "{app}\Lenguajes"; \
Flags: recursesubdirs createallsubdirs ignoreversion

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

; --- Bloque [Run] completamente actualizado ---
[Run]
; 1. Instalar Visual C++ Redistributable
Filename: "{tmp}\VC_redist.x64.exe"; Parameters: "/install /quiet /norestart"; StatusMsg: "Instalando componentes de Microsoft..."; Flags: runhidden waituntilterminated; Check: IsVCRedistNeeded()

; 2. Instalar SQL LocalDB
; **CORREGIDO:** El instalador es msiexec.exe, el MSI es el parámetro.
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\SqlLocalDB.msi"" /qn IACCEPTSQLLOCALDBLICENSETERMS=YES"; StatusMsg: "Instalando motor LocalDB..."; Flags: runhidden waituntilterminated

; 3. Instalar ODBC Driver
; **CORREGIDO:** El instalador es msiexec.exe, el MSI es el parámetro.
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\msodbcsql.msi"" /qn IACCEPTMSODBCSQLLICENSETERMS=YES"; StatusMsg: "Instalando controlador de conexión..."; Flags: runhidden waituntilterminated

; 4. Instalar herramientas de línea de comandos (Contiene sqlcmd.exe)
; **CORREGIDO:** El instalador es msiexec.exe, el MSI es el parámetro.
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\MsSqlCmdLnUtils.msi"" /qn IACCEPTMSSQLCMDLNUTILSLICENSETERMS=YES"; StatusMsg: "Instalando herramientas de base de datos..."; Flags: runhidden waituntilterminated

; 5. Crear y Arrancar instancia LocalDB
Filename: "{commonpf64}\Microsoft SQL Server\160\Tools\Binn\sqllocaldb.exe"; Parameters: "create MSSQLLocalDB -s"; Flags: runhidden waituntilterminated;

; AHORA USAMOS LA RUTA DEL SISTEMA {#SqlCmdPath} y los comandos SQL (-Q)

; 6. Eliminar base de datos antigua
; **CORREGIDO:** Usa {#SqlCmdPath}\sqlcmd.exe como Filename y el comando SQL en Parameters.
Filename: "{#SqlCmdPath}\sqlcmd.exe"; Parameters: "-S (LocalDB)\MSSQLLocalDB -Q ""IF EXISTS (SELECT name FROM sys.databases WHERE name = '{#MyDbName}') BEGIN ALTER DATABASE {#MyDbName} SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE {#MyDbName}; END"" -E"; StatusMsg: "Eliminando base de datos antigua..."; Flags: runhidden; Check: ShouldPerformDbSetup()

; 7. Crear la base de datos
; **CORREGIDO:** Usa {#SqlCmdPath}\sqlcmd.exe como Filename y el comando SQL en Parameters.
; Usamos el script 01_Create_DB.sql para el comando -i (InputFile)
Filename: "{#SqlCmdPath}\sqlcmd.exe"; Parameters: "-S (LocalDB)\MSSQLLocalDB -i ""{app}\01_Create_DB.sql"" -E"; StatusMsg: "Creando la base de datos..."; Flags: runhidden; Check: ShouldPerformDbSetup()

; 8. Ejecutar script SQL (Estructura y datos)
; **CORREGIDO:** Usa {#SqlCmdPath}\sqlcmd.exe como Filename y el script 02 como InputFile.
Filename: "{#SqlCmdPath}\sqlcmd.exe"; Parameters: "-S (LocalDB)\MSSQLLocalDB -d {#MyDbName} -i ""{app}\02_Schema_Data_Permisos.sql"" -E"; StatusMsg: "Configurando estructura y permisos..."; Flags: runhidden; Check: ShouldPerformDbSetup()

; 9. Asignar permisos al usuario actual (Si los permisos no se hicieron en el paso 8)
; **CORREGIDO:** Usa {#SqlCmdPath}\sqlcmd.exe como Filename y el comando SQL en Parameters.
Filename: "{#SqlCmdPath}\sqlcmd.exe"; Parameters: "-S (LocalDB)\MSSQLLocalDB -d {#MyDbName} -Q ""IF NOT EXISTS (SELECT name FROM sys.database_principals WHERE name = N'{code:GetCurrentUser}') CREATE USER [{code:GetCurrentUser}] FOR LOGIN [{code:GetCurrentUser}]; EXEC sp_addrolemember 'db_owner', N'{code:GetCurrentUser}'"" -E"; StatusMsg: "Asignando permisos..."; Flags: runhidden; Check: ShouldPerformDbSetup()

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

// Obtiene el nombre del usuario actual de Windows.
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
  
  // Usamos WizardForm como padre para máxima compatibilidad con versiones antiguas
  DbSetupPage.Parent := WizardForm; 
  
  // Posicionamiento se hará en CurPageChanged
  DbSetupPage.Visible := False;
end;

// Maneja los cambios de página para mostrar/ocultar y posicionar el checkbox
procedure CurPageChanged(CurPageID: Integer);
begin
  // Muestra el checkbox en la página de Tareas (o Componentes)
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