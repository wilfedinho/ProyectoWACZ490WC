using Microsoft.VisualBasic;
using SE490WC;
using SERVICIOS490WC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI490WC
{
    public partial class FormPermisos490WC : Form
    {
        string adminRolNombre490WC = "AdminSistema";

        Permiso490WC elementoSeleccionado490WC;

        public FormPermisos490WC()
        {
            InitializeComponent();
            HabilitarCarga490WC();
            CargarComboboxFamilia490WC();
            CargarComboBoxRol490WC();
            CargarTodasLasFamiliasEnArbol490WC();
            CargarTodosLosPerfilesEnArbol490WC();
        }

        public void CargarComboBoxRol490WC()
        {
            CB_ROL490WC.Items.Clear();
            GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
            foreach (Permiso490WC permi490WC in gestorPermiso490WC.ObtenerRoles490WC())
            {
                if (permi490WC.obtenerPermisoNombre490WC() != SesionManager490WC.GestorSesion490WC.Usuario490WC.Rol490WC)
                {
                    CB_ROL490WC.Items.Add(permi490WC.obtenerPermisoNombre490WC());
                }
            }

        }

        public void CargarComboboxFamilia490WC()
        {
            CB_FAMILIA490WC.Items.Clear();
            GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
            foreach (Permiso490WC permi490WC in gestorPermiso490WC.ObtenerPermisosCompuestos490WC())
            {
                CB_FAMILIA490WC.Items.Add(permi490WC.obtenerPermisoNombre490WC());
            }
        }

        public void LlenarPermisosSimples490WC()
        {
            listboxPermisoSimple490WC.Items.Clear();
            GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
            foreach (Permiso490WC permi490WC in gestorPermiso490WC.ObtenerPermisosSimples490WC())
            {
                listboxPermisoSimple490WC.Items.Add(permi490WC.obtenerPermisoNombre490WC());
            }
        }

        public void LlenarFamilias490WC()
        {
            listboxFamilia490WC.Items.Clear();
            GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
            foreach (Permiso490WC permi490WC in gestorPermiso490WC.ObtenerPermisosCompuestos490WC())
            {
                listboxFamilia490WC.Items.Add(permi490WC.obtenerPermisoNombre490WC());
            }
        }

        public void HabilitarCarga490WC()
        {
            listboxFamilia490WC.Items.Clear();
            listboxPermisoSimple490WC.Items.Clear();
            if (RB_SIMPLE490WC.Checked)
            {
                listboxPermisoSimple490WC.Enabled = true;
                listboxFamilia490WC.Enabled = false;
                LlenarPermisosSimples490WC();
            }
            else
            {
                listboxFamilia490WC.Enabled = true;
                listboxPermisoSimple490WC.Enabled = false;
                LlenarFamilias490WC();
            }
        }

        public void CargarTodosLosPerfilesEnArbol490WC()
        {
            treeViewRoles490WC.Nodes.Clear();
            GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
            foreach (Permiso490WC permi490WC in gestorPermiso490WC.ObtenerRoles490WC())
            {
                Permiso490WC rolEstructurar490WC = gestorPermiso490WC.LeerPermisoCompuesto490WC(permi490WC.obtenerPermisoNombre490WC());
                var nodo490WC = new TreeNode(rolEstructurar490WC.obtenerPermisoNombre490WC());
                treeViewRoles490WC.Nodes.Add(nodo490WC);
                CargarArbolRevursivo490WC(rolEstructurar490WC, nodo490WC);
            }
        }
        public void CargarTodasLasFamiliasEnArbol490WC()
        {
            treeViewFamilias490WC.Nodes.Clear();
            GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
            foreach (Permiso490WC permi490WC in gestorPermiso490WC.LeerFamiliasConEstructuraRecursiva490WC())
            {
                var nodo490WC = new TreeNode(permi490WC.obtenerPermisoNombre490WC());
                treeViewFamilias490WC.Nodes.Add(nodo490WC);
                CargarArbolRevursivo490WC(permi490WC, nodo490WC);
            }
        }
        public void CargarArbolRevursivo490WC(Permiso490WC permisoPadre490WC, TreeNode nodoPadre490WC)
        {
            if (permisoPadre490WC is PermisoCompuesto490WC permisoPadreCompuesto490WC)
            {
                foreach (Permiso490WC permi490WC in permisoPadreCompuesto490WC.PermisosIncluidos490WC())
                {
                    var nodoAgregar490WC = new TreeNode(permi490WC.obtenerPermisoNombre490WC());
                    nodoPadre490WC.Nodes.Add(nodoAgregar490WC);
                    if (permi490WC is PermisoCompuesto490WC)
                    {
                        CargarArbolRevursivo490WC(permi490WC, nodoAgregar490WC);
                    }
                }
            }
            else
            {
                var nodoAgregar490WC = new TreeNode(permisoPadre490WC.obtenerPermisoNombre490WC());
                nodoPadre490WC.Nodes.Add(nodoAgregar490WC);
            }
        }

        public void HabilitarAcciones490WC(bool Activar490WC)
        {
            if (Activar490WC)
            {

            }
        }

        private void FormPermisos490WC_Load(object sender, EventArgs e)
        {

        }

        private void BT_CrearRol490WC_Click(object sender, EventArgs e)
        {
            string nombreRol490WC = TB_ROL490WC.Text;
            GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
            if (!string.IsNullOrEmpty(nombreRol490WC) && !string.IsNullOrWhiteSpace(nombreRol490WC))
            {
                if (!gestorPermiso490WC.PerfilExiste490WC(nombreRol490WC))
                {
                    if (RB_SIMPLE490WC.Checked)
                    {
                        if (listboxPermisoSimple490WC.SelectedIndex > -1)
                        {
                            Permiso490WC rolCrear490WC = new PermisoCompuesto490WC(nombreRol490WC);
                            Permiso490WC permisoHijo = gestorPermiso490WC.ObtenerPermisosSimples490WC().Find(x => x.obtenerPermisoNombre490WC() == listboxPermisoSimple490WC.SelectedItem.ToString());
                            rolCrear490WC.Agregar490WC(permisoHijo);
                            if (gestorPermiso490WC.InsertarRol490WC((PermisoCompuesto490WC)rolCrear490WC))
                            {
                                CargarComboBoxRol490WC();
                                CargarComboboxFamilia490WC();
                                CargarTodasLasFamiliasEnArbol490WC();
                                CargarTodosLosPerfilesEnArbol490WC();
                                TB_ROL490WC.Clear();
                                MessageBox.Show("Creacion del Rol Exitosa!!!");
                            }
                            else
                            {
                                MessageBox.Show("Creacion del Rol Fracasada!!!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se Puede Crear un Rol Vacio!!!");
                        }
                    }
                    else
                    {
                        if (listboxFamilia490WC.SelectedIndex > -1)
                        {
                            Permiso490WC rolCrear490WC = new PermisoCompuesto490WC(nombreRol490WC);
                            Permiso490WC permisoHijo = gestorPermiso490WC.LeerPermisoCompuesto490WC(listboxFamilia490WC.SelectedItem.ToString());
                            rolCrear490WC.Agregar490WC(permisoHijo);
                            if (gestorPermiso490WC.InsertarRol490WC((PermisoCompuesto490WC)rolCrear490WC))
                            {
                                CargarComboBoxRol490WC();
                                CargarComboboxFamilia490WC();
                                CargarTodasLasFamiliasEnArbol490WC();
                                CargarTodosLosPerfilesEnArbol490WC();
                                TB_ROL490WC.Clear();
                                MessageBox.Show("Creacion del Rol Exitosa!!!");
                            }
                            else
                            {
                                MessageBox.Show("Creacion del Rol Fracasada!!!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se puede Crear un Rol Vacio!!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El nombre ingresado para un nuevo Rol ya se encuentra en uso!!!");
                }

            }
            else
            {
                MessageBox.Show("Debe Ingresar un Nombre para Crear un Nuevo Rol!!!");
            }
        }

        private void BT_CrearFamilia490WC_Click(object sender, EventArgs e)
        {
            string nombreFamiliaCrear490WC = TB_FAMILIA490WC.Text;
            GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
            if (!string.IsNullOrEmpty(nombreFamiliaCrear490WC) && !string.IsNullOrWhiteSpace(nombreFamiliaCrear490WC))
            {
                if (!gestorPermiso490WC.FamiliaExiste490WC(nombreFamiliaCrear490WC))
                {
                    if (RB_SIMPLE490WC.Checked)
                    {
                        if (listboxPermisoSimple490WC.SelectedIndex > -1)
                        {
                            Permiso490WC FamiliaCrear490WC = new PermisoCompuesto490WC(nombreFamiliaCrear490WC);
                            Permiso490WC permisoHijo = gestorPermiso490WC.ObtenerPermisosSimples490WC().Find(x => x.obtenerPermisoNombre490WC() == listboxPermisoSimple490WC.SelectedItem.ToString());
                            FamiliaCrear490WC.Agregar490WC(permisoHijo);
                            if (gestorPermiso490WC.InsertarFamilia490WC((PermisoCompuesto490WC)FamiliaCrear490WC))
                            {
                                CargarComboBoxRol490WC();
                                CargarComboboxFamilia490WC();
                                CargarTodasLasFamiliasEnArbol490WC();
                                CargarTodosLosPerfilesEnArbol490WC();
                                TB_ROL490WC.Clear();
                                MessageBox.Show("Creacion de la Familia Exitosa!!!");
                            }
                            else
                            {
                                MessageBox.Show("Creacion de la Familia Fracasada!!!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se Puede Crear una Familia Vacia!!!");
                        }
                    }
                    else
                    {
                        if (listboxFamilia490WC.SelectedIndex > -1)
                        {
                            Permiso490WC FamiliaCrear490WC = new PermisoCompuesto490WC(nombreFamiliaCrear490WC);
                            Permiso490WC permisoHijo = gestorPermiso490WC.LeerPermisoCompuesto490WC(listboxFamilia490WC.SelectedItem.ToString());
                            FamiliaCrear490WC.Agregar490WC(permisoHijo);
                            if (gestorPermiso490WC.InsertarFamilia490WC((PermisoCompuesto490WC)FamiliaCrear490WC))
                            {
                                CargarComboBoxRol490WC();
                                CargarComboboxFamilia490WC();
                                CargarTodasLasFamiliasEnArbol490WC();
                                CargarTodosLosPerfilesEnArbol490WC();
                                TB_ROL490WC.Clear();
                                MessageBox.Show("Creacion de la Familia Exitosa!!!");
                            }
                            else
                            {
                                MessageBox.Show("Creacion de la Familia Fracasada!!!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se puede Crear una Familia Vacia!!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El nombre ingresado para la nueva Familia ya se encuentra en uso!!!");
                }

            }
            else
            {
                MessageBox.Show("Debe Ingresar un Nombre para Crear una Nueva Familia!!!");
            }
        }

        private void BT_Modificar490WC_Click(object sender, EventArgs e)
        {
            if (CB_ROL490WC.SelectedIndex > -1)
            {
                EjecutarModificacion490WC("Rol");
            }
            else if (CB_FAMILIA490WC.SelectedIndex > -1)
            {
                EjecutarModificacion490WC("Familia");
            }
        }

        public void EjecutarModificacion490WC(string queModificar490WC)
        {
            if (queModificar490WC == "Rol")
            {

            }
            else if (queModificar490WC == "Familia")
            {

            }
        }

        private void BT_ELIMINAR490WC_Click(object sender, EventArgs e)
        {
            if (CB_ROL490WC.SelectedIndex > -1)
            {
                EjecutarEliminacion490WC("Rol");
            }
            else if (CB_FAMILIA490WC.SelectedIndex > -1)
            {
                EjecutarEliminacion490WC("Familia");
            }
        }

        public void EjecutarEliminacion490WC(string queEliminar490WC)
        {
            if (queEliminar490WC == "Rol")
            {
                GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
                if (CB_ROL490WC.SelectedIndex > -1)
                {
                    string nombreElementoSeleccionado490WC = CB_ROL490WC.SelectedItem.ToString();
                    if (!gestorPermiso490WC.RolEstaAsignado490WC(nombreElementoSeleccionado490WC))
                    {
                        if (gestorPermiso490WC.BorrarRol490WC(nombreElementoSeleccionado490WC))
                        {
                            MessageBox.Show("Eliminacion Exitosa!!!");
                            CargarComboBoxRol490WC();
                            CargarComboboxFamilia490WC();
                            CargarTodasLasFamiliasEnArbol490WC();
                            CargarTodosLosPerfilesEnArbol490WC();
                            CB_ROL490WC.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Eliminacion Fracasada!!!");
                            CB_ROL490WC.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puede eliminar un Rol que esta asignado a usuario(s)!!");
                        CB_ROL490WC.SelectedIndex = -1;
                    }
                }
                else
                {
                    MessageBox.Show("Para eliminar Un Rol o Familia Debe Seleccionarlo!!!");
                    CB_ROL490WC.SelectedIndex = -1;
                }
            }
            else if (queEliminar490WC == "Familia")
            {
                GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
                if (CB_FAMILIA490WC.SelectedIndex > -1)
                {
                    string nombreElementoSeleccionado490WC = CB_FAMILIA490WC.SelectedItem.ToString();

                    if (!gestorPermiso490WC.FamiliaEstaAsignadaAPerfil490WC(nombreElementoSeleccionado490WC))
                    {
                        if (!gestorPermiso490WC.FamiliaEstaAnidadaEnOtra490WC(nombreElementoSeleccionado490WC))
                        {
                            if (gestorPermiso490WC.BorrarFamilia490WC(nombreElementoSeleccionado490WC))
                            {
                                MessageBox.Show("Eliminacion Exitosa!!!");
                                CargarComboBoxRol490WC();
                                CargarComboboxFamilia490WC();
                                CargarTodasLasFamiliasEnArbol490WC();
                                CargarTodosLosPerfilesEnArbol490WC();
                                CB_ROL490WC.SelectedIndex = -1;
                            }
                            else
                            {
                                MessageBox.Show("Eliminacion Fracasada!!!");
                                CB_FAMILIA490WC.SelectedIndex = -1;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No puede eliminar una Familia que esta asignada a otra Familia(s)!!!");
                            CB_FAMILIA490WC.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puede eliminar una Familia que esta asignada a Rol(es)!!!");
                        CB_FAMILIA490WC.SelectedIndex = -1;
                    }
                }
                else
                {
                    MessageBox.Show("Para eliminar Un Rol o Familia Debe Seleccionarlo!!!");
                    CB_FAMILIA490WC.SelectedIndex = -1;
                }
            }
        }
        private void BT_ASIGNAR490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_DESASIGNAR490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_GUARDARCAMBIOS490WC_Click(object sender, EventArgs e)
        {

        }

        private void RB_SIMPLE490WC_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarCarga490WC();
        }
    }
}
