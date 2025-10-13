using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL490WC
{
    public class DigitoVerificadorDAL490WC
    {
        
        private readonly Dictionary<string, string[]> mapaDeTablasSistema = new Dictionary<string, string[]>
        {
            { "Beneficio490WC", new string[] { "CodigoBeneficio490WC" } },
            { "Boleto490WC", new string[] { "ID490WC" } },
            { "CelularCliente490WC", new string[] { "IDCelular490WC" } },
            { "Cliente_Beneficio490WC", new string[] { "DNI490WC", "CodigoBeneficio490WC" } },
            { "Cliente490WC", new string[] { "DNI490WC" } },
            { "EmailCliente490WC", new string[] { "IDEmail490WC" } },
            { "Factura490WC", new string[] { "NumeroFactura490WC" } },
            { "Usuario490WC", new string[] { "Username490WC" } }
        };

        
        public Dictionary<string, (BigInteger DVH, BigInteger DVV)> CalcularTodosLosDigitosCrudos()
        {
            var resultadoGlobal = new Dictionary<string, (BigInteger DVH, BigInteger DVV)>();

            foreach (var parTablaPK in mapaDeTablasSistema)
            {
                var digitosCrudos = CalcularDigitosDeTabla(parTablaPK.Key, parTablaPK.Value);
                resultadoGlobal[parTablaPK.Key] = digitosCrudos;
            }
            return resultadoGlobal;
        }

        public bool GuardarDigitos(string nombreTabla, string dvhHasheado, string dvvHasheado)
        {
            using (SqlConnection con = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                con.Open();
                try
                {
                    string queryUpsert = @"UPDATE DigitoVerificador490WC SET DVH490WC = @DVH, DVV490WC = @DVV WHERE NombreTabla490WC = @NombreTabla; IF @@ROWCOUNT = 0 INSERT INTO DigitoVerificador490WC (NombreTabla490WC, DVH490WC, DVV490WC) VALUES (@NombreTabla, @DVH, @DVV);";

                    using (SqlCommand cmdUpsert = new SqlCommand(queryUpsert, con))
                    {
                        cmdUpsert.Parameters.AddWithValue("@DVH", dvhHasheado);
                        cmdUpsert.Parameters.AddWithValue("@DVV", dvvHasheado);
                        cmdUpsert.Parameters.AddWithValue("@NombreTabla", nombreTabla);
                        cmdUpsert.ExecuteNonQuery();
                    }
                    return true;
                }
                catch { return false; }
            }
        }

        public Dictionary<string, (string DVH, string DVV)> ObtenerDigitosGuardados()
        {
            var resultado = new Dictionary<string, (string DVH, string DVV)>();
            using (SqlConnection con = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                con.Open();
                string querySelect = "SELECT NombreTabla490WC, DVH490WC, DVV490WC FROM DigitoVerificador490WC";
                using (SqlCommand cmdSelect = new SqlCommand(querySelect, con))
                using (SqlDataReader reader = cmdSelect.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombreTabla = reader["NombreTabla490WC"].ToString();
                        string dvhGuardado = reader["DVH490WC"]?.ToString() ?? "";
                        string dvvGuardado = reader["DVV490WC"]?.ToString() ?? "";
                        resultado[nombreTabla] = (dvhGuardado, dvvGuardado);
                    }
                }
            }
            return resultado;
        }

        private (BigInteger DVH, BigInteger DVV) CalcularDigitosDeTabla(string nombreTabla, string[] columnasPK)
        {
            using (SqlConnection con = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                con.Open();
                string orderByClause = string.Join(", ", columnasPK);
                string querySelect = $"SELECT * FROM {nombreTabla} ORDER BY {orderByClause}";

                using (SqlCommand cmdSelect = new SqlCommand(querySelect, con))
                using (SqlDataReader reader = cmdSelect.ExecuteReader())
                {
                    if (!reader.HasRows) return (0, 0);

                    BigInteger sumaHexDVH = 0;
                    int numColumnas = reader.FieldCount;
                    StringBuilder[] columnasSB = new StringBuilder[numColumnas];
                    for (int i = 0; i < numColumnas; i++) columnasSB[i] = new StringBuilder();

                    while (reader.Read())
                    {
                        StringBuilder sbFila = new StringBuilder();
                        for (int j = 0; j < numColumnas; j++)
                        {
                            string valorCelda = reader[j]?.ToString() ?? "";
                            sbFila.Append(valorCelda);
                            columnasSB[j].Append(valorCelda);
                        }
                        byte[] bytesFila = Encoding.UTF8.GetBytes(sbFila.ToString());
                        string hexDigestFila = BitConverter.ToString(bytesFila).Replace("-", "").ToLower();
                        sumaHexDVH += BigInteger.Parse("0" + hexDigestFila, System.Globalization.NumberStyles.HexNumber);
                    }

                    BigInteger sumaHexDVV = 0;
                    foreach (StringBuilder colSB in columnasSB)
                    {
                        byte[] bytesColumna = Encoding.UTF8.GetBytes(colSB.ToString());
                        string hexDigestColumna = BitConverter.ToString(bytesColumna).Replace("-", "").ToLower();
                        sumaHexDVV += BigInteger.Parse("0" + hexDigestColumna, System.Globalization.NumberStyles.HexNumber);
                    }
                    return (sumaHexDVH, sumaHexDVV);
                }
            }
        }
    }
}
