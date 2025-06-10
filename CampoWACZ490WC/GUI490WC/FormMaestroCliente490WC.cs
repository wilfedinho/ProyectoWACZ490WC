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
            dgvCliente490WC.Rows.Clear();
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            dgvCliente490WC.RowTemplate.Height = 90;
            dgvCliente490WC.Columns["IMAGEN_ESTRELLA"].Width = 90;
            foreach (Cliente490WC clienteMostrar490WC in gestorCliente490WC.ObtenerTodosLosCliente490WC())
            {
                dgvCliente490WC.Rows.Add(clienteMostrar490WC.DNI490WC, clienteMostrar490WC.Nombre490WC, clienteMostrar490WC.Apellido490WC, clienteMostrar490WC.EstrellasCliente490WC, null);
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
                string[] datosTarjeta490WC = Cifrador490WC.GestorCifrador490WC.DesencriptarReversible490WC(clienteModificar490WC.DatosTarjeta490WC).Split(',');
                if (datosTarjeta490WC[0] == "Credito")
                {
                    RB_CREDITO490WC.Checked = true;
                }
                else
                {
                    RB_CREDITO490WC.Checked = false;
                }
                TB_NUMEROTARJETA490WC.Text = datosTarjeta490WC[1];
                TB_NOMBRETITULAR490WC.Text = datosTarjeta490WC[2];
                TB_APELLIDOTITULAR490WC.Text = datosTarjeta490WC[3];
                TB_FECHAEMISION490WC.Text = datosTarjeta490WC[4];
                TB_FECHAVENCIMIENTO490WC.Text = datosTarjeta490WC[5];
                TB_CODIGOSEGURIDAD490WC.Text = datosTarjeta490WC[6];
                TB_ESTRELLASCLIENTE490WC.Text = clienteModificar490WC.EstrellasCliente490WC.ToString();
                TB_DNI490WC.Enabled = false;
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

            int estrellasCliente490WC = int.Parse(TB_ESTRELLASCLIENTE490WC.Text); //implementar logica que valide que las estrellas sean numeros
            if (!string.IsNullOrEmpty(nombre490WC))
            {
                if (!string.IsNullOrEmpty(apellido490WC))
                {
                    if (!string.IsNullOrEmpty(dni490WC)) //Implementar validacion de DNI
                    {
                        if (!string.IsNullOrEmpty(TB_NUMEROTARJETA490WC.Text))
                        {
                            if (!string.IsNullOrEmpty(TB_NOMBRETITULAR490WC.Text))
                            {
                                if (!string.IsNullOrEmpty(TB_APELLIDOTITULAR490WC.Text))
                                {
                                    if (!string.IsNullOrEmpty(TB_FECHAEMISION490WC.Text)) //Implementar validacion de fecha de emision
                                    {
                                        if (!string.IsNullOrEmpty(TB_FECHAVENCIMIENTO490WC.Text)) //Implementar validacion de fecha de vencimiento
                                        {
                                            if (!string.IsNullOrEmpty(TB_CODIGOSEGURIDAD490WC.Text)) //Implementar validacion de codigo de seguridad
                                            {
                                                Cliente490WC clienteAlta490WC = new Cliente490WC(dni490WC, nombre490WC, apellido490WC, Cifrador490WC.GestorCifrador490WC.EncriptarReversible490WC(datosTarjeta490WC), estrellasCliente490WC);
                                                GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
                                                gestorCliente490WC.Alta490WC(clienteAlta490WC);
                                                Mostrar490WC();
                                                LimpiarCampos490WC();
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
                string datosTarjeta490WC = "";
                int estrellasCliente490WC = int.Parse(TB_ESTRELLASCLIENTE490WC.Text); //implementar logica que valide que las estrellas sean numeros
                if (RB_CREDITO490WC.Checked)
                {
                    datosTarjeta490WC = $"{RB_CREDITO490WC.Text},{TB_NUMEROTARJETA490WC.Text},{TB_NOMBRETITULAR490WC.Text},{TB_APELLIDOTITULAR490WC.Text},{TB_FECHAEMISION490WC.Text},{TB_FECHAVENCIMIENTO490WC.Text},{TB_CODIGOSEGURIDAD490WC.Text}";
                }
                else
                {
                    datosTarjeta490WC = $"{RB_DEBITO490WC.Text},{TB_NUMEROTARJETA490WC.Text},{TB_NOMBRETITULAR490WC.Text},{TB_APELLIDOTITULAR490WC.Text},{TB_FECHAEMISION490WC.Text},{TB_FECHAVENCIMIENTO490WC.Text},{TB_CODIGOSEGURIDAD490WC.Text}";
                }


                if (!string.IsNullOrEmpty(nombre490WC))
                {
                    if (!string.IsNullOrEmpty(apellido490WC))
                    {
                        if (!string.IsNullOrEmpty(TB_NUMEROTARJETA490WC.Text))
                        {
                            if (!string.IsNullOrEmpty(TB_NOMBRETITULAR490WC.Text))
                            {
                                if (!string.IsNullOrEmpty(TB_APELLIDOTITULAR490WC.Text))
                                {
                                    if (!string.IsNullOrEmpty(TB_FECHAEMISION490WC.Text)) //Implementar validacion de fecha de emision
                                    {
                                        if (!string.IsNullOrEmpty(TB_FECHAVENCIMIENTO490WC.Text)) //Implementar validacion de fecha de vencimiento
                                        {
                                            if (!string.IsNullOrEmpty(TB_CODIGOSEGURIDAD490WC.Text)) //Implementar validacion de codigo de seguridad
                                            {
                                                clienteModificar.Nombre490WC = nombre490WC;
                                                clienteModificar.Apellido490WC = apellido490WC;
                                                clienteModificar.DatosTarjeta490WC = Cifrador490WC.GestorCifrador490WC.EncriptarReversible490WC(datosTarjeta490WC);
                                                clienteModificar.EstrellasCliente490WC = estrellasCliente490WC;
                                                gestorCliente490WC.Modificar490WC(clienteModificar);
                                                Mostrar490WC();
                                                LimpiarCampos490WC();
                                                ActivarModoModificar490WC(false);
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ingrese un codigo de seguridad valido!!");
                                                LimpiarCampos490WC();
                                                ActivarModoModificar490WC(false);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ingrese una fecha de vencimiento valida!!");
                                            LimpiarCampos490WC();
                                            ActivarModoModificar490WC(false);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ingrese una fecha de emision valida!!");
                                        LimpiarCampos490WC();
                                        ActivarModoModificar490WC(false);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ingrese un apellido de titular valido!!");
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
                            MessageBox.Show("Ingrese un numero de tarjeta valido!!");
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
            catch { }
        }

        private void BT_CANCELAR490WC_Click(object sender, EventArgs e)
        {
            ActivarModoModificar490WC(false);
        }

        private void BT_SALIR490WC_Click(object sender, EventArgs e)
        {

        }
    }
}
