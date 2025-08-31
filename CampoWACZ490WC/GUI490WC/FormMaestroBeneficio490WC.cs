using BE490WC;
using BLL490WC;
using SERVICIOS490WC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI490WC
{
    public partial class FormMaestroBeneficio490WC : Form , iObserverLenguaje490WC
    {
        public FormMaestroBeneficio490WC()
        {
            InitializeComponent();
            //Traductor490WC.TraductorSG490WC.Notificar490WC();
            Mostrar490WC();
            ActivarModoModificar490WC(false);
        }

        public void Mostrar490WC()
        {
            dgvBeneficio490WC.Rows.Clear();
            GestorBeneficio490WC gestorBeneficio490WC = new GestorBeneficio490WC();
            dgvBeneficio490WC.RowTemplate.Height = 80;
            dgvBeneficio490WC.Columns["ColumnaImagen"].Width = 90;
            foreach (Beneficio490WC bene490WC in gestorBeneficio490WC.ObtenerTodosLosBeneficios490WC())
            {
                dgvBeneficio490WC.Rows.Add(bene490WC.CodigoBeneficio490WC, bene490WC.Nombre490WC, bene490WC.CantidadBeneficioReclamo490WC, bene490WC.DescuentoAplicar490WC, $"{bene490WC.PrecioEstrella490WC}", null);
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
            if (IsActivo == true)
            {
                BT_SALIR490WC.Enabled = false;
                BT_ALTA490WC.Enabled = false;
                BT_BAJA490WC.Enabled = false;
                BT_MODIFICAR490WC.Enabled = false;
                BT_APLICAR490WC.Enabled = true;
                BT_CANCELAR490WC.Enabled = true;
                TB_NOMBRE490WC.Text = dgvBeneficio490WC.SelectedRows[0].Cells["ColumnaNombre"].Value.ToString();
                TB_PRECIO490WC.Text = dgvBeneficio490WC.SelectedRows[0].Cells["ColumnaPrecio"].Value.ToString();
                TB_VECESRECLAMADO490WC.Text = dgvBeneficio490WC.SelectedRows[0].Cells["ColumnaCantidadReclamado"].Value.ToString();
                TB_DESCUENTOAPLICAR490WC.Text = dgvBeneficio490WC.SelectedRows[0].Cells["ColumnaDescuentoAplicar"].Value.ToString();
            }
            else
            {
                BT_SALIR490WC.Enabled = true;
                BT_ALTA490WC.Enabled = true;
                BT_BAJA490WC.Enabled = true;
                BT_MODIFICAR490WC.Enabled = true;
                BT_APLICAR490WC.Enabled = false;
                BT_CANCELAR490WC.Enabled = false;
                LimpiarCampos490WC();
            }
        }

        private void BT_ALTA490WC_Click(object sender, EventArgs e)
        {
            GestorBeneficio490WC gestorBeneficio490WC = new GestorBeneficio490WC();
            if (!string.IsNullOrEmpty(TB_NOMBRE490WC.Text)) 
            {
                if (!gestorBeneficio490WC.ExisteNombreBeneficioAlta490WC(TB_NOMBRE490WC.Text))
                {
                    if (int.TryParse(TB_PRECIO490WC.Text, out int precioEstrella490WC))
                    {
                        if (int.TryParse(TB_VECESRECLAMADO490WC.Text, out int cantidadReclamo490WC))
                        {
                            string texto = TB_DESCUENTOAPLICAR490WC.Text.Replace('.', ',');
                            CultureInfo cultura = new CultureInfo("es-AR");

                            if (decimal.TryParse(texto, NumberStyles.Number, cultura, out decimal descuentoAplicar490WC))
                            {
                                if (descuentoAplicar490WC >= 0.00m && descuentoAplicar490WC <= 1.00m)
                                {
                                    int decimales = BitConverter.GetBytes(decimal.GetBits(descuentoAplicar490WC)[3])[2];
                                    if (decimales <= 2)
                                    {

                                        string nombre490WC = TB_NOMBRE490WC.Text;
                                        int idBeneficio490WC = gestorBeneficio490WC.ObtenerTodosLosBeneficios490WC().Count + 1;
                                        Beneficio490WC beneficioAlta490WC = new Beneficio490WC(idBeneficio490WC, nombre490WC, precioEstrella490WC, cantidadReclamo490WC, float.Parse(descuentoAplicar490WC.ToString()));
                                        gestorBeneficio490WC.Alta490WC(beneficioAlta490WC);
                                        Mostrar490WC();
                                        LimpiarCampos490WC();
                                    }
                                    else
                                    {
                                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("Error2Decimales");
                                        MessageBox.Show(mensajeError);
                                        LimpiarCampos490WC();
                                    }
                                }
                                else
                                {
                                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorDescuentoRango");
                                    MessageBox.Show(mensajeError);
                                    LimpiarCampos490WC();
                                }
                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorValorDecimal");
                                MessageBox.Show(mensajeError);
                                LimpiarCampos490WC();
                            }
                        }
                        else
                        {
                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorValorEnteroCantidadReclamado");
                            MessageBox.Show(mensajeError);
                            LimpiarCampos490WC();
                        }
                    }
                    else
                    {
                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorValorEnteroPrecio");
                        MessageBox.Show(mensajeError);
                        LimpiarCampos490WC();
                    }

                }
                else
                {
                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorNombreRepetidoBeneficio");
                    MessageBox.Show(mensajeError);
                    LimpiarCampos490WC();
                }
            }
            else
            {
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorCampoNombreVacio");
                MessageBox.Show(mensajeError);
                LimpiarCampos490WC();
            }


        }



        private void BT_BAJA490WC_Click(object sender, EventArgs e)
        {
            GestorBeneficio490WC gestorBeneficio490WC = new GestorBeneficio490WC();
            if (gestorBeneficio490WC.Baja490WC(Convert.ToInt32(dgvBeneficio490WC.SelectedRows[0].Cells["ColumnaCodigo"].Value.ToString())) == true)
            {
                Mostrar490WC();
            }
            else
            {
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorEliminarBeneficioConCliente");
                MessageBox.Show(mensajeError);
            }

        }

        private void BT_MODIFICAR490WC_Click(object sender, EventArgs e)
        {
            ActivarModoModificar490WC(true);
        }

        private void BT_APLICAR490WC_Click(object sender, EventArgs e)
        {
            GestorBeneficio490WC gestorBeneficio490WC = new GestorBeneficio490WC();
            int codigoBeneficio490WC = int.Parse(dgvBeneficio490WC.SelectedRows[0].Cells["ColumnaCodigo"].Value.ToString());
            if (!string.IsNullOrEmpty(TB_NOMBRE490WC.Text)) 
            {
                if (!gestorBeneficio490WC.ExisteNombreBeneficioModificar490WC(TB_NOMBRE490WC.Text, codigoBeneficio490WC))
                {
                    if (int.TryParse(TB_PRECIO490WC.Text, out int precioEstrella490WC))
                    {
                        if (int.TryParse(TB_VECESRECLAMADO490WC.Text, out int cantidadReclamo490WC))
                        {
                            string texto = TB_DESCUENTOAPLICAR490WC.Text.Replace('.', ',');
                            CultureInfo cultura = new CultureInfo("es-AR");

                            if (decimal.TryParse(texto, NumberStyles.Number, cultura, out decimal descuentoAplicar490WC))
                            {
                                if (descuentoAplicar490WC >= 0.00m && descuentoAplicar490WC <= 1.00m)
                                {
                                    int decimales = BitConverter.GetBytes(decimal.GetBits(descuentoAplicar490WC)[3])[2];
                                    if (decimales <= 2)
                                    {

                                        string nombre490WC = TB_NOMBRE490WC.Text;
                                        Beneficio490WC beneficioModificado490WC = gestorBeneficio490WC.ObtenerBeneficioPorCodigo490WC(codigoBeneficio490WC);
                                        beneficioModificado490WC.Nombre490WC = nombre490WC;
                                        beneficioModificado490WC.PrecioEstrella490WC = precioEstrella490WC;
                                        beneficioModificado490WC.CantidadBeneficioReclamo490WC = cantidadReclamo490WC;
                                        beneficioModificado490WC.DescuentoAplicar490WC = float.Parse(descuentoAplicar490WC.ToString());
                                        gestorBeneficio490WC.Modificacion490WC(beneficioModificado490WC);
                                        Mostrar490WC();
                                        ActivarModoModificar490WC(false);
                                    }
                                    else
                                    {
                                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("Error2Decimales");
                                        MessageBox.Show(mensajeError);
                                        ActivarModoModificar490WC(false);
                                    }
                                }
                                else
                                {
                                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorDescuentoRango");
                                    MessageBox.Show(mensajeError);
                                    ActivarModoModificar490WC(false);
                                }
                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorValorDecimal");
                                MessageBox.Show(mensajeError);
                                ActivarModoModificar490WC(false);
                            }
                        }
                        else
                        {
                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorValorEnteroCantidadReclamado");
                            MessageBox.Show(mensajeError);
                            ActivarModoModificar490WC(false);
                        }
                    }
                    else
                    {
                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorValorEnteroPrecio");
                        MessageBox.Show(mensajeError);
                        ActivarModoModificar490WC(false);
                    }

                }
                else
                {
                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorNombreRepetidoBeneficio");
                    MessageBox.Show(mensajeError);
                    ActivarModoModificar490WC(false);
                }
            }
            else
            {
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorCampoNombreVacio");
                MessageBox.Show(mensajeError);
                ActivarModoModificar490WC(false);
            }

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

        private void FormMaestroBeneficio490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActivarModoModificar490WC(false);
            Traductor490WC.TraductorSG490WC.Desuscribir490WC(this);
            this.Close();
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

        private void FormMaestroBeneficio490WC_Load(object sender, EventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            Traductor490WC.TraductorSG490WC.Notificar490WC();
        }
    }
}
