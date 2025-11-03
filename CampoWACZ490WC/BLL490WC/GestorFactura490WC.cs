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
using System.Threading.Tasks;

namespace BLL490WC
{
    public class GestorFactura490WC
    {
        public void Alta490WC(Factura490WC FacturaAlta490WC)
        {
            FacturaDAL490WC gestorFactura490WC = new FacturaDAL490WC();
            gestorFactura490WC.Alta490WC(FacturaAlta490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Factura", "Crear Factura", 3);
            DigitoVerificador490WC gestorDigitoVerificador490WC = new DigitoVerificador490WC();
            gestorDigitoVerificador490WC.ActualizarIntegridadPorTabla490WC("Factura490WC");
        }
        public List<Factura490WC> ObtenerTodasLasFacturas490WC()
        {
            FacturaDAL490WC gestorFactura490WC = new FacturaDAL490WC();
            return gestorFactura490WC.ObtenerTodasLasFacturas490WC();
        }
        public void GenerarFactura490WC(Factura490WC factura490WC)
        {
            string carpeta490WC = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Facturas490WC");
            if (!Directory.Exists(carpeta490WC)) { Directory.CreateDirectory(carpeta490WC); }
            string nombreArchivo490WC = $"Factura_{factura490WC.DNIC490WC}_Cod{factura490WC.NumeroFactura490WC}.pdf";
            string rutaFinal490WC = Path.Combine(carpeta490WC, nombreArchivo490WC);


            float ancho490WC = Utilities.MillimetersToPoints(80);
            float alto490WC = Utilities.MillimetersToPoints(150);
            Document doc490WC = new Document(new Rectangle(ancho490WC, alto490WC), 10f, 10f, 10f, 10f);
            using (FileStream fs490WC = new FileStream(rutaFinal490WC, FileMode.Create))
            {
                PdfWriter writer490WC = PdfWriter.GetInstance(doc490WC, fs490WC);
                doc490WC.Open();
                doc490WC.Add(new Paragraph(" "));
                doc490WC.Add(new Paragraph(" "));
                Paragraph titulo490WC = new Paragraph($"FACTURA", FontFactory.GetFont(FontFactory.COURIER_BOLD, 16));
                titulo490WC.Alignment = Element.ALIGN_CENTER;
                doc490WC.Add(titulo490WC);
                doc490WC.Add(new Paragraph(" "));
                doc490WC.Add(new Paragraph($"Fecha: {factura490WC.FechaEmision490WC} {factura490WC.HoraEmision490WC}", FontFactory.GetFont(FontFactory.COURIER, 10)));
                doc490WC.Add(new Paragraph($"Cliente: {factura490WC.Apellido490WC}, {factura490WC.Nombre490WC}", FontFactory.GetFont(FontFactory.COURIER, 10)));
                doc490WC.Add(new Paragraph($"DNI: {factura490WC.DNIC490WC}", FontFactory.GetFont(FontFactory.COURIER, 10)));
                doc490WC.Add(new Paragraph(" "));
                doc490WC.Add(new Paragraph("----------------------------------", FontFactory.GetFont(FontFactory.COURIER, 10)));
                doc490WC.Add(new Paragraph(" "));
                doc490WC.Add(new Paragraph($"Numero Boleto: {factura490WC.NumeroBoleto490WC}", FontFactory.GetFont(FontFactory.COURIER, 10)));
                if (factura490WC.BeneficioAplicado490WC != null)
                {
                    if (!string.IsNullOrEmpty(factura490WC.BeneficioAplicado490WC))
                    {
                        doc490WC.Add(new Paragraph($"Beneficio Aplicado: {factura490WC.BeneficioAplicado490WC}", FontFactory.GetFont(FontFactory.COURIER, 10)));
                    }
                    else
                    {
                        doc490WC.Add(new Paragraph($"Beneficio Aplicado: No se Aplico Ningun Beneficio", FontFactory.GetFont(FontFactory.COURIER, 10)));
                    }
                }
                else
                {
                    doc490WC.Add(new Paragraph($"Beneficio Aplicado: No se Aplico Ningun Beneficio", FontFactory.GetFont(FontFactory.COURIER, 10)));
                }
                doc490WC.Add(new Paragraph($"Subtotal: {factura490WC.Subtotal490WC:F2}$", FontFactory.GetFont(FontFactory.COURIER, 10)));
                doc490WC.Add(new Paragraph(" "));
                doc490WC.Add(new Paragraph("----------------------------------", FontFactory.GetFont(FontFactory.COURIER, 10)));
                doc490WC.Add(new Paragraph(" "));
                doc490WC.Add(new Paragraph($"Impuestos Aplicados: IMPUESTO PAIS 60%", FontFactory.GetFont(FontFactory.COURIER, 10)));
                doc490WC.Add(new Paragraph($"Total pagado: {factura490WC.Total490WC:F2}$", FontFactory.GetFont(FontFactory.COURIER_BOLD, 12)));
                doc490WC.Add(new Paragraph(" "));
                doc490WC.Add(new Paragraph(" "));
                doc490WC.Close();
            }
            System.Diagnostics.Process.Start(rutaFinal490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Factura", "Generar Reporte Factura", 2);
        }

        public void GenerarFacturaBoletoModificado490WC(Factura490WC factura490WC)
        {
            string carpeta490WC = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Facturas490WC");
            if (!Directory.Exists(carpeta490WC)) { Directory.CreateDirectory(carpeta490WC); }
            string nombreArchivo490WC = $"Factura_{factura490WC.DNIC490WC}_Cod{factura490WC.NumeroFactura490WC}.pdf";
            string rutaFinal490WC = Path.Combine(carpeta490WC, nombreArchivo490WC);


            float ancho490WC = Utilities.MillimetersToPoints(80);
            float alto490WC = Utilities.MillimetersToPoints(150);
            Document doc490WC = new Document(new Rectangle(ancho490WC, alto490WC), 10f, 10f, 10f, 10f);
            using (FileStream fs490WC = new FileStream(rutaFinal490WC, FileMode.Create))
            {
                PdfWriter writer490WC = PdfWriter.GetInstance(doc490WC, fs490WC);
                doc490WC.Open();
                doc490WC.Add(new Paragraph(" "));
                Paragraph titulo490WC = new Paragraph($"FACTURA", FontFactory.GetFont(FontFactory.COURIER_BOLD, 16));
                titulo490WC.Alignment = Element.ALIGN_CENTER;
                doc490WC.Add(titulo490WC);
                doc490WC.Add(new Paragraph(" "));
                doc490WC.Add(new Paragraph($"Fecha: {factura490WC.FechaEmision490WC} {factura490WC.HoraEmision490WC}", FontFactory.GetFont(FontFactory.COURIER, 10)));
                doc490WC.Add(new Paragraph($"Cliente: {factura490WC.Apellido490WC}, {factura490WC.Nombre490WC}", FontFactory.GetFont(FontFactory.COURIER, 10)));
                doc490WC.Add(new Paragraph($"DNI: {factura490WC.DNIC490WC}", FontFactory.GetFont(FontFactory.COURIER, 10)));
                doc490WC.Add(new Paragraph("----------------------------------", FontFactory.GetFont(FontFactory.COURIER, 10)));
                doc490WC.Add(new Paragraph($"Numero Boleto: {factura490WC.NumeroBoleto490WC}", FontFactory.GetFont(FontFactory.COURIER, 10)));
                if (factura490WC.BeneficioAplicado490WC != null)
                {
                    if (!string.IsNullOrEmpty(factura490WC.BeneficioAplicado490WC))
                    {
                        doc490WC.Add(new Paragraph($"Beneficio Aplicado: {factura490WC.BeneficioAplicado490WC}", FontFactory.GetFont(FontFactory.COURIER, 10)));
                    }
                    else
                    {
                        doc490WC.Add(new Paragraph($"Beneficio Aplicado: No se Aplico Ningun Beneficio", FontFactory.GetFont(FontFactory.COURIER, 10)));
                    }
                }
                else
                {
                    doc490WC.Add(new Paragraph($"Beneficio Aplicado: No se Aplico Ningun Beneficio", FontFactory.GetFont(FontFactory.COURIER, 10)));
                }
                if (factura490WC.CambiosRealizados490WC != null)
                {
                    string[] cambios490WC = factura490WC.CambiosRealizados490WC.Split(';');
                    doc490WC.Add(new Paragraph("Cambios Realizados: ", FontFactory.GetFont(FontFactory.COURIER, 10)));
                    if (!(string.IsNullOrEmpty(cambios490WC[1])) || !(string.IsNullOrEmpty(cambios490WC[2])) || !(string.IsNullOrEmpty(cambios490WC[3])) || !(string.IsNullOrEmpty(cambios490WC[4])))
                    {
                        doc490WC.Add(new Paragraph("Cambio De Fecha ===> 30% Recargo", FontFactory.GetFont(FontFactory.COURIER, 10)));
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[5]))
                    {
                        doc490WC.Add(new Paragraph("Cambio De Beneficio ===> 20% Recargo", FontFactory.GetFont(FontFactory.COURIER, 10)));
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[6]))
                    {
                        doc490WC.Add(new Paragraph("Cambio De Clase ===> 40% Recargo", FontFactory.GetFont(FontFactory.COURIER, 10)));
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[7]))
                    {
                        doc490WC.Add(new Paragraph("Cambio De Asiento ===> 20% Recargo", FontFactory.GetFont(FontFactory.COURIER, 10)));
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[8]))
                    {
                        doc490WC.Add(new Paragraph("Cambio De Peso ===> 13% Recargo", FontFactory.GetFont(FontFactory.COURIER, 10)));
                    }
                    if (!string.IsNullOrEmpty(cambios490WC[9]))
                    {
                        doc490WC.Add(new Paragraph("Cambio De Titular ===> 60% Recargo", FontFactory.GetFont(FontFactory.COURIER, 10)));
                    }
                }
                doc490WC.Add(new Paragraph($"Subtotal: {factura490WC.Subtotal490WC:F2}$", FontFactory.GetFont(FontFactory.COURIER, 10)));
                doc490WC.Add(new Paragraph("----------------------------------", FontFactory.GetFont(FontFactory.COURIER, 10)));
                doc490WC.Add(new Paragraph($"Impuestos Aplicados: IMPUESTO PAIS 60%", FontFactory.GetFont(FontFactory.COURIER, 10)));
                doc490WC.Add(new Paragraph($"Total pagado: {factura490WC.Total490WC:F2}$", FontFactory.GetFont(FontFactory.COURIER_BOLD, 12)));
                doc490WC.Add(new Paragraph(" "));
                doc490WC.Close();
            }
            System.Diagnostics.Process.Start(rutaFinal490WC);
            Bitacora490WC GestorBitacora490WC = new Bitacora490WC();
            GestorBitacora490WC.AltaEvento490WC("Gestión Factura", "Generar Reporte Factura", 2);
        }

    }
}
