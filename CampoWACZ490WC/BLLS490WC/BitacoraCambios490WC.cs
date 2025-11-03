using DAL490WC;
using SE490WC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLS490WC
{
    public class BitacoraCambios490WC
    {
        public List<BitacoraCambioSE490WC> ObtenerEventosPorConsulta490WC(int CodigoBeneficioFiltrar490WC = 0, string nombreBeneficioFiltrar490WC = "", DateTime? fechaInicioFiltrar490WC = null, DateTime? fechaFinFiltrar490WC = null)
        {
            BitacoraCambiosDAL490WC gestorBitacoraCambios490WC = new BitacoraCambiosDAL490WC();
            return gestorBitacoraCambios490WC.ObtenerEventosPorConsulta490WC(CodigoBeneficioFiltrar490WC, nombreBeneficioFiltrar490WC, fechaInicioFiltrar490WC, fechaFinFiltrar490WC);
        }

        public List<BitacoraCambioSE490WC> ObtenerEventosSINFiltro()
        {
            BitacoraCambiosDAL490WC gestorBitacoraCambios490WC = new BitacoraCambiosDAL490WC();
            return gestorBitacoraCambios490WC.ObtenerEventosSINFiltro();
        }

        public bool RestaurarVersionBeneficio490WC(int numeroCambioRestaurar)
        {
            BitacoraCambiosDAL490WC gestorBitacoraCambios490WC = new BitacoraCambiosDAL490WC();
            bool operacion490WC = gestorBitacoraCambios490WC.RestaurarVersionBeneficio490WC(numeroCambioRestaurar);
            DigitoVerificador490WC gestorDigitoVerificador490WC = new DigitoVerificador490WC();
            gestorDigitoVerificador490WC.ActualizarIntegridadPorTabla490WC("Beneficio490WC");
            return operacion490WC;
        }

    }
}
