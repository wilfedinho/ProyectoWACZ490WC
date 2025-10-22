; --- Fertech490WC Installer con detección de instancias SQL Server ---
; Combina instalación con LocalDB y opción de usar una instancia detectada

#define MyAppName "Fertech490WC"
#define MyAppVersion "1.5"
#define MyAppPublisher "CZ Enterprise"
#define MyAppExeName "Fertech.exe"
#define PrereqsPath "C:\GitHubCarpetaDiploma\ProyectoWACZ490WC\CampoWACZ490WC\GUI490WC\bin\Debug"
#define MyDbName "BD_PROYECTO_2025490WC"
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
PrivilegesRequired=admin

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[CustomMessages]
english.DbSetupPageTitle=Database Setup
spanish.DbSetupPageTitle=Configuración de Base de Datos
english.DbSetupPageDesc=Restore DataBase?
spanish.DbSetupPageDesc=¿Reinstalar Base de Datos?

[Files]
; Archivos del programa
Source: "C:\GitHubCarpetaDiploma\ProyectoWACZ490WC\CampoWACZ490WC\GUI490WC\bin\Debug\*"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#PrereqsPath}\VC_redist.x64.exe"; DestDir: "{tmp}"; Flags: deleteafterinstall
Source: "{#PrereqsPath}\SqlLocalDB.msi"; DestDir: "{tmp}"; Flags: deleteafterinstall
Source: "{#PrereqsPath}\msodbcsql.msi"; DestDir: "{tmp}"; Flags: deleteafterinstall
Source: "{#PrereqsPath}\MsSqlCmdLnUtils.msi"; DestDir: "{tmp}"; Flags: deleteafterinstall
Source: "{#PrereqsPath}\list_sql_instances.ps1"; Flags: dontcopy
Source: "C:\GitHubCarpetaDiploma\ProyectoWACZ490WC\CampoWACZ490WC\GUI490WC\bin\Debug\01_Create_DB.sql"; DestDir: "{app}"
Source: "C:\GitHubCarpetaDiploma\ProyectoWACZ490WC\CampoWACZ490WC\GUI490WC\bin\Debug\02_Schema_Data_Permisos.sql"; DestDir: "{app}"
Source: "C:\GitHubCarpetaDiploma\ProyectoWACZ490WC\CampoWACZ490WC\GUI490WC\bin\Debug\Lenguajes\*"; DestDir: "{app}\Lenguajes"; Flags: recursesubdirs createallsubdirs ignoreversion

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

; --- Instalación de dependencias y base de datos ---
[Run]
Filename: "{tmp}\VC_redist.x64.exe"; Parameters: "/install /quiet /norestart"; StatusMsg: "Instalando componentes de Microsoft..."; Flags: runhidden waituntilterminated; Check: IsVCRedistNeeded()
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\SqlLocalDB.msi"" /qn IACCEPTSQLLOCALDBLICENSETERMS=YES"; StatusMsg: "Instalando motor LocalDB..."; Flags: runhidden waituntilterminated
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\msodbcsql.msi"" /qn IACCEPTMSODBCSQLLICENSETERMS=YES"; StatusMsg: "Instalando controlador de conexión..."; Flags: runhidden waituntilterminated
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\MsSqlCmdLnUtils.msi"" /qn IACCEPTMSSQLCMDLNUTILSLICENSETERMS=YES"; StatusMsg: "Instalando herramientas SQL..."; Flags: runhidden waituntilterminated

; Crear LocalDB solo si no se eligió instancia
Filename: "{commonpf64}\Microsoft SQL Server\160\Tools\Binn\sqllocaldb.exe"; Parameters: "create MSSQLLocalDB"; Flags: runhidden waituntilterminated; Check: UseLocalDb()
Filename: "{commonpf64}\Microsoft SQL Server\160\Tools\Binn\sqllocaldb.exe"; Parameters: "start MSSQLLocalDB"; Flags: runhidden waituntilterminated; Check: UseLocalDb()

; Configurar base de datos según elección
Filename: "{#SqlCmdPath}\sqlcmd.exe"; Parameters: "-S {code:GetSqlCmdServer} -Q ""IF EXISTS (SELECT name FROM sys.databases WHERE name = '{#MyDbName}') BEGIN ALTER DATABASE {#MyDbName} SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE {#MyDbName}; END"" -E"; Flags: runhidden; StatusMsg: "Eliminando base de datos anterior..."; Check: ShouldPerformDbSetup()
Filename: "powershell.exe"; \
  Parameters: "-ExecutionPolicy Bypass -File ""{tmp}\create_db.ps1"" -Server ""{code:GetSelectedInstance}"" -DbName ""proyecto_is"" -AppCfg ""{app}\GUI.exe.config"" -ConnStr ""Data Source={code:GetSelectedInstance};Initial Catalog=proyecto_is;Integrated Security=True;Encrypt=False"" -JsonPath ""{app}\config.json"""; \
  StatusMsg: "Creando base de datos y configurando conexión..."; \
  Flags: runhidden waituntilterminated
Filename: "{#SqlCmdPath}\sqlcmd.exe"; Parameters: "-S {code:GetSqlCmdServer} -i ""{app}\01_Create_DB.sql"" -E"; Flags: runhidden; StatusMsg: "Creando base de datos..."; Check: ShouldPerformDbSetup()
Filename: "{#SqlCmdPath}\sqlcmd.exe"; Parameters: "-S {code:GetSqlCmdServer} -d {#MyDbName} -i ""{app}\02_Schema_Data_Permisos.sql"" -E"; Flags: runhidden; StatusMsg: "Cargando estructura y datos..."; Check: ShouldPerformDbSetup()
Filename: "{#SqlCmdPath}\sqlcmd.exe"; Parameters: "-S {code:GetSqlCmdServer} -d {#MyDbName} -Q ""IF NOT EXISTS (SELECT name FROM sys.server_principals WHERE name = N'BUILTIN\Users') CREATE LOGIN [BUILTIN\Users] FROM WINDOWS; IF NOT EXISTS (SELECT name FROM sys.database_principals WHERE name = N'BUILTIN\Users') CREATE USER [BUILTIN\Users] FOR LOGIN [BUILTIN\Users]; EXEC sp_addrolemember 'db_owner', N'BUILTIN\Users'"" -E"; Flags: runhidden; StatusMsg: "Asignando permisos..."; Check: ShouldPerformDbSetup()

; Lanzar aplicación
Filename: "{app}\{#MyAppExeName}"; Flags: nowait postinstall skipifsilent
[Code]
var
  PageInstances: TWizardPage;
  CboInstances: TNewComboBox;
  UseInstanceCB: TNewCheckBox;
  DbSetupPage: TNewCheckBox;
  SelectedInstance: string;
  GHasInstances: Boolean;  // ← variable correcta

// ---------------------------
// Verifica si falta el VC++
// ---------------------------
function IsVCRedistNeeded(): Boolean;
begin
  Result := not RegKeyExists(HKLM64, 'SOFTWARE\Microsoft\VisualStudio\14.0\VC\Runtimes\x64');
end;

// ---------------------------
// Agrega líneas al ComboBox
// ---------------------------
procedure AddLinesToCombo(const FilePath: string);
var
  Lines: TArrayOfString;
  I: Integer;
begin
  if FileExists(FilePath) and LoadStringsFromFile(FilePath, Lines) then
  begin
    for I := 0 to GetArrayLength(Lines) - 1 do
      if Trim(Lines[I]) <> '' then
        CboInstances.Items.Add(Trim(Lines[I]));
  end;
end;

// ---------------------------
// Ejecuta el PS1 y carga instancias detectadas
// ---------------------------
function PopulateInstancesFromPS(): Boolean;
var
  PSPath, OutPath, PSExe: string;
  RC: Integer;
begin
  ExtractTemporaryFile('list_sql_instances.ps1');
  PSPath := ExpandConstant('{tmp}\list_sql_instances.ps1');
  OutPath := AddBackslash(ExtractFilePath(PSPath)) + 'sql_instances.txt';
  PSExe := ExpandConstant('{sysnative}\WindowsPowerShell\v1.0\powershell.exe');
  if not FileExists(PSExe) then
    PSExe := ExpandConstant('{sys}\WindowsPowerShell\v1.0\powershell.exe');
  Exec(PSExe, Format('-NoProfile -ExecutionPolicy Bypass -File "%s"', [PSPath]), '', SW_HIDE, ewWaitUntilTerminated, RC);
  AddLinesToCombo(OutPath);
  GHasInstances := (CboInstances.Items.Count > 0);
  if GHasInstances then CboInstances.ItemIndex := 0;
  Result := GHasInstances;
end;

// ---------------------------
// Página de selección de instancia SQL
// ---------------------------
procedure CreateInstancePage;
var
  Lbl: TNewStaticText;
begin
  PageInstances := CreateCustomPage(wpSelectDir, 'Instancia de SQL Server', 'Seleccione una instancia existente o use LocalDB.');
  Lbl := TNewStaticText.Create(PageInstances);
  Lbl.Parent := PageInstances.Surface;
  Lbl.Caption := 'Instancias detectadas:';
  Lbl.Top := 4;
  Lbl.Left := 0;

  CboInstances := TNewComboBox.Create(PageInstances);
  CboInstances.Parent := PageInstances.Surface;
  CboInstances.Style := csDropDownList;
  CboInstances.Top := 20;
  CboInstances.Left := 0;
  CboInstances.Width := ScaleX(400);

  UseInstanceCB := TNewCheckBox.Create(PageInstances);
  UseInstanceCB.Parent := PageInstances.Surface;
  UseInstanceCB.Caption := 'Usar la instancia seleccionada (en lugar de LocalDB)';
  UseInstanceCB.Top := 60;
  UseInstanceCB.Left := 0;

  PopulateInstancesFromPS();
end;

// ---------------------------
// Página para decidir reinstalación BD
// ---------------------------
procedure CreateDbSetupPage;
begin
  DbSetupPage := TNewCheckBox.Create(WizardForm);
  DbSetupPage.Caption := CustomMessage('DbSetupPageDesc');
  DbSetupPage.Checked := True;
  DbSetupPage.Parent := WizardForm;
  DbSetupPage.Visible := False;
end;

// ---------------------------
// Inicializa las páginas del wizard
// ---------------------------
procedure InitializeWizard;
begin
  CreateInstancePage();
  CreateDbSetupPage();
end;

// ---------------------------
// Mostrar/ocultar checkbox de BD
// ---------------------------
procedure CurPageChanged(CurPageID: Integer);
begin
  if CurPageID = wpSelectTasks then
  begin
    DbSetupPage.Top := WizardForm.ClientHeight - DbSetupPage.Height - ScaleY(10);
    DbSetupPage.Left := ScaleX(20);
    DbSetupPage.Visible := True;
  end
  else
    DbSetupPage.Visible := False;
end;

// ---------------------------
// Lógica de instalación BD
// ---------------------------
function ShouldPerformDbSetup(): Boolean;
begin
  Result := DbSetupPage.Checked;
end;

// ---------------------------
// Uso de instancia o LocalDB
// ---------------------------
function UseInstanceSelected(Param: string): Boolean;
begin
  Result := Assigned(UseInstanceCB) and UseInstanceCB.Checked;
end;

function UseLocalDb(): Boolean;
begin
  Result := not UseInstanceSelected('');
end;

// ---------------------------
// Devuelve servidor para SQLCMD
// ---------------------------
function GetSqlCmdServer(Param: string): string;
begin
  if UseLocalDb() then
    Result := '(LocalDB)\MSSQLLocalDB'
  else if CboInstances.ItemIndex >= 0 then
    Result := CboInstances.Text
  else
    Result := '.\SQLEXPRESS';
end;

// ---------------------------
// Verifica si SQL Express está instalado
// ---------------------------
function SqlExpressInstalled: Boolean;
begin
  Result :=
    RegValueExists(HKLM,  'SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL', 'SQLEXPRESS') or
    RegValueExists(HKLM64,'SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL', 'SQLEXPRESS') or
    RegKeyExists(HKLM, 'SYSTEM\CurrentControlSet\Services\MSSQL$SQLEXPRESS') or
    RegKeyExists(HKLM, 'SYSTEM\CurrentControlSet\Services\MSSQLSERVER');
end;

// ---------------------------
// Devuelve instancia seleccionada
// ---------------------------
function GetSelectedInstance(Param: string): string;
begin
  if Assigned(CboInstances) then
    SelectedInstance := Trim(CboInstances.Text);

  if (SelectedInstance = '') or (CboInstances.Items.Count = 0) then
    SelectedInstance := '.\SQLEXPRESS';

  Result := SelectedInstance;
end;

// ---------------------------
// Devuelve si se detectaron instancias reales
// ---------------------------
function HaveRealInstancesDetected: Boolean;
begin
  Result := GHasInstances;  // ← corregido
end;