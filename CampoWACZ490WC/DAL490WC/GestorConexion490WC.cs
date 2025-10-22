using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DAL490WC
{
    public class GestorConexion490WC
    {

        private static GestorConexion490WC Instancia490WC;

        public static GestorConexion490WC GestorCone490WC
        {
            get
            {
                if (Instancia490WC == null) { Instancia490WC = new GestorConexion490WC(); }
                return Instancia490WC;
            }
        }

        public string ObtenerStringConexion()
        {
            try
            {
                string exePath = Environment.GetCommandLineArgs()[0];
                if (string.IsNullOrEmpty(exePath))
                    exePath = Process.GetCurrentProcess().MainModule != null
                        ? Process.GetCurrentProcess().MainModule.FileName
                        : null;
                if (string.IsNullOrEmpty(exePath))
                    throw new InvalidOperationException("No se pudo resolver la ruta del ejecutable.");
                string baseDir = Path.GetDirectoryName(exePath);
                string path = Path.Combine(baseDir, "config.json");

                if (!File.Exists(path))
                    throw new FileNotFoundException("No se encontró config.json", path);
                string json = File.ReadAllText(path);
                var serializer = new JavaScriptSerializer();
                var data = serializer.Deserialize<Dictionary<string, object>>(json);
                if (data == null || !data.ContainsKey("ConnectionString"))
                    throw new InvalidDataException("config.json inválido o sin 'ConnectionString'.");
                string cs = Convert.ToString(data["ConnectionString"]);
                if (string.IsNullOrWhiteSpace(cs))
                    throw new InvalidDataException("El campo 'ConnectionString' está vacío o no válido.");
                return cs;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la cadena de conexión: " + ex.Message, ex);
            }
        }

        //private SqlConnection Conexion490WC = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionBD490WC"].ConnectionString);
        private SqlConnection Conexion490WC ;
        private GestorConexion490WC()
        {
            //Conexion490WC = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionBD490WC"].ConnectionString);
            Conexion490WC = new SqlConnection(ObtenerStringConexion());
        }
        public SqlConnection DevolverConexion490WC()
        {
            
            //Conexion490WC = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionBD490WC"].ConnectionString);
            Conexion490WC = new SqlConnection(ObtenerStringConexion());
            return Conexion490WC;
        }

        public void AbrirConexion490WC()
        {
            
            if (Conexion490WC.ConnectionString == string.Empty) Conexion490WC = new SqlConnection(ObtenerStringConexion());
            Conexion490WC.Open();
        }

        public void CerrarConexion490WC() { Conexion490WC.Close(); }
    }
}
