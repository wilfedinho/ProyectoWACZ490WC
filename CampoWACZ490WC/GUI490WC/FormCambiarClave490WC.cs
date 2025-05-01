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
    public partial class FormCambiarClave490WC : Form
    {
        public FormCambiarClave490WC()
        {
              InitializeComponent();
        }
        public void LimpiarTB490WC() 
        {
            TB_ClaveActual490WC.Clear();
            TB_ClaveNueva490WC.Clear();
            TB_ConfirmarClave490WC.Clear();
        }

        private void BT_CambiarClave490WC_Click(object sender, EventArgs e)
        {
            if (UserManager490WC.UserManagerSG490WC.VerificarCambioClave490WC(TB_ClaveNueva490WC.Text, TB_ConfirmarClave490WC.Text, TB_ClaveActual490WC.Text))
            {
                MessageBox.Show("El cambio de clave se realizo con exito!!");
                LimpiarTB490WC();
            }
            else
            {
                LimpiarTB490WC();
                MessageBox.Show("El cambio de clave ha fracasado por ingresar datos incorrectos o inconsistentes");
            }
        }
        

        private void FormCambiarClave490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            LimpiarTB490WC();  
        }
    }
    
}
