﻿using DAL490WC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SERVICIOS490WC
{
    public class UserManager490WC
    {
        private static UserManager490WC Instancia;
        public static UserManager490WC UserManagerSG490WC
        {
            get
            {
                if (Instancia == null)
                {
                    Instancia = new UserManager490WC();
                }
                return Instancia;
            }
        }

        #region Operaciones Usuario 490WC
        public void Alta490WC(Usuario490WC UsuarioAlta490WC)
        {
            UsuarioAccesoDatos490WC.UsuarioAccesoDatosSG490WC.Alta490WC(UsuarioAlta490WC);
        }
        public void Baja490WC(string username490WC)
        {
            UsuarioAccesoDatos490WC.UsuarioAccesoDatosSG490WC.Baja490WC(username490WC);
        }
        public void Modificar490WC(Usuario490WC UsuarioModificado)
        {
            UsuarioAccesoDatos490WC.UsuarioAccesoDatosSG490WC.Modificar490WC(UsuarioModificado);
        }
        public void DesbloquearUsuario490WC(Usuario490WC UsuarioDesbloquear)
        {
            UsuarioAccesoDatos490WC.UsuarioAccesoDatosSG490WC.DesbloquearUsuario490WC(UsuarioDesbloquear);
        }
        public void BloquearUsuario490WC(string username490WC)
        {
            UsuarioAccesoDatos490WC.UsuarioAccesoDatosSG490WC.BloquearUsuario490WC(username490WC);
        }
        public void DesactivarUsuario490WC(string username490WC)
        {
            UsuarioAccesoDatos490WC.UsuarioAccesoDatosSG490WC.DesactivarUsuario490WC(username490WC);
        }
        public void ActivarUsuario490WC(string username490WC)
        {
            UsuarioAccesoDatos490WC.UsuarioAccesoDatosSG490WC.ActivarUsuario490WC(username490WC);
        }
        #endregion

        #region Busquedas De Usuarios 490WC
        public List<Usuario490WC> DevolverTodosLosUsuarios490WC()
        {
            return UsuarioAccesoDatos490WC.UsuarioAccesoDatosSG490WC.DevolverTodosLosUsuarios490WC();
        }
      
        public Usuario490WC BuscarUsuarioPorUsername490WC(string Username490WC)
        {
            return UsuarioAccesoDatos490WC.UsuarioAccesoDatosSG490WC.BuscarUsuarioPorUsername490WC(Username490WC);
        }
        public Usuario490WC BuscarUsuarioPorDNI490WC(string DNI490WC)
        {
            return UsuarioAccesoDatos490WC.UsuarioAccesoDatosSG490WC.BuscarUsuarioPorDNI490WC(DNI490WC);
        }

        public Usuario490WC BuscarUsuarioPorEmail490WC(string Email490WC)
        {
            return UsuarioAccesoDatos490WC.UsuarioAccesoDatosSG490WC.BuscarUsuarioPorEmail490WC(Email490WC);
        }
        #endregion

        #region Verificaciones De Usuarios

        public bool VerificarDNI490WC(string DNI490WC)
        {
            Regex rgx490WC = new Regex("^[0-9]{2}[.]{1}[0-9]{3}[.]{1}[0-9]{3}$");

            if (rgx490WC.IsMatch(DNI490WC))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool VerificarEmail490WC(string email490WC)
        {

            Regex rgx490WC = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$");
            if (rgx490WC.IsMatch(email490WC))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool VerificarDNIDuplicado490WC(string DNI490WC)
        {
            Usuario490WC usuario490WC = BuscarUsuarioPorDNI490WC(DNI490WC);

            if (usuario490WC != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool VerificarEmailDuplicado490WC(string Email490WC)
        {
            Usuario490WC usuario490WC = BuscarUsuarioPorEmail490WC(Email490WC);

            if (usuario490WC != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool VerificarUsernameDuplicado490WC(string username490WC)
        {

            Usuario490WC usuario = BuscarUsuarioPorUsername490WC(username490WC);
            if (usuario != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string VerificarCambioClave490WC(string ClaveNueva490WC, string ClaveConfirmacion490WC, string ClaveActual490WC)
        {
           if (Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(ClaveActual490WC) == SesionManager490WC.GestorSesion490WC.Usuario490WC.Contraseña490WC)
           {
              if (Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(ClaveNueva490WC) == Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(ClaveConfirmacion490WC))
              {

                 if(Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(ClaveNueva490WC) != SesionManager490WC.GestorSesion490WC.Usuario490WC.Contraseña490WC)
                 {

                    if (Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(ClaveConfirmacion490WC) != SesionManager490WC.GestorSesion490WC.Usuario490WC.Contraseña490WC)
                    {
                            SesionManager490WC.GestorSesion490WC.Usuario490WC.Contraseña490WC = Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(ClaveNueva490WC);
                            Modificar490WC(SesionManager490WC.GestorSesion490WC.Usuario490WC);
                            return "Ninguno";
                    }
                    else
                    {
                            return "ClaveConfirmacionIgualActual";
                    }
                 }
                 else
                 {
                            return "ClaveNuevaIgualActual";
                 }
              }
              else
              {
                    return "ClaveNuevaDistintaClaveConfirmacion";
              }
           }
           else
           {
                return "ClaveActualDistintaOriginal";
           }
        }

        #endregion
    }
}
