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
        public bool ActualizarIntegridadSistema()
        {
            try
            {
                var todosLosDigitosCrudos = gestorDigitoVerificador490WC.CalcularTodosLosDigitosCrudos();   
                foreach (var parTablaDigitos in todosLosDigitosCrudos)
                {
                    string nombreTabla = parTablaDigitos.Key;
                    var digitosCrudos = parTablaDigitos.Value;
                    string dvhHasheado = Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(digitosCrudos.DVH.ToString());
                    string dvvHasheado = Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(digitosCrudos.DVV.ToString());

                    if (!gestorDigitoVerificador490WC.GuardarDigitos(nombreTabla, dvhHasheado, dvvHasheado))
                    {
                        return false; 
                    }
                }

                
                return true;
            }
            catch { return false; }
        }
        public bool VerificarIntegridadSistema()
        {
            try
            {
                var digitosGuardados = gestorDigitoVerificador490WC.ObtenerDigitosGuardados();
                var digitosCrudosCalculados = gestorDigitoVerificador490WC.CalcularTodosLosDigitosCrudos();
                if (digitosGuardados.Count != digitosCrudosCalculados.Count) return false;
                foreach (var par in digitosCrudosCalculados)
                {
                    string nombreTabla = par.Key;
                    var digitosCrudos = par.Value;
                    string dvhCalculadoYHasheado = Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(digitosCrudos.DVH.ToString());
                    string dvvCalculadoYHasheado = Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(digitosCrudos.DVV.ToString());
                    if (!digitosGuardados.ContainsKey(nombreTabla) || digitosGuardados[nombreTabla].DVH != dvhCalculadoYHasheado || digitosGuardados[nombreTabla].DVV != dvvCalculadoYHasheado)
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
