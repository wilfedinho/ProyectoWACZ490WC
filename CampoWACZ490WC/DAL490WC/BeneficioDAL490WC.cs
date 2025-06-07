using BE490WC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL490WC
{
    public class BeneficioDAL490WC
    {
        #region Operaciones Beneficio

        public void Alta490WC(Beneficio490WC BeneficioAlta490WC)
        {
            using(SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "INSERT INTO Beneficio490WC (CodigoBeneficio490WC, Nombre490WC, PrecioEstrella490WC, CantidadBeneficioReclamado490WC, DescuentoAplicar490WC) VALUES (@CodigoBeneficio490WC, @Nombre490WC, @PrecioEstrella490WC, @CantidadBeneficioReclamado490WC, @DescuentoAplicar490WC)";
                using (SqlCommand comando490WC = new SqlCommand(query490WC,cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@CodigoBeneficio490WC", BeneficioAlta490WC.CodigoBeneficio490WC);
                    comando490WC.Parameters.AddWithValue("@Nombre490WC", BeneficioAlta490WC.Nombre490WC);
                    comando490WC.Parameters.AddWithValue("@PrecioEstrella490WC", BeneficioAlta490WC.PrecioEstrella490WC);
                    comando490WC.Parameters.AddWithValue("@CantidadBeneficioReclamado490WC", BeneficioAlta490WC.CantidadBeneficioReclamo490WC);
                    comando490WC.Parameters.AddWithValue("@DescuentoAplicar490WC", BeneficioAlta490WC.DescuentoAplicar490WC);

                    comando490WC.ExecuteNonQuery();
                }
            }
        }

        public void Baja490WC(int ID490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "DELETE FROM Beneficio490WC WHERE CodigoBeneficio490WC = @ID";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@ID", ID490WC);
                    comando490WC.ExecuteNonQuery();
                }
            }
        }

        public void Modificacion490WC(Beneficio490WC BeneficioModificado490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "UPDATE Beneficio490WC SET Nombre490WC = @Nombre490WC, PrecioEstrella490WC = @PrecioEstrella490WC, CantidadBeneficioReclamado490WC = @CantidadBeneficioReclamado490WC, DescuentoAplicar490WC = @DescuentoAplicar490WC WHERE CodigoBeneficio490WC = @CodigoBeneficio490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@CodigoBeneficio490WC", BeneficioModificado490WC.CodigoBeneficio490WC);
                    comando490WC.Parameters.AddWithValue("@Nombre490WC", BeneficioModificado490WC.Nombre490WC);
                    comando490WC.Parameters.AddWithValue("@PrecioEstrella490WC", BeneficioModificado490WC.PrecioEstrella490WC);
                    comando490WC.Parameters.AddWithValue("@CantidadBeneficioReclamado490WC", BeneficioModificado490WC.CantidadBeneficioReclamo490WC);
                    comando490WC.Parameters.AddWithValue("@DescuentoAplicar490WC", BeneficioModificado490WC.DescuentoAplicar490WC);
                    comando490WC.ExecuteNonQuery();
                }
            }
        }

        public void ReducirSaldoEstrellas490WC(string DNICliente490WC, int cantidadEstrellas490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "UPDATE Cliente490WC SET EstrellasCliente490WC = EstrellasCliente490WC - @CantidadEstrellas WHERE DNICliente490WC = @DNICliente490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@CantidadEstrellas", cantidadEstrellas490WC);
                    comando490WC.Parameters.AddWithValue("@DNICliente490WC", DNICliente490WC);
                    comando490WC.ExecuteNonQuery();
                }
            }
        }

        public void AplicarBeneficio490WC(int IDBoleto490WC, float DescuentoAplicar490WC)
        {
            using(SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "UPDATE Boleto490WC SET Precio490WC = Precio490WC * (1 - @PorcentajeDescuento) WHERE ID490WC = @ID490WC;";
                using(SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@PorcentajeDescuento", DescuentoAplicar490WC);
                    comando490WC.Parameters.AddWithValue("@ID490WC", IDBoleto490WC);
                    comando490WC.ExecuteNonQuery();
                }
            }
        }


        #endregion

        #region Busquedas Beneficio
        public Beneficio490WC ObtenerBeneficioPorCodigo490WC(int CodigoBeneficio490WC)
        {
            using(SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "SELECT * FROM Beneficio490WC WHERE CodigoBeneficio490WC = @CodigoBeneficio490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@CodigoBeneficio490WC", CodigoBeneficio490WC);
                    using (SqlDataReader reader = comando490WC.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Beneficio490WC( int.Parse(reader["CodigoBeneficio490WC"].ToString()), reader["Nombre490WC"].ToString(), int.Parse(reader["PrecioEstrella490WC"].ToString()), int.Parse(reader["CantidadBeneficioReclamado490WC"].ToString()), float.Parse(reader["DescuentoAplicar490WC"].ToString()));
                        }
                        else
                        {
                            return null; 
                        }
                    }
                }
            }
        }

        public List<Beneficio490WC> ObtenerTodosLosBeneficios490WC()
        {
            List<Beneficio490WC> beneficios = new List<Beneficio490WC>();
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "SELECT * FROM Beneficio490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    using (SqlDataReader reader = comando490WC.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            beneficios.Add(new Beneficio490WC(int.Parse(reader["CodigoBeneficio490WC"].ToString()), reader["Nombre490WC"].ToString(), int.Parse(reader["PrecioEstrella490WC"].ToString()), int.Parse(reader["CantidadBeneficioReclamado490WC"].ToString()), float.Parse(reader["DescuentoAplicar490WC"].ToString())));
                        }
                    }
                }
            }
            return beneficios;
        }

        public List<Beneficio490WC> ObtenerBeneficiosPorCliente490WC(string DNI490WC)
        {
            List<Beneficio490WC> beneficios = new List<Beneficio490WC>();
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "SELECT b.* FROM Beneficio490WC b INNER JOIN Cliente_Beneficio490WC cb ON b.CodigoBeneficio490WC = cb.CodigoBeneficio490WC WHERE cb.DNICliente490WC = @DNICliente490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@DNICliente490WC", DNI490WC);
                    using (SqlDataReader reader = comando490WC.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            beneficios.Add(new Beneficio490WC(int.Parse(reader["CodigoBeneficio490WC"].ToString()), reader["Nombre490WC"].ToString(), int.Parse(reader["PrecioEstrella490WC"].ToString()), int.Parse(reader["CantidadBeneficioReclamado490WC"].ToString()), float.Parse(reader["DescuentoAplicar490WC"].ToString())));
                        }
                    }
                }
            }
            return beneficios;
        }

        public List<Beneficio490WC> ObtenerBeneficiosPorCantidadDeReclamados490WC(int cantidadReclamados)
        {
            List<Beneficio490WC> beneficios = new List<Beneficio490WC>();
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "SELECT * FROM Beneficio490WC WHERE CantidadBeneficioReclamado490WC >= @CantidadReclamados";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@CantidadReclamados", cantidadReclamados);
                    using (SqlDataReader reader = comando490WC.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            beneficios.Add(new Beneficio490WC(int.Parse(reader["CodigoBeneficio490WC"].ToString()), reader["Nombre490WC"].ToString(), int.Parse(reader["PrecioEstrella490WC"].ToString()), int.Parse(reader["CantidadBeneficioReclamado490WC"].ToString()), float.Parse(reader["DescuentoAplicar490WC"].ToString())));
                        }
                    }
                }
            }
            return beneficios;
        }

        #endregion

    }
}
