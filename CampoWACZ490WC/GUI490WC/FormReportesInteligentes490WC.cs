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
            // 1. Obtener los datos
            GestorBoleto490WC gestorBoleto = new GestorBoleto490WC();
            List<Boleto490WC> listaBoletos = gestorBoleto.ObtenerTodosLosBoletos490WC();

            // 2. Filtrar solo los boletos vendidos
            var boletosVendidos = listaBoletos.Where(b => b.IsVendido490WC == true).ToList();

            // 3. Agrupar por clase y contar cantidad
            var clasesAgrupadas = boletosVendidos.GroupBy(b => b.ClaseBoleto490WC).Select(g => new
                {
                    Clase = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(x => x.Cantidad)
                .ToList();

            // 4. Limpiar gráfico
            VisualizadorReporte490WC.Series.Clear();
            VisualizadorReporte490WC.ChartAreas.Clear();
            VisualizadorReporte490WC.Titles.Clear();
            VisualizadorReporte490WC.Legends.Clear();

            // 5. Crear área y serie
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

            // 6. Enlazar datos
            serie.Points.DataBindXY(
                clasesAgrupadas.Select(x => x.Clase).ToList(),
                clasesAgrupadas.Select(x => x.Cantidad).ToList()
            );

            // 7. Mostrar porcentaje y nombre en las etiquetas
            serie.Label = "#VALX: #PERCENT{P1}"; // Ejemplo: "Económica: 45.3%"

            // 8. Agregar título
            VisualizadorReporte490WC.Titles.Add("Clases de Boletos Más Populares");
            VisualizadorReporte490WC.Titles[0].Font = new Font("Segoe UI", 14, FontStyle.Bold);
            VisualizadorReporte490WC.Titles[0].ForeColor = Color.White;
            area.BackColor = Color.Transparent;
            VisualizadorReporte490WC.BackColor = Color.Transparent;
        }


        private void BT_ReporteBeneficiosMayorCanje_490WC_Click(object sender, EventArgs e)
        {
            GenerarReporteBeneficiosMasCanjeados490WC();
        }

        private void BT_ReporteDestinosMasSolicitadosTemporada_490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_ReporteClaseBoletoPopularidad_490WC_Click(object sender, EventArgs e)
        {
            GenerarReporteClasesBoletosMasPopulares490WC();
        }

        private void BT_ReporteModalidadMasSolicitadaTemporada_490WC_Click(object sender, EventArgs e)
        {

        }

        private void BT_ReporteCamposQueSuelenGenerarCambios_490WC_Click(object sender, EventArgs e)
        {

        }
    }
}
