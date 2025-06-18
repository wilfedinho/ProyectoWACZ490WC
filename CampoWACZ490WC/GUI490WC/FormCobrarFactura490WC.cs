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
    public partial class FormCobrarFactura490WC : Form
    {
        Cliente490WC clienteCargado490WC;
        Boleto490WC boletoCargado490WC;
        float totalFactura490WC;
        public FormCobrarFactura490WC(Cliente490WC clienteCobrar490WC, Boleto490WC BoletoCobrar490WC)
        {
            InitializeComponent();
            clienteCargado490WC = clienteCobrar490WC;
            boletoCargado490WC = BoletoCobrar490WC;
            HabilitarCobros490WC();
            CargarDatosPreviosFactura490WC();
        }

        public void CargarDatosPreviosFactura490WC()
        {
            GestorFactura490WC gestorFactura490WC = new GestorFactura490WC();
            TBVISTAPREVIAFACTURA490WC.Clear();
            TBVISTAPREVIAFACTURA490WC.Text += $"Numero Factura: {gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1} {Environment.NewLine}";
            TBVISTAPREVIAFACTURA490WC.Text += $"Nombre: {clienteCargado490WC.Nombre490WC} {Environment.NewLine}";
            TBVISTAPREVIAFACTURA490WC.Text += $"Apellido:  {clienteCargado490WC.Apellido490WC} {Environment.NewLine}";
            if (boletoCargado490WC.BeneficioAplicado490WC != null)
            {
                TBVISTAPREVIAFACTURA490WC.Text += $"Beneficio Aplicado: {boletoCargado490WC.BeneficioAplicado490WC} {Environment.NewLine}";
            }
            else
            {
                TBVISTAPREVIAFACTURA490WC.Text += $"Beneficio Aplicado: No se aplico ningun beneficio {Environment.NewLine}";
            }
            TBVISTAPREVIAFACTURA490WC.Text += $"DNI: {clienteCargado490WC.DNI490WC} {Environment.NewLine}";
            TBVISTAPREVIAFACTURA490WC.Text += $"Fecha Emision: {DateTime.Now.ToShortDateString()} {Environment.NewLine}";
            TBVISTAPREVIAFACTURA490WC.Text += $"Hora Emision: {DateTime.Now.ToShortTimeString()} {Environment.NewLine}";
            TBVISTAPREVIAFACTURA490WC.Text += $"Numero Boleto: {boletoCargado490WC.IDBoleto490WC} {Environment.NewLine}";
            TBVISTAPREVIAFACTURA490WC.Text += $"Subtotal: {boletoCargado490WC.Precio490WC} {Environment.NewLine}";
            totalFactura490WC = boletoCargado490WC.Precio490WC * 1.60f;
            TBVISTAPREVIAFACTURA490WC.Text += $"Total: {totalFactura490WC} {Environment.NewLine}";
        }
        public void HabilitarCobros490WC()
        {
            if (!checkBoxOTROMETODOPAGO490WC.Checked)
            {
                LABEL_TIPOTARJETA490WC.Enabled = false;
                RB_CREDITO490WC.Enabled = false;
                RB_DEBITO490WC.Enabled = false;
                TB_NUMEROTARJETA490WC.Enabled = false;
                TB_FECHAEMISION490WC.Enabled = false;
                TB_FECHAVENCIMIENTO490WC.Enabled = false;
                TB_CODIGOSEGURIDAD490WC.Enabled = false;
                TB_NOMBRETITULAR490WC.Enabled = false;
                TB_APELLIDOTITULAR490WC.Enabled = false;
            }
            else
            {
                LABEL_TIPOTARJETA490WC.Enabled = true;
                RB_CREDITO490WC.Enabled = true;
                RB_DEBITO490WC.Enabled = true;
                TB_NUMEROTARJETA490WC.Enabled = true;
                TB_FECHAEMISION490WC.Enabled = true;
                TB_FECHAVENCIMIENTO490WC.Enabled = true;
                TB_CODIGOSEGURIDAD490WC.Enabled = true;
                TB_NOMBRETITULAR490WC.Enabled = true;
                TB_APELLIDOTITULAR490WC.Enabled = true;
            }

        }

        private void checkBoxOTROMETODOPAGO490WC_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarCobros490WC();
        }

        private void BT_REALIZARPAGO490WC_Click(object sender, EventArgs e)
        {
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            GestorPagos490WC gestorPagos490WC = new GestorPagos490WC();
            GestorFactura490WC gestorFactura490WC = new GestorFactura490WC();
            if (!checkBoxOTROMETODOPAGO490WC.Checked)
            {
                if (gestorPagos490WC.ValidarPago490WC(clienteCargado490WC.DatosTarjeta490WC, totalFactura490WC))
                {
                  Factura490WC facturaAlta490WC = new Factura490WC(gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1, clienteCargado490WC.Nombre490WC, clienteCargado490WC.Apellido490WC, clienteCargado490WC.DNI490WC, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), boletoCargado490WC.IDBoleto490WC, boletoCargado490WC.Precio490WC, totalFactura490WC);
                  gestorFactura490WC.Alta490WC(facturaAlta490WC);
                    MessageBox.Show("Pago realizado con exito!!");
                }
                else
                {
                    MessageBox.Show("El pago no fue aceptado por la entidad bancaria, intente nuevamente!!");
                }
            }
            else
            {
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
                                            Factura490WC facturaAlta490WC = new Factura490WC(gestorFactura490WC.ObtenerTodasLasFacturas490WC().Count + 1,clienteCargado490WC.Nombre490WC,clienteCargado490WC.Apellido490WC,clienteCargado490WC.DNI490WC, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), boletoCargado490WC.IDBoleto490WC,boletoCargado490WC.Precio490WC,totalFactura490WC);
                                            gestorFactura490WC.Alta490WC(facturaAlta490WC); 
                                            MessageBox.Show("Pago realizado con exito!!");

                                        }
                                        else
                                        {
                                            MessageBox.Show("El pago no fue aceptado por la entidad bancaria, intente nuevamente!!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ingrese un codigo de seguridad valido!!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese una fecha de vencimiento valida!!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese una fecha de emision valida!!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un apellido de titular valido!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un nombre de titular valido!!");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un numero de tarjeta valido!!");
                }
            }
        }





    }
}
