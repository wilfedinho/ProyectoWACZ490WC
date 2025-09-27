using BLLS490WC;
using FontAwesome.Sharp;
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
                    string mensajeOperacion490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("RespaldoExitoso490WC");
                    MessageBox.Show(mensajeOperacion490WC);
                    TB_RUTABACKUP490WC.Clear();
                }
                else
                {
                    string mensajeOperacion490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("SeleccionarRutaRespaldo490WC");
                    MessageBox.Show(mensajeOperacion490WC);
                    TB_RUTABACKUP490WC.Clear();
                }
            }
            catch { string mensajeOperacion490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorRutaSeleccionada490WC"); MessageBox.Show(mensajeOperacion490WC); }
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
                    if (c490WC is IconButton == true)
                    {

                    }
                    else if (c490WC is Button)
                    {
                        c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);
                    }
                }
            }
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
