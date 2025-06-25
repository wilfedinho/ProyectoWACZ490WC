using SE490WC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS490WC
{
    public class SesionManager490WC
    {
        private static SesionManager490WC Instancia490WC;
        public PermisoCompuesto490WC permisosDeLaSesion490WC;

        public static SesionManager490WC GestorSesion490WC
        {
            get
            {
                if (Instancia490WC == null)
                {
                    Instancia490WC = new SesionManager490WC();
                }
                return Instancia490WC;
            }
        }
        public Usuario490WC Usuario490WC;

        public bool Login490WC(Usuario490WC UsuarioLoguear)
        {
            
            if (GestorSesion490WC.Usuario490WC == null)
            {
                GestorSesion490WC.Usuario490WC = UsuarioLoguear;
                return true;
               
            }
            else
            {
                return false;
                
            }
        }
        public bool Logout490WC()
        {
          
            if (GestorSesion490WC.Usuario490WC != null)
            {
                GestorSesion490WC.Usuario490WC = null;
                return true;
                
            }
            else
            {
                return false;
                
            }
        }
        public bool SesionTienePermisos490WC(string permisoSolicitado490WC)
        {
            PermisoCompuesto490WC permiso490WC = new PermisoCompuesto490WC(permisoSolicitado490WC);
            return permiso490WC.VerificarPermisoIncluido490WC(permisosDeLaSesion490WC, permisoSolicitado490WC);
        }
    }
}
