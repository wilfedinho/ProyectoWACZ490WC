using DAL490WC;
using SE490WC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLS490WC
{
    public class Simple490WC
    {
        public List<Permiso490WC> ObtenerPermisosSimples490WC()
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.ObtenerPermisosSimples490WC();
        }

        public bool EliminarRelacionPermisoSimple_Familia(string nombreFamilia, string nombrePermisoSimple)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            bool estadoOperacion490WC = gestorPermiso490WC.EliminarRelacionPermisoSimple_Familia(nombreFamilia, nombrePermisoSimple);
            if (estadoOperacion490WC)
            {
                Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
                GestorBitacora490WC.AltaEvento490WC("Gestión Permisos", "Eliminar Permiso a Familia", 5);
                return estadoOperacion490WC;
            }
            else
            {
                return estadoOperacion490WC;
            }
        }

        public bool EliminarRelacionPermisoSimple_Perfil(string nombrePerfil, string nombrePermisoSimple)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            bool estadoOperacion490WC = gestorPermiso490WC.EliminarRelacionPermisoSimple_Perfil(nombrePerfil, nombrePermisoSimple);
            if (estadoOperacion490WC)
            {
                Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
                GestorBitacora490WC.AltaEvento490WC("Gestión Permisos", "Eliminar Permiso a un Rol", 5);
                return estadoOperacion490WC;
            }
            else
            {
                return estadoOperacion490WC;
            }
        }
    }
}
