using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL490WC
{
    public class BackUpRestoreDAL490WC
    {
        private string nombreBaseDatos490WC = "BD_PROYECTO_2025490WC";

        public void RealizarBackUp490WC(string rutaBackup490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = $@"BACKUP DATABASE [{nombreBaseDatos490WC}] TO DISK = '{rutaBackup490WC}'";
                using (SqlCommand cmd490WC = new SqlCommand(query490WC, cone490WC))
                {
                    cmd490WC.ExecuteNonQuery();
                }
            }
        }

        public void RealizarRestore490WC(string rutaRestore490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "USE master;";
                using (SqlCommand cmd490WC = new SqlCommand(query490WC, cone490WC))
                {
                    cmd490WC.ExecuteNonQuery();
                }
                query490WC = $@"ALTER DATABASE [{nombreBaseDatos490WC}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                using (SqlCommand cmd490WC = new SqlCommand(query490WC, cone490WC))
                {
                    cmd490WC.ExecuteNonQuery();
                }
                query490WC = $@"RESTORE DATABASE [{nombreBaseDatos490WC}] FROM DISK = '{rutaRestore490WC}' WITH REPLACE;";
                using (SqlCommand cmd490WC = new SqlCommand(query490WC, cone490WC))
                {
                    cmd490WC.ExecuteNonQuery();
                }
                query490WC = $@"ALTER DATABASE [{nombreBaseDatos490WC}] SET MULTI_USER;";
                using (SqlCommand cmd490WC = new SqlCommand(query490WC, cone490WC))
                {
                    cmd490WC.ExecuteNonQuery();
                }
            }
        }
    }
}
