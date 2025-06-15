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
                string query490WC = "INSERT INTO Cliente490WC (DNI490WC, Nombre490WC, Apellido490WC, DatosTarjeta490WC, EstrellasCliente490WC) VALUES (@DNI490WC, @Nombre490WC, @Apellido490WC, @DatosTarjeta490WC, @EstrellasCliente490WC)";
                using (SqlCommand comando490WC = new SqlCommand(query490WC,cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@DNI490WC", ClienteAlta490WC.DNI490WC);
                    comando490WC.Parameters.AddWithValue("@Nombre490WC", ClienteAlta490WC.Nombre490WC);
                    comando490WC.Parameters.AddWithValue("@Apellido490WC", ClienteAlta490WC.Apellido490WC);
                    comando490WC.Parameters.AddWithValue("@DatosTarjeta490WC", ClienteAlta490WC.DatosTarjeta490WC);
                    comando490WC.Parameters.AddWithValue("@EstrellasCliente490WC", ClienteAlta490WC.EstrellasCliente490WC);

                    comando490WC.ExecuteNonQuery();
                }
            }
        }

        public void Baja490WC(string DNI490WC)
        {
            using(SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "DELETE FROM Cliente490WC WHERE DNI490WC = @DNI490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@DNI490WC", DNI490WC);
                    comando490WC.ExecuteNonQuery();
                }
            }
        }

        public void Modificar490WC(Cliente490WC ClienteModificado490WC)
        {
            using(SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "UPDATE Cliente490WC SET Nombre490WC = @Nombre490WC, Apellido490WC = @Apellido490WC, DatosTarjeta490WC = @DatosTarjeta490WC, EstrellasCliente490WC = @EstrellasCliente490WC WHERE DNI490WC = @DNI490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@DNI490WC", ClienteModificado490WC.DNI490WC);
                    comando490WC.Parameters.AddWithValue("@Nombre490WC", ClienteModificado490WC.Nombre490WC);
                    comando490WC.Parameters.AddWithValue("@Apellido490WC", ClienteModificado490WC.Apellido490WC);
                    comando490WC.Parameters.AddWithValue("@DatosTarjeta490WC", ClienteModificado490WC.DatosTarjeta490WC);
                    comando490WC.Parameters.AddWithValue("@EstrellasCliente490WC", ClienteModificado490WC.EstrellasCliente490WC);
                    comando490WC.ExecuteNonQuery();
                }
            }
        }

        public void ModificarEstrellasCliente490WC(string DNI490WC, int EstrellasReducir490WC)
        {
            BeneficioDAL490WC gestorBeneficioDAL490WC = new BeneficioDAL490WC();
            gestorBeneficioDAL490WC.ReducirSaldoEstrellas490WC(DNI490WC,EstrellasReducir490WC);
        }

        #endregion

        #region Busquedas Cliente

        public Cliente490WC BuscarClientePorDNI490WC(string DNI490WC)
        {
            using(SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                BeneficioDAL490WC gestorBeneficio490WC = new BeneficioDAL490WC();
                cone490WC.Open();
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
                                reader["DatosTarjeta490WC"].ToString(),
                                Convert.ToInt32(reader["EstrellasCliente490WC"]),
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
        }

        public List<Cliente490WC> ObtenerTodosLosCliente490WC()
        {
            List<Cliente490WC> listaClientes490WC = new List<Cliente490WC>();
            using(SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "SELECT * FROM Cliente490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    using (SqlDataReader reader = comando490WC.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaClientes490WC.Add(new Cliente490WC(
                                reader["DNI490WC"].ToString(),
                                reader["Nombre490WC"].ToString(),
                                reader["Apellido490WC"].ToString(),
                                reader["DatosTarjeta490WC"].ToString(),
                                Convert.ToInt32(reader["EstrellasCliente490WC"])
                            ));
                        }
                    }
                }
            }
            return listaClientes490WC;
        }

        #endregion

    }
}
