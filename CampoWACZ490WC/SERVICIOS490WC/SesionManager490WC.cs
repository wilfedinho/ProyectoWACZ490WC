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
            //Este if chequea si existe una sesion iniciada
            if (GestorSesion490WC.Usuario490WC == null)
            {
                GestorSesion490WC.Usuario490WC = UsuarioLoguear;
                return true;
                //Devolvera True Si el proceso de Login se completo correctamente
                //Se asignara el usuario a la sesion
            }
            else
            {
                return false;
                //Devolvera False si el proceso de login no se logro completar, por ejemplo de que ya exista una sesion iniciada
            }
        }
        public bool Logout490WC()
        {
            //Este if chequea si existe una sesion iniciada
            if (GestorSesion490WC.Usuario490WC != null)
            {
                GestorSesion490WC.Usuario490WC = null;
                return true;
                //Devolvera True Si el proceso de Logout se completo correctamente
                //Se limpiara el usuario de la sesion actual
            }
            else
            {
                return false;
                //Devolvera False si el proceso de logout no se logro completar, por ejemplo de que no exista una sesion iniciada
            }
        }
    }
}
