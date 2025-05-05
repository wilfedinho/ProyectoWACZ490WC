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
        }
        private void BT_LOGIN490WC_Click(object sender, EventArgs e)
        {
            Usuario490WC usuarioIniciarSesion490WC = UserManager490WC.UserManagerSG490WC.BuscarUsuarioPorUsername490WC(TB_Username490WC.Text);
            if (usuarioIniciarSesion490WC != null)
            {
                if (usuarioIniciarSesion490WC.IsBloqueado490WC == false && usuarioIniciarSesion490WC.IsHabilitado490WC == true)
                {
                    if (usuarioIniciarSesion490WC.Contraseña490WC == Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(TB_Contrasena490WC.Text))
                    {
                        SesionManager490WC.GestorSesion490WC.Login490WC(usuarioIniciarSesion490WC);

                        usuarioIniciarSesion490WC.Intentos490WC = 0;
                        UserManager490WC.UserManagerSG490WC.Modificar490WC(usuarioIniciarSesion490WC);
                        GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoMenu490WC());
                    }
                    else
                    {

                        if (usuarioIniciarSesion490WC.Intentos490WC >= 3 && usuarioIniciarSesion490WC.Rol490WC != "Admin")
                        {
                            UserManager490WC.UserManagerSG490WC.BloquearUsuario490WC(usuarioIniciarSesion490WC.Username490WC);
                        }
                        else
                        {
                            usuarioIniciarSesion490WC.Intentos490WC += 1;
                            UserManager490WC.UserManagerSG490WC.Modificar490WC(usuarioIniciarSesion490WC);
                        }
                        MessageBox.Show($"Datos Ingresados Incorrectos!!!");
                    }
                }
                else
                {
                    MessageBox.Show($"El Usuario {usuarioIniciarSesion490WC.Nombre490WC} está Bloqueado o Desactivado!!!");
                }
            }
            else
            {
                MessageBox.Show($"Datos Ingresados Incorrectos!!!");
            }
        }
        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoCerrarAplicacion490WC());
        }

    }
}
