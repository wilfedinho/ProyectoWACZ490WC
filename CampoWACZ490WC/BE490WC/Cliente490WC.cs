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
        public string DatosTarjeta490WC { get; set; }
        public int EstrellasCliente490WC { get; set; }
        public List<Beneficio490WC> BeneficiosCliente490WC { get; set; }
        public Cliente490WC(string nDNI490WC, string nNombre490WC, string nApellido490WC, string nDatosTarjeta490WC, int nEstrellasCliente490WC, List<Beneficio490WC> nBeneficiosCliente490WC = null)
        {
            DNI490WC = nDNI490WC;
            Nombre490WC = nNombre490WC;
            Apellido490WC = nApellido490WC;
            DatosTarjeta490WC = nDatosTarjeta490WC;
            EstrellasCliente490WC = nEstrellasCliente490WC;
            if (nBeneficiosCliente490WC != null)
            {
                BeneficiosCliente490WC = nBeneficiosCliente490WC;
            }
            else
            {
                BeneficiosCliente490WC = new List<Beneficio490WC>();
            }
        }
    }
}
