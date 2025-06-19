using BE490WC;
using DAL490WC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public bool ExisteBoletoEnAsiento490WC(Boleto490WC boletoVerificarExistencia490WC)
        {
            BoletoDAL490WC gestorBoleto490WC = new BoletoDAL490WC();
            return gestorBoleto490WC.ExisteBoletoEnAsiento490WC(boletoVerificarExistencia490WC);
        }

        public bool ExisteBoletoEnAsientoParaModificar490WC(Boleto490WC boletoVerificarExistencia490WC)
        {
            BoletoDAL490WC gestorBoleto490WC = new BoletoDAL490WC();
            return gestorBoleto490WC.ExisteBoletoEnAsientoParaModificar490WC(boletoVerificarExistencia490WC);
        }

        #endregion

        #region Verificar Formatos

        public bool VerificarFormatoAsiento490WC(string FormatoAsiento490WC)
        {
            Regex rgxFormatoAsiento = new Regex("^[A-Z]{1}[0-9]{3}$");
            if (rgxFormatoAsiento.IsMatch(FormatoAsiento490WC))
            {
                return true;
            }
            else
            {
                return false;
            }

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
        public List<Boleto490WC> ObtenerBoletosFiltrados490WC(string origen490WC = "", string destino490WC = "", string claseBoleto490WC = "", float? precioDesde490WC = null, float? precioHasta490WC = null, float? pesoPermitido490WC = null, DateTime? fechaPartida490WC = null, DateTime? fechaLlegada490WC = null, DateTime? fechaPartidaVUELTA490WC = null, DateTime? fechaLlegadaVUELTA490WC = null)
        {
            BoletoDAL490WC gestorBoleto490WC = new BoletoDAL490WC();
            return gestorBoleto490WC.ObtenerBoletosFiltrados490WC(origen490WC, destino490WC, claseBoleto490WC, precioDesde490WC, precioHasta490WC, pesoPermitido490WC, fechaPartida490WC, fechaLlegada490WC, fechaPartidaVUELTA490WC, fechaLlegadaVUELTA490WC);
        }

        public Boleto490WC ObtenerBoletoConBeneficio490WC(string ID490WC)
        {
            BoletoDAL490WC boletoDAL490WC = new BoletoDAL490WC();
            return boletoDAL490WC.ObtenerBoletoConBeneficio490WC(ID490WC);
        }

            #endregion

        }
}
