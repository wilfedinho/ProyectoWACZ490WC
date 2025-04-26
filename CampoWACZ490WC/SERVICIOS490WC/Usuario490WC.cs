using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS490WC
{
    public class Usuario490WC
    {
        public string Username490WC { get; set; }
        public string Nombre490WC { get; set; }
        public string Apellido490WC { get; set; }
        public string DNI490WC { get; set; }
        public string Contraseña490WC { get; set; }
        public string Email490WC { get; set; }
        public string Rol490WC { get; set; }
        public int Intentos490WC { get; set; }
        public bool IsBloqueado490WC { get; set; }
        public bool IsHabilitado490WC { get; set; }
        public string IdiomaUsuario490WC { get; set; }

        public Usuario490WC(string nUsername490WC, string nNombre490WC, string nApellido490WC, string nDNI490WC, string nContraseña490WC, string nEmail490WC, string rOL490WC, string nIdioma490WC, int nIntentos490WC = 0, bool nIsBloqueado490WC = false, bool nIsHabilitado490WC = true)
        {
            Username490WC = nUsername490WC;
            Nombre490WC = nNombre490WC;
            Apellido490WC = nApellido490WC;
            DNI490WC = nDNI490WC;
            Contraseña490WC = nContraseña490WC;
            Email490WC = nEmail490WC;
            Rol490WC = rOL490WC;
            IdiomaUsuario490WC = nIdioma490WC;
            Intentos490WC = nIntentos490WC;
            IsBloqueado490WC = nIsBloqueado490WC;
            IsHabilitado490WC = nIsHabilitado490WC;
        }
    }
}
