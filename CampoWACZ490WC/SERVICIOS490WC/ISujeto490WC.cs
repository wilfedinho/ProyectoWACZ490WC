using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS490WC
{
    public interface ISujeto490WC
    {
        void Suscribir490WC(iObserverLenguaje490WC observer);
        void Desuscribir490WC(iObserverLenguaje490WC observer);
        void Notificar490WC();
    }
}
