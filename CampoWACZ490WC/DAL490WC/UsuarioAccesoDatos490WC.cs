using DAL490WC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SERVICIOS490WC
{
    public class UsuarioAccesoDatos490WC
    {
      
       private static UsuarioAccesoDatos490WC Instancia;
       public static UsuarioAccesoDatos490WC UsuarioAccesoDatosSG490WC
       {
           get
           {
              if (Instancia == null)
              {
                Instancia = new UsuarioAccesoDatos490WC();
              }
                return Instancia;
           }
       }

            #region Operaciones Usuario 490WC
            public void Alta490WC(Usuario490WC UsuarioAlta490WC)
            {
                using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    cone490WC.Open();
                    string query490WC = "INSERT INTO Usuario490WC (Username490WC,Nombre490WC,Apellido490WC,DNI490WC,Contraseña490WC,Email490WC,Rol490WC,IdiomaUsuario490WC,Intentos490WC,IsBloqueado490WC,IsHabilitado490WC,HoraUltimaSesion490WC)" +
                                        " VALUES (@Username490WC,@Nombre490WC,@Apellido490WC,@DNI490WC,@Contraseña490WC,@Email490WC,@Rol490WC,@IdiomaUsuario490WC,@Intentos490WC,@IsBloqueado490WC,@IsHabilitado490WC,@HoraUltimaSesion490WC)";
                    using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                    {
                        comando490WC.Parameters.AddWithValue("@Username490WC", UsuarioAlta490WC.Username490WC);
                        comando490WC.Parameters.AddWithValue("@Nombre490WC", UsuarioAlta490WC.Nombre490WC);
                        comando490WC.Parameters.AddWithValue("@Apellido490WC", UsuarioAlta490WC.Apellido490WC);
                        comando490WC.Parameters.AddWithValue("@DNI490WC", UsuarioAlta490WC.DNI490WC);
                        comando490WC.Parameters.AddWithValue("@Contraseña490WC", UsuarioAlta490WC.Contraseña490WC);
                        comando490WC.Parameters.AddWithValue("@Email490WC", UsuarioAlta490WC.Email490WC);
                        comando490WC.Parameters.AddWithValue("@Rol490WC", UsuarioAlta490WC.Rol490WC);
                        comando490WC.Parameters.AddWithValue("@IdiomaUsuario490WC", UsuarioAlta490WC.IdiomaUsuario490WC);
                        comando490WC.Parameters.AddWithValue("@Intentos490WC", UsuarioAlta490WC.Intentos490WC);
                        comando490WC.Parameters.AddWithValue("@IsBloqueado490WC", UsuarioAlta490WC.IsBloqueado490WC);
                        comando490WC.Parameters.AddWithValue("@IsHabilitado490WC", UsuarioAlta490WC.IsHabilitado490WC);
                        comando490WC.Parameters.AddWithValue("@HoraUltimaSesion490WC", UsuarioAlta490WC.HoraUltimaSesion490WC);

                        comando490WC.ExecuteNonQuery();
                    }
                }
            }
            public void Baja490WC(string username490WC)
            {
                using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    cone490WC.Open();
                    string query490WC = "DELETE FROM Usuario490WC WHERE Username490WC = @Username490WC";
                    using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                    {
                        comando490WC.Parameters.AddWithValue("@Username490WC", username490WC);
                        comando490WC.ExecuteNonQuery();
                    }
                }
            }
            public void Modificar490WC(Usuario490WC UsuarioModificado)
            {
                using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    cone490WC.Open();
                    string query490WC = "UPDATE Usuario490WC SET Nombre490WC = @Nombre490WC, Apellido490WC = @Apellido490WC, DNI490WC = @DNI490WC, Contraseña490WC = @Contraseña490WC, Email490WC = @Email490WC, Rol490WC = @Rol490WC, IdiomaUsuario490WC = @IdiomaUsuario490WC, Intentos490WC = @Intentos490WC, IsBloqueado490WC = @IsBloqueado490WC, IsHabilitado490WC = @IsHabilitado490WC, HoraUltimaSesion490WC = @HoraUltimaSesion490WC  WHERE Username490WC = @Username490WC";

                    using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                    {
                        comando490WC.Parameters.AddWithValue("@Username490WC", UsuarioModificado.Username490WC);
                        comando490WC.Parameters.AddWithValue("@Nombre490WC", UsuarioModificado.Nombre490WC);
                        comando490WC.Parameters.AddWithValue("@Apellido490WC", UsuarioModificado.Apellido490WC);
                        comando490WC.Parameters.AddWithValue("@DNI490WC", UsuarioModificado.DNI490WC);
                        comando490WC.Parameters.AddWithValue("@Contraseña490WC", UsuarioModificado.Contraseña490WC);
                        comando490WC.Parameters.AddWithValue("@Email490WC", UsuarioModificado.Email490WC);
                        comando490WC.Parameters.AddWithValue("@Rol490WC", UsuarioModificado.Rol490WC);
                        comando490WC.Parameters.AddWithValue("@IdiomaUsuario490WC", UsuarioModificado.IdiomaUsuario490WC);
                        comando490WC.Parameters.AddWithValue("@Intentos490WC", UsuarioModificado.Intentos490WC);
                        comando490WC.Parameters.AddWithValue("@IsBloqueado490WC", UsuarioModificado.IsBloqueado490WC);
                        comando490WC.Parameters.AddWithValue("@IsHabilitado490WC", UsuarioModificado.IsHabilitado490WC);
                        comando490WC.Parameters.AddWithValue("@HoraUltimaSesion490WC", UsuarioModificado.HoraUltimaSesion490WC);
                        comando490WC.ExecuteNonQuery();
                    }
                }
            }
            public void DesbloquearUsuario490WC(Usuario490WC UsuarioDesbloquear)
            {

                using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    cone490WC.Open();
                    string query490WC = "Update Usuario490WC SET IsBloqueado490WC = @IsBloqueado490WC, Contraseña490WC = @Contraseña490WC, Intentos490WC = @Intentos490WC WHERE Username490WC = @Username490WC";
                    using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                    {
                        comando490WC.Parameters.AddWithValue("@IsBloqueado490WC", 0);
                        comando490WC.Parameters.AddWithValue("@Contraseña490WC", UsuarioDesbloquear.Contraseña490WC);
                        comando490WC.Parameters.AddWithValue("@Username490WC", UsuarioDesbloquear.Username490WC);
                        comando490WC.Parameters.AddWithValue("@Intentos490WC", 0);

                        comando490WC.ExecuteNonQuery();
                    }
                }
            }
            public void BloquearUsuario490WC(string username490WC)
            {
                using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    cone490WC.Open();
                    string query490WC = "Update Usuario490WC SET IsBloqueado490WC = @IsBloqueado490WC WHERE Username490WC = @Username490WC";
                    using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                    {
                        comando490WC.Parameters.AddWithValue("@IsBloqueado490WC", 1);
                        comando490WC.Parameters.AddWithValue("@Username490WC", username490WC);

                        comando490WC.ExecuteNonQuery();
                    }
                }
            }
            public void DesactivarUsuario490WC(string username490WC)
            {
                using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    cone490WC.Open();
                    string query490WC = "Update Usuario490WC SET IsHabilitado490WC = @IsHabilitado490WC WHERE Username490WC = @Username490WC";
                    using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                    {
                        comando490WC.Parameters.AddWithValue("@IsHabilitado490WC", 0);
                        comando490WC.Parameters.AddWithValue("@Username490WC", username490WC);

                        comando490WC.ExecuteNonQuery();
                    }
                }
            }
            public void ActivarUsuario490WC(string username490WC)
            {
                using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    cone490WC.Open();
                    string query490WC = "Update Usuario490WC SET IsHabilitado490WC = @IsHabilitado490WC WHERE Username490WC = @Username490WC";
                    using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                    {
                        comando490WC.Parameters.AddWithValue("@IsHabilitado490WC", 1);
                        comando490WC.Parameters.AddWithValue("@Username490WC", username490WC);

                        comando490WC.ExecuteNonQuery();
                    }
                }
            }
            #endregion

            #region Busquedas De Usuarios 490WC
            public List<Usuario490WC> DevolverTodosLosUsuarios490WC()
            {
                List<Usuario490WC> ListaUsuario490WC = new List<Usuario490WC>();
                using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    using (SqlCommand comando490WC = new SqlCommand("SELECT * FROM Usuario490WC", cone490WC))
                    {
                        cone490WC.Open();
                        using (SqlDataReader lector490WC = comando490WC.ExecuteReader())
                        {

                            while (lector490WC.Read())
                            {
                                Usuario490WC usuarioLectura = new Usuario490WC(
                                                                                 lector490WC["Username490WC"].ToString(),
                                                                                 lector490WC["Nombre490WC"].ToString(),
                                                                                 lector490WC["Apellido490WC"].ToString(),
                                                                                 lector490WC["DNI490WC"].ToString(),
                                                                                 lector490WC["Contraseña490WC"].ToString(),
                                                                                 lector490WC["Email490WC"].ToString(),
                                                                                 lector490WC["Rol490WC"].ToString(),
                                                                                 lector490WC["IdiomaUsuario490WC"].ToString(),
                                                                                 int.Parse(lector490WC["Intentos490WC"].ToString()),
                                                                                 bool.Parse(lector490WC["IsBloqueado490WC"].ToString()),
                                                                                 bool.Parse(lector490WC["IsHabilitado490WC"].ToString())
                                                                               );
                                ListaUsuario490WC.Add(usuarioLectura);
                            }
                        }
                    }
                }
                return ListaUsuario490WC;
            }
            private Usuario490WC BuscarUsuario490WC(string query490WC, string parametro490WC, string valorBusqueda490WC)
            {
                using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
                {
                    using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                    {
                        cone490WC.Open();
                        comando490WC.Parameters.AddWithValue(parametro490WC, valorBusqueda490WC);
                        using (SqlDataReader lector490WC = comando490WC.ExecuteReader())
                        {
                            if (lector490WC.Read())
                            {
                                Usuario490WC usuarioLectura = new Usuario490WC(
                                                                                    lector490WC["Username490WC"].ToString(),
                                                                                    lector490WC["Nombre490WC"].ToString(),
                                                                                    lector490WC["Apellido490WC"].ToString(),
                                                                                    lector490WC["DNI490WC"].ToString(),
                                                                                    lector490WC["Contraseña490WC"].ToString(),
                                                                                    lector490WC["Email490WC"].ToString(),
                                                                                    lector490WC["Rol490WC"].ToString(),
                                                                                    lector490WC["IdiomaUsuario490WC"].ToString(),
                                                                                    int.Parse(lector490WC["Intentos490WC"].ToString()),
                                                                                    bool.Parse(lector490WC["IsBloqueado490WC"].ToString()),
                                                                                    bool.Parse(lector490WC["IsHabilitado490WC"].ToString())
                                                                                );
                                return usuarioLectura;
                            }
                        }
                    }
                }

                return null;
            }
            public Usuario490WC BuscarUsuarioPorUsername490WC(string Username490WC)
            {
                return BuscarUsuario490WC("SELECT * FROM Usuario490WC WHERE Username490WC = @Username490WC", "@Username490WC", Username490WC);
            }
            public Usuario490WC BuscarUsuarioPorDNI490WC(string DNI490WC)
            {
                return BuscarUsuario490WC("SELECT * FROM Usuario490WC WHERE DNI490WC = @DNI490WC", "@DNI490WC", DNI490WC);
            }

            public Usuario490WC BuscarUsuarioPorEmail490WC(string Email490WC)
            {
                return BuscarUsuario490WC("SELECT * FROM Usuario490WC WHERE Email490WC = @Email490WC", "@Email490WC", Email490WC);
            }
            #endregion
        
    }
}
