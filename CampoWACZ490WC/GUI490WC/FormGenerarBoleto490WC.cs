using BE490WC;
using BLL490WC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI490WC
{
    public partial class FormGenerarBoleto490WC : Form
    {
        private ControlModalidadIDA490WC controlIDA490WC;
        private ControlModalidadVUELTA490WC controlVUELTA490WC;
        private FormAplicarBeneficios490WC formAplicarBeneficios490WC;
        private Cliente490WC ClienteCargado490WC;
        private Boleto490WC boletoCargado490WC;
        public FormGenerarBoleto490WC()
        {
            InitializeComponent();
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            gestorBoleto490WC.LiberarBoletosVencidos490WC();
            InicializarControles490WC();
            HabilitarControl490WC();
            CargarCliente490WC(null);
            formAplicarBeneficios490WC = new FormAplicarBeneficios490WC();
            controlIDA490WC.Mostrar490WC();
            controlVUELTA490WC.Mostrar490WC();
        }

        private void InicializarControles490WC()
        {
            controlIDA490WC = new ControlModalidadIDA490WC()
            {
                Location = new Point(12, 56),
                Visible = false
            };

            controlVUELTA490WC = new ControlModalidadVUELTA490WC()
            {
                Location = new Point(12, 56),
                Visible = false
            };

            this.Controls.Add(controlIDA490WC);
            this.Controls.Add(controlVUELTA490WC);

            HabilitarBeneficio490WC();

            controlIDA490WC.NotificarSeleccion490WC = () =>
            {
                if (controlIDA490WC.Visible)
                {
                    boletoCargado490WC = controlIDA490WC.boleto490WCSeleccionado490WC;
                    if (boletoCargado490WC != null)
                    {
                        LlenarInfoBoleto490WC();
                    }
                }
            };

            controlVUELTA490WC.NotificarSeleccion490WC = () =>
            {
                if (controlVUELTA490WC.Visible)
                {
                    boletoCargado490WC = controlVUELTA490WC.boleto490WCSeleccionado490WC;
                    if (boletoCargado490WC != null)
                    {
                        LlenarInfoBoleto490WC();
                    }
                }
            };
        }
        public void LlenarInfoBoleto490WC()
        {
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            TBINFOBOLETOGENERAR490WC.Clear();
            if (boletoCargado490WC != null)
            {
                boletoCargado490WC = gestorBoleto490WC.ObtenerBoletoConBeneficio490WC(boletoCargado490WC.IDBoleto490WC);
                if (ClienteCargado490WC != null)
                {
                    TBINFOBOLETOGENERAR490WC.Text += $"DNI Cliente: {ClienteCargado490WC.DNI490WC} {Environment.NewLine}";
                    TBINFOBOLETOGENERAR490WC.Text += $"Nombre: {ClienteCargado490WC.Nombre490WC} Apellido: {ClienteCargado490WC.Apellido490WC} {Environment.NewLine}";
                    TBINFOBOLETOGENERAR490WC.Text += $"ID Boleto: {boletoCargado490WC.IDBoleto490WC} {Environment.NewLine}";
                    if (boletoCargado490WC.BeneficioAplicado490WC == "")
                    {
                        TBINFOBOLETOGENERAR490WC.Text += $"Beneficio Aplicado: Ninguno";
                    }
                    else
                    {
                        TBINFOBOLETOGENERAR490WC.Text += $"Beneficio Aplicado: {boletoCargado490WC.BeneficioAplicado490WC}";
                    }
                }
                else
                {
                    TBINFOBOLETOGENERAR490WC.Text += $"No se encuentra cargado ningun cliente {Environment.NewLine}";
                    TBINFOBOLETOGENERAR490WC.Text += $"ID Boleto: {boletoCargado490WC.IDBoleto490WC} {Environment.NewLine}";
                    if (boletoCargado490WC.BeneficioAplicado490WC == "")
                    {
                        TBINFOBOLETOGENERAR490WC.Text += $"Beneficio Aplicado: Ninguno";
                    }
                    else
                    {
                        TBINFOBOLETOGENERAR490WC.Text += $"Beneficio Aplicado: {boletoCargado490WC.BeneficioAplicado490WC}";
                    }
                }
            }
        }
        public void HabilitarBeneficio490WC()
        {
            if (ClienteCargado490WC == null)
            {
                CB_BENEFICIOSCLIENTE490WC.Enabled = false;
                BT_APLICARBENEFICIO490WC.Enabled = false;
                BT_CANJEARBENEFICIO490WC.Enabled = false;
            }
            else
            {
                CB_BENEFICIOSCLIENTE490WC.Enabled = true;
                BT_APLICARBENEFICIO490WC.Enabled = true;
                BT_CANJEARBENEFICIO490WC.Enabled = true;
            }
        }
        public void LimpiarCampos490WC()
        {
            TBINFOBOLETOGENERAR490WC.Clear();
            TBINFOCLIENTE490WC.Clear();
            TB_DNI490WC.Clear();
            CB_BENEFICIOSCLIENTE490WC.Items.Clear();
            HabilitarBeneficio490WC();
        }
        public void HabilitarControl490WC()
        {
            if (RB_IDA490WC.Checked)
            {
                controlIDA490WC.Visible = true;
                controlVUELTA490WC.Visible = false;
            }
            else
            {
                controlIDA490WC.Visible = false;
                controlVUELTA490WC.Visible = true;
            }
        }


        private void RB_IDA490WC_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarControl490WC();
            controlIDA490WC.Mostrar490WC();
            controlIDA490WC.LimpiarCampos490WC();
            controlVUELTA490WC.Mostrar490WC();
            controlVUELTA490WC.LimpiarCampos490WC();
        }

        public void CargarCliente490WC(Cliente490WC clienteBuscado490WC)
        {
            TBINFOCLIENTE490WC.Clear();
            if (clienteBuscado490WC != null)
            {
                TBINFOCLIENTE490WC.Text += $"DNI: {clienteBuscado490WC.DNI490WC} {Environment.NewLine}";
                TBINFOCLIENTE490WC.Text += $"Nombre: {clienteBuscado490WC.Nombre490WC} {Environment.NewLine}";
                TBINFOCLIENTE490WC.Text += $"Apellido: {clienteBuscado490WC.Apellido490WC} {Environment.NewLine}";
                TBINFOCLIENTE490WC.Text += $"Estrellas del Cliente: {clienteBuscado490WC.EstrellasCliente490WC} {Environment.NewLine}";
            }
            else
            {
                TBINFOCLIENTE490WC.Text = $"Ingrese el DNI, Nombre y Apellido para visualizar los datos del cliente";
            }
        }

        private void BT_BUSCARCLIENTE490WC_Click(object sender, EventArgs e)
        {
            LlenarDatosCliente490WC(TB_DNI490WC.Text);
        }
        public void LlenarDatosCliente490WC(string DNICliente490WC)
        {
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            ClienteCargado490WC = gestorCliente490WC.BuscarClientePorDNI490WC(DNICliente490WC);
            if (ClienteCargado490WC != null)
            {
                if (ClienteCargado490WC.Activo490WC == true)
                {

                CargarCliente490WC(ClienteCargado490WC);
                if (ClienteCargado490WC.BeneficiosCliente490WC.Count > 0)
                {
                    foreach (Beneficio490WC bene490WC in ClienteCargado490WC.BeneficiosCliente490WC)
                    {
                        CB_BENEFICIOSCLIENTE490WC.Items.Add(bene490WC.Nombre490WC);
                    }
                }
                TB_DNI490WC.Clear();
                HabilitarBeneficio490WC();
                LlenarInfoBoleto490WC();
                }
                else
                {
                    MessageBox.Show("El cliente buscado se encuentra desactivado!!!");
                    ClienteCargado490WC = null;
                    CargarCliente490WC(null);
                    CB_BENEFICIOSCLIENTE490WC.Items.Clear();
                    TB_DNI490WC.Clear();
                    HabilitarBeneficio490WC();
                    LlenarInfoBoleto490WC();
                }
            }
            else
            {
                MessageBox.Show("Cliente no encontrado. Por favor, verifique el DNI.");
                ClienteCargado490WC = null;
                CargarCliente490WC(null);
                CB_BENEFICIOSCLIENTE490WC.Items.Clear();
                TB_DNI490WC.Clear();
                HabilitarBeneficio490WC();
                LlenarInfoBoleto490WC();
            }
        }

        private void BT_CANJEARBENEFICIO490WC_Click(object sender, EventArgs e)
        {
            formAplicarBeneficios490WC.ShowDialog();
            ClienteCargado490WC = formAplicarBeneficios490WC.ClienteCargado490WC;
            if (ClienteCargado490WC != null)
            {
                LlenarDatosCliente490WC(ClienteCargado490WC.DNI490WC);
            }
            else
            {
                LlenarDatosCliente490WC("");
            }
        }

        private void BT_APLICARBENEFICIO490WC_Click(object sender, EventArgs e)
        {
            GestorBeneficio490WC gestorBeneficio490WC = new GestorBeneficio490WC();
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            if (boletoCargado490WC == null)
            {
                MessageBox.Show("Debe seleccionar un boleto para aplicar un beneficio.");
            }
            else 
            {
            if (CB_BENEFICIOSCLIENTE490WC.SelectedItem != null)
            {
                Beneficio490WC beneficioAplicar490WC = ClienteCargado490WC.BeneficiosCliente490WC.Find(x => x.Nombre490WC == CB_BENEFICIOSCLIENTE490WC.SelectedItem.ToString());
                if (beneficioAplicar490WC != null)
                {
                    gestorBeneficio490WC.AplicarBeneficio490WC(boletoCargado490WC.IDBoleto490WC, beneficioAplicar490WC.DescuentoAplicar490WC, beneficioAplicar490WC.Nombre490WC);
                    boletoCargado490WC = gestorBoleto490WC.ObtenerBoletoConBeneficio490WC(boletoCargado490WC.IDBoleto490WC);
                    gestorBeneficio490WC.EliminarBeneficioDeCliente490WC(ClienteCargado490WC.DNI490WC, beneficioAplicar490WC.CodigoBeneficio490WC);
                    ClienteCargado490WC = gestorCliente490WC.BuscarClientePorDNI490WC(ClienteCargado490WC.DNI490WC);
                    LlenarDatosCliente490WC(ClienteCargado490WC.DNI490WC);
                        BT_CANCELAR490WC.Enabled = false;
                    controlIDA490WC.Enabled = false;
                    controlVUELTA490WC.Enabled = false;
                    RB_IDA490WC.Enabled = false;
                    RB_IDAVUELTA490WC.Enabled = false;
                }
                else
                {
                    MessageBox.Show("El beneficio seleccionado no pertenece al cliente");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un beneficio para aplicar.");
            }

            }
        }

        private void BT_GENERARBOLETO490WC_Click(object sender, EventArgs e)
        {
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            if (boletoCargado490WC == null)
            {
                MessageBox.Show("Debe seleccionar un boleto para generar.");
                return;
            }
            else
            {
                if (ClienteCargado490WC != null)
                {
                    gestorBoleto490WC.AsignarBoletoCliente490WC(boletoCargado490WC, ClienteCargado490WC);
                    MessageBox.Show("El boleto fue generado Correctamente!!, tiene 8 horas para realizar el pago");
                    LimpiarCampos490WC();
                    BT_CANCELAR490WC.Enabled = true;
                    controlIDA490WC.Enabled = true;
                    controlVUELTA490WC.Enabled = true;
                    RB_IDA490WC.Enabled = true;
                    RB_IDAVUELTA490WC.Enabled = true;
                    this.Close();
                }
                else
                {
                    gestorBoleto490WC.GenerarBoletoCompra490WC(boletoCargado490WC);
                    MessageBox.Show($"El boleto fue generado Correctamente!!, tiene 8 horas para realizar el pago. {Environment.NewLine} Indique al Cajero el siguiente codigo: {boletoCargado490WC.IDBoleto490WC} para que se le asigne el boleto generado cuando sea registrado");
                    LimpiarCampos490WC();
                    BT_CANCELAR490WC.Enabled = true;
                    controlIDA490WC.Enabled = true;
                    controlVUELTA490WC.Enabled = true;
                    RB_IDA490WC.Enabled = true;
                    RB_IDAVUELTA490WC.Enabled = true;
                    this.Close();
                }

            }
        }

        private void BT_CANCELAR490WC_Click(object sender, EventArgs e)
        {
            LimpiarCampos490WC();
            this.Close();
        }

        private void FormGenerarBoleto490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (RB_IDA490WC.Checked)
            {
                RB_IDAVUELTA490WC.Checked = true;
            }
            else
            {
                RB_IDA490WC.Checked = true;
            }
            boletoCargado490WC = null;
            ClienteCargado490WC = null;
            LimpiarCampos490WC();
            this.Close();
        }
    }
}
