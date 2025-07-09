using BE490WC;
using BLL490WC;
using SERVICIOS490WC;
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
    public partial class ControlModalidadIDA490WC : UserControl, iObserverLenguaje490WC
    {
        public Boleto490WC boleto490WCSeleccionado490WC = null;
        public Action NotificarSeleccion490WC { get; set; }
        public ControlModalidadIDA490WC()
        {
            InitializeComponent();
            calendarioFECHAPARTIDA_IDA490WC.Enabled = false;
            calendarioFECHALLEGADA_IDA490WC.Enabled = false;
            LLenarCB490WC();
            Mostrar490WC();
        }

        public void Mostrar490WC(string origen490WC = "", string destino490WC = "", string claseBoleto490WC = "", float? precioDesde490WC = null, float? precioHasta490WC = null, float? pesoPermitido490WC = null, DateTime? fechaPartida490WC = null, DateTime? fechaLlegada490WC = null, DateTime? fechaPartidaVUELTA490WC = null, DateTime? fechaLlegadaVUELTA490WC = null)
        {
            dgvBoleto490WC.Rows.Clear();
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            foreach (Boleto490WC bole490WC in gestorBoleto490WC.ObtenerBoletosFiltrados490WC(origen490WC, destino490WC, claseBoleto490WC, precioDesde490WC, precioHasta490WC, pesoPermitido490WC, fechaPartida490WC, fechaLlegada490WC))
            {
                if (bole490WC is BoletoIDA490WC && bole490WC.Titular490WC == null)
                {
                    dgvBoleto490WC.Rows.Add(bole490WC.IDBoleto490WC, "IDA", bole490WC.Origen490WC, bole490WC.Destino490WC, bole490WC.FechaPartida490WC.ToShortDateString(), bole490WC.FechaLlegada490WC.ToShortDateString(), bole490WC.ClaseBoleto490WC, bole490WC.EquipajePermitido490WC, bole490WC.Precio490WC, bole490WC.NumeroAsiento490WC);
                }
            }
        }

        public void LLenarCB490WC()
        {
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            CB_ORIGEN490WC.Items.Clear();
            CB_DESTINO490WC.Items.Clear();
            CB_CLASEBOLETO490WC.Items.Clear();
            foreach (Boleto490WC boleto490WC in gestorBoleto490WC.ObtenerTodosLosBoletos490WC())
            {
                if (boleto490WC is BoletoIDA490WC)
                {
                    if (CB_ORIGEN490WC.Items.Count == 0 || !CB_ORIGEN490WC.Items.Contains(boleto490WC.Origen490WC))
                        CB_ORIGEN490WC.Items.Add(boleto490WC.Origen490WC);

                    if (CB_DESTINO490WC.Items.Count == 0 || !CB_DESTINO490WC.Items.Contains(boleto490WC.Destino490WC))
                        CB_DESTINO490WC.Items.Add(boleto490WC.Destino490WC);

                    if (CB_CLASEBOLETO490WC.Items.Count == 0 || !CB_CLASEBOLETO490WC.Items.Contains(boleto490WC.ClaseBoleto490WC))
                        CB_CLASEBOLETO490WC.Items.Add(boleto490WC.ClaseBoleto490WC);
                }
            }
        }
        public void LimpiarCampos490WC()
        {
            TB_PESO490WC.Clear();
            TB_PRECIODESDE490WC.Clear();
            TB_PRECIOHASTA490WC.Clear();
            CB_ORIGEN490WC.SelectedIndex = -1;
            CB_DESTINO490WC.SelectedIndex = -1;
            CB_CLASEBOLETO490WC.SelectedIndex = -1;
            calendarioFECHAPARTIDA_IDA490WC.SelectionStart = DateTime.Now;
            calendarioFECHALLEGADA_IDA490WC.SelectionStart = DateTime.Now;
        }

        private void checkBoxINCLUIRFECHA490WC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxINCLUIRFECHA490WC.Checked)
            {
                calendarioFECHAPARTIDA_IDA490WC.Enabled = true;
                calendarioFECHALLEGADA_IDA490WC.Enabled = true;
            }
            else
            {
                calendarioFECHAPARTIDA_IDA490WC.Enabled = false;
                calendarioFECHALLEGADA_IDA490WC.Enabled = false;
            }
        }

        private void BT_FILTRAR490WC_Click(object sender, EventArgs e)
        {
            string Origen490WC = "";
            string Destino490WC = "";
            string ClaseBoleto490WC = "";
            float? PrecioDesde490WC = null;
            float? PrecioHasta490WC = null;
            float? PesoPermitido490WC = null;
            DateTime? FechaPartida490WC = null;
            DateTime? FechaLlegada490WC = null;

            if (CB_ORIGEN490WC.SelectedIndex >= 0)
                Origen490WC = CB_ORIGEN490WC.SelectedItem.ToString();
            if (CB_DESTINO490WC.SelectedIndex >= 0)
                Destino490WC = CB_DESTINO490WC.SelectedItem.ToString();
            if (CB_CLASEBOLETO490WC.SelectedIndex >= 0)
                ClaseBoleto490WC = CB_CLASEBOLETO490WC.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(TB_PRECIODESDE490WC.Text))
            {
                if (float.TryParse(TB_PRECIODESDE490WC.Text, out float precioDesde490WC))
                {
                    PrecioDesde490WC = precioDesde490WC;
                }
                else
                {
                    MessageBox.Show("Ingrese un valor numérico válido para el precio desde.");
                }
            }

            if (!string.IsNullOrEmpty(TB_PRECIOHASTA490WC.Text))
            {
                if (float.TryParse(TB_PRECIOHASTA490WC.Text, out float precioHasta490WC))
                {
                    PrecioHasta490WC = precioHasta490WC;
                }
                else
                {
                    MessageBox.Show("Ingrese un valor numérico válido para el precio hasta.");
                }
            }

            if (!string.IsNullOrEmpty(TB_PESO490WC.Text))
            {
                if (float.TryParse(TB_PESO490WC.Text, out float pesoPermitido490WC))
                {
                    PesoPermitido490WC = pesoPermitido490WC;
                }
                else
                {
                    MessageBox.Show("Ingrese un valor numérico válido para el peso permitido.");
                }
            }
            if (checkBoxINCLUIRFECHA490WC.Checked == false)
            {
                Mostrar490WC(Origen490WC, Destino490WC, ClaseBoleto490WC, PrecioDesde490WC, PrecioHasta490WC, PesoPermitido490WC);
            }
            else
            {
                FechaPartida490WC = calendarioFECHAPARTIDA_IDA490WC.SelectionStart;
                FechaLlegada490WC = calendarioFECHALLEGADA_IDA490WC.SelectionStart;
                if (FechaPartida490WC <= FechaLlegada490WC)
                {
                    Mostrar490WC(Origen490WC, Destino490WC, ClaseBoleto490WC, PrecioDesde490WC, PrecioHasta490WC, PesoPermitido490WC, FechaPartida490WC, FechaLlegada490WC);
                }
                else
                {
                    MessageBox.Show("La fecha de partida no puede ser posterior a la fecha de llegada.");
                }
            }
            LimpiarCampos490WC();
        }

        private void BT_LIMPIARFILTROS490WC_Click(object sender, EventArgs e)
        {
            Mostrar490WC();
            LimpiarCampos490WC();
        }

        private void dgvBoleto490WC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            boleto490WCSeleccionado490WC = gestorBoleto490WC.ObtenerBoletoPorID490WC(dgvBoleto490WC.SelectedRows[0].Cells["ColumnaID"].Value.ToString());
            NotificarSeleccion490WC?.Invoke();
        }

        public void ActualizarLenguaje490WC()
        {
           
        }
    }
}
