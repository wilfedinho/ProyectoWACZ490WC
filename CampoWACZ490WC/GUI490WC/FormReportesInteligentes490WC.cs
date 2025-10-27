using BE490WC;
using BLL490WC;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SERVICIOS490WC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI490WC
{
    public partial class FormReportesInteligentes490WC : Form
    {
        public FormReportesInteligentes490WC()
        {
            InitializeComponent();
            GenerarReporteBeneficiosCuatrimestral490WC();
        }
        private void GenerarReporteBeneficiosCuatrimestral490WC()
        {
            VisualizadorReporte490WC.Series.Clear();
            VisualizadorReporte490WC.Titles.Clear();
            VisualizadorReporte490WC.ChartAreas.Clear();
            VisualizadorReporte490WC.Legends.Clear(); 

            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();
            List<string> temporadas490WC = new List<string> { "Verano", "Otoño", "Invierno", "Primavera" };

            int areaIndex490WC = 0;
            foreach (string temporada490WC in temporadas490WC)
            {
                string nombreTemporada490WC = temporada490WC.ToString();
                List<KeyValuePair<string, int>> datosReporte490WC = gestorBoleto490WC.GenerarReporteBeneficiosPorTemporada(temporada490WC);
                ChartArea area490WC = new ChartArea(nombreTemporada490WC);
                VisualizadorReporte490WC.ChartAreas.Add(area490WC);
                area490WC.InnerPlotPosition.Auto = false; 
                area490WC.InnerPlotPosition.Height = 85;
                area490WC.InnerPlotPosition.Width = 85;
                area490WC.InnerPlotPosition.Y = 5; 
                area490WC.InnerPlotPosition.X = 5; 
                switch (areaIndex490WC)
                {
                    case 0: area490WC.Position = new ElementPosition(0, 5, 50, 45); break;
                    case 1: area490WC.Position = new ElementPosition(50, 5, 50, 45); break;
                    case 2: area490WC.Position = new ElementPosition(0, 55, 50, 45); break;
                    case 3: area490WC.Position = new ElementPosition(50, 55, 50, 45); break;
                }
                Series serie490WC = new Series(nombreTemporada490WC)
                {
                    ChartType = SeriesChartType.Pie,
                    ChartArea = nombreTemporada490WC,
                    Legend = "" 
                };
                VisualizadorReporte490WC.Series.Add(serie490WC);
                if (datosReporte490WC.Count > 0)
                {
                    serie490WC.Points.DataBind(
                        dataSource: datosReporte490WC,
                        xField: "Key",
                        yFields: "Value",
                        otherFields: string.Empty
                    );
                    serie490WC.Label = "#VALX: #PERCENT{P1}";
                    serie490WC["PieLabelStyle"] = "Outside";
                    serie490WC["PieDrawingStyle"] = "SoftEdge";
                    serie490WC["PieStartAngle"] = "270"; 
                }
                else
                {
                    serie490WC.Points.AddXY("Sin datos", 1);
                    serie490WC.Points[0].Color = Color.LightGray;
                    serie490WC.Label = "Sin datos";
                }
                Title titulo490WC = new Title($"{nombreTemporada490WC}")
                {
                    Font = new System.Drawing.Font("Segoe UI", 11, FontStyle.Bold),
                    DockedToChartArea = nombreTemporada490WC,
                    IsDockedInsideChartArea = false,
                    Alignment = ContentAlignment.MiddleCenter
                };
                VisualizadorReporte490WC.Titles.Add(titulo490WC);
                areaIndex490WC++;
            }
        }

        public void GenerarReporteBeneficiosCuatrimestralPDF(Chart chartReporte)
        {
            string tituloReporte490WC = "Beneficios Más Populares En Base A Los Boletos Vendidos Por Temporada Del Año";
            string carpeta490WC = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ReportesInteligentes490WC");
            if (!Directory.Exists(carpeta490WC)) Directory.CreateDirectory(carpeta490WC);
            string nombreUsuario490WC = SesionManager490WC.GestorSesion490WC.Usuario490WC.Username490WC;
            string fecha490WC = DateTime.Now.ToString("ddMMyy");
            string nombreArchivo490WC = $"ReporteInteligente_{nombreUsuario490WC}_{fecha490WC}.pdf";
            string ruta490WC = Path.Combine(carpeta490WC, nombreArchivo490WC);
            Document doc490WC = new Document(PageSize.A4.Rotate(), 20f, 20f, 20f, 20f);
            try
            {
                using (FileStream fs490WC = new FileStream(ruta490WC, FileMode.Create))
                {
                    PdfWriter writer490WC = PdfWriter.GetInstance(doc490WC, fs490WC);
                    doc490WC.Open();
                    iTextSharp.text.Image pdfImage;
                    using (MemoryStream ms490WC = new MemoryStream())
                    {
                        chartReporte.SaveImage(ms490WC, ChartImageFormat.Png);
                        ms490WC.Seek(0, SeekOrigin.Begin);
                        pdfImage = iTextSharp.text.Image.GetInstance(ms490WC);
                    }
                    pdfImage.ScaleToFit(doc490WC.PageSize.Width - doc490WC.LeftMargin - doc490WC.RightMargin, doc490WC.PageSize.Height - doc490WC.TopMargin - doc490WC.BottomMargin); 
                    pdfImage.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                    var fontTitulo490WC = FontFactory.GetFont(FontFactory.COURIER_BOLD, 18);
                    Paragraph titulo490WC = new Paragraph(tituloReporte490WC, fontTitulo490WC);
                    titulo490WC.Alignment = Element.ALIGN_CENTER;
                    doc490WC.Add(titulo490WC);
                    doc490WC.Add(new Paragraph(" "));
                    doc490WC.Add(pdfImage);
                    doc490WC.Close();
                }
                System.Diagnostics.Process.Start(new ProcessStartInfo(ruta490WC) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error de Impresión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BT_ImprimirReporte490WC_Click(object sender, EventArgs e)
        {
            GenerarReporteBeneficiosCuatrimestralPDF(VisualizadorReporte490WC);
        }
    }
}
