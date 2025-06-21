using BE490WC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL490WC
{
    public class ClienteDAL490WC
    {
        #region Operaciones Cliente
        public void Alta490WC(Cliente490WC ClienteAlta490WC)
        {
            using(SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "INSERT INTO Cliente490WC (DNI490WC, Nombre490WC, Apellido490WC, EstrellasCliente490WC, Direccion490WC, Activo490WC) VALUES (@DNI490WC, @Nombre490WC, @Apellido490WC, @EstrellasCliente490WC, @Direccion490WC, @Activo490WC)";
                using (SqlCommand comando490WC = new SqlCommand(query490WC,cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@DNI490WC", ClienteAlta490WC.DNI490WC);
                    comando490WC.Parameters.AddWithValue("@Nombre490WC", ClienteAlta490WC.Nombre490WC);
                    comando490WC.Parameters.AddWithValue("@Apellido490WC", ClienteAlta490WC.Apellido490WC);
                    comando490WC.Parameters.AddWithValue("@EstrellasCliente490WC", ClienteAlta490WC.EstrellasCliente490WC);
                    comando490WC.Parameters.AddWithValue("@Direccion490WC", ClienteAlta490WC.Direccion490WC);
                    comando490WC.Parameters.AddWithValue("@Activo490WC", ClienteAlta490WC.Activo490WC);

                    comando490WC.ExecuteNonQuery();
                }
            }
            AgregarCelularesCliente490WC(ClienteAlta490WC.DNI490WC,ClienteAlta490WC.Celulares490WC);
            AgregarEmailsCliente490WC(ClienteAlta490WC.DNI490WC,ClienteAlta490WC.Emails490WC);
        }

        public void Baja490WC(string DNI490WC)
        {
            using(SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                
                string query490WC = "UPDATE Cliente490WC SET Activo490WC = @Activo490WC WHERE DNI490WC = @DNI490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@DNI490WC", DNI490WC);
                    comando490WC.Parameters.AddWithValue("@Activo490WC", 0);
                    comando490WC.ExecuteNonQuery();
                }
            }
        }

        public void Modificar490WC(Cliente490WC ClienteModificado490WC)
        {
            using(SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "UPDATE Cliente490WC SET Nombre490WC = @Nombre490WC, Apellido490WC = @Apellido490WC, EstrellasCliente490WC = @EstrellasCliente490WC, Direccion490WC = @Direccion490WC, Activo490WC = @Activo490WC WHERE DNI490WC = @DNI490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@DNI490WC", ClienteModificado490WC.DNI490WC);
                    comando490WC.Parameters.AddWithValue("@Nombre490WC", ClienteModificado490WC.Nombre490WC);
                    comando490WC.Parameters.AddWithValue("@Apellido490WC", ClienteModificado490WC.Apellido490WC);
                    comando490WC.Parameters.AddWithValue("@EstrellasCliente490WC", ClienteModificado490WC.EstrellasCliente490WC);
                    comando490WC.Parameters.AddWithValue("@Direccion490WC", ClienteModificado490WC.Direccion490WC);
                    comando490WC.Parameters.AddWithValue("@Activo490WC", ClienteModificado490WC.Activo490WC);
                    comando490WC.ExecuteNonQuery();
                }
            }
            ReemplazarCelularesCliente490WC(ClienteModificado490WC.DNI490WC,ClienteModificado490WC.Celulares490WC);
            ReemplazarEmailsCliente490WC(ClienteModificado490WC.DNI490WC,ClienteModificado490WC.Emails490WC);
        }

        public void ModificarEstrellasCliente490WC(string DNI490WC, int EstrellasReducir490WC)
        {
            BeneficioDAL490WC gestorBeneficioDAL490WC = new BeneficioDAL490WC();
            gestorBeneficioDAL490WC.ReducirSaldoEstrellas490WC(DNI490WC,EstrellasReducir490WC);
        }

        #endregion

        #region Busquedas Cliente

        /*public Cliente490WC BuscarClientePorDNI490WC(string DNI490WC)
        {
            List<string> celularesCliente490WC = ObtenerCelularesPorCliente490WC(DNI490WC);
            List<string> emailsCliente490WC = ObtenerEmailsPorCliente490WC(DNI490WC);
            using(SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                BeneficioDAL490WC gestorBeneficio490WC = new BeneficioDAL490WC();
                if (cone490WC.State != System.Data.ConnectionState.Open)
                {
                  cone490WC.Open();
                }
                string query490WC = "SELECT * FROM Cliente490WC WHERE DNI490WC = @DNI490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@DNI490WC", DNI490WC);
                    using (SqlDataReader reader = comando490WC.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Cliente490WC(
                                reader["DNI490WC"].ToString(),
                                reader["Nombre490WC"].ToString(),
                                reader["Apellido490WC"].ToString(),
                                Convert.ToInt32(reader["EstrellasCliente490WC"]),
                                emailsCliente490WC,
                                celularesCliente490WC,
                                reader["Direccion490WC"].ToString(),
                                Convert.ToBoolean(reader["Activo490WC"]),
                                gestorBeneficio490WC.ObtenerBeneficiosPorCliente490WC(DNI490WC)
                            );
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }*/

        public Cliente490WC BuscarClientePorDNI490WC(string DNI490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();

                string query490WC = "SELECT * FROM Cliente490WC WHERE DNI490WC = @DNI490WC";

                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@DNI490WC", DNI490WC);

                    using (SqlDataReader reader = comando490WC.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            List<string> celularesCliente490WC = ObtenerCelularesPorCliente490WC(DNI490WC);
                            List<string> emailsCliente490WC = ObtenerEmailsPorCliente490WC(DNI490WC);
                            BeneficioDAL490WC gestorBeneficio490WC = new BeneficioDAL490WC();
                            List<Beneficio490WC> beneficiosCliente490WC = gestorBeneficio490WC.ObtenerBeneficiosPorCliente490WC(DNI490WC);

                            return new Cliente490WC(
                                reader["DNI490WC"].ToString(),
                                reader["Nombre490WC"].ToString(),
                                reader["Apellido490WC"].ToString(),
                                Convert.ToInt32(reader["EstrellasCliente490WC"]),
                                emailsCliente490WC,
                                celularesCliente490WC,
                                reader["Direccion490WC"].ToString(),
                                Convert.ToBoolean(reader["Activo490WC"]),
                                beneficiosCliente490WC
                            );
                        }
                    }
                }
            }

            return null; 
        }


        /*  public List<Cliente490WC> ObtenerTodosLosCliente490WC()
          {
              List<Cliente490WC> listaClientes490WC = new List<Cliente490WC>();
              using(SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
              {
                  cone490WC.Open();
                  string query490WC = "SELECT * FROM Cliente490WC";
                  using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                  {
                      BeneficioDAL490WC gestorBeneficio490WC = new BeneficioDAL490WC();
                      using (SqlDataReader reader = comando490WC.ExecuteReader())
                      {
                          while (reader.Read())
                          {
                              List<string> celularesCliente490WC = ObtenerCelularesPorCliente490WC(reader["DNI490WC"].ToString());
                              List<string> emailsCliente490WC = ObtenerEmailsPorCliente490WC(reader["DNI490WC"].ToString());
                              listaClientes490WC.Add(new Cliente490WC(
                                  reader["DNI490WC"].ToString(),
                                  reader["Nombre490WC"].ToString(),
                                  reader["Apellido490WC"].ToString(),
                                  Convert.ToInt32(reader["EstrellasCliente490WC"]),
                                  emailsCliente490WC,
                                  celularesCliente490WC,
                                  reader["Direccion490WC"].ToString(),
                                  Convert.ToBoolean(reader["Activo490WC"]),
                                  gestorBeneficio490WC.ObtenerBeneficiosPorCliente490WC(reader["DNI490WC"].ToString())
                              ));
                          }
                      }
                  }
              }
              return listaClientes490WC;
          }*/

        public List<Cliente490WC> ObtenerTodosLosCliente490WC()
        {
            List<Cliente490WC> listaClientes490WC = new List<Cliente490WC>();

            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "SELECT * FROM Cliente490WC";

                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    BeneficioDAL490WC gestorBeneficio490WC = new BeneficioDAL490WC();

                    using (SqlDataReader reader = comando490WC.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string dni = reader["DNI490WC"].ToString();
                            List<string> celulares = ObtenerCelularesPorCliente490WC(dni);
                            List<string> emails = ObtenerEmailsPorCliente490WC(dni);
                            List<Beneficio490WC> beneficios = gestorBeneficio490WC.ObtenerBeneficiosPorCliente490WC(dni);

                            listaClientes490WC.Add(new Cliente490WC(
                                dni,
                                reader["Nombre490WC"].ToString(),
                                reader["Apellido490WC"].ToString(),
                                Convert.ToInt32(reader["EstrellasCliente490WC"]),
                                emails,
                                celulares,
                                reader["Direccion490WC"].ToString(),
                                Convert.ToBoolean(reader["Activo490WC"]),
                                beneficios
                            ));
                        }
                    }
                }
            }

            return listaClientes490WC;
        }


        public List<string> ObtenerCelularesPorCliente490WC(string DNI490WC)
        {
            List<string> celulares = new List<string>();

            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query = "SELECT Celular490WC FROM CelularCliente490WC WHERE DNICliente490WC = @DNI490WC";
                using (SqlCommand comando = new SqlCommand(query, cone490WC))
                {
                    comando.Parameters.AddWithValue("@DNI490WC", DNI490WC);
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            celulares.Add(reader["Celular490WC"].ToString());
                        }
                    }
                }
            }

            return celulares;
        }

        public void AgregarCelularesCliente490WC(string dniCliente, List<string> celulares)
        {
            using (SqlConnection con = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                con.Open();

                foreach (string celular in celulares)
                {
                    string query = "INSERT INTO CelularCliente490WC (DNICliente490WC, Celular490WC) VALUES (@DNI, @Celular)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@DNI", dniCliente);
                        cmd.Parameters.AddWithValue("@Celular", celular);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void ReemplazarCelularesCliente490WC(string dniCliente, List<string> nuevosCelulares)
        {
            using (SqlConnection con = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                con.Open();

                string deleteQuery = "DELETE FROM CelularCliente490WC WHERE DNICliente490WC = @DNI";
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, con))
                {
                    deleteCmd.Parameters.AddWithValue("@DNI", dniCliente);
                    deleteCmd.ExecuteNonQuery();
                }

                foreach (string celular in nuevosCelulares)
                {
                    string insertQuery = "INSERT INTO CelularCliente490WC (DNICliente490WC, Celular490WC) VALUES (@DNI, @Celular)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@DNI", dniCliente);
                        insertCmd.Parameters.AddWithValue("@Celular", celular);
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
        }


        public List<string> ObtenerEmailsPorCliente490WC(string DNI490WC)
        {
            List<string> emails = new List<string>();

            using (SqlConnection cone = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone.Open();
                string query = "SELECT Email490WC FROM EmailCliente490WC WHERE DNICliente490WC = @DNI490WC";
                using (SqlCommand comando = new SqlCommand(query, cone))
                {
                    comando.Parameters.AddWithValue("@DNI490WC", DNI490WC);
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            emails.Add(reader["Email490WC"].ToString());
                        }
                    }
                }
            }

            return emails;
        }

        public void AgregarEmailsCliente490WC(string dniCliente, List<string> emails)
        {
            using (SqlConnection con = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                con.Open();

                foreach (string email in emails)
                {
                    string query = "INSERT INTO EmailCliente490WC (DNICliente490WC, Email490WC) VALUES (@DNI, @Email)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@DNI", dniCliente);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void ReemplazarEmailsCliente490WC(string dniCliente, List<string> nuevosEmails)
        {
            using (SqlConnection con = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                con.Open();

                string deleteQuery = "DELETE FROM EmailCliente490WC WHERE DNICliente490WC = @DNI";
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, con))
                {
                    deleteCmd.Parameters.AddWithValue("@DNI", dniCliente);
                    deleteCmd.ExecuteNonQuery();
                }

                foreach (string email in nuevosEmails)
                {
                    string insertQuery = "INSERT INTO EmailCliente490WC (DNICliente490WC, Email490WC) VALUES (@DNI, @Email)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@DNI", dniCliente);
                        insertCmd.Parameters.AddWithValue("@Email", email);
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
        }


        #endregion

    }
}
