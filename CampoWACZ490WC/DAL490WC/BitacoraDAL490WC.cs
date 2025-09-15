using SE490WC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL490WC
{
    public class BitacoraDAL490WC
    {
        public void Alta490WC(BitacoraSE490WC BitacoraAlta490WC)
        {
            using (SqlConnection con = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                con.Open();
                string query = @"INSERT INTO Bitacora490WC (Username490WC, Fecha490WC, Hora490WC, Modulo490WC, Descripcion490WC, Criticidad490WC) VALUES (@Username, @Fecha, @Hora, @Modulo, @Descripcion, @Criticidad)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", BitacoraAlta490WC.Username490WC);
                    cmd.Parameters.AddWithValue("@Fecha", BitacoraAlta490WC.Fecha490WC);
                    cmd.Parameters.AddWithValue("@Hora", BitacoraAlta490WC.Hora490WC);
                    cmd.Parameters.AddWithValue("@Modulo", BitacoraAlta490WC.Modulo490WC);
                    cmd.Parameters.AddWithValue("@Descripcion", BitacoraAlta490WC.Descripcion490WC);
                    cmd.Parameters.AddWithValue("@Criticidad", BitacoraAlta490WC.Criticidad490WC);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<string> ObtenerDescripcion490WC(string Modulo490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                List<string> listaDescripcion490WC = new List<string>();
                string query490WC = @"SELECT DISTINCT Descripcion490WC FROM Bitacora490WC WHERE Modulo490WC = @Modulo490WC";
                using (SqlCommand cmd490WC = new SqlCommand(query490WC, cone490WC))
                {
                    cmd490WC.Parameters.AddWithValue("@Modulo490WC", Modulo490WC);
                    cone490WC.Open();
                    using (SqlDataReader reader490WC = cmd490WC.ExecuteReader())
                    {
                        while (reader490WC.Read())
                        {
                            listaDescripcion490WC.Add(reader490WC["Descripcion490WC"].ToString());
                        }
                    }
                }
                return listaDescripcion490WC;
            }
        }

        public List<BitacoraSE490WC> ObtenerEventosPorConsulta490WC(string usuarioFiltrar490WC = "", string moduloFiltrar490WC = "", string descripcionFiltrar490WC = "", string criticidadFiltrar490WC = "", DateTime? fechaInicioFiltrar490WC = null, DateTime? fechaFinFiltrar490WC = null)
        {
            List<BitacoraSE490WC> listaBitacora490WC = new List<BitacoraSE490WC>();

            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();

                string query490WC = @"SELECT IdBitacora490WC, Username490WC, Fecha490WC, Hora490WC, Modulo490WC, Descripcion490WC, Criticidad490WC FROM Bitacora490WC WHERE 1=1";

                List<SqlParameter> parametros490WC = new List<SqlParameter>();

                bool hayFiltros490WC = false;

                if (!string.IsNullOrEmpty(usuarioFiltrar490WC))
                {
                    query490WC += " AND Username490WC = @Username";
                    parametros490WC.Add(new SqlParameter("@Username", usuarioFiltrar490WC));
                    hayFiltros490WC = true;
                }
                if (!string.IsNullOrEmpty(moduloFiltrar490WC))
                {
                    query490WC += " AND Modulo490WC = @Modulo";
                    parametros490WC.Add(new SqlParameter("@Modulo", moduloFiltrar490WC));
                    hayFiltros490WC = true;
                }
                if (!string.IsNullOrEmpty(descripcionFiltrar490WC))
                {
                    query490WC += " AND Descripcion490WC = @Descripcion";
                    parametros490WC.Add(new SqlParameter("@Descripcion", descripcionFiltrar490WC));
                    hayFiltros490WC = true;
                }
                if (!string.IsNullOrEmpty(criticidadFiltrar490WC))
                {
                    query490WC += " AND Criticidad490WC = @Criticidad";
                    parametros490WC.Add(new SqlParameter("@Criticidad", criticidadFiltrar490WC));
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
