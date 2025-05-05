using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS490WC
{
    public class Cifrador490WC
    {
        private static Cifrador490WC Instancia490WC;
        public static Cifrador490WC GestorCifrador490WC
        {
            get
            {
                if (Instancia490WC == null)
                {
                    Instancia490WC = new Cifrador490WC();
                }
                return Instancia490WC;
            }
        }
        private readonly byte[] key490WC;
        private readonly byte[] iv490WC;
        private Cifrador490WC()
        {
            using (Aes aesAlg490WC = Aes.Create())
            {

                aesAlg490WC.GenerateKey();
                aesAlg490WC.GenerateIV();
                key490WC = aesAlg490WC.Key;
                iv490WC = aesAlg490WC.IV;
            }
        }
        public string EncriptarIrreversible490WC(string textoEncriptar490WC)
        {
            using (SHA256 sha256490WC = SHA256.Create())
            {

                byte[] bytes490WC = Encoding.UTF8.GetBytes(textoEncriptar490WC);


                byte[] hashBytes490WC = sha256490WC.ComputeHash(bytes490WC);


                StringBuilder stringBuilder490WC = new StringBuilder();
                for (int i = 0; i < hashBytes490WC.Length; i++)
                {
                    stringBuilder490WC.Append(hashBytes490WC[i].ToString("x2"));
                }
                return stringBuilder490WC.ToString();
            }
        }

        public string EncriptarReversible490WC(string textoEncriptar490WC)
        {
            using (Aes aesAlg490WC = Aes.Create())
            {
                aesAlg490WC.Key = key490WC;
                aesAlg490WC.IV = iv490WC;

                ICryptoTransform Encriptador490WC = aesAlg490WC.CreateEncryptor(aesAlg490WC.Key, aesAlg490WC.IV);

                using (MemoryStream msEncrypt490WC = new MemoryStream())
                {
                    using (CryptoStream csEncrypt490WC = new CryptoStream(msEncrypt490WC, Encriptador490WC, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt490WC = new StreamWriter(csEncrypt490WC))
                    {
                        swEncrypt490WC.Write(textoEncriptar490WC);
                    }
                    return Convert.ToBase64String(msEncrypt490WC.ToArray());
                }
            }
        }

        public string DesencriptarReversible490WC(string textoEncriptar)
        {
            using (Aes aesAlg490WC = Aes.Create())
            {
                aesAlg490WC.Key = key490WC;
                aesAlg490WC.IV = iv490WC;

                ICryptoTransform decryptor490WC = aesAlg490WC.CreateDecryptor(aesAlg490WC.Key, aesAlg490WC.IV);

                using (MemoryStream msDecrypt490WC = new MemoryStream(Convert.FromBase64String(textoEncriptar)))
                {
                    using (CryptoStream csDecrypt490WC = new CryptoStream(msDecrypt490WC, decryptor490WC, CryptoStreamMode.Read))
                    using (StreamReader srDecrypt490WC = new StreamReader(csDecrypt490WC))
                    {
                        return srDecrypt490WC.ReadToEnd();
                    }
                }
            }
        }
    }
}
