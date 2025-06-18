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
    public partial class FormAplicarBeneficios490WC : Form
    {
        public Cliente490WC ClienteCargado490WC;
        public FormAplicarBeneficios490WC()
        {
            InitializeComponent();
            Mostrar490WC();
            CargarCliente490WC(null);
        }
        public void LimpiarCampos490WC()
        {
            TB_NOMBRE490WC.Clear();
            TB_APELLIDO490WC.Clear();
            TB_DNI490WC.Clear();
        }
        public void Mostrar490WC()
        {
            GestorBeneficio490WC gestorBeneficio490WC = new GestorBeneficio490WC();
            dgvBeneficio490WC.RowTemplate.Height = 80;
            dgvBeneficio490WC.Columns["ColumnImagenEstrella"].Width = 90;

            foreach (Beneficio490WC beneficioMostrar490WC in gestorBeneficio490WC.ObtenerTodosLosBeneficios490WC())
            {
                dgvBeneficio490WC.Rows.Add(beneficioMostrar490WC.CodigoBeneficio490WC, beneficioMostrar490WC.Nombre490WC, beneficioMostrar490WC.CantidadBeneficioReclamo490WC, $"{beneficioMostrar490WC.PrecioEstrella490WC}", null, beneficioMostrar490WC.DescuentoAplicar490WC);
            }
            HabilitarCanjeBeneficio490WC();
        }

        public void HabilitarCanjeBeneficio490WC()
        {
            if (ClienteCargado490WC != null && dgvBeneficio490WC.SelectedRows.Count > 0)
            {
                BT_CANJEARBENEFICIO490WC.Enabled = true;
            }
            else
            {
                BT_CANJEARBENEFICIO490WC.Enabled = false;
            }
        }

        public void CargarCliente490WC(Cliente490WC clienteBuscado490WC)
        {
            TBINFOCLIENTE490WC.Clear();
            TBBENEFICIOCLIENTE490WC.Clear();
            GestorBeneficio490WC gestorBeneficio490WC = new GestorBeneficio490WC();
            if (clienteBuscado490WC != null)
            {
                TBINFOCLIENTE490WC.Text += $"DNI: {clienteBuscado490WC.DNI490WC} {Environment.NewLine}";
                TBINFOCLIENTE490WC.Text += $"Nombre: {clienteBuscado490WC.Nombre490WC} {Environment.NewLine}";
                TBINFOCLIENTE490WC.Text += $"Apellido: {clienteBuscado490WC.Apellido490WC} {Environment.NewLine}";
                TBINFOCLIENTE490WC.Text += $"Estrellas del Cliente: {clienteBuscado490WC.EstrellasCliente490WC} {Environment.NewLine}";
                int contadorBeneficio490WC = 1;
                if (clienteBuscado490WC.BeneficiosCliente490WC.Count > 0)
                {
                    foreach (Beneficio490WC bene490WC in clienteBuscado490WC.BeneficiosCliente490WC)
                    {
                        TBBENEFICIOCLIENTE490WC.Text += $"{contadorBeneficio490WC}. {bene490WC.Nombre490WC} {Environment.NewLine}";
                        contadorBeneficio490WC++;
                    }
                }
                else
                {
                    TBBENEFICIOCLIENTE490WC.Text = "El cliente no tiene beneficios aplicados.";
                }
            }
            else
            {
                TBINFOCLIENTE490WC.Text = $"Ingrese el DNI, Nombre y Apellido para visualizar los datos del cliente";
                TBBENEFICIOCLIENTE490WC.Text = $"Ingrese el DNI, Nombre y Apellido para visualizar los beneficios del cliente";
            }
            HabilitarCanjeBeneficio490WC();
        }

        private void BT_BUSCARCLIENTE490WC_Click(object sender, EventArgs e)
        {
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            Cliente490WC clienteCargar490WC = gestorCliente490WC.BuscarClientePorDNI490WC(TB_DNI490WC.Text);
            if (clienteCargar490WC != null)
            {
                if (clienteCargar490WC.Nombre490WC == TB_NOMBRE490WC.Text && clienteCargar490WC.Apellido490WC == TB_APELLIDO490WC.Text)
                {
                    ClienteCargado490WC = clienteCargar490WC;
                    CargarCliente490WC(clienteCargar490WC);
                    LimpiarCampos490WC();
                }
                else
                {
                    MessageBox.Show("Los datos del cliente no coinciden. Por favor, verifique el DNI, Nombre y Apellido.");
                    LimpiarCampos490WC();
                    ClienteCargado490WC = null;
                    CargarCliente490WC(null);
                }
            }
            else
            {
                MessageBox.Show("Cliente no encontrado. Por favor, verifique el DNI.");
                LimpiarCampos490WC();
                ClienteCargado490WC = null;
                CargarCliente490WC(null);
            }
        }

        private void BT_CANJEARBENEFICIO490WC_Click(object sender, EventArgs e)
        {

            GestorBeneficio490WC gestorBeneficio490WC = new GestorBeneficio490WC();
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            Beneficio490WC beneficioAplicar490WC = gestorBeneficio490WC.ObtenerBeneficioPorCodigo490WC(Convert.ToInt32(dgvBeneficio490WC.SelectedRows[0].Cells["ColumnaCodigoBeneficio490WC"].Value.ToString()));
            if (ClienteCargado490WC.EstrellasCliente490WC >= beneficioAplicar490WC.PrecioEstrella490WC)
            {
                if (ClienteCargado490WC.BeneficiosCliente490WC.Find(x => x.CodigoBeneficio490WC == beneficioAplicar490WC.CodigoBeneficio490WC) == null)
                {
                    gestorCliente490WC.ModificarEstrellasCliente490WC(ClienteCargado490WC.DNI490WC, beneficioAplicar490WC.PrecioEstrella490WC);
                    beneficioAplicar490WC.CantidadBeneficioReclamo490WC += 1;
                    gestorBeneficio490WC.Modificacion490WC(beneficioAplicar490WC);
                    gestorBeneficio490WC.AgregarBeneficioACliente490WC(ClienteCargado490WC.DNI490WC, beneficioAplicar490WC.CodigoBeneficio490WC);
                    ClienteCargado490WC = gestorCliente490WC.BuscarClientePorDNI490WC(ClienteCargado490WC.DNI490WC);
                    CargarCliente490WC(ClienteCargado490WC);
                    Mostrar490WC();
                }
                else
                {
                    MessageBox.Show("El cliente ya tiene este beneficio.");
                }
            }
            else
            {
                MessageBox.Show("El cliente no tiene suficientes estrellas para canjear este beneficio.", "Error");
            }
        }

        private void BT_CANCELAR490WC_Click(object sender, EventArgs e)
        {
            ClienteCargado490WC = null;
            CargarCliente490WC(null);
        }
    }
}
