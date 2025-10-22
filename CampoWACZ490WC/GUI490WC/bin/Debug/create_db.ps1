param(
    [string]$Server = ".\SQLEXPRESS",
    [string]$DbName = "BD_PROYECTO_2025490WC",
    [string]$AppCfg = "",
    [string]$JsonPath = ""
)

Write-Host "=== Script de instalación de base de datos ===" -ForegroundColor Cyan

try {
    # Validar parámetros obligatorios
    if (-not $Server -or -not $DbName) {
        throw "Faltan parámetros obligatorios (Server o DbName)."
    }

    if (-not $JsonPath -or [string]::IsNullOrWhiteSpace($JsonPath)) {
        $JsonPath = Join-Path (Split-Path $MyInvocation.MyCommand.Definition) "config.json"
        Write-Host "Ruta JSON no especificada. Se usará: $JsonPath" -ForegroundColor Yellow
    }

    Write-Host "Conectando al servidor: $Server" -ForegroundColor Cyan
    $connectionString = "Server=$Server;Integrated Security=True"
    $connection = New-Object System.Data.SqlClient.SqlConnection $connectionString
    $connection.Open()
    Write-Host "Conexión establecida correctamente con el servidor." -ForegroundColor Green

    # Crear base de datos si no existe
    Write-Host "Creando base de datos si no existe..."
    $cmd = $connection.CreateCommand()
    $cmd.CommandText = "IF NOT EXISTS(SELECT name FROM sys.databases WHERE name = '$DbName') CREATE DATABASE [$DbName];"
    $cmd.ExecuteNonQuery()
    $connection.Close()

    # Crear cadena de conexión final
    $connString = "Data Source=$Server;Initial Catalog=$DbName;Integrated Security=True;"

    # Crear archivo JSON con la cadena
    $json = @{
        "ConnectionStrings" = @{
            "DefaultConnection" = $connString
        }
    } | ConvertTo-Json -Depth 5

    Write-Host "Generando archivo JSON en: $JsonPath"
    Set-Content -Path $JsonPath -Value $json -Encoding UTF8

    Write-Host "Archivo config.json generado exitosamente." -ForegroundColor Green
    Write-Host "=== Proceso completado correctamente ===" -ForegroundColor Cyan
}
catch {
    Write-Host "❌ Error: $($_.Exception.Message)" -ForegroundColor Red
    
}

finally {
  # --- 9️⃣ Generar config.json (aunque haya fallado algo) ---
  if ($JsonPath -and $JsonPath.Trim() -ne "") {
    try {
      $dir = Split-Path $JsonPath -Parent
      if (-not (Test-Path $dir)) { New-Item -Path $dir -ItemType Directory -Force | Out-Null }

      $obj = @{
        ConnectionString = $connString
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
