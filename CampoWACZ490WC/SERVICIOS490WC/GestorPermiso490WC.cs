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
            Permiso490WC permiso490WC = LeerPermisoCompuesto490WC("Sesion");
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


        /*  public bool AgregarPermisoCompuesto490WC(string nombrePermiso490WC, List<string> permisos490WC, bool esRol490WC)
          {
              Permiso490WC permisoCompuesto490WC = new PermisoCompuesto490WC(nombrePermiso490WC);
              PermisoDAL490WC GestorPermiso490WC = PermisoDAL490WC.GestorPermisoORM490WC;
              List<Permiso490WC> ListaPermisos490WC = GestorPermiso490WC.LeerPermisosEnArbol490WC();
              foreach (string nomP490WC in permisos490WC)
              {
                  PermisoCompuesto490WC compuesto490WC = (PermisoCompuesto490WC)ListaPermisos490WC.Find(x => x.obtenerPermisoNombre490WC() == nomP490WC);
                  if (BuscarPermiso490WC(nombrePermiso490WC, compuesto490WC))
                  {
                      return false;
                  }
              }

              if (GestorPermiso490WC.permisoExiste490WC(nombrePermiso490WC))
              {
                  return false;
              }
              else
              {

                  GestorPermiso490WC.InsertarPermiso490WC(permisoCompuesto490WC, esRol490WC);
                  foreach (string permiso490WC in permisos490WC)
                  {
                      GestorPermiso490WC.InsertarRelacion490WC(nombrePermiso490WC, permiso490WC);
                  }
              }
              return true;
          }*/

        /* public bool BorrarPermiso490WC(string nombrePermiso490WC)
         {
             PermisoDAL490WC GestorPermiso490WC = PermisoDAL490WC.GestorPermisoORM490WC;
             return GestorPermiso490WC.BorrarPermiso490WC(nombrePermiso490WC);
         }

         public void ModificarPermiso490WC(string nombrePermiso490WC, string nuevoNombrePermiso490WC)
         {
             PermisoDAL490WC GestorPermiso490WC = PermisoDAL490WC.GestorPermisoORM490WC;
             GestorPermiso490WC.ModificarPermiso490WC(nombrePermiso490WC, nuevoNombrePermiso490WC);
         }

         public bool ModificarPermisoCompuesto490WC(string nombrePermiso490WC, List<string> permisos490WC)
         {
             Permiso490WC permiso490WC = new PermisoCompuesto490WC(nombrePermiso490WC);
             PermisoDAL490WC GestorPermiso490WC = PermisoDAL490WC.GestorPermisoORM490WC;
             List<Permiso490WC> Lista490WC = GestorPermiso490WC.LeerPermisosEnArbol490WC();

             foreach (string perm490WC in permisos490WC)
             {

                 PermisoCompuesto490WC compuesto490WC = (PermisoCompuesto490WC)Lista490WC.Find(x => x.obtenerPermisoNombre490WC() == perm490WC);
                 if (BuscarPermiso490WC(nombrePermiso490WC, compuesto490WC))
                 {
                     return false;
                 }
             }
             if (permisos490WC.Contains(nombrePermiso490WC))
             {
                 return false;
             }
             else
             {
                 GestorPermiso490WC.BorrarRelacion490WC(nombrePermiso490WC);
                 foreach (string perm490WC in permisos490WC)
                 {
                     GestorPermiso490WC.InsertarRelacion490WC(nombrePermiso490WC, perm490WC);
                 }
                 return true;
             }
         }*/





        /*   #region Funciones para el Mapeo de Permisos

           public List<Permiso490WC> ObtenerPermisos490WC()
           {
               return PermisoDAL490WC.GestorPermisoORM490WC.ObtenerPermisos490WC();
           }

           public List<Permiso490WC> ObtenerPermisosSimples490WC()
           {
               return PermisoDAL490WC.GestorPermisoORM490WC.ObtenerPermisosSimples490WC();
           }

           public List<Permiso490WC> ObtenerPermisosCompuestos490WC()
           {
               return PermisoDAL490WC.GestorPermisoORM490WC.ObtenerPermisosCompuestos490WC();
           }

           public List<Permiso490WC> ObtenerRoles490WC()
           {
               return PermisoDAL490WC.GestorPermisoORM490WC.ObtenerRoles490WC();
           }
           public List<Permiso490WC> ObtenerTodoSinRoles490WC()
           {
               return PermisoDAL490WC.GestorPermisoORM490WC.ObtenerTodoSinRoles490WC();
           }
           public List<Permiso490WC> ObtenerPermisosArbol490WC()
           {
               return PermisoDAL490WC.GestorPermisoORM490WC.LeerPermisosEnArbol490WC();
           }
           #endregion
        */

        /*   private bool BuscarPermiso490WC(string nombrePermiso490WC, PermisoCompuesto490WC raiz490WC)
           {
               if (raiz490WC == null)
               {
                   return false;
               }

               foreach (var permiso490WC in raiz490WC.PermisosIncluidos490WC())
               {
                   if (permiso490WC.obtenerPermisoNombre490WC() == nombrePermiso490WC || (permiso490WC is PermisoCompuesto490WC && BuscarPermiso490WC(nombrePermiso490WC, (PermisoCompuesto490WC)permiso490WC)))
                   {
                       return true;
                   }
               }
               return false;
           }*/
        /*   public PermisoCompuesto490WC ObtenerPermisoCompuesto490WC(string nombreRol490WC)
           {
               return PermisoDAL490WC.GestorPermisoORM490WC.LeerPermisoCompuesto490WC(nombreRol490WC);
           }*/
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
