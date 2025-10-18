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
    public partial class FormReportesInteligentes490WC : Form
    {
        public FormReportesInteligentes490WC()
        {
            InitializeComponent();
        }

        private void BT_Reporte1_490WC_Click(object sender, EventArgs e)
        {
            FormReporteBeneficioMayorCanje490WC formReporteBeneficioMayorCanje490WC = new FormReporteBeneficioMayorCanje490WC();
            formReporteBeneficioMayorCanje490WC.ShowDialog();
        }

        private void BT_Reporte3_490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_Reporte5_490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_Reporte2_490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_Reporte4_490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_Reporte6_490WC_Click(object sender, EventArgs e)
        {

        }
    }
}
