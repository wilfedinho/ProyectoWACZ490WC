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
    public class GestorCliente490WC
    {
        
        public void Alta490WC(Cliente490WC clienteAlta490WC)
        {
            ClienteDAL490WC clienteDAL490WC = new ClienteDAL490WC();
            clienteDAL490WC.Alta490WC(clienteAlta490WC);
        }
        public void Baja490WC(string dni)
        {
            ClienteDAL490WC clienteDAL490WC = new ClienteDAL490WC();
            clienteDAL490WC.Baja490WC(dni);
        }
        public void Modificar490WC(Cliente490WC clienteModificado490WC)
        {
            ClienteDAL490WC clienteDAL490WC = new ClienteDAL490WC();
            clienteDAL490WC.Modificar490WC(clienteModificado490WC);
        }
        public void ModificarEstrellasCliente490WC(string DNI490WC, int EstrellasReducir490WC)
        {
            ClienteDAL490WC clienteDAL490WC = new ClienteDAL490WC();
            clienteDAL490WC.ModificarEstrellasCliente490WC(DNI490WC, EstrellasReducir490WC);
        }

        public Cliente490WC BuscarClientePorDNI490WC(string DNI490WC)
        {
            ClienteDAL490WC clienteDAL490WC = new ClienteDAL490WC();
            return  clienteDAL490WC.BuscarClientePorDNI490WC(DNI490WC);
        }

        public List<Cliente490WC> ObtenerTodosLosCliente490WC()
        {
            ClienteDAL490WC clienteDAL490WC = new ClienteDAL490WC();
            return clienteDAL490WC.ObtenerTodosLosCliente490WC();
        }
    }
}
