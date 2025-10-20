using BE490WC;
using System;
using System.Collections.Generic;
using System.Data;
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
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();

                
                string queryMaxId = "SELECT ISNULL(MAX(CodigoBeneficio490WC), 0) + 1 FROM Beneficio490WC";
                using (SqlCommand cmdMaxId = new SqlCommand(queryMaxId, cone490WC))
                {
                    int nuevoId = Convert.ToInt32(cmdMaxId.ExecuteScalar());
                    BeneficioAlta490WC.CodigoBeneficio490WC = nuevoId;
                }

                
                string queryInsert = "INSERT INTO Beneficio490WC (CodigoBeneficio490WC, Nombre490WC, PrecioEstrella490WC, CantidadBeneficioReclamado490WC, DescuentoAplicar490WC) VALUES (@CodigoBeneficio490WC, @Nombre490WC, @PrecioEstrella490WC, @CantidadBeneficioReclamado490WC, @DescuentoAplicar490WC)";

                using (SqlCommand comando490WC = new SqlCommand(queryInsert, cone490WC))
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


        public bool Baja490WC(int ID490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();

                string queryVerificacion490WC = "SELECT COUNT(*) FROM Cliente_Beneficio490WC WHERE CodigoBeneficio490WC = @ID";
                using (SqlCommand cmdVerificacion490WC = new SqlCommand(queryVerificacion490WC, cone490WC))
                {
                    cmdVerificacion490WC.Parameters.AddWithValue("@ID", ID490WC);
                    int cantidadRelacionada = (int)cmdVerificacion490WC.ExecuteScalar();

                    if (cantidadRelacionada > 0)
                    {
                  
                        return false;
                    }
                }

           
                string queryEliminar490WC = "DELETE FROM Beneficio490WC WHERE CodigoBeneficio490WC = @ID";
                using (SqlCommand cmdEliminar490WC = new SqlCommand(queryEliminar490WC, cone490WC))
                {
                    cmdEliminar490WC.Parameters.AddWithValue("@ID", ID490WC);
                    cmdEliminar490WC.ExecuteNonQuery();
                }

                return true;
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

        public void AgregarBeneficioACliente490WC(string DNICliente490WC, int CodigoBeneficio490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "INSERT INTO Cliente_Beneficio490WC (DNI490WC, CodigoBeneficio490WC) VALUES (@DNICliente490WC, @CodigoBeneficio490WC)";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@DNICliente490WC", DNICliente490WC);
                    comando490WC.Parameters.AddWithValue("@CodigoBeneficio490WC", CodigoBeneficio490WC);
                    comando490WC.ExecuteNonQuery();
                }
            }
        }

        public void EliminarBeneficioDeCliente490WC(string DNICliente490WC, int CodigoBeneficio490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open(); 
                string query490WC = "DELETE FROM Cliente_Beneficio490WC WHERE DNI490WC = @DNICliente490WC AND CodigoBeneficio490WC = @CodigoBeneficio490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@DNICliente490WC", DNICliente490WC);
                    comando490WC.Parameters.AddWithValue("@CodigoBeneficio490WC", CodigoBeneficio490WC);
                    comando490WC.ExecuteNonQuery();
                }
            }
        }

        public void ReducirSaldoEstrellas490WC(string DNICliente490WC, int cantidadEstrellas490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "UPDATE Cliente490WC SET EstrellasCliente490WC = EstrellasCliente490WC - @CantidadEstrellas490WC WHERE DNI490WC = @DNICliente490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@CantidadEstrellas490WC", cantidadEstrellas490WC);
                    comando490WC.Parameters.AddWithValue("@DNICliente490WC", DNICliente490WC);
                    comando490WC.ExecuteNonQuery();
                }
            }
        }

        public void AplicarBeneficio490WC(string IDBoleto490WC, float DescuentoAplicar490WC, string nombreBeneficio490WC) 
        {
            using(SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "UPDATE Boleto490WC SET Precio490WC = Precio490WC * (1 - @PorcentajeDescuento), BeneficioAplicado490WC = @BeneficioAplicado490WC WHERE ID490WC = @ID490WC;";
                using(SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@PorcentajeDescuento", DescuentoAplicar490WC);
                    comando490WC.Parameters.AddWithValue("@ID490WC", IDBoleto490WC);
                    comando490WC.Parameters.AddWithValue("@BeneficioAplicado490WC", nombreBeneficio490WC);
                    comando490WC.ExecuteNonQuery();
                }
            }

        }

        public bool ExisteNombreBeneficioAlta490WC(string nombreBeneficio490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "SELECT COUNT(*) FROM Beneficio490WC WHERE Nombre490WC = @Nombre";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@Nombre", nombreBeneficio490WC);
                    int cantidad = (int)comando490WC.ExecuteScalar();
                    return cantidad > 0;
                }
            }
        }

        public bool ExisteNombreBeneficioModificar490WC(string nombreBeneficio490WC, int idActual490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "SELECT COUNT(*) FROM Beneficio490WC WHERE Nombre490WC = @Nombre AND CodigoBeneficio490WC <> @ID";

                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@Nombre", nombreBeneficio490WC);
                    comando490WC.Parameters.AddWithValue("@ID", idActual490WC);
                    int cantidad = (int)comando490WC.ExecuteScalar();
                    return cantidad > 0;
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
                string query490WC = "SELECT b.* FROM Beneficio490WC b INNER JOIN Cliente_Beneficio490WC cb ON b.CodigoBeneficio490WC = cb.CodigoBeneficio490WC WHERE cb.DNI490WC = @DNI490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@DNI490WC", DNI490WC);
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

        public DataTable ObtenerReporteBeneficiosMayorCanje490WC()
        {
            DataTable dtReporte490WC = new DataTable();
            
            dtReporte490WC.Columns.Add("Nombre", typeof(string));
            dtReporte490WC.Columns.Add("Cantidad", typeof(int));

            
            string query490WC = "SELECT Nombre490WC, CantidadBeneficioReclamado490WC FROM Beneficio490WC ORDER BY CantidadBeneficioReclamado490WC DESC;";

            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    using (SqlDataReader reader490WC = comando490WC.ExecuteReader())
                    {
                        while (reader490WC.Read())
                        {
                            
                            dtReporte490WC.Rows.Add(reader490WC["Nombre490WC"].ToString(), int.Parse(reader490WC["CantidadBeneficioReclamado490WC"].ToString()));
                        }
                    }
                }
            }
            return dtReporte490WC; 
        }


    }
}
