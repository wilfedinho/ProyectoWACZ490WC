using BE490WC;
using BLL490WC;
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
    public partial class FormSeleccionarBeneficio490WC : Form, iObserverLenguaje490WC
    {
        public Cliente490WC clienteCargado490WC;
        public FormSeleccionarBeneficio490WC(Cliente490WC clienteCargar490WC)
        {
            InitializeComponent();
            clienteCargado490WC = clienteCargar490WC;
            Mostrar490WC();
            CargarCliente490WC(clienteCargado490WC);
        }

        public void Mostrar490WC()
        {
            dgvBeneficio490WC.Rows.Clear();
            GestorBeneficio490WC gestorBeneficio490WC = new GestorBeneficio490WC();
            dgvBeneficio490WC.RowTemplate.Height = 80;
            dgvBeneficio490WC.Columns["ColumnImagenEstrella"].Width = 90;

            foreach (Beneficio490WC beneficioMostrar490WC in gestorBeneficio490WC.ObtenerTodosLosBeneficios490WC())
            {
                dgvBeneficio490WC.Rows.Add(beneficioMostrar490WC.CodigoBeneficio490WC, beneficioMostrar490WC.Nombre490WC, beneficioMostrar490WC.CantidadBeneficioReclamo490WC, $"{beneficioMostrar490WC.PrecioEstrella490WC}", null, beneficioMostrar490WC.DescuentoAplicar490WC);
            }
            HabilitarCanjeBeneficio490WC();
        }

        public void CargarCliente490WC(Cliente490WC clienteBuscado490WC)
        {
            TBINFOCLIENTE490WC.Clear();
            TBBENEFICIOCLIENTE490WC.Clear();
            GestorBeneficio490WC gestorBeneficio490WC = new GestorBeneficio490WC();
            if (clienteBuscado490WC != null)
            {
                TBINFOCLIENTE490WC.Name = "TBINFOCLIENTE490WC";
                TBBENEFICIOCLIENTE490WC.Name = "TBBENEFICIOCLIENTE490WC";

                int contadorBeneficio490WC = 1;
                if (clienteBuscado490WC.BeneficiosCliente490WC.Count > 0)
                {
                    foreach (Beneficio490WC bene490WC in clienteBuscado490WC.BeneficiosCliente490WC)
                    {
                        TBBENEFICIOCLIENTE490WC.Text += $"{contadorBeneficio490WC}. {bene490WC.Nombre490WC} {Environment.NewLine}";
                        contadorBeneficio490WC++;
                    }
                }
                else
                {

                    TBBENEFICIOCLIENTE490WC.Name = "TBBENEFICIOCLIENTECOUNT0";
                }
                ActualizarLenguaje490WC();
            }
            else
            {
                TBINFOCLIENTE490WC.Name = "TBINFOCLIENTEVACIO490WC";

                TBBENEFICIOCLIENTE490WC.Name = "TBBENEFICIOCLIENTEVACIO490WC";

                ActualizarLenguaje490WC();
            }
            HabilitarCanjeBeneficio490WC();
        }



        public void HabilitarCanjeBeneficio490WC()
        {
            if (clienteCargado490WC != null && dgvBeneficio490WC.SelectedRows.Count > 0)
            {
                BT_CANJEARBENEFICIO490WC.Enabled = true;
            }
            else
            {
                BT_CANJEARBENEFICIO490WC.Enabled = false;
            }
        }

        private void FormSeleccionarBeneficio490WC_Load(object sender, EventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            Traductor490WC.TraductorSG490WC.Notificar490WC();
        }

        private void FormSeleccionarBeneficio490WC_FormClosed(object sender, FormClosedEventArgs e)
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
                else if (c490WC.Name == "TBINFOCLIENTE490WC")
                {
                    if (clienteCargado490WC != null)
                    {
                        c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);
                        string a = c490WC.Text;
                        a = a.Replace("{ClienteCargado490WC.DNI490WC} {Environment.NewLine} ", $"{clienteCargado490WC.DNI490WC} {Environment.NewLine}");
                        a = a.Replace("{ClienteCargado490WC.Nombre490WC} {Environment.NewLine}", $"{clienteCargado490WC.Nombre490WC} {Environment.NewLine}");
                        a = a.Replace("{ClienteCargado490WC.Apellido490WC} {Environment.NewLine}", $"{clienteCargado490WC.Apellido490WC} {Environment.NewLine}");
                        a = a.Replace("{ClienteCargado490WC.EstrellasCliente490WC} {Environment.NewLine}", $"{clienteCargado490WC.EstrellasCliente490WC} {Environment.NewLine}");
                        c490WC.Text = a;
                    }
                }
                else if (c490WC.Name == "TBINFOCLIENTEVACIO490WC")
                {
                    c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);
                }
                else if (c490WC.Name == "TBBENEFICIOCLIENTEVACIO490WC")
                {
                    c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);
                }
                else if (c490WC.Name == "TBBENEFICIOCLIENTECOUNT0")
                {
                    c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);
                }
            }
        }

        private void BT_CANJEARBENEFICIO490WC_Click(object sender, EventArgs e)
        {

            GestorBeneficio490WC gestorBeneficio490WC = new GestorBeneficio490WC();
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            Beneficio490WC beneficioAplicar490WC = gestorBeneficio490WC.ObtenerBeneficioPorCodigo490WC(Convert.ToInt32(dgvBeneficio490WC.SelectedRows[0].Cells["ColumnaCodigoBeneficio490WC"].Value.ToString()));
            if (clienteCargado490WC.EstrellasCliente490WC >= beneficioAplicar490WC.PrecioEstrella490WC)
            {
                if (clienteCargado490WC.BeneficiosCliente490WC.Find(x => x.CodigoBeneficio490WC == beneficioAplicar490WC.CodigoBeneficio490WC) == null)
                {
                    gestorCliente490WC.ModificarEstrellasCliente490WC(clienteCargado490WC.DNI490WC, beneficioAplicar490WC.PrecioEstrella490WC);
                    beneficioAplicar490WC.CantidadBeneficioReclamo490WC += 1;
                    gestorBeneficio490WC.Modificacion490WC(beneficioAplicar490WC);
                    gestorBeneficio490WC.AgregarBeneficioACliente490WC(clienteCargado490WC.DNI490WC, beneficioAplicar490WC.CodigoBeneficio490WC);
                    clienteCargado490WC = gestorCliente490WC.BuscarClientePorDNI490WC(clienteCargado490WC.DNI490WC);
                    CargarCliente490WC(clienteCargado490WC);
                    Mostrar490WC();
                }
                else
                {
                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ClienteYaTieneBeneficio490WC");
                    MessageBox.Show(mensajeError);
                }
            }
            else
            {
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ClienteNoTieneEstrellasSuficientes490WC");
                MessageBox.Show(mensajeError);
            }
        }

        private void BT_CANCELAR490WC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
