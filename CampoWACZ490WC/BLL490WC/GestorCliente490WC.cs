using BE490WC;
using BLLS490WC;
using DAL490WC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BLL490WC
{
    public class GestorCliente490WC
    {

        public void Alta490WC(Cliente490WC clienteAlta490WC)
        {
            ClienteDAL490WC clienteDAL490WC = new ClienteDAL490WC();
            clienteDAL490WC.Alta490WC(clienteAlta490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Cliente", "Crear Cliente", 3);
        }
        public void Baja490WC(string dni)
        {
            ClienteDAL490WC clienteDAL490WC = new ClienteDAL490WC();
            clienteDAL490WC.Baja490WC(dni);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Cliente", "Eliminar Cliente", 5);
        }

        public void ActivarCliente490WC(string DNI490WC)
        {
            ClienteDAL490WC clienteDAL490WC = new ClienteDAL490WC();
            clienteDAL490WC.ActivarCliente490WC(DNI490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Cliente", "Activar Cliente", 5);
        }

        public void Modificar490WC(Cliente490WC clienteModificado490WC)
        {
            ClienteDAL490WC clienteDAL490WC = new ClienteDAL490WC();
            clienteDAL490WC.Modificar490WC(clienteModificado490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Cliente", "Modificar Cliente", 3);
        }

        public string SerializarCliente490WC(List<Cliente490WC> datosSerializar490WC)
        {
            XmlSerializer Serializador490WC = new XmlSerializer(typeof(List<Cliente490WC>));
            using (var memoria490WC = new MemoryStream())
            {
                using (var escritor490WC = new StreamWriter(memoria490WC, new UTF8Encoding(true)))
                {
                    Serializador490WC.Serialize(escritor490WC, datosSerializar490WC);
                    escritor490WC.Flush();
                    return Encoding.UTF8.GetString(memoria490WC.ToArray());
                }
            }
        }

        public void GuardarXML490WC(string datosXML490WC, string patron490WC)
        {
            using (StreamWriter escritor490WC = new StreamWriter(patron490WC))
            {
                escritor490WC.Write(datosXML490WC);
            }
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Cliente", "Serializar Clientes", 2);
        }

        public bool VerificarFormatoDNI490WC(string DNI490WC)
        {
            Regex rgx490WC = new Regex("^[0-9]{2}[.]{1}[0-9]{3}[.]{1}[0-9]{3}$");

            if (rgx490WC.IsMatch(DNI490WC))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificarFormatoFechaTarjeta490WC(string FechaTarjeta490WC)
        {
            Regex rgx490WC = new Regex("^[0-9]{2}[/]{1}[0-9]{2}$");
            if (rgx490WC.IsMatch(FechaTarjeta490WC))
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
        public bool VerificarFormatoNumeroTarjeta490WC(string NumeroTarjeta490WC)
        {
            Regex rgx490WC = new Regex("^[0-9]{16}$");
            if (rgx490WC.IsMatch(NumeroTarjeta490WC))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool VerificarFormatoCVVTarjeta490WC(string CVVTarjeta490WC)
        {
            Regex rgx490WC = new Regex("^[0-9]{3}$");
            if (rgx490WC.IsMatch(CVVTarjeta490WC))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificarCelular490WC(string Celular490WC)
        {
            Regex rgx490WC = new Regex("^[0-9]{10}$");
            if (rgx490WC.IsMatch(Celular490WC))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificarEmail490WC(string email490WC)
        {
            Regex rgx490WC = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$");
            if (rgx490WC.IsMatch(email490WC))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ModificarEstrellasCliente490WC(string DNI490WC, int EstrellasReducir490WC)
        {
            ClienteDAL490WC clienteDAL490WC = new ClienteDAL490WC();
            clienteDAL490WC.ModificarEstrellasCliente490WC(DNI490WC, EstrellasReducir490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Cliente", "Modificar Cliente", 3);
        }

       

        public Cliente490WC BuscarClientePorDNI490WC(string DNI490WC)
        {
            ClienteDAL490WC clienteDAL490WC = new ClienteDAL490WC();
            return clienteDAL490WC.BuscarClientePorDNI490WC(DNI490WC);
        }

        public List<Cliente490WC> ObtenerTodosLosCliente490WC()
        {
            ClienteDAL490WC clienteDAL490WC = new ClienteDAL490WC();
            return clienteDAL490WC.ObtenerTodosLosCliente490WC();
        }
    }
}
