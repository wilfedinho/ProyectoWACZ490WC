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
    }
}
