using SERVICIOS490WC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL490WC
{
    public class GestorPagos490WC
    {
        public bool ValidarPago490WC(string datosPago, float precioPagar)
        {
            return ProcesarPagoEntidadBancaria490WC(datosPago, precioPagar);
        }

        private bool ProcesarPagoEntidadBancaria490WC(string datosPago490WC, float precioPagar490WC)
        {
            bool pagoAceptado490WC = true;
            datosPago490WC = Cifrador490WC.GestorCifrador490WC.DesencriptarReversible490WC(datosPago490WC);
            string[] datos490WC = datosPago490WC.Split(',');

            //SIMULACION DE LA COMUNICACION CON LA ENTIDAD BANCARIA, lo que puede modificar el estado pagoAceptado490WC

            if (pagoAceptado490WC)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
