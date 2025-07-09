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
    public partial class FormABMUsuario490WC : Form, iObserverLenguaje490WC
    {

        FormMenu490WC menu490WC;
        public FormABMUsuario490WC(FormMenu490WC menuOrigen490WC)
        {
            InitializeComponent();
            MostrarUsuarioPorConsulta490WC();
            BT_CANCELAR490WC.Enabled = false;
            BT_APLICAR490WC.Enabled = false;
            menu490WC = menuOrigen490WC;
            BT_DESBLOQUEAR_USUARIO490WC.Enabled = false;
            RellenarCombobox490WC();
        }

        public void RellenarCombobox490WC()
        {
            CB_ROL490WC.Items.Clear();
           GestorPermiso490WC GestorPermiso490WC = new GestorPermiso490WC();
            foreach (var rol490WC in GestorPermiso490WC.ObtenerRoles490WC())
            {
                CB_ROL490WC.Items.Add(rol490WC.obtenerPermisoNombre490WC());

            }
          
        }

        public void MostrarUsuarioPorConsulta490WC()
        {

            dgvUsuario490WC.Rows.Clear();
            int indiceRow490WC = 0;
            foreach (Usuario490WC usuario490WC in UserManager490WC.UserManagerSG490WC.DevolverTodosLosUsuarios490WC())
            {
                if(usuario490WC.Username490WC != SesionManager490WC.GestorSesion490WC.Usuario490WC.Username490WC)
                {
                    if (checkBoxMostrarDesactivados490WC.Checked || usuario490WC.IsHabilitado490WC == true)
                    {
                        indiceRow490WC = dgvUsuario490WC.Rows.Add(usuario490WC.Username490WC, usuario490WC.Nombre490WC, usuario490WC.Apellido490WC, usuario490WC.DNI490WC, usuario490WC.Email490WC, usuario490WC.Rol490WC, usuario490WC.IsBloqueado490WC, usuario490WC.IsHabilitado490WC);
                    }
                    if (usuario490WC.IsHabilitado490WC == false && dgvUsuario490WC.Rows.Count > 0 && checkBoxMostrarDesactivados490WC.Checked)
                    {
                        dgvUsuario490WC.Rows[indiceRow490WC].DefaultCellStyle.BackColor = Color.LightCoral;
                    } 
                }
            }
        }
        public void VaciarTextBox490WC(Control contenedor490WC)
        {
            foreach (Control control490WC in contenedor490WC.Controls)
            {
                if (control490WC is TextBox textBox490WC)
                {
                    textBox490WC.Clear();
                }
                else if (control490WC is ComboBox cb490WC)
                {
                    cb490WC.SelectedIndex = -1;
                }
                else if (control490WC.HasChildren)
                {
                    VaciarTextBox490WC(control490WC);
                }
            }
        }
      
        private void BT_ALTA_USUARIO490WC_Click(object sender, EventArgs e)
        {
             try 
             {
                string nombre490WC = TB_NOMBRE490WC.Text;
                string apellido490WC = TB_APELLIDO490WC.Text;
                string dni490WC = TB_DNI490WC.Text;
                string username490WC = dni490WC + nombre490WC;
                string contraseña490WC = Cifrador490WC.GestorCifrador490WC.EncriptarIrreversible490WC(dni490WC + apellido490WC);
                string email490WC = TB_EMAIL490WC.Text;
                string rol490WC = CB_ROL490WC.SelectedItem?.ToString();
                string idioma490WC = "Español";
                if (UserManager490WC.UserManagerSG490WC.VerificarDNI490WC(dni490WC) == true)
                {
                    if (UserManager490WC.UserManagerSG490WC.VerificarDNIDuplicado490WC(dni490WC) == false)
                    {
                        if (UserManager490WC.UserManagerSG490WC.VerificarEmail490WC(email490WC) == true)
                        {
                            if (UserManager490WC.UserManagerSG490WC.VerificarEmailDuplicado490WC(email490WC) == false)
                            {
                                if(UserManager490WC.UserManagerSG490WC.VerificarUsernameDuplicado490WC(username490WC) == false)
                                {
                                    if(!string.IsNullOrEmpty(nombre490WC))
                                    {
                                        if(!string.IsNullOrEmpty(apellido490WC))
                                        {
                                            Usuario490WC usuario490WC = new Usuario490WC(username490WC, nombre490WC, apellido490WC, dni490WC, contraseña490WC, email490WC, rol490WC, idioma490WC);
                                            UserManager490WC.UserManagerSG490WC.Alta490WC(usuario490WC);
                                            MostrarUsuarioPorConsulta490WC();
                                            VaciarTextBox490WC(this);
                                        }
                                        else
                                        {
                                            MessageBox.Show($"Debe ingresar un apellido!!"); 
                                            VaciarTextBox490WC(this);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Debe ingresar un nombre!!");
                                        VaciarTextBox490WC(this);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"El nombre de usuario es duplicado!!");
                                    VaciarTextBox490WC(this);
                                }
                            }
                            else
                            {
                                MessageBox.Show($"El email ingresado es duplicado!!");
                                VaciarTextBox490WC(this);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"El formato ingreso del Email es Incorrecto!!");
                            VaciarTextBox490WC(this);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"El DNI Ingresado se encuentra duplicado!!");
                        VaciarTextBox490WC(this);
                    }
                 
                }
                else
                {
                    MessageBox.Show($"El formato del DNI ingresado es Incorrecto!!");
                    VaciarTextBox490WC(this);
                }
             }
             catch
             {
                MessageBox.Show($"Debe seleccionar un Rol!!");
                VaciarTextBox490WC(this);
             }
        }

        private void BT_BAJA_USUARIO490WC_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario490WC UsuarioEliminar490WC = UserManager490WC.UserManagerSG490WC.BuscarUsuarioPorUsername490WC(dgvUsuario490WC.SelectedRows[0].Cells[0].Value.ToString());
                UserManager490WC.UserManagerSG490WC.Baja490WC(UsuarioEliminar490WC.Username490WC);
                MostrarUsuarioPorConsulta490WC();
                VaciarTextBox490WC(this);
            }
            catch { MessageBox.Show("Debe seleccionar el usuario a dar de baja!!!"); }
        }

        private void dgvUsuario490WC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try 
            {
                TB_NOMBRE490WC.Text = dgvUsuario490WC.SelectedRows[0].Cells[1].Value.ToString();
                TB_APELLIDO490WC.Text = dgvUsuario490WC.SelectedRows[0].Cells[2].Value.ToString();
                TB_DNI490WC.Text = dgvUsuario490WC.SelectedRows[0].Cells[3].Value.ToString();
                TB_EMAIL490WC.Text = dgvUsuario490WC.SelectedRows[0].Cells[4].Value.ToString();
                CB_ROL490WC.SelectedItem = dgvUsuario490WC.SelectedRows[0].Cells[5].Value.ToString();
                if (dgvUsuario490WC.SelectedRows[0].Cells[7].Value.ToString() == "True")
                {
                   BT_ACTIVAR_USUARIO490WC.Text = "Desactivar";
                   BT_ACTIVAR_USUARIO490WC.Name = "BT_DESACTIVAR_USUARIO490WC";
                }
                else
                {
                   BT_ACTIVAR_USUARIO490WC.Text = "Activar";
                   BT_ACTIVAR_USUARIO490WC.Name = "BT_ACTIVAR_USUARIO490WC";
                }
                if (dgvUsuario490WC.SelectedRows[0].Cells[6].Value.ToString() == "True")
                {
                  BT_DESBLOQUEAR_USUARIO490WC.Enabled = true;
                }
                else
                {
                  BT_DESBLOQUEAR_USUARIO490WC.Enabled = false;
                }
            }
            catch { }
        }

        private void BT_MODIFICAR_USUARIO490WC_Click(object sender, EventArgs e)
        {
            try
            {
                ActivarModoModificar490WC(true);
                TB_NOMBRE490WC.Text = dgvUsuario490WC.SelectedRows[0].Cells[1].Value.ToString();
                TB_APELLIDO490WC.Text = dgvUsuario490WC.SelectedRows[0].Cells[2].Value.ToString();
                TB_DNI490WC.Text = dgvUsuario490WC.SelectedRows[0].Cells[3].Value.ToString();
                TB_EMAIL490WC.Text = dgvUsuario490WC.SelectedRows[0].Cells[4].Value.ToString();
                CB_ROL490WC.SelectedItem = dgvUsuario490WC.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch { MessageBox.Show($"Debe Seleccionar Un Usuario Para Modificarlo"); };
        }
        public void ActivarModoModificar490WC(bool IsModo490WC)
        {
            if (IsModo490WC == true)
            {
                BT_ALTA_USUARIO490WC.Enabled = false;
                BT_BAJA_USUARIO490WC.Enabled = false;
                BT_MODIFICAR_USUARIO490WC.Enabled = false;
                BT_DESBLOQUEAR_USUARIO490WC.Enabled = false;
                BT_SALIR490WC.Enabled = false;
                BT_ACTIVAR_USUARIO490WC.Enabled = false;
                TB_DNI490WC.Enabled = false;
                BT_APLICAR490WC.Enabled = true;
                BT_CANCELAR490WC.Enabled = true;
            }
            else
            {
                BT_ALTA_USUARIO490WC.Enabled = true;
                BT_BAJA_USUARIO490WC.Enabled = true;
                BT_MODIFICAR_USUARIO490WC.Enabled = true;
                BT_DESBLOQUEAR_USUARIO490WC.Enabled = true;
                BT_SALIR490WC.Enabled = true;
                BT_ACTIVAR_USUARIO490WC.Enabled = true;
                TB_DNI490WC.Enabled = true;
                BT_APLICAR490WC.Enabled = false;
                BT_CANCELAR490WC.Enabled = false;
            }
        }

        private void BT_APLICAR490WC_Click(object sender, EventArgs e)
        {
            try
            {
               Usuario490WC UsuarioModificar490WC = UserManager490WC.UserManagerSG490WC.BuscarUsuarioPorUsername490WC(dgvUsuario490WC.SelectedRows[0].Cells[0].Value.ToString());
               if (UserManager490WC.UserManagerSG490WC.VerificarEmail490WC(TB_EMAIL490WC.Text) == true)
               {
                  if (UserManager490WC.UserManagerSG490WC.VerificarEmailDuplicadoModificar490WC(UsuarioModificar490WC.Email490WC,TB_EMAIL490WC.Text) == false)
                  {        
                    if (!string.IsNullOrEmpty(TB_NOMBRE490WC.Text))
                    {
                       if (!string.IsNullOrEmpty(TB_APELLIDO490WC.Text))
                       {
                          UsuarioModificar490WC.Nombre490WC = TB_NOMBRE490WC.Text;
                          UsuarioModificar490WC.Apellido490WC = TB_APELLIDO490WC.Text;
                          UsuarioModificar490WC.Email490WC = TB_EMAIL490WC.Text;
                          UsuarioModificar490WC.DNI490WC = TB_DNI490WC.Text;
                          UsuarioModificar490WC.Rol490WC = CB_ROL490WC.SelectedItem?.ToString();
                          UserManager490WC.UserManagerSG490WC.Modificar490WC(UsuarioModificar490WC);
                          MostrarUsuarioPorConsulta490WC();
                          VaciarTextBox490WC(this);
                          ActivarModoModificar490WC(false);
                       }
                       else
                       {
                           MessageBox.Show($"Debe ingresar un apellido!!");
                           VaciarTextBox490WC(this);
                           ActivarModoModificar490WC(false);
                       }
                    }
                    else
                    {
                       MessageBox.Show($"Debe ingresar un nombre!!");
                       VaciarTextBox490WC(this);
                       ActivarModoModificar490WC(false);
                    }                 
                  }
                  else
                  {
                     MessageBox.Show($"El email ingresado es duplicado!!");
                     VaciarTextBox490WC(this);
                     ActivarModoModificar490WC(false);
                  }
               }
               else
               {
                  MessageBox.Show($"El formato ingreso del Email es Incorrecto!!");
                  VaciarTextBox490WC(this);
                  ActivarModoModificar490WC(false);
               }
            }
            catch { MessageBox.Show("Debe Elegir un Rol!!!"); VaciarTextBox490WC(this); ActivarModoModificar490WC(false);}
        }

        private void BT_CANCELAR490WC_Click(object sender, EventArgs e)
        {
            ActivarModoModificar490WC(false);
            VaciarTextBox490WC(this);
        }

        private void checkBoxMostrarDesactivados490WC_CheckedChanged(object sender, EventArgs e)
        {
            MostrarUsuarioPorConsulta490WC();
        }

        private void BT_SALIR490WC_Click(object sender, EventArgs e)
        {
            VaciarTextBox490WC(this);
            this.Close();
        }

        private void FormABMUsuario490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            VaciarTextBox490WC(this);
        }

        private void BT_ACTIVAR_USUARIO490WC_Click(object sender, EventArgs e)
        {
            try 
            {
               Usuario490WC UsuarioActivarDesactivar490WC = UserManager490WC.UserManagerSG490WC.BuscarUsuarioPorUsername490WC(dgvUsuario490WC.SelectedRows[0].Cells[0].Value.ToString());

               if (dgvUsuario490WC.SelectedRows[0].Cells[7].Value.ToString() == "True")
               {
                  UserManager490WC.UserManagerSG490WC.DesactivarUsuario490WC(UsuarioActivarDesactivar490WC.Username490WC);
                  BT_ACTIVAR_USUARIO490WC.Text = "Desactivar";

               }
               else
               {
                  UserManager490WC.UserManagerSG490WC.ActivarUsuario490WC(UsuarioActivarDesactivar490WC.Username490WC);
                  BT_ACTIVAR_USUARIO490WC.Text = "Activar";

               }
               MostrarUsuarioPorConsulta490WC();  
            }
            catch { MessageBox.Show("Debe seleccionar un usuario para activarlo!!!"); }
        }

        private void BT_DESBLOQUEAR_USUARIO490WC_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario490WC UsuarioDesbloquear490WC = UserManager490WC.UserManagerSG490WC.BuscarUsuarioPorUsername490WC(dgvUsuario490WC.SelectedRows[0].Cells[0].Value.ToString());
                UserManager490WC.UserManagerSG490WC.DesbloquearUsuario490WC(UsuarioDesbloquear490WC);
                BT_DESBLOQUEAR_USUARIO490WC.Enabled = false;
                MostrarUsuarioPorConsulta490WC();
            }
            catch { MessageBox.Show("Debe seleccionar un Usuario para desbloquearlo"); }
        }

        public void ActualizarLenguaje490WC()
        {
           
        }
    }
}
