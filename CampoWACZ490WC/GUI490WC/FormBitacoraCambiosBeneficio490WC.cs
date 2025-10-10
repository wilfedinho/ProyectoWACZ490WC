using BLLS490WC;
using SE490WC;
using SERVICIOS490WC;
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
    public partial class FormBitacoraCambiosBeneficio490WC : Form
    {
        List<BitacoraCambioSE490WC> ListaBitacora490WC;
        List<BitacoraCambioSE490WC> ListaBitacoraSINFiltros;
        BitacoraCambios490WC GestorBitacora490WC;
        public FormBitacoraCambiosBeneficio490WC()
        {
            InitializeComponent();
            GestorBitacora490WC = new BitacoraCambios490WC();
            ListaBitacora490WC = new List<BitacoraCambioSE490WC>();
            ListaBitacoraSINFiltros = GestorBitacora490WC.ObtenerEventosSINFiltro();
            Mostrar490WC();
            LLenarCB490WC();
            monthCalendarFechaInicio490WC.Enabled = false;
            monthCalendarFechaFin490WC.Enabled = false;
        }

        public void LimpiarCB490WC()
        {
            CB_CodigoBeneficio490WC.SelectedIndex = -1;
            CB_NombreBeneficio490WC.SelectedIndex = -1;
            monthCalendarFechaInicio490WC.SelectionStart = DateTime.Today;
            monthCalendarFechaFin490WC.SelectionStart = DateTime.Today;
        }

        public void LLenarCB490WC()
        {
            CB_CodigoBeneficio490WC.Items.Clear();
            CB_NombreBeneficio490WC.Items.Clear();

            foreach (BitacoraCambioSE490WC bitacora490WC in ListaBitacoraSINFiltros)
            {

                if (CB_CodigoBeneficio490WC.Items.Count == 0 || !CB_CodigoBeneficio490WC.Items.Contains(bitacora490WC.CodigoBeneficio490WC))
                    CB_CodigoBeneficio490WC.Items.Add(bitacora490WC.CodigoBeneficio490WC);

                if (CB_NombreBeneficio490WC.Items.Count == 0 || !CB_NombreBeneficio490WC.Items.Contains(bitacora490WC.Nombre490WC))
                    CB_NombreBeneficio490WC.Items.Add(bitacora490WC.Nombre490WC);
            }
        }

        public void Mostrar490WC(int CodigoBeneficioFiltrar490WC = 0, string nombreBeneficioFiltrar490WC = "", DateTime? fechaInicioFiltrar490WC = null, DateTime? fechaFinFiltrar490WC = null)
        {
            int indiceRow490WC = 0;
            dgvBeneficio490WC.Rows.Clear();
            ListaBitacora490WC = GestorBitacora490WC.ObtenerEventosPorConsulta490WC(CodigoBeneficioFiltrar490WC, nombreBeneficioFiltrar490WC, fechaInicioFiltrar490WC, fechaFinFiltrar490WC);
            foreach (BitacoraCambioSE490WC bitacora490WC in ListaBitacora490WC)
            {
                indiceRow490WC = dgvBeneficio490WC.Rows.Add(bitacora490WC.NumeroCambioRealizado490WC, bitacora490WC.CodigoBeneficio490WC, bitacora490WC.Fecha490WC.ToShortDateString(), bitacora490WC.Hora490WC, bitacora490WC.Nombre490WC, bitacora490WC.CantidadBeneficioReclamado490WC, bitacora490WC.DescuentoAplicar490WC, bitacora490WC.PrecioEstrella490WC, bitacora490WC.Activo490WC);

                if (dgvBeneficio490WC.Rows.Count > 0)
                {
                    switch (bitacora490WC.Activo490WC)
                    {
                        case true:
                            dgvBeneficio490WC.Rows[indiceRow490WC].DefaultCellStyle.BackColor = Color.GreenYellow;
                            break;

                    }
                }
            }
        }

        private void BT_Filtrar490WC_Click(object sender, EventArgs e)
        {
            int codigoBeneficioFiltrar490WC = 0;
            string nombreFiltrar490WC = "";

            if (CB_CodigoBeneficio490WC.SelectedIndex >= 0)
                codigoBeneficioFiltrar490WC = int.Parse(CB_CodigoBeneficio490WC.SelectedItem.ToString());
            if (CB_NombreBeneficio490WC.SelectedIndex >= 0)
                nombreFiltrar490WC = CB_NombreBeneficio490WC.SelectedItem.ToString();


            if (checkBoxFecha490WC.Checked == false)
            {
                Mostrar490WC(codigoBeneficioFiltrar490WC, nombreFiltrar490WC);
            }
            else
            {

                DateTime fechaInicioFiltrar490WC = monthCalendarFechaInicio490WC.SelectionStart;
                DateTime fechaFinFiltrar490WC = monthCalendarFechaFin490WC.SelectionStart;
                if (fechaInicioFiltrar490WC <= fechaFinFiltrar490WC)
                {
                    Mostrar490WC(codigoBeneficioFiltrar490WC, nombreFiltrar490WC, fechaInicioFiltrar490WC, fechaFinFiltrar490WC);
                }
                else
                {
                    string errorMensaje490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorFechaBitacora");
                    MessageBox.Show(errorMensaje490WC);
                }
            }
            LimpiarCB490WC();
            LLenarCB490WC();
        }

        private void BT_LimpiarFiltros490WC_Click(object sender, EventArgs e)
        {
            LimpiarCB490WC();
            Mostrar490WC();
            LLenarCB490WC();
        }

        private void BT_Activar490WC_Click(object sender, EventArgs e)
        {
            bool IsActivo490WC = bool.Parse(dgvBeneficio490WC.SelectedRows[0].Cells["ColumnaActivo"].Value.ToString());
            if (!IsActivo490WC)
            {
                int numeroCambioRestaurar490WC = int.Parse(dgvBeneficio490WC.SelectedRows[0].Cells["ColumaNumeroCambio"].Value.ToString());
                GestorBitacora490WC.RestaurarVersionBeneficio490WC(numeroCambioRestaurar490WC);
                LimpiarCB490WC();
                Mostrar490WC();
                LLenarCB490WC();
            }
            else
            {
                MessageBox.Show("No Puedes Activar Un Registra Que Ya Esta Activo!!!");
            }
        }

        private void checkBoxFecha490WC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFecha490WC.Checked == true)
            {
                monthCalendarFechaInicio490WC.Enabled = true;
                monthCalendarFechaFin490WC.Enabled = true;
            }
            else
            {
                monthCalendarFechaInicio490WC.Enabled = false;
                monthCalendarFechaFin490WC.Enabled = false;
            }
        }
    }
}
