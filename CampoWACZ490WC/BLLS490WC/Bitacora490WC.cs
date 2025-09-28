using DAL490WC;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SE490WC;
using SERVICIOS490WC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLS490WC
{
    public class Bitacora490WC
    {

        public void AltaEvento490WC(string Modulo490WC, string Descripcion490WC, int Criticidad490WC)
        {
            BitacoraDAL490WC GestorBitacora490WC = new BitacoraDAL490WC();
            if (SesionManager490WC.GestorSesion490WC.Usuario490WC != null)
            {
                BitacoraSE490WC bitacora490WC = new BitacoraSE490WC(SesionManager490WC.GestorSesion490WC.Usuario490WC.Username490WC, DateTime.Now.Date, DateTime.Now.TimeOfDay, Modulo490WC, Descripcion490WC, Criticidad490WC);
                GestorBitacora490WC.Alta490WC(bitacora490WC);
            }
        }

        public List<BitacoraSE490WC> ObtenerBitacoraPorConsulta490WC(string usuarioFiltrar490WC = "", string moduloFiltrar490WC = "", string descripcionFiltrar490WC = "", string criticidadFiltrar490WC = "", DateTime? fechaInicioFiltrar490WC = null, DateTime? fechaFinFiltrar490WC = null)
        {
            BitacoraDAL490WC GestorBitacora490WC = new BitacoraDAL490WC();
            return GestorBitacora490WC.ObtenerEventosPorConsulta490WC(usuarioFiltrar490WC, moduloFiltrar490WC, descripcionFiltrar490WC, criticidadFiltrar490WC, fechaInicioFiltrar490WC, fechaFinFiltrar490WC);
        }
        public void ImprimirBitacora490WC(List<BitacoraSE490WC> listaEventos490WC)
        {
            string carpeta490WC = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Bitacora490WC");
            if (!Directory.Exists(carpeta490WC)) { Directory.CreateDirectory(carpeta490WC); }
            string nombreFile490WC = $"Eventos{DateTime.Now:ddMMyy_HHmmss}_{SesionManager490WC.GestorSesion490WC.Usuario490WC.Username490WC}.pdf";
            string rutaFileFinal490WC = Path.Combine(carpeta490WC, nombreFile490WC);

            float alturaRow490WC = 18f;
            float alturaEncabezado490WC = 20f;
            float alturaTotal490WC = alturaEncabezado490WC + (listaEventos490WC.Count * alturaRow490WC) + 100f;
            Document documento490WC = new Document(new Rectangle(PageSize.A4.Width, alturaTotal490WC), 30f, 30f, 30f, 30f);

            using (FileStream FS490WC = new FileStream(rutaFileFinal490WC, FileMode.Create))
            {
                PdfWriter writer490WC = PdfWriter.GetInstance(documento490WC, FS490WC);
                documento490WC.Open();
                BaseFont fuenteRoboto490WC = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, false);

               
                BaseColor azulTexto = new BaseColor(0, 123, 255);     
                BaseColor azulMarinoOscuro = new BaseColor(0, 0, 0); 
                BaseColor azulMarinoMedio = new BaseColor(15, 32, 60);  

               
                var estiloTitulo490WC = new Font(fuenteRoboto490WC, 14f, Font.BOLD, azulTexto);
                var estiloEncabezado490WC = new Font(fuenteRoboto490WC, 11.87629f, Font.BOLD, azulTexto);
                var estiloCelda490WC = new Font(fuenteRoboto490WC, 11.87629f, Font.NORMAL, azulTexto);

             
                Paragraph titulo490WC = new Paragraph("Reporte Bitacora De Eventos", estiloTitulo490WC);
                titulo490WC.Alignment = Element.ALIGN_CENTER;
                documento490WC.Add(titulo490WC);
                documento490WC.Add(new Paragraph(" "));

              
                PdfPTable tablaBitacora490WC = new PdfPTable(7);
                tablaBitacora490WC.WidthPercentage = 100;
                tablaBitacora490WC.SetWidths(new float[] { 15, 15, 15, 10, 15, 22, 14 });

               
                string[] encabezados490WC = { "Código", "Usuario", "Fecha", "Hora", "Módulo", "Descripción", "Criticidad" };
                foreach (var encabezado in encabezados490WC)
                {
                    PdfPCell celdaEncabezado490WC = new PdfPCell(new Phrase(encabezado, estiloEncabezado490WC));
                    celdaEncabezado490WC.BackgroundColor = azulMarinoMedio;
                    celdaEncabezado490WC.HorizontalAlignment = Element.ALIGN_CENTER;
                    celdaEncabezado490WC.Padding = 6;
                    tablaBitacora490WC.AddCell(celdaEncabezado490WC);
                }

               
                foreach (var evento490WC in listaEventos490WC)
                {
                    PdfPCell celda1 = new PdfPCell(new Phrase(evento490WC.IdBitacora490WC, estiloCelda490WC));
                    PdfPCell celda2 = new PdfPCell(new Phrase(evento490WC.Username490WC, estiloCelda490WC));
                    PdfPCell celda3 = new PdfPCell(new Phrase(evento490WC.Fecha490WC.ToShortDateString(), estiloCelda490WC));
                    PdfPCell celda4 = new PdfPCell(new Phrase(evento490WC.Hora490WC.ToString(@"hh\:mm"), estiloCelda490WC));
                    PdfPCell celda5 = new PdfPCell(new Phrase(evento490WC.Modulo490WC, estiloCelda490WC));
                    PdfPCell celda6 = new PdfPCell(new Phrase(evento490WC.Descripcion490WC, estiloCelda490WC));
                    PdfPCell celda7 = new PdfPCell(new Phrase(evento490WC.Criticidad490WC.ToString(), estiloCelda490WC));

                    
                    foreach (PdfPCell celda in new[] { celda1, celda2, celda3, celda4, celda5, celda6, celda7 })
                    {
                        celda.BackgroundColor = azulMarinoOscuro;
                        celda.HorizontalAlignment = Element.ALIGN_CENTER;
                        celda.Padding = 5;
                        tablaBitacora490WC.AddCell(celda);
                    }
                }

                documento490WC.Add(tablaBitacora490WC);
                documento490WC.Close();
            }

            System.Diagnostics.Process.Start(rutaFileFinal490WC);
        }



        public List<BitacoraSE490WC> ObtenerEventosSINFiltro()
        {
            BitacoraDAL490WC GestorBitacora490WC = new BitacoraDAL490WC();
            return GestorBitacora490WC.ObtenerEventosSINFiltro();
        }

        public List<string> ObtenerDescripcion490WC(string Modulo490WC)
        {
            BitacoraDAL490WC GestorBitacora490WC = new BitacoraDAL490WC();
            return GestorBitacora490WC.ObtenerDescripcion490WC(Modulo490WC);
        }

    }
}
