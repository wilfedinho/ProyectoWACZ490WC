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
    public partial class FormGenerarFactura490WC : Form, iObserverLenguaje490WC
    {
        FormRegistrarCliente490WC formRegistrarCliente490WC;
        Cliente490WC clienteCobrar490WC;
        Boleto490WC boletoCobrar490WC;
        public FormGenerarFactura490WC()
        {
            InitializeComponent();
            //Traductor490WC.TraductorSG490WC.Notificar490WC();
            CargarCliente490WC(null);
            BT_COBRARFACTURA490WC.Enabled = false;
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
                else if (c490WC.Name == "TBINFOCLIENTEGENERARFACTURA490WC")
                {
                    TBINFOCLIENTE490WC.Text += "DNI: {clienteBuscado490WC.DNI490WC} {Environment.NewLine} Nombre: {clienteBuscado490WC.Nombre490WC} {Environment.NewLine} Apellido: {clienteBuscado490WC.Apellido490WC} {Environment.NewLine}";
                    c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);
                    string a = c490WC.Text;
                    a = a.Replace("{clienteBuscado490WC.DNI490WC} {Environment.NewLine}",$"{clienteCobrar490WC.DNI490WC} {Environment.NewLine}");
                    a = a.Replace("{clienteBuscado490WC.Nombre490WC} {Environment.NewLine}", $"{clienteCobrar490WC.Nombre490WC} {Environment.NewLine}");
                    a = a.Replace("{clienteBuscado490WC.Apellido490WC} {Environment.NewLine}", $"{clienteCobrar490WC.Apellido490WC} {Environment.NewLine}");
                    c490WC.Text = a;
                }
                else if (c490WC.Name == "TBINFOCLIENTEVACIOGENERARFACTURA490WC")
                {
                    c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);
                }
            }
        }

        public void CargarCliente490WC(Cliente490WC clienteBuscado490WC)
        {
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            TBINFOCLIENTE490WC.Clear();
            dgvBoleto490WC.Rows.Clear();
            if (clienteBuscado490WC != null)
            {
                
                foreach (Boleto490WC boletoCliente490WC in gestorBoleto490WC.ObtenerBoletosPorCliente490WC(clienteBuscado490WC))
                {
                    if (boletoCliente490WC.IsVendido490WC == false)
                    {
                        if (boletoCliente490WC is BoletoIDA490WC)
                        {
                            dgvBoleto490WC.Rows.Add(boletoCliente490WC.IDBoleto490WC, boletoCliente490WC.Origen490WC, boletoCliente490WC.Destino490WC, boletoCliente490WC.FechaPartida490WC.ToShortDateString(), boletoCliente490WC.FechaLlegada490WC.ToShortDateString(), null, null, boletoCliente490WC.EquipajePermitido490WC, boletoCliente490WC.ClaseBoleto490WC, boletoCliente490WC.Precio490WC, boletoCliente490WC.NumeroAsiento490WC, boletoCliente490WC.BeneficioAplicado490WC);
                        }
                        if (boletoCliente490WC is BoletoIDAVUELTA490WC)
                        {
                            dgvBoleto490WC.Rows.Add(boletoCliente490WC.IDBoleto490WC, boletoCliente490WC.Origen490WC, boletoCliente490WC.Destino490WC, boletoCliente490WC.FechaPartida490WC.ToShortDateString(), boletoCliente490WC.FechaLlegada490WC.ToShortDateString(), (boletoCliente490WC as BoletoIDAVUELTA490WC).FechaPartidaVUELTA490WC.ToShortDateString(), (boletoCliente490WC as BoletoIDAVUELTA490WC).FechaLlegadaVUELTA490WC.ToShortDateString(), boletoCliente490WC.EquipajePermitido490WC, boletoCliente490WC.ClaseBoleto490WC, boletoCliente490WC.Precio490WC, boletoCliente490WC.NumeroAsiento490WC, boletoCliente490WC.BeneficioAplicado490WC);
                        }
                    }
                }
                TBINFOCLIENTE490WC.Name = "TBINFOCLIENTEGENERARFACTURA490WC";
            }
            else
            {
                clienteCobrar490WC = null;
               
                TBINFOCLIENTE490WC.Name = "TBINFOCLIENTEVACIOGENERARFACTURA490WC";
            }
            if (dgvBoleto490WC.Rows.Count > 0)
            {
                BT_COBRARFACTURA490WC.Enabled = true;
            }
            else
            {
                BT_COBRARFACTURA490WC.Enabled = false;
            }
        }

        private void BT_BUSCARCLIENTE490WC_Click(object sender, EventArgs e)
        {
            GestorCliente490WC gestorCliente490WC = new GestorCliente490WC();
            clienteCobrar490WC = gestorCliente490WC.BuscarClientePorDNI490WC(TB_DNI490WC.Text);
            if (clienteCobrar490WC != null)
            {
                if (clienteCobrar490WC.Activo490WC == true)
                {
                    CargarCliente490WC(clienteCobrar490WC);
                    TB_DNI490WC.Clear();
                    
                }
                else
                {
                    string mensajeDesactivado = Traductor490WC.TraductorSG490WC.Traducir490WC("ClienteDesactivado490WC");
                    MessageBox.Show(mensajeDesactivado);
                    
                    CargarCliente490WC(null);
                    TB_DNI490WC.Clear();
                }
            }
            else
            {
                string mensajeClienteRegistrar = Traductor490WC.TraductorSG490WC.Traducir490WC("ClienteRegistrar");
                MessageBox.Show(mensajeClienteRegistrar);
                
                CargarCliente490WC(null);
                formRegistrarCliente490WC = new FormRegistrarCliente490WC();
                formRegistrarCliente490WC.ShowDialog();
                TB_DNI490WC.Clear();
            }
            ActualizarLenguaje490WC();
        }



        private void BT_COBRARFACTURA490WC_Click(object sender, EventArgs e)
        {
            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            if (clienteCobrar490WC != null)
            {
                foreach (Boleto490WC bole490WC in gestorBoleto490WC.ObtenerBoletosPorCliente490WC(clienteCobrar490WC))
                {
                    if (bole490WC.IDBoleto490WC == dgvBoleto490WC.SelectedRows[0].Cells["ColumnaID"].Value.ToString())
                    {
                        boletoCobrar490WC = bole490WC;

                    }
                }
                if (boletoCobrar490WC != null)
                {
                    FormCobrarFactura490WC formCobrarFactura490WC = new FormCobrarFactura490WC(clienteCobrar490WC, boletoCobrar490WC);
                    formCobrarFactura490WC.ShowDialog();
                    if (formCobrarFactura490WC.pagoAceptado490WC)
                    {
                        gestorBoleto490WC.CobrarBoleto490WC(boletoCobrar490WC);
                        
                        string mensajeFacturaGenerada = Traductor490WC.TraductorSG490WC.Traducir490WC("FacturaGenerada490WC");
                        MessageBox.Show(mensajeFacturaGenerada);
                        //boletoCobrar490WC = gestorBoleto490WC.ObtenerBoletoPorID490WC(boletoCobrar490WC.IDBoleto490WC);
                        boletoCobrar490WC = gestorBoleto490WC.ObtenerBoletoConBeneficio490WC(boletoCobrar490WC.IDBoleto490WC);
                        gestorBoleto490WC.GenerarBoleto490WC(boletoCobrar490WC);
                        CargarCliente490WC(null);
                        boletoCobrar490WC = null;
                    }
                    else
                    {
                        string mensajeFacturaNoGenerada = Traductor490WC.TraductorSG490WC.Traducir490WC("FacturaNoGenerada490WC");
                        MessageBox.Show(mensajeFacturaNoGenerada);
                        CargarCliente490WC(null);
                        boletoCobrar490WC = null;
                    }
                }
                else
                {
                    string mensajeSeleccionarBoleto = Traductor490WC.TraductorSG490WC.Traducir490WC("DebeSeleccionarBoletoFactura490WC");
                    MessageBox.Show(mensajeSeleccionarBoleto);
                    CargarCliente490WC(null);
                    boletoCobrar490WC = null;
                }

            }
            else
            {
                string mensajeBuscarCliente = Traductor490WC.TraductorSG490WC.Traducir490WC("DebeBuscarClienteParaCobrarFactura490WC");
                MessageBox.Show(mensajeBuscarCliente);
                CargarCliente490WC(null);
                boletoCobrar490WC = null;
            }

        }

        private void FormGenerarFactura490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarCliente490WC(null);
            boletoCobrar490WC = null;
            BT_COBRARFACTURA490WC.Enabled = false;
            Traductor490WC.TraductorSG490WC.Desuscribir490WC(this);
        }

        private void FormGenerarFactura490WC_Load(object sender, EventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            Traductor490WC.TraductorSG490WC.Notificar490WC();
        }
    }
}
