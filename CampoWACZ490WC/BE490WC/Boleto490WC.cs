using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE490WC
{
    public abstract class Boleto490WC
    {
        public string IDBoleto490WC { get; set; }
        public string Origen490WC { get; set; }
        public string Destino490WC { get; set; }
        public DateTime FechaPartida490WC { get; set; }
        public DateTime FechaLlegada490WC { get; set; }
        public bool IsVendido490WC { get; set; }
        public float EquipajePermitido490WC { get; set; }
        public string ClaseBoleto490WC { get; set; }
        public float Precio490WC { get; set; }
        public Cliente490WC Titular490WC { get; set; }

        public Boleto490WC(string nIDBoleto490WC, string nOrigen490WC, string nDestino490WC, DateTime nFechaPartida490WC, DateTime nFechaLlegada490WC, bool nIsVendido490WC, float nEquipajePermitido490WC, string nClaseBoleto490WC, float nPrecio490WC, Cliente490WC nTitular490WC)
        {
            IDBoleto490WC = nIDBoleto490WC;
            Origen490WC = nOrigen490WC;
            Destino490WC = nDestino490WC;
            FechaPartida490WC = nFechaPartida490WC;
            FechaLlegada490WC = nFechaLlegada490WC;
            IsVendido490WC = nIsVendido490WC;
            EquipajePermitido490WC = nEquipajePermitido490WC;
            ClaseBoleto490WC = nClaseBoleto490WC;
            Precio490WC = nPrecio490WC;
            Titular490WC = nTitular490WC;
        }
    }
}
