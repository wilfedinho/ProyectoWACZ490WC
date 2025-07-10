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
            ActualizarLenguaje490WC();
        }

        public void ActualizarLenguaje490WC()
        {
            RecorrerControles490WC(this);

        }
        public void MostrarFacturas490WC()
        {
            dgvFactura490WC.Rows.Clear();
            GestorFactura490WC gestorFacturas490WC = new GestorFactura490WC();
            foreach (Factura490WC factu490WC in gestorFacturas490WC.ObtenerTodasLasFacturas490WC())
            {
                dgvFactura490WC.Rows.Add(factu490WC.NumeroFactura490WC, factu490WC.DNIC490WC, factu490WC.NumeroBoleto490WC);
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
            if (dgvFactura490WC.SelectedRows.Count > 0)
            {
                string carpeta490WC = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Facturas490WC");

                
                if (!Directory.Exists(carpeta490WC))
                {
                    Directory.CreateDirectory(carpeta490WC);
                }

               
                string nombreArchivoFactura = $"Factura_{dgvFactura490WC.SelectedRows[0].Cells["ColumnaDNITitular"].Value.ToString()}_Cod{dgvFactura490WC.SelectedRows[0].Cells["ColumnaNumeroFactura"].Value.ToString()}.pdf";
                string rutaFactura = Path.Combine(carpeta490WC, nombreArchivoFactura);

               
                string nombreArchivoBoleto = $"Boleto_{dgvFactura490WC.SelectedRows[0].Cells["ColumnaDNITitular"].Value.ToString().Trim()}_Cod{dgvFactura490WC.SelectedRows[0].Cells["ColumnaIDBoleto"].Value.ToString().Trim()}.pdf";
                string rutaBoleto = Path.Combine(carpeta490WC, nombreArchivoBoleto);

               
                if (File.Exists(rutaFactura))
                {
                    System.Diagnostics.Process.Start(rutaFactura);
                }
                else
                {
                    string mensajeError490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("ArchivoFacturaNOExiste");
                    MessageBox.Show(mensajeError490WC);
                }

                
                if (File.Exists(rutaBoleto))
                {
                    System.Diagnostics.Process.Start(rutaBoleto);
                }
                else
                {
                    string mensajeError490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("ArchivoBoletoNOExiste");
                    MessageBox.Show(mensajeError490WC);
                }

            }

        }
    }
}
