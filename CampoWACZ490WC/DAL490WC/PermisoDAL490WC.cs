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

        public List<Permiso490WC> LeerPermisosEnArbol490WC()
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

        public PermisoCompuesto490WC LeerPermisoCompuesto490WC(string PermisoLeer490WC)
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

        public bool InsertarPermiso490WC(Permiso490WC permisoNuevo490WC, bool esRol490WC)
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
                        comando490WC.Parameters.AddWithValue("@tipo", permisoNuevo490WC.esCompuesto490WC() ? "Compuesto" : "Simple");
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
        }

        public bool InsertarRelacion490WC(string Compuesto490WC, string Incluido490WC)
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
        }

        public bool BorrarPermiso490WC(string NombrePermiso490WC)
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
        }

        public bool BorrarRelacion490WC(string nombrePermisoCompuesto490WC)
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
        }

        public bool ModificarPermiso490WC(string nombrePermiso490WC, string nuevoNombrePermiso490WC)
        {
            try
            {
                using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion490WC.Open();

                    string updatePermisoQuery = "UPDATE Permiso490WC SET nombrePermiso490WC = @nuevoNombre WHERE nombrePermiso490WC = @nombreActual";

                    using (SqlCommand cmdPermiso = new SqlCommand(updatePermisoQuery, conexion490WC))
                    {
                        cmdPermiso.Parameters.AddWithValue("@nuevoNombre", nuevoNombrePermiso490WC);
                        cmdPermiso.Parameters.AddWithValue("@nombreActual", nombrePermiso490WC);
                        cmdPermiso.ExecuteNonQuery();
                    }

                    // 2. Actualizar las relaciones si el permiso estaba como compuesto
                    string updateRelacionCompuestoQuery = "UPDATE RelacionPermiso490WC SET permisoCompuestoNombre490WC = @nuevoNombre WHERE permisoCompuestoNombre490WC = @nombreActual";

                    using (SqlCommand cmdCompuesto = new SqlCommand(updateRelacionCompuestoQuery, conexion490WC))
                    {
                        cmdCompuesto.Parameters.AddWithValue("@nuevoNombre", nuevoNombrePermiso490WC);
                        cmdCompuesto.Parameters.AddWithValue("@nombreActual", nombrePermiso490WC);
                        cmdCompuesto.ExecuteNonQuery();
                    }

                    // 3. Actualizar las relaciones si el permiso estaba como incluido
                    string updateRelacionIncluidoQuery = "UPDATE RelacionPermiso490WC SET permisoIncluidoNombre490WC = @nuevoNombre WHERE permisoIncluidoNombre490WC = @nombreActual";

                    using (SqlCommand cmdIncluido = new SqlCommand(updateRelacionIncluidoQuery, conexion490WC))
                    {
                        cmdIncluido.Parameters.AddWithValue("@nuevoNombre", nuevoNombrePermiso490WC);
                        cmdIncluido.Parameters.AddWithValue("@nombreActual", nombrePermiso490WC);
                        cmdIncluido.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool esRol490WC(string nombrePermiso490WC)
        {
            try
            {
                using (SqlConnection conexion490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    conexion490WC.Open();

                    string query = "SELECT esRolPermiso490WC FROM Permiso490WC WHERE nombrePermiso490WC = @nombre";

                    using (SqlCommand cmd = new SqlCommand(query, conexion490WC))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombrePermiso490WC);

                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null && resultado.ToString() == "True")
                        {
                            return true;
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







    }
}
