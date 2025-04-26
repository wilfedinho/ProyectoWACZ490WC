using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI490WC
{
    public class EstadoCerrarAplicacion490WC : Estado490WC
    {
        public override void CerrarEstado490WC()
        {
           
        }
        public override void EjecutarEstado490WC()
        {
            Environment.Exit(0);
        }
    }
}
