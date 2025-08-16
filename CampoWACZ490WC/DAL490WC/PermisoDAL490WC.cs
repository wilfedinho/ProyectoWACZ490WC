using SE490WC;
using SERVICIOS490WC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL490WC
{
    public class PermisoDAL490WC
    {
        
      
        public List<PermisoCompuesto490WC> LeerFamiliasConEstructuraRecursiva490WC()
        {
            Dictionary<string, PermisoCompuesto490WC> familiasDiccionario = new Dictionary<string,PermisoCompuesto490WC>();
            Dictionary<string, PermisoSimple490WC> permisosSimplesDiccionario = new Dictionary<string, PermisoSimple490WC>();

            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                
                string querySimples = "SELECT Nombre490WC FROM PermisoSimple490WC";
                using (SqlCommand cmd = new SqlCommand(querySimples, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombre = lector["Nombre490WC"].ToString();
                        permisosSimplesDiccionario[nombre] = new PermisoSimple490WC(nombre);
                    }
                }

                
                string queryFamilias = "SELECT Nombre490WC FROM Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryFamilias, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombre = lector["Nombre490WC"].ToString();
                        familiasDiccionario[nombre] = new PermisoCompuesto490WC(nombre);
                    }
                }

                
                string queryRelPS = "SELECT NombreFamilia490WC, NombrePermisoSimple490WC FROM PermisoSimple_Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryRelPS, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombreFamilia = lector["NombreFamilia490WC"].ToString();
                        string nombrePermiso = lector["NombrePermisoSimple490WC"].ToString();

                        if (familiasDiccionario.TryGetValue(nombreFamilia, out var familia) &&
                            permisosSimplesDiccionario.TryGetValue(nombrePermiso, out var permisoSimple))
                        {
                            familia.Agregar490WC(permisoSimple);
                        }
                    }
                }

                
                string queryRelFF = "SELECT NombreFamiliaIncluye490WC, NombreFamiliaIncluida490WC FROM Familia_Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryRelFF, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string padre = lector["NombreFamiliaIncluye490WC"].ToString();
                        string hija = lector["NombreFamiliaIncluida490WC"].ToString();

                        if (familiasDiccionario.TryGetValue(padre, out var familiaPadre) && familiasDiccionario.TryGetValue(hija, out var familiaHija))
                        {
                            familiaPadre.Agregar490WC(familiaHija);
                        }
                    }
                }
            }

            return familiasDiccionario.Values.ToList();
        }

        public PermisoCompuesto490WC LeerRolConEstructura490WC(string nombrePerfil)
        {
            Dictionary<string, PermisoCompuesto490WC> familiasDiccionario = new Dictionary<string, PermisoCompuesto490WC>();
            Dictionary<string, PermisoSimple490WC> permisosSimplesDiccionario = new Dictionary<string, PermisoSimple490WC>();
            PermisoCompuesto490WC perfilTemporal = null;

            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                
                string queryPerfil = "SELECT COUNT(*) FROM Perfil490WC WHERE Nombre490WC = @nombre";
                using (SqlCommand cmd = new SqlCommand(queryPerfil, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombrePerfil);
                    int esPerfil = (int)cmd.ExecuteScalar();

                    if (esPerfil == 0)
                        return null; 
                }

                
                string querySimples = "SELECT Nombre490WC FROM PermisoSimple490WC";
                using (SqlCommand cmd = new SqlCommand(querySimples, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombre = lector["Nombre490WC"].ToString();
                        permisosSimplesDiccionario[nombre] = new PermisoSimple490WC(nombre);
                    }
                }

                
                string queryFamilias = "SELECT Nombre490WC FROM Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryFamilias, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombre = lector["Nombre490WC"].ToString();
                        familiasDiccionario[nombre] = new PermisoCompuesto490WC(nombre);
                    }
                }

               
                string queryRelPS = "SELECT NombreFamilia490WC, NombrePermisoSimple490WC FROM PermisoSimple_Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryRelPS, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombreFamilia = lector["NombreFamilia490WC"].ToString();
                        string nombrePermiso = lector["NombrePermisoSimple490WC"].ToString();

                        if (familiasDiccionario.TryGetValue(nombreFamilia, out var familia) &&
                            permisosSimplesDiccionario.TryGetValue(nombrePermiso, out var permisoSimple))
                        {
                            familia.Agregar490WC(permisoSimple);
                        }
                    }
                }

                
                string queryRelFF = "SELECT NombreFamiliaIncluye490WC, NombreFamiliaIncluida490WC FROM Familia_Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryRelFF, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombrePadre = lector["NombreFamiliaIncluye490WC"].ToString();
                        string nombreHija = lector["NombreFamiliaIncluida490WC"].ToString();

                        if (familiasDiccionario.TryGetValue(nombrePadre, out var padre) &&
                            familiasDiccionario.TryGetValue(nombreHija, out var hija))
                        {
                            padre.Agregar490WC(hija);
                        }
                    }
                }

                
                perfilTemporal = new PermisoCompuesto490WC(nombrePerfil);

               
                string querySimplesPerfil = "SELECT NombrePermisoSimple490WC FROM PermisoSimple_Perfil490WC WHERE NombrePerfil490WC = @nombre";
                using (SqlCommand cmd = new SqlCommand(querySimplesPerfil, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombrePerfil);
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string nombrePermiso = lector["NombrePermisoSimple490WC"].ToString();
                            if (permisosSimplesDiccionario.TryGetValue(nombrePermiso, out var permisoSimple))
                            {
                                perfilTemporal.Agregar490WC(permisoSimple);
                            }
                        }
                    }
                }

               
                string queryFamiliasPerfil = "SELECT NombreFamilia490WC FROM Perfil_Familia490WC WHERE NombrePerfil490WC = @nombre";
                using (SqlCommand cmd = new SqlCommand(queryFamiliasPerfil, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombrePerfil);
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string nombreFamilia = lector["NombreFamilia490WC"].ToString();
                            if (familiasDiccionario.TryGetValue(nombreFamilia, out var familia))
                            {
                                perfilTemporal.Agregar490WC(familia);
                            }
                        }
                    }
                }
            }

            return perfilTemporal;
        }



        public PermisoCompuesto490WC LeerPermisoCompuesto490WC(string nombreCompuesto490WC)
        {
            Dictionary<string, PermisoCompuesto490WC> familiasDiccionario = new Dictionary<string, PermisoCompuesto490WC>();
            Dictionary<string, PermisoSimple490WC> permisosSimplesDiccionario = new Dictionary<string, PermisoSimple490WC>();
            PermisoCompuesto490WC perfilTemporal = null;

            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                
                string querySimples = "SELECT Nombre490WC FROM PermisoSimple490WC";
                using (SqlCommand cmd = new SqlCommand(querySimples, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombre = lector["Nombre490WC"].ToString();
                        permisosSimplesDiccionario[nombre] = new PermisoSimple490WC(nombre);
                    }
                }

                
                string queryFamilias = "SELECT Nombre490WC FROM Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryFamilias, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombre = lector["Nombre490WC"].ToString();
                        familiasDiccionario[nombre] = new PermisoCompuesto490WC(nombre);
                    }
                }

                
                string queryRelPS = "SELECT NombreFamilia490WC, NombrePermisoSimple490WC FROM PermisoSimple_Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryRelPS, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombreFamilia = lector["NombreFamilia490WC"].ToString();
                        string nombrePermiso = lector["NombrePermisoSimple490WC"].ToString();

                        if (familiasDiccionario.TryGetValue(nombreFamilia, out var familia) &&
                            permisosSimplesDiccionario.TryGetValue(nombrePermiso, out var permisoSimple))
                        {
                            familia.Agregar490WC(permisoSimple);
                        }
                    }
                }

                
                string queryRelFF = "SELECT NombreFamiliaIncluye490WC, NombreFamiliaIncluida490WC FROM Familia_Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryRelFF, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombrePadre = lector["NombreFamiliaIncluye490WC"].ToString();
                        string nombreHija = lector["NombreFamiliaIncluida490WC"].ToString();

                        if (familiasDiccionario.TryGetValue(nombrePadre, out var padre) &&
                            familiasDiccionario.TryGetValue(nombreHija, out var hija))
                        {
                            padre.Agregar490WC(hija);
                        }
                    }
                }

                
                string queryPerfil = "SELECT COUNT(*) FROM Perfil490WC WHERE Nombre490WC = @nombre";
                using (SqlCommand cmd = new SqlCommand(queryPerfil, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombreCompuesto490WC);
                    int esPerfil = (int)cmd.ExecuteScalar();

                    if (esPerfil > 0)
                    {
                        perfilTemporal = new PermisoCompuesto490WC(nombreCompuesto490WC);

                        
                        string querySimplesPerfil = "SELECT NombrePermisoSimple490WC FROM PermisoSimple_Perfil490WC WHERE NombrePerfil490WC = @nombre";
                        using (SqlCommand cmdSimples = new SqlCommand(querySimplesPerfil, conexion))
                        {
                            cmdSimples.Parameters.AddWithValue("@nombre", nombreCompuesto490WC);
                            using (SqlDataReader lector = cmdSimples.ExecuteReader())
                            {
                                while (lector.Read())
                                {
                                    string nombrePermiso = lector["NombrePermisoSimple490WC"].ToString();
                                    if (permisosSimplesDiccionario.TryGetValue(nombrePermiso, out var permisoSimple))
                                    {
                                        perfilTemporal.Agregar490WC(permisoSimple);
                                    }
                                }
                            }
                        }

                        
                        string queryFamiliasPerfil = "SELECT NombreFamilia490WC FROM Perfil_Familia490WC WHERE NombrePerfil490WC = @nombre";
                        using (SqlCommand cmdFamilias = new SqlCommand(queryFamiliasPerfil, conexion))
                        {
                            cmdFamilias.Parameters.AddWithValue("@nombre", nombreCompuesto490WC);
                            using (SqlDataReader lector = cmdFamilias.ExecuteReader())
                            {
                                while (lector.Read())
                                {
                                    string nombreFamilia = lector["NombreFamilia490WC"].ToString();
                                    if (familiasDiccionario.TryGetValue(nombreFamilia, out var familia))
                                    {
                                        perfilTemporal.Agregar490WC(familia);
                                    }
                                }
                            }
                        }

                        return perfilTemporal;
                    }
                }
            }

           
            if (familiasDiccionario.TryGetValue(nombreCompuesto490WC, out var familiaRaiz))
            {
                return familiaRaiz;
            }

            return null;
        }


        public bool InsertarFamilia490WC(PermisoCompuesto490WC familiaNueva)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    
                    string insertFamilia = "INSERT INTO Familia490WC (Nombre490WC) VALUES (@nombre)";
                    using (SqlCommand cmd = new SqlCommand(insertFamilia, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", familiaNueva.obtenerPermisoNombre490WC());
                        cmd.ExecuteNonQuery();
                    }

                    
                    foreach (var hijo in familiaNueva.PermisosIncluidos490WC())
                    {
                        if (hijo is PermisoSimple490WC simple)
                        {
                            string insertRelacion = "INSERT INTO PermisoSimple_Familia490WC (NombreFamilia490WC, NombrePermisoSimple490WC) VALUES (@familia, @simple)";
                            using (SqlCommand cmd = new SqlCommand(insertRelacion, conexion))
                            {
                                cmd.Parameters.AddWithValue("@familia", familiaNueva.obtenerPermisoNombre490WC());
                                cmd.Parameters.AddWithValue("@simple", simple.obtenerPermisoNombre490WC());
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (hijo is PermisoCompuesto490WC subfamilia)
                        {
                            string insertRelacion = "INSERT INTO Familia_Familia490WC (NombreFamiliaIncluye490WC, NombreFamiliaIncluida490WC) VALUES (@padre, @hija)";
                            using (SqlCommand cmd = new SqlCommand(insertRelacion, conexion))
                            {
                                cmd.Parameters.AddWithValue("@padre", familiaNueva.obtenerPermisoNombre490WC());
                                cmd.Parameters.AddWithValue("@hija", subfamilia.obtenerPermisoNombre490WC());
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool InsertarRol490WC(PermisoCompuesto490WC nuevoRol)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    
                    string insertPerfil = "INSERT INTO Perfil490WC (Nombre490WC) VALUES (@nombre)";
                    using (SqlCommand cmd = new SqlCommand(insertPerfil, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nuevoRol.obtenerPermisoNombre490WC());
                        cmd.ExecuteNonQuery();
                    }

                    
                    foreach (var hijo in nuevoRol.PermisosIncluidos490WC())
                    {
                        if (hijo is PermisoSimple490WC simple)
                        {
                            string insertRelacion = "INSERT INTO PermisoSimple_Perfil490WC (NombrePerfil490WC, NombrePermisoSimple490WC) VALUES (@perfil, @simple)";
                            using (SqlCommand cmd = new SqlCommand(insertRelacion, conexion))
                            {
                                cmd.Parameters.AddWithValue("@perfil", nuevoRol.obtenerPermisoNombre490WC());
                                cmd.Parameters.AddWithValue("@simple", simple.obtenerPermisoNombre490WC());
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (hijo is PermisoCompuesto490WC familia)
                        {
                            string insertRelacion = "INSERT INTO Perfil_Familia490WC (NombrePerfil490WC, NombreFamilia490WC) VALUES (@perfil, @familia)";
                            using (SqlCommand cmd = new SqlCommand(insertRelacion, conexion))
                            {
                                cmd.Parameters.AddWithValue("@perfil", nuevoRol.obtenerPermisoNombre490WC());
                                cmd.Parameters.AddWithValue("@familia", familia.obtenerPermisoNombre490WC());
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool InsertarRelacionDesdePerfil490WC(string nombrePerfil, string nombreIncluido)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    
                    string querySimple = "SELECT COUNT(*) FROM PermisoSimple490WC WHERE Nombre490WC = @nombreIncluido";
                    using (SqlCommand cmd = new SqlCommand(querySimple, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombreIncluido", nombreIncluido);
                        if ((int)cmd.ExecuteScalar() > 0)
                        {
                            string insert = "INSERT INTO PermisoSimple_Perfil490WC (NombrePerfil490WC, NombrePermisoSimple490WC) VALUES (@perfil, @simple)";
                            using (SqlCommand insertCmd = new SqlCommand(insert, conexion))
                            {
                                insertCmd.Parameters.AddWithValue("@perfil", nombrePerfil);
                                insertCmd.Parameters.AddWithValue("@simple", nombreIncluido);
                                insertCmd.ExecuteNonQuery();
                                return true;
                            }
                        }
                    }

                    
                    string queryFamilia = "SELECT COUNT(*) FROM Familia490WC WHERE Nombre490WC = @nombreIncluido";
                    using (SqlCommand cmd = new SqlCommand(queryFamilia, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombreIncluido", nombreIncluido);
                        if ((int)cmd.ExecuteScalar() > 0)
                        {
                            string insert = "INSERT INTO Perfil_Familia490WC (NombrePerfil490WC, NombreFamilia490WC) VALUES (@perfil, @familia)";
                            using (SqlCommand insertCmd = new SqlCommand(insert, conexion))
                            {
                                insertCmd.Parameters.AddWithValue("@perfil", nombrePerfil);
                                insertCmd.Parameters.AddWithValue("@familia", nombreIncluido);
                                insertCmd.ExecuteNonQuery();
                                return true;
                            }
                        }
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }
        }


        public bool InsertarRelacionDesdeFamilia490WC(string nombreFamilia, string nombreIncluido)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    
                    string querySimple = "SELECT COUNT(*) FROM PermisoSimple490WC WHERE Nombre490WC = @nombreIncluido";
                    using (SqlCommand cmd = new SqlCommand(querySimple, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombreIncluido", nombreIncluido);
                        if ((int)cmd.ExecuteScalar() > 0)
                        {
                            string insert = "INSERT INTO PermisoSimple_Familia490WC (NombreFamilia490WC, NombrePermisoSimple490WC) VALUES (@familia, @simple)";
                            using (SqlCommand insertCmd = new SqlCommand(insert, conexion))
                            {
                                insertCmd.Parameters.AddWithValue("@familia", nombreFamilia);
                                insertCmd.Parameters.AddWithValue("@simple", nombreIncluido);
                                insertCmd.ExecuteNonQuery();
                                return true;
                            }
                        }
                    }

                    
                    string queryFamilia = "SELECT COUNT(*) FROM Familia490WC WHERE Nombre490WC = @nombreIncluido";
                    using (SqlCommand cmd = new SqlCommand(queryFamilia, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombreIncluido", nombreIncluido);
                        if ((int)cmd.ExecuteScalar() > 0)
                        {
                            string insert = "INSERT INTO Familia_Familia490WC (NombreFamiliaIncluye490WC, NombreFamiliaIncluida490WC) VALUES (@padre, @hija)";
                            using (SqlCommand insertCmd = new SqlCommand(insert, conexion))
                            {
                                insertCmd.Parameters.AddWithValue("@padre", nombreFamilia);
                                insertCmd.Parameters.AddWithValue("@hija", nombreIncluido);
                                insertCmd.ExecuteNonQuery();
                                return true;
                            }
                        }
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }
        }




        public bool BorrarFamilia490WC(string nombreFamilia)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    
                    string deleteRelFF = "DELETE FROM Familia_Familia490WC WHERE NombreFamiliaIncluye490WC = @nombre OR NombreFamiliaIncluida490WC = @nombre";
                    using (SqlCommand cmdDelFF = new SqlCommand(deleteRelFF, conexion))
                    {
                        cmdDelFF.Parameters.AddWithValue("@nombre", nombreFamilia);
                        cmdDelFF.ExecuteNonQuery();
                    }

                   
                    string deleteRelPS = "DELETE FROM PermisoSimple_Familia490WC WHERE NombreFamilia490WC = @nombre";
                    using (SqlCommand cmdDelPS = new SqlCommand(deleteRelPS, conexion))
                    {
                        cmdDelPS.Parameters.AddWithValue("@nombre", nombreFamilia);
                        cmdDelPS.ExecuteNonQuery();
                    }

                    
                    string deletePerfilRel = "DELETE FROM Perfil_Familia490WC WHERE NombreFamilia490WC = @nombre";
                    using (SqlCommand cmdDelPerfil = new SqlCommand(deletePerfilRel, conexion))
                    {
                        cmdDelPerfil.Parameters.AddWithValue("@nombre", nombreFamilia);
                        cmdDelPerfil.ExecuteNonQuery();
                    }

                   
                    string deleteFamilia = "DELETE FROM Familia490WC WHERE Nombre490WC = @nombre";
                    using (SqlCommand cmdDel = new SqlCommand(deleteFamilia, conexion))
                    {
                        cmdDel.Parameters.AddWithValue("@nombre", nombreFamilia);
                        cmdDel.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool BorrarRol490WC(string nombreRol)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    Usuario490WC usuarioConRol = UsuarioAccesoDatos490WC.UsuarioAccesoDatosSG490WC.DevolverTodosLosUsuarios490WC().Find(x => x.Rol490WC == nombreRol);

                    if (usuarioConRol != null)
                    {
                        return false; 
                    }


                    
                    string deleteRelPS = "DELETE FROM PermisoSimple_Perfil490WC WHERE NombrePerfil490WC = @nombre";
                    using (SqlCommand cmdDelPS = new SqlCommand(deleteRelPS, conexion))
                    {
                        cmdDelPS.Parameters.AddWithValue("@nombre", nombreRol);
                        cmdDelPS.ExecuteNonQuery();
                    }

                   
                    string deleteRelFam = "DELETE FROM Perfil_Familia490WC WHERE NombrePerfil490WC = @nombre";
                    using (SqlCommand cmdDelFam = new SqlCommand(deleteRelFam, conexion))
                    {
                        cmdDelFam.Parameters.AddWithValue("@nombre", nombreRol);
                        cmdDelFam.ExecuteNonQuery();
                    }

                    
                    string deletePerfil = "DELETE FROM Perfil490WC WHERE Nombre490WC = @nombre";
                    using (SqlCommand cmdDel = new SqlCommand(deletePerfil, conexion))
                    {
                        cmdDel.Parameters.AddWithValue("@nombre", nombreRol);
                        cmdDel.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }



        

        public bool FamiliaQuedariaVaciaTrasEliminarElemento(string nombreFamilia, string nombreElemento)
        {
            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                
                string querySimples = "SELECT COUNT(*) FROM PermisoSimple_Familia490WC WHERE NombreFamilia490WC = @familia AND NombrePermisoSimple490WC <> @elemento";

                using (SqlCommand cmd = new SqlCommand(querySimples, conexion))
                {
                    cmd.Parameters.AddWithValue("@familia", nombreFamilia);
                    cmd.Parameters.AddWithValue("@elemento", nombreElemento);

                    int countSimples = (int)cmd.ExecuteScalar();
                    if (countSimples > 0)
                        return false; 
                }

               
                string queryFamilias = "SELECT COUNT(*) FROM Familia_Familia490WC WHERE NombreFamiliaIncluye490WC = @familia AND NombreFamiliaIncluida490WC <> @elemento";

                using (SqlCommand cmd = new SqlCommand(queryFamilias, conexion))
                {
                    cmd.Parameters.AddWithValue("@familia", nombreFamilia);
                    cmd.Parameters.AddWithValue("@elemento", nombreElemento);

                    int countFamilias = (int)cmd.ExecuteScalar();
                    if (countFamilias > 0)
                        return false; 
                }

                
                return true;
            }
        }


        public bool PerfilQuedariaVacioTrasEliminarElemento(string nombrePerfil, string nombreElemento)
        {
            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                
                string queryFamilias = "SELECT COUNT(*) FROM Perfil_Familia490WC WHERE NombrePerfil490WC = @perfil AND NombreFamilia490WC <> @elemento";

                using (SqlCommand cmd = new SqlCommand(queryFamilias, conexion))
                {
                    cmd.Parameters.AddWithValue("@perfil", nombrePerfil);
                    cmd.Parameters.AddWithValue("@elemento", nombreElemento);

                    int countFamilias = (int)cmd.ExecuteScalar();
                    if (countFamilias > 0)
                        return false; 
                }

               
                string querySimples = "SELECT COUNT(*) FROM PermisoSimple_Perfil490WC WHERE NombrePerfil490WC = @perfil AND NombrePermisoSimple490WC <> @elemento";

                using (SqlCommand cmd = new SqlCommand(querySimples, conexion))
                {
                    cmd.Parameters.AddWithValue("@perfil", nombrePerfil);
                    cmd.Parameters.AddWithValue("@elemento", nombreElemento);

                    int countSimples = (int)cmd.ExecuteScalar();
                    if (countSimples > 0)
                        return false; 
                }

               
                return true;
            }
        }



        public bool EliminarRelacionPermisoSimple_Perfil(string nombrePerfil, string nombrePermisoSimple)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    string query = "DELETE FROM PermisoSimple_Perfil490WC WHERE NombrePerfil490WC = @perfil AND NombrePermisoSimple490WC = @permiso";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@perfil", nombrePerfil);
                        cmd.Parameters.AddWithValue("@permiso", nombrePermisoSimple);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarRelacionPermisoSimple_Familia(string nombreFamilia, string nombrePermisoSimple)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    string query = "DELETE FROM PermisoSimple_Familia490WC WHERE NombreFamilia490WC = @familia AND NombrePermisoSimple490WC = @permiso";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@familia", nombreFamilia);
                        cmd.Parameters.AddWithValue("@permiso", nombrePermisoSimple);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarRelacionFamilia_Familia(string familiaPadre, string familiaHija)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    string query = "DELETE FROM Familia_Familia490WC WHERE NombreFamiliaIncluye490WC = @padre AND NombreFamiliaIncluida490WC = @hija";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@padre", familiaPadre);
                        cmd.Parameters.AddWithValue("@hija", familiaHija);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarRelacionPerfil_Familia(string nombrePerfil, string nombreFamilia)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    string query = "DELETE FROM Perfil_Familia490WC WHERE nombrePerfil490WC = @perfil AND nombreFamilia490WC = @familia";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@perfil", nombrePerfil);
                        cmd.Parameters.AddWithValue("@familia", nombreFamilia);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


     

        public bool FamiliaExiste490WC(string nombreFamilia)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    string query = "SELECT COUNT(*) FROM Familia490WC WHERE Nombre490WC = @nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombreFamilia);
                        int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                        return cantidad > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public bool PerfilExiste490WC(string nombrePerfil)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    string query = "SELECT COUNT(*) FROM Perfil490WC WHERE Nombre490WC = @nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombrePerfil);
                        int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                        return cantidad > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public bool RolEstaAsignado490WC(string nombreRol490WC)
        {
            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                string query = "SELECT COUNT(*) FROM Usuario490WC WHERE Rol490WC = @rol";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@rol", nombreRol490WC);
                    int cantidad = (int)cmd.ExecuteScalar();
                    return cantidad > 0;
                }
            }
        }

        public bool FamiliaEstaAsignadaAPerfil490WC(string nombreFamilia490WC)
        {
            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                string query = "SELECT COUNT(*) FROM Perfil_Familia490WC WHERE NombreFamilia490WC = @familia";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@familia", nombreFamilia490WC);
                    int cantidad = (int)cmd.ExecuteScalar();
                    return cantidad > 0;
                }
            }
        }

        public bool FamiliaEstaAnidadaEnOtra490WC(string nombreFamilia490WC)
        {
            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                string query = "SELECT COUNT(*) FROM Familia_Familia490WC WHERE NombreFamiliaIncluida490WC = @familia";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@familia", nombreFamilia490WC);
                    int cantidad = (int)cmd.ExecuteScalar();
                    return cantidad > 0;
                }
            }
        }


        


     
        public List<Permiso490WC> ObtenerPermisosSimples490WC()
        {
            List<Permiso490WC> ListaPermisos490WC = new List<Permiso490WC>();

            try
            {
                using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion490WC.Open();

                   
                    string query = "SELECT Nombre490WC FROM PermisoSimple490WC";

                    using (SqlCommand cmd = new SqlCommand(query, conexion490WC))
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string nombre = lector["Nombre490WC"].ToString();
                            ListaPermisos490WC.Add(new PermisoSimple490WC(nombre));
                        }
                    }
                }

                return ListaPermisos490WC;
            }
            catch
            {
                ListaPermisos490WC.Clear();
                return ListaPermisos490WC;
            }
        }


        

        public List<Permiso490WC> ObtenerPermisosCompuestos490WC()
        {
            List<Permiso490WC> ListaPermisosCompuestos490WC = new List<Permiso490WC>();

            try
            {
                using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion490WC.Open();

                    
                    string query = "SELECT Nombre490WC FROM Familia490WC";

                    using (SqlCommand cmd = new SqlCommand(query, conexion490WC))
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string nombre = lector["Nombre490WC"].ToString();
                            ListaPermisosCompuestos490WC.Add(new PermisoCompuesto490WC(nombre));
                        }
                    }
                }

                return ListaPermisosCompuestos490WC;
            }
            catch
            {
                ListaPermisosCompuestos490WC.Clear();
                return ListaPermisosCompuestos490WC;
            }
        }



        public List<Permiso490WC> ObtenerRoles490WC()
        {
            List<Permiso490WC> ListaRoles490WC = new List<Permiso490WC>();

            try
            {
                using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion490WC.Open();

                    string query = "SELECT Nombre490WC FROM Perfil490WC";

                    using (SqlCommand cmd = new SqlCommand(query, conexion490WC))
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string nombre = lector["Nombre490WC"].ToString();
                            ListaRoles490WC.Add(new PermisoCompuesto490WC(nombre));
                        }
                    }
                }

                return ListaRoles490WC;
            }
            catch
            {
                ListaRoles490WC.Clear();
                return ListaRoles490WC;
            }
        }


    }
}
