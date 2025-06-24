using DAL490WC;
using SE490WC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS490WC
{
    public class GestorPermiso490WC
    {
        public void AsignarRolSesion490WC(string nuevoRol490WC)
        {
           // SesionManager490WC.GestorSesion490WC.Usuario490WC.Rol490WC = nuevoRol490WC;
           // SesionManager490WC.GestorSesion490WC.permisosDeLaSesion490WC = ObtenerPermisoCompuesto490WC(SesionManager490WC.GestorSesion490WC.Usuario490WC.Rol490WC);
            SesionManager490WC.GestorSesion490WC.Usuario490WC.Rol490WC = "AdminSistema";
            //SesionManager490WC.GestorSesion490WC.permisosDeLaSesion490WC = ObtenerPermisoCompuesto490WC(SesionManager490WC.GestorSesion490WC.Usuario490WC.Rol490WC);
            List<PermisoCompuesto490WC> familias490WC = LeerFamiliasConEstructuraRecursiva490WC();
            Permiso490WC permiso490WC = LeerPermisoCompuesto490WC("Basico");
        }
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

        public bool InsertarRol490WC(PermisoCompuesto490WC nuevoRol)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.InsertarRol490WC(nuevoRol);
        }

        public bool InsertarRelacion490WC(string nombrePermisoCompuesto490WC, string nombreIncluido490WC)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.InsertarRelacion490WC(nombrePermisoCompuesto490WC, nombreIncluido490WC);
        }

        public bool BorrarPermiso490WC(string NombrePermiso490WC)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.BorrarPermiso490WC(NombrePermiso490WC);
        }

        public bool AlgunaFamiliaQuedariaVaciaAlEliminarElemento(string nombreElemento)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.AlgunaFamiliaQuedariaVaciaAlEliminarElemento(nombreElemento);
        }

        public bool PerfilQuedariaVacioAlEliminarElemento(string nombreElemento)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.PerfilQuedariaVacioAlEliminarElemento(nombreElemento);
        }

        public bool EliminarRelacionPermisoSimple_Perfil(string nombrePerfil, string nombrePermisoSimple)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.EliminarRelacionPermisoSimple_Perfil(nombrePerfil,nombrePermisoSimple);
        }

        public bool EliminarRelacionPermisoSimple_Familia(string nombreFamilia, string nombrePermisoSimple)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.EliminarRelacionPermisoSimple_Familia(nombreFamilia, nombrePermisoSimple);
        }

        public bool EliminarRelacionFamilia_Familia(string familiaPadre, string familiaHija)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.EliminarRelacionFamilia_Familia(familiaPadre, familiaHija);
        }

        public bool EliminarRelacionPerfil_Familia(string nombrePerfil, string nombreFamilia)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.EliminarRelacionPerfil_Familia(nombrePerfil, nombreFamilia);
        }




        public bool FamiliaExiste490WC(string nombreFamilia)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.FamiliaExiste490WC(nombreFamilia);
        }

        public bool PerfilExiste490WC(string nombrePerfil)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.PerfilExiste490WC(nombrePerfil);
        }

        public List<Permiso490WC> ObtenerPermisos490WC()
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.ObtenerPermisos490WC();
        }

        public bool RolEstaAsignado490WC(string nombreRol490WC)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.RolEstaAsignado490WC(nombreRol490WC);
        }

        public bool FamiliaEstaAsignadaAPerfil490WC(string nombreFamilia490WC)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.FamiliaEstaAsignadaAPerfil490WC(nombreFamilia490WC);
        }

        public bool FamiliaEstaAnidadaEnOtra490WC(string nombreFamilia490WC)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.FamiliaEstaAnidadaEnOtra490WC(nombreFamilia490WC);
        }


        public List<Permiso490WC> ObtenerPermisosSimples490WC()
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.ObtenerPermisosSimples490WC();
        }

        public List<Permiso490WC> ObtenerPermisosCompuestos490WC()
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.ObtenerPermisosCompuestos490WC();
        }

        public List<Permiso490WC> ObtenerRoles490WC()
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.ObtenerRoles490WC();
        }

        public bool ConfigurarControl490WC(string tag490WC, bool estadoSecundario490WC)
        {

            if (!estadoSecundario490WC)
            {
                return false;
            }

            if (tag490WC == null || SesionManager490WC.GestorSesion490WC.Usuario490WC.Rol490WC == "AdminSistema" || tag490WC == "")
            {

                return true;
            }
            return SesionManager490WC.GestorSesion490WC.SesionTienePermisos490WC(tag490WC);
        }
    }
}
