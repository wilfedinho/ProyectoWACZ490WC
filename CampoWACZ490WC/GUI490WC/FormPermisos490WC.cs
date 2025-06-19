using Microsoft.VisualBasic;
using SE490WC;
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
    public partial class FormPermisos490WC : Form
    {
        string adminRolNombre490WC = "AdminSistema";

        public FormPermisos490WC()
        {
            InitializeComponent();
            RecargarTodasLasVistas490WC();
        }
        #region Carga del Formulario
        private void RecargarTodasLasVistas490WC()
        {
            CB_Familias.SelectedIndex = -1;
            CargarPermisos490WC();
            CargarArbol490WC();
            CargarFamilias490WC();
        }
        public void CargarPermisos490WC()
        {
            listaPermisos490WC.Items.Clear();
            PermisoBLL490WC GestorPermiso490WC = new PermisoBLL490WC();
            var permisos490WC = GestorPermiso490WC.ObtenerTodoSinRoles490WC();
            listaPermisos490WC.Items.AddRange(permisos490WC.Select(p => p.obtenerPermisoNombre490WC()).Where(nombre => nombre != adminRolNombre490WC).ToArray());
        }


        public void CargarArbol490WC()
        {
            vistaPermisosArbol.Nodes.Clear();
            PermisoBLL490WC GestorPermiso490WC = new PermisoBLL490WC();
            var permisosRaiz490WC = GestorPermiso490WC.ObtenerPermisosArbol490WC();
            foreach (var permiso490WC in permisosRaiz490WC)
            {
                var nodo490WC = new TreeNode(permiso490WC.obtenerPermisoNombre490WC());
                vistaPermisosArbol.Nodes.Add(nodo490WC);
                if (permiso490WC is PermisoCompuesto490WC permisoCompuesto490WC)
                {
                    CargarArbolRecursivo490WC((PermisoCompuesto490WC)permisoCompuesto490WC, nodo490WC);
                }
            }
        }

        public void CargarArbolRecursivo490WC(PermisoCompuesto490WC permisoActual490WC, TreeNode nodoPadre490WC)
        {
            foreach (var permiso490WC in permisoActual490WC.PermisosIncluidos490WC())
            {
                var nodoInterno490WC = new TreeNode(permiso490WC.obtenerPermisoNombre490WC());
                nodoPadre490WC.Nodes.Add(nodoInterno490WC);
                if (permiso490WC is PermisoCompuesto490WC permisoCompuesto490WC)
                {
                    CargarArbolRecursivo490WC(permisoCompuesto490WC, nodoInterno490WC);
                }
            }
        }
        public void CargarFamilias490WC()
        {
            CB_Familias.Items.Clear();
            PermisoBLL490WC GestorPermiso490WC = new PermisoBLL490WC();
            var permisosCompuestos490WC = GestorPermiso490WC.ObtenerPermisosCompuestos490WC();
            CB_Familias.Items.AddRange(permisosCompuestos490WC.Select(p => p.obtenerPermisoNombre490WC()).Where(nombre => nombre != "AdminSistema").ToArray());
        }


        #endregion


        #region Comportamiento del Combobox Familia

        private void CB_Familias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Familias.SelectedItem != null)
            {
                if (CB_Familias.SelectedItem.ToString() == SesionManager490WC.GestorSesion490WC.Usuario490WC.Rol490WC)
                {
                    MessageBox.Show("labelErrorRolSesion.Text");
                    CB_Familias.SelectedIndex = -1;
                }
                else
                {
                    LimpiarTodasSeleccionesPermisos490WC();
                    if (CB_Familias.SelectedItem != null)
                    {
                        PermisoBLL490WC GestorPermiso490WC = new PermisoBLL490WC();
                        List<Permiso490WC> permisosRaices490WC = GestorPermiso490WC.ObtenerPermisosArbol490WC();
                        Permiso490WC seleccionado490WC = permisosRaices490WC.Find(x => x.obtenerPermisoNombre490WC() == CB_Familias.SelectedItem.ToString());
                        if (seleccionado490WC is PermisoCompuesto490WC permisoCompuesto490WC)
                        {
                            ChequearPermisosEnLista490WC(permisoCompuesto490WC);
                        }
                    }
                }
            }
        }
        public void ChequearPermisosEnLista490WC(PermisoCompuesto490WC Raiz490WC)
        {
            foreach (Permiso490WC p490WC in Raiz490WC.PermisosIncluidos490WC())
            {
                int indice490WC = listaPermisos490WC.Items.IndexOf(p490WC.obtenerPermisoNombre490WC());
                if (indice490WC != -1)
                {
                    listaPermisos490WC.SetItemChecked(indice490WC, true);
                }
                if (p490WC is PermisoCompuesto490WC permisoCompuesto490WC)
                {
                    ChequearPermisosEnLista490WC(permisoCompuesto490WC);
                }
            }

        }


        public void LimpiarTodasSeleccionesPermisos490WC()
        {
            for (int i490WC = 0; i490WC < listaPermisos490WC.Items.Count; i490WC++)
            {
                listaPermisos490WC.SetItemChecked(i490WC, false);
            }
        }
        #endregion


        #region Botones

        public void CrearPermisoCompuesto490WC(string nombrePermiso490WC, bool esRol490WC)
        {
            List<string> items490WC = GenerarLista490WC();
            PermisoBLL490WC GestorPermiso490WC = new PermisoBLL490WC();
            if (GestorPermiso490WC.AgregarPermisoCompuesto490WC(nombrePermiso490WC, items490WC, true) == false)
            {
                MessageBox.Show("labelErrorPermisoDuplicado.Text");
            }
            else
            {
                MessageBox.Show("labelPermisoCreado.Text");
            }
        }


        public List<string> GenerarLista490WC()
        {
            List<string> items490WC = new List<string>();
            foreach (var CI490WC in listaPermisos490WC.CheckedItems)
            {
                items490WC.Add(CI490WC.ToString());
            }
            return items490WC;

        }
        private void BT_ElimiarSeleccionado_Click(object sender, EventArgs e)
        {
            if (CB_Familias.SelectedItem.ToString() == adminRolNombre490WC)
            {
                MessageBox.Show("labelNoSePuedeSeleccionarElRolAdmin.Text");
            }
            else
            {
                string cuestion490WC = "labelDeseaBorrarLaFamilia.Text";
                cuestion490WC = cuestion490WC.Replace("{CB_Familias.SelectedItem.ToString()}", CB_Familias.SelectedItem.ToString());
                DialogResult resultado490WC = MessageBox.Show(cuestion490WC, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado490WC == DialogResult.Yes)
                {
                    PermisoBLL490WC GestorPermiso490WC = new PermisoBLL490WC();
                    if (GestorPermiso490WC.BorrarPermiso490WC(CB_Familias.SelectedItem.ToString()) == true)
                    {
                        
                    }
                    RecargarTodasLasVistas490WC();
                }
            }
        }


        #endregion

        private void BT_ModificarNombre_Click(object sender, EventArgs e)
        {
            if (CB_Familias.SelectedItem.ToString() == adminRolNombre490WC)
            {
                MessageBox.Show("labelNoSePuedeSeleccionarElRolAdmin.Text");
            }
            else
            {
                string nuevoNombre490WC = Interaction.InputBox("labelIngreseElNuevoNombre.Text");
                if (!(nuevoNombre490WC == null || string.IsNullOrEmpty(nuevoNombre490WC) || string.IsNullOrWhiteSpace(nuevoNombre490WC)))
                {
                    PermisoBLL490WC GestorPermiso490WC = new PermisoBLL490WC();
                    GestorPermiso490WC.ModificarPermiso490WC(CB_Familias.SelectedItem.ToString(), nuevoNombre490WC);
                    RecargarTodasLasVistas490WC();
               
                }


            }
        }

        private void BT_CrearRol_Click(object sender, EventArgs e)
        {
            if (TB_NuevoNombre.Text == "" || TB_NuevoNombre.Text == null)
            {
            }
            else
            {
             
                CrearPermisoCompuesto490WC(TB_NuevoNombre.Text, true);
                RecargarTodasLasVistas490WC();
            }
            TB_NuevoNombre.Clear();
        }

        private void BT_CrearGrupoDePermisos_Click(object sender, EventArgs e)
        {
            if (TB_NuevoNombre.Text == "" || TB_NuevoNombre.Text == null)
            {
            }
            else
            {
         
                CrearPermisoCompuesto490WC(TB_NuevoNombre.Text, false);
                RecargarTodasLasVistas490WC();
            }
        }

        private void BT_GuardarCambios_Click(object sender, EventArgs e)
        {
            if (CB_Familias.Text == "")
            {
            }
            else
            {
                DialogResult resultado490WC = MessageBox.Show("", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado490WC == DialogResult.Yes)
                {
                    List<string> items490WC = GenerarLista490WC();
                    if (items490WC.Contains(CB_Familias.Text))
                    {
                    }
                    PermisoBLL490WC GestorPermiso490WC = new PermisoBLL490WC();
                    if (GestorPermiso490WC.ModificarPermisoCompuesto490WC(CB_Familias.Text, items490WC))
                    {
                    
                    }
                    RecargarTodasLasVistas490WC();
                }

            }
        }

    }
}
