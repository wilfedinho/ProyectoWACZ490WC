using DAL490WC;
using SE490WC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLS490WC
{
    public class Familia490WC
    {
        public List<PermisoCompuesto490WC> LeerFamiliasConEstructuraRecursiva490WC()
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.LeerFamiliasConEstructuraRecursiva490WC();
        }

        public PermisoCompuesto490WC LeerPermisoCompuesto490WC(string nombreFamiliaRaiz490WC)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.LeerPermisoCompuesto490WC(nombreFamiliaRaiz490WC);
        }

        public bool InsertarFamilia490WC(PermisoCompuesto490WC familiaNueva)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.InsertarFamilia490WC(familiaNueva);
        }

        public bool InsertarRelacionDesdeFamilia490WC(string nombreFamilia, string nombreIncluido)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.InsertarRelacionDesdeFamilia490WC(nombreFamilia, nombreIncluido);
        }

        public bool BorrarFamilia490WC(string nombreFamilia)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.BorrarFamilia490WC(nombreFamilia);
        }

        public bool FamiliaQuedariaVaciaTrasEliminarElemento(string nombreFamilia, string nombreElemento)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.FamiliaQuedariaVaciaTrasEliminarElemento(nombreFamilia, nombreElemento);
        }

        public bool EliminarRelacionFamilia_Familia(string familiaPadre, string familiaHija)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.EliminarRelacionFamilia_Familia(familiaPadre, familiaHija);
        }

        public bool FamiliaExiste490WC(string nombreFamilia)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.FamiliaExiste490WC(nombreFamilia);
        }

        public bool FamiliaEstaAnidadaEnOtra490WC(string nombreFamilia490WC)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.FamiliaEstaAnidadaEnOtra490WC(nombreFamilia490WC);
        }

        public List<Permiso490WC> ObtenerPermisosCompuestos490WC()
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.ObtenerPermisosCompuestos490WC();
        }
    }
}
