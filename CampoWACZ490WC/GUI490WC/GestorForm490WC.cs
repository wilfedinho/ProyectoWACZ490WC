using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI490WC
{
    public class GestorForm490WC
    {
        private static GestorForm490WC instance490WC;
        private Estado490WC estadoGestor490WC = new EstadoIniciarSesion490WC();
        public static GestorForm490WC gestorFormSG490WC
        {
            get
            {
                if (instance490WC == null)
                {
                    instance490WC = new GestorForm490WC();
                }
                return instance490WC;
            }
        }
        public void DefinirEstado490WC(Estado490WC estadoNuevo490WC)
        {
            estadoGestor490WC?.CerrarEstado490WC();
            estadoGestor490WC = estadoNuevo490WC;
            estadoGestor490WC.EjecutarEstado490WC();
        }
    }
}
