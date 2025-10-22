# list_sql_instances.ps1
$ErrorActionPreference = "SilentlyContinue"
try { Add-Type -AssemblyName System.Data } catch {}

$hostn  = $env:COMPUTERNAME
$result = New-Object System.Collections.Generic.List[string]

try {
  # Leer la clave de instancias SQL
  $instances = Get-ItemProperty 'HKLM:\SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL' -ErrorAction SilentlyContinue
  if ($instances) {
    # Solo las propiedades que representan instancias reales
    $names = $instances.PSObject.Properties |
      Where-Object { $_.Name -notmatch '^PS' } |
      Select-Object -ExpandProperty Name

    foreach ($n in $names) {
      if ($n -eq 'MSSQLSERVER') {
        $result.Add('.')     | Out-Null
        $result.Add($hostn)  | Out-Null
      }
      elseif ($n) {
        $result.Add(".\$n")      | Out-Null
        $result.Add("$hostn\$n") | Out-Null
      }
    }
  }
} catch {}

# Guardar el resultado en un archivo al lado del script
$result |
  Where-Object { $_ -and $_.Trim() -ne '' } |
  Sort-Object -Unique |
  Set-Content -Path (Join-Path $PSScriptRoot 'sql_instances.txt') -Encoding ASCII
