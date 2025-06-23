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
            LlenarPermisosSimples490WC();
            LlenarFamilias490WC();
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
    }
}
