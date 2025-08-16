using DAL490WC;
using SE490WC;
using SERVICIOS490WC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLS490WC
{
    public class Bitacora490WC
    {

        public void AltaEvento490WC(string Modulo490WC, string Descripcion490WC, int Criticidad490WC)
        {
            BitacoraDAL490WC GestorBitacora490WC = new BitacoraDAL490WC();
            if (SesionManager490WC.GestorSesion490WC.Usuario490WC != null)
            {
                BitacoraSE490WC bitacora490WC = new BitacoraSE490WC(SesionManager490WC.GestorSesion490WC.Usuario490WC.Username490WC, DateTime.Now.Date, DateTime.Now.TimeOfDay, Modulo490WC, Descripcion490WC, Criticidad490WC);
                GestorBitacora490WC.Alta490WC(bitacora490WC);
            }
        }

        public List<BitacoraSE490WC> ObtenerBitacoraPorConsulta490WC(string usuarioFiltrar490WC = "", string moduloFiltrar490WC = "", string descripcionFiltrar490WC = "", string criticidadFiltrar490WC = "", DateTime? fechaInicioFiltrar490WC = null, DateTime? fechaFinFiltrar490WC = null)
        {
            BitacoraDAL490WC GestorBitacora490WC = new BitacoraDAL490WC();
            return GestorBitacora490WC.ObtenerEventosPorConsulta490WC(usuarioFiltrar490WC, moduloFiltrar490WC, descripcionFiltrar490WC, criticidadFiltrar490WC, fechaInicioFiltrar490WC, fechaFinFiltrar490WC);
        }

    }
}
