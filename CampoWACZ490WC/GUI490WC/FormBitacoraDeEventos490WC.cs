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
        List<BitacoraSE490WC> ListaBitacora490WC;
        public FormBitacoraDeEventos490WC()
        {
            InitializeComponent();
            //Traductor490WC.TraductorSG490WC.Notificar490WC();
            GestorBitacora490WC = new Bitacora490WC();
            GestorUsuario490WC = new UserManager490WC();
            //ListaUsuario490WC = GestorUsuario490WC.DevolverTodosLosUsuarios490WC();
            ListaBitacora490WC = new List<BitacoraSE490WC>();
            Mostrar490WC();
            LLenarCB490WC();
            monthCalendarFechaInicio490WC.Enabled = false;
            monthCalendarFechaFin490WC.Enabled = false;
            labelUsuario490WC.Text = $"Usuario: ";
            labelNombre490WC.Text = $"Nombre: ";
            labelApellido490WC.Text = $"Apellido: ";
            labelDNI490WC.Text = $"DNI: ";
        }
        public void Mostrar490WC(string usuarioFiltrar490WC = "", string moduloFiltrar490WC = "", string descripcionFiltrar490WC = "", string criticidadFiltrar490WC = "", DateTime? fechaInicioFiltrar490WC = null, DateTime? fechaFinFiltrar490WC = null)
        {
            int indiceRow490WC = 0;
            int criticidad490WC = 0;
            dgvBitacora490WC.Rows.Clear();
            ListaBitacora490WC = GestorBitacora490WC.ObtenerBitacoraPorConsulta490WC(usuarioFiltrar490WC, moduloFiltrar490WC, descripcionFiltrar490WC, criticidadFiltrar490WC, fechaInicioFiltrar490WC, fechaFinFiltrar490WC);
            foreach (BitacoraSE490WC bitacora490WC in ListaBitacora490WC)
            {
                indiceRow490WC = dgvBitacora490WC.Rows.Add(bitacora490WC.Username490WC, bitacora490WC.Fecha490WC.ToShortDateString(), bitacora490WC.Hora490WC, bitacora490WC.Modulo490WC, bitacora490WC.Descripcion490WC, bitacora490WC.Criticidad490WC);
                criticidad490WC = bitacora490WC.Criticidad490WC;
                if (dgvBitacora490WC.Rows.Count > 0)
                {
                    switch (criticidad490WC)
                    {
                        case 1:
                            dgvBitacora490WC.Rows[indiceRow490WC].DefaultCellStyle.BackColor = Color.GreenYellow;
                            break;
                        case 2:
                            dgvBitacora490WC.Rows[indiceRow490WC].DefaultCellStyle.BackColor = Color.Coral;
                            break;
                        case 3:
                            dgvBitacora490WC.Rows[indiceRow490WC].DefaultCellStyle.BackColor = Color.Orange;
                            break;
                        case 4:
                            dgvBitacora490WC.Rows[indiceRow490WC].DefaultCellStyle.BackColor = Color.OrangeRed;
                            break;
                        case 5:
                            dgvBitacora490WC.Rows[indiceRow490WC].DefaultCellStyle.BackColor = Color.Firebrick;
                            break;
                    }
                }
            }
        }
        public void LLenarCB490WC()
        {
            foreach (BitacoraSE490WC bitacora490WC in GestorBitacora490WC.ObtenerBitacoraPorConsulta490WC())
            {

                if (CB_Usuario490WC.Items.Count == 0 || !CB_Usuario490WC.Items.Contains(bitacora490WC.Username490WC))
                    CB_Usuario490WC.Items.Add(bitacora490WC.Username490WC);

                if (CB_Modulo490WC.Items.Count == 0 || !CB_Modulo490WC.Items.Contains(bitacora490WC.Modulo490WC))
                    CB_Modulo490WC.Items.Add(bitacora490WC.Modulo490WC);

                if (CB_Descripcion490WC.Items.Count == 0 || !CB_Descripcion490WC.Items.Contains(bitacora490WC.Descripcion490WC))
                    CB_Descripcion490WC.Items.Add(bitacora490WC.Descripcion490WC);

                if (CB_Criticidad490WC.Items.Count == 0 || !CB_Criticidad490WC.Items.Contains(bitacora490WC.Criticidad490WC.ToString()))
                    CB_Criticidad490WC.Items.Add(bitacora490WC.Criticidad490WC.ToString());
            }
        }

        public void LimpiarCB490WC()
        {
            CB_Usuario490WC.SelectedIndex = -1;
            CB_Modulo490WC.SelectedIndex = -1;
            CB_Descripcion490WC.SelectedIndex = -1;
            CB_Criticidad490WC.SelectedIndex = -1;
            monthCalendarFechaInicio490WC.SelectionStart = DateTime.Today;
            monthCalendarFechaFin490WC.SelectionStart = DateTime.Today;
        }
        private void BT_Filtrar_Click(object sender, EventArgs e)
        {
            string usuarioFiltrar490WC = "";
            string moduloFiltrar490WC = "";
            string descripcionFiltrar490WC = "";
            string criticidadFiltrar490WC = "";


            if (CB_Usuario490WC.SelectedIndex >= 0)
                usuarioFiltrar490WC = CB_Usuario490WC.SelectedItem.ToString();
            if (CB_Modulo490WC.SelectedIndex >= 0)
                moduloFiltrar490WC = CB_Modulo490WC.SelectedItem.ToString();
            if (CB_Descripcion490WC.SelectedIndex >= 0)
                descripcionFiltrar490WC = CB_Descripcion490WC.SelectedItem.ToString();
            if (CB_Criticidad490WC.SelectedIndex >= 0)
                criticidadFiltrar490WC = CB_Criticidad490WC.SelectedItem.ToString();


            if (checkBoxFecha490WC.Checked == false)
            {
                Mostrar490WC(usuarioFiltrar490WC, moduloFiltrar490WC, descripcionFiltrar490WC, criticidadFiltrar490WC);
            }
            else
            {

                DateTime fechaInicioFiltrar490WC = monthCalendarFechaInicio490WC.SelectionStart;
                DateTime fechaFinFiltrar490WC = monthCalendarFechaFin490WC.SelectionStart;
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
            
            Usuario490WC usuario490WC = UserManager490WC.UserManagerSG490WC.BuscarUsuarioPorUsername490WC(dgvBitacora490WC.SelectedRows[0].Cells[0].Value.ToString());
            if (usuario490WC != null)
            {

                labelUsuario490WC.Text = $"Usuario: {usuario490WC.Username490WC}";
                labelNombre490WC.Text = $"Nombre: {usuario490WC.Nombre490WC}";
                labelApellido490WC.Text = $"Apellido: {usuario490WC.Apellido490WC}";
                labelDNI490WC.Text = $"DNI: {usuario490WC.DNI490WC}";


            }
            else
            {
                labelUsuario490WC.Text = $"Usuario: Error";
                labelNombre490WC.Text = $"Nombre: Error";
                labelApellido490WC.Text = $"Apellido: Error";
                labelDNI490WC.Text = $"DNI: Error";
            }
        }

        private void BT_LimpiarFiltros_Click(object sender, EventArgs e)
        {
            LimpiarCB490WC();
            Mostrar490WC();
            labelUsuario490WC.Text = $"Usuario: ";
            labelNombre490WC.Text = $"Nombre: ";
            labelApellido490WC.Text = $"Apellido: ";
            labelDNI490WC.Text = $"DNI: ";
        }

        private void checkBoxFecha_CheckedChanged(object sender, EventArgs e)
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

        private void FormBitacoraDeEventos490WC_Load(object sender, EventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            Traductor490WC.TraductorSG490WC.Notificar490WC();
        }

        private void FormBitacoraDeEventos490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Desuscribir490WC(this);
        }

        private void BT_IMPRIMIR490WC_Click(object sender, EventArgs e)
        {

        }
    }
}
