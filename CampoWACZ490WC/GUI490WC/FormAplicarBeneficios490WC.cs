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
        public FormAplicarBeneficios490WC()
        {
            InitializeComponent();
            Mostrar490WC();
            CargarCliente490WC();
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
                dgvBeneficio490WC.Rows.Add(beneficioMostrar490WC.CodigoBeneficio490WC, beneficioMostrar490WC.Nombre490WC, beneficioMostrar490WC.CantidadBeneficioReclamo490WC, $"{beneficioMostrar490WC.PrecioEstrella490WC}",null, beneficioMostrar490WC.DescuentoAplicar490WC);
            }

            TBINFOCLIENTE490WC.Text = $"Busque un Cliente Para Visualizar Sus Datos";
            TBBENEFICIOCLIENTE490WC.Text = $"Busque un Cliente Para Ver Si posee Beneficios";
            TBBENEFICIOCLIENTE490WC.Text += $"{Environment.NewLine} 1. 10%";
            TBBENEFICIOCLIENTE490WC.Text += $"{Environment.NewLine} 2. 30%";
        }

        public void CargarCliente490WC()
        {
            TBINFOCLIENTE490WC.Clear();
            TBBENEFICIOCLIENTE490WC.Clear();
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            GestorBeneficio490WC gestorBeneficio490WC = new GestorBeneficio490WC();
            Cliente490WC ClienteCargado490WC = gestorCliente490WC.BuscarClientePorDNI490WC(TB_DNI490WC.Text);
            if (ClienteCargado490WC != null)
            {
                if (ClienteCargado490WC.Nombre490WC == TB_NOMBRE490WC.Text && ClienteCargado490WC.Apellido490WC == TB_APELLIDO490WC.Text)
                {
                    TBINFOCLIENTE490WC.Text += $"DNI: {ClienteCargado490WC.DNI490WC} {Environment.NewLine}";
                    TBINFOCLIENTE490WC.Text += $"Nombre: {ClienteCargado490WC.Nombre490WC} {Environment.NewLine}";
                    TBINFOCLIENTE490WC.Text += $"Apellido: {ClienteCargado490WC.Apellido490WC} {Environment.NewLine}";
                    TBINFOCLIENTE490WC.Text += $"Estrellas del Cliente: {ClienteCargado490WC.EstrellasCliente490WC} {Environment.NewLine}";
                    int contadorBeneficio490WC = 1;
                    foreach (Beneficio490WC bene490WC in gestorBeneficio490WC.ObtenerBeneficiosPorCliente490WC(ClienteCargado490WC.DNI490WC))
                    {
                        TBBENEFICIOCLIENTE490WC.Text += $"{contadorBeneficio490WC}. {bene490WC.Nombre490WC} {Environment.NewLine}";
                        contadorBeneficio490WC++;
                    }
                }
            }
            else
            {
                TBINFOCLIENTE490WC.Text = $"Ingrese el DNI, Nombre y Apellido para visualizar los datos del cliente";
                TBBENEFICIOCLIENTE490WC.Text = $"Ingrese el DNI, Nombre y Apellido para visualizar los beneficios del cliente";
            }
        }

        private void BT_BUSCARCLIENTE490WC_Click(object sender, EventArgs e)
        {
            CargarCliente490WC();
            LimpiarCampos490WC();
        }
    }
}
