; === Fertech490WC Setup ===
#define MyAppName "Fertech490WC"
#define MyAppVersion "1.0"
#define MyAppPublisher "Fertech"
#define MyAppExeName "Fertech.exe"
#define MyAppName "Fertech490WC"
#define MyAppVersion "1.5"
#define MyAppPublisher "CZ Enterprise"
#define MyAppExeName "Fertech.exe"
#define PrereqsPath "C:\GitHubCarpetaDiploma\ProyectoWACZ490WC\CampoWACZ490WC\GUI490WC\bin\Debug"
#define MyDbName "BD_PROYECTO_2025490WC"
#define SqlCmdPath "{commonpf64}\Microsoft SQL Server\Client SDK\ODBC\170\Tools\Binn"

[Setup]
AppId={{D3E04D5B-9B0F-4F37-BDE4-8C57A490WC01}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf32}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputBaseFilename=FertechInstaller
Compression=lzma
SolidCompression=yes
WizardStyle=modern
PrivilegesRequired=admin
ArchitecturesInstallIn64BitMode=x64

[Languages]
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Files]
; Se copian todos los archivos necesarios al directorio de instalación
Source: "C:\GitHubCarpetaDiploma\ProyectoWACZ490WC\CampoWACZ490WC\GUI490WC\bin\Debug\*"; \
  DestDir: "{app}"; Flags: recursesubdirs ignoreversion

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"

[Run]
; Ejecutar PowerShell SOLO si el usuario eligió reinstalar la BD

Filename: "{tmp}\VC_redist.x64.exe"; Parameters: "/install /quiet /norestart"; StatusMsg: "Instalando componentes de Microsoft..."; Flags: runhidden waituntilterminated; Check: IsVCRedistNeeded()
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\SqlLocalDB.msi"" /qn IACCEPTSQLLOCALDBLICENSETERMS=YES"; StatusMsg: "Instalando motor LocalDB..."; Flags: runhidden waituntilterminated
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\msodbcsql.msi"" /qn IACCEPTMSODBCSQLLICENSETERMS=YES"; StatusMsg: "Instalando controlador de conexión..."; Flags: runhidden waituntilterminated
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\MsSqlCmdLnUtils.msi"" /qn IACCEPTMSSQLCMDLNUTILSLICENSETERMS=YES"; StatusMsg: "Instalando herramientas SQL..."; Flags: runhidden waituntilterminated

; Configurar base de datos según elección
Filename: "{#SqlCmdPath}\sqlcmd.exe"; Parameters: "-S {code:GetSqlCmdServer} -Q ""IF EXISTS (SELECT name FROM sys.databases WHERE name = '{#MyDbName}') BEGIN ALTER DATABASE {#MyDbName} SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE {#MyDbName}; END"" -E"; Flags: runhidden; StatusMsg: "Eliminando base de datos anterior..."; Check: ShouldReinstallDB()
;Filename: "powershell.exe";Parameters: "-ExecutionPolicy Bypass -File ""{tmp}\create_db.ps1"" -Server ""{code:GetSelectedInstance}"" -DbName ""BD_PROYECTO_2025490WC"" -AppCfg ""{app}\Fertech.exe.config"" -ConnStr ""Data Source={code:GetSelectedInstance};Initial Catalog=BD_PROYECTO_2025490WC;Integrated Security=True;Encrypt=False"" -JsonPath ""{app}\config.json"""; StatusMsg: "Creando base de datos y configurando conexión..."; Flags: runhidden waituntilterminated


Filename: "{#SqlCmdPath}\sqlcmd.exe"; Parameters: "-S {code:GetSqlCmdServer} -i ""{app}\01_Create_DB.sql"" -E"; Flags: runhidden; StatusMsg: "Creando base de datos..."; Check: ShouldReinstallDB()
Filename: "{#SqlCmdPath}\sqlcmd.exe"; Parameters: "-S {code:GetSqlCmdServer} -d {#MyDbName} -i ""{app}\02_Schema_Data_Permisos.sql"" -E"; Flags: runhidden; StatusMsg: "Cargando estructura y datos..."; Check: ShouldReinstallDB()
Filename: "{#SqlCmdPath}\sqlcmd.exe"; Parameters: "-S {code:GetSqlCmdServer} -d {#MyDbName} -Q ""IF NOT EXISTS (SELECT name FROM sys.server_principals WHERE name = N'BUILTIN\Users') CREATE LOGIN [BUILTIN\Users] FROM WINDOWS; IF NOT EXISTS (SELECT name FROM sys.database_principals WHERE name = N'BUILTIN\Users') CREATE USER [BUILTIN\Users] FOR LOGIN [BUILTIN\Users]; EXEC sp_addrolemember 'db_owner', N'BUILTIN\Users'"" -E"; Flags: runhidden; StatusMsg: "Asignando permisos..."; Check: ShouldReinstallDB()


[Code]
var
  ReinstallPage: TWizardPage;
  ReinstallDBCheckBox: TNewCheckBox;

procedure InitializeWizard;
begin
  { Página para preguntar si reinstalar la base de datos }
  ReinstallPage := CreateCustomPage(wpReady, 'Configuración de base de datos', '¿Desea reinstalar la base de datos existente?');

  ReinstallDBCheckBox := TNewCheckBox.Create(WizardForm);
  ReinstallDBCheckBox.Parent := ReinstallPage.Surface;
  ReinstallDBCheckBox.Caption := 'Sí, deseo reinstalar la base de datos.';
  ReinstallDBCheckBox.Checked := False;
end;

function IsVCRedistNeeded(): Boolean;
begin
  Result := not RegKeyExists(HKLM64, 'SOFTWARE\Microsoft\VisualStudio\14.0\VC\Runtimes\x64');
end;

function UseLocalDb(): Boolean;
begin
  Result := ReinstallDBCheckBox.Checked;
end;

function GetSqlCmdServer(Param: string): string;
begin
  if UseLocalDb() then
    Result := '.'
end;



function ShouldReinstallDB: Boolean;
begin
  Result := ReinstallDBCheckBox.Checked;
end;

procedure CurPageChanged(CurPageID: Integer);
begin
  { Cambiar texto del botón en la pantalla de instalación }
  if CurPageID = wpReady then
    WizardForm.NextButton.Caption := 'Instalar';
end;
