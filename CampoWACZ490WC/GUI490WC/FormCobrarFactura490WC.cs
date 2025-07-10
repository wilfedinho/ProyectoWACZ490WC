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
    public partial class FormCobrarFactura490WC : Form, iObserverLenguaje490WC
    {
        Cliente490WC clienteCargado490WC;
        Boleto490WC boletoCargado490WC;
        float totalFactura490WC;
        public bool pagoAceptado490WC = false;
        public FormCobrarFactura490WC(Cliente490WC clienteCobrar490WC, Boleto490WC BoletoCobrar490WC)
        {
            InitializeComponent();
            clienteCargado490WC = clienteCobrar490WC;
            boletoCargado490WC = BoletoCobrar490WC;
            CargarDatosPreviosFactura490WC();
            Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            ActualizarLenguaje490WC();
        }

        public void CargarDatosPreviosFactura490WC()
        {
            GestorFactura490WC gestorFactura490WC = new GestorFactura490WC();
            TBVISTAPREVIAFACTURA490WC.Clear();
            //TBVISTAPREVIAFACTURA490WC.Text += $"Numero Factura: {gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1} {Environment.NewLine}";
            //TBVISTAPREVIAFACTURA490WC.Text += $"Nombre: {clienteCargado490WC.Nombre490WC} {Environment.NewLine}";
            //TBVISTAPREVIAFACTURA490WC.Text += $"Apellido:  {clienteCargado490WC.Apellido490WC} {Environment.NewLine}";
            if (boletoCargado490WC.BeneficioAplicado490WC != null)
            {
                //TBVISTAPREVIAFACTURA490WC.Text += $"Beneficio Aplicado: {boletoCargado490WC.BeneficioAplicado490WC} {Environment.NewLine}";
                TBVISTAPREVIAFACTURA490WC.Name = "TBVISTAPREVIAFACTURA490WC";
            }
            else
            {
                //TBVISTAPREVIAFACTURA490WC.Text += $"Beneficio Aplicado: No se aplico ningun beneficio {Environment.NewLine}";
                TBVISTAPREVIAFACTURA490WC.Name = "TBVISTAPREVIAFACTURASINBENEFICIO490WC";
            }
            //TBVISTAPREVIAFACTURA490WC.Text += $"DNI: {clienteCargado490WC.DNI490WC} {Environment.NewLine}";
            //TBVISTAPREVIAFACTURA490WC.Text += $"Fecha Emision: {DateTime.Now.ToShortDateString()} {Environment.NewLine}";
            //TBVISTAPREVIAFACTURA490WC.Text += $"Hora Emision: {DateTime.Now.ToShortTimeString()} {Environment.NewLine}";
            //TBVISTAPREVIAFACTURA490WC.Text += $"Numero Boleto: {boletoCargado490WC.IDBoleto490WC} {Environment.NewLine}";
            //TBVISTAPREVIAFACTURA490WC.Text += $"Subtotal: {boletoCargado490WC.Precio490WC} {Environment.NewLine}";
            //totalFactura490WC = boletoCargado490WC.Precio490WC * 1.60f;
            //TBVISTAPREVIAFACTURA490WC.Text += $"Total: {totalFactura490WC} {Environment.NewLine}";

        }




        private void BT_REALIZARPAGO490WC_Click(object sender, EventArgs e)
        {
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            GestorPagos490WC gestorPagos490WC = new GestorPagos490WC();
            GestorFactura490WC gestorFactura490WC = new GestorFactura490WC();
            string datosTarjeta490WC = "";
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
                            if (gestorCliente490WC.VerificarFormatoFechaTarjeta490WC(TB_FECHAVENCIMIENTO490WC.Text))
                            {
                                if (gestorCliente490WC.VerificarFormatoCVVTarjeta490WC(TB_CODIGOSEGURIDAD490WC.Text))
                                {
                                    datosTarjeta490WC = Cifrador490WC.GestorCifrador490WC.EncriptarReversible490WC(datosTarjeta490WC);
                                    if (gestorPagos490WC.ValidarPago490WC(datosTarjeta490WC, totalFactura490WC))
                                    {
                                        Factura490WC facturaAlta490WC = new Factura490WC(gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1, clienteCargado490WC.Nombre490WC, clienteCargado490WC.Apellido490WC, clienteCargado490WC.DNI490WC, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), boletoCargado490WC.IDBoleto490WC, boletoCargado490WC.Precio490WC, totalFactura490WC);
                                        gestorFactura490WC.Alta490WC(facturaAlta490WC);
                                        string mensajePago = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajePago490WC");
                                        MessageBox.Show(mensajePago);
                                        pagoAceptado490WC = true;
                                        this.Close();
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

        private void FormCobrarFactura490WC_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        public void ActualizarLenguaje490WC()
        {
            RecorrerControles490WC(this);
            //Personalizar para Traducir el TextBox de vista previa factura
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
                else if (c490WC.Name == "TBVISTAPREVIAFACTURA490WC")
                {
                    GestorFactura490WC gestorFactura490WC = new GestorFactura490WC();
                    totalFactura490WC = boletoCargado490WC.Precio490WC * 1.60f;
                    TBVISTAPREVIAFACTURA490WC.Text += "Numero Factura: {gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1} {Environment.NewLine} Nombre: {clienteCargado490WC.Nombre490WC} {Environment.NewLine} Apellido:  {clienteCargado490WC.Apellido490WC} {Environment.NewLine} Beneficio Aplicado: {boletoCargado490WC.BeneficioAplicado490WC} {Environment.NewLine} DNI: {clienteCargado490WC.DNI490WC} {Environment.NewLine} Fecha Emision: {DateTime.Now.ToShortDateString()} {Environment.NewLine} Hora Emision: {DateTime.Now.ToShortTimeString()} {Environment.NewLine} Numero Boleto: {boletoCargado490WC.IDBoleto490WC} {Environment.NewLine} Subtotal: {boletoCargado490WC.Precio490WC} {Environment.NewLine} Total: {totalFactura490WC} {Environment.NewLine}";
                    c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);
                    string a = c490WC.Text;
                    a = a.Replace("{gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1} {Environment.NewLine}", $"{gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1} {Environment.NewLine}");
                    a = a.Replace("{clienteCargado490WC.Nombre490WC} {Environment.NewLine}", $"{clienteCargado490WC.Nombre490WC} {Environment.NewLine}");
                    a = a.Replace("{clienteCargado490WC.Apellido490WC} {Environment.NewLine}", $"{clienteCargado490WC.Apellido490WC} {Environment.NewLine}");
                    a = a.Replace("{boletoCargado490WC.BeneficioAplicado490WC} {Environment.NewLine}", $"{boletoCargado490WC.BeneficioAplicado490WC} {Environment.NewLine}");
                    a = a.Replace("{clienteCargado490WC.DNI490WC} {Environment.NewLine}", $"{clienteCargado490WC.DNI490WC} {Environment.NewLine}");
                    a = a.Replace("{DateTime.Now.ToShortDateString()} {Environment.NewLine}", $"{DateTime.Now.ToShortDateString()} {Environment.NewLine}");
                    a = a.Replace("{DateTime.Now.ToShortTimeString()} {Environment.NewLine}", $"{DateTime.Now.ToShortTimeString()} {Environment.NewLine}");
                    a = a.Replace("{boletoCargado490WC.IDBoleto490WC} {Environment.NewLine}", $"{boletoCargado490WC.IDBoleto490WC} {Environment.NewLine}");
                    a = a.Replace("{boletoCargado490WC.Precio490WC} {Environment.NewLine}", $"{boletoCargado490WC.Precio490WC} {Environment.NewLine}");
                    a = a.Replace("{totalFactura490WC} {Environment.NewLine}", $"{totalFactura490WC} {Environment.NewLine}");
                    c490WC.Text = a;
                }
                else if (c490WC.Name == "TBVISTAPREVIAFACTURASINBENEFICIO490WC")
                {
                    totalFactura490WC = boletoCargado490WC.Precio490WC * 1.60f;
                    GestorFactura490WC gestorFactura490WC = new GestorFactura490WC();
                    TBVISTAPREVIAFACTURA490WC.Text += $"Numero Factura: {gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1} {Environment.NewLine} Nombre: {clienteCargado490WC.Nombre490WC} {Environment.NewLine} Apellido:  {clienteCargado490WC.Apellido490WC} {Environment.NewLine} Beneficio Aplicado: No se aplico ningun beneficio {Environment.NewLine} DNI: {clienteCargado490WC.DNI490WC} {Environment.NewLine} Fecha Emision: {DateTime.Now.ToShortDateString()} {Environment.NewLine} Hora Emision: {DateTime.Now.ToShortTimeString()} {Environment.NewLine} Numero Boleto: {boletoCargado490WC.IDBoleto490WC} {Environment.NewLine} Subtotal: {boletoCargado490WC.Precio490WC} {Environment.NewLine} Total: {totalFactura490WC} {Environment.NewLine}";
                    
                    c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);
                    string a = c490WC.Text;
                    a = a.Replace("{gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1} {Environment.NewLine}", $"{gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1} {Environment.NewLine}");
                    a = a.Replace("{clienteCargado490WC.Nombre490WC} {Environment.NewLine}", $"{clienteCargado490WC.Nombre490WC} {Environment.NewLine}");
                    a = a.Replace("{clienteCargado490WC.Apellido490WC} {Environment.NewLine}", $"{clienteCargado490WC.Apellido490WC} {Environment.NewLine}");
                    a = a.Replace("{Environment.NewLine}", $"{Environment.NewLine}");
                    a = a.Replace("{clienteCargado490WC.DNI490WC} {Environment.NewLine}", $"{clienteCargado490WC.DNI490WC} {Environment.NewLine}");
                    a = a.Replace("{DateTime.Now.ToShortDateString()} {Environment.NewLine}", $"{DateTime.Now.ToShortDateString()} {Environment.NewLine}");
                    a = a.Replace("{DateTime.Now.ToShortTimeString()} {Environment.NewLine}", $"{DateTime.Now.ToShortTimeString()} {Environment.NewLine}");
                    a = a.Replace("{boletoCargado490WC.IDBoleto490WC} {Environment.NewLine}", $"{boletoCargado490WC.IDBoleto490WC} {Environment.NewLine}");
                    a = a.Replace("{boletoCargado490WC.Precio490WC} {Environment.NewLine}", $"{boletoCargado490WC.Precio490WC} {Environment.NewLine}");
                    a = a.Replace("{totalFactura490WC} {Environment.NewLine}", $"{totalFactura490WC} {Environment.NewLine}");
                    c490WC.Text = a;
                }
            }
        }
    }
}
