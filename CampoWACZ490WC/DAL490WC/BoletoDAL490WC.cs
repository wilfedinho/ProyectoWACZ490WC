using BE490WC;
using SERVICIOS490WC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL490WC
{
    public class BoletoDAL490WC
    {


        #region Operaciones Boleto

        public void Alta490WC(Boleto490WC BoletoAgregar490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "";
                if (BoletoAgregar490WC is BoletoIDA490WC boletoIDA490WC)
                {
                    query490WC = "INSERT INTO Boleto490WC (ID490WC, Origen490WC, Destino490WC, FechaPartidaIDA490WC, FechaLlegadaIDA490WC, IsVendido490WC, PesoEquipajePermitido490WC, ClaseBoleto490WC, Precio490WC, Titular490WC, NumeroAsiento490WC) VALUES (@ID490WC, @Origen490WC, @Destino490WC, @FechaPartidaIDA490WC, @FechaLlegadaIDA490WC, @IsVendido490WC, @PesoEquipajePermitido490WC, @ClaseBoleto490WC, @Precio490WC, @Titular490WC, @NumeroAsiento490WC)";
                    using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                    {
                        comando490WC.Parameters.AddWithValue("@ID490WC", boletoIDA490WC.IDBoleto490WC);
                        comando490WC.Parameters.AddWithValue("@Origen490WC", boletoIDA490WC.Origen490WC);
                        comando490WC.Parameters.AddWithValue("@Destino490WC", boletoIDA490WC.Destino490WC);
                        comando490WC.Parameters.AddWithValue("@FechaPartidaIDA490WC", boletoIDA490WC.FechaPartida490WC);
                        comando490WC.Parameters.AddWithValue("@FechaLlegadaIDA490WC", boletoIDA490WC.FechaLlegada490WC);
                        comando490WC.Parameters.AddWithValue("@IsVendido490WC", boletoIDA490WC.IsVendido490WC);
                        comando490WC.Parameters.AddWithValue("@PesoEquipajePermitido490WC", boletoIDA490WC.EquipajePermitido490WC);
                        comando490WC.Parameters.AddWithValue("@ClaseBoleto490WC", boletoIDA490WC.ClaseBoleto490WC);
                        comando490WC.Parameters.AddWithValue("@Precio490WC", boletoIDA490WC.Precio490WC);
                        comando490WC.Parameters.AddWithValue("@Titular490WC", boletoIDA490WC.Titular490WC.DNI490WC);
                        comando490WC.Parameters.AddWithValue("@NumeroAsiento490WC", boletoIDA490WC.NumeroAsiento490WC);

                        comando490WC.ExecuteNonQuery();
                    }
                }

                if (BoletoAgregar490WC is BoletoIDAVUELTA490WC boletoIDAVUELTA490WC)
                {
                    query490WC = "INSERT INTO Boleto490WC (ID490WC, Origen490WC, Destino490WC, FechaPartidaIDA490WC, FechaLlegadaIDA490WC, FechaPartidaVUELTA490WC, FechaLlegadaVUELTA490WC, IsVendido490WC, PesoEquipajePermitido490WC, ClaseBoleto490WC, Precio490WC, Titular490WC, NumeroAsiento490WC) VALUES (@ID490WC, @Origen490WC, @Destino490WC, @FechaPartidaIDA490WC, @FechaLlegadaIDA490WC, @FechaPartidaVUELTA490WC, @FechaLlegadaVUELTA490WC, @IsVendido490WC, @PesoEquipajePermitido490WC, @ClaseBoleto490WC, @Precio490WC, @Titular490WC, @NumeroAsiento490WC)";
                    using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                    {
                        comando490WC.Parameters.AddWithValue("@ID490WC", boletoIDAVUELTA490WC.IDBoleto490WC);
                        comando490WC.Parameters.AddWithValue("@Origen490WC", boletoIDAVUELTA490WC.Origen490WC);
                        comando490WC.Parameters.AddWithValue("@Destino490WC", boletoIDAVUELTA490WC.Destino490WC);
                        comando490WC.Parameters.AddWithValue("@FechaPartidaIDA490WC", boletoIDAVUELTA490WC.FechaPartida490WC);
                        comando490WC.Parameters.AddWithValue("@FechaPartidaVUELTA490WC", boletoIDAVUELTA490WC.FechaPartidaVUELTA490WC);
                        comando490WC.Parameters.AddWithValue("@FechaLlegadaIDA490WC", boletoIDAVUELTA490WC.FechaLlegada490WC);
                        comando490WC.Parameters.AddWithValue("@FechaLlegadaVUELTA490WC", boletoIDAVUELTA490WC.FechaLlegadaVUELTA490WC);
                        comando490WC.Parameters.AddWithValue("@IsVendido490WC", boletoIDAVUELTA490WC.IsVendido490WC);
                        comando490WC.Parameters.AddWithValue("@PesoEquipajePermitido490WC", boletoIDAVUELTA490WC.EquipajePermitido490WC);
                        comando490WC.Parameters.AddWithValue("@ClaseBoleto490WC", boletoIDAVUELTA490WC.ClaseBoleto490WC);
                        comando490WC.Parameters.AddWithValue("@Precio490WC", boletoIDAVUELTA490WC.Precio490WC);
                        comando490WC.Parameters.AddWithValue("@Titular490WC", boletoIDAVUELTA490WC.Titular490WC.DNI490WC);
                        comando490WC.Parameters.AddWithValue("@NumeroAsiento490WC", boletoIDAVUELTA490WC.NumeroAsiento490WC);

                        comando490WC.ExecuteNonQuery();
                    }
                }
            }
        }

        public void Baja490WC(string IDBoleto490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "DELETE FROM Boleto490WC WHERE ID490WC = @IDBoleto490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@IDBoleto490WC", IDBoleto490WC);
                    comando490WC.ExecuteNonQuery();
                }
            }
        }

        public void Modificar490WC(Boleto490WC BoletoModificado490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "";
                if (BoletoModificado490WC is BoletoIDA490WC boletoIDA490WC)
                {
                    query490WC = "UPDATE Boleto490WC SET Origen490WC = @Origen490WC, Destino490WC = @Destino490WC, FechaPartidaIDA490WC = @FechaPartidaIDA490WC, FechaLlegadaIDA490WC = @FechaLlegadaIDA490WC, IsVendido490WC = @IsVendido490WC, PesoEquipajePermitido490WC = @PesoEquipajePermitido490WC, ClaseBoleto490WC = @ClaseBoleto490WC, Precio490WC = @Precio490WC, Titular490WC = @Titular490WC, NumeroAsiento490WC = @NumeroAsiento490WC WHERE ID490WC = @ID490WC";
                    using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                    {
                        comando490WC.Parameters.AddWithValue("@ID490WC", boletoIDA490WC.IDBoleto490WC);
                        comando490WC.Parameters.AddWithValue("@Origen490WC", boletoIDA490WC.Origen490WC);
                        comando490WC.Parameters.AddWithValue("@Destino490WC", boletoIDA490WC.Destino490WC);
                        comando490WC.Parameters.AddWithValue("@FechaPartidaIDA490WC", boletoIDA490WC.FechaPartida490WC);
                        comando490WC.Parameters.AddWithValue("@FechaLlegadaIDA490WC", boletoIDA490WC.FechaLlegada490WC);
                        comando490WC.Parameters.AddWithValue("@IsVendido490WC", boletoIDA490WC.IsVendido490WC);
                        comando490WC.Parameters.AddWithValue("@PesoEquipajePermitido490WC", boletoIDA490WC.EquipajePermitido490WC);
                        comando490WC.Parameters.AddWithValue("@ClaseBoleto490WC", boletoIDA490WC.ClaseBoleto490WC);
                        comando490WC.Parameters.AddWithValue("@Precio490WC", boletoIDA490WC.Precio490WC);
                        comando490WC.Parameters.AddWithValue("@Titular490WC", boletoIDA490WC.Titular490WC.DNI490WC);
                        comando490WC.Parameters.AddWithValue("@NumeroAsiento490WC", boletoIDA490WC.NumeroAsiento490WC);

                        comando490WC.ExecuteNonQuery();
                    }
                }

                if (BoletoModificado490WC is BoletoIDAVUELTA490WC boletoIDAVUELTA490WC)
                {
                    query490WC = "UPDATE Boleto490WC SET Origen490WC = @Origen490WC, Destino490WC = @Destino490WC, FechaPartidaIDA490WC = @FechaPartidaIDA490WC, FechaLlegadaIDA490WC = @FechaLlegadaIDA490WC, FechaPartidaVUELTA490WC = @FechaPartidaVUELTA490WC, FechaLlegadaVUELTA490WC = @FechaLlegadaVUELTA490WC, IsVendido490WC = @IsVendido490WC, PesoEquipajePermitido490WC = @PesoEquipajePermitido490WC, ClaseBoleto490WC = @ClaseBoleto490WC, Precio490WC = @Precio490WC, Titular490WC = @Titular490WC, NumeroAsiento490WC = @NumeroAsiento490WC WHERE ID490WC = @ID490WC";
                    using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                    {
                        comando490WC.Parameters.AddWithValue("@ID490WC", boletoIDAVUELTA490WC.IDBoleto490WC);
                        comando490WC.Parameters.AddWithValue("@Origen490WC", boletoIDAVUELTA490WC.Origen490WC);
                        comando490WC.Parameters.AddWithValue("@Destino490WC", boletoIDAVUELTA490WC.Destino490WC);
                        comando490WC.Parameters.AddWithValue("@FechaPartidaIDA490WC", boletoIDAVUELTA490WC.FechaPartida490WC);
                        comando490WC.Parameters.AddWithValue("@FechaLlegadaIDA490WC", boletoIDAVUELTA490WC.FechaLlegada490WC);
                        comando490WC.Parameters.AddWithValue("@FechaPartidaVUELTA490WC", boletoIDAVUELTA490WC.FechaPartidaVUELTA490WC);
                        comando490WC.Parameters.AddWithValue("@FechaLlegadaVUELTA490WC", boletoIDAVUELTA490WC.FechaLlegadaVUELTA490WC);
                        comando490WC.Parameters.AddWithValue("@IsVendido490WC", boletoIDAVUELTA490WC.IsVendido490WC);
                        comando490WC.Parameters.AddWithValue("@PesoEquipajePermitido490WC", boletoIDAVUELTA490WC.EquipajePermitido490WC);
                        comando490WC.Parameters.AddWithValue("@ClaseBoleto490WC", boletoIDAVUELTA490WC.ClaseBoleto490WC);
                        comando490WC.Parameters.AddWithValue("@Precio490WC", boletoIDAVUELTA490WC.Precio490WC);
                        comando490WC.Parameters.AddWithValue("@Titular490WC", boletoIDAVUELTA490WC.Titular490WC.DNI490WC);
                        comando490WC.Parameters.AddWithValue("@NumeroAsiento490WC", boletoIDAVUELTA490WC.NumeroAsiento490WC);

                        comando490WC.ExecuteNonQuery();
                    }
                }
            }
        }

        public void AsignarBoletoCliente490WC(Boleto490WC boletoAsignar490WC, Cliente490WC clienteAsignar490WC)
        {
            using(SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "UPDATE Boleto490WC SET Titular490WC = @Titular490WC, FechaBoletoGenerado490WC = @FechaBoletoGenerado490WC WHERE ID490WC = @ID490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@ID490WC", boletoAsignar490WC.IDBoleto490WC);
                    comando490WC.Parameters.AddWithValue("@Titular490WC", clienteAsignar490WC.DNI490WC);
                    comando490WC.Parameters.AddWithValue("@FechaBoletoGenerado490WC", DateTime.Now);

                    comando490WC.ExecuteNonQuery();
                }
            }
        }


        public void GenerarBoletoCompra490WC(Boleto490WC boletoGenerar490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "UPDATE Boleto490WC SET Titular490WC = @Titular490WC, FechaBoletoGenerado490WC = @FechaBoletoGenerado490WC WHERE ID490WC = @ID490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@ID490WC", boletoGenerar490WC.IDBoleto490WC);
                    comando490WC.Parameters.AddWithValue("@Titular490WC", boletoGenerar490WC.IDBoleto490WC);
                    comando490WC.Parameters.AddWithValue("@FechaBoletoGenerado490WC", DateTime.Now);

                    comando490WC.ExecuteNonQuery();
                }
            }
        }

        public void LiberarBoletosVencidos490WC()
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "UPDATE Boleto490WC SET Titular490WC = 'Sistema', FechaBoletoGenerado490WC = NULL WHERE IsVendido490WC = 0 AND FechaBoletoGenerado490WC IS NOT NULL AND DATEADD(hour, 8, FechaBoletoGenerado490WC) <= SYSDATETIME()";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.ExecuteNonQuery();
                }
            }
        }


        public void CobrarBoleto490WC(Boleto490WC BoletoCobrado490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string query490WC = "UPDATE Boleto490WC SET IsVendido490WC = 1 WHERE ID490WC = @ID490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@ID490WC", BoletoCobrado490WC.IDBoleto490WC);
                    comando490WC.ExecuteNonQuery();
                }
            }
        }



        #endregion

        #region Busqueda Boleto

        public List<Boleto490WC> ObtenerBoletosPorModalidad490WC(string Modalidad490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                List<Boleto490WC> boletos490WC = new List<Boleto490WC>();
                List<Cliente490WC> Titulares490WC = new ClienteDAL490WC().ObtenerTodosLosCliente490WC();
                cone490WC.Open();
                string query490WC = "";
                if (Modalidad490WC == "IDA")
                {
                    query490WC = "SELECT * FROM Boleto490WC WHERE FechaPartidaVUELTA490WC IS NULL OR FechaLlegadaVUELTA490WC IS NULL";
                    using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                    {
                        using (SqlDataReader reader = comando490WC.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Boleto490WC boletoIDA490WC = new BoletoIDA490WC(
                                    reader["ID490WC"].ToString(),
                                    reader["Origen490WC"].ToString(),
                                    reader["Destino490WC"].ToString(),
                                    Convert.ToDateTime(reader["FechaPartidaIDA490WC"]),
                                    Convert.ToDateTime(reader["FechaLlegadaIDA490WC"]),
                                    Convert.ToBoolean(reader["IsVendido490WC"]),
                                    Convert.ToSingle(reader["PesoEquipajePermitido490WC"]),
                                    reader["ClaseBoleto490WC"].ToString(),
                                    Convert.ToSingle(reader["Precio490WC"]),
                                    Titulares490WC.Find(x => x.DNI490WC == reader["Titular490WC"].ToString()),
                                    reader["NumeroAsiento490WC"].ToString()
                                );
                                boletos490WC.Add(boletoIDA490WC);
                            }
                        }
                    }
                }

                if (Modalidad490WC == "IDAVUELTA")
                {
                    query490WC = "SELECT * FROM Boleto490WC WHERE FechaPartidaVUELTA490WC IS NOT NULL AND FechaLlegadaVUELTA490WC IS NOT NULL";
                    using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                    {
                        using (SqlDataReader reader = comando490WC.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Boleto490WC boletoIDA490WC = new BoletoIDAVUELTA490WC(
                                    reader["ID490WC"].ToString(),
                                    reader["Origen490WC"].ToString(),
                                    reader["Destino490WC"].ToString(),
                                    Convert.ToDateTime(reader["FechaPartidaIDA490WC"]),
                                    Convert.ToDateTime(reader["FechaLlegadaIDA490WC"]),
                                    Convert.ToDateTime(reader["FechaPartidaVUELTA490WC"]),
                                    Convert.ToDateTime(reader["FechaLlegadaVUELTA490WC"]),
                                    Convert.ToBoolean(reader["IsVendido490WC"]),
                                    Convert.ToSingle(reader["PesoEquipajePermitido490WC"]),
                                    reader["ClaseBoleto490WC"].ToString(),
                                    Convert.ToSingle(reader["Precio490WC"]),
                                   Titulares490WC.Find(x => x.DNI490WC == reader["Titular490WC"].ToString()),
                                   reader["NumeroAsiento490WC"].ToString()
                                );
                                boletos490WC.Add(boletoIDA490WC);
                            }
                        }
                    }
                }

                return boletos490WC;
            }
        }

        public Boleto490WC ObtenerBoletoPorID490WC(string ID490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                List<Cliente490WC> Titulares490WC = new ClienteDAL490WC().ObtenerTodosLosCliente490WC();
                cone490WC.Open();
                string query490WC = "SELECT * FROM Boleto490WC WHERE ID490WC = @ID490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@ID490WC", ID490WC);
                    using (SqlDataReader reader = comando490WC.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["FechaPartidaVUELTA490WC"] == DBNull.Value || reader["FechaLlegadaVUELTA490WC"] == DBNull.Value)
                            {
                                return new BoletoIDA490WC(
                                    reader["ID490WC"].ToString(),
                                    reader["Origen490WC"].ToString(),
                                    reader["Destino490WC"].ToString(),
                                    Convert.ToDateTime(reader["FechaPartidaIDA490WC"]),
                                    Convert.ToDateTime(reader["FechaLlegadaIDA490WC"]),
                                    Convert.ToBoolean(reader["IsVendido490WC"]),
                                    Convert.ToSingle(reader["PesoEquipajePermitido490WC"]),
                                    reader["ClaseBoleto490WC"].ToString(),
                                    Convert.ToSingle(reader["Precio490WC"]),
                                    Titulares490WC.Find(x => x.DNI490WC == ID490WC),
                                    reader["NumeroAsiento490WC"].ToString()
                                );
                            }
                            else
                            {
                                return new BoletoIDAVUELTA490WC(
                                    reader["ID490WC"].ToString(),
                                    reader["Origen490WC"].ToString(),
                                    reader["Destino490WC"].ToString(),
                                    Convert.ToDateTime(reader["FechaPartidaIDA490WC"]),
                                    Convert.ToDateTime(reader["FechaLlegadaIDA490WC"]),
                                    Convert.ToDateTime(reader["FechaPartidaVUELTA490WC"]),
                                    Convert.ToDateTime(reader["FechaLlegadaVUELTA490WC"]),
                                    Convert.ToBoolean(reader["IsVendido490WC"]),
                                    Convert.ToSingle(reader["PesoEquipajePermitido490WC"]),
                                    reader["ClaseBoleto490WC"].ToString(),
                                    Convert.ToSingle(reader["Precio490WC"]),
                                    Titulares490WC.Find(x => x.DNI490WC == ID490WC),
                                    reader["NumeroAsiento490WC"].ToString()
                                );
                            }
                        }
                    }
                }
                return null;
            }
        }

        public List<Boleto490WC> ObtenerBoletosPorPagarCliente490WC(Cliente490WC cliente490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                List<Boleto490WC> boletos490WC = new List<Boleto490WC>();
                List<Cliente490WC> Titulares490WC = new ClienteDAL490WC().ObtenerTodosLosCliente490WC();
                cone490WC.Open();
                string query490WC = "SELECT * FROM Boleto490WC WHERE Titular490WC = @Titular490WC AND IsVendido490WC = 0";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@Titular490WC", cliente490WC.DNI490WC);
                    using (SqlDataReader reader = comando490WC.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["FechaPartidaVUELTA490WC"] == DBNull.Value || reader["FechaLlegadaVUELTA490WC"] == DBNull.Value)
                            {
                                Boleto490WC boletoPagar490WC = new BoletoIDA490WC(
                                   reader["ID490WC"].ToString(),
                                   reader["Origen490WC"].ToString(),
                                   reader["Destino490WC"].ToString(),
                                   Convert.ToDateTime(reader["FechaPartidaIDA490WC"]),
                                   Convert.ToDateTime(reader["FechaLlegadaIDA490WC"]),
                                   Convert.ToBoolean(reader["IsVendido490WC"]),
                                   Convert.ToSingle(reader["PesoEquipajePermitido490WC"]),
                                   reader["ClaseBoleto490WC"].ToString(),
                                   Convert.ToSingle(reader["Precio490WC"]),
                                   Titulares490WC.Find(x => x.DNI490WC == cliente490WC.DNI490WC),
                                   reader["NumeroAsiento490WC"].ToString()
                               );
                                boletos490WC.Add(boletoPagar490WC);
                            }
                            else
                            {
                                Boleto490WC boletoPagar490WC = new BoletoIDAVUELTA490WC(
                                    reader["ID490WC"].ToString(),
                                    reader["Origen490WC"].ToString(),
                                    reader["Destino490WC"].ToString(),
                                    Convert.ToDateTime(reader["FechaPartidaIDA490WC"]),
                                    Convert.ToDateTime(reader["FechaLlegadaIDA490WC"]),
                                    Convert.ToDateTime(reader["FechaPartidaVUELTA490WC"]),
                                    Convert.ToDateTime(reader["FechaLlegadaVUELTA490WC"]),
                                    Convert.ToBoolean(reader["IsVendido490WC"]),
                                    Convert.ToSingle(reader["PesoEquipajePermitido490WC"]),
                                    reader["ClaseBoleto490WC"].ToString(),
                                    Convert.ToSingle(reader["Precio490WC"]),
                                    Titulares490WC.Find(x => x.DNI490WC == cliente490WC.DNI490WC),
                                    reader["NumeroAsiento490WC"].ToString()
                                );
                                boletos490WC.Add(boletoPagar490WC);
                            }
                        }
                    }
                }
                return boletos490WC;
            }
        }

        public List<Boleto490WC> ObtenerBoletosPorCliente490WC(Cliente490WC cliente490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                List<Boleto490WC> boletos490WC = new List<Boleto490WC>();
                List<Cliente490WC> Titulares490WC = new ClienteDAL490WC().ObtenerTodosLosCliente490WC();
                cone490WC.Open();
                string query490WC = "SELECT * FROM Boleto490WC WHERE Titular490WC = @Titular490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                    comando490WC.Parameters.AddWithValue("@Titular490WC", cliente490WC.DNI490WC);
                    using (SqlDataReader reader = comando490WC.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["FechaPartidaVUELTA490WC"] == DBNull.Value || reader["FechaLlegadaVUELTA490WC"] == DBNull.Value)
                            {
                                Boleto490WC boletoPagar490WC = new BoletoIDA490WC(
                                   reader["ID490WC"].ToString(),
                                   reader["Origen490WC"].ToString(),
                                   reader["Destino490WC"].ToString(),
                                   Convert.ToDateTime(reader["FechaPartidaIDA490WC"]),
                                   Convert.ToDateTime(reader["FechaLlegadaIDA490WC"]),
                                   Convert.ToBoolean(reader["IsVendido490WC"]),
                                   Convert.ToSingle(reader["PesoEquipajePermitido490WC"]),
                                   reader["ClaseBoleto490WC"].ToString(),
                                   Convert.ToSingle(reader["Precio490WC"]),
                                   Titulares490WC.Find(x => x.DNI490WC == cliente490WC.DNI490WC),
                                   reader["NumeroAsiento490WC"].ToString()
                               );
                                boletos490WC.Add(boletoPagar490WC);
                            }
                            else
                            {
                                Boleto490WC boletoPagar490WC = new BoletoIDAVUELTA490WC(
                                    reader["ID490WC"].ToString(),
                                    reader["Origen490WC"].ToString(),
                                    reader["Destino490WC"].ToString(),
                                    Convert.ToDateTime(reader["FechaPartidaIDA490WC"]),
                                    Convert.ToDateTime(reader["FechaLlegadaIDA490WC"]),
                                    Convert.ToDateTime(reader["FechaPartidaVUELTA490WC"]),
                                    Convert.ToDateTime(reader["FechaLlegadaVUELTA490WC"]),
                                    Convert.ToBoolean(reader["IsVendido490WC"]),
                                    Convert.ToSingle(reader["PesoEquipajePermitido490WC"]),
                                    reader["ClaseBoleto490WC"].ToString(),
                                    Convert.ToSingle(reader["Precio490WC"]),
                                    Titulares490WC.Find(x => x.DNI490WC == cliente490WC.DNI490WC),
                                    reader["NumeroAsiento490WC"].ToString()
                                );
                                boletos490WC.Add(boletoPagar490WC);
                            }
                        }
                    }
                }
                return boletos490WC;
            }
        }

        public List<Boleto490WC> ObtenerTodosLosBoletos490WC()
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                List<Boleto490WC> boletos490WC = new List<Boleto490WC>();
                List<Cliente490WC> Titulares490WC = new ClienteDAL490WC().ObtenerTodosLosCliente490WC();
                if(cone490WC.State != System.Data.ConnectionState.Open)
                {
                  cone490WC.Open();
                }
                string query490WC = "SELECT * FROM Boleto490WC";
                using (SqlCommand comando490WC = new SqlCommand(query490WC, cone490WC))
                {
                  
                    using (SqlDataReader reader = comando490WC.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["FechaPartidaVUELTA490WC"] == DBNull.Value || reader["FechaLlegadaVUELTA490WC"] == DBNull.Value)
                            {
                                Boleto490WC boletoPagar490WC = new BoletoIDA490WC(
                                   reader["ID490WC"].ToString(),
                                   reader["Origen490WC"].ToString(),
                                   reader["Destino490WC"].ToString(),
                                   Convert.ToDateTime(reader["FechaPartidaIDA490WC"]),
                                   Convert.ToDateTime(reader["FechaLlegadaIDA490WC"]),
                                   Convert.ToBoolean(reader["IsVendido490WC"]),
                                   Convert.ToSingle(reader["PesoEquipajePermitido490WC"]),
                                   reader["ClaseBoleto490WC"].ToString(),
                                   Convert.ToSingle(reader["Precio490WC"]),
                                   Titulares490WC.Find(x => x.DNI490WC == reader["Titular490WC"].ToString()),
                                   reader["NumeroAsiento490WC"].ToString()
                               );
                                boletos490WC.Add(boletoPagar490WC);
                            }
                            else
                            {
                                Boleto490WC boletoPagar490WC = new BoletoIDAVUELTA490WC(
                                    reader["ID490WC"].ToString(),
                                    reader["Origen490WC"].ToString(),
                                    reader["Destino490WC"].ToString(),
                                    Convert.ToDateTime(reader["FechaPartidaIDA490WC"]),
                                    Convert.ToDateTime(reader["FechaLlegadaIDA490WC"]),
                                    Convert.ToDateTime(reader["FechaPartidaVUELTA490WC"]),
                                    Convert.ToDateTime(reader["FechaLlegadaVUELTA490WC"]),
                                    Convert.ToBoolean(reader["IsVendido490WC"]),
                                    Convert.ToSingle(reader["PesoEquipajePermitido490WC"]),
                                    reader["ClaseBoleto490WC"].ToString(),
                                    Convert.ToSingle(reader["Precio490WC"]),
                                    Titulares490WC.Find(x => x.DNI490WC == reader["Titular490WC"].ToString()),
                                    reader["NumeroAsiento490WC"].ToString()
                                );
                                boletos490WC.Add(boletoPagar490WC);
                            }
                        }
                    }
                }
                return boletos490WC;
            }
        }



        public List<Boleto490WC> BuscarBoletosPorFiltros() // Falta implementar la logica de filtros, que hicimos en el otro proyecto.
        {
            return null;
        }



        #endregion
    }
}
