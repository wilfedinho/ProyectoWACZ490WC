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
        }
        public void Mostrar490WC()
        {
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            dgvCliente490WC.RowTemplate.Height = 90;
            dgvCliente490WC.Columns["IMAGEN_ESTRELLA"].Width = 90;
            foreach (Cliente490WC clienteMostrar490WC in gestorCliente490WC.ObtenerTodosLosCliente490WC())
            {
                dgvCliente490WC.Rows.Add(clienteMostrar490WC.DNI490WC, clienteMostrar490WC.Nombre490WC, clienteMostrar490WC.Apellido490WC, clienteMostrar490WC.EstrellasCliente490WC, null);
             
            }

        }

        private void BT_ALTA_USUARIO490WC_Click(object sender, EventArgs e)
        {
            string nombre490WC = TB_NOMBRE490WC.Text;
            string apellido490WC = TB_APELLIDO490WC.Text;
            string dni490WC = TB_DNI490WC.Text;
            string datosTarjeta490WC = $"{RB_CREDITO490WC.Text},{TB_NUMEROTARJETA490WC.Text},{TB_NOMBRETITULAR490WC.Text},{TB_APELLIDOTITULAR490WC.Text},{TB_FECHAEMISION490WC.Text},{TB_FECHAVENCIMIENTO490WC.Text},{TB_CODIGOSEGURIDAD490WC.Text}";
            int estrellasCliente490WC = 0;
            if (!string.IsNullOrEmpty(nombre490WC))
            {
                if(!string.IsNullOrEmpty(apellido490WC))
                {
                    if(!string.IsNullOrEmpty(dni490WC)) //Implementar validacion de DNI
                    {
                        if(!string.IsNullOrEmpty(TB_NUMEROTARJETA490WC.Text))
                        {
                            if(!string.IsNullOrEmpty(TB_NOMBRETITULAR490WC.Text))
                            {
                                if(!string.IsNullOrEmpty(TB_APELLIDOTITULAR490WC.Text))
                                {
                                    if(!string.IsNullOrEmpty(TB_FECHAEMISION490WC.Text)) //Implementar validacion de fecha de emision
                                    {
                                        if(!string.IsNullOrEmpty(TB_FECHAVENCIMIENTO490WC.Text)) //Implementar validacion de fecha de vencimiento
                                        {
                                            if(!string.IsNullOrEmpty(TB_CODIGOSEGURIDAD490WC.Text)) //Implementar validacion de codigo de seguridad
                                            {
                                                Cliente490WC clienteAlta490WC = new Cliente490WC(dni490WC, nombre490WC, apellido490WC, Cifrador490WC.GestorCifrador490WC.EncriptarReversible490WC(datosTarjeta490WC), estrellasCliente490WC);
                                                GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
                                                gestorCliente490WC.Alta490WC(clienteAlta490WC);
                                                Mostrar490WC();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ingrese un codigo de seguridad valido!!");
                                            }
                                        }
                                        else
                                        {
                                          MessageBox.Show("Ingrese una fecha de vencimiento valida!!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ingrese una fecha de emision valida!!");
                                    }
                                }
                                else
                                {
                                  MessageBox.Show("Ingrese un apellido de titular valido!!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese un nombre de titular valido!!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un numero de tarjeta valido!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un DNI valido");
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un apellido!!");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre!!!");
            }


        }

        private void BT_BAJA_USUARIO490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_MODIFICAR_USUARIO490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_APLICAR490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_CANCELAR490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_SALIR490WC_Click(object sender, EventArgs e)
        {

        }
    }
}
