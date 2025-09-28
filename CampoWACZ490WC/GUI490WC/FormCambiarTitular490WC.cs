using BE490WC;
using BLL490WC;
using Org.BouncyCastle.Pqc.Crypto.Lms;
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
using System.Windows.Ink;

namespace GUI490WC
{
    public partial class FormCambiarTitular490WC : Form, iObserverLenguaje490WC
    {
        public Boleto490WC boletoCargado490WC;
        public Cliente490WC clienteCambiarTitularidad490WC;
        List<Cliente490WC> listaClientes490WC;
        public FormCambiarTitular490WC(Boleto490WC BoletoCargado490WC)
        {
            InitializeComponent();
            boletoCargado490WC = BoletoCargado490WC;
            Mostrar490WC();
        }
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

        private void FormCambiarTitular490WC_Load(object sender, EventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            Traductor490WC.TraductorSG490WC.Notificar490WC();
        }

        private void FormCambiarTitular490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Desuscribir490WC(this);
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

        public void LimpiarCampos490WC()
        {
            foreach (Control cl in this.Controls)
            {
                if (cl is TextBox tb)
                {
                    tb.Clear();
                }
            }
        }

        private void BT_REGISTRARCLIENTE490WC_Click(object sender, EventArgs e)
        {
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            string nombre490WC = TB_NOMBRE490WC.Text;
            string apellido490WC = TB_APELLIDO490WC.Text;
            string dni490WC = TB_DNI490WC.Text;
            string direccion490WC = TB_DIRECCION490WC.Text;
            string idBoleto490WC = boletoCargado490WC.IDBoleto490WC;

            int estrellasCliente490WC = 0;
            if (gestorCliente490WC.BuscarClientePorDNI490WC(TB_DNI490WC.Text) == null)
            {
                if (!string.IsNullOrEmpty(nombre490WC))
                {
                    if (!string.IsNullOrEmpty(apellido490WC))
                    {
                        if (gestorCliente490WC.VerificarFormatoDNI490WC(dni490WC))
                        {

                            Cliente490WC clienteDuplicado490WC = gestorCliente490WC.BuscarClientePorDNI490WC(dni490WC);
                            if (clienteDuplicado490WC == null)
                            {
                                if (boletoCargado490WC != null)
                                {

                                    List<string> celulares = listboxCelularesCliente490WC.Items.Cast<string>().ToList();
                                    List<string> emails = listboxEmailsCliente490WC.Items.Cast<string>().ToList();
                                    if (celulares.Count > 0)
                                    {
                                        if (emails.Count > 0)
                                        {
                                            if (int.TryParse(idBoleto490WC, out int IDConvertido490WC))
                                            {
                                                Cliente490WC clienteAlta490WC = new Cliente490WC(dni490WC, nombre490WC, apellido490WC, estrellasCliente490WC, emails, celulares, Cifrador490WC.GestorCifrador490WC.EncriptarReversible490WC(direccion490WC), true);
                                                gestorCliente490WC.Alta490WC(clienteAlta490WC);
                                                boletoCargado490WC.Titular490WC = clienteAlta490WC;
                                                string[] cambios = boletoCargado490WC.CambiosRealizados490WC.Split(';');
                                                cambios[9] = $"{boletoCargado490WC.Titular490WC.DNI490WC}";
                                                boletoCargado490WC.Precio490WC += (boletoCargado490WC.Precio490WC * 0.60f);
                                                boletoCargado490WC.CambiosRealizados490WC = string.Join(";", cambios);
                                                gestorBoleto490WC.CambiarTitularBoletoModificado490WC(boletoCargado490WC);
                                                string mensajeOperacion490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("RegistroYCambioTitularBoleto490WC");
                                                mensajeOperacion490WC = mensajeOperacion490WC.Replace("{boletoCargado490WC.IDBoleto490WC}", boletoCargado490WC.IDBoleto490WC);
                                                MessageBox.Show(mensajeOperacion490WC);
                                                LimpiarCampos490WC();
                                                this.Close();
                                            }
                                            else
                                            {
                                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorValoresNumericos");
                                                MessageBox.Show(mensajeError);
                                            }
                                        }
                                        else
                                        {
                                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorMinimoEmailRegistro");
                                            MessageBox.Show(mensajeError);
                                        }
                                    }
                                    else
                                    {
                                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorMinimoCelularRegistro");
                                        MessageBox.Show(mensajeError);
                                    }



                                }
                                else
                                {
                                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorCodigoNoExistente");
                                    MessageBox.Show(mensajeError);

                                }

                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorDNIYAREGISTRADO");
                                MessageBox.Show(mensajeError);
                            }
                        }
                        else
                        {
                            string mensajeErrpr = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajeErrorDNIInvalido490WC");
                            MessageBox.Show(mensajeErrpr);
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
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorDNIYAREGISTRADO");
                MessageBox.Show(mensajeError);
                LimpiarCampos490WC();
            }
        }

        private void BT_CAMBIARTITULAR490WC_Click(object sender, EventArgs e)
        {
            if (dgvCliente490WC.SelectedRows.Count > 0)
            {
                string[] cambios = boletoCargado490WC.CambiosRealizados490WC.Split(';');
                GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
                GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
                clienteCambiarTitularidad490WC = gestorCliente490WC.BuscarClientePorDNI490WC(dgvCliente490WC.SelectedRows[0].Cells["DNI_CLIENTE"].Value.ToString());
                if (clienteCambiarTitularidad490WC != null && clienteCambiarTitularidad490WC.DNI490WC != boletoCargado490WC.Titular490WC.DNI490WC)
                {
                    boletoCargado490WC.Titular490WC = clienteCambiarTitularidad490WC;
                    cambios[9] = $"{boletoCargado490WC.Titular490WC.DNI490WC}";
                    boletoCargado490WC.Precio490WC += (boletoCargado490WC.Precio490WC * 0.60f);
                    boletoCargado490WC.CambiosRealizados490WC = string.Join(";", cambios);
                    gestorBoleto490WC.CambiarTitularBoletoModificado490WC(boletoCargado490WC);
                    string mensajeOperacion490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("CambioTitularBoleto490WC");
                    mensajeOperacion490WC = mensajeOperacion490WC.Replace("{boletoCargado490WC.IDBoleto490WC}", cambios[0]);
                    MessageBox.Show(mensajeOperacion490WC);
                    LimpiarCampos490WC();
                    this.Close();
                }
                else
                {
                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorMismoTitular490WC");
                    MessageBox.Show(mensajeError);
                }
            }
        }
    }
}
