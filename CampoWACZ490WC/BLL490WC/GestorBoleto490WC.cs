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
    public class GestorBoleto490WC
    {
        #region Operaciones Boleto

        public void Alta490WC(Boleto490WC BoletoAgregar490WC)
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            gestorBoletoDAL490WC.Alta490WC(BoletoAgregar490WC);
        }

        public void Baja490WC(string IDBoleto490WC)
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            gestorBoletoDAL490WC.Baja490WC(IDBoleto490WC);
        }

        public void Modificar490WC(Boleto490WC BoletoModificado490WC)
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            gestorBoletoDAL490WC.Modificar490WC(BoletoModificado490WC);
        }

        public void AsignarBoletoCliente490WC(Boleto490WC boletoAsignar490WC, Cliente490WC clienteAsignar490WC)
        {
            BoletoDAL490WC boletoDAL490WC = new BoletoDAL490WC();
            boletoDAL490WC.AsignarBoletoCliente490WC(boletoAsignar490WC, clienteAsignar490WC);
        }


        public void GenerarBoletoCompra490WC(Boleto490WC boletoGenerar490WC)
        {
            BoletoDAL490WC boletoDAL490WC = new BoletoDAL490WC();
            boletoDAL490WC.GenerarBoletoCompra490WC(boletoGenerar490WC);
        }

        public void LiberarBoletosVencidos490WC()
        {
            BoletoDAL490WC boletoDAL490WC = new BoletoDAL490WC();
            boletoDAL490WC.LiberarBoletosVencidos490WC();
        }

        public void CobrarBoleto490WC(Boleto490WC BoletoCobrado490WC)
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            gestorBoletoDAL490WC.CobrarBoleto490WC(BoletoCobrado490WC);
        }



        #endregion

        #region Busqueda Boleto

        public List<Boleto490WC> ObtenerBoletosPorModalidad490WC(string Modalidad490WC)
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            return gestorBoletoDAL490WC.ObtenerBoletosPorModalidad490WC(Modalidad490WC);
        }

        public Boleto490WC ObtenerBoletoPorID490WC(string ID490WC)
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            return gestorBoletoDAL490WC.ObtenerBoletoPorID490WC(ID490WC);
        }

        public List<Boleto490WC> ObtenerBoletosPorPagarCliente490WC(Cliente490WC cliente490WC)
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            return gestorBoletoDAL490WC.ObtenerBoletosPorPagarCliente490WC(cliente490WC);
        }

        public List<Boleto490WC> ObtenerBoletosPorCliente490WC(Cliente490WC cliente490WC)
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            return gestorBoletoDAL490WC.ObtenerBoletosPorCliente490WC(cliente490WC);
        }
        public List<Boleto490WC> ObtenerTodosLosBoletos490WC()
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            return gestorBoletoDAL490WC.ObtenerTodosLosBoletos490WC();
        }
        public List<Boleto490WC> BuscarBoletosPorFiltros() // Falta implementar la logica de filtros, que hicimos en el otro proyecto.
        {
            return null;
        }
        #endregion

    }
}
