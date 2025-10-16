using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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

        
        private SqlConnection Conexion490WC = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionBD490WC"].ConnectionString);
        private GestorConexion490WC()
        {
            
            Conexion490WC = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionBD490WC"].ConnectionString);
        }
        public SqlConnection DevolverConexion490WC()
        {
            
            Conexion490WC = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionBD490WC"].ConnectionString);
            return Conexion490WC;
        }

        public void AbrirConexion490WC()
        {
            
            if (Conexion490WC.ConnectionString == string.Empty) Conexion490WC = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionBD490WC"].ConnectionString);
            Conexion490WC.Open();
        }

        public void CerrarConexion490WC() { Conexion490WC.Close(); }
    }
}
