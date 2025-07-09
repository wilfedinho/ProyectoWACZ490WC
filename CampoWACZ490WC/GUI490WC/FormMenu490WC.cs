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
    public partial class FormMenu490WC : Form, iObserverLenguaje490WC
    {
        FormABMUsuario490WC formABMUSUARIO490WC;
        FormCambiarClave490WC formCambiarClave490WC;
        FormMaestroCliente490WC formMaestroCliente490WC;
        FormMaestroBoleto490WC formMaestroBoleto490WC;
        FormMaestroBeneficio490WC formMaestroBeneficio490WC;
        FormGenerarBoleto490WC formGenerarBoleto490WC;
        FormGenerarFactura490WC formGenerarFactura490WC;
        FormPermisos490WC formPermisos490WC;
        FormCambiarIdioma490WC formCambiarIdioma490WC;

        public FormMenu490WC()
        {
            InitializeComponent();
            

            LabelNombreUsuarios490WC.AutoSize = false;
            LabelNombreUsuarios490WC.MaximumSize = new Size(panelPrincipal.Width, 0);


            LabelNombreUsuarios490WC.Height = LabelNombreUsuarios490WC.PreferredHeight;

            LabelRolUsuario490WC.AutoSize = false;
            LabelRolUsuario490WC.MaximumSize = new Size(panelPrincipal.Width, 0);
            LabelRolUsuario490WC.Height = LabelRolUsuario490WC.PreferredHeight;
            SuscribirFormularios490WC();

            Traductor490WC.TraductorSG490WC.Notificar490WC();

           // LabelNombreUsuarios490WC.Text = $"Bienvenido {SesionManager490WC.GestorSesion490WC.Usuario490WC.Nombre490WC} {SesionManager490WC.GestorSesion490WC.Usuario490WC.Apellido490WC} a Fertech!!! \n\n\n";
            //LabelRolUsuario490WC.Text = $"Puedo ver que Posees un Rol {SesionManager490WC.GestorSesion490WC.Usuario490WC.Rol490WC}, Así que podrás acceder a estas funciones!!";

            LabelNombreUsuarios490WC.Height = LabelNombreUsuarios490WC.PreferredHeight;
            LabelRolUsuario490WC.Height = LabelRolUsuario490WC.PreferredHeight;

            VerificarAccesibilidadDeTodosLosControles490WC();

            Diseno490WC();

        }

        public void SuscribirFormularios490WC()
        {
            formABMUSUARIO490WC = new FormABMUsuario490WC(this);
            formCambiarClave490WC = new FormCambiarClave490WC();
            formMaestroCliente490WC = new FormMaestroCliente490WC();
            formMaestroBoleto490WC = new FormMaestroBoleto490WC();
            formMaestroBeneficio490WC = new FormMaestroBeneficio490WC();
            formGenerarBoleto490WC = new FormGenerarBoleto490WC();
            formGenerarFactura490WC = new FormGenerarFactura490WC();
            formPermisos490WC = new FormPermisos490WC();
            formCambiarIdioma490WC = new FormCambiarIdioma490WC();

            Traductor490WC.TraductorSG490WC.Suscribir490WC(this);
            Traductor490WC.TraductorSG490WC.Suscribir490WC(formABMUSUARIO490WC);
            Traductor490WC.TraductorSG490WC.Suscribir490WC(formCambiarClave490WC);
            Traductor490WC.TraductorSG490WC.Suscribir490WC(formMaestroCliente490WC);
            Traductor490WC.TraductorSG490WC.Suscribir490WC(formMaestroBoleto490WC);
            Traductor490WC.TraductorSG490WC.Suscribir490WC(formMaestroBeneficio490WC);
            Traductor490WC.TraductorSG490WC.Suscribir490WC(formGenerarBoleto490WC);
            Traductor490WC.TraductorSG490WC.Suscribir490WC(formGenerarFactura490WC);
            Traductor490WC.TraductorSG490WC.Suscribir490WC(formPermisos490WC);
            Traductor490WC.TraductorSG490WC.Suscribir490WC(formCambiarIdioma490WC);

        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                SesionManager490WC.GestorSesion490WC.Logout490WC();
                GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoCerrarAplicacion490WC());
            }
            catch { }
        }
        #region Diseno

        private void Diseno490WC()
        {
            panelAdministrarSubmenu490WC.Visible = false;
            panelSubmenuSesion490WC.Visible = false;
            panelSubmenuMaestros490WC.Visible = false;
            panelSubmenuCompra490WC.Visible = false;
            panelSubmenuModificacionBoleto490WC.Visible = false;
            panelSubmenuReportes490WC.Visible = false;
            panelSubmenuAyuda490WC.Visible = false;
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
            if (panelSubmenuMaestros490WC.Visible == true)
            {
                panelSubmenuMaestros490WC.Visible = false;
            }
            if (panelSubmenuCompra490WC.Visible == true)
            {
                panelSubmenuCompra490WC.Visible = false;
            }
            if (panelSubmenuModificacionBoleto490WC.Visible == true)
            {
                panelSubmenuModificacionBoleto490WC.Visible = false;
            }
            if (panelSubmenuReportes490WC.Visible == true)
            {
                panelSubmenuReportes490WC.Visible = false;
            }
            if (panelSubmenuAyuda490WC.Visible == true)
            {
                panelSubmenuAyuda490WC.Visible = false;
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
            try
            {
                formABMUSUARIO490WC.RellenarCombobox490WC();
                formABMUSUARIO490WC.ShowDialog();
                hideSubmenu490WC();
                this?.Show();
            }
            catch { }
        }

        private void BT_CambiarClave490WC_Click(object sender, EventArgs e)
        {
            try
            {
                formCambiarClave490WC.ShowDialog();
                hideSubmenu490WC();
                this?.Show();
            }
            catch { }
        }

        private void BT_CerrarSesion490WC_Click(object sender, EventArgs e)
        {
            try
            {
                SesionManager490WC.GestorSesion490WC.Logout490WC();
                GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoIniciarSesion490WC());
                hideSubmenu490WC();
            }
            catch { }
        }



        private void BT_IniciarSesion490WC_Click(object sender, EventArgs e)
        {
            try
            {
                GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoIniciarSesion490WC());
                hideSubmenu490WC();
            }
            catch { }
        }

        private void BT_Salir490WC_Click_1(object sender, EventArgs e)
        {
            try
            {
                SesionManager490WC.GestorSesion490WC.Logout490WC();
                GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoCerrarAplicacion490WC());
                hideSubmenu490WC();
            }
            catch { }
        }

        private void BT_GestionPermisos490WC_Click(object sender, EventArgs e)
        {
            try
            {
                formPermisos490WC.ShowDialog();
                hideSubmenu490WC();
                this?.Show();
            }
            catch { }


        }

        private void BT_BackUp490WC_Click(object sender, EventArgs e)
        {
            hideSubmenu490WC();
        }

        private void BT_Restore490WC_Click(object sender, EventArgs e)
        {
            hideSubmenu490WC();
        }

        private void BT_Bitacora490WC_Click(object sender, EventArgs e)
        {
            hideSubmenu490WC();
        }

        private void BT_DigitoVerificador490WC_Click(object sender, EventArgs e)
        {
            hideSubmenu490WC();
        }

        private void BT_CambiarIdioma490WC_Click(object sender, EventArgs e)
        {
            try
            {
                formCambiarIdioma490WC.ShowDialog();
                hideSubmenu490WC();
                this?.Show();

            }
            catch { }

        }

        private void BT_Maestros490WC_Click(object sender, EventArgs e)
        {
            showSubmenu490WC(panelSubmenuMaestros490WC);
        }

        private void BT_MaestroBoleto490WC_Click(object sender, EventArgs e)
        {
            try
            {
                formMaestroBoleto490WC.ShowDialog();
                hideSubmenu490WC();
                this?.Show();
            }
            catch { }
        }

        private void BT_MaestroCliente490WC_Click(object sender, EventArgs e)
        {
            try
            {
                formMaestroCliente490WC.ShowDialog();
                hideSubmenu490WC();
                this?.Show();
            }
            catch { }
        }

        private void BT_Compra490WC_Click(object sender, EventArgs e)
        {
            showSubmenu490WC(panelSubmenuCompra490WC);
        }

        private void BT_CompraBoleteria490WC_Click(object sender, EventArgs e)
        {
            try
            {
                formGenerarBoleto490WC.ShowDialog();
                hideSubmenu490WC();
                this?.Show();
            }
            catch { }
        }

        private void BT_CompraFacturacion_Click(object sender, EventArgs e)
        {
            try
            {
                formGenerarFactura490WC.ShowDialog();
                hideSubmenu490WC();
                this?.Show();
            }
            catch { }
        }

        private void BT_Reportes490WC_Click(object sender, EventArgs e)
        {
            showSubmenu490WC(panelSubmenuReportes490WC);
        }

        private void BT_ReporteFacturas490WC_Click(object sender, EventArgs e)
        {


            hideSubmenu490WC();

        }

        private void BT_Reporte2490WC_Click(object sender, EventArgs e)
        {
            hideSubmenu490WC();
        }

        private void BT_Reporte3490WC_Click(object sender, EventArgs e)
        {
            hideSubmenu490WC();
        }

        private void BT_Ayuda490WC_Click(object sender, EventArgs e)
        {

            hideSubmenu490WC();
        }

        private void BT_ModificacionBoleto490WC_Click(object sender, EventArgs e)
        {

            hideSubmenu490WC();
        }

        private void BT_MaestroBeneficio490WC_Click(object sender, EventArgs e)
        {
            try
            {
                formMaestroBeneficio490WC.ShowDialog();
                hideSubmenu490WC();
                this?.Show();
            }
            catch { }
        }


        public void ActualizarLenguaje490WC()
        {
            RecorrerControles490WC(this);
        }

        public void RecorrerControles490WC(Control control490WC)
        {
            foreach (Control c490WC in control490WC.Controls)
            {

                c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);
                if (c490WC.Name == LabelNombreUsuarios490WC.Name)
                {
                    string a = LabelNombreUsuarios490WC.Text;
                    a = a.Replace("{SesionManager.GestorSesion.Usuario490WC.Nombre490WC}", $"{SesionManager490WC.GestorSesion490WC.Usuario490WC.Nombre490WC}");
                    LabelNombreUsuarios490WC.Text = a;
                    LabelNombreUsuarios490WC.Height = LabelNombreUsuarios490WC.PreferredHeight;

                }

                if (c490WC.Name == LabelRolUsuario490WC.Name)
                {
                    string b490WC = LabelRolUsuario490WC.Text;
                    b490WC = b490WC.Replace("{SesionManager.GestorSesion.Usuario490WC.Rol490WC}", $"{SesionManager490WC.GestorSesion490WC.Usuario490WC.Rol490WC}");
                    LabelRolUsuario490WC.Text = b490WC;
                    LabelRolUsuario490WC.Height = LabelRolUsuario490WC.PreferredHeight;
                }


                if (c490WC.HasChildren)
                {
                    RecorrerControles490WC(c490WC);
                }
            }
        }

        #region Logica de Permisos Para Habilitar Accesos
        public void VerificarAccesibilidadDeTodosLosControles490WC()
        {
            GestorPermiso490WC GestorPermiso490WC = new GestorPermiso490WC();
            VerificarAccesibilidadRecursivo490WC(Controls, GestorPermiso490WC);
        }

        public void VerificarAccesibilidadRecursivo490WC(Control.ControlCollection controles490WC, GestorPermiso490WC GestorPermiso490WC)
        {
            foreach (Control c490WC in controles490WC)
            {
                VerificarAccesibilidad(c490WC, GestorPermiso490WC);


                if (c490WC.HasChildren)
                {
                    VerificarAccesibilidadRecursivo490WC(c490WC.Controls, GestorPermiso490WC);
                }
            }

        }

        public void VerificarAccesibilidad(Control control490WC, GestorPermiso490WC GestorPermiso490WC, bool estadoSecundario490WC = true)
        {

            control490WC.Visible = GestorPermiso490WC.ConfigurarControl490WC(control490WC.Tag?.ToString(), estadoSecundario490WC);


        }
        #endregion

    }
}
