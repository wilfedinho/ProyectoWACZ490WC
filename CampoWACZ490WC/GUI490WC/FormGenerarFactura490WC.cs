using BE490WC;
using BLL490WC;
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
    public partial class FormGenerarFactura490WC : Form
    {
        FormRegistrarCliente490WC formRegistrarCliente490WC;
        Cliente490WC clienteCobrar490WC;
        Boleto490WC boletoCobrar490WC;
        public FormGenerarFactura490WC()
        {
            InitializeComponent();
            CargarCliente490WC(null);
            BT_COBRARFACTURA490WC.Enabled = false;
        }
        public void CargarCliente490WC(Cliente490WC clienteBuscado490WC)
        {
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            TBINFOCLIENTE490WC.Clear();
            dgvBoleto490WC.Rows.Clear();
            if (clienteBuscado490WC != null)
            {
                TBINFOCLIENTE490WC.Text += $"DNI: {clienteBuscado490WC.DNI490WC} {Environment.NewLine}";
                TBINFOCLIENTE490WC.Text += $"Nombre: {clienteBuscado490WC.Nombre490WC} {Environment.NewLine}";
                TBINFOCLIENTE490WC.Text += $"Apellido: {clienteBuscado490WC.Apellido490WC} {Environment.NewLine}";
                foreach (Boleto490WC boletoCliente490WC in gestorBoleto490WC.ObtenerBoletosPorCliente490WC(clienteBuscado490WC))
                {
                    if (boletoCliente490WC.IsVendido490WC == false)
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
                }
            }
            else
            {
                clienteCobrar490WC = null;
                TBINFOCLIENTE490WC.Text = $"Ingrese el DNI, Nombre y Apellido para visualizar los datos del cliente";
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

        private void BT_BUSCARCLIENTE490WC_Click(object sender, EventArgs e)
        {
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            clienteCobrar490WC = gestorCliente490WC.BuscarClientePorDNI490WC(TB_DNI490WC.Text);
            if (clienteCobrar490WC != null)
            {
                if (clienteCobrar490WC.Activo490WC == true)
                {
                    CargarCliente490WC(clienteCobrar490WC);
                    TB_DNI490WC.Clear();
                    
                }
                else
                {
                    MessageBox.Show("El cliente buscado se encuentra desactivado!!!");
                    TBINFOCLIENTE490WC.Text = $"Cliente no encontrado. Verifique el DNI ingresado.";
                    CargarCliente490WC(null);
                    TB_DNI490WC.Clear();
                }
            }
            else
            {
                MessageBox.Show("Cliente No Encontrado, Pase A registrarlo");
                TBINFOCLIENTE490WC.Text = $"Cliente no encontrado. Verifique el DNI ingresado.";
                formRegistrarCliente490WC = new FormRegistrarCliente490WC();
                formRegistrarCliente490WC.ShowDialog();
                CargarCliente490WC(null);
                TB_DNI490WC.Clear();
            }
        }



        private void BT_COBRARFACTURA490WC_Click(object sender, EventArgs e)
        {
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            if (clienteCobrar490WC != null)
            {
                foreach (Boleto490WC bole490WC in gestorBoleto490WC.ObtenerBoletosPorCliente490WC(clienteCobrar490WC))
                {
                    if (bole490WC.IDBoleto490WC == dgvBoleto490WC.SelectedRows[0].Cells["ColumnaID"].Value.ToString())
                    {
                        boletoCobrar490WC = bole490WC;

                    }
                }
                if (boletoCobrar490WC != null)
                {
                    FormCobrarFactura490WC formCobrarFactura490WC = new FormCobrarFactura490WC(clienteCobrar490WC, boletoCobrar490WC);
                    formCobrarFactura490WC.ShowDialog();
                    if (formCobrarFactura490WC.pagoAceptado490WC)
                    {
                        gestorBoleto490WC.CobrarBoleto490WC(boletoCobrar490WC);
                        MessageBox.Show("Factura Generada");
                        CargarCliente490WC(null);
                        boletoCobrar490WC = null;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo generar la factura");
                        CargarCliente490WC(null);
                        boletoCobrar490WC = null;
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un boleto para cobrar la factura.");
                    CargarCliente490WC(null);
                    boletoCobrar490WC = null;
                }

            }
            else
            {
                MessageBox.Show("Debe buscar un cliente para cobrar la factura");
                CargarCliente490WC(null);
                boletoCobrar490WC = null;
            }

        }

        private void FormGenerarFactura490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarCliente490WC(null);
            boletoCobrar490WC = null;
            BT_COBRARFACTURA490WC.Enabled = false;
        }
    }
}
