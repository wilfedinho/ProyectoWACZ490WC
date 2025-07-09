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
        }

        public void ActualizarLenguaje490WC()
        {
            
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
                MessageBox.Show($"Cambio de Clave Exitoso!!!");
                LimpiarTB490WC();
                SesionManager490WC.GestorSesion490WC.Logout490WC();
                GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoIniciarSesion490WC());
            }
            if(tipoErrorCambioClave == "ClaveConfirmacionIgualActual")
            {
                MessageBox.Show($"El cambio de clave no se efectuo ya que la clave de confirmacion es igual a la clave antigua");
                LimpiarTB490WC();
            }
            if (tipoErrorCambioClave == "ClaveNuevaIgualActual")
            {
                MessageBox.Show($"El cambio de clave no se efectuo ya que la clave nueva es igual a la clave antigua");
                LimpiarTB490WC();
            }
            if (tipoErrorCambioClave == "ClaveNuevaDistintaClaveConfirmacion")
            {
                MessageBox.Show($"El cambio de clave no se efectuo ya que la clave nueva y la clave confirmacion son distintas entre si");
                LimpiarTB490WC();
            }
            if (tipoErrorCambioClave == "ClaveActualDistintaOriginal")
            {
                MessageBox.Show($"El cambio de clave no se efectuo ya que la clave actual es distinta a la clave antigua");
                LimpiarTB490WC();
            }
            if (tipoErrorCambioClave == "Campos Vacios")
            {
                MessageBox.Show("El cambio de clave no se efectuo ya que se detecto que ingresaron campos vacios");
            }
        }
        

        private void FormCambiarClave490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            LimpiarTB490WC();  
        }
    }
    
}
