using BE490WC;
using BLL490WC;
using Microsoft.VisualBasic;
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
    public partial class FormRegistrarCliente490WC : Form, iObserverLenguaje490WC
    {
        public FormRegistrarCliente490WC()
        {
            InitializeComponent();
            //Traductor490WC.TraductorSG490WC.Notificar490WC();
            //Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            //ActualizarLenguaje490WC();
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
            string idBoleto490WC = TB_CodigoBoleto490WC.Text;

            int estrellasCliente490WC = 0;
            if (gestorCliente490WC.BuscarClientePorDNI490WC(TB_DNI490WC.Text) == null)
            {
                if (!string.IsNullOrEmpty(nombre490WC))
                {
                    if (!string.IsNullOrEmpty(apellido490WC))
                    {
                        if (gestorCliente490WC.VerificarFormatoDNI490WC(dni490WC))
                        {
                            Boleto490WC boletoAsignar490WC = gestorBoleto490WC.ObtenerBoletoPorID490WC(idBoleto490WC);
                            Cliente490WC clienteDuplicado490WC = gestorCliente490WC.BuscarClientePorDNI490WC(dni490WC);
                            if (clienteDuplicado490WC == null)
                            {
                                if (boletoAsignar490WC != null)
                                {
                                    if (boletoAsignar490WC.Titular490WC == null)
                                    {
                                        List<string> celulares = listboxCelularesCliente490WC.Items.Cast<string>().ToList();
                                        List<string> emails = listboxEmailsCliente490WC.Items.Cast<string>().ToList();
                                        if (celulares.Count > 0)
                                        {
                                            if (emails.Count > 0)
                                            {
                                                if (int.TryParse(idBoleto490WC, out int IDConvertido490WC))
                                                {
                                                    if (gestorBoleto490WC.ExisteBoletoAsignar490WC(IDConvertido490WC))
                                                    {
                                                        Cliente490WC clienteAlta490WC = new Cliente490WC(dni490WC, nombre490WC, apellido490WC, estrellasCliente490WC, emails, celulares, Cifrador490WC.GestorCifrador490WC.EncriptarReversible490WC(direccion490WC), true);
                                                        gestorCliente490WC.Alta490WC(clienteAlta490WC);
                                                        gestorBoleto490WC.AsignarBoletoClienteRegistrar490WC(boletoAsignar490WC, clienteAlta490WC);
                                                        string mensajeOperacion = Traductor490WC.TraductorSG490WC.Traducir490WC("AsignarBoletoClienteRegistrar");
                                                        string a = mensajeOperacion;
                                                        a = a.Replace("{boletoAsignar490WC.IDBoleto490WC}", boletoAsignar490WC.IDBoleto490WC);
                                                        a = a.Replace("{clienteAlta490WC.DNI490WC}", clienteAlta490WC.DNI490WC);
                                                        mensajeOperacion = a;
                                                        MessageBox.Show(mensajeOperacion);
                                                        LimpiarCampos490WC();
                                                        this.Close();

                                                    }
                                                    else
                                                    {
                                                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorNumeroBoletoDeBoletoNOGENERADO");
                                                        MessageBox.Show(mensajeError);
                                                    }
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
                                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorBoletoYaTieneClienteAsignado");
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
            if (listboxEmailsCliente490WC.SelectedIndex != -1)
            {
                listboxEmailsCliente490WC.Items.RemoveAt(listboxEmailsCliente490WC.SelectedIndex);
            }
            else
            {
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("DebesSeleccionarEmailParaEliminarlo490WC");
                MessageBox.Show(mensajeError);
            }
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

        private void FormRegistrarCliente490WC_Load(object sender, EventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            Traductor490WC.TraductorSG490WC.Notificar490WC();
        }

        private void FormRegistrarCliente490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Desuscribir490WC(this);
        }
    }
}
