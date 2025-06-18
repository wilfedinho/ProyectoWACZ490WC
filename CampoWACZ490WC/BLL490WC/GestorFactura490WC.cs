using BE490WC;
using DAL490WC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL490WC
{
    public class GestorFactura490WC
    {
        public void Alta490WC(Factura490WC FacturaAlta490WC)
        {
            FacturaDAL gestorFactura490WC = new FacturaDAL();
            gestorFactura490WC.Alta490WC(FacturaAlta490WC);
        }



        public List<Factura490WC> ObtenerTodasLasFacturas490WC()
        {
            FacturaDAL gestorFactura490WC = new FacturaDAL();
            return gestorFactura490WC.ObtenerTodasLasFacturas490WC();
        }
    }
}
