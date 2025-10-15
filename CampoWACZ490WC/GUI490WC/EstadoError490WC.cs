using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI490WC
{
    public class EstadoError490WC : Estado490WC
    {

        FormInconsistenciaDeDatos490WC Error490WC;
        public override void CerrarEstado490WC()
        {
           Error490WC?.Dispose();
        }

        public override void EjecutarEstado490WC()
        {
           Error490WC = new FormInconsistenciaDeDatos490WC();
           Error490WC.ShowDialog();
        }
    }
}
