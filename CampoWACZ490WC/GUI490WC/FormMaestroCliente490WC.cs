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
    public partial class FormMaestroCliente490WC : Form, iObserverLenguaje490WC
    {

        public FormMaestroCliente490WC()
        {
            InitializeComponent();
            //Traductor490WC.TraductorSG490WC.Notificar490WC();
            Mostrar490WC();
            ActivarModoModificar490WC(false);
            BT_Activar490WC.Enabled = false;
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            listaClientes490WC = gestorCliente490WC.ObtenerTodosLosCliente490WC();
        }
        List<Cliente490WC> listaClientes490WC;
        List<Cliente490WC> clientesSerializar490WC = new List<Cliente490WC>();
        bool estadoSerializar490WC = false;
        public void Mostrar490WC()
        {
            dgvCliente490WC.Rows.Clear();
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            dgvCliente490WC.RowTemplate.Height = 90;
            dgvCliente490WC.Columns["IMAGEN_ESTRELLA"].Width = 90;
            int indiceRow490WC = 0;
            listaClientes490WC = gestorCliente490WC.ObtenerTodosLosCliente490WC();
            foreach (Cliente490WC clienteMostrar490WC in listaClientes490WC)
            {
                indiceRow490WC = dgvCliente490WC.Rows.Add(clienteMostrar490WC.DNI490WC, clienteMostrar490WC.Nombre490WC, clienteMostrar490WC.Apellido490WC, clienteMostrar490WC.EstrellasCliente490WC, null);
                if (clienteMostrar490WC.Activo490WC == false && dgvCliente490WC.Rows.Count > 0)
                {
                    dgvCliente490WC.Rows[indiceRow490WC].DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }

        }
        public void LimpiarCampos490WC()
        {
            listboxCelularesCliente490WC.Items.Clear();
            listboxEmailsCliente490WC.Items.Clear();
            foreach (Control cl in this.Controls)
            {
                if (cl is TextBox tb)
                {
                    tb.Clear();
                }
            }
        }
        public void ActivarModoModificar490WC(bool IsActivo)
        {
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            BT_ACEPTARSERIALIZAR490WC.Enabled = false;
            BT_CANCELARSERIALIZAR490WC.Enabled = false;
            BT_LIMPIARDESERIALIZAR490WC.Enabled = false;
            if (IsActivo == true)
            {
                BT_ALTA_USUARIO490WC.Enabled = false;
                BT_BAJA_USUARIO490WC.Enabled = false;
                BT_MODIFICAR_USUARIO490WC.Enabled = false;
                BT_SALIR490WC.Enabled = false;
                BT_APLICAR490WC.Enabled = true;
                BT_CANCELAR490WC.Enabled = true;
                Cliente490WC clienteModificar490WC = gestorCliente490WC.BuscarClientePorDNI490WC(dgvCliente490WC.SelectedRows[0].Cells["DNI_CLIENTE"].Value.ToString());
                TB_NOMBRE490WC.Text = clienteModificar490WC.Nombre490WC;
                TB_APELLIDO490WC.Text = clienteModificar490WC.Apellido490WC;
                TB_DNI490WC.Text = clienteModificar490WC.DNI490WC;
                TB_DIRECCION490WC.Text = Cifrador490WC.GestorCifrador490WC.DesencriptarReversible490WC(clienteModificar490WC.Direccion490WC);

                TB_ESTRELLASCLIENTE490WC.Text = clienteModificar490WC.EstrellasCliente490WC.ToString();
                TB_DNI490WC.Enabled = false;
                foreach (string celular490WC in clienteModificar490WC.Celulares490WC)
                {
                    listboxCelularesCliente490WC.Items.Add(celular490WC);
                }
                foreach (string email490WC in clienteModificar490WC.Emails490WC)
                {
                    listboxEmailsCliente490WC.Items.Add(email490WC);
                }
            }
            else
            {
                BT_SALIR490WC.Enabled = true;
                BT_ALTA_USUARIO490WC.Enabled = true;
                BT_BAJA_USUARIO490WC.Enabled = true;
                BT_MODIFICAR_USUARIO490WC.Enabled = true;
                BT_APLICAR490WC.Enabled = false;
                BT_CANCELAR490WC.Enabled = false;
                TB_DNI490WC.Enabled = true;
                LimpiarCampos490WC();
            }
        }

        private void BT_ALTA_USUARIO490WC_Click(object sender, EventArgs e)
        {
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            string nombre490WC = TB_NOMBRE490WC.Text;
            string apellido490WC = TB_APELLIDO490WC.Text;
            string dni490WC = TB_DNI490WC.Text;
            string direccion490WC = TB_DIRECCION490WC.Text;

            if (!string.IsNullOrEmpty(direccion490WC))
            {

                if (int.TryParse(TB_ESTRELLASCLIENTE490WC.Text, out int estrellasCliente490WC))
                {
                    if (gestorCliente490WC.BuscarClientePorDNI490WC(TB_DNI490WC.Text) == null)
                    {
                        if (!string.IsNullOrEmpty(nombre490WC))
                        {
                            if (!string.IsNullOrEmpty(apellido490WC))
                            {
                                if (gestorCliente490WC.VerificarFormatoDNI490WC(dni490WC))
                                {
                                    if (!string.IsNullOrEmpty(TB_DIRECCION490WC.Text))
                                    {
                                        List<string> celulares = listboxCelularesCliente490WC.Items.Cast<string>().ToList();
                                        List<string> emails = listboxEmailsCliente490WC.Items.Cast<string>().ToList();
                                        if (celulares.Count > 0)
                                        {
                                            if (emails.Count > 0)
                                            {
                                                Cliente490WC clienteAlta490WC = new Cliente490WC(dni490WC, nombre490WC, apellido490WC, estrellasCliente490WC, emails, celulares, Cifrador490WC.GestorCifrador490WC.EncriptarReversible490WC(direccion490WC), true);
                                                gestorCliente490WC.Alta490WC(clienteAlta490WC);
                                                Mostrar490WC();
                                                LimpiarCampos490WC();
                                            }
                                            else
                                            {
                                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ClienteDebeTenerEmail");
                                                MessageBox.Show(mensajeError);
                                                LimpiarCampos490WC();
                                            }
                                        }
                                        else
                                        {
                                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ClienteDebeTenerCelular");
                                            MessageBox.Show(mensajeError);
                                            LimpiarCampos490WC();
                                        }
                                    }
                                    else
                                    {
                                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajeNombreTitularInvalido490WC");
                                        MessageBox.Show(mensajeError);
                                        LimpiarCampos490WC();
                                    }
                                }
                                else
                                {
                                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajeErrorDNIInvalido490WC");
                                    MessageBox.Show(mensajeError);
                                    LimpiarCampos490WC();
                                }
                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ApellidoVacio");
                                MessageBox.Show(mensajeError);
                                LimpiarCampos490WC();
                            }
                        }
                        else
                        {
                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("NombreVacio");
                            MessageBox.Show(mensajeError);
                            LimpiarCampos490WC();
                        }
                    }
                    else
                    {
                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ClienteConDNIExistente490WC");
                        MessageBox.Show(mensajeError);
                        LimpiarCampos490WC();
                    }
                }
                else
                {
                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("IngreseNumeroEstrellasValido490WC");
                    MessageBox.Show(mensajeError);
                    LimpiarCampos490WC();
                }
            }
            else
            {
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("DebeIngresarDireccion490WC");
                MessageBox.Show(mensajeError);
            }
        }

        private void BT_BAJA_USUARIO490WC_Click(object sender, EventArgs e)
        {
            try
            {
                GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
                gestorCliente490WC.Baja490WC(dgvCliente490WC.SelectedRows[0].Cells["DNI_CLIENTE"].Value.ToString());
                Mostrar490WC();
                LimpiarCampos490WC();
            }
            catch { }
        }

        private void BT_MODIFICAR_USUARIO490WC_Click(object sender, EventArgs e)
        {
            ActivarModoModificar490WC(true);
        }

        private void BT_APLICAR490WC_Click(object sender, EventArgs e)
        {
            try
            {
                GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
                Cliente490WC clienteModificar = gestorCliente490WC.BuscarClientePorDNI490WC(dgvCliente490WC.SelectedRows[0].Cells["DNI_CLIENTE"].Value.ToString());
                string nombre490WC = TB_NOMBRE490WC.Text;
                string apellido490WC = TB_APELLIDO490WC.Text;
                string direccion490WC = TB_DIRECCION490WC.Text;
                if (int.TryParse(TB_ESTRELLASCLIENTE490WC.Text, out int estrellasCliente490WC))
                {
                    if (!string.IsNullOrEmpty(nombre490WC))
                    {
                        if (!string.IsNullOrEmpty(apellido490WC))
                        {
                            if (!string.IsNullOrEmpty(TB_DIRECCION490WC.Text))
                            {
                                List<string> celulares = listboxCelularesCliente490WC.Items.Cast<string>().ToList();
                                List<string> emails = listboxEmailsCliente490WC.Items.Cast<string>().ToList();
                                if (celulares.Count > 0)
                                {
                                    if (emails.Count > 0)
                                    {
                                        clienteModificar.Nombre490WC = nombre490WC;
                                        clienteModificar.Apellido490WC = apellido490WC;
                                        clienteModificar.EstrellasCliente490WC = estrellasCliente490WC;
                                        clienteModificar.Celulares490WC = celulares;
                                        clienteModificar.Emails490WC = emails;
                                        clienteModificar.Direccion490WC = Cifrador490WC.GestorCifrador490WC.EncriptarReversible490WC(direccion490WC);
                                        gestorCliente490WC.Modificar490WC(clienteModificar);
                                        Mostrar490WC();
                                        LimpiarCampos490WC();
                                        ActivarModoModificar490WC(false);
                                    }
                                    else
                                    {

                                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ClienteDebeTenerEmail");
                                        MessageBox.Show(mensajeError);
                                        LimpiarCampos490WC();
                                        ActivarModoModificar490WC(false);
                                    }
                                }
                                else
                                {
                                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ClienteDebeTenerCelular");
                                    MessageBox.Show(mensajeError);
                                    LimpiarCampos490WC();
                                    ActivarModoModificar490WC(false);
                                }
                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("DebeIngresarDireccion");
                                MessageBox.Show(mensajeError);
                                LimpiarCampos490WC();
                                ActivarModoModificar490WC(false);
                            }
                        }
                        else
                        {
                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ApellidoVacio");
                            MessageBox.Show(mensajeError);
                            LimpiarCampos490WC();
                            ActivarModoModificar490WC(false);
                        }
                    }
                    else
                    {
                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("NombreVacio");
                        MessageBox.Show(mensajeError);
                        LimpiarCampos490WC();
                        ActivarModoModificar490WC(false);
                    }
                }
                else
                {
                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("IngreseNumeroEstrellasValido490WC");
                    MessageBox.Show(mensajeError);
                    LimpiarCampos490WC();
                    ActivarModoModificar490WC(false);
                }
            }
            catch { }
        }

        private void BT_CANCELAR490WC_Click(object sender, EventArgs e)
        {
            ActivarModoModificar490WC(false);
        }

        private void BT_SALIR490WC_Click(object sender, EventArgs e)
        {
            ActivarModoModificar490WC(false);
            this.Close();
        }

        private void FormMaestroCliente490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActivarModoModificar490WC(false);
            this.Close();
        }

        private void BT_AGREGARCELULAR490WC_Click(object sender, EventArgs e)
        {
            string celular490WC = TB_CELULAR490WC.Text;
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            if (!string.IsNullOrEmpty(celular490WC))
            {
                if (!listboxCelularesCliente490WC.Items.Contains(celular490WC))
                {
                    if (gestorCliente490WC.VerificarCelular490WC(celular490WC))
                    {
                        listboxCelularesCliente490WC.Items.Add(celular490WC);
                        TB_CELULAR490WC.Clear();
                    }
                    else
                    {
                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("CelularFormatoInvalido490WC");
                        MessageBox.Show(mensajeError);
                    }
                }
                else
                {
                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("NoPuedesAgregarCelularDuplicado490WC");
                    MessageBox.Show(mensajeError);
                }
            }
            else
            {
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("DebeIngresarCelular490WC");
                MessageBox.Show(mensajeError);
            }
        }

        private void BT_ELIMINARCELULAR490WC_Click(object sender, EventArgs e)
        {
            if (listboxCelularesCliente490WC.SelectedIndex != -1)
            {
                listboxCelularesCliente490WC.Items.RemoveAt(listboxCelularesCliente490WC.SelectedIndex);
            }
            else
            {
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("DebesSeleccionarCelularParaEliminarlo490WC");
                MessageBox.Show(mensajeError);
            }
        }

        private void BT_AGREGAREMAIL490WC_Click(object sender, EventArgs e)
        {
            string email490WC = TB_EMAIL490WC.Text;
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            if (!string.IsNullOrEmpty(email490WC))
            {
                if (!listboxEmailsCliente490WC.Items.Contains(email490WC))
                {
                    if (gestorCliente490WC.VerificarEmail490WC(email490WC))
                    {
                        listboxEmailsCliente490WC.Items.Add(email490WC);
                        TB_EMAIL490WC.Clear();
                    }
                    else
                    {
                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("EmailFormatoInvalido490WC");
                        MessageBox.Show(mensajeError);
                    }
                }
                else
                {
                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("NoPuedesAgregarEmailDuplicado490WC");
                    MessageBox.Show(mensajeError);
                }
            }
            else
            {
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("DebeIngresarEmail490WC");
                MessageBox.Show(mensajeError);
            }
        }

        private void BT_ELIMINAREMAIL490WC_Click(object sender, EventArgs e)
        {
            if (listboxEmailsCliente490WC.SelectedIndex != 1)
            {
                listboxEmailsCliente490WC.Items.RemoveAt(listboxEmailsCliente490WC.SelectedIndex);
            }
            else
            {
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("DebesSeleccionarEmailParaEliminarlo490WC");
                MessageBox.Show(mensajeError);
            }
        }

        private void dgvCliente490WC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            Cliente490WC clienteSeleccionado490WC = gestorCliente490WC.BuscarClientePorDNI490WC(dgvCliente490WC.SelectedRows[0].Cells["DNI_CLIENTE"].Value.ToString());
            if (clienteSeleccionado490WC.Activo490WC == false)
            {
                BT_Activar490WC.Enabled = true;
            }
            else
            {
                BT_Activar490WC.Enabled = false;
            }
        }

        private void BT_Activar490WC_Click(object sender, EventArgs e)
        {
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            gestorCliente490WC.ActivarCliente490WC(dgvCliente490WC.SelectedRows[0].Cells["DNI_CLIENTE"].Value.ToString());
            Mostrar490WC();
        }

        public void ActualizarLenguaje490WC()
        {
            RecorrerControles490WC(this);

        }

        public void RecorrerControles490WC(Control control490WC)
        {
            foreach (Control c490WC in control490WC.Controls)
            {
                if ((c490WC is TextBox tb490WC) == false)
                {

                    c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);


                    if (c490WC.HasChildren)
                    {
                        RecorrerControles490WC(c490WC);
                    }
                    if (c490WC is DataGridView dgv490WC)
                    {
                        foreach (DataGridViewColumn columna490WC in dgv490WC.Columns)
                        {
                            columna490WC.HeaderText = Traductor490WC.TraductorSG490WC.Traducir490WC(columna490WC.Name);
                        }
                    }

                }
            }
        }

        private void FormMaestroCliente490WC_Load(object sender, EventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            Traductor490WC.TraductorSG490WC.Notificar490WC();
        }

        public void ModoSerializar490WC(bool estado490WC)
        {
            if (estado490WC)
            {
                estadoSerializar490WC = true;
                BT_ACEPTARSERIALIZAR490WC.Enabled = true;
                BT_CANCELARSERIALIZAR490WC.Enabled = true;
                BT_MODOSERIALIZAR490WC.Enabled = false;
                BT_Activar490WC.Enabled = false;
                BT_DesSerializar490WC.Enabled = false;
                BT_LIMPIARDESERIALIZAR490WC.Enabled = false;
                BT_AGREGARCELULAR490WC.Enabled = false;
                BT_ELIMINARCELULAR490WC.Enabled = false;
                BT_AGREGAREMAIL490WC.Enabled = false;
                BT_ELIMINAREMAIL490WC.Enabled = false;
                BT_SALIR490WC.Enabled = false;
                BT_CANCELAR490WC.Enabled = false;
                BT_APLICAR490WC.Enabled = false;
                BT_MODIFICAR_USUARIO490WC.Enabled = false;
                BT_BAJA_USUARIO490WC.Enabled = false;
                BT_ALTA_USUARIO490WC.Enabled = false;
                clientesSerializar490WC.Clear();
            }
            else
            {
                estadoSerializar490WC = false;
                BT_ACEPTARSERIALIZAR490WC.Enabled = false;
                BT_CANCELARSERIALIZAR490WC.Enabled = false;
                BT_MODOSERIALIZAR490WC.Enabled = true;
                BT_Activar490WC.Enabled = true;
                BT_DesSerializar490WC.Enabled = true;
                BT_LIMPIARDESERIALIZAR490WC.Enabled = true;
                BT_AGREGARCELULAR490WC.Enabled = true;
                BT_ELIMINARCELULAR490WC.Enabled = true;
                BT_AGREGAREMAIL490WC.Enabled = true;
                BT_ELIMINAREMAIL490WC.Enabled = true;
                BT_SALIR490WC.Enabled = true;
                BT_CANCELAR490WC.Enabled = true;
                BT_APLICAR490WC.Enabled = true;
                BT_MODIFICAR_USUARIO490WC.Enabled = true;
                BT_BAJA_USUARIO490WC.Enabled = true;
                BT_ALTA_USUARIO490WC.Enabled = true;
                clientesSerializar490WC.Clear();
                PrevisualizadorXML490WC.Clear();
            }
        }
        private void BT_MODOSERIALIZAR490WC_Click(object sender, EventArgs e)
        {
            ModoSerializar490WC(true);
        }

        private void BT_ACEPTARSERIALIZAR490WC_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog SFD490WC =new SaveFileDialog())
            {
                SFD490WC.Filter = "Archivo XML (*.xml)|*.xml";
                SFD490WC.Title = "Guardar archivo XML";
                SFD490WC.AddExtension = true;
                SFD490WC.FileName = "Clientes490WC.xml";
                DialogResult resultado490WC = SFD490WC.ShowDialog();
                if (resultado490WC == DialogResult.OK && !string.IsNullOrWhiteSpace(SFD490WC.FileName))
                {
                    if (!SFD490WC.FileName.EndsWith(".xml",StringComparison.OrdinalIgnoreCase))
                    {
                        SFD490WC.FileName += ".xml";
                    }

                    GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();

                    gestorCliente490WC.GuardarXML490WC(GenerarTextoXML490WC(),SFD490WC.FileName);
                    MessageBox.Show("Clientes Serializados Con Exito!");
                    ModoSerializar490WC(false);
                }
            }
        }

        private void dgvCliente490WC_SelectionChanged(object sender, EventArgs e)
        {
            if (estadoSerializar490WC)
            {
                DataGridViewCellCollection celdaSerializar490WC = dgvCliente490WC.SelectedRows[0].Cells;
                Cliente490WC ClienteSerializar490WC = listaClientes490WC.Find(c490WC => c490WC.DNI490WC == celdaSerializar490WC["DNI_CLIENTE"].Value.ToString());
                var clienteSerializarRepetido490WC = clientesSerializar490WC.Find(c490WC => c490WC.DNI490WC == celdaSerializar490WC["DNI_CLIENTE"].Value.ToString());
                if (clienteSerializarRepetido490WC != null)
                {
                    clientesSerializar490WC.Remove(clienteSerializarRepetido490WC);
                }
                else
                {
                    clientesSerializar490WC.Add(ClienteSerializar490WC);
                }
                GenerarTextoXML490WC();
            }
        }
        public string GenerarTextoXML490WC()
        {
            PrevisualizadorXML490WC.Clear();
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            string XML490WC = gestorCliente490WC.SerializarCliente490WC(clientesSerializar490WC);
            PrevisualizadorXML490WC.Text = XML490WC;
            return XML490WC;
        }

        private void BT_CANCELARSERIALIZAR490WC_Click(object sender, EventArgs e)
        {
            ModoSerializar490WC(false);
        }
    }
}
