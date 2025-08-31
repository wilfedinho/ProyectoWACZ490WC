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
    public partial class FormCambiarClave490WC : Form, iObserverLenguaje490WC
    {
        public FormCambiarClave490WC()
        {
              InitializeComponent();
           // Traductor490WC.TraductorSG490WC.Notificar490WC();
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

        public void LimpiarTB490WC() 
        {
            TB_ClaveActual490WC.Clear();
            TB_ClaveNueva490WC.Clear();
            TB_ConfirmarClave490WC.Clear();
        }

        private void BT_CambiarClave490WC_Click(object sender, EventArgs e)
        {
            string tipoErrorCambioClave = UserManager490WC.UserManagerSG490WC.VerificarCambioClave490WC(TB_ClaveNueva490WC.Text, TB_ConfirmarClave490WC.Text, TB_ClaveActual490WC.Text);
            if(tipoErrorCambioClave == "Ninguno")
            {
                string mensajeCambioClave = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajeCambioClaveExitoso490WC");
                MessageBox.Show(mensajeCambioClave);
                LimpiarTB490WC();
                SesionManager490WC.GestorSesion490WC.Logout490WC();
                GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoIniciarSesion490WC());
            }
            if(tipoErrorCambioClave == "ClaveConfirmacionIgualActual")
            {
                string mensajeErrorClaveConfirmacionIgualActual = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajeErrorClaveConfirmacionIgualActual490WC");
                MessageBox.Show(mensajeErrorClaveConfirmacionIgualActual);
                LimpiarTB490WC();
            }
            if (tipoErrorCambioClave == "ClaveNuevaIgualActual")
            {
                string mensajeErrorClaveNuevaIgualActual = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajeErrorClaveNuevaIgualActual490WC"); 
                MessageBox.Show(mensajeErrorClaveNuevaIgualActual);
                LimpiarTB490WC();
            }
            if (tipoErrorCambioClave == "ClaveNuevaDistintaClaveConfirmacion")
            {
                string mensajeErrorClaveNuevaDistintaClaveConfirmacion = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajeErrorClaveNuevaDistintaClaveConfirmacion490WC");
                MessageBox.Show(mensajeErrorClaveNuevaDistintaClaveConfirmacion);
                LimpiarTB490WC();
            }
            if (tipoErrorCambioClave == "ClaveActualDistintaOriginal")
            {
                string mensajeErrorClaveActualDistintaOriginal = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajeErrorClaveActualDistintaOriginal490WC");
                MessageBox.Show(mensajeErrorClaveActualDistintaOriginal);
                LimpiarTB490WC();
            }
            if (tipoErrorCambioClave == "Campos Vacios")
            {
                string mensajeErrorCamposVacios = Traductor490WC.TraductorSG490WC.Traducir490WC("MensajeErrorCamposVacios490WC");
                MessageBox.Show(mensajeErrorCamposVacios);
            }
        }
        

        private void FormCambiarClave490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Desuscribir490WC(this);
            LimpiarTB490WC();  
        }

        private void FormCambiarClave490WC_Load(object sender, EventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            Traductor490WC.TraductorSG490WC.Notificar490WC();
        }
    }
    
}
