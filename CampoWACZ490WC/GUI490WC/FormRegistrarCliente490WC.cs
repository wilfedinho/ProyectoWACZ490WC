using BE490WC;
using BLL490WC;
using Microsoft.VisualBasic;
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
    public partial class FormRegistrarCliente490WC : Form
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
            string datosTarjeta490WC = "";
            if (RB_CREDITO490WC.Checked)
            {
                datosTarjeta490WC = $"{RB_CREDITO490WC.Text},{TB_NUMEROTARJETA490WC.Text},{TB_NOMBRETITULAR490WC.Text},{TB_APELLIDOTITULAR490WC.Text},{TB_FECHAEMISION490WC.Text},{TB_FECHAVENCIMIENTO490WC.Text},{TB_CODIGOSEGURIDAD490WC.Text}";
            }
            else
            {
                datosTarjeta490WC = $"{RB_DEBITO490WC.Text},{TB_NUMEROTARJETA490WC.Text},{TB_NOMBRETITULAR490WC.Text},{TB_APELLIDOTITULAR490WC.Text},{TB_FECHAEMISION490WC.Text},{TB_FECHAVENCIMIENTO490WC.Text},{TB_CODIGOSEGURIDAD490WC.Text}";
            }

            int estrellasCliente490WC = 0;
            if (gestorCliente490WC.BuscarClientePorDNI490WC(TB_DNI490WC.Text) == null)
            {
                if (!string.IsNullOrEmpty(nombre490WC))
                {
                    if (!string.IsNullOrEmpty(apellido490WC))
                    {
                        if (gestorCliente490WC.VerificarFormatoDNI490WC(dni490WC))
                        {
                            if (gestorCliente490WC.VerificarFormatoNumeroTarjeta490WC(TB_NUMEROTARJETA490WC.Text))
                            {
                                if (!string.IsNullOrEmpty(TB_NOMBRETITULAR490WC.Text))
                                {
                                    if (!string.IsNullOrEmpty(TB_APELLIDOTITULAR490WC.Text))
                                    {
                                        if (gestorCliente490WC.VerificarFormatoFechaTarjeta490WC(TB_FECHAEMISION490WC.Text))
                                        {
                                            if (gestorCliente490WC.VerificarFormatoFechaTarjeta490WC(TB_FECHAVENCIMIENTO490WC.Text))
                                            {
                                                if (gestorCliente490WC.VerificarFormatoCVVTarjeta490WC(TB_CODIGOSEGURIDAD490WC.Text))
                                                {
                                                    //Cliente490WC clienteAlta490WC = new Cliente490WC(dni490WC, nombre490WC, apellido490WC, Cifrador490WC.GestorCifrador490WC.EncriptarReversible490WC(datosTarjeta490WC), estrellasCliente490WC);
                                                    //gestorCliente490WC.Alta490WC(clienteAlta490WC);
                                                    LimpiarCampos490WC();
                                                    DialogResult asignarBoleto = MessageBox.Show("Cliente registrado correctamente!!\n¿Desea asignar un boleto a este cliente?", "", MessageBoxButtons.YesNo);
                                                    if (asignarBoleto == DialogResult.Yes)
                                                    {
                                                        string idBoleto490WC = Interaction.InputBox("Ingrese el ID del boleto generado, que desea asignarle: ");
                                                        Boleto490WC boletoAsignar490WC = gestorBoleto490WC.ObtenerBoletoPorID490WC(idBoleto490WC);
                                                        if (boletoAsignar490WC != null)
                                                        {
                                                            if (boletoAsignar490WC.Titular490WC == null)
                                                            {
                                                               // gestorBoleto490WC.AsignarBoletoCliente490WC(boletoAsignar490WC,clienteAlta490WC);
                                                                //MessageBox.Show($"Boleto cuyo ID es: {boletoAsignar490WC.IDBoleto490WC} fue asignado correctamente al cliente con el DNI: {clienteAlta490WC.DNI490WC}!!");
                                                                LimpiarCampos490WC();
                                                                this.Close();
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("El boleto ya tiene un cliente asignado!!");
                                                                LimpiarCampos490WC();
                                                            }
                                                        }
                                                        else 
                                                        { 
                                                            MessageBox.Show("No existe un boleto con ese ID!!");
                                                            LimpiarCampos490WC();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        LimpiarCampos490WC();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Ingrese un codigo de seguridad valido!!");
                                                    LimpiarCampos490WC();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ingrese una fecha de vencimiento valida!!");
                                                LimpiarCampos490WC();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ingrese una fecha de emision valida!!");
                                            LimpiarCampos490WC();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ingrese un apellido de titular valido!!");
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
                                MessageBox.Show("Ingrese un numero de tarjeta valido!!");
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
    }
}
