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
                string query = @"INSERT INTO Bitacora490WC
                        (IdBitacora490WC, Username490WC, Fecha490WC, Hora490WC, Modulo490WC, Descripcion490WC, Criticidad490WC) 
                         VALUES (@IdBitacora, @Username, @Fecha, @Hora, @Modulo, @Descripcion, @Criticidad)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdBitacora", BitacoraAlta490WC.IdBitacora490WC);
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


        public List<BitacoraSE490WC> ObtenerEventosPorConsulta490WC(string usuarioFiltrar490WC = "", string moduloFiltrar490WC = "", string descripcionFiltrar490WC = "", string criticidadFiltrar490WC = "", DateTime? fechaInicioFiltrar490WC = null, DateTime? fechaFinFiltrar490WC = null)
        {
            List<BitacoraSE490WC> listaBitacora490WC = new List<BitacoraSE490WC>();

            using (SqlConnection con = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                con.Open();


                string query = "SELECT IdBitacora490WC, Username490WC, Fecha490WC, Hora490WC, Modulo490WC, Descripcion490WC, Criticidad490WC FROM Bitacora490WC WHERE 1=1";


                List<SqlParameter> parametros = new List<SqlParameter>();

                if (!string.IsNullOrEmpty(usuarioFiltrar490WC))
                {
                    query += " AND Username490WC = @Username";
                    parametros.Add(new SqlParameter("@Username", usuarioFiltrar490WC));
                }
                if (!string.IsNullOrEmpty(moduloFiltrar490WC))
                {
                    query += " AND Modulo490WC = @Modulo";
                    parametros.Add(new SqlParameter("@Modulo", moduloFiltrar490WC));
                }
                if (!string.IsNullOrEmpty(descripcionFiltrar490WC))
                {
                    query += " AND Descripcion490WC = @Descripcion";
                    parametros.Add(new SqlParameter("@Descripcion", descripcionFiltrar490WC));
                }
                if (!string.IsNullOrEmpty(criticidadFiltrar490WC))
                {
                    query += " AND Criticidad490WC = @Criticidad";
                    parametros.Add(new SqlParameter("@Criticidad", criticidadFiltrar490WC));
                }
                if (fechaInicioFiltrar490WC.HasValue)
                {
                    query += " AND Fecha490WC >= @FechaInicio";
                    parametros.Add(new SqlParameter("@FechaInicio", fechaInicioFiltrar490WC.Value));
                }
                if (fechaFinFiltrar490WC.HasValue)
                {
                    query += " AND Fecha490WC <= @FechaFin";
                    parametros.Add(new SqlParameter("@FechaFin", fechaFinFiltrar490WC.Value));
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddRange(parametros.ToArray());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idBitacora490WC = Convert.ToInt32(reader["IdBitacora490WC"]);
                            string username490WC = reader["Username490WC"].ToString();
                            DateTime fecha490WC = Convert.ToDateTime(reader["Fecha490WC"]);
                            TimeSpan hora490WC = (TimeSpan)reader["Hora490WC"];
                            string modulo490WC = reader["Modulo490WC"].ToString();
                            string descripcion490WC = reader["Descripcion490WC"].ToString();
                            int criticidad490WC = Convert.ToInt32(reader["Criticidad490WC"]);

                            listaBitacora490WC.Add(new BitacoraSE490WC(
                                username490WC, fecha490WC, hora490WC, modulo490WC, descripcion490WC, criticidad490WC, idBitacora490WC
                            ));
                        }
                    }
                }
            }

            return listaBitacora490WC;
        }


    }
}
