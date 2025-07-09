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
                                                        MessageBox.Show($"Boleto cuyo Codigo Boleto es: {boletoAsignar490WC.IDBoleto490WC} fue asignado correctamente al cliente con el DNI: {clienteAlta490WC.DNI490WC}!!");
                                                        LimpiarCampos490WC();
                                                        this.Close();

                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("El numero De Boleto Ingresado pertenece a un Boleto que NO ha sido generado todavia!!!");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Ingrese valores Numericos!!!");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Para registrar el cliente, minimo debe tener un email para ser registrado");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Para registrar el cliente, minimo debe tener un celular para ser registrado");
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("El boleto ya tiene un cliente asignado!!");

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No existe un boleto con ese CodigoBoleto!!");

                                }

                            }
                            else
                            {
                                MessageBox.Show("El DNI Ingresado Ya pertenece a un cliente registrado en el sistema!!!");
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

        public void ActualizarLenguaje490WC()
        {
           
        }
    }
}
