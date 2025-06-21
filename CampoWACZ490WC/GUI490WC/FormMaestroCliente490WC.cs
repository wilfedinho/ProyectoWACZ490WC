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
    public partial class FormMaestroCliente490WC : Form
    {
        public FormMaestroCliente490WC()
        {
            InitializeComponent();
            Mostrar490WC();
            ActivarModoModificar490WC(false);
        }
        public void Mostrar490WC()
        {
            dgvCliente490WC.Rows.Clear();
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            dgvCliente490WC.RowTemplate.Height = 90;
            dgvCliente490WC.Columns["IMAGEN_ESTRELLA"].Width = 90;
            foreach (Cliente490WC clienteMostrar490WC in gestorCliente490WC.ObtenerTodosLosCliente490WC())
            {
                if (clienteMostrar490WC.Activo490WC == true)
                {
                    dgvCliente490WC.Rows.Add(clienteMostrar490WC.DNI490WC, clienteMostrar490WC.Nombre490WC, clienteMostrar490WC.Apellido490WC, clienteMostrar490WC.EstrellasCliente490WC, null);
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
                                                Cliente490WC clienteAlta490WC = new Cliente490WC(dni490WC, nombre490WC, apellido490WC, estrellasCliente490WC, emails, celulares,Cifrador490WC.GestorCifrador490WC.EncriptarReversible490WC(direccion490WC), true);
                                                gestorCliente490WC.Alta490WC(clienteAlta490WC);
                                                Mostrar490WC();
                                                LimpiarCampos490WC();
                                            }
                                            else
                                            {
                                                MessageBox.Show("El cliente debe tener registrado al menos un Email!!!");
                                                LimpiarCampos490WC();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("El cliente debe tener registrado al menos un Celular!!!");
                                            LimpiarCampos490WC();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ingrese un nombre de titular valido!!");
                                        LimpiarCampos490WC();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese un DNI valido");
                                    LimpiarCampos490WC();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe ingresar un apellido!!");
                                LimpiarCampos490WC();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar un nombre!!!");
                            LimpiarCampos490WC();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un cliente con ese DNI!!");
                        LimpiarCampos490WC();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un numero de estrellas valido!!");
                    LimpiarCampos490WC();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una direccion");
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
                                        MessageBox.Show("El cliente debe tener registrado al menos un Email!!!");
                                        LimpiarCampos490WC();
                                        ActivarModoModificar490WC(false);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El cliente debe tener registrado al menos un Celular!!!");
                                    LimpiarCampos490WC();
                                    ActivarModoModificar490WC(false);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese un nombre de titular valido!!");
                                LimpiarCampos490WC();
                                ActivarModoModificar490WC(false);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar un apellido!!");
                            LimpiarCampos490WC();
                            ActivarModoModificar490WC(false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un nombre!!!");
                        LimpiarCampos490WC();
                        ActivarModoModificar490WC(false);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un numero de estrellas valido!!");
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
                        MessageBox.Show("El celular ingresado no posee el formato 1122223333");
                    }
                }
                else
                {
                    MessageBox.Show("No puedes agregar un celular duplicado!!");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un celular!!!");
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
                MessageBox.Show("Debes seleccionar un celular para eliminarlo");
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
                        MessageBox.Show("El email ingresado no posee el formato correcto");
                    }
                }
                else
                {
                    MessageBox.Show("No puedes agregar un email duplicado!!");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un email!!!");
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
                MessageBox.Show("Debes seleccionar un email para eliminarlo");
            }
        }
    }
}
