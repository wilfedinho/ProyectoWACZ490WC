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
        private static PermisoDAL490WC Instancia490WC;
        public static PermisoDAL490WC GestorPermisoORM490WC
        {
            get
            {
                if (Instancia490WC == null)
                {
                    Instancia490WC = new PermisoDAL490WC();
                }
                return Instancia490WC;
            }
        }
        //Para No Marearnos la forma para refactorizar es la siguiente:
        //Funcion NO comentada de arriba es la reemplazante de la comentada que tiene abajo William Cardenas 22-6-25

        public List<PermisoCompuesto490WC> LeerFamiliasConEstructuraRecursiva490WC()
        {
            Dictionary<string, PermisoCompuesto490WC> familiasDiccionario = new Dictionary<string,PermisoCompuesto490WC>();
            Dictionary<string, PermisoSimple490WC> permisosSimplesDiccionario = new Dictionary<string, PermisoSimple490WC>();

            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                
                string querySimples = "SELECT nombre490WC FROM PermisoSimple490WC";
                using (SqlCommand cmd = new SqlCommand(querySimples, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombre = lector["nombre490WC"].ToString();
                        permisosSimplesDiccionario[nombre] = new PermisoSimple490WC(nombre);
                    }
                }

                
                string queryFamilias = "SELECT nombre490WC FROM Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryFamilias, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombre = lector["nombre490WC"].ToString();
                        familiasDiccionario[nombre] = new PermisoCompuesto490WC(nombre);
                    }
                }

                
                string queryRelPS = "SELECT nombreFamilia490WC, nombrePermisoSimple490WC FROM PermisoSimple_Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryRelPS, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombreFamilia = lector["nombreFamilia490WC"].ToString();
                        string nombrePermiso = lector["nombrePermisoSimple490WC"].ToString();

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

                        if (familiasDiccionario.TryGetValue(padre, out var familiaPadre) &&
                            familiasDiccionario.TryGetValue(hija, out var familiaHija))
                        {
                            familiaPadre.Agregar490WC(familiaHija);
                        }
                    }
                }
            }

            return familiasDiccionario.Values.ToList();
        }


        /*   public List<Permiso490WC> LeerPermisosEnArbol490WC()
           {
               List<Permiso490WC> ListaPermiso490WC = new List<Permiso490WC>();
               List<Permiso490WC> PermisosCompuestos490WC = new List<Permiso490WC>();

               try
               {
                   using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                   {
                       conexion490WC.Open();
                       string queryPermisos490WC = "SELECT nombrePermiso490WC, tipoPermiso490WC FROM Permiso490WC";
                       using (SqlCommand comandoPermisos490WC = new SqlCommand(queryPermisos490WC, conexion490WC))
                       using (SqlDataReader lectorPermisos490WC = comandoPermisos490WC.ExecuteReader())
                       {
                           while (lectorPermisos490WC.Read())
                           {
                               string nombre = lectorPermisos490WC["nombrePermiso490WC"].ToString();
                               string tipo = lectorPermisos490WC["tipoPermiso490WC"].ToString();

                               if (tipo == "Compuesto")
                               {
                                   PermisoCompuesto490WC compuesto490WC = new PermisoCompuesto490WC(nombre);
                                   PermisosCompuestos490WC.Add(compuesto490WC);
                                   ListaPermiso490WC.Add(compuesto490WC);
                               }
                               else
                               {
                                   PermisoSimple490WC simple490WC = new PermisoSimple490WC(nombre);
                                   ListaPermiso490WC.Add(simple490WC);
                               }
                           }
                       }
                       string queryRelaciones490WC = "SELECT permisoCompuestoNombre490WC, permisoIncluidoNombre490WC FROM RelacionPermiso490WC";
                       using (SqlCommand comandoRelacion490WC = new SqlCommand(queryRelaciones490WC, conexion490WC))
                       using (SqlDataReader lectorRelacion490WC = comandoRelacion490WC.ExecuteReader())
                       {
                           while (lectorRelacion490WC.Read())
                           {
                               string compuesto = lectorRelacion490WC["permisoCompuestoNombre490WC"].ToString();
                               string incluido = lectorRelacion490WC["permisoIncluidoNombre490WC"].ToString();

                               PermisoCompuesto490WC permisoCompuestoLeido490WC = (PermisoCompuesto490WC)PermisosCompuestos490WC
                                   .Find(p => p.obtenerPermisoNombre490WC() == compuesto);
                               Permiso490WC permisoIncluido490WC = ListaPermiso490WC
                                   .Find(p => p.obtenerPermisoNombre490WC() == incluido);

                               permisoCompuestoLeido490WC?.Agregar490WC(permisoIncluido490WC);
                           }
                       }
                   }

                   return PermisosCompuestos490WC;
               }
               catch
               {
                   PermisosCompuestos490WC.Clear();
                   return ListaPermiso490WC;
               }
           }
        */

        public PermisoCompuesto490WC LeerPermisoCompuesto490WC(string nombreFamiliaRaiz490WC)
        {
            Dictionary<string, PermisoCompuesto490WC> familiasDiccionario = new Dictionary<string, PermisoCompuesto490WC>();
            Dictionary<string, PermisoSimple490WC> permisosSimplesDiccionario = new Dictionary<string, PermisoSimple490WC>();

            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                
                string querySimples = "SELECT nombre490WC FROM PermisoSimple490WC";
                using (SqlCommand cmd = new SqlCommand(querySimples, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombre = lector["nombre490WC"].ToString();
                        permisosSimplesDiccionario[nombre] = new PermisoSimple490WC(nombre);
                    }
                }

                
                string queryFamilias = "SELECT nombre490WC FROM Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryFamilias, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombre = lector["nombre490WC"].ToString();
                        familiasDiccionario[nombre] = new PermisoCompuesto490WC(nombre);
                    }
                }

                
                string queryRelPS = "SELECT nombreFamilia490WC, nombrePermisoSimple490WC FROM PermisoSimple_Familia490WC";
                using (SqlCommand cmd = new SqlCommand(queryRelPS, conexion))
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        string nombreFamilia = lector["nombreFamilia490WC"].ToString();
                        string nombrePermiso = lector["nombrePermisoSimple490WC"].ToString();

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
            }

            
            if (familiasDiccionario.TryGetValue(nombreFamiliaRaiz490WC, out var familiaRaiz))
            {
                return familiaRaiz;
            }

            return null;
        }



        /*   public PermisoCompuesto490WC LeerPermisoCompuesto490WC(string PermisoLeer490WC)
           {
               PermisoCompuesto490WC PermisoLeidoGlobal490WC;
               List<Permiso490WC> listaPermiso490WC = new List<Permiso490WC>();
               List<Permiso490WC> permisosCompuestos490WC = new List<Permiso490WC>();

               try
               {
                   using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                   {
                       conexion490WC.Open();
                       string queryPermisos490WC = "SELECT nombrePermiso490WC, tipoPermiso490WC FROM Permiso490WC";
                       using (SqlCommand comandoPermiso490WC = new SqlCommand(queryPermisos490WC, conexion490WC))
                       using (SqlDataReader lectorPermiso490WC = comandoPermiso490WC.ExecuteReader())
                       {
                           while (lectorPermiso490WC.Read())
                           {
                               string nombre = lectorPermiso490WC["nombrePermiso490WC"].ToString();
                               string tipo = lectorPermiso490WC["tipoPermiso490WC"].ToString();

                               if (tipo == "Compuesto")
                               {
                                   PermisoCompuesto490WC compuesto = new PermisoCompuesto490WC(nombre);
                                   permisosCompuestos490WC.Add(compuesto);
                                   listaPermiso490WC.Add(compuesto);
                               }
                               else
                               {
                                   PermisoSimple490WC simple = new PermisoSimple490WC(nombre);
                                   listaPermiso490WC.Add(simple);
                               }
                           }
                       }
                       string queryRelaciones490WC = "SELECT permisoCompuestoNombre490WC, permisoIncluidoNombre490WC FROM RelacionPermiso490WC";
                       using (SqlCommand comandoRelacion490WC = new SqlCommand(queryRelaciones490WC, conexion490WC))
                       using (SqlDataReader lectorRelacion490WC = comandoRelacion490WC.ExecuteReader())
                       {
                           while (lectorRelacion490WC.Read())
                           {
                               string compuesto = lectorRelacion490WC["permisoCompuestoNombre490WC"].ToString();
                               string incluido = lectorRelacion490WC["permisoIncluidoNombre490WC"].ToString();

                               PermisoCompuesto490WC compuestoLeido = (PermisoCompuesto490WC)permisosCompuestos490WC
                                   .Find(x => x.obtenerPermisoNombre490WC() == compuesto);
                               Permiso490WC incluidoLeido = listaPermiso490WC
                                   .Find(x => x.obtenerPermisoNombre490WC() == incluido);

                               compuestoLeido?.Agregar490WC(incluidoLeido);
                           }
                       }
                   }

                   PermisoLeidoGlobal490WC = (PermisoCompuesto490WC)permisosCompuestos490WC.Find(x => x.obtenerPermisoNombre490WC() == PermisoLeer490WC);

                   return PermisoLeidoGlobal490WC;
               }
               catch
               {
                   permisosCompuestos490WC.Clear();
                   return null;
               }
           }
        */


        public bool InsertarPermiso490WC(Permiso490WC permisoNuevo490WC)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    string query;
                    if (permisoNuevo490WC is PermisoSimple490WC)
                    {
                        query = "INSERT INTO PermisoSimple490WC (nombre490WC) VALUES (@nombre)";
                    }
                    else if (permisoNuevo490WC is PermisoCompuesto490WC)
                    {
                        query = "INSERT INTO Familia490WC (nombre490WC) VALUES (@nombre)";
                    }
                    else
                    {
                        return false; 
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", permisoNuevo490WC.obtenerPermisoNombre490WC());
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


        /*public bool InsertarPermiso490WC(Permiso490WC permisoNuevo490WC, bool esRol490WC)
        {
            try
            {
                using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion490WC.Open();

                    string query490WC = "INSERT INTO Permiso490WC (nombrePermiso490WC, tipoPermiso490WC, esRolPermiso490WC) " +
                                        "VALUES (@nombre, @tipo, @esRol)";

                    using (SqlCommand comando490WC = new SqlCommand(query490WC, conexion490WC))
                    {
                        comando490WC.Parameters.AddWithValue("@nombre", permisoNuevo490WC.obtenerPermisoNombre490WC());
                        comando490WC.Parameters.AddWithValue("@tipo", permisoNuevo490WC is PermisoCompuesto490WC ? "Compuesto" : "Simple");
                        comando490WC.Parameters.AddWithValue("@esRol", esRol490WC ? "True" : "False");

                        comando490WC.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }*/

        public bool InsertarRelacion490WC(string nombreFamilia490WC, string nombreIncluido490WC)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    // 1. Verificar si el incluido es PermisoSimple
                    string queryVerificarSimple = "SELECT COUNT(*) FROM PermisoSimple490WC WHERE Nombre490WC = @nombreIncluido";
                    using (SqlCommand cmdVerificar = new SqlCommand(queryVerificarSimple, conexion))
                    {
                        cmdVerificar.Parameters.AddWithValue("@nombreIncluido", nombreIncluido490WC);
                        int count = (int)cmdVerificar.ExecuteScalar();

                        if (count > 0)
                        {
                            // Insertar en PermisoSimple_Familia490WC
                            string insertSimple = "INSERT INTO PermisoSimple_Familia490WC (NombreFamilia490WC, NombrePermisoSimple490WC) VALUES (@familia, @simple)";
                            using (SqlCommand cmdInsert = new SqlCommand(insertSimple, conexion))
                            {
                                cmdInsert.Parameters.AddWithValue("@familia", nombreFamilia490WC);
                                cmdInsert.Parameters.AddWithValue("@simple", nombreIncluido490WC);
                                cmdInsert.ExecuteNonQuery();
                            }

                            return true;
                        }
                    }

                    // 2. Verificar si el incluido es otra Familia
                    string queryVerificarFamilia = "SELECT COUNT(*) FROM Familia490WC WHERE Nombre490WC = @nombreIncluido";
                    using (SqlCommand cmdVerificar = new SqlCommand(queryVerificarFamilia, conexion))
                    {
                        cmdVerificar.Parameters.AddWithValue("@nombreIncluido", nombreIncluido490WC);
                        int count = (int)cmdVerificar.ExecuteScalar();

                        if (count > 0)
                        {
                            // Insertar en Familia_Familia490WC
                            string insertFamilia = "INSERT INTO Familia_Familia490WC (NombreFamiliaIncluye490WC, NombreFamiliaIncluida490WC) VALUES (@padre, @hija)";
                            using (SqlCommand cmdInsert = new SqlCommand(insertFamilia, conexion))
                            {
                                cmdInsert.Parameters.AddWithValue("@padre", nombreFamilia490WC);
                                cmdInsert.Parameters.AddWithValue("@hija", nombreIncluido490WC);
                                cmdInsert.ExecuteNonQuery();
                            }

                            return true;
                        }
                    }
                }

                // No se encontró ningún tipo de permiso válido
                return false;
            }
            catch
            {
                return false;
            }
        }


        /*public bool InsertarRelacion490WC(string Compuesto490WC, string Incluido490WC)
        {
            try
            {
                using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion490WC.Open();

                    string query490WC = "INSERT INTO RelacionPermiso490WC (permisoCompuestoNombre490WC, permisoIncluidoNombre490WC) " +
                                        "VALUES (@Compuesto, @Incluido)";

                    using (SqlCommand comando490WC = new SqlCommand(query490WC, conexion490WC))
                    {
                        comando490WC.Parameters.AddWithValue("@Compuesto", Compuesto490WC);
                        comando490WC.Parameters.AddWithValue("@Incluido", Incluido490WC);

                        comando490WC.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }*/


        public bool BorrarPermiso490WC(string NombrePermiso490WC)
        {
            try
            {
                // 1. Verificar si el permiso está asignado como Rol a algún usuario
                Usuario490WC usuarioConRol = UsuarioAccesoDatos490WC.UsuarioAccesoDatosSG490WC.DevolverTodosLosUsuarios490WC().Find(x => x.Rol490WC == NombrePermiso490WC);

                if (usuarioConRol != null)
                {
                    return false;
                }

                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    // 2. Verificar si es Permiso Simple
                    string queryEsSimple = "SELECT COUNT(*) FROM PermisoSimple490WC WHERE Nombre490WC = @nombre";
                    using (SqlCommand cmdVerificarSimple = new SqlCommand(queryEsSimple, conexion))
                    {
                        cmdVerificarSimple.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                        int countSimple = (int)cmdVerificarSimple.ExecuteScalar();

                        if (countSimple > 0)
                        {
                            // 2.a Eliminar relaciones PermisoSimple-Familia
                            string deleteRel = "DELETE FROM PermisoSimple_Familia490WC WHERE NombrePermisoSimple490WC = @nombre";
                            using (SqlCommand cmdDelRel = new SqlCommand(deleteRel, conexion))
                            {
                                cmdDelRel.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDelRel.ExecuteNonQuery();
                            }

                            // 2.b Eliminar relaciones con perfiles si las hay
                            string deletePerfilRel = "DELETE FROM PermisoSimple_Perfil490WC WHERE NombrePermisoSimple490WC = @nombre";
                            using (SqlCommand cmdDelPerfil = new SqlCommand(deletePerfilRel, conexion))
                            {
                                cmdDelPerfil.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDelPerfil.ExecuteNonQuery();
                            }

                            // 2.c Eliminar el permiso simple
                            string deleteSimple = "DELETE FROM PermisoSimple490WC WHERE Nombre490WC = @nombre";
                            using (SqlCommand cmdDel = new SqlCommand(deleteSimple, conexion))
                            {
                                cmdDel.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDel.ExecuteNonQuery();
                            }

                            return true;
                        }
                    }

                    // 3. Verificar si es una Familia
                    string queryEsFamilia = "SELECT COUNT(*) FROM Familia490WC WHERE Nombre490WC = @nombre";
                    using (SqlCommand cmdVerificarFamilia = new SqlCommand(queryEsFamilia, conexion))
                    {
                        cmdVerificarFamilia.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                        int countFamilia = (int)cmdVerificarFamilia.ExecuteScalar();

                        if (countFamilia > 0)
                        {
                            // 3.a Eliminar relaciones Familia-Familia (como padre o hija)
                            string deleteRelFF = "DELETE FROM Familia_Familia490WC WHERE NombreFamiliaIncluye490WC = @nombre OR NombreFamiliaIncluida490WC = @nombre";
                            using (SqlCommand cmdDelFF = new SqlCommand(deleteRelFF, conexion))
                            {
                                cmdDelFF.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDelFF.ExecuteNonQuery();
                            }

                            // 3.b Eliminar relaciones Familia - PermisoSimple
                            string deleteRelPS = "DELETE FROM PermisoSimple_Familia490WC WHERE NombreFamilia490WC = @nombre";
                            using (SqlCommand cmdDelPS = new SqlCommand(deleteRelPS, conexion))
                            {
                                cmdDelPS.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDelPS.ExecuteNonQuery();
                            }

                            // 3.c Eliminar relaciones con perfiles si las hay
                            string deletePerfilRel = "DELETE FROM Perfil_Familia490WC WHERE NombreFamilia490WC = @nombre";
                            using (SqlCommand cmdDelPerfil = new SqlCommand(deletePerfilRel, conexion))
                            {
                                cmdDelPerfil.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDelPerfil.ExecuteNonQuery();
                            }

                            // 3.d Eliminar la familia
                            string deleteFamilia = "DELETE FROM Familia490WC WHERE Nombre490WC = @nombre";
                            using (SqlCommand cmdDel = new SqlCommand(deleteFamilia, conexion))
                            {
                                cmdDel.Parameters.AddWithValue("@nombre", NombrePermiso490WC);
                                cmdDel.ExecuteNonQuery();
                            }
                            //FALTA AGREGAR LOGICA PARA BORRAR Perfiles 22-6-25

                            return true;
                        }
                    }
                }

                // No se encontró ni como permiso simple ni como familia
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool FamiliaQuedariaVaciaAlEliminarPermisoSimple(string nombrePermisoSimple)
        {
            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                string query = "SELECT NombreFamilia490WC FROM PermisoSimple_Familia490WC GROUP BY NombreFamilia490WC HAVING COUNT(*) = 1 AND SUM(CASE WHEN NombrePermisoSimple490WC = @nombre THEN 1 ELSE 0 END) = 1";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombrePermisoSimple);

                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        return lector.HasRows; // True si hay al menos una familia que quedaría vacía
                    }
                }
            }
        }

        public bool FamiliaQuedariaVaciaAlEliminarFamiliaHija(string nombreFamiliaHija)
        {
            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                string query = "SELECT NombreFamiliaIncluye490WC FROM Familia_Familia490WC GROUP BY NombreFamiliaIncluye490WC HAVING COUNT(*) = 1 AND SUM(CASE WHEN NombreFamiliaIncluida490WC = @nombre THEN 1 ELSE 0 END) = 1";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombreFamiliaHija);

                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        return lector.HasRows;
                    }
                }
            }
        }

        public bool PerfilQuedariaVacioAlEliminarFamilia(string nombreFamilia)
        {
            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                string query =  "SELECT NombrePerfil490WC FROM Perfil_Familia490WC GROUP BY NombrePerfil490WC HAVING COUNT(*) = 1 AND SUM(CASE WHEN NombreFamilia490WC = @nombre THEN 1 ELSE 0 END) = 1";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombreFamilia);

                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        return lector.HasRows;
                    }
                }
            }
        }

        public bool PerfilQuedariaVacioAlEliminarFamilia(string nombrePerfil, string nombreFamilia)
        {
            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                // Verificar si hay otras familias
                string queryFamilias = "SELECT COUNT(*) FROM Perfil_Familia490WC WHERE nombrePerfil490WC = @perfil AND nombreFamilia490WC <> @familia";
                using (SqlCommand cmd = new SqlCommand(queryFamilias, conexion))
                {
                    cmd.Parameters.AddWithValue("@perfil", nombrePerfil);
                    cmd.Parameters.AddWithValue("@familia", nombreFamilia);
                    int restantesFamilias = (int)cmd.ExecuteScalar();
                    if (restantesFamilias > 0) return false;
                }

                // Verificar si hay permisos simples asociados
                string querySimples = "SELECT COUNT(*) FROM Perfil_PermisoSimple490WC WHERE nombrePerfil490WC = @perfil";
                using (SqlCommand cmd = new SqlCommand(querySimples, conexion))
                {
                    cmd.Parameters.AddWithValue("@perfil", nombrePerfil);
                    int cantidadSimples = (int)cmd.ExecuteScalar();
                    return cantidadSimples == 0; // Si no hay permisos simples, quedaría vacío
                }
            }
        }

        public bool PerfilQuedariaVacioAlEliminarPermisoSimple(string nombrePerfil, string nombrePermisoSimple)
        {
            using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                conexion.Open();

                // Verificar si hay otros permisos simples
                string querySimples = "SELECT COUNT(*) FROM Perfil_PermisoSimple490WC WHERE nombrePerfil490WC = @perfil AND nombrePermisoSimple490WC <> @permiso";
                using (SqlCommand cmd = new SqlCommand(querySimples, conexion))
                {
                    cmd.Parameters.AddWithValue("@perfil", nombrePerfil);
                    cmd.Parameters.AddWithValue("@permiso", nombrePermisoSimple);
                    int restantesSimples = (int)cmd.ExecuteScalar();
                    if (restantesSimples > 0) return false;
                }

                // Verificar si hay familias asociadas
                string queryFamilias = "SELECT COUNT(*) FROM Perfil_Familia490WC WHERE nombrePerfil490WC = @perfil";
                using (SqlCommand cmd = new SqlCommand(queryFamilias, conexion))
                {
                    cmd.Parameters.AddWithValue("@perfil", nombrePerfil);
                    int cantidadFamilias = (int)cmd.ExecuteScalar();
                    return cantidadFamilias == 0; // Si no hay familias, el perfil quedaría vacío
                }
            }
        }


        /*public bool BorrarPermiso490WC(string NombrePermiso490WC)
        {
            try
            {

                Usuario490WC usuarioConPermisoBorrar490WC = UsuarioAccesoDatos490WC.UsuarioAccesoDatosSG490WC.DevolverTodosLosUsuarios490WC().Find(x => x.Rol490WC == NombrePermiso490WC);
                if (usuarioConPermisoBorrar490WC != null)
                {
                    return false;
                }
                
                using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion490WC.Open();

                    // 1. Eliminar relaciones donde participe el permiso
                    string deleteRelacionesQuery = "DELETE FROM RelacionPermiso490WC WHERE permisoCompuestoNombre490WC = @nombrePermiso OR permisoIncluidoNombre490WC = @nombrePermiso";

                    using (SqlCommand cmdRelaciones = new SqlCommand(deleteRelacionesQuery, conexion490WC))
                    {
                        cmdRelaciones.Parameters.AddWithValue("@nombrePermiso", NombrePermiso490WC);
                        cmdRelaciones.ExecuteNonQuery();
                    }

                 
                    string deletePermisoQuery = "DELETE FROM Permiso490WC WHERE nombrePermiso490WC = @nombrePermiso";

                    using (SqlCommand cmdPermiso = new SqlCommand(deletePermisoQuery, conexion490WC))
                    {
                        cmdPermiso.Parameters.AddWithValue("@nombrePermiso", NombrePermiso490WC);
                        cmdPermiso.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }*/

        public bool EliminarRelacionPermisoSimple_Perfil(string nombrePerfil, string nombrePermisoSimple)
        {
            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    string query = "DELETE FROM Perfil_PermisoSimple490WC WHERE nombrePerfil490WC = @perfil AND nombrePermisoSimple490WC = @permiso";

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

                    string query = "DELETE FROM PermisoSimple_Familia490WC WHERE nombreFamilia490WC = @familia AND nombrePermisoSimple490WC = @permiso";

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


        /*public bool BorrarRelacion490WC(string nombrePermisoCompuesto490WC)
        {
            try
            {
                using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion490WC.Open();

                    string deleteQuery = @"DELETE FROM RelacionPermiso490WC WHERE permisoCompuestoNombre490WC = @nombreCompuesto";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conexion490WC))
                    {
                        cmd.Parameters.AddWithValue("@nombreCompuesto", nombrePermisoCompuesto490WC);
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }*/


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


        //public bool permisoExiste490WC(string nombrePermiso490WC)
        //{
        //    try
        //    {
        //        using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
        //        {
        //            conexion490WC.Open();

        //            string query = "SELECT COUNT(*) FROM Permiso490WC WHERE nombrePermiso490WC = @nombre";

        //            using (SqlCommand cmd = new SqlCommand(query, conexion490WC))
        //            {
        //                cmd.Parameters.AddWithValue("@nombre", nombrePermiso490WC);
        //                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
        //                return cantidad > 0;
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        public List<Permiso490WC> ObtenerPermisos490WC()
        {
            List<Permiso490WC> permisosTotales = new List<Permiso490WC>();

            try
            {
                using (SqlConnection conexion = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion.Open();

                    
                    string querySimples = "SELECT Nombre490WC FROM PermisoSimple490WC";
                    using (SqlCommand cmdSimples = new SqlCommand(querySimples, conexion))
                    using (SqlDataReader lector = cmdSimples.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string nombre = lector["Nombre490WC"].ToString();
                            permisosTotales.Add(new PermisoSimple490WC(nombre));
                        }
                    }

                    // 2. Leer familias
                    string queryFamilias = "SELECT Nombre490WC FROM Familia490WC";
                    using (SqlCommand cmdFamilias = new SqlCommand(queryFamilias, conexion))
                    using (SqlDataReader lector = cmdFamilias.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string nombre = lector["Nombre490WC"].ToString();
                            permisosTotales.Add(new PermisoCompuesto490WC(nombre));
                        }
                    }
                }
            }
            catch
            {
                permisosTotales.Clear(); 
            }

            return permisosTotales;
        }


        //public List<Permiso490WC> ObtenerPermisos490WC()
        //{
        //    List<Permiso490WC> ListaPermisos490WC = new List<Permiso490WC>();

        //    try
        //    {
        //        using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
        //        {
        //            conexion490WC.Open();

        //            string query = "SELECT nombrePermiso490WC, tipoPermiso490WC FROM Permiso490WC";

        //            using (SqlCommand cmd = new SqlCommand(query, conexion490WC))
        //            using (SqlDataReader lector = cmd.ExecuteReader())
        //            {
        //                while (lector.Read())
        //                {
        //                    string nombre = lector["nombrePermiso490WC"].ToString();
        //                    string tipo = lector["tipoPermiso490WC"].ToString();


        //                    if(tipo == "Compuesto")
        //                    {
        //                        Permiso490WC permiso490WC = new PermisoCompuesto490WC(nombre);
        //                        ListaPermisos490WC.Add(permiso490WC);
        //                    }
        //                    else
        //                    {
        //                        Permiso490WC permiso490WC = permiso490WC = new PermisoSimple490WC(nombre);
        //                        ListaPermisos490WC.Add(permiso490WC);
        //                    }


        //                }
        //            }
        //        }

        //        return ListaPermisos490WC;
        //    }
        //    catch
        //    {
        //        ListaPermisos490WC.Clear();
        //        return ListaPermisos490WC;
        //    }
        //}

        public List<Permiso490WC> ObtenerPermisosSimples490WC()
        {
            List<Permiso490WC> ListaPermisos490WC = new List<Permiso490WC>();

            try
            {
                using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion490WC.Open();

                    // Leer de la tabla actual según el DER aprobado
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


        //public List<Permiso490WC> ObtenerPermisosSimples490WC()
        //{
        //    List<Permiso490WC> ListaPermisos490WC = new List<Permiso490WC>();

        //    try
        //    {
        //        using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
        //        {
        //            conexion490WC.Open();

        //            string query = "SELECT nombrePermiso490WC FROM Permiso490WC WHERE tipoPermiso490WC = 'Simple'";

        //            using (SqlCommand cmd = new SqlCommand(query, conexion490WC))
        //            using (SqlDataReader lector = cmd.ExecuteReader())
        //            {
        //                while (lector.Read())
        //                {
        //                    string nombre = lector["nombrePermiso490WC"].ToString();
        //                    Permiso490WC permiso490WC = new PermisoSimple490WC(nombre);
        //                    ListaPermisos490WC.Add(permiso490WC);
        //                }
        //            }
        //        }

        //        return ListaPermisos490WC;
        //    }
        //    catch
        //    {
        //        ListaPermisos490WC.Clear();
        //        return ListaPermisos490WC;
        //    }
        //}

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


        //public List<Permiso490WC> ObtenerPermisosCompuestos490WC()
        //{
        //    List<Permiso490WC> ListaPermisos490WC = new List<Permiso490WC>();

        //    try
        //    {
        //        using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
        //        {
        //            conexion490WC.Open();

        //            string query = "SELECT nombrePermiso490WC FROM Permiso490WC WHERE tipoPermiso490WC = 'Compuesto'";

        //            using (SqlCommand cmd = new SqlCommand(query, conexion490WC))
        //            using (SqlDataReader lector = cmd.ExecuteReader())
        //            {
        //                while (lector.Read())
        //                {
        //                    string nombre = lector["nombrePermiso490WC"].ToString();
        //                    Permiso490WC permiso490WC = new PermisoCompuesto490WC(nombre);
        //                    ListaPermisos490WC.Add(permiso490WC);
        //                }
        //            }
        //        }

        //        return ListaPermisos490WC;
        //    }
        //    catch
        //    {
        //        ListaPermisos490WC.Clear();
        //        return ListaPermisos490WC;
        //    }
        //}

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


        //public List<Permiso490WC> ObtenerRoles490WC()
        //{
        //    List<Permiso490WC> ListaPermisos490WC = new List<Permiso490WC>();

        //    try
        //    {
        //        using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
        //        {
        //            conexion490WC.Open();

        //            string query = "SELECT nombrePermiso490WC, tipoPermiso490WC FROM Permiso490WC WHERE esRolPermiso490WC = 'True'";

        //            using (SqlCommand cmd = new SqlCommand(query, conexion490WC))
        //            using (SqlDataReader lector = cmd.ExecuteReader())
        //            {
        //                while (lector.Read())
        //                {
        //                    string nombre = lector["nombrePermiso490WC"].ToString();
        //                    string tipo = lector["tipoPermiso490WC"].ToString();

        //                    if (tipo == "Compuesto")
        //                    {
        //                        Permiso490WC permiso490WC = new PermisoCompuesto490WC(nombre);
        //                        ListaPermisos490WC.Add(permiso490WC);
        //                    }
        //                }
        //            }
        //        }

        //        return ListaPermisos490WC;
        //    }
        //    catch
        //    {
        //        ListaPermisos490WC.Clear();
        //        return ListaPermisos490WC;
        //    }
        //}
    }
}
