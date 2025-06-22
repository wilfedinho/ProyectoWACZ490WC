using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE490WC
{
    public class PermisoCompuesto490WC : Permiso490WC
    {
        public PermisoCompuesto490WC(string nNombre490WC) : base(nNombre490WC)
        {

        }
        protected List<Permiso490WC> permisos490WC = new List<Permiso490WC>();

        public override void Agregar490WC(Permiso490WC nPermiso490WC)
        {
            this.permisos490WC.Add(nPermiso490WC);
        }

        public override void Borrar490WC(Permiso490WC nPermiso490WC)
        {
            this.permisos490WC.Remove(nPermiso490WC);
        }

        public Permiso490WC BuscarPermiso490WC(Permiso490WC raiz490WC, Permiso490WC permiso490WC)
        {
            if (raiz490WC == permiso490WC)
            {
                return raiz490WC;
            }
            else
            {
                if (raiz490WC is PermisoCompuesto490WC)
                {

                    foreach (Permiso490WC permi490WC in (raiz490WC as PermisoCompuesto490WC).permisos490WC)
                    {
                        Permiso490WC permisoEncontrado490WC = BuscarPermiso490WC(permi490WC, permiso490WC);
                        if (permisoEncontrado490WC != null)
                        {
                            return permisoEncontrado490WC;
                        }
                    }

                }
            }
            return null;
        }

        public bool VerificarPermisoIncluido490WC(Permiso490WC raiz490WC, string permiso490WC)
        {
            if (raiz490WC.obtenerPermisoNombre490WC() == permiso490WC)
            {
                return true;
            }
            else
            {
                if (raiz490WC is PermisoCompuesto490WC)
                {
                    foreach (Permiso490WC permi490WC in (raiz490WC as PermisoCompuesto490WC).permisos490WC)
                    {
                        if (VerificarPermisoIncluido490WC(permi490WC, permiso490WC))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public List<Permiso490WC> PermisosIncluidos490WC()
        {
            return permisos490WC;
        }

    }
}
