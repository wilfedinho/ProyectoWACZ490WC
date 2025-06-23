using Microsoft.VisualBasic;
using SE490WC;
using SERVICIOS490WC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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



        public FormPermisos490WC()
        {
            InitializeComponent();
            HabilitarCarga490WC();
            CargarComboBox490WC();
            CargarTodasLasFamiliasEnArbol490WC();
            CargarTodosLosPerfilesEnArbol490WC();
        }

        public void CargarComboBox490WC()
        {
            CB_PermisoCompuesto490WC.Items.Clear();
            GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
            foreach (Permiso490WC permi490WC in gestorPermiso490WC.ObtenerRoles490WC())
            {
                if (permi490WC.obtenerPermisoNombre490WC() != SesionManager490WC.GestorSesion490WC.Usuario490WC.Rol490WC)
                {
                    CB_PermisoCompuesto490WC.Items.Add(permi490WC.obtenerPermisoNombre490WC());
                }
            }
            foreach (Permiso490WC permi490WC in gestorPermiso490WC.ObtenerPermisosCompuestos490WC())
            {
                if (!CB_PermisoCompuesto490WC.Items.Contains(permi490WC.obtenerPermisoNombre490WC()))
                {
                    CB_PermisoCompuesto490WC.Items.Add(permi490WC.obtenerPermisoNombre490WC());
                }
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
                CargarArbolRevursivo490WC(permi490WC,nodo490WC);
            }
        }
        public void CargarArbolRevursivo490WC(Permiso490WC permisoPadre490WC,TreeNode nodoPadre490WC)
        {
            if (permisoPadre490WC is PermisoCompuesto490WC permisoPadreCompuesto490WC)
            {
               foreach (Permiso490WC permi490WC in permisoPadreCompuesto490WC.PermisosIncluidos490WC())
               {
                    var nodoAgregar490WC = new TreeNode(permi490WC.obtenerPermisoNombre490WC());
                    nodoPadre490WC.Nodes.Add(nodoAgregar490WC);
                    if (permi490WC is PermisoCompuesto490WC)
                    {
                        CargarArbolRevursivo490WC(permi490WC,nodoAgregar490WC);
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

        }

        private void BT_CrearFamilia490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_Modificar490WC_Click(object sender, EventArgs e)
        {
            if (CB_PermisoCompuesto490WC.SelectedIndex > -1)
            {

            }
        }

        private void BT_ELIMINAR490WC_Click(object sender, EventArgs e)
        {

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
