using BLLS490WC;
using FontAwesome.Sharp;
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
    public partial class FormRestore490WC : Form, iObserverLenguaje490WC
    {
        public FormRestore490WC()
        {
            InitializeComponent();
        }
        private void BT_BUSCARRESTORE490WC_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD490WC = new OpenFileDialog())
            {
                string mensajeOperacion490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("BuscarArchivoRespaldo490WC");
                OFD490WC.Filter = mensajeOperacion490WC;
                if (OFD490WC.ShowDialog() == DialogResult.OK)
                {
                    TB_RESTORE490WC.Text = OFD490WC.FileName;
                }
            }
        }

        private void BT_EJECUTARRESTORE490WC_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TB_RESTORE490WC.Text) && !string.IsNullOrWhiteSpace(TB_RESTORE490WC.Text))
            {
                GestorBackUpRestore490WC gestorBackUpRestore490WC = new GestorBackUpRestore490WC();
                if (gestorBackUpRestore490WC.RealizarRestore490WC(TB_RESTORE490WC.Text))
                {
                    string mensajeOperacion490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("RestauracionExitosa490WC");
                    MessageBox.Show(mensajeOperacion490WC);
                    TB_RESTORE490WC.Clear();
                }
                else
                {
                    string mensajeOperacion490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("RestauracionFallida490WC");
                    MessageBox.Show(mensajeOperacion490WC);
                    TB_RESTORE490WC.Clear();
                }
            }
        }

        private void FormRestore490WC_Load(object sender, EventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            Traductor490WC.TraductorSG490WC.Notificar490WC();
        }

        private void FormRestore490WC_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
