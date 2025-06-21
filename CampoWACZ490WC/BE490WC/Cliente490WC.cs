using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE490WC
{
    public class Cliente490WC
    {
        public string DNI490WC { get; set; }
        public string Nombre490WC { get; set; }
        public string Apellido490WC { get; set; }
        public List<string> Emails490WC { get; set; }
        public List<string> Celulares490WC { get; set; }
        public string Direccion490WC { get; set; }
        public bool Activo490WC { get; set; }
        public int EstrellasCliente490WC { get; set; }
        public List<Beneficio490WC> BeneficiosCliente490WC { get; set; }
        public Cliente490WC(string nDNI490WC, string nNombre490WC, string nApellido490WC, int nEstrellasCliente490WC, List<string> nEmail490WC, List<string> nCelular490WC, string nDireccion490WC, bool nActivo490WC, List<Beneficio490WC> nBeneficiosCliente490WC = null)
        {
            DNI490WC = nDNI490WC;
            Nombre490WC = nNombre490WC;
            Apellido490WC = nApellido490WC;
            EstrellasCliente490WC = nEstrellasCliente490WC;
            Direccion490WC = nDireccion490WC;
            Activo490WC = nActivo490WC;
            if (nBeneficiosCliente490WC != null)
            {
                BeneficiosCliente490WC = nBeneficiosCliente490WC;
            }
            else
            {
                BeneficiosCliente490WC = new List<Beneficio490WC>();
            }
            if (nEmail490WC != null)
            {
                Emails490WC = nEmail490WC;
            }
            else
            {
                Emails490WC = new List<string>();
            }
            if (nCelular490WC != null)
            {
                Celulares490WC = nCelular490WC;
            }
            else
            {
                Celulares490WC= new List<string>();
            }
        }
    }
}
