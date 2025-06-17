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
    public class GestorBeneficio490WC
    {
        public void Alta490WC(Beneficio490WC BeneficioAlta490WC)
        {
            BeneficioDAL490WC beneficioDAL490WC = new BeneficioDAL490WC();
            beneficioDAL490WC.Alta490WC(BeneficioAlta490WC);
        }

        public void Baja490WC(int ID490WC)
        {
            BeneficioDAL490WC beneficioDAL490WC = new BeneficioDAL490WC();
            beneficioDAL490WC.Baja490WC(ID490WC);
        }

        public void Modificacion490WC(Beneficio490WC BeneficioModificado490WC)
        {
            BeneficioDAL490WC beneficioDAL490WC = new BeneficioDAL490WC();
            beneficioDAL490WC.Modificacion490WC(BeneficioModificado490WC);
        }

        public void ReducirSaldoEstrellas490WC(string DNICliente490WC, int cantidadEstrellas490WC)
        {
            BeneficioDAL490WC beneficioDAL490WC = new BeneficioDAL490WC();
            beneficioDAL490WC.ReducirSaldoEstrellas490WC(DNICliente490WC, cantidadEstrellas490WC);
        }

        public void AplicarBeneficio490WC(int IDBoleto490WC, float DescuentoAplicar490WC)
        {
            BeneficioDAL490WC beneficioDAL490WC = new BeneficioDAL490WC();
            beneficioDAL490WC.AplicarBeneficio490WC(IDBoleto490WC, DescuentoAplicar490WC);
        }

        public void AgregarBeneficioACliente490WC(string DNICliente490WC, int CodigoBeneficio490WC)
        {
           BeneficioDAL490WC gestorBeneficio490WC = new BeneficioDAL490WC();
           gestorBeneficio490WC.AgregarBeneficioACliente490WC(DNICliente490WC, CodigoBeneficio490WC);
        }

        public Beneficio490WC ObtenerBeneficioPorCodigo490WC(int CodigoBeneficio490WC)
        {
            BeneficioDAL490WC beneficioDAL490WC = new BeneficioDAL490WC();
            return beneficioDAL490WC.ObtenerBeneficioPorCodigo490WC(CodigoBeneficio490WC);
        }

        public List<Beneficio490WC> ObtenerTodosLosBeneficios490WC()
        {
            BeneficioDAL490WC beneficioDAL490WC = new BeneficioDAL490WC();
            return beneficioDAL490WC.ObtenerTodosLosBeneficios490WC();
        }

        public List<Beneficio490WC> ObtenerBeneficiosPorCliente490WC(string DNI490WC)
        {
            BeneficioDAL490WC beneficioDAL490WC = new BeneficioDAL490WC();
            return beneficioDAL490WC.ObtenerBeneficiosPorCliente490WC(DNI490WC);
        }

        public List<Beneficio490WC> ObtenerBeneficiosPorCantidadDeReclamados490WC(int cantidadReclamados)
        {
            BeneficioDAL490WC beneficioDAL490WC = new BeneficioDAL490WC();
            return beneficioDAL490WC.ObtenerBeneficiosPorCantidadDeReclamados490WC(cantidadReclamados);
        }

    }
}
