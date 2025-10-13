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
        
        private readonly Dictionary<string, string[]> mapaDeTablasSistema490WC = new Dictionary<string, string[]>
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

        
        public Dictionary<string, (BigInteger DVH490WC, BigInteger DVV490WC)> CalcularTodosLosDigitosCrudos490WC()
        {
            var resultadoGlobal490WC = new Dictionary<string, (BigInteger DVH490WC, BigInteger DVV490WC)>();

            foreach (var parTablaPK490WC in mapaDeTablasSistema490WC)
            {
                var digitosCrudos490WC = CalcularDigitosDeTabla490WC(parTablaPK490WC.Key, parTablaPK490WC.Value);
                resultadoGlobal490WC[parTablaPK490WC.Key] = digitosCrudos490WC;
            }
            return resultadoGlobal490WC;
        }

        public bool GuardarDigitos490WC(string nombreTabla490WC, string dvhHasheado490WC, string dvvHasheado490WC)
        {
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                try
                {
                    string queryUpsert490WC = @"UPDATE DigitoVerificador490WC SET DVH490WC = @DVH490WC, DVV490WC = @DVV490WC WHERE NombreTabla490WC = @NombreTabla490WC; IF @@ROWCOUNT = 0 INSERT INTO DigitoVerificador490WC (NombreTabla490WC, DVH490WC, DVV490WC) VALUES (@NombreTabla490WC, @DVH490WC, @DVV490WC);";

                    using (SqlCommand cmdUpsert490WC = new SqlCommand(queryUpsert490WC, cone490WC))
                    {
                        cmdUpsert490WC.Parameters.AddWithValue("@DVH490WC", dvhHasheado490WC);
                        cmdUpsert490WC.Parameters.AddWithValue("@DVV490WC", dvvHasheado490WC);
                        cmdUpsert490WC.Parameters.AddWithValue("@NombreTabla490WC", nombreTabla490WC);
                        cmdUpsert490WC.ExecuteNonQuery();
                    }
                    return true;
                }
                catch { return false; }
            }
        }

        public Dictionary<string, (string DVH490WC, string DVV490WC)> ObtenerDigitosGuardados490WC()
        {
            var resultado490WC = new Dictionary<string, (string DVH490WC, string DVV490WC)>();
            using (SqlConnection cone490WC = GestorConexion490WC.GestorCone490WC.DevolverConexion490WC())
            {
                cone490WC.Open();
                string querySelect490WC = "SELECT NombreTabla490WC, DVH490WC, DVV490WC FROM DigitoVerificador490WC";
                using (SqlCommand cmdSelect490WC = new SqlCommand(querySelect490WC, cone490WC))
                using (SqlDataReader reader490WC = cmdSelect490WC.ExecuteReader())
                {
                    while (reader490WC.Read())
                    {
                        string nombreTabla = reader490WC["NombreTabla490WC"].ToString();
                        string dvhGuardado = reader490WC["DVH490WC"]?.ToString() ?? "";
                        string dvvGuardado = reader490WC["DVV490WC"]?.ToString() ?? "";
                        resultado490WC[nombreTabla] = (dvhGuardado, dvvGuardado);
                    }
                }
            }
            return resultado490WC;
        }

        private (BigInteger DVH, BigInteger DVV) CalcularDigitosDeTabla490WC(string nombreTabla, string[] columnasPK)
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
