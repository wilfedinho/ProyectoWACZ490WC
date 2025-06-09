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
            dgvBeneficio490WC.RowTemplate.Height = 80;
            dgvBeneficio490WC.Columns["ColumnImagenEstrella"].Width = 90;
           
            foreach (Beneficio490WC beneficioMostrar490WC in gestorBeneficio490WC.ObtenerTodosLosBeneficios490WC())
            {
                dgvBeneficio490WC.Rows.Add(beneficioMostrar490WC.CodigoBeneficio490WC, beneficioMostrar490WC.Nombre490WC, beneficioMostrar490WC.CantidadBeneficioReclamo490WC, $"{beneficioMostrar490WC.PrecioEstrella490WC}",null, beneficioMostrar490WC.DescuentoAplicar490WC);
            }
            
            LISTBOXINFOCLIENTE490WC.Items.Add("Nombre: William");
            LISTBOXINFOCLIENTE490WC.Items.Add("");
            LISTBOXINFOCLIENTE490WC.Items.Add("Apellido: Cardenas");
            LISTBOXINFOCLIENTE490WC.Items.Add("");
            LISTBOXINFOCLIENTE490WC.Items.Add("DNI: 96.117.490");
           
            
            LISTBOXBENEFICIOSDELCLIENTE490WC.Items.Add($"1. 10%");
            LISTBOXINFOCLIENTE490WC.Items.Add("");
            LISTBOXBENEFICIOSDELCLIENTE490WC.Items.Add($"2. 40%");
        }
    }
}
