using BE490WC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL490WC
{
    public class FacturaDAL490WC
    {
        public void Alta490WC(Factura490WC FacturaAlta490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();

                string query = "INSERT INTO Factura490WC (NumeroFactura490WC, Nombre490WC, Apellido490WC, DNI490WC, FechaEmision490WC, HoraEmision490WC, NumeroBoleto490WC, Subtotal490WC, Total490WC, BeneficioAplicado490WC) VALUES (@NumeroFactura, @Nombre, @Apellido, @DNI, @Fecha, @Hora, @NumeroBoleto, @Subtotal, @Total, @Beneficio)";

                using (SqlCommand comando = new SqlCommand(query, cone490WC))
                {
                    comando.Parameters.AddWithValue("@NumeroFactura", FacturaAlta490WC.NumeroFactura490WC);
                    comando.Parameters.AddWithValue("@Nombre", FacturaAlta490WC.Nombre490WC);
                    comando.Parameters.AddWithValue("@Apellido", FacturaAlta490WC.Apellido490WC);
                    comando.Parameters.AddWithValue("@DNI", FacturaAlta490WC.DNIC490WC);
                    comando.Parameters.AddWithValue("@Fecha", FacturaAlta490WC.FechaEmision490WC);
                    comando.Parameters.AddWithValue("@Hora", FacturaAlta490WC.HoraEmision490WC);
                    comando.Parameters.AddWithValue("@NumeroBoleto", FacturaAlta490WC.NumeroBoleto490WC.ToString());
                    comando.Parameters.AddWithValue("@Subtotal", FacturaAlta490WC.Subtotal490WC);
                    comando.Parameters.AddWithValue("@Total", FacturaAlta490WC.Total490WC);

                    if (string.IsNullOrWhiteSpace(FacturaAlta490WC.BeneficioAplicado490WC))
                        comando.Parameters.AddWithValue("@Beneficio", DBNull.Value);
                    else
                        comando.Parameters.AddWithValue("@Beneficio", FacturaAlta490WC.BeneficioAplicado490WC);

                    comando.ExecuteNonQuery();
                }
            }
        }



        public List<Factura490WC> ObtenerTodasLasFacturas490WC()
        {
            List<Factura490WC> facturas490WC = new List<Factura490WC>();

            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "SELECT * FROM Factura490WC";

                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    using (SqlDataReader reader = comando490WC.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string beneficioAplicado = null;
                            if (reader["BeneficioAplicado490WC"] != DBNull.Value)
                            {
                                beneficioAplicado = reader["BeneficioAplicado490WC"].ToString();
                            }

                            Factura490WC factura = new Factura490WC(
                                numeroFactura: Convert.ToInt32(reader["NumeroFactura490WC"]),
                                nombreCliente: reader["Nombre490WC"].ToString(),
                                apellidoCliente: reader["Apellido490WC"].ToString(),
                                dniCliente: reader["DNI490WC"].ToString(),
                                fechaEmision: reader["FechaEmision490WC"].ToString(),
                                horaEmision: reader["HoraEmision490WC"].ToString(),
                                numeroBoleto: reader["NumeroBoleto490WC"].ToString(),
                                subtotal: Convert.ToSingle(reader["Subtotal490WC"]),
                                total: Convert.ToSingle(reader["Total490WC"]),
                                beneficioAplicado490WC: beneficioAplicado
                            );

                            facturas490WC.Add(factura);
                        }
                    }
                }
            }

            return facturas490WC;
        }



    }
}
