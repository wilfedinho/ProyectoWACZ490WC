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
       
        }
        public List<PermisoCompuesto490WC> LeerFamiliasConEstructuraRecursiva490WC()
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.LeerFamiliasConEstructuraRecursiva490WC();
        }

        public PermisoCompuesto490WC LeerRolConEstructura490WC(string nombrePerfil)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.LeerRolConEstructura490WC(nombrePerfil);
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

        public bool InsertarRelacionDesdePerfil490WC(string nombrePerfil, string nombreIncluido)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.InsertarRelacionDesdePerfil490WC(nombrePerfil, nombreIncluido);
        }

        public bool InsertarRelacionDesdeFamilia490WC(string nombreFamilia, string nombreIncluido)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.InsertarRelacionDesdeFamilia490WC(nombreFamilia, nombreIncluido);
        }

        public bool BorrarRol490WC(string nombreRol)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.BorrarRol490WC(nombreRol);
        }

        public bool BorrarFamilia490WC(string nombreFamilia)
        {
            PermisoDAL490WC gestorPermiso490WC = new PermisoDAL490WC();
            return gestorPermiso490WC.BorrarFamilia490WC(nombreFamilia);
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

        public PermisoCompuesto490WC BuscarPadreDirecto490WC(PermisoCompuesto490WC raiz, string nombreBuscado)
        {
            foreach (var hijo in raiz.PermisosIncluidos490WC())
            {
                if (hijo.obtenerPermisoNombre490WC() == nombreBuscado)
                {
                    return raiz; // Este nodo es el padre directo
                }

                if (hijo is PermisoCompuesto490WC hijoCompuesto)
                {
                    var padreEncontrado = BuscarPadreDirecto490WC(hijoCompuesto, nombreBuscado);
                    if (padreEncontrado != null)
                        return padreEncontrado;
                }
            }

            return null; // No se encontró el padre en esta rama
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

        public List<string> ObtenerNombresDePermisos490WC(PermisoCompuesto490WC permisoRaiz)
        {
            HashSet<string> nombres = new HashSet<string>();
            RecorrerPermisosRecursivo490WC(permisoRaiz, nombres);
            return nombres.ToList();
        }
        

        private void RecorrerPermisosRecursivo490WC(PermisoCompuesto490WC permiso, HashSet<string> acumulador)
        {
            foreach (var hijo in permiso.PermisosIncluidos490WC())
            {
                if (hijo is PermisoSimple490WC simple)
                {
                    acumulador.Add(simple.obtenerPermisoNombre490WC());
                }
                else if (hijo is PermisoCompuesto490WC compuesto)
                {
                    acumulador.Add(compuesto.obtenerPermisoNombre490WC());
                    RecorrerPermisosRecursivo490WC(compuesto, acumulador);
                }
            }
        }

        public bool ExistePermisoEnEstructura490WC(PermisoCompuesto490WC estructura, string nombreABuscar)
        {
            if (estructura.obtenerPermisoNombre490WC() == nombreABuscar)
                return true;

            foreach (var hijo in estructura.PermisosIncluidos490WC())
            {
                if (hijo.obtenerPermisoNombre490WC() == nombreABuscar)
                    return true;

                if (hijo is PermisoCompuesto490WC hijoCompuesto)
                {
                    if (ExistePermisoEnEstructura490WC(hijoCompuesto, nombreABuscar))
                        return true;
                }
            }

            return false;
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
