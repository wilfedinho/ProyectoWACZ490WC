using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI490WC
{
    public class EstadoMenu490WC : Estado490WC
    {
        FormMenu490WC menu490WC;
        public override void CerrarEstado490WC()
        {
           menu490WC?.Dispose();
        }

        public override void EjecutarEstado490WC()
        {
            menu490WC = new FormMenu490WC();
            menu490WC.ShowDialog();
        }

    }
}
