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
    public partial class FormMaestroBoleto490WC : Form
    {
        public FormMaestroBoleto490WC()
        {
            InitializeComponent();
            Mostrar490WC();
            LimpiarCampos490WC();
        }

        public void Mostrar490WC()
        {
            dgvBoleto490WC.Rows.Clear();
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            foreach(Boleto490WC bole490WC in gestorBoleto490WC.ObtenerTodosLosBoletos490WC())
            {
                if (bole490WC is BoletoIDA490WC boletoIDA490WC)
                {
                   dgvBoleto490WC.Rows.Add(boletoIDA490WC.IDBoleto490WC, "IDA",boletoIDA490WC.Origen490WC, boletoIDA490WC.Destino490WC, boletoIDA490WC.FechaPartida490WC, boletoIDA490WC.FechaLlegada490WC, null, null, boletoIDA490WC.ClaseBoleto490WC, boletoIDA490WC.EquipajePermitido490WC, boletoIDA490WC.Precio490WC);
                }

                if (bole490WC is BoletoIDAVUELTA490WC boletoIDAVUELTA490WC)
                {
                    dgvBoleto490WC.Rows.Add(boletoIDAVUELTA490WC.IDBoleto490WC, "IDA & VUELTA",boletoIDAVUELTA490WC.Origen490WC, boletoIDAVUELTA490WC.Destino490WC, boletoIDAVUELTA490WC.FechaPartida490WC, boletoIDAVUELTA490WC.FechaLlegada490WC, boletoIDAVUELTA490WC.FechaPartidaVUELTA490WC, boletoIDAVUELTA490WC.FechaLlegadaVUELTA490WC, boletoIDAVUELTA490WC.ClaseBoleto490WC, boletoIDAVUELTA490WC.EquipajePermitido490WC, boletoIDAVUELTA490WC.Precio490WC);
                }
            }
        }

        public void LimpiarCampos490WC()
        {
            foreach (Control cl in this.Controls)
            {
                if (cl is TextBox tb)
                {
                    tb.Clear();
                }
            }
            CB_CLASEBOLETO490WC.SelectedIndex = -1;
        }


        private void BT_ALTA490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_BAJA490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_MODIFICAR490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_APLICAR490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_CANCELAR490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_SALIR490WC_Click(object sender, EventArgs e)
        {

        }
    }
}
