using BLLS490WC;
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
                OFD490WC.Filter = "Archivos de Respaldo (*.bak)|*.bak";
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
                gestorBackUpRestore490WC.RealizarRestore490WC(TB_RESTORE490WC.Text);
                MessageBox.Show("Restauración realizada con éxito");
                TB_RESTORE490WC.Clear();
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
            
        }
    }
}
