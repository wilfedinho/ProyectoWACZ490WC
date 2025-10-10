using SE490WC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL490WC
{
    internal class BitacoraCambiosDAL490WC
    {
        public List<BitacoraCambioSE490WC> ObtenerEventosPorConsulta490WC(int CodigoBeneficioFiltrar490WC = 0, string nombreBeneficioFiltrar490WC = "",  DateTime? fechaInicioFiltrar490WC = null, DateTime? fechaFinFiltrar490WC = null)
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

                            listaBitacora490WC.Add(new BitacoraCambioSE490WC(NumeroCambioRealizado490WC,CodigoBeneficio490WC,Nombre490WC,PrecioEstrella490WC,CantidadBeneficioReclamado490WC,DescuentoAplicar490WC,fecha490WC,hora490WC,Activo490WC));
                        }
                    }
                }
            }
            return listaBitacora490WC;
        }

        public List<BitacoraSE490WC> ObtenerEventosSINFiltro()
        {
            List<BitacoraSE490WC> listaBitacora490WC = new List<BitacoraSE490WC>();

            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();

                string query490WC = @"SELECT IdBitacora490WC, Username490WC, Fecha490WC, Hora490WC, Modulo490WC, Descripcion490WC, Criticidad490WC FROM Bitacora490WC";

                using (SqlCommand cmd490WC = new SqlCommand(query490WC, cone490WC))
                {


                    using (SqlDataReader reader490WC = cmd490WC.ExecuteReader())
                    {
                        while (reader490WC.Read())
                        {
                            string idBitacora490WC = reader490WC["IdBitacora490WC"].ToString();
                            string username490WC = reader490WC["Username490WC"].ToString();
                            DateTime fecha490WC = Convert.ToDateTime(reader490WC["Fecha490WC"]);
                            TimeSpan hora490WC = (TimeSpan)reader490WC["Hora490WC"];
                            string modulo490WC = reader490WC["Modulo490WC"].ToString();
                            string descripcion490WC = reader490WC["Descripcion490WC"].ToString();
                            int criticidad490WC = Convert.ToInt32(reader490WC["Criticidad490WC"]);

                            listaBitacora490WC.Add(new BitacoraSE490WC(username490WC, fecha490WC, hora490WC, modulo490WC, descripcion490WC, criticidad490WC, idBitacora490WC));
                        }
                    }
                }
            }
            return listaBitacora490WC;
        }
    }
}
