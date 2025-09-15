using BLLS490WC;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GUI490WC
{
    public partial class FormBackUp490WC : Form, iObserverLenguaje490WC
    {
        public FormBackUp490WC()
        {
            InitializeComponent();
        }

        private void BT_BUSCARBACKUP490WC_Click(object sender, EventArgs e)
        {

            TB_RUTABACKUP490WC.Clear();
            using (FolderBrowserDialog FBD490WC = new FolderBrowserDialog())
            {
                if (FBD490WC.ShowDialog() == DialogResult.OK)
                {
                    string nombreArchivo490WC = $"Fertech_{DateTime.Now.ToString("ddMMyyyy_HHmm")}.bak";
                    string direccionBackup = Path.Combine(FBD490WC.SelectedPath, nombreArchivo490WC);
                    direccionBackup = Path.GetFullPath(direccionBackup);
                    TB_RUTABACKUP490WC.Text = direccionBackup;
                }
            }


        }

        private void BT_EJECUTARBACKUP490WC_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TB_RUTABACKUP490WC.Text) && !string.IsNullOrWhiteSpace(TB_RUTABACKUP490WC.Text))
                {
                    GestorBackUpRestore490WC gestorBackUpRestore490WC = new GestorBackUpRestore490WC();
                    gestorBackUpRestore490WC.RealizarBackUp490WC(TB_RUTABACKUP490WC.Text);
                    MessageBox.Show("Respaldo realizado con éxito.");
                    TB_RUTABACKUP490WC.Clear();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una ruta para guardar el archivo de respaldo.");
                    TB_RUTABACKUP490WC.Clear();
                }
            }
            catch { MessageBox.Show("Ruta Seleccionada Invalida Para Realizar  El Respaldo"); }
        }

        public void ActualizarLenguaje490WC()
        {

        }

        private void FormBackUp490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Desuscribir490WC(this);
        }

        private void FormBackUp490WC_Load(object sender, EventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            Traductor490WC.TraductorSG490WC.Notificar490WC();
        }
    }
}
