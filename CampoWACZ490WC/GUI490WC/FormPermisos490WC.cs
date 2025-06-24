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
            ActivarModificacion490WC(false);
            HabilitarCarga490WC();
            CargarComboboxFamilia490WC();
            CargarComboBoxRol490WC();
            CargarTodasLasFamiliasEnArbol490WC();
            CargarTodosLosPerfilesEnArbol490WC();
            LlenarFamilias490WC();
            LlenarPermisosSimples490WC();
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
            
            if (RB_SIMPLE490WC.Checked)
            {
                listboxPermisoSimple490WC.Enabled = true;
                listboxFamilia490WC.Enabled = false;
                listboxFamilia490WC.SelectedIndex = -1;
                listboxPermisoSimple490WC.SelectedIndex = -1;
            }
            else
            {
                listboxFamilia490WC.Enabled = true;
                listboxPermisoSimple490WC.Enabled = false;
                listboxFamilia490WC.SelectedIndex = -1;
                listboxPermisoSimple490WC.SelectedIndex = -1;
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
                                LlenarFamilias490WC();
                                TB_FAMILIA490WC.Clear();
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
                                LlenarFamilias490WC();
                                TB_FAMILIA490WC.Clear();
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
                if (elementoSeleccionado490WC != null)
                {
                    ActivarModificacion490WC(true);
                    CargarPermisosSimplesParaModificacion490WC();
                    CargarFamiliasParaModificacion490WC();
                }
            }
            else if (CB_FAMILIA490WC.SelectedIndex > -1)
            {
                EjecutarModificacion490WC("Familia");
                if (elementoSeleccionado490WC != null)
                {
                    ActivarModificacion490WC(true);
                    CargarPermisosSimplesParaModificacion490WC();
                    CargarFamiliasParaModificacion490WC();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Familia o Rol para modificarlo");
            }
        }
        public void ActivarModificacion490WC(bool Activo490WC)
        {
            if (Activo490WC)
            {
                BT_ASIGNAR490WC.Enabled = true;
                BT_DESASIGNAR490WC.Enabled = true;
                BT_GUARDARCAMBIOS490WC.Enabled = true;
                CB_FAMILIA490WC.Enabled = false;
                CB_ROL490WC.Enabled = false;
                treeViewFamilias490WC.Enabled = false;
                treeViewRoles490WC.Enabled = false;
                BT_CrearFamilia490WC.Enabled = false;
                BT_CrearRol490WC.Enabled = false;
                TB_FAMILIA490WC.Enabled = false;
                TB_ROL490WC.Enabled = false;
                BT_Modificar490WC.Enabled = false;
                BT_ELIMINAR490WC.Enabled = false;
            }
            else
            {
                BT_ASIGNAR490WC.Enabled = false;
                BT_DESASIGNAR490WC.Enabled = false;
                BT_GUARDARCAMBIOS490WC.Enabled = false;
                CB_FAMILIA490WC.Enabled = true;
                CB_ROL490WC.Enabled = true;
                treeViewFamilias490WC.Enabled = true;
                treeViewRoles490WC.Enabled = true;
                BT_CrearFamilia490WC.Enabled = true;
                BT_CrearRol490WC.Enabled = true;
                TB_FAMILIA490WC.Enabled = true;
                TB_ROL490WC.Enabled = true;
                BT_Modificar490WC.Enabled = true;
                BT_ELIMINAR490WC.Enabled = true;
            }
        }

        public void CargarPermisosSimplesParaModificacion490WC()
        {
            GestorPermiso490WC gestorPermisos490WC = new GestorPermiso490WC();
            if (elementoSeleccionado490WC != null)
            {
                listboxPermisoSimple490WC.Items.Clear();
                List<string> nombrePermisosNOagregar = gestorPermisos490WC.ObtenerNombresDePermisos490WC((PermisoCompuesto490WC)elementoSeleccionado490WC);
                foreach (Permiso490WC permi490WC in gestorPermisos490WC.ObtenerPermisosSimples490WC())
                {
                    if (!nombrePermisosNOagregar.Contains(permi490WC.obtenerPermisoNombre490WC()))
                    {
                        listboxPermisoSimple490WC.Items.Add(permi490WC.obtenerPermisoNombre490WC());
                    }
                }
            }
        }
        public void CargarFamiliasParaModificacion490WC()
        {
            GestorPermiso490WC gestorPermisos490WC = new GestorPermiso490WC();
            listboxFamilia490WC.Items.Clear();

            if (elementoSeleccionado490WC is PermisoCompuesto490WC compuestoSeleccionado)
            {
                foreach (PermisoCompuesto490WC familiaCandidata in gestorPermisos490WC.LeerFamiliasConEstructuraRecursiva490WC())
                {
                    string nombreCandidata = familiaCandidata.obtenerPermisoNombre490WC();

                    // Evitar agregarse a sí misma
                    if (nombreCandidata == compuestoSeleccionado.obtenerPermisoNombre490WC())
                        continue;

                    // Verificar si ya existe en la estructura del seleccionado
                    bool yaExiste = gestorPermisos490WC.ExistePermisoEnEstructura490WC(compuestoSeleccionado, nombreCandidata);

                    if (!yaExiste)
                    {
                        listboxFamilia490WC.Items.Add(nombreCandidata);
                    }
                }
            }
        }





        public void PrepararArbolVistaPreviaModificar490WC(string queModificar490WC)
        {
            if (queModificar490WC == "Rol")
            {
                treeViewPreviaModificacion490WC.Nodes.Clear();
                GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
                elementoSeleccionado490WC = gestorPermiso490WC.LeerPermisoCompuesto490WC(CB_ROL490WC.SelectedItem.ToString());
                var nodo490WC = new TreeNode(elementoSeleccionado490WC.obtenerPermisoNombre490WC());
                treeViewPreviaModificacion490WC.Nodes.Add(nodo490WC);
                CargarArbolRevursivo490WC(elementoSeleccionado490WC, nodo490WC);
            }
            else if (queModificar490WC == "Familia")
            {
                treeViewPreviaModificacion490WC.Nodes.Clear();
                GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
                elementoSeleccionado490WC = gestorPermiso490WC.LeerPermisoCompuesto490WC(CB_FAMILIA490WC.SelectedItem.ToString());
                var nodo490WC = new TreeNode(elementoSeleccionado490WC.obtenerPermisoNombre490WC());
                treeViewPreviaModificacion490WC.Nodes.Add(nodo490WC);
                CargarArbolRevursivo490WC(elementoSeleccionado490WC, nodo490WC);
            }
        }
        public void EjecutarModificacion490WC(string queModificar490WC)
        {
            if (queModificar490WC == "Rol")
            {
                PrepararArbolVistaPreviaModificar490WC("Rol");

            }
            else if (queModificar490WC == "Familia")
            {
                PrepararArbolVistaPreviaModificar490WC("Familia");
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
            else
            {
                MessageBox.Show("Debes Elegir un Rol o Familia Para Eliminarlos!!");
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
                            LlenarFamilias490WC();
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
                                LlenarFamilias490WC();
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
            ActivarModificacion490WC(true);
            LlenarFamilias490WC();
            LlenarPermisosSimples490WC();
        }

        private void RB_SIMPLE490WC_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarCarga490WC();
        }
    }
}
