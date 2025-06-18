using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE490WC
{
    public class Factura490WC
    {
        public int NumeroFactura490WC { get; set; }
        public string Nombre490WC { get; set; }
        public string Apellido490WC { get; set; }
        public string BeneficioAplicado490WC { get; set; } 
        public string DNIC490WC { get; set; }
        public DateTime FechaEmision490WC { get; set; }
        public TimeSpan HoraEmision490WC { get; set; }
        public int NumeroBoleto490WC { get; set; }
        public float Subtotal490WC { get; set; }
        public float Total490WC { get; set; }
        public Factura490WC(int numeroFactura, string nombreCliente, string apellidoCliente, string dniCliente, DateTime fechaEmision, TimeSpan horaEmision, int numeroBoleto, float subtotal, float total, string beneficioAplicado490WC = null)
        {
            NumeroFactura490WC = numeroFactura;
            Nombre490WC = nombreCliente;
            Apellido490WC = apellidoCliente;
            DNIC490WC = dniCliente;
            FechaEmision490WC = fechaEmision;
            HoraEmision490WC = horaEmision;
            NumeroBoleto490WC = numeroBoleto;
            Subtotal490WC = subtotal;
            Total490WC = total;
            BeneficioAplicado490WC = beneficioAplicado490WC;
        }
    }
}
