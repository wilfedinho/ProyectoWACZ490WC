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
    public partial class FormInconsistenciaDeDatos490WC : Form
    {
        public FormInconsistenciaDeDatos490WC()
        {
            InitializeComponent();
        }

        private void BT_ACTIVAR_USUARIO490WC_Click(object sender, EventArgs e)
        {
            DigitoVerificador490WC gestorDigitoVerificador = new DigitoVerificador490WC();
            gestorDigitoVerificador.ActualizarIntegridadSistema490WC();
            MessageBox.Show("Recalculazicion De Los Digitos Verificadores Ha Sido Exitoso!!!");
            GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoIniciarSesion490WC());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreArchivo490WC = "";
            using (OpenFileDialog OFD490WC = new OpenFileDialog())
            {
                string mensajeOperacion490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("BuscarArchivoRespaldo490WC");
                OFD490WC.Filter = mensajeOperacion490WC;
                if (OFD490WC.ShowDialog() == DialogResult.OK)
                {
                    nombreArchivo490WC = OFD490WC.FileName;
                }
            }

            if (!string.IsNullOrEmpty(nombreArchivo490WC) && !string.IsNullOrWhiteSpace(nombreArchivo490WC))
            {
                GestorBackUpRestore490WC gestorBackUpRestore490WC = new GestorBackUpRestore490WC();
                if (gestorBackUpRestore490WC.RealizarRestore490WC(nombreArchivo490WC))
                {
                    string mensajeOperacion490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("RestauracionExitosa490WC");
                    MessageBox.Show(mensajeOperacion490WC);
                    nombreArchivo490WC = "";
                    GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoIniciarSesion490WC());
                }
                else
                {
                    string mensajeOperacion490WC = Traductor490WC.TraductorSG490WC.Traducir490WC("RestauracionFallida490WC");
                    MessageBox.Show(mensajeOperacion490WC);
                    nombreArchivo490WC = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoIniciarSesion490WC());
        }
    }
}
