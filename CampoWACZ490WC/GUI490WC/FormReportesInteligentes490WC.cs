using BE490WC;
using BLL490WC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void GenerarReporteBeneficiosMasCanjeados490WC()
        {

            GestorBeneficio490WC gestorBeneficio490WC = new GestorBeneficio490WC();
            List<Beneficio490WC> listaBeneficio490WC = gestorBeneficio490WC.ObtenerTodosLosBeneficios490WC();

            VisualizadorReporte490WC.Series.Clear();
            VisualizadorReporte490WC.ChartAreas.Clear();
            VisualizadorReporte490WC.Titles.Clear();
            VisualizadorReporte490WC.Legends.Clear();

            ChartArea area = new ChartArea("AreaBeneficios");
            VisualizadorReporte490WC.ChartAreas.Add(area);

            Series serie = new Series("Beneficios Más Canjeados")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                LabelForeColor = Color.Black
            };

            VisualizadorReporte490WC.Series.Add(serie);

            serie.Points.DataBindXY(listaBeneficio490WC.Select(b => b.Nombre490WC).ToList(), listaBeneficio490WC.Select(b => b.CantidadBeneficioReclamo490WC).ToList());
            area.AxisX.Title = "Nombre del Beneficio";
            area.AxisY.Title = "Cantidad de Canjes";
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisX.Interval = 1;
            area.AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            area.AxisX.LabelStyle.Angle = -30;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.Position = new ElementPosition(0, 0, 100, 90);
            area.InnerPlotPosition = new ElementPosition(5, 5, 90, 90);
            VisualizadorReporte490WC.Titles.Add("Beneficios Más Canjeados");
            area.BackColor = Color.White;
            VisualizadorReporte490WC.BackColor = Color.White;
        }

        private void GenerarReporteClasesBoletosMasPopulares490WC()
        {

            GestorBoleto490WC gestorBoleto = new GestorBoleto490WC();
            List<Boleto490WC> listaBoletos = gestorBoleto.ObtenerTodosLosBoletos490WC();
            var boletosVendidos = listaBoletos.Where(b => b.IsVendido490WC == true).ToList();
            var clasesAgrupadas = boletosVendidos.GroupBy(b => b.ClaseBoleto490WC).Select(g => new
            {
                Clase = g.Key,
                Cantidad = g.Count()
            }).OrderByDescending(x => x.Cantidad).ToList();

            VisualizadorReporte490WC.Series.Clear();
            VisualizadorReporte490WC.ChartAreas.Clear();
            VisualizadorReporte490WC.Titles.Clear();
            VisualizadorReporte490WC.Legends.Clear();


            ChartArea area = new ChartArea("AreaClases");
            VisualizadorReporte490WC.ChartAreas.Add(area);

            Series serie = new Series("Clases de Boletos Más Populares")
            {
                ChartType = SeriesChartType.Pie,
                Font = new Font("Segoe UI", 16),
                LabelForeColor = Color.Black
            };
            serie.IsValueShownAsLabel = false;
            VisualizadorReporte490WC.Series.Add(serie);
            serie.Points.DataBindXY(
                clasesAgrupadas.Select(x => x.Clase).ToList(),
                clasesAgrupadas.Select(x => x.Cantidad).ToList()
            );
            serie.Label = "#VALX: #PERCENT{P1}";
            VisualizadorReporte490WC.Titles.Add("Clases de Boletos Más Populares");
            VisualizadorReporte490WC.Titles[0].Font = new Font("Segoe UI", 14, FontStyle.Bold);
            VisualizadorReporte490WC.Titles[0].ForeColor = Color.White;
            area.BackColor = Color.Transparent;
            VisualizadorReporte490WC.BackColor = Color.Transparent;
        }
        private void GenerarReporteModalidadPorTemporada490WC()
        {
            VisualizadorReporte490WC.Series.Clear();
            VisualizadorReporte490WC.Titles.Clear();
            VisualizadorReporte490WC.ChartAreas.Clear();
            VisualizadorReporte490WC.Legends.Clear();

            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();

            List<Boleto490WC> boletosVerano = gestorBoleto490WC.ObtenerBoletosVerano490WC();
            List<Boleto490WC> boletosOtono = gestorBoleto490WC.ObtenerBoletosOtono490WC();
            List<Boleto490WC> boletosInvierno = gestorBoleto490WC.ObtenerBoletosInvierno490WC();
            List<Boleto490WC> boletosPrimavera = gestorBoleto490WC.ObtenerBoletosPrimavera490WC();

            var temporadas = new Dictionary<string, List<Boleto490WC>>()
            {
                 { "Verano", boletosVerano },
                 { "Otoño", boletosOtono },
                 { "Invierno", boletosInvierno },
                 { "Primavera", boletosPrimavera }
            };

            int areaIndex = 0;

            foreach (var temporada in temporadas)
            {
                var boletosTemporada = temporada.Value.Where(b => b.IsVendido490WC).ToList();
                var datosAgrupados = boletosTemporada.GroupBy(b => b.ClaseBoleto490WC).Select(g => new { Clase = g.Key, Cantidad = g.Count() }).ToList();

                ChartArea area = new ChartArea(temporada.Key);
                VisualizadorReporte490WC.ChartAreas.Add(area);

                switch (areaIndex)
                {
                    case 0: area.Position = new ElementPosition(0, 5, 50, 45); break;
                    case 1: area.Position = new ElementPosition(50, 5, 50, 45); break;
                    case 2: area.Position = new ElementPosition(0, 55, 50, 45); break;
                    case 3: area.Position = new ElementPosition(50, 55, 50, 45); break;
                }


                Series serie = new Series(temporada.Key)
                {
                    ChartType = SeriesChartType.Pie,
                    ChartArea = temporada.Key,
                    IsValueShownAsLabel = true
                };

                serie["PieLabelStyle"] = "Outside";
                serie.Label = "#VALX: #PERCENT{P1}";
                serie.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                serie.LegendText = "#VALX";

                if (datosAgrupados.Count > 0)
                {
                    serie.Points.DataBindXY(
                        datosAgrupados.Select(x => x.Clase).ToList(),
                        datosAgrupados.Select(x => x.Cantidad).ToList()
                    );
                }
                else
                {
                    serie.Points.AddXY("Sin datos", 1);
                    serie.Points[0].Color = Color.LightGray;
                }

                VisualizadorReporte490WC.Series.Add(serie);

                Title titulo = new Title($"{temporada.Key} - Modalidades más populares")
                {
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.Black,
                    DockedToChartArea = temporada.Key,
                    IsDockedInsideChartArea = false,
                    Alignment = ContentAlignment.MiddleCenter
                };
                VisualizadorReporte490WC.Titles.Add(titulo);

                areaIndex++;
            }
            VisualizadorReporte490WC.BackColor = Color.WhiteSmoke;
        }

        private void GenerarReporteDestinosPorTemporada490WC()
        {
            VisualizadorReporte490WC.Series.Clear();
            VisualizadorReporte490WC.Titles.Clear();
            VisualizadorReporte490WC.ChartAreas.Clear();
            VisualizadorReporte490WC.Legends.Clear();

            GestorBoleto490WC gestorBoleto490WC = new GestorBoleto490WC();

            List<Boleto490WC> boletosVerano = gestorBoleto490WC.ObtenerBoletosVerano490WC();
            List<Boleto490WC> boletosOtono = gestorBoleto490WC.ObtenerBoletosOtono490WC();
            List<Boleto490WC> boletosInvierno = gestorBoleto490WC.ObtenerBoletosInvierno490WC();
            List<Boleto490WC> boletosPrimavera = gestorBoleto490WC.ObtenerBoletosPrimavera490WC();

            var temporadas = new Dictionary<string, List<Boleto490WC>>()
            {
                { "Verano", boletosVerano },
                { "Otoño", boletosOtono },
                { "Invierno", boletosInvierno },
                { "Primavera", boletosPrimavera }
            };

            int areaIndex = 0;

            foreach (var temporada in temporadas)
            {
                var boletosTemporada = temporada.Value.Where(b => b.IsVendido490WC).ToList();
                var datosAgrupados = boletosTemporada.GroupBy(b => b.Destino490WC).Select(g => new { Destino = g.Key, Cantidad = g.Count() }).OrderByDescending(x => x.Cantidad).Take(5) .ToList();
                ChartArea area = new ChartArea(temporada.Key);
                VisualizadorReporte490WC.ChartAreas.Add(area);
                switch (areaIndex)
                {
                    case 0: area.Position = new ElementPosition(0, 5, 50, 45); break;      
                    case 1: area.Position = new ElementPosition(50, 5, 50, 45); break;   
                    case 2: area.Position = new ElementPosition(0, 55, 50, 45); break;     
                    case 3: area.Position = new ElementPosition(50, 55, 50, 45); break;  
                }
                Series serie = new Series(temporada.Key)
                {
                    ChartType = SeriesChartType.Pie,
                    ChartArea = temporada.Key,
                    IsValueShownAsLabel = true
                };

                serie["PieLabelStyle"] = "Outside";
                serie.Label = "#VALX: #PERCENT{P1}";
                serie.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                serie.LegendText = "#VALX";

                if (datosAgrupados.Count > 0)
                {
                    serie.Points.DataBindXY(
                        datosAgrupados.Select(x => x.Destino).ToList(),
                        datosAgrupados.Select(x => x.Cantidad).ToList()
                    );
                }
                else
                {
                    serie.Points.AddXY("Sin datos", 1);
                    serie.Points[0].Color = Color.LightGray;
                }

                VisualizadorReporte490WC.Series.Add(serie);
                Title titulo = new Title($"{temporada.Key} - Destinos Más Populares")
                {
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.Black,
                    DockedToChartArea = temporada.Key,
                    IsDockedInsideChartArea = false,
                    Alignment = ContentAlignment.MiddleCenter
                };
                VisualizadorReporte490WC.Titles.Add(titulo);

                areaIndex++;
            }

            VisualizadorReporte490WC.BackColor = Color.WhiteSmoke;
        }


        private void BT_ReporteBeneficiosMayorCanje_490WC_Click(object sender, EventArgs e)
        {
            GenerarReporteBeneficiosMasCanjeados490WC();
        }

        private void BT_ReporteDestinosMasSolicitadosTemporada_490WC_Click(object sender, EventArgs e)
        {
            GenerarReporteDestinosPorTemporada490WC();
        }

        private void BT_ReporteClaseBoletoPopularidad_490WC_Click(object sender, EventArgs e)
        {
            GenerarReporteClasesBoletosMasPopulares490WC();
        }

        private void BT_ReporteModalidadMasSolicitadaTemporada_490WC_Click(object sender, EventArgs e)
        {
            GenerarReporteModalidadPorTemporada490WC();
        }

        private void BT_ReporteCamposQueSuelenGenerarCambios_490WC_Click(object sender, EventArgs e)
        {

        }
    }
}
