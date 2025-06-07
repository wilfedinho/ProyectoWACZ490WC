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
            Mostrar();
        }
        public void Mostrar()
        {
            GestorBeneficio490WC gestorBeneficio490WC = new GestorBeneficio490WC();
            dgvBeneficio490WC.RowTemplate.Height = 100;
            dgvBeneficio490WC.Columns["ColumnImagenEstrella"].Width = 110;
            foreach (Beneficio490WC beneficioMostrar490WC in gestorBeneficio490WC.ObtenerTodosLosBeneficios490WC())
            {
                dgvBeneficio490WC.Rows.Add(beneficioMostrar490WC.CodigoBeneficio490WC, beneficioMostrar490WC.Nombre490WC, $"{beneficioMostrar490WC.PrecioEstrella490WC}",null , beneficioMostrar490WC.CantidadBeneficioReclamo490WC, beneficioMostrar490WC.DescuentoAplicar490WC);
            }
        }
    }
}
