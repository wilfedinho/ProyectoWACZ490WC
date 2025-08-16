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
    public partial class FormBitacoraDeEventos490WC : Form, iObserverLenguaje490WC
    {
        Bitacora490WC GestorBitacora490WC;
        UserManager490WC GestorUsuario490WC;
        List<Usuario490WC> ListaUsuario490WC;
        public FormBitacoraDeEventos490WC()
        {
            InitializeComponent();
            GestorBitacora490WC = new Bitacora490WC();
            GestorUsuario490WC = new UserManager490WC();
            ListaUsuario490WC = GestorUsuario490WC.DevolverTodosLosUsuarios490WC();
            Mostrar490WC();
            LLenarCB490WC();
            monthCalendarFechaInicio.Enabled = false;
            monthCalendarFechaFin.Enabled = false;
            labelUsuario.Text = $"Usuario: ";
            labelNombre.Text = $"Nombre: ";
            labelApellido.Text = $"Apellido: ";
            labelDNI.Text = $"DNI: ";
        }
        public void Mostrar490WC(string usuarioFiltrar490WC = "", string moduloFiltrar490WC = "", string descripcionFiltrar490WC = "", string criticidadFiltrar490WC = "", DateTime? fechaInicioFiltrar490WC = null, DateTime? fechaFinFiltrar490WC = null)
        {
            int indiceRow490WC = 0;
            int criticidad490WC = 0;
            dgvBitacora.Rows.Clear();
            foreach (BitacoraSE490WC bitacora490WC in GestorBitacora490WC.ObtenerBitacoraPorConsulta490WC(usuarioFiltrar490WC, moduloFiltrar490WC, descripcionFiltrar490WC, criticidadFiltrar490WC, fechaInicioFiltrar490WC, fechaFinFiltrar490WC))
            {
                indiceRow490WC = dgvBitacora.Rows.Add(bitacora490WC.Username490WC, bitacora490WC.Fecha490WC.ToShortDateString(), bitacora490WC.Hora490WC, bitacora490WC.Modulo490WC, bitacora490WC.Descripcion490WC, bitacora490WC.Criticidad490WC);
                criticidad490WC = bitacora490WC.Criticidad490WC;
                if (dgvBitacora.Rows.Count > 0)
                {
                    switch (criticidad490WC)
                    {
                        case 1:
                            dgvBitacora.Rows[indiceRow490WC].DefaultCellStyle.BackColor = Color.GreenYellow;
                            break;
                        case 2:
                            dgvBitacora.Rows[indiceRow490WC].DefaultCellStyle.BackColor = Color.Coral;
                            break;
                        case 3:
                            dgvBitacora.Rows[indiceRow490WC].DefaultCellStyle.BackColor = Color.Orange;
                            break;
                        case 4:
                            dgvBitacora.Rows[indiceRow490WC].DefaultCellStyle.BackColor = Color.OrangeRed;
                            break;
                        case 5:
                            dgvBitacora.Rows[indiceRow490WC].DefaultCellStyle.BackColor = Color.Firebrick;
                            break;
                    }
                }
            }
        }
        public void LLenarCB490WC()
        {
            foreach (BitacoraSE490WC bitacora490WC in GestorBitacora490WC.ObtenerBitacoraPorConsulta490WC())
            {

                if (CB_Usuario.Items.Count == 0 || !CB_Usuario.Items.Contains(bitacora490WC.Username490WC))
                    CB_Usuario.Items.Add(bitacora490WC.Username490WC);

                if (CB_Modulo.Items.Count == 0 || !CB_Modulo.Items.Contains(bitacora490WC.Modulo490WC))
                    CB_Modulo.Items.Add(bitacora490WC.Modulo490WC);

                if (CB_Descripcion.Items.Count == 0 || !CB_Descripcion.Items.Contains(bitacora490WC.Descripcion490WC))
                    CB_Descripcion.Items.Add(bitacora490WC.Descripcion490WC);

                if (CB_Criticidad.Items.Count == 0 || !CB_Criticidad.Items.Contains(bitacora490WC.Criticidad490WC.ToString()))
                    CB_Criticidad.Items.Add(bitacora490WC.Criticidad490WC.ToString());
            }
        }

        public void LimpiarCB490WC()
        {
            CB_Usuario.SelectedIndex = -1;
            CB_Modulo.SelectedIndex = -1;
            CB_Descripcion.SelectedIndex = -1;
            CB_Criticidad.SelectedIndex = -1;
            monthCalendarFechaInicio.SelectionStart = DateTime.Today;
            monthCalendarFechaFin.SelectionStart = DateTime.Today;
        }
        private void BT_Filtrar_Click(object sender, EventArgs e)
        {
            string usuarioFiltrar490WC = "";
            string moduloFiltrar490WC = "";
            string descripcionFiltrar490WC = "";
            string criticidadFiltrar490WC = "";


            if (CB_Usuario.SelectedIndex >= 0)
                usuarioFiltrar490WC = CB_Usuario.SelectedItem.ToString();
            if (CB_Modulo.SelectedIndex >= 0)
                moduloFiltrar490WC = CB_Modulo.SelectedItem.ToString();
            if (CB_Descripcion.SelectedIndex >= 0)
                descripcionFiltrar490WC = CB_Descripcion.SelectedItem.ToString();
            if (CB_Criticidad.SelectedIndex >= 0)
                criticidadFiltrar490WC = CB_Criticidad.SelectedItem.ToString();


            if (checkBoxFecha.Checked == false)
            {
                Mostrar490WC(usuarioFiltrar490WC, moduloFiltrar490WC, descripcionFiltrar490WC, criticidadFiltrar490WC);
            }
            else
            {
                
                DateTime fechaInicioFiltrar490WC = monthCalendarFechaInicio.SelectionStart;
                DateTime fechaFinFiltrar490WC = monthCalendarFechaFin.SelectionStart;
                if (fechaInicioFiltrar490WC <= fechaFinFiltrar490WC)
                {
                    Mostrar490WC(usuarioFiltrar490WC, moduloFiltrar490WC, descripcionFiltrar490WC, criticidadFiltrar490WC, fechaInicioFiltrar490WC, fechaFinFiltrar490WC);
                }
                else
                {
                    MessageBox.Show("La fecha de inicio debe ser anterior a la fecha de fin.");
                }
            }
            LimpiarCB490WC();
        }


        private void dgvBitacora_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Usuario490WC usuario490WC = ListaUsuario490WC.Find(x => x.Username490WC == dgvBitacora.SelectedRows[0].Cells[0].Value.ToString());
            if (usuario490WC != null)
            {
                labelUsuario.Text = $"Usuario: {usuario490WC.Username490WC}";
                labelNombre.Text = $"Nombre: {usuario490WC.Nombre490WC}";
                labelApellido.Text = $"Apellido: {usuario490WC.Apellido490WC}";
                labelDNI.Text = $"DNI: {usuario490WC.DNI490WC}";
            }
            else
            {
                labelUsuario.Text = $"Usuario: Error";
                labelNombre.Text = $"Nombre: Error";
                labelApellido.Text = $"Apellido: Error";
                labelDNI.Text = $"DNI: Error";
            }
        }

        private void BT_LimpiarFiltros_Click(object sender, EventArgs e)
        {
            LimpiarCB490WC();
            Mostrar490WC();
            labelUsuario.Text = $"Usuario: ";
            labelNombre.Text = $"Nombre: ";
            labelApellido.Text = $"Apellido: ";
            labelDNI.Text = $"DNI: ";
        }

        private void checkBoxFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFecha.Checked == true)
            {
                monthCalendarFechaInicio.Enabled = true;
                monthCalendarFechaFin.Enabled = true;
            }
            else
            {
                monthCalendarFechaInicio.Enabled = false;
                monthCalendarFechaFin.Enabled = false;
            }
        }

        private void FormBitacoraDeEventos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormBitacoraDeEventos_Load(object sender, EventArgs e)
        {

        }

        private void labelCBUsuario_Click(object sender, EventArgs e)
        {

        }

        public void ActualizarLenguaje490WC()
        {

        }

        private void CB_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
