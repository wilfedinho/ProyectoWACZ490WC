using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE490WC
{
    public class BitacoraCambioSE490WC
    {
        public int NumeroCambioRealizado490WC { get; set; }
        public int CodigoBeneficio490WC { get; set; }
        public string Nombre490WC { get; set; }
        public int PrecioEstrella490WC { get; set; }
        public int CantidadBeneficioReclamado490WC { get; set; }
        public float DescuentoAplicar490WC { get; set; }
        public DateTime Fecha490WC { get; set; }
        public TimeSpan Hora490WC { get; set; }
        public bool Activo490WC { get; set; }
        public BitacoraCambioSE490WC(int nNumeroCambioRealizado490WC, int nCodigoBeneficio490WC, string nNombre490WC, int nPrecioEstrella490WC, int nCantidadBeneficioReclamado490WC, float nDescuentoAplicar490WC, DateTime nFecha490WC, TimeSpan nHora490WC, bool nActivo490WC)
        {
            NumeroCambioRealizado490WC = nNumeroCambioRealizado490WC;
            CodigoBeneficio490WC = nCodigoBeneficio490WC;
            Nombre490WC = nNombre490WC;
            PrecioEstrella490WC = nPrecioEstrella490WC;
            CantidadBeneficioReclamado490WC = nCantidadBeneficioReclamado490WC;
            DescuentoAplicar490WC = nDescuentoAplicar490WC;
            Fecha490WC = nFecha490WC;
            Hora490WC = nHora490WC;
            Activo490WC = nActivo490WC;

        }
    }
}
