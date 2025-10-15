using BE490WC;
using BLLS490WC;
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
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Beneficio", "Crear Beneficio",3);
            DigitoVerificador490WC gestorDigitoVerificador490WC = new DigitoVerificador490WC();
            gestorDigitoVerificador490WC.ActualizarIntegridadPorTabla490WC("Beneficio490WC");
        }

        public bool Baja490WC(int ID490WC)
        {
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Beneficio", "Eliminar Beneficio", 5);
            BeneficioDAL490WC beneficioDAL490WC = new BeneficioDAL490WC();
            bool operacion490WC = beneficioDAL490WC.Baja490WC(ID490WC);
            DigitoVerificador490WC gestorDigitoVerificador490WC = new DigitoVerificador490WC();
            gestorDigitoVerificador490WC.ActualizarIntegridadPorTabla490WC("Beneficio490WC");
            return operacion490WC;
        }

        public void Modificacion490WC(Beneficio490WC BeneficioModificado490WC)
        {
            BeneficioDAL490WC beneficioDAL490WC = new BeneficioDAL490WC();
            beneficioDAL490WC.Modificacion490WC(BeneficioModificado490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Beneficio", "Modificar Beneficio", 3);
            DigitoVerificador490WC gestorDigitoVerificador490WC = new DigitoVerificador490WC();
            gestorDigitoVerificador490WC.ActualizarIntegridadPorTabla490WC("Beneficio490WC");
        }

        public void ReducirSaldoEstrellas490WC(string DNICliente490WC, int cantidadEstrellas490WC)
        {
            BeneficioDAL490WC beneficioDAL490WC = new BeneficioDAL490WC();
            beneficioDAL490WC.ReducirSaldoEstrellas490WC(DNICliente490WC, cantidadEstrellas490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Beneficio", "Reducir Estrellas", 3);
            DigitoVerificador490WC gestorDigitoVerificador490WC = new DigitoVerificador490WC();
            gestorDigitoVerificador490WC.ActualizarIntegridadPorTabla490WC("Cliente490WC");
        }

        public void AplicarBeneficio490WC(string IDBoleto490WC, float DescuentoAplicar490WC, string nombreBeneficio490WC)
        {
            BeneficioDAL490WC beneficioDAL490WC = new BeneficioDAL490WC();
            beneficioDAL490WC.AplicarBeneficio490WC(IDBoleto490WC, DescuentoAplicar490WC,nombreBeneficio490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Beneficio", "Aplicar Beneficio", 3);
            DigitoVerificador490WC gestorDigitoVerificador490WC = new DigitoVerificador490WC();
            gestorDigitoVerificador490WC.ActualizarIntegridadPorTabla490WC("Boleto490WC");
        }

        public void AgregarBeneficioACliente490WC(string DNICliente490WC, int CodigoBeneficio490WC)
        {
           BeneficioDAL490WC gestorBeneficio490WC = new BeneficioDAL490WC();
           gestorBeneficio490WC.AgregarBeneficioACliente490WC(DNICliente490WC, CodigoBeneficio490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Beneficio", "Asignar Beneficio a Cliente", 2);
            DigitoVerificador490WC gestorDigitoVerificador490WC = new DigitoVerificador490WC();
            gestorDigitoVerificador490WC.ActualizarIntegridadPorTabla490WC("Cliente_Beneficio490WC");
        }
        public void EliminarBeneficioDeCliente490WC(string DNICliente490WC, int CodigoBeneficio490WC)
        {
            BeneficioDAL490WC gestorBeneficio490WC = new BeneficioDAL490WC();
            gestorBeneficio490WC.EliminarBeneficioDeCliente490WC(DNICliente490WC, CodigoBeneficio490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Beneficio", "Eliminar Beneficio a un Cliente", 5);
            DigitoVerificador490WC gestorDigitoVerificador490WC = new DigitoVerificador490WC();
            gestorDigitoVerificador490WC.ActualizarIntegridadPorTabla490WC("Cliente_Beneficio490WC");
        }

        public bool ExisteNombreBeneficioAlta490WC(string nombreBeneficio490WC)
        {
            BeneficioDAL490WC gestorBeneficio490WC = new BeneficioDAL490WC();
            return gestorBeneficio490WC.ExisteNombreBeneficioAlta490WC(nombreBeneficio490WC);
        }

        public bool ExisteNombreBeneficioModificar490WC(string nombreBeneficio490WC, int idActual490WC)
        {
            BeneficioDAL490WC gestorBeneficio490WC = new BeneficioDAL490WC();
            return gestorBeneficio490WC.ExisteNombreBeneficioModificar490WC(nombreBeneficio490WC, idActual490WC);
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
