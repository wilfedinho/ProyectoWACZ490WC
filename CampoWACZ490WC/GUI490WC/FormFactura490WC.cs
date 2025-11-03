using BE490WC;
using BLL490WC;
using Org.BouncyCastle.Bcpg.OpenPgp;
using SERVICIOS490WC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI490WC
{
    public partial class FormFactura490WC : Form, iObserverLenguaje490WC
    {
        public FormFactura490WC()
        {
            InitializeComponent();

            MostrarFacturas490WC();

        }

        public void ActualizarLenguaje490WC()
        {
            RecorrerControles490WC(this);

        }
        public void MostrarFacturas490WC()
        {
            dgvFactura490WC.Rows.Clear();
            GestorFactura490WC gestorFacturas490WC = new GestorFactura490WC();
            if (RD_FacturaNormal490WC.Checked)
            {
                foreach (Factura490WC factu490WC in gestorFacturas490WC.ObtenerTodasLasFacturas490WC())
                {
                    if (string.IsNullOrEmpty(factu490WC.CambiosRealizados490WC))
                    {
                        dgvFactura490WC.Rows.Add(factu490WC.NumeroFactura490WC, factu490WC.DNIC490WC, factu490WC.NumeroBoleto490WC);
                    }
                }
            }
            else
            {
                foreach (Factura490WC factu490WC in gestorFacturas490WC.ObtenerTodasLasFacturasModificadas490WC())
                {
                    dgvFactura490WC.Rows.Add(factu490WC.NumeroFactura490WC, factu490WC.DNIC490WC, factu490WC.NumeroBoleto490WC);
                }
            }
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

        private void BT_IMPRIMIRFACTURA490WC_Click(object sender, EventArgs e)
        {
            if (RD_FacturaNormal490WC.Checked)
            {
                if (dgvFactura490WC.SelectedRows.Count > 0)
                {
                    GestorFactura490WC gestorFactura490WC = new GestorFactura490WC();
                    Factura490WC facturaGenerar490WC = gestorFactura490WC.ObtenerTodasLasFacturas490WC().Find(x => x.NumeroFactura490WC == int.Parse(dgvFactura490WC.SelectedRows[0].Cells["ColumnaNumeroFactura"].Value.ToString()));
                    if (facturaGenerar490WC != null)
                    {
                        gestorFactura490WC.GenerarFactura490WC(facturaGenerar490WC);
                    }
                    GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
                    Boleto490WC boletoGenerar490WC = gestorBoleto490WC.ObtenerBoletoConBeneficio490WC(dgvFactura490WC.SelectedRows[0].Cells["ColumnaIDBoleto"].Value.ToString().Trim());
                    if (boletoGenerar490WC != null)
                    {
                        gestorBoleto490WC.GenerarBoleto490WC(boletoGenerar490WC);
                    }
                }
            }
            else
            {
                if (dgvFactura490WC.SelectedRows.Count > 0)
                {
                    GestorFactura490WC gestorFactura490WC = new GestorFactura490WC();
                    Factura490WC facturaGenerar490WC = gestorFactura490WC.ObtenerTodasLasFacturas490WC().Find(x => x.NumeroFactura490WC == int.Parse(dgvFactura490WC.SelectedRows[0].Cells["ColumnaNumeroFactura"].Value.ToString()));
                    if (facturaGenerar490WC != null)
                    {
                        gestorFactura490WC.GenerarFacturaBoletoModificado490WC(facturaGenerar490WC);
                    }
                    GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
                    Boleto490WC boletoGenerar490WC = gestorBoleto490WC.ObtenerBoletoConBeneficio490WC(dgvFactura490WC.SelectedRows[0].Cells["ColumnaIDBoleto"].Value.ToString().Trim());
                    if (boletoGenerar490WC != null)
                    {
                        gestorBoleto490WC.GenerarBoleto490WC(boletoGenerar490WC);
                    }
                }
            }

        }

        private void FormFactura490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Desuscribir490WC(this);
            MostrarFacturas490WC();
        }

        private void FormFactura490WC_Load(object sender, EventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            Traductor490WC.TraductorSG490WC.Notificar490WC();
        }

        private void RD_FacturaNormal490WC_CheckedChanged(object sender, EventArgs e)
        {
            MostrarFacturas490WC();
        }
    }
}
