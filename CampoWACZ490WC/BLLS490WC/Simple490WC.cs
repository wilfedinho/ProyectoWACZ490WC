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
            return gestorPermiso490WC.EliminarRelacionPermisoSimple_Familia(nombreFamilia, nombrePermisoSimple);
        }

        public bool EliminarRelacionPermisoSimple_Perfil(string nombrePerfil, string nombrePermisoSimple)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.EliminarRelacionPermisoSimple_Perfil(nombrePerfil, nombrePermisoSimple);
        }
    }
}
