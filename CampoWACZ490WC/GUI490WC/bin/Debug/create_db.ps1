param(
  [string]$Server = ".\SQLEXPRESS",
  [string]$DbName = "proyecto_is",
  [string]$AppCfg = "$env:ProgramFiles\Barberia SANSATECH\Release\GUI.exe.config",
  [string]$ConnStr,                         # ← opcional: si viene desde el .iss, lo usamos
  [string]$JsonPath = "$env:ProgramFiles\Barberia SANSATECH\config.json"  # ← opcional
)

$ErrorActionPreference = "Stop"

Add-Type -AssemblyName "System.Data"

# --- Detectar ruta válida del .config ---
if (-not (Test-Path $AppCfg)) {
  $AppCfg = "$env:ProgramFiles (x86)\Barberia SANSATECH\Release\GUI.exe.config"
}
Write-Host "Usando config en: $AppCfg"

# --- 0) Armar/normalizar connection strings ---
# Si no vino -ConnStr, lo armamos con Encrypt=False como pediste para configuración de app/JSON
if (-not $ConnStr -or $ConnStr.Trim() -eq "") {
  $ConnStr = "Data Source=$Server;Initial Catalog=$DbName;Integrated Security=True;Encrypt=False"
}

# Para conectarnos vía .NET (master y DB), agregamos TrustServerCertificate=True si no está
function Add-TrustServerCertIfMissing([string]$cs) {
  if ($cs -notmatch '(?i)TrustServerCertificate\s*=\s*(True|False)') {
    return $cs + ';TrustServerCertificate=True'
  }
  return $cs
}

# Derivamos csDb y csMaster a partir de $ConnStr
$csDb = $ConnStr
# Reemplazar Initial Catalog por master (si no existe, lo agregamos)
$csMaster = [regex]::Replace($csDb, '(?i)Initial\s*Catalog\s*=\s*[^;]+', 'Initial Catalog=master', 1)
if ($csMaster -eq $csDb) { $csMaster = $csDb + ';Initial Catalog=master' }

$csDbConn     = Add-TrustServerCertIfMissing $csDb
$csMasterConn = Add-TrustServerCertIfMissing $csMaster

try {
  # --- 1) Crear BD si no existe ---
  Write-Host "Creando base de datos si no existe..."
  $cnMaster = New-Object System.Data.SqlClient.SqlConnection($csMasterConn)
  $cnMaster.Open()
  $cmd = $cnMaster.CreateCommand()
  $cmd.CommandText = "IF DB_ID('$DbName') IS NULL BEGIN CREATE DATABASE [$DbName]; END"
  $cmd.ExecuteNonQuery() | Out-Null
  $cnMaster.Close()

  # --- 2) Ejecutar script de tablas/datos ---
  $script = Join-Path $PSScriptRoot "script.sql"
  if (Test-Path $script) {
    Write-Host "Ejecutando script.sql..."
    $cnDb = New-Object System.Data.SqlClient.SqlConnection($csDbConn)
    $cnDb.Open()
    $sql = Get-Content $script -Raw

    # Split robusto (detecta GO en may/min, con o sin saltos de línea)
param(
  [string]$Server = ".\SQLEXPRESS",
  [string]$DbName = "proyecto_is",
  [string]$AppCfg = "$env:ProgramFiles\Barberia SANSATECH\Release\GUI.exe.config",
  [string]$ConnStr,
  [string]$JsonPath = "$env:ProgramFiles\Barberia SANSATECH\config.json"
)

$ErrorActionPreference = "Stop"

Add-Type -AssemblyName "System.Data"

# --- Detectar ruta válida del .config ---
if (-not (Test-Path $AppCfg)) {
  $AppCfg = "$env:ProgramFiles (x86)\Barberia SANSATECH\Release\GUI.exe.config"
}
Write-Host "Usando config en: $AppCfg"

# --- Normalizar connection string ---
if (-not $ConnStr -or $ConnStr.Trim() -eq "") {
  $ConnStr = "Data Source=$Server;Initial Catalog=$DbName;Integrated Security=True;Encrypt=False"
}

function Add-TrustServerCertIfMissing([string]$cs) {
  if ($cs -notmatch '(?i)TrustServerCertificate\s*=\s*(True|False)') {
    return $cs + ';TrustServerCertificate=True'
  }
  return $cs
}

$csDb = $ConnStr
$csMaster = [regex]::Replace($csDb, '(?i)Initial\s*Catalog\s*=\s*[^;]+', 'Initial Catalog=master', 1)
if ($csMaster -eq $csDb) { $csMaster = $csDb + ';Initial Catalog=master' }

$csDbConn     = Add-TrustServerCertIfMissing $csDb
$csMasterConn = Add-TrustServerCertIfMissing $csMaster

try {
  # --- 1️⃣ Crear BD si no existe ---
  Write-Host "Creando base de datos si no existe..."
  $cnMaster = New-Object System.Data.SqlClient.SqlConnection($csMasterConn)
  $cnMaster.Open()
  $cmd = $cnMaster.CreateCommand()
  $cmd.CommandText = "IF DB_ID('$DbName') IS NULL BEGIN CREATE DATABASE [$DbName]; END"
  $cmd.ExecuteNonQuery() | Out-Null
  $cnMaster.Close()

  # --- 2️⃣ Ejecutar script SQL ---
  $script = Join-Path $PSScriptRoot "script.sql"
  if (Test-Path $script) {
    Write-Host "Ejecutando script.sql..."
    $cnDb = New-Object System.Data.SqlClient.SqlConnection($csDbConn)
    $cnDb.Open()
    $sql = Get-Content $script -Raw

    $bloques = [regex]::Split($sql, '^\s*GO\s*$(\r?\n)?', 'IgnoreCase, Multiline')
    foreach ($t in $bloques) {
      $t = $t.Trim()
      if ($t.Length -gt 0) {
        try {
          $cmd = $cnDb.CreateCommand()
          $cmd.CommandText = $t
          $cmd.ExecuteNonQuery() | Out-Null
        } catch {
          Write-Host "⚠️ Error ejecutando bloque SQL: $($_.Exception.Message)"
        }
      }
    }
    $cnDb.Close()
  } else {
    Write-Host "❌ No se encontró script.sql en $PSScriptRoot"
  }

  # --- 3️⃣ Escribir connectionString en app.config ---
  if (Test-Path $AppCfg) {
    Write-Host "Actualizando connectionString en $AppCfg"
    [xml]$xml = Get-Content $AppCfg

    if (-not $xml.configuration) {
      $root = $xml.CreateElement("configuration")
      $xml.AppendChild($root) | Out-Null
    }

    if (-not $xml.configuration.connectionStrings) {
      $csNode = $xml.CreateElement("connectionStrings")
      $xml.configuration.AppendChild($csNode) | Out-Null
    }

    $node = $xml.configuration.connectionStrings.add | Where-Object { $_.name -eq 'DefaultConnection' }
    if (-not $node) {
      $node = $xml.CreateElement("add")
      $node.SetAttribute("name", "DefaultConnection")
      $xml.configuration.connectionStrings.AppendChild($node) | Out-Null
    }

    $node.SetAttribute("connectionString", $ConnStr)
    $xml.Save($AppCfg)
    Write-Host "✅ Connection string escrita correctamente en app.config."
  } else {
    Write-Host "⚠️ No se encontró el archivo .config en: $AppCfg"
  }

  # --- 4️⃣ Asignar permisos BUILTIN\Users ---
  Write-Host "Otorgando permisos a BUILTIN\Users..."
  $cnMaster = New-Object System.Data.SqlClient.SqlConnection($csMasterConn)
  $cnMaster.Open()
  $cmd = $cnMaster.CreateCommand()
  $cmd.CommandText = @"
IF NOT EXISTS (SELECT 1 FROM sys.server_principals WHERE name = N'BUILTIN\Users')
    CREATE LOGIN [BUILTIN\Users] FROM WINDOWS;
"@
  $cmd.ExecuteNonQuery() | Out-Null
  $cnMaster.Close()

  $cnDb = New-Object System.Data.SqlClient.SqlConnection($csDbConn)
  $cnDb.Open()
  $cmd = $cnDb.CreateCommand()
  $cmd.CommandText = @"
IF NOT EXISTS (SELECT 1 FROM sys.database_principals WHERE name = N'BUILTIN\Users')
    CREATE USER [BUILTIN\Users] FOR LOGIN [BUILTIN\Users];
EXEC sp_addrolemember N'db_datareader', N'BUILTIN\Users';
EXEC sp_addrolemember N'db_datawriter', N'BUILTIN\Users';
EXEC sp_addrolemember N'db_owner',     N'BUILTIN\Users';
"@
  $cmd.ExecuteNonQuery() | Out-Null
  $cnDb.Close()
  Write-Host "✅ Permisos asignados correctamente."

} catch {
  Write-Host "❌ Error general: $($_.Exception.Message)"
  exit 1
}
finally {
  # --- 5️⃣ Generar config.json aunque haya fallado algo ---
  if ($JsonPath -and $JsonPath.Trim() -ne "") {
    try {
      $dir = Split-Path $JsonPath -Parent
      if (-not (Test-Path $dir)) { New-Item -Path $dir -ItemType Directory -Force | Out-Null }

      $obj = @{
        ConnectionString = $ConnStr
        FechaGeneracion  = (Get-Date).ToString("yyyy-MM-dd HH:mm:ss")
        Servidor         = $Server
        BaseDatos        = $DbName
      }

      $json = $obj | ConvertTo-Json -Depth 3
      $json | Set-Content -Path $JsonPath -Encoding UTF8
      Write-Host "✅ JSON generado correctamente en: $JsonPath"
    } catch {
      Write-Host "⚠️ No se pudo escribir config.json: $($_.Exception.Message)"
    }
  }
}
