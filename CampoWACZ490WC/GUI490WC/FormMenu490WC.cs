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
    public partial class FormMenu490WC : Form
    {
        FormABMUsuario490WC formABMUSUARIO490WC;
        FormCambiarClave490WC formCambiarClave490WC;

        public FormMenu490WC()
        {
            InitializeComponent();
            formABMUSUARIO490WC = new FormABMUsuario490WC(this);
            formCambiarClave490WC = new FormCambiarClave490WC();

            LabelNombreUsuarios490WC.AutoSize = false;
            LabelNombreUsuarios490WC.MaximumSize = new Size(panelPrincipal.Width, 0);


            LabelNombreUsuarios490WC.Height = LabelNombreUsuarios490WC.PreferredHeight;

            LabelRolUsuario490WC.AutoSize = false;
            LabelRolUsuario490WC.MaximumSize = new Size(panelPrincipal.Width, 0);
            LabelRolUsuario490WC.Height = LabelRolUsuario490WC.PreferredHeight;

            LabelNombreUsuarios490WC.Text = $"Bienvenido {SesionManager490WC.GestorSesion490WC.Usuario490WC.Nombre490WC} {SesionManager490WC.GestorSesion490WC.Usuario490WC.Apellido490WC} a Fertech!!! \n\n\n";
            LabelRolUsuario490WC.Text = $"Puedo ver que Posees un Rol {SesionManager490WC.GestorSesion490WC.Usuario490WC.Rol490WC}, Así que podrás acceder a estas funciones!!";

            LabelNombreUsuarios490WC.Height = LabelNombreUsuarios490WC.PreferredHeight;
            LabelRolUsuario490WC.Height = LabelRolUsuario490WC.PreferredHeight;

            Diseno490WC();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            SesionManager490WC.GestorSesion490WC.Logout490WC();
            GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoCerrarAplicacion490WC());
        }
        #region Diseno

        private void Diseno490WC()
        {
            panelAdministrarSubmenu490WC.Visible = false;
            panelSubmenuSesion490WC.Visible = false;
        }

        private void hideSubmenu490WC()
        {
            if (panelAdministrarSubmenu490WC.Visible == true)
            {
                panelAdministrarSubmenu490WC.Visible = false;
            }
            if (panelSubmenuSesion490WC.Visible == true)
            {
                panelSubmenuSesion490WC.Visible = false;
            }
        }
        private void showSubmenu490WC(Panel subMenu490WC)
        {
            if (subMenu490WC.Visible == false)
            {
                hideSubmenu490WC();
                subMenu490WC.Visible = true;
            }
            else
            {
                subMenu490WC.Visible = false;
            }
        }

        #endregion

        #region Button Click


        #endregion

        private void BT_Administrar490WC_Click(object sender, EventArgs e)
        {
            showSubmenu490WC(panelAdministrarSubmenu490WC);
        }

        private void BT_Sesion490WC_Click(object sender, EventArgs e)
        {
            showSubmenu490WC(panelSubmenuSesion490WC);
        }

        private void BT_Usuarios490WC_Click(object sender, EventArgs e)
        {
            formABMUSUARIO490WC.ShowDialog();
            hideSubmenu490WC();
            this.Show();
        }

        private void BT_CambiarClave490WC_Click(object sender, EventArgs e)
        {
            formCambiarClave490WC.ShowDialog();
            hideSubmenu490WC();
            this.Show();
        }

        private void BT_CerrarSesion490WC_Click(object sender, EventArgs e)
        {
            SesionManager490WC.GestorSesion490WC.Logout490WC();
            GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoIniciarSesion490WC());
            hideSubmenu490WC();
        }

        private void BT_Salir490WC_Click(object sender, EventArgs e)
        {
            SesionManager490WC.GestorSesion490WC.Logout490WC();
            GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoCerrarAplicacion490WC());
            hideSubmenu490WC();
        }
    }
}
