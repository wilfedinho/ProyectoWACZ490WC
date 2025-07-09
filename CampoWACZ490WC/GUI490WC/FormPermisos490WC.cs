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
    public partial class FormPermisos490WC : Form, iObserverLenguaje490WC
    {


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
            HabilitarCB490WC();
            ActualizarLenguaje490WC();
        }


        public void CargarComboBoxRol490WC()
        {
            CB_ROL490WC.Items.Clear();
            GestorPermiso490WC gestorPermiso = new GestorPermiso490WC();

            string nombreRolSesion = SesionManager490WC.GestorSesion490WC.Usuario490WC.Rol490WC;


            if (nombreRolSesion == "AdminSistema")
            {
                foreach (Permiso490WC rol in gestorPermiso.ObtenerRoles490WC())
                {
                    if (rol.obtenerPermisoNombre490WC() != "AdminSistema")
                    {
                        CB_ROL490WC.Items.Add(rol.obtenerPermisoNombre490WC());
                    }
                }
                return;
            }


            var familiasDelRolActual = new HashSet<string>(
                ObtenerNombresDeFamiliasEnEstructura(SesionManager490WC.GestorSesion490WC.permisosDeLaSesion490WC)
            );


            foreach (PermisoCompuesto490WC rolVacio490WC in gestorPermiso.ObtenerRoles490WC())
            {
                PermisoCompuesto490WC otroRol = gestorPermiso.LeerRolConEstructura490WC(rolVacio490WC.obtenerPermisoNombre490WC());



                string nombreOtroRol = otroRol.obtenerPermisoNombre490WC();

                if (nombreOtroRol == nombreRolSesion)
                    continue;

                var familiasDelOtroRol = new HashSet<string>(
                    ObtenerNombresDeFamiliasEnEstructura(otroRol)
                );

                bool haySolapamiento = familiasDelOtroRol.Any(f => familiasDelRolActual.Contains(f));
                if (!haySolapamiento)
                {
                    CB_ROL490WC.Items.Add(nombreOtroRol);
                }
            }
        }

        public List<string> ObtenerNombresDeFamiliasEnEstructura(PermisoCompuesto490WC estructura)
        {
            List<string> nombresFamilias = new List<string>();
            RecorrerFamilias(estructura, nombresFamilias);
            return nombresFamilias;
        }

        private void RecorrerFamilias(PermisoCompuesto490WC nodo, List<string> acumulador)
        {
            if (!acumulador.Contains(nodo.obtenerPermisoNombre490WC()))
                acumulador.Add(nodo.obtenerPermisoNombre490WC());

            foreach (var hijo in nodo.PermisosIncluidos490WC())
            {
                if (hijo is PermisoCompuesto490WC familia)
                {
                    RecorrerFamilias(familia, acumulador);
                }
            }
        }

        public void CargarComboboxFamilia490WC()
        {
            CB_FAMILIA490WC.Items.Clear();
            GestorPermiso490WC gestorPermiso = new GestorPermiso490WC();


            if (SesionManager490WC.GestorSesion490WC.Usuario490WC.Rol490WC == "AdminSistema")
            {
                foreach (PermisoCompuesto490WC familia in gestorPermiso.ObtenerPermisosCompuestos490WC())
                {
                    CB_FAMILIA490WC.Items.Add(familia.obtenerPermisoNombre490WC());
                }
                return;
            }


            var familiasDelRolActual = new HashSet<string>(
                ObtenerNombresDeFamiliasEnEstructura(SesionManager490WC.GestorSesion490WC.permisosDeLaSesion490WC)
            );

            foreach (PermisoCompuesto490WC familia in gestorPermiso.ObtenerPermisosCompuestos490WC())
            {
                if (!familiasDelRolActual.Contains(familia.obtenerPermisoNombre490WC()))
                {
                    CB_FAMILIA490WC.Items.Add(familia.obtenerPermisoNombre490WC());
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
                nodoAgregar490WC.Tag = "Simple";
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
                                string mensajeOperacion = Traductor490WC.TraductorSG490WC.Traducir490WC("CreacionRol");
                                MessageBox.Show(mensajeOperacion);
                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("CreacionRolFracasada");
                                MessageBox.Show(mensajeError);
                            }
                        }
                        else
                        {
                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("CreacionRolVacio");
                            MessageBox.Show(mensajeError);
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
                                string mensajeOperacion = Traductor490WC.TraductorSG490WC.Traducir490WC("CreacionRol");
                                MessageBox.Show(mensajeOperacion);
                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("CreacionRolFracasada");
                                MessageBox.Show(mensajeError);
                            }
                        }
                        else
                        {
                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("CreacionRolVacio");
                            MessageBox.Show(mensajeError);
                        }
                    }
                }
                else
                {
                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("NombreRolDUPLICADO");
                    MessageBox.Show(mensajeError);
                }

            }
            else
            {
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("NombreRolVacio");
                MessageBox.Show(mensajeError);
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
                                string mensajeOperacion = Traductor490WC.TraductorSG490WC.Traducir490WC("CreacionFamiliaExitosa");
                                MessageBox.Show(mensajeOperacion);
                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("CreacionFamiliaFracasada");
                                MessageBox.Show(mensajeError);
                            }
                        }
                        else
                        {
                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("CreacionFamiliaVacia");
                            MessageBox.Show(mensajeError);
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
                                string mensajeOperacion = Traductor490WC.TraductorSG490WC.Traducir490WC("CreacionFamiliaExitosa");
                                MessageBox.Show(mensajeOperacion);
                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("CreacionFamiliaFracasada");
                                MessageBox.Show(mensajeError);
                            }
                        }
                        else
                        {
                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("CreacionFamiliaVacia");
                            MessageBox.Show(mensajeError);
                        }
                    }
                }
                else
                {
                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("NombreFamiliaDUPLICADO");
                    MessageBox.Show(mensajeError);
                }

            }
            else
            {
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("NombreFamiliaVacia");
                MessageBox.Show(mensajeError);
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
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorElegirFamiliaRol");
                MessageBox.Show(mensajeError);
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
                BT_CrearFamilia490WC.Enabled = false;
                BT_CrearRol490WC.Enabled = false;
                TB_FAMILIA490WC.Enabled = false;
                TB_ROL490WC.Enabled = false;
                BT_Modificar490WC.Enabled = false;
                BT_ELIMINAR490WC.Enabled = false;
                RB_CBFAMILIA490WC.Enabled = false;
                RB_CBROLES490WC.Enabled = false;
            }
            else
            {
                BT_ASIGNAR490WC.Enabled = false;
                BT_DESASIGNAR490WC.Enabled = false;
                BT_GUARDARCAMBIOS490WC.Enabled = false;
                CB_FAMILIA490WC.Enabled = true;
                CB_ROL490WC.Enabled = true;
                BT_CrearFamilia490WC.Enabled = true;
                BT_CrearRol490WC.Enabled = true;
                TB_FAMILIA490WC.Enabled = true;
                TB_ROL490WC.Enabled = true;
                BT_Modificar490WC.Enabled = true;
                BT_ELIMINAR490WC.Enabled = true;
                RB_CBFAMILIA490WC.Enabled = true;
                RB_CBROLES490WC.Enabled = true;
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

                var nombresEnSeleccionado = new HashSet<string>(
                    gestorPermisos490WC.ObtenerNombresDePermisos490WC(compuestoSeleccionado)
                );


                foreach (PermisoCompuesto490WC familiaCandidata in gestorPermisos490WC.LeerFamiliasConEstructuraRecursiva490WC())
                {
                    string nombreCandidata = familiaCandidata.obtenerPermisoNombre490WC();


                    if (nombreCandidata == compuestoSeleccionado.obtenerPermisoNombre490WC())
                        continue;


                    var nombresDeLaCandidata = gestorPermisos490WC.ObtenerNombresDePermisos490WC(familiaCandidata);


                    bool haySolapamiento = nombresDeLaCandidata.Any(nombre => nombresEnSeleccionado.Contains(nombre));

                    if (!haySolapamiento)
                    {
                        listboxFamilia490WC.Items.Add(nombreCandidata);
                    }
                }
            }
        }

        public void CargarArbolPrevioModificar490WC(string queModificamos490WC)
        {

            if (queModificamos490WC == "Rol")
            {
                treeViewPreviaModificacion490WC.Nodes.Clear();
                GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
                elementoSeleccionado490WC = gestorPermiso490WC.LeerPermisoCompuesto490WC(CB_ROL490WC.SelectedItem.ToString());
                var nodo490WC = new TreeNode(elementoSeleccionado490WC.obtenerPermisoNombre490WC());
                nodo490WC.Tag = "Rol";
                treeViewPreviaModificacion490WC.Nodes.Add(nodo490WC);
                CargarArbolRecursivoParaModificar490WC(elementoSeleccionado490WC, nodo490WC);
            }
            else if (queModificamos490WC == "Familia")
            {
                treeViewPreviaModificacion490WC.Nodes.Clear();
                GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
                elementoSeleccionado490WC = gestorPermiso490WC.LeerFamiliasConEstructuraRecursiva490WC().Find(x => x.obtenerPermisoNombre490WC() == CB_FAMILIA490WC.SelectedItem.ToString());
                var nodo490WC = new TreeNode(elementoSeleccionado490WC.obtenerPermisoNombre490WC());
                nodo490WC.Tag = "Familia";
                treeViewPreviaModificacion490WC.Nodes.Add(nodo490WC);
                CargarArbolRecursivoParaModificar490WC(elementoSeleccionado490WC, nodo490WC);
            }
        }

        public void CargarArbolRecursivoParaModificar490WC(Permiso490WC permisoPadre490WC, TreeNode nodoPadre490WC)
        {

            if (permisoPadre490WC is PermisoCompuesto490WC permisoPadreCompuesto490WC)
            {
                foreach (Permiso490WC permi490WC in permisoPadreCompuesto490WC.PermisosIncluidos490WC())
                {
                    if (permi490WC is PermisoCompuesto490WC)
                    {
                        var nodoAgregar490WC = new TreeNode(permi490WC.obtenerPermisoNombre490WC());
                        nodoAgregar490WC.Tag = "Familia";
                        nodoPadre490WC.Nodes.Add(nodoAgregar490WC);
                        if (permi490WC is PermisoCompuesto490WC)
                        {

                            CargarArbolRecursivoParaModificar490WC(permi490WC, nodoAgregar490WC);
                        }
                    }
                    else
                    {
                        var nodoAgregar490WC = new TreeNode(permi490WC.obtenerPermisoNombre490WC());
                        nodoAgregar490WC.Tag = "Simple";
                        nodoPadre490WC.Nodes.Add(nodoAgregar490WC);
                    }

                }
            }
            else
            {
                var nodoAgregar490WC = new TreeNode(permisoPadre490WC.obtenerPermisoNombre490WC());
                nodoAgregar490WC.Tag = "Simple";
                nodoPadre490WC.Nodes.Add(nodoAgregar490WC);
            }
        }




        public void EjecutarModificacion490WC(string queModificar490WC)
        {
            if (queModificar490WC == "Rol")
            {

                CargarArbolPrevioModificar490WC("Rol");
            }
            else if (queModificar490WC == "Familia")
            {

                CargarArbolPrevioModificar490WC("Familia");
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
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorElegirFamiliaRolEliminar");
                MessageBox.Show(mensajeError);
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
                            string mensajeOperacion = Traductor490WC.TraductorSG490WC.Traducir490WC("EliminacionExitosa");
                            MessageBox.Show(mensajeOperacion);
                            CargarComboBoxRol490WC();
                            CargarComboboxFamilia490WC();
                            CargarTodasLasFamiliasEnArbol490WC();
                            CargarTodosLosPerfilesEnArbol490WC();
                            LlenarFamilias490WC();
                            CB_ROL490WC.SelectedIndex = -1;
                        }
                        else
                        {
                            string mensajeOperacion = Traductor490WC.TraductorSG490WC.Traducir490WC("EliminacionFracasada");
                            MessageBox.Show(mensajeOperacion);
                            CB_ROL490WC.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorEliminarRolAsignadoUsuario");
                        MessageBox.Show(mensajeError);
                        CB_ROL490WC.SelectedIndex = -1;
                    }
                }
                else
                {
                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorElegirFamiliaRolEliminar");
                    MessageBox.Show(mensajeError);
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
                                string mensajeOperacion = Traductor490WC.TraductorSG490WC.Traducir490WC("EliminacionExitosa");
                                MessageBox.Show(mensajeOperacion);
                                CargarComboBoxRol490WC();
                                CargarComboboxFamilia490WC();
                                CargarTodasLasFamiliasEnArbol490WC();
                                CargarTodosLosPerfilesEnArbol490WC();
                                LlenarFamilias490WC();
                                CB_ROL490WC.SelectedIndex = -1;
                            }
                            else
                            {
                                string mensajeOperacion = Traductor490WC.TraductorSG490WC.Traducir490WC("EliminacionFracasada");
                                MessageBox.Show(mensajeOperacion);
                                CB_FAMILIA490WC.SelectedIndex = -1;
                            }
                        }
                        else
                        {
                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorEliminarFamiliaAsignadaFamilia");
                            MessageBox.Show(mensajeError);
                            CB_FAMILIA490WC.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorEliminarFamiliaAsignadaUsuario");
                        MessageBox.Show(mensajeError);
                        CB_FAMILIA490WC.SelectedIndex = -1;
                    }
                }
                else
                {
                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorElegirFamiliaRolEliminar");
                    MessageBox.Show(mensajeError);
                    CB_FAMILIA490WC.SelectedIndex = -1;
                }
            }
        }
        private void BT_ASIGNAR490WC_Click(object sender, EventArgs e)
        {
            GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
            if (RB_CBFAMILIA490WC.Checked)
            {
                if (treeViewPreviaModificacion490WC.SelectedNode != null)
                {
                    if (RB_SIMPLE490WC.Checked)
                    {
                        if (listboxPermisoSimple490WC.SelectedItem != null)
                        {

                            Permiso490WC permisoSimpleAsignar490WC = new PermisoSimple490WC(listboxPermisoSimple490WC.SelectedItem.ToString());

                            if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Familia" && treeViewPreviaModificacion490WC.SelectedNode.Text == CB_FAMILIA490WC.SelectedItem.ToString())
                            {
                                string nombreFamiliaSeleccionado490WC = treeViewPreviaModificacion490WC.SelectedNode.Text;
                                Permiso490WC PermisoDelNivelSeleccionado490WC = gestorPermiso490WC.LeerFamiliasConEstructuraRecursiva490WC().Find(x => x.obtenerPermisoNombre490WC() == nombreFamiliaSeleccionado490WC);
                                if (PermisoDelNivelSeleccionado490WC != null)
                                {
                                    if ((PermisoDelNivelSeleccionado490WC as PermisoCompuesto490WC).VerificarPermisoIncluido490WC(PermisoDelNivelSeleccionado490WC, permisoSimpleAsignar490WC.obtenerPermisoNombre490WC()) == false)
                                    {
                                        if (gestorPermiso490WC.InsertarRelacionDesdeFamilia490WC(PermisoDelNivelSeleccionado490WC.obtenerPermisoNombre490WC(), permisoSimpleAsignar490WC.obtenerPermisoNombre490WC()))
                                        {
                                            elementoSeleccionado490WC = gestorPermiso490WC.LeerFamiliasConEstructuraRecursiva490WC().Find(x => x.obtenerPermisoNombre490WC() == elementoSeleccionado490WC.obtenerPermisoNombre490WC());
                                            CargarTodasLasFamiliasEnArbol490WC();
                                            CargarTodosLosPerfilesEnArbol490WC();
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
                                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorSeleccionarFamiliaRolModificar");
                                                MessageBox.Show(mensajeError);
                                            }
                                        }
                                        
                                    }
                                    else
                                    {
                                        
                                    }
                                }
                            }
                            else if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Simple")
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorAgregarAlgoAPermisoSimple");
                                MessageBox.Show(mensajeError);
                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorModificarSubfamilia");
                                MessageBox.Show(mensajeError);
                            }

                        }
                        else
                        {
                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorSeleccionarPermisoSimple");
                            MessageBox.Show(mensajeError);
                        }

                    }
                    else
                    {
                        if (listboxFamilia490WC.SelectedItem != null)
                        {
                            Permiso490WC FamiliaAsignar490WC = gestorPermiso490WC.LeerFamiliasConEstructuraRecursiva490WC().Find(x => x.obtenerPermisoNombre490WC() == listboxFamilia490WC.SelectedItem.ToString());

                            if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Familia" && treeViewPreviaModificacion490WC.SelectedNode.Text == CB_FAMILIA490WC.SelectedItem.ToString())
                            {
                                string nombreFamiliaSeleccionado490WC = treeViewPreviaModificacion490WC.SelectedNode.Text;
                                Permiso490WC PermisoDelNivelSeleccionado490WC = gestorPermiso490WC.LeerFamiliasConEstructuraRecursiva490WC().Find(x => x.obtenerPermisoNombre490WC() == nombreFamiliaSeleccionado490WC);
                                if (PermisoDelNivelSeleccionado490WC != null)
                                {
                                    if ((PermisoDelNivelSeleccionado490WC as PermisoCompuesto490WC).VerificarPermisoIncluido490WC(PermisoDelNivelSeleccionado490WC, FamiliaAsignar490WC.obtenerPermisoNombre490WC()) == false)
                                    {
                                        if (gestorPermiso490WC.InsertarRelacionDesdeFamilia490WC(PermisoDelNivelSeleccionado490WC.obtenerPermisoNombre490WC(), FamiliaAsignar490WC.obtenerPermisoNombre490WC()))
                                        {
                                            elementoSeleccionado490WC = gestorPermiso490WC.LeerFamiliasConEstructuraRecursiva490WC().Find(x => x.obtenerPermisoNombre490WC() == elementoSeleccionado490WC.obtenerPermisoNombre490WC());
                                            CargarTodasLasFamiliasEnArbol490WC();
                                            CargarTodosLosPerfilesEnArbol490WC();
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
                                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorSeleccionarFamiliaRolModificar");
                                                MessageBox.Show(mensajeError);
                                            }
                                        }
                                        
                                    }
                                    else
                                    {
                                        
                                    }
                                }
                            }
                            else if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Simple")
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorAgregarAlgoAPermisoSimple");
                                MessageBox.Show(mensajeError);
                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorModificarSubfamilia");
                                MessageBox.Show(mensajeError);
                            }

                        }
                        else
                        {
                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorSeleccionarFamilia");
                            MessageBox.Show(mensajeError);
                        }
                    }
                }
                else
                {

                }
            }
            else
            {
                if (treeViewPreviaModificacion490WC.SelectedNode != null)
                {
                    if (RB_SIMPLE490WC.Checked)
                    {
                        if (listboxPermisoSimple490WC.SelectedItem != null)
                        {
                            Permiso490WC permisoSimpleAsignar490WC = new PermisoSimple490WC(listboxPermisoSimple490WC.SelectedItem.ToString());
                            if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Rol")
                            {
                                string nombrePerfilSeleccionado490WC = treeViewPreviaModificacion490WC.SelectedNode.Text;
                                Permiso490WC PermisoDelNivelSeleccionado490WC = gestorPermiso490WC.LeerRolConEstructura490WC(nombrePerfilSeleccionado490WC);
                                if (PermisoDelNivelSeleccionado490WC != null)
                                {
                                    if ((PermisoDelNivelSeleccionado490WC as PermisoCompuesto490WC).VerificarPermisoIncluido490WC(PermisoDelNivelSeleccionado490WC, permisoSimpleAsignar490WC.obtenerPermisoNombre490WC()) == false)
                                    {
                                        if (gestorPermiso490WC.InsertarRelacionDesdePerfil490WC(PermisoDelNivelSeleccionado490WC.obtenerPermisoNombre490WC(), permisoSimpleAsignar490WC.obtenerPermisoNombre490WC()))
                                        {
                                            elementoSeleccionado490WC = gestorPermiso490WC.LeerRolConEstructura490WC(elementoSeleccionado490WC.obtenerPermisoNombre490WC());
                                            CargarTodasLasFamiliasEnArbol490WC();
                                            CargarTodosLosPerfilesEnArbol490WC();
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
                                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorSeleccionarFamiliaRolModificar");
                                                MessageBox.Show(mensajeError);
                                            }
                                          
                                        }
                                    }
                                    else
                                    {
                                      
                                    }
                                }
                            }
                            else if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Familia")
                            {

                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorModificarSubfamilia");
                                MessageBox.Show(mensajeError);
                            }
                            else if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Simple")
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorAgregarAlgoAPermisoSimple");
                                MessageBox.Show(mensajeError);
                            }

                        }
                        else
                        {
                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorSeleccionarPermisoSimple");
                            MessageBox.Show(mensajeError);
                        }
                    }
                    else
                    {
                        if (listboxFamilia490WC.SelectedItem != null)
                        {
                            Permiso490WC FamiliaAsignar490WC = gestorPermiso490WC.LeerFamiliasConEstructuraRecursiva490WC().Find(x => x.obtenerPermisoNombre490WC() == listboxFamilia490WC.SelectedItem.ToString());
                            if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Rol")
                            {
                                string nombrePerfilSeleccionado490WC = treeViewPreviaModificacion490WC.SelectedNode.Text;
                                Permiso490WC PermisoDelNivelSeleccionado490WC = gestorPermiso490WC.LeerRolConEstructura490WC(nombrePerfilSeleccionado490WC);
                                if (PermisoDelNivelSeleccionado490WC != null)
                                {
                                    if ((PermisoDelNivelSeleccionado490WC as PermisoCompuesto490WC).VerificarPermisoIncluido490WC(PermisoDelNivelSeleccionado490WC, FamiliaAsignar490WC.obtenerPermisoNombre490WC()) == false)
                                    {
                                        if (gestorPermiso490WC.InsertarRelacionDesdePerfil490WC(PermisoDelNivelSeleccionado490WC.obtenerPermisoNombre490WC(), FamiliaAsignar490WC.obtenerPermisoNombre490WC()))
                                        {
                                            elementoSeleccionado490WC = gestorPermiso490WC.LeerRolConEstructura490WC(elementoSeleccionado490WC.obtenerPermisoNombre490WC());
                                            CargarTodasLasFamiliasEnArbol490WC();
                                            CargarTodosLosPerfilesEnArbol490WC();
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
                                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorSeleccionarFamiliaRolModificar");
                                                MessageBox.Show(mensajeError);
                                            }

                                        }
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                            else if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Familia")
                            {

                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorModificarSubfamilia");
                                MessageBox.Show(mensajeError);
                            }

                            else if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Simple")
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorAgregarAlgoAPermisoSimple");
                                MessageBox.Show(mensajeError);
                            }

                        }
                        else
                        {
                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorSeleccionarFamilia");
                            MessageBox.Show(mensajeError);
                        }
                    }
                }
                else
                {
                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorSeleccionarNodo");
                    MessageBox.Show(mensajeError);
                }
            }


        }

        private void BT_DESASIGNAR490WC_Click(object sender, EventArgs e)
        {
            GestorPermiso490WC gestorPermiso490WC = new GestorPermiso490WC();
            if (treeViewPreviaModificacion490WC.SelectedNode != null)
            {
                if (RB_CBFAMILIA490WC.Checked)
                {
                    PermisoCompuesto490WC familiaModificar490WC = gestorPermiso490WC.LeerFamiliasConEstructuraRecursiva490WC().Find(x => x.obtenerPermisoNombre490WC() == CB_FAMILIA490WC.SelectedItem.ToString());
                    if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Rol")
                    {
                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorDesasignarRol");
                        MessageBox.Show(mensajeError);
                    }
                    else if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Familia" && familiaModificar490WC.PermisosIncluidos490WC().Find(x => x.obtenerPermisoNombre490WC() == treeViewPreviaModificacion490WC.SelectedNode.Text) != null)
                    {
                        Permiso490WC FamiliaDesasignar490WC = gestorPermiso490WC.LeerFamiliasConEstructuraRecursiva490WC().Find(x => x.obtenerPermisoNombre490WC() == treeViewPreviaModificacion490WC.SelectedNode.Text);
                        Permiso490WC FamiliaPadreDesasignar490WC = gestorPermiso490WC.BuscarPadreDirecto490WC((PermisoCompuesto490WC)elementoSeleccionado490WC, FamiliaDesasignar490WC.obtenerPermisoNombre490WC());
                        if (FamiliaPadreDesasignar490WC != null)
                        {
                            if (gestorPermiso490WC.FamiliaQuedariaVaciaTrasEliminarElemento(FamiliaPadreDesasignar490WC.obtenerPermisoNombre490WC(), FamiliaDesasignar490WC.obtenerPermisoNombre490WC()) == false)
                            {
                                if (gestorPermiso490WC.EliminarRelacionFamilia_Familia(FamiliaPadreDesasignar490WC.obtenerPermisoNombre490WC(), FamiliaDesasignar490WC.obtenerPermisoNombre490WC()))
                                {
                                    elementoSeleccionado490WC = gestorPermiso490WC.LeerFamiliasConEstructuraRecursiva490WC().Find(x => x.obtenerPermisoNombre490WC() == elementoSeleccionado490WC.obtenerPermisoNombre490WC());
                                    CargarTodasLasFamiliasEnArbol490WC();
                                    CargarTodosLosPerfilesEnArbol490WC();
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
                                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorSeleccionarFamiliaRolModificar");
                                        MessageBox.Show(mensajeError);
                                    }
                                }
                                else
                                {
                                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorEjecutarDesasignacion");
                                    MessageBox.Show(mensajeError);
                                }

                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorFamiliaQuedariaVacia");
                                MessageBox.Show(mensajeError);
                            }

                        }
                        else
                        {
                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorDesasignarFamiliaModificando");
                            MessageBox.Show(mensajeError);
                        }


                    }
                    else if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Simple" && familiaModificar490WC.PermisosIncluidos490WC().Find(x => x.obtenerPermisoNombre490WC() == treeViewPreviaModificacion490WC.SelectedNode.Text) != null)
                    {
                        Permiso490WC permisoSimpleDesasignar490WC = gestorPermiso490WC.ObtenerPermisosSimples490WC().Find(x => x.obtenerPermisoNombre490WC() == treeViewPreviaModificacion490WC.SelectedNode.Text);
                        Permiso490WC PermisoPadreDesasignar490WC = gestorPermiso490WC.BuscarPadreDirecto490WC((PermisoCompuesto490WC)elementoSeleccionado490WC, permisoSimpleDesasignar490WC.obtenerPermisoNombre490WC());
                        if (gestorPermiso490WC.FamiliaQuedariaVaciaTrasEliminarElemento(PermisoPadreDesasignar490WC.obtenerPermisoNombre490WC(), permisoSimpleDesasignar490WC.obtenerPermisoNombre490WC()) == false)
                        {
                            if (gestorPermiso490WC.EliminarRelacionPermisoSimple_Familia(PermisoPadreDesasignar490WC.obtenerPermisoNombre490WC(), permisoSimpleDesasignar490WC.obtenerPermisoNombre490WC()))
                            {
                                elementoSeleccionado490WC = gestorPermiso490WC.LeerFamiliasConEstructuraRecursiva490WC().Find(x => x.obtenerPermisoNombre490WC() == elementoSeleccionado490WC.obtenerPermisoNombre490WC());
                                CargarTodasLasFamiliasEnArbol490WC();
                                CargarTodosLosPerfilesEnArbol490WC();
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

                                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorSeleccionarFamiliaRolModificar");
                                    MessageBox.Show(mensajeError);
                                }
                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorEjecutarDesasignacion");
                                MessageBox.Show(mensajeError);
                            }

                        }
                        else
                        {
                            string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorFamiliaQuedariaVacia");
                            MessageBox.Show(mensajeError);
                        }


                    }
                    else if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Familia" && familiaModificar490WC.obtenerPermisoNombre490WC() == treeViewPreviaModificacion490WC.SelectedNode.Text)
                    {
                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorDesasignarFamiliaModificando");
                        MessageBox.Show(mensajeError);
                    }
                    else
                    {
                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorModificarSubfamilia");
                        MessageBox.Show(mensajeError);
                    }
                    
                }
                else
                {
                    PermisoCompuesto490WC rolModificar490WC = gestorPermiso490WC.LeerRolConEstructura490WC(CB_ROL490WC.SelectedItem.ToString());
                    if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Rol")
                    {
                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorDesasignarRol");
                        MessageBox.Show(mensajeError);
                    }
                    else if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Familia" && rolModificar490WC.PermisosIncluidos490WC().Find(x => x.obtenerPermisoNombre490WC() == treeViewPreviaModificacion490WC.SelectedNode.Text) != null)
                    {
                        Permiso490WC FamiliaDesasignar490WC = gestorPermiso490WC.LeerFamiliasConEstructuraRecursiva490WC().Find(x => x.obtenerPermisoNombre490WC() == treeViewPreviaModificacion490WC.SelectedNode.Text);
                        Permiso490WC PermisoPadreDesasignar490WC = gestorPermiso490WC.BuscarPadreDirecto490WC((PermisoCompuesto490WC)elementoSeleccionado490WC, FamiliaDesasignar490WC.obtenerPermisoNombre490WC());
                        if (PermisoPadreDesasignar490WC != null || PermisoPadreDesasignar490WC.obtenerPermisoNombre490WC() != elementoSeleccionado490WC.obtenerPermisoNombre490WC())
                        {
                            if (gestorPermiso490WC.PerfilQuedariaVacioTrasEliminarElemento(PermisoPadreDesasignar490WC.obtenerPermisoNombre490WC(), FamiliaDesasignar490WC.obtenerPermisoNombre490WC()) == false)
                            {
                                if (gestorPermiso490WC.EliminarRelacionPerfil_Familia(PermisoPadreDesasignar490WC.obtenerPermisoNombre490WC(), FamiliaDesasignar490WC.obtenerPermisoNombre490WC()))
                                {
                                    elementoSeleccionado490WC = gestorPermiso490WC.LeerRolConEstructura490WC(elementoSeleccionado490WC.obtenerPermisoNombre490WC());
                                    CargarTodasLasFamiliasEnArbol490WC();
                                    CargarTodosLosPerfilesEnArbol490WC();
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
                                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorSeleccionarFamiliaRolModificar");
                                        MessageBox.Show(mensajeError);
                                    }
                                }
                                else
                                {
                                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorEjecutarDesasignacion");
                                    MessageBox.Show(mensajeError);
                                }

                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorRolQuedariaVacio");
                                MessageBox.Show(mensajeError);
                            }

                        }
                        else
                        {
                            if (gestorPermiso490WC.PerfilQuedariaVacioTrasEliminarElemento(elementoSeleccionado490WC.obtenerPermisoNombre490WC(), FamiliaDesasignar490WC.obtenerPermisoNombre490WC()) == false)
                            {
                                if (gestorPermiso490WC.EliminarRelacionPerfil_Familia(elementoSeleccionado490WC.obtenerPermisoNombre490WC(), FamiliaDesasignar490WC.obtenerPermisoNombre490WC()))
                                {
                                    elementoSeleccionado490WC = gestorPermiso490WC.LeerRolConEstructura490WC(elementoSeleccionado490WC.obtenerPermisoNombre490WC());
                                    CargarTodasLasFamiliasEnArbol490WC();
                                    CargarTodosLosPerfilesEnArbol490WC();
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
                                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorSeleccionarFamiliaRolModificar");
                                        MessageBox.Show(mensajeError);
                                    }
                                }
                                else
                                {
                                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorEjecutarDesasignacion");
                                    MessageBox.Show(mensajeError);
                                }

                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorRolQuedariaVacio");
                                MessageBox.Show(mensajeError);
                            }
                        }

                    }
                    else if (treeViewPreviaModificacion490WC.SelectedNode.Tag.ToString() == "Simple" && rolModificar490WC.PermisosIncluidos490WC().Find(x => x.obtenerPermisoNombre490WC() == treeViewPreviaModificacion490WC.SelectedNode.Text) != null)
                    {
                        Permiso490WC permisoSimpleDesasignar490WC = gestorPermiso490WC.ObtenerPermisosSimples490WC().Find(x => x.obtenerPermisoNombre490WC() == treeViewPreviaModificacion490WC.SelectedNode.Text);
                        Permiso490WC PermisoPadreDesasignar490WC = gestorPermiso490WC.BuscarPadreDirecto490WC((PermisoCompuesto490WC)elementoSeleccionado490WC, permisoSimpleDesasignar490WC.obtenerPermisoNombre490WC());
                        if (PermisoPadreDesasignar490WC != null)
                        {
                            if (gestorPermiso490WC.PerfilQuedariaVacioTrasEliminarElemento(PermisoPadreDesasignar490WC.obtenerPermisoNombre490WC(), permisoSimpleDesasignar490WC.obtenerPermisoNombre490WC()) == false)
                            {
                                if (gestorPermiso490WC.EliminarRelacionPermisoSimple_Perfil(PermisoPadreDesasignar490WC.obtenerPermisoNombre490WC(), permisoSimpleDesasignar490WC.obtenerPermisoNombre490WC()))
                                {
                                    elementoSeleccionado490WC = gestorPermiso490WC.LeerRolConEstructura490WC(elementoSeleccionado490WC.obtenerPermisoNombre490WC());
                                    CargarTodasLasFamiliasEnArbol490WC();
                                    CargarTodosLosPerfilesEnArbol490WC();
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
                                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorSeleccionarFamiliaRolModificar");
                                        MessageBox.Show(mensajeError);
                                    }
                                }
                                else
                                {
                                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorEjecutarDesasignacion");
                                    MessageBox.Show(mensajeError);
                                }

                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorRolQuedariaVacio");
                                MessageBox.Show(mensajeError);
                            }

                        }
                        else
                        {
                            if (gestorPermiso490WC.PerfilQuedariaVacioTrasEliminarElemento(elementoSeleccionado490WC.obtenerPermisoNombre490WC(), permisoSimpleDesasignar490WC.obtenerPermisoNombre490WC()) == false)
                            {
                                if (gestorPermiso490WC.EliminarRelacionPermisoSimple_Perfil(elementoSeleccionado490WC.obtenerPermisoNombre490WC(), permisoSimpleDesasignar490WC.obtenerPermisoNombre490WC()))
                                {
                                    elementoSeleccionado490WC = gestorPermiso490WC.LeerRolConEstructura490WC(elementoSeleccionado490WC.obtenerPermisoNombre490WC());
                                    CargarTodasLasFamiliasEnArbol490WC();
                                    CargarTodosLosPerfilesEnArbol490WC();
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
                                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorSeleccionarFamiliaRolModificar");
                                        MessageBox.Show(mensajeError);
                                    }
                                }
                                else
                                {
                                    string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorEjecutarDesasignacion");
                                    MessageBox.Show(mensajeError);
                                }

                            }
                            else
                            {
                                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorRolQuedariaVacio");
                                MessageBox.Show(mensajeError);
                            }
                        }

                    }
                    else
                    {
                        string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorModificarSubfamilia");
                        MessageBox.Show(mensajeError);
                    }
                }
                

            }
            else
            {
                string mensajeError = Traductor490WC.TraductorSG490WC.Traducir490WC("ErrorSeleccionarSimpleFamiliaDesasignar");
                MessageBox.Show(mensajeError);
            }

        }




        private void BT_GUARDARCAMBIOS490WC_Click(object sender, EventArgs e)
        {
            treeViewPreviaModificacion490WC.Nodes.Clear();
            CB_FAMILIA490WC.SelectedIndex = -1;
            CB_ROL490WC.SelectedIndex = -1;
            CargarComboboxFamilia490WC();
            CargarComboBoxRol490WC();
            ActivarModificacion490WC(false);
            LlenarFamilias490WC();
            LlenarPermisosSimples490WC();
            HabilitarCB490WC();
        }

        private void RB_SIMPLE490WC_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarCarga490WC();
        }
        public void HabilitarCB490WC()
        {
            if (RB_CBFAMILIA490WC.Checked)
            {
                CB_FAMILIA490WC.Enabled = true;
                CB_ROL490WC.Enabled = false;
                CB_ROL490WC.SelectedIndex = -1;
            }
            else
            {
                CB_FAMILIA490WC.Enabled = false;
                CB_ROL490WC.Enabled = true;
                CB_FAMILIA490WC.SelectedIndex = -1;
            }
        }
        private void CB_ROL490WC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RB_CBFAMILIA490WC_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarCB490WC();
        }

        private void FormPermisos490WC_FormClosed(object sender, FormClosedEventArgs e)
        {
            treeViewPreviaModificacion490WC.Nodes.Clear();
            CB_FAMILIA490WC.SelectedIndex = -1;
            CB_ROL490WC.SelectedIndex = -1;
            ActivarModificacion490WC(false);
            LlenarFamilias490WC();
            LlenarPermisosSimples490WC();
            HabilitarCB490WC();
        }

        public void ActualizarLenguaje490WC()
        {
            RecorrerControles490WC(this);
            
        }

        public void RecorrerControles490WC(Control control490WC)
        {
            foreach (Control c490WC in control490WC.Controls)
            {
                if ((c490WC is TextBox tb490WC) == false)
                {

                    c490WC.Text = Traductor490WC.TraductorSG490WC.Traducir490WC(c490WC.Name);


                    if (c490WC.HasChildren)
                    {
                        RecorrerControles490WC(c490WC);
                    }
                    if (c490WC is DataGridView dgv490WC)
                    {
                        foreach (DataGridViewColumn columna490WC in dgv490WC.Columns)
                        {
                            columna490WC.HeaderText = Traductor490WC.TraductorSG490WC.Traducir490WC(columna490WC.Name);
                        }
                    }

                }
            }
        }
    }
}
