using DAL490WC;
using SERVICIOS490WC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BLLS490WC
{
    public class DigitoVerificador490WC
    {
        private readonly DigitoVerificadorDAL490WC gestorDigitoVerificador490WC = new DigitoVerificadorDAL490WC();
        public bool ActualizarIntegridadSistema490WC()
        {
            try
            {
                var todosLosDigitosCrudos490WC = gestorDigitoVerificador490WC.CalcularTodosLosDigitosCrudos490WC();   
                foreach (var parTablaDigitos490WC in todosLosDigitosCrudos490WC)
                {
                    string nombreTabla490WC = parTablaDigitos490WC.Key;
                    var digitosCrudos490WC = parTablaDigitos490WC.Value;
                    string dvhHasheado490WC = Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(digitosCrudos490WC.DVH490WC.ToString());
                    string dvvHasheado490WC = Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(digitosCrudos490WC.DVV490WC.ToString());

                    if (!gestorDigitoVerificador490WC.GuardarDigitos490WC(nombreTabla490WC, dvhHasheado490WC, dvvHasheado490WC))
                    {
                        return false; 
                    }
                }

                
                return true;
            }
            catch { return false; }
        }
        public bool VerificarIntegridadSistema490WC()
        {
            try
            {
                var digitosGuardados490WC = gestorDigitoVerificador490WC.ObtenerDigitosGuardados490WC();
                var digitosCrudosCalculados490WC = gestorDigitoVerificador490WC.CalcularTodosLosDigitosCrudos490WC();
                if (digitosGuardados490WC.Count != digitosCrudosCalculados490WC.Count) return false;
                foreach (var par490WC in digitosCrudosCalculados490WC)
                {
                    string nombreTabla490WC = par490WC.Key;
                    var digitosCrudos490WC = par490WC.Value;
                    string dvhCalculadoYHasheado490WC = Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(digitosCrudos490WC.DVH490WC.ToString());
                    string dvvCalculadoYHasheado490WC = Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(digitosCrudos490WC.DVV490WC.ToString());
                    if (!digitosGuardados490WC.ContainsKey(nombreTabla490WC) || digitosGuardados490WC[nombreTabla490WC].DVH490WC != dvhCalculadoYHasheado490WC || digitosGuardados490WC[nombreTabla490WC].DVV490WC != dvvCalculadoYHasheado490WC)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch { return false; }
        }
    }
}
