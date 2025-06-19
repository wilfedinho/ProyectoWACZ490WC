using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE490WC
{
    public abstract class Permiso490WC
    {

        private string Nombre490WC;
        protected Permiso490WC(string nNombre490WC)
        {
            Nombre490WC = nNombre490WC;
        }
        public virtual void Agregar490WC(Permiso490WC nPermiso490WC)
        {

        }

        public virtual void Borrar490WC(Permiso490WC nPermiso490WC)
        {

        }

        public virtual bool esCompuesto490WC()
        {
            return false;
        }

        public string obtenerPermisoNombre490WC()
        {
            return Nombre490WC;
        }

    }
}
