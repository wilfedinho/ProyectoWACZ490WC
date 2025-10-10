using FontAwesome.Sharp;
using SE490WC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DAL490WC
{
    public class BitacoraCambiosDAL490WC
    {
        public List<BitacoraCambioSE490WC> ObtenerEventosPorConsulta490WC(int CodigoBeneficioFiltrar490WC = 0, string nombreBeneficioFiltrar490WC = "", DateTime? fechaInicioFiltrar490WC = null, DateTime? fechaFinFiltrar490WC = null)
        {
            List<BitacoraCambioSE490WC> listaBitacora490WC = new List<BitacoraCambioSE490WC>();

            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();

                string query490WC = @"SELECT NumeroCambioRealizado490WC, CodigoBeneficio490WC, Nombre490WC, PrecioEstrella490WC, CantidadBeneficioReclamado490WC, DescuentoAplicar490WC, Fecha490WC, Hora490WC, Activo490WC FROM BeneficioCambios490WC WHERE 1=1";

                List<SqlParameter> parametros490WC = new List<SqlParameter>();

                bool hayFiltros490WC = false;

                if (!string.IsNullOrEmpty(nombreBeneficioFiltrar490WC))
                {
                    query490WC += " AND Nombre490WC = @Nombre";
                    parametros490WC.Add(new SqlParameter("@Nombre", nombreBeneficioFiltrar490WC));
                    hayFiltros490WC = true;
                }
                if (CodigoBeneficioFiltrar490WC > 0)
                {
                    query490WC += " AND CodigoBeneficio490WC = @Codigo";
                    parametros490WC.Add(new SqlParameter("@Codigo", CodigoBeneficioFiltrar490WC));
                    hayFiltros490WC = true;
                }
                if (fechaInicioFiltrar490WC.HasValue)
                {
                    query490WC += " AND Fecha490WC >= @FechaInicio";
                    parametros490WC.Add(new SqlParameter("@FechaInicio", fechaInicioFiltrar490WC.Value));
                    hayFiltros490WC = true;
                }
                if (fechaFinFiltrar490WC.HasValue)
                {
                    query490WC += " AND Fecha490WC <= @FechaFin";
                    parametros490WC.Add(new SqlParameter("@FechaFin", fechaFinFiltrar490WC.Value));
                    hayFiltros490WC = true;
                }


                if (!hayFiltros490WC)
                {
                    query490WC += " AND Fecha490WC >= @FechaUltimos3Dias";
                    parametros490WC.Add(new SqlParameter("@FechaUltimos3Dias", DateTime.Now.Date.AddDays(-2)));
                }

                using (SqlCommand cmd490WC = new SqlCommand(query490WC, cone490WC))
                {
                    cmd490WC.Parameters.AddRange(parametros490WC.ToArray());

                    using (SqlDataReader reader490WC = cmd490WC.ExecuteReader())
                    {
                        while (reader490WC.Read())
                        {
                            int NumeroCambioRealizado490WC = int.Parse(reader490WC["NumeroCambioRealizado490WC"].ToString());
                            int CodigoBeneficio490WC = int.Parse(reader490WC["CodigoBeneficio490WC"].ToString());
                            string Nombre490WC = reader490WC["Nombre490WC"].ToString();
                            int PrecioEstrella490WC = int.Parse(reader490WC["PrecioEstrella490WC"].ToString());
                            int CantidadBeneficioReclamado490WC = int.Parse(reader490WC["CantidadBeneficioReclamado490WC"].ToString());
                            float DescuentoAplicar490WC = float.Parse(reader490WC["DescuentoAplicar490WC"].ToString());
                            DateTime fecha490WC = Convert.ToDateTime(reader490WC["Fecha490WC"]);
                            TimeSpan hora490WC = (TimeSpan)reader490WC["Hora490WC"];
                            bool Activo490WC = (bool)reader490WC["Activo490WC"];

                            listaBitacora490WC.Add(new BitacoraCambioSE490WC(NumeroCambioRealizado490WC, CodigoBeneficio490WC, Nombre490WC, PrecioEstrella490WC, CantidadBeneficioReclamado490WC, DescuentoAplicar490WC, fecha490WC, hora490WC, Activo490WC));
                        }
                    }
                }
            }
            return listaBitacora490WC;
        }

        public List<BitacoraCambioSE490WC> ObtenerEventosSINFiltro()
        {
            List<BitacoraCambioSE490WC> listaBitacora490WC = new List<BitacoraCambioSE490WC>();

            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();

                string query490WC = @"SELECT NumeroCambioRealizado490WC, CodigoBeneficio490WC, Nombre490WC, PrecioEstrella490WC, CantidadBeneficioReclamado490WC, DescuentoAplicar490WC, Fecha490WC, Hora490WC, Activo490WC FROM BeneficioCambios490WC";

                using (SqlCommand cmd490WC = new SqlCommand(query490WC, cone490WC))
                {


                    using (SqlDataReader reader490WC = cmd490WC.ExecuteReader())
                    {
                        while (reader490WC.Read())
                        {
                            int NumeroCambioRealizado490WC = int.Parse(reader490WC["NumeroCambioRealizado490WC"].ToString());
                            int CodigoBeneficio490WC = int.Parse(reader490WC["CodigoBeneficio490WC"].ToString());
                            string Nombre490WC = reader490WC["Nombre490WC"].ToString();
                            int PrecioEstrella490WC = int.Parse(reader490WC["PrecioEstrella490WC"].ToString());
                            int CantidadBeneficioReclamado490WC = int.Parse(reader490WC["CantidadBeneficioReclamado490WC"].ToString());
                            float DescuentoAplicar490WC = float.Parse(reader490WC["DescuentoAplicar490WC"].ToString());
                            DateTime fecha490WC = Convert.ToDateTime(reader490WC["Fecha490WC"]);
                            TimeSpan hora490WC = (TimeSpan)reader490WC["Hora490WC"];
                            bool Activo490WC = (bool)reader490WC["Activo490WC"];

                            listaBitacora490WC.Add(new BitacoraCambioSE490WC(NumeroCambioRealizado490WC, CodigoBeneficio490WC, Nombre490WC, PrecioEstrella490WC, CantidadBeneficioReclamado490WC, DescuentoAplicar490WC, fecha490WC, hora490WC, Activo490WC));
                        }
                    }
                }
            }
            return listaBitacora490WC;
        }

        public bool RestaurarVersionBeneficio490WC(int numeroCambioRestaurar)
        {
            
            using (SqlConnection con = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                con.Open();

                try
                {
                    
                    BitacoraCambioSE490WC versionARestaurar = null;
                    string querySelect = @"SELECT CodigoBeneficio490WC, Nombre490WC, PrecioEstrella490WC, CantidadBeneficioReclamado490WC, DescuentoAplicar490WC, Fecha490WC, Hora490WC, Activo490WC 
                                 FROM BeneficioCambios490WC WHERE NumeroCambioRealizado490WC = @NumeroCambio";

                    using (SqlCommand cmdSelect = new SqlCommand(querySelect, con))
                    {
                        cmdSelect.Parameters.AddWithValue("@NumeroCambio", numeroCambioRestaurar);
                        using (SqlDataReader reader490WC = cmdSelect.ExecuteReader())
                        {
                            if (reader490WC.Read())
                            {
                                int CodigoBeneficio490WC = int.Parse(reader490WC["CodigoBeneficio490WC"].ToString());
                                string Nombre490WC = reader490WC["Nombre490WC"].ToString();
                                int PrecioEstrella490WC = int.Parse(reader490WC["PrecioEstrella490WC"].ToString());
                                int CantidadBeneficioReclamado490WC = int.Parse(reader490WC["CantidadBeneficioReclamado490WC"].ToString());
                                float DescuentoAplicar490WC = float.Parse(reader490WC["DescuentoAplicar490WC"].ToString());
                                DateTime fecha490WC = Convert.ToDateTime(reader490WC["Fecha490WC"]);
                                TimeSpan hora490WC = (TimeSpan)reader490WC["Hora490WC"];
                                bool Activo490WC = (bool)reader490WC["Activo490WC"];
                                versionARestaurar = new BitacoraCambioSE490WC(numeroCambioRestaurar, CodigoBeneficio490WC, Nombre490WC, PrecioEstrella490WC, CantidadBeneficioReclamado490WC, DescuentoAplicar490WC, fecha490WC, hora490WC, Activo490WC);
                            }
                        }
                    }

                    if (versionARestaurar == null) { return false; }

                    
                    string queryUpdateViejo = "UPDATE BeneficioCambios490WC SET Activo490WC = 0 WHERE CodigoBeneficio490WC = @CodigoBeneficio AND Activo490WC = 1";
                    using (SqlCommand cmdUpdateViejo = new SqlCommand(queryUpdateViejo, con))
                    {
                        cmdUpdateViejo.Parameters.AddWithValue("@CodigoBeneficio", versionARestaurar.CodigoBeneficio490WC);
                        cmdUpdateViejo.ExecuteNonQuery();
                    }

                    string queryUpdateNuevo = "UPDATE BeneficioCambios490WC SET Activo490WC = 1 WHERE NumeroCambioRealizado490WC = @NumeroCambio";
                    using (SqlCommand cmdUpdateNuevo = new SqlCommand(queryUpdateNuevo, con))
                    {
                        cmdUpdateNuevo.Parameters.AddWithValue("@NumeroCambio", numeroCambioRestaurar);
                        cmdUpdateNuevo.ExecuteNonQuery();
                    }

                    
                    try
                    {
                        
                        using (SqlCommand cmdDisable = new SqlCommand("DISABLE TRIGGER ALL ON Beneficio490WC", con))
                        {
                            cmdDisable.ExecuteNonQuery();
                        }

                        
                        int existe = 0;
                        string queryCheck = "SELECT COUNT(*) FROM Beneficio490WC WHERE CodigoBeneficio490WC = @CodigoBeneficio";
                        using (SqlCommand cmdCheck = new SqlCommand(queryCheck, con))
                        {
                            cmdCheck.Parameters.AddWithValue("@CodigoBeneficio", versionARestaurar.CodigoBeneficio490WC);
                            existe = (int)cmdCheck.ExecuteScalar();
                        }

                        if (existe > 0)
                        {
                            
                            string queryUpdatePrincipal = @"UPDATE Beneficio490WC SET Nombre490WC = @Nombre, PrecioEstrella490WC = @Precio, CantidadBeneficioReclamado490WC = @Cantidad, DescuentoAplicar490WC = @Descuento WHERE CodigoBeneficio490WC = @CodigoBeneficio";
                            using (SqlCommand cmdUpdatePrincipal = new SqlCommand(queryUpdatePrincipal, con))
                            {
                                cmdUpdatePrincipal.Parameters.AddWithValue("@Nombre", versionARestaurar.Nombre490WC);
                                cmdUpdatePrincipal.Parameters.AddWithValue("@Precio", versionARestaurar.PrecioEstrella490WC);
                                cmdUpdatePrincipal.Parameters.AddWithValue("@Cantidad", versionARestaurar.CantidadBeneficioReclamado490WC);
                                cmdUpdatePrincipal.Parameters.AddWithValue("@Descuento", versionARestaurar.DescuentoAplicar490WC);
                                cmdUpdatePrincipal.Parameters.AddWithValue("@CodigoBeneficio", versionARestaurar.CodigoBeneficio490WC);
                                cmdUpdatePrincipal.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            
                            string queryInsertPrincipal = @"INSERT INTO Beneficio490WC (CodigoBeneficio490WC, Nombre490WC, PrecioEstrella490WC, CantidadBeneficioReclamado490WC, DescuentoAplicar490WC) 
                                                  VALUES (@CodigoBeneficio, @Nombre, @Precio, @Cantidad, @Descuento)";
                            using (SqlCommand cmdInsertPrincipal = new SqlCommand(queryInsertPrincipal, con))
                            {
                                cmdInsertPrincipal.Parameters.AddWithValue("@CodigoBeneficio", versionARestaurar.CodigoBeneficio490WC);
                                cmdInsertPrincipal.Parameters.AddWithValue("@Nombre", versionARestaurar.Nombre490WC);
                                cmdInsertPrincipal.Parameters.AddWithValue("@Precio", versionARestaurar.PrecioEstrella490WC);
                                cmdInsertPrincipal.Parameters.AddWithValue("@Cantidad", versionARestaurar.CantidadBeneficioReclamado490WC);
                                cmdInsertPrincipal.Parameters.AddWithValue("@Descuento", versionARestaurar.DescuentoAplicar490WC);
                                cmdInsertPrincipal.ExecuteNonQuery();
                            }
                        }
                    }
                    finally
                    {
                        
                        using (SqlCommand cmdEnable = new SqlCommand("ENABLE TRIGGER ALL ON Beneficio490WC", con))
                        {
                            cmdEnable.ExecuteNonQuery();
                        }
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                //catch
                //{

                //    return false;
                //}
            }
        }

    }
}
