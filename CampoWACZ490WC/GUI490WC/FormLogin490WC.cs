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
    public partial class FormLogin490WC : Form
    {
        public FormLogin490WC()
        {
            InitializeComponent();
            Habilitar();
        }
        public void Habilitar()
        {
            if (SesionManager490WC.GestorSesion490WC.Usuario490WC != null)
            {
                BT_VolverMenu.Visible = true;
                BT_VolverMenu.Enabled = true;
            }
            else
            {
                BT_VolverMenu.Visible = false;
                BT_VolverMenu.Enabled = false;
            }
        }
        private void BT_LOGIN490WC_Click(object sender, EventArgs e)
        {
            Usuario490WC usuarioIniciarSesion490WC = UserManager490WC.UserManagerSG490WC.BuscarUsuarioPorUsername490WC(TB_Username490WC.Text);
            if (SesionManager490WC.GestorSesion490WC.Usuario490WC == null)
            {
                if (usuarioIniciarSesion490WC != null)
                {
                    if (usuarioIniciarSesion490WC.IsBloqueado490WC == false)
                    {
                        if (usuarioIniciarSesion490WC.IsHabilitado490WC == true)
                        {
                                UserManager490WC.UserManagerSG490WC.ResetearIntentos490WC(usuarioIniciarSesion490WC);
                            if (usuarioIniciarSesion490WC.Contraseña490WC == Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(TB_Contrasena490WC.Text))
                            {
                                SesionManager490WC.GestorSesion490WC.Login490WC(usuarioIniciarSesion490WC);
                                usuarioIniciarSesion490WC.HoraUltimaSesion490WC = DateTime.Now;
                                usuarioIniciarSesion490WC.Intentos490WC = 0;
                                UserManager490WC.UserManagerSG490WC.Modificar490WC(usuarioIniciarSesion490WC);
                                PermisoBLL490WC GestorPermiso490WC = new PermisoBLL490WC();
                                GestorPermiso490WC.AsignarRolSesion490WC(SesionManager490WC.GestorSesion490WC.Usuario490WC.Rol490WC);
                                GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoMenu490WC());
                            }
                            else
                            {
                                usuarioIniciarSesion490WC.Intentos490WC += 1;
                                if (usuarioIniciarSesion490WC.Intentos490WC >= 3 && usuarioIniciarSesion490WC.Rol490WC != "AdminSistema")
                                {
                                    UserManager490WC.UserManagerSG490WC.BloquearUsuario490WC(usuarioIniciarSesion490WC.Username490WC);
                                }
                                else
                                {
                                   UserManager490WC.UserManagerSG490WC.Modificar490WC(usuarioIniciarSesion490WC);
                                }
                                MessageBox.Show($"Datos Ingresados Incorrectos!!!");
                            }
                        }
                        else 
                        {
                            MessageBox.Show($"El Usuario {usuarioIniciarSesion490WC.Nombre490WC} está Desactivado!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"El Usuario {usuarioIniciarSesion490WC.Nombre490WC} está Bloqueado!!!");
                    }
                }
                else
                {
                    MessageBox.Show($"Datos Ingresados Incorrectos!!!");
                }
            }
            else
            {
                MessageBox.Show($"No se Puede Iniciar Sesion, ya que existe una sesion activa!!!");
            }
        }
        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoCerrarAplicacion490WC());
        }

        private void BT_VolverMenu_Click(object sender, EventArgs e)
        {
            GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoMenu490WC());
        }
    }
}
