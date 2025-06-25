using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI490WC
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo culturaForzada = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = culturaForzada;
            Thread.CurrentThread.CurrentUICulture = culturaForzada;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            GestorForm490WC.gestorFormSG490WC.DefinirEstado490WC(new EstadoIniciarSesion490WC());
        }
    }
}
