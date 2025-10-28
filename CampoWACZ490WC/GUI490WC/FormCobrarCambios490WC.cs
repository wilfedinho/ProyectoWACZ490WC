using BE490WC;
using BLL490WC;
using SERVICIOS490WC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI490WC
{
    public partial class FormCobrarCambios490WC : Form, iObserverLenguaje490WC
    {
        Cliente490WC clienteCobrar490WC;
        Boleto490WC boletoModificadoCobrar490WC;
        List<Boleto490WC> BoletosModificadosPorPagar490WC;
        FormCambiarTitular490WC formCambiarTitular490WC;
        float totalFactura490WC;
        bool pagoAceptado490WC = false;
        public FormCobrarCambios490WC()
        {
            InitializeComponent();
            CargarCliente490WC(null);
            CargarInfoFactura490WC();
        }

        public void CargarInfoFactura490WC()
        {
            GestorFactura490WC gestorFactura490WC = new GestorFactura490WC();
            TBVISTAPREVIAFACTURA490WC.Clear();

            if (boletoModificadoCobrar490WC == null && clienteCobrar490WC == null)
            {
                string mensajeSeleccionarBoleto490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("SeleccionarBoleto490WC");
                TBVISTAPREVIAFACTURA490WC.Text = mensajeSeleccionarBoleto490WC;
            }
            else if (boletoModificadoCobrar490WC is BoletoIDAVUELTA490WC && clienteCobrar490WC != null)
            {
                string[] cambios490WC = boletoModificadoCobrar490WC.CambiosRealizados490WC.Split(';');
                totalFactura490WC = boletoModificadoCobrar490WC.Precio490WC * 1.60f;
                if (boletoModificadoCobrar490WC.BeneficioAplicado490WC != null)
                {
                    string mensajeBeneficioAplicado490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("BeneficioAplicadoVistaPreviaFactura490WC");
                    string a = mensajeBeneficioAplicado490WC;
                    a = a.Replace("{gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1}", $"{gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1}");
                    a = a.Replace("{clienteCobrar490WC.Nombre490WC}", $"{clienteCobrar490WC.Nombre490WC}");
                    a = a.Replace("{clienteCobrar490WC.Apellido490WC}", $"{clienteCobrar490WC.Apellido490WC}");
                    a = a.Replace("{boletoModificadoCobrar490WC.BeneficioAplicado490WC}", $"{boletoModificadoCobrar490WC.BeneficioAplicado490WC}");
                    a = a.Replace("{clienteCobrar490WC.DNI490WC}", $"{clienteCobrar490WC.DNI490WC}");
                    a = a.Replace("{DateTime.Now.ToShortDateString()}", $"{DateTime.Now.ToShortDateString()}");
                    a = a.Replace("{DateTime.Now.ToShortTimeString()}", $"{DateTime.Now.ToShortTimeString()}");
                    a = a.Replace("{boletoModificadoCobrar490WC.IDBoleto490WC}", $"{cambios490WC[0].ToString()}");
                    a = a.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                    TBVISTAPREVIAFACTURA490WC.Text = a;

             
                    if ((!string.IsNullOrEmpty(cambios490WC[1])) || (!string.IsNullOrEmpty(cambios490WC[2])) || (!string.IsNullOrEmpty(cambios490WC[3])) || (!string.IsNullOrEmpty(cambios490WC[4])))
                    {
                        string mensajeCambioFecha490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioFechaVistaPreviaFactura490WC");
                        mensajeCambioFecha490WC = mensajeCambioFecha490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioFecha490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[5]))
                    {
                        string mensajeCambioBeneficio490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioBeneficioVistaPreviaFactura490WC");
                        mensajeCambioBeneficio490WC = mensajeCambioBeneficio490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioBeneficio490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[6]))
                    {
                        string mensajeCambioClase490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioClaseVistaPreviaFactura490WC");
                        mensajeCambioClase490WC = mensajeCambioClase490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioClase490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[7]))
                    {
                        string mensajeCambioAsiento490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioAsientoVistaPreviaFactura490WC");
                        mensajeCambioAsiento490WC = mensajeCambioAsiento490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioAsiento490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[8]))
                    {
                        string mensajeCambioPesoEquipaje490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioPesoEquipajeVistaPreviaFactura490WC");
                        mensajeCambioPesoEquipaje490WC = mensajeCambioPesoEquipaje490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioPesoEquipaje490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[9]))
                    {
                        string mensajeCambioTitular490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioTitularVistaPreviaFactura490WC");
                        mensajeCambioTitular490WC = mensajeCambioTitular490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioTitular490WC;
                    }
                    string mensajeSubtotal490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("SubtotalVistaPreviaFactura490WC");
                    mensajeSubtotal490WC = mensajeSubtotal490WC.Replace("{boletoModificadoCobrar490WC.Precio490WC}", $"{boletoModificadoCobrar490WC.Precio490WC}");
                    mensajeSubtotal490WC = mensajeSubtotal490WC.Replace("{totalFactura490WC}", $"{totalFactura490WC}");
                    mensajeSubtotal490WC = mensajeSubtotal490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                    TBVISTAPREVIAFACTURA490WC.Text += mensajeSubtotal490WC;
                }
                else
                {
                    string mensajeBeneficioNOAplicado490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("BeneficioNOAplicadoVistaPreviaFactura490WC");
                    mensajeBeneficioNOAplicado490WC = mensajeBeneficioNOAplicado490WC.Replace("{gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1}", $"{gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1}");
                    mensajeBeneficioNOAplicado490WC = mensajeBeneficioNOAplicado490WC.Replace("{clienteCobrar490WC.Nombre490WC}", $"{clienteCobrar490WC.Nombre490WC}");
                    mensajeBeneficioNOAplicado490WC = mensajeBeneficioNOAplicado490WC.Replace("{clienteCobrar490WC.Apellido490WC}", $"{clienteCobrar490WC.Apellido490WC}");
                    mensajeBeneficioNOAplicado490WC = mensajeBeneficioNOAplicado490WC.Replace("{clienteCobrar490WC.DNI490WC}", $"{clienteCobrar490WC.DNI490WC}");
                    mensajeBeneficioNOAplicado490WC = mensajeBeneficioNOAplicado490WC.Replace("{DateTime.Now.ToShortDateString()}", $"{DateTime.Now.ToShortDateString()}");
                    mensajeBeneficioNOAplicado490WC = mensajeBeneficioNOAplicado490WC.Replace("{DateTime.Now.ToShortTimeString()}", $"{DateTime.Now.ToShortTimeString()}");
                    mensajeBeneficioNOAplicado490WC = mensajeBeneficioNOAplicado490WC.Replace("{boletoModificadoCobrar490WC.IDBoleto490WC}", $"{cambios490WC[0].ToString()}");
                    mensajeBeneficioNOAplicado490WC = mensajeBeneficioNOAplicado490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                    TBVISTAPREVIAFACTURA490WC.Text = mensajeBeneficioNOAplicado490WC;
                    if ((!string.IsNullOrEmpty(cambios490WC[1])) || (!string.IsNullOrEmpty(cambios490WC[2])) || (!string.IsNullOrEmpty(cambios490WC[3])) || (!string.IsNullOrEmpty(cambios490WC[4])))
                    {
                        string mensajeCambioFecha490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioFechaVistaPreviaFactura490WC");
                        mensajeCambioFecha490WC = mensajeCambioFecha490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioFecha490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[5]))
                    {
                        string mensajeCambioBeneficio490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioBeneficioVistaPreviaFactura490WC");
                        mensajeCambioBeneficio490WC = mensajeCambioBeneficio490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioBeneficio490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[6]))
                    {
                        string mensajeCambioClase490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioClaseVistaPreviaFactura490WC");
                        mensajeCambioClase490WC = mensajeCambioClase490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioClase490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[7]))
                    {
                        string mensajeCambioAsiento490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioAsientoVistaPreviaFactura490WC");
                        mensajeCambioAsiento490WC = mensajeCambioAsiento490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioAsiento490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[8]))
                    {
                        string mensajeCambioPesoEquipaje490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioPesoEquipajeVistaPreviaFactura490WC");
                        mensajeCambioPesoEquipaje490WC = mensajeCambioPesoEquipaje490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioPesoEquipaje490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[9]))
                    {
                        string mensajeCambioTitular490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioTitularVistaPreviaFactura490WC");
                        mensajeCambioTitular490WC = mensajeCambioTitular490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioTitular490WC;
                    }
                    string mensajeSubtotal490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("SubtotalVistaPreviaFactura490WC");
                    mensajeSubtotal490WC = mensajeSubtotal490WC.Replace("{boletoModificadoCobrar490WC.Precio490WC}", $"{boletoModificadoCobrar490WC.Precio490WC}");
                    mensajeSubtotal490WC = mensajeSubtotal490WC.Replace("{totalFactura490WC}", $"{totalFactura490WC}");
                    mensajeSubtotal490WC = mensajeSubtotal490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                    TBVISTAPREVIAFACTURA490WC.Text += mensajeSubtotal490WC;
                }
            }
            else if (boletoModificadoCobrar490WC is BoletoIDA490WC && clienteCobrar490WC != null)
            {
                totalFactura490WC = boletoModificadoCobrar490WC.Precio490WC * 1.60f;
                string[] cambios490WC = boletoModificadoCobrar490WC.CambiosRealizados490WC.Split(';');
                if (boletoModificadoCobrar490WC.BeneficioAplicado490WC != null)
                {


                    string mensajeBeneficioAplicado490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("BeneficioAplicadoVistaPreviaFactura490WC");
                    string a = mensajeBeneficioAplicado490WC;
                    a = a.Replace("{gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1}", $"{gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1}");
                    a = a.Replace("{clienteCobrar490WC.Nombre490WC}", $"{clienteCobrar490WC.Nombre490WC}");
                    a = a.Replace("{clienteCobrar490WC.Apellido490WC}", $"{clienteCobrar490WC.Apellido490WC}");
                    a = a.Replace("{boletoModificadoCobrar490WC.BeneficioAplicado490WC}", $"{boletoModificadoCobrar490WC.BeneficioAplicado490WC}");
                    a = a.Replace("{clienteCobrar490WC.DNI490WC}", $"{clienteCobrar490WC.DNI490WC}");
                    a = a.Replace("{DateTime.Now.ToShortDateString()}", $"{DateTime.Now.ToShortDateString()}");
                    a = a.Replace("{DateTime.Now.ToShortTimeString()}", $"{DateTime.Now.ToShortTimeString()}");
                    a = a.Replace("{boletoModificadoCobrar490WC.IDBoleto490WC}", $"{cambios490WC[0].ToString()}");
                    a = a.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                    TBVISTAPREVIAFACTURA490WC.Text = a;

                    if ((!string.IsNullOrEmpty(cambios490WC[1])) || (!string.IsNullOrEmpty(cambios490WC[2])))
                    {
                        string mensajeCambioFecha490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioFechaVistaPreviaFactura490WC");
                        mensajeCambioFecha490WC = mensajeCambioFecha490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioFecha490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[5]))
                    {
                        string mensajeCambioBeneficio490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioBeneficioVistaPreviaFactura490WC");
                        mensajeCambioBeneficio490WC = mensajeCambioBeneficio490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioBeneficio490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[6]))
                    {
                        string mensajeCambioClase490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioClaseVistaPreviaFactura490WC");
                        mensajeCambioClase490WC = mensajeCambioClase490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioClase490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[7]))
                    {
                        string mensajeCambioAsiento490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioAsientoVistaPreviaFactura490WC");
                        mensajeCambioAsiento490WC = mensajeCambioAsiento490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioAsiento490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[8]))
                    {
                        string mensajeCambioPesoEquipaje490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioPesoEquipajeVistaPreviaFactura490WC");
                        mensajeCambioPesoEquipaje490WC = mensajeCambioPesoEquipaje490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioPesoEquipaje490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[9]))
                    {
                        string mensajeCambioTitular490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioTitularVistaPreviaFactura490WC");
                        mensajeCambioTitular490WC = mensajeCambioTitular490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioTitular490WC;
                    }
                    string mensajeSubtotal490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("SubtotalVistaPreviaFactura490WC");
                    mensajeSubtotal490WC = mensajeSubtotal490WC.Replace("{boletoModificadoCobrar490WC.Precio490WC}", $"{boletoModificadoCobrar490WC.Precio490WC}");
                    mensajeSubtotal490WC = mensajeSubtotal490WC.Replace("{totalFactura490WC}", $"{totalFactura490WC}");
                    mensajeSubtotal490WC = mensajeSubtotal490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                    TBVISTAPREVIAFACTURA490WC.Text += mensajeSubtotal490WC;
                }
                else
                {
                    string mensajeBeneficioNOAplicado490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("BeneficioNOAplicadoVistaPreviaFactura490WC");
                    mensajeBeneficioNOAplicado490WC = mensajeBeneficioNOAplicado490WC.Replace("{gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1}", $"{gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1}");
                    mensajeBeneficioNOAplicado490WC = mensajeBeneficioNOAplicado490WC.Replace("{clienteCobrar490WC.Nombre490WC}", $"{clienteCobrar490WC.Nombre490WC}");
                    mensajeBeneficioNOAplicado490WC = mensajeBeneficioNOAplicado490WC.Replace("{clienteCobrar490WC.Apellido490WC}", $"{clienteCobrar490WC.Apellido490WC}");
                    mensajeBeneficioNOAplicado490WC = mensajeBeneficioNOAplicado490WC.Replace("{clienteCobrar490WC.DNI490WC}", $"{clienteCobrar490WC.DNI490WC}");
                    mensajeBeneficioNOAplicado490WC = mensajeBeneficioNOAplicado490WC.Replace("{DateTime.Now.ToShortDateString()}", $"{DateTime.Now.ToShortDateString()}");
                    mensajeBeneficioNOAplicado490WC = mensajeBeneficioNOAplicado490WC.Replace("{DateTime.Now.ToShortTimeString()}", $"{DateTime.Now.ToShortTimeString()}");
                    mensajeBeneficioNOAplicado490WC = mensajeBeneficioNOAplicado490WC.Replace("{boletoModificadoCobrar490WC.IDBoleto490WC}", $"{cambios490WC[0].ToString()}");
                    mensajeBeneficioNOAplicado490WC = mensajeBeneficioNOAplicado490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                    TBVISTAPREVIAFACTURA490WC.Text = mensajeBeneficioNOAplicado490WC;
                    if ((!string.IsNullOrEmpty(cambios490WC[1])) || (!string.IsNullOrEmpty(cambios490WC[2])))
                    {
                        string mensajeCambioFecha490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioFechaVistaPreviaFactura490WC");
                        mensajeCambioFecha490WC = mensajeCambioFecha490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioFecha490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[5]))
                    {
                        string mensajeCambioBeneficio490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioBeneficioVistaPreviaFactura490WC");
                        mensajeCambioBeneficio490WC = mensajeCambioBeneficio490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioBeneficio490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[6]))
                    {
                        string mensajeCambioClase490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioClaseVistaPreviaFactura490WC");
                        mensajeCambioClase490WC = mensajeCambioClase490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioClase490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[7]))
                    {
                        string mensajeCambioAsiento490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioAsientoVistaPreviaFactura490WC");
                        mensajeCambioAsiento490WC = mensajeCambioAsiento490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioAsiento490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[8]))
                    {
                        string mensajeCambioPesoEquipaje490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioPesoEquipajeVistaPreviaFactura490WC");
                        mensajeCambioPesoEquipaje490WC = mensajeCambioPesoEquipaje490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioPesoEquipaje490WC;
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[9]))
                    {
                        string mensajeCambioTitular490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioTitularVistaPreviaFactura490WC");
                        mensajeCambioTitular490WC = mensajeCambioTitular490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                        TBVISTAPREVIAFACTURA490WC.Text += mensajeCambioTitular490WC;
                    }
                    string mensajeSubtotal490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("SubtotalVistaPreviaFactura490WC");
                    mensajeSubtotal490WC = mensajeSubtotal490WC.Replace("{boletoModificadoCobrar490WC.Precio490WC}", $"{boletoModificadoCobrar490WC.Precio490WC}");
                    mensajeSubtotal490WC = mensajeSubtotal490WC.Replace("{totalFactura490WC}", $"{totalFactura490WC}");
                    mensajeSubtotal490WC = mensajeSubtotal490WC.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                    TBVISTAPREVIAFACTURA490WC.Text += mensajeSubtotal490WC;
                }
            }
        }

        public void CargarCliente490WC(Cliente490WC clienteBuscado490WC)
        {
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            TBINFOCLIENTE490WC.Clear();
            dgvBoleto490WC.Rows.Clear();
            if (clienteBuscado490WC != null)
            {
                BoletosModificadosPorPagar490WC = gestorBoleto490WC.ObtenerBoletosModificadosPorPagarCliente490WC(clienteBuscado490WC);
                foreach (Boleto490WC boletoCliente490WC in BoletosModificadosPorPagar490WC)
                {
                    if (boletoCliente490WC is BoletoIDA490WC)
                    {
                        dgvBoleto490WC.Rows.Add(boletoCliente490WC.IDBoleto490WC, boletoCliente490WC.Origen490WC, boletoCliente490WC.Destino490WC, boletoCliente490WC.FechaPartida490WC.ToShortDateString(), boletoCliente490WC.FechaLlegada490WC.ToShortDateString(), null, null, boletoCliente490WC.EquipajePermitido490WC, boletoCliente490WC.ClaseBoleto490WC, boletoCliente490WC.Precio490WC, boletoCliente490WC.NumeroAsiento490WC, boletoCliente490WC.BeneficioAplicado490WC);
                    }
                    if (boletoCliente490WC is BoletoIDAVUELTA490WC)
                    {
                        dgvBoleto490WC.Rows.Add(boletoCliente490WC.IDBoleto490WC, boletoCliente490WC.Origen490WC, boletoCliente490WC.Destino490WC, boletoCliente490WC.FechaPartida490WC.ToShortDateString(), boletoCliente490WC.FechaLlegada490WC.ToShortDateString(), (boletoCliente490WC as BoletoIDAVUELTA490WC).FechaPartidaVUELTA490WC.ToShortDateString(), (boletoCliente490WC as BoletoIDAVUELTA490WC).FechaLlegadaVUELTA490WC.ToShortDateString(), boletoCliente490WC.EquipajePermitido490WC, boletoCliente490WC.ClaseBoleto490WC, boletoCliente490WC.Precio490WC, boletoCliente490WC.NumeroAsiento490WC, boletoCliente490WC.BeneficioAplicado490WC);
                    }
                }
                TBINFOCLIENTE490WC.Name = "TBINFOCLIENTEGENERARFACTURA490WC";
            }
            else
            {
                clienteCobrar490WC = null;
                BoletosModificadosPorPagar490WC = null;
                TBINFOCLIENTE490WC.Name = "TBINFOCLIENTEVACIOGENERARFACTURA490WC";
            }
            if (dgvBoleto490WC.Rows.Count > 0)
            {
                BT_COBRARFACTURA490WC.Enabled = true;
            }
            else
            {
                BT_COBRARFACTURA490WC.Enabled = false;
            }
        }
        private void FormCobrarCambios490WC_Load(object sender, EventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            Traductor490WC.TraductorSG490WC.Notificar490WC();
        }

        private void FormCobrarCambios490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Desuscribir490WC(this);
        }

        public void ActualizarLenguaje490WC()
        {
            RecorrerControles490WC(this);

        }

        public void RecorrerControles490WC(Control control490WC)
        {
            foreach (Control c490WC in control490WC.Controls)
            {
                if ((c490WC is TextBox tb490WC) == false)
                {

                    c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);


                    if (c490WC.HasChildren)
                    {
                        RecorrerControles490WC(c490WC);
                    }
                    if (c490WC is DataGridView dgv490WC)
                    {
                        foreach (DataGridViewColumn columna490WC in dgv490WC.Columns)
                        {
                            columna490WC.HeaderText = Traductor490WC.TraductorSG490WC.Traducir490WC(columna490WC.Name);
                        }
                    }

                }
                else if (c490WC.Name == "TBINFOCLIENTEGENERARFACTURA490WC")
                {
                    TBINFOCLIENTE490WC.Text += "DNI: {clienteBuscado490WC.DNI490WC} {Environment.NewLine} Nombre: {clienteBuscado490WC.Nombre490WC} {Environment.NewLine} Apellido: {clienteBuscado490WC.Apellido490WC} {Environment.NewLine}";
                    c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);
                    string a = c490WC.Text;
                    a = a.Replace("{clienteBuscado490WC.DNI490WC} {Environment.NewLine}", $"{clienteCobrar490WC.DNI490WC} {Environment.NewLine}");
                    a = a.Replace("{clienteBuscado490WC.Nombre490WC} {Environment.NewLine}", $"{clienteCobrar490WC.Nombre490WC} {Environment.NewLine}");
                    a = a.Replace("{clienteBuscado490WC.Apellido490WC} {Environment.NewLine}", $"{clienteCobrar490WC.Apellido490WC} {Environment.NewLine}");
                    c490WC.Text = a;
                }
                else if (c490WC.Name == "TBINFOCLIENTEVACIOGENERARFACTURA490WC")
                {
                    c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);
                }

            }
        }

        private void BT_BUSCARCLIENTE490WC_Click(object sender, EventArgs e)
        {
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            boletoModificadoCobrar490WC = null;
            clienteCobrar490WC = gestorCliente490WC.BuscarClientePorDNI490WC(TB_DNI490WC.Text);
            if (clienteCobrar490WC != null)
            {
                if (clienteCobrar490WC.Activo490WC == true)
                {
                    CargarCliente490WC(clienteCobrar490WC);
                    TB_DNI490WC.Clear();
                    CargarInfoFactura490WC();
                }
                else
                {
                    string mensajeDesactivado = Traductor490WC.TraductorSG490WC.Traducir490WC("ClienteDesactivado490WC");
                    MessageBox.Show(mensajeDesactivado);
                    CargarInfoFactura490WC();
                    CargarCliente490WC(null);
                    TB_DNI490WC.Clear();
                }
            }
            else
            {
                string mensajeError490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("ClienteNoEncontrado490WC");
                MessageBox.Show(mensajeError490WC);
                CargarInfoFactura490WC();
                CargarCliente490WC(null);
                TB_DNI490WC.Clear();
            }
            ActualizarLenguaje490WC();
        }

        private void dgvBoleto490WC_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvBoleto490WC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvBoleto490WC.Rows.Count > 0 && clienteCobrar490WC != null && BoletosModificadosPorPagar490WC != null)
            {
                GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
                boletoModificadoCobrar490WC = BoletosModificadosPorPagar490WC.Find(x => x.IDBoleto490WC == dgvBoleto490WC.CurrentRow.Cells[0].Value.ToString());
                CargarInfoFactura490WC();
            }
            else
            {
                boletoModificadoCobrar490WC = null;
                CargarInfoFactura490WC();
            }
        }

        private void BT_COBRARFACTURA490WC_Click(object sender, EventArgs e)
        {
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            GestorPagos490WC gestorPagos490WC = new GestorPagos490WC();
            GestorFactura490WC gestorFactura490WC = new GestorFactura490WC();
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            string datosTarjeta490WC = "";
            if (boletoModificadoCobrar490WC != null)
            {
                if (RB_CREDITO490WC.Checked)
                {
                    datosTarjeta490WC = $"{RB_CREDITO490WC.Text},{TB_NUMEROTARJETA490WC.Text},{TB_NOMBRETITULAR490WC.Text},{TB_APELLIDOTITULAR490WC.Text},{TB_FECHAEMISION490WC.Text},{TB_FECHAVENCIMIENTO490WC.Text},{TB_CODIGOSEGURIDAD490WC.Text}";
                }
                else
                {
                    datosTarjeta490WC = $"{RB_DEBITO490WC.Text},{TB_NUMEROTARJETA490WC.Text},{TB_NOMBRETITULAR490WC.Text},{TB_APELLIDOTITULAR490WC.Text},{TB_FECHAEMISION490WC.Text},{TB_FECHAVENCIMIENTO490WC.Text},{TB_CODIGOSEGURIDAD490WC.Text}";
                }
                if (gestorCliente490WC.VerificarFormatoNumeroTarjeta490WC(TB_NUMEROTARJETA490WC.Text))
                {
                    if (!string.IsNullOrEmpty(TB_NOMBRETITULAR490WC.Text))
                    {
                        if (!string.IsNullOrEmpty(TB_APELLIDOTITULAR490WC.Text))
                        {
                            if (gestorCliente490WC.VerificarFormatoFechaTarjeta490WC(TB_FECHAEMISION490WC.Text))
                            {
                                if (gestorCliente490WC.VerificarFormatoFechaVencimientoTarjeta490WC(TB_FECHAVENCIMIENTO490WC.Text) && gestorCliente490WC.VerificarRangoFechasTarjeta490WC(TB_FECHAEMISION490WC.Text, TB_FECHAVENCIMIENTO490WC.Text))
                                {
                                    if (gestorCliente490WC.VerificarFormatoCVVTarjeta490WC(TB_CODIGOSEGURIDAD490WC.Text))
                                    {
                                        datosTarjeta490WC = Cifrador490WC.GestorCifrador490WC.EncriptarReversible490WC(datosTarjeta490WC);
                                        if (gestorPagos490WC.ValidarPago490WC(datosTarjeta490WC, totalFactura490WC))
                                        {
                                            if (boletoModificadoCobrar490WC.BeneficioAplicado490WC != null)
                                            {
                                                string[] cambios490WC = boletoModificadoCobrar490WC.CambiosRealizados490WC.Split(';');
                                                Factura490WC facturaAlta490WC = new Factura490WC(gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1, clienteCobrar490WC.Nombre490WC, clienteCobrar490WC.Apellido490WC, clienteCobrar490WC.DNI490WC, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), cambios490WC[0], boletoModificadoCobrar490WC.Precio490WC, totalFactura490WC, boletoModificadoCobrar490WC.BeneficioAplicado490WC);
                                                facturaAlta490WC.CambiosRealizados490WC = boletoModificadoCobrar490WC.CambiosRealizados490WC;
                                                gestorFactura490WC.Alta490WC(facturaAlta490WC);
                                                gestorBoleto490WC.CobrarBoletoModificado490WC(boletoModificadoCobrar490WC);
                                                gestorFactura490WC.GenerarFacturaBoletoModificado490WC(facturaAlta490WC);
                                                gestorBoleto490WC.GenerarBoleto490WC(boletoModificadoCobrar490WC);
                                                string mensajePago = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajePago490WC");
                                                MessageBox.Show(mensajePago);
                                                pagoAceptado490WC = true;
                                                this.Close();

                                            }
                                            else
                                            {
                                                string[] cambios490WC = boletoModificadoCobrar490WC.CambiosRealizados490WC.Split(';');
                                                Factura490WC facturaAlta490WC = new Factura490WC(gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1, clienteCobrar490WC.Nombre490WC, clienteCobrar490WC.Apellido490WC, clienteCobrar490WC.DNI490WC, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), cambios490WC[0], boletoModificadoCobrar490WC.Precio490WC, totalFactura490WC);
                                                facturaAlta490WC.CambiosRealizados490WC = boletoModificadoCobrar490WC.CambiosRealizados490WC;
                                                gestorFactura490WC.Alta490WC(facturaAlta490WC);
                                                gestorBoleto490WC.CobrarBoletoModificado490WC(boletoModificadoCobrar490WC);
                                                gestorFactura490WC.GenerarFacturaBoletoModificado490WC(facturaAlta490WC);
                                                gestorBoleto490WC.GenerarBoleto490WC(boletoModificadoCobrar490WC);
                                                string mensajePago = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajePago490WC");
                                                MessageBox.Show(mensajePago);
                                                pagoAceptado490WC = true;
                                                this.Close();
                                            }
                                        }
                                        else
                                        {
                                            string mensajePagoRechazado = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajePagoRechazado490WC");
                                            MessageBox.Show(mensajePagoRechazado);
                                        }
                                    }
                                    else
                                    {
                                        string mensajeCodigoSeguridadInvalido = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajeCodigoSeguridadInvalido490WC");
                                        MessageBox.Show(mensajeCodigoSeguridadInvalido);
                                    }
                                }
                                else
                                {
                                    string mensajeFechaVencimientoInvalida = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajeFechaVencimientoInvalida490WC");
                                    MessageBox.Show(mensajeFechaVencimientoInvalida);
                                }
                            }
                            else
                            {
                                string mensajeFechaEmisionInvalida = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajeFechaEmisionInvalida490WC");
                                MessageBox.Show(mensajeFechaEmisionInvalida);
                            }
                        }
                        else
                        {
                            string mensajeApellidoTitularInvalido = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajeApellidoTitularInvalido490WC");
                            MessageBox.Show(mensajeApellidoTitularInvalido);
                        }
                    }
                    else
                    {
                        string mensajeNombreTitularInvalido = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajeNombreTitularInvalido490WC");
                        MessageBox.Show(mensajeNombreTitularInvalido);
                    }
                }
                else
                {
                    string mensajeNumeroTarjetaInvalido = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajeNumeroTarjetaInvalido490WC");
                    MessageBox.Show(mensajeNumeroTarjetaInvalido);
                }

            }
            else
            {
                string mensajeError490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("ElegirBoletoCobrar490WC");
                MessageBox.Show(mensajeError490WC);
            }
        }

        private void BT_CAMBIARTITULAR_Click(object sender, EventArgs e)
        {
            if (boletoModificadoCobrar490WC != null)
            {
                string[] cambios490WC = boletoModificadoCobrar490WC.CambiosRealizados490WC.Split(';');
                if (cambios490WC[9] == null || cambios490WC[9] == "")
                {
                    formCambiarTitular490WC = new FormCambiarTitular490WC(boletoModificadoCobrar490WC);
                    formCambiarTitular490WC.ShowDialog();
                    boletoModificadoCobrar490WC = null;
                    clienteCobrar490WC = null;
                    CargarCliente490WC(null);
                    CargarInfoFactura490WC();
                }
                else
                {
                    string errorCambioTitular490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorCambioTitularYaEfectuado490WC");
                    MessageBox.Show(errorCambioTitular490WC);
                }
            }
            else
            {
                string mensajeError490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("ElegirBoletoCambiarTitular490WC");
                MessageBox.Show(mensajeError490WC);
            }
        }
    }
}
