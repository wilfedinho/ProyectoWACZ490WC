using BE490WC;
using BLLS490WC;
using DAL490WC;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL490WC
{
    public class GestorBoleto490WC
    {
        #region Operaciones Boleto

        public void Alta490WC(Boleto490WC BoletoAgregar490WC)
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            gestorBoletoDAL490WC.Alta490WC(BoletoAgregar490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Boleto", "Crear Boleto", 3);
        }

        public void Baja490WC(string IDBoleto490WC)
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            gestorBoletoDAL490WC.Baja490WC(IDBoleto490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Boleto", "Eliminar Boleto", 5);
        }

        public void Modificar490WC(Boleto490WC BoletoModificado490WC)
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            gestorBoletoDAL490WC.Modificar490WC(BoletoModificado490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Boleto", "Modificar Boleto", 3);
        }

        public void AsignarBoletoCliente490WC(Boleto490WC boletoAsignar490WC, Cliente490WC clienteAsignar490WC)
        {
            BoletoDAL490WC boletoDAL490WC = new BoletoDAL490WC();
            boletoDAL490WC.AsignarBoletoCliente490WC(boletoAsignar490WC, clienteAsignar490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Boleto", "Asignar Boleto A un Cliente", 2);
        }

        public void AsignarBoletoClienteRegistrar490WC(Boleto490WC boletoAsignar490WC, Cliente490WC clienteAsignar490WC)
        {
            BoletoDAL490WC boletoDAL490WC = new BoletoDAL490WC();
            boletoDAL490WC.AsignarBoletoClienteRegistrar490WC(boletoAsignar490WC, clienteAsignar490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Boleto", "Asignar Boleto A un Cliente", 2);
        }

        public void GenerarBoletoCompra490WC(Boleto490WC boletoGenerar490WC)
        {
            BoletoDAL490WC boletoDAL490WC = new BoletoDAL490WC();
            boletoDAL490WC.GenerarBoletoCompra490WC(boletoGenerar490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Boleto", "Generar Boleto", 5);
        }

        public void LiberarBoletosVencidos490WC()
        {
            BoletoDAL490WC boletoDAL490WC = new BoletoDAL490WC();
            boletoDAL490WC.LiberarBoletosVencidos490WC();
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Boleto", "Liberar Boletos Vencidos", 3);
        }

        public void CobrarBoleto490WC(Boleto490WC BoletoCobrado490WC)
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            gestorBoletoDAL490WC.CobrarBoleto490WC(BoletoCobrado490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Boleto", "Vender Boleto", 2);
        }

        public bool ExisteBoletoAsignar490WC(int idBoleto)
        {
            BoletoDAL490WC gestorBoleto490WC = new BoletoDAL490WC();
            return gestorBoleto490WC.ExisteBoletoAsignar490WC(idBoleto);
        }
        public bool ExisteBoletoEnAsiento490WC(Boleto490WC boletoVerificarExistencia490WC)
        {
            BoletoDAL490WC gestorBoleto490WC = new BoletoDAL490WC();
            return gestorBoleto490WC.ExisteBoletoEnAsiento490WC(boletoVerificarExistencia490WC);
        }

        public bool ExisteBoletoEnAsientoParaModificar490WC(Boleto490WC boletoVerificarExistencia490WC)
        {
            BoletoDAL490WC gestorBoleto490WC = new BoletoDAL490WC();
            return gestorBoleto490WC.ExisteBoletoEnAsientoParaModificar490WC(boletoVerificarExistencia490WC);
        }
        public void GenerarBoleto490WC(Boleto490WC boleto490WC)
        {
            string carpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Facturas490WC");
            if (!Directory.Exists(carpeta)) Directory.CreateDirectory(carpeta);

            string nombreArchivo = $"Boleto_{boleto490WC.Titular490WC.DNI490WC}_Cod{boleto490WC.IDBoleto490WC}.pdf";
            string ruta = Path.Combine(carpeta, nombreArchivo);

            float ancho = Utilities.MillimetersToPoints(80);
            float alto = Utilities.MillimetersToPoints(150);
            Document doc = new Document(new Rectangle(ancho, alto), 10f, 10f, 10f, 10f);

            using (FileStream fs = new FileStream(ruta, FileMode.Create))
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                var fontTitulo = FontFactory.GetFont(FontFactory.COURIER_BOLD, 14);
                var fontSeccion = FontFactory.GetFont(FontFactory.COURIER_BOLD, 10);
                var fontNormal = FontFactory.GetFont(FontFactory.COURIER, 9);


                Paragraph titulo = new Paragraph("BOLETO DE VIAJE", fontTitulo);
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);
                doc.Add(new Paragraph(" ", fontNormal));


                doc.Add(new Paragraph($"N° Boleto: {boleto490WC.IDBoleto490WC}", fontNormal));
                doc.Add(new Paragraph($"Emitido: {DateTime.Now:dd/MM/yyyy HH:mm}", fontNormal));
                doc.Add(new Paragraph("----------------------------------", fontNormal));


                doc.Add(new Paragraph("ITINERARIO", fontSeccion));
                doc.Add(new Paragraph($"Origen: {boleto490WC.Origen490WC}", fontNormal));
                doc.Add(new Paragraph($"Destino: {boleto490WC.Destino490WC}", fontNormal));
                doc.Add(new Paragraph($"Salida: {boleto490WC.FechaPartida490WC:dd/MM/yyyy HH:mm}", fontNormal));
                doc.Add(new Paragraph($"Llegada: {boleto490WC.FechaLlegada490WC:dd/MM/yyyy HH:mm}", fontNormal));

                if (boleto490WC is BoletoIDAVUELTA490WC boleIDAVUELTA)
                {
                    doc.Add(new Paragraph($"Regreso: {boleIDAVUELTA.FechaPartidaVUELTA490WC:dd/MM/yyyy HH:mm}", fontNormal));
                    doc.Add(new Paragraph($"Llegada Regreso: {boleIDAVUELTA.FechaLlegadaVUELTA490WC:dd/MM/yyyy HH:mm}", fontNormal));
                    doc.Add(new Paragraph($"Modalidad: IDA Y VUELTA", fontNormal));
                }
                else
                {
                    doc.Add(new Paragraph($"Modalidad: SOLO IDA", fontNormal));
                }

                doc.Add(new Paragraph("----------------------------------", fontNormal));


                doc.Add(new Paragraph("PASAJERO", fontSeccion));
                doc.Add(new Paragraph($"Nombre: {boleto490WC.Titular490WC.Nombre490WC}", fontNormal));
                doc.Add(new Paragraph($"Apellido: {boleto490WC.Titular490WC.Apellido490WC}", fontNormal));
                doc.Add(new Paragraph($"DNI: {boleto490WC.Titular490WC.DNI490WC}", fontNormal));

                doc.Add(new Paragraph("----------------------------------", fontNormal));


                doc.Add(new Paragraph("DETALLES", fontSeccion));
                doc.Add(new Paragraph($"Asiento: {boleto490WC.NumeroAsiento490WC}", fontNormal));
                doc.Add(new Paragraph($"Clase: {boleto490WC.ClaseBoleto490WC}", fontNormal));
                doc.Add(new Paragraph($"Equipaje: {boleto490WC.EquipajePermitido490WC} kg", fontNormal));
                doc.Add(new Paragraph($"Precio: ${boleto490WC.Precio490WC:F2}", fontNormal));

                doc.Add(new Paragraph(" ", fontNormal));
                doc.Add(new Paragraph("----------------------------------", fontNormal));
                doc.Add(new Paragraph(" ", fontNormal));

                doc.Close();
            }


            System.Diagnostics.Process.Start(ruta);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Boleto", "Generar Reporte Boleto", 2);
        }

        #endregion

        #region Verificar Formatos

        public bool VerificarFormatoAsiento490WC(string FormatoAsiento490WC)
        {
            Regex rgxFormatoAsiento = new Regex("^[A-Z]{1}[0-9]{3}$");
            if (rgxFormatoAsiento.IsMatch(FormatoAsiento490WC))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        #endregion


        #region Busqueda Boleto

        public List<Boleto490WC> ObtenerBoletosPorModalidad490WC(string Modalidad490WC)
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            return gestorBoletoDAL490WC.ObtenerBoletosPorModalidad490WC(Modalidad490WC);
        }

        public Boleto490WC ObtenerBoletoPorID490WC(string ID490WC)
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            return gestorBoletoDAL490WC.ObtenerBoletoPorID490WC(ID490WC);
        }

        public List<Boleto490WC> ObtenerBoletosPorPagarCliente490WC(Cliente490WC cliente490WC)
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            return gestorBoletoDAL490WC.ObtenerBoletosPorPagarCliente490WC(cliente490WC);
        }

        public List<Boleto490WC> ObtenerBoletosPorCliente490WC(Cliente490WC cliente490WC)
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            return gestorBoletoDAL490WC.ObtenerBoletosPorCliente490WC(cliente490WC);
        }
        public List<Boleto490WC> ObtenerTodosLosBoletos490WC()
        {
            BoletoDAL490WC gestorBoletoDAL490WC = new BoletoDAL490WC();
            return gestorBoletoDAL490WC.ObtenerTodosLosBoletos490WC();
        }
        public List<Boleto490WC> ObtenerBoletosFiltrados490WC(string origen490WC = "", string destino490WC = "", string claseBoleto490WC = "", float? precioDesde490WC = null, float? precioHasta490WC = null, float? pesoPermitido490WC = null, DateTime? fechaPartida490WC = null, DateTime? fechaLlegada490WC = null, DateTime? fechaPartidaVUELTA490WC = null, DateTime? fechaLlegadaVUELTA490WC = null)
        {
            BoletoDAL490WC gestorBoleto490WC = new BoletoDAL490WC();
            return gestorBoleto490WC.ObtenerBoletosFiltrados490WC(origen490WC, destino490WC, claseBoleto490WC, precioDesde490WC, precioHasta490WC, pesoPermitido490WC, fechaPartida490WC, fechaLlegada490WC, fechaPartidaVUELTA490WC, fechaLlegadaVUELTA490WC);
        }

        public Boleto490WC ObtenerBoletoConBeneficio490WC(string ID490WC)
        {
            BoletoDAL490WC boletoDAL490WC = new BoletoDAL490WC();
            return boletoDAL490WC.ObtenerBoletoConBeneficio490WC(ID490WC);
        }

        #endregion

    }
}
