using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE490WC
{
    public class BitacoraSE490WC
    {
        public string IdBitacora490WC { get; set; }
        public string Username490WC { get; set; }
        public DateTime Fecha490WC { get; set; }
        public TimeSpan Hora490WC { get; set; }
        public string Modulo490WC { get; set; }
        public string Descripcion490WC { get; set; }
        public int Criticidad490WC { get; set; }
        public BitacoraSE490WC(string nUsername490WC, DateTime nFecha490WC, TimeSpan nHora490WC, string nModulo490WC, string nDescripcion490WC, int nCriticidad490WC, string nIdBitacora490WC = "")
        {
            IdBitacora490WC = nIdBitacora490WC;
            Username490WC = nUsername490WC;
            Fecha490WC = nFecha490WC;
            Hora490WC = nHora490WC;
            Modulo490WC = nModulo490WC;
            Descripcion490WC = nDescripcion490WC;
            Criticidad490WC = nCriticidad490WC;
        }
    }
}
