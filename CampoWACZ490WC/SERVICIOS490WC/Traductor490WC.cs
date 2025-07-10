using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SERVICIOS490WC
{
    public class Traductor490WC
    {
        public static Traductor490WC Instance490WC;
        public static Traductor490WC TraductorSG490WC
        {
            get
            {
                if (Instance490WC == null)
                {
                    Instance490WC = new Traductor490WC();
                }
                return Instance490WC;
            }
        }
        List<iObserverLenguaje490WC> ListaFormularios490WC = new List<iObserverLenguaje490WC>();
        Dictionary<string, string> Lenguaje490WC = new Dictionary<string, string>();

        string jsonFilePath490WC;
        public void CargarTraducciones490WC(string nuevoLenguaje490WC)
        {

            if (File.Exists(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lenguajes", $"{nuevoLenguaje490WC}.json"))))
            {
                jsonFilePath490WC = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lenguajes", $"{nuevoLenguaje490WC}.json"));
                string jsonContent490WC = File.ReadAllText(jsonFilePath490WC);
                Lenguaje490WC.Clear();
                Lenguaje490WC = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonContent490WC);
            }
        }

        public List<string> DevolverIdiomasDisponibles490WC()
        {
            List<string> ListaIdiomas490WC = new List<string>();
            
            string rutaBase = AppDomain.CurrentDomain.BaseDirectory;
            string rutaLenguajes = Path.Combine(rutaBase, "Lenguajes");
            string[] archivos490WC = Directory.GetFiles(rutaLenguajes, "*.json");


            List<string> nombresDeIdiomas490WC = archivos490WC
                .Select(archivo => Path.GetFileNameWithoutExtension(archivo))
                .ToList();

            return nombresDeIdiomas490WC;

        }

        public void Actualizar490WC(string lenguajeActual490WC)
        {
            CargarTraducciones490WC(lenguajeActual490WC);
            Notificar490WC();
            Lenguaje490WC.Clear();
        }
        public string Traducir490WC(string TextoATraducir490WC)
        {
            try
            {
                if (Lenguaje490WC.Count == 0) CargarTraducciones490WC(SesionManager490WC.GestorSesion490WC.Usuario490WC.IdiomaUsuario490WC);
                string translation490WC = "";
                return translation490WC = Lenguaje490WC[TextoATraducir490WC];
            }
            catch (Exception ex) { return TextoATraducir490WC; }
        }

        public void Notificar490WC()
        {
            foreach (iObserverLenguaje490WC Iob490WC in ListaFormularios490WC)
            {
                Iob490WC.ActualizarLenguaje490WC();
            }
        }

        public void Suscribir490WC(iObserverLenguaje490WC nNuevoObserver490WC)
        {
            this.ListaFormularios490WC.Add(nNuevoObserver490WC);
        }

        public void Desuscribir490WC(iObserverLenguaje490WC nObserverBorrar490WC)
        {
            if (this.ListaFormularios490WC.Contains(nObserverBorrar490WC))
            {
                this.ListaFormularios490WC.Remove(nObserverBorrar490WC);
            }
        }

    }
}

