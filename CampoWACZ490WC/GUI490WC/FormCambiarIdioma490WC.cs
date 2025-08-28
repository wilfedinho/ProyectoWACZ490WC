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
    public partial class FormCambiarIdioma490WC : Form, iObserverLenguaje490WC
    {
        public FormCambiarIdioma490WC()
        {
            InitializeComponent();
           // Traductor490WC.TraductorSG490WC.Notificar490WC();
            LlenarComboBox490WC();
            //ActualizarLenguaje490WC();
            
        }


        public void LlenarComboBox490WC()
        {
            foreach (string idioma490WC in Traductor490WC.TraductorSG490WC.DevolverIdiomasDisponibles490WC())
            {

                if (!(CB_IdiomasDisponibles.Items.Contains(idioma490WC)) && SesionManager490WC.GestorSesion490WC.Usuario490WC.IdiomaUsuario490WC != idioma490WC)
                {
                    CB_IdiomasDisponibles.Items.Add(idioma490WC);
                }
            }
        }

      

        public void ActualizarLenguaje490WC()
        {
            RecorrerControles490WC(this);
            string a490WC = labelIdiomaActual.Text;
            a490WC = a490WC.Replace("{SesionManager.GestorSesion.UsuarioSesion.IdiomaUsuario}", $"{SesionManager490WC.GestorSesion490WC.Usuario490WC.IdiomaUsuario490WC}");
            labelIdiomaActual.Text = a490WC;
        }

        public void RecorrerControles490WC(Control control490WC)
        {
            foreach (Control c490WC in control490WC.Controls)
            {

                if (!(c490WC is ComboBox))
                {
                    c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);
                }

                if (c490WC.HasChildren)
                {
                    RecorrerControles490WC(c490WC);
                }
            }
        }


        private void FormCambiarIdioma_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void BT_CambiarIdioma_Click_1(object sender, EventArgs e)
        {
            try
            {
                UserManager490WC GestorUsuario490WC = new UserManager490WC();
                if (CB_IdiomasDisponibles.SelectedItem != null)
                {
                    GestorUsuario490WC.CambiarIdioma490WC(CB_IdiomasDisponibles.SelectedItem.ToString());
                    ActualizarLenguaje490WC();

                    CB_IdiomasDisponibles.SelectedIndex = -1;
                    LlenarComboBox490WC();

                }
            }
            catch { }
        }

        private void FormCambiarIdioma490WC_Load(object sender, EventArgs e)
        {
            Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            Traductor490WC.TraductorSG490WC.Notificar490WC();
        }
    }
}
