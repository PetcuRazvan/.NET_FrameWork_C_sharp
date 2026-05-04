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

namespace Seminar8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCbCompanii();
        }

        private void InitializeCbCompanii()
        {
            cbCompanii.DataSource = FakeDatabase.Companii;
            cbCompanii.DisplayMember = "Nume";
        }

        private void cbCompanii_SelectedIndexChanged(object sender, EventArgs e)
        {
            var companie = cbCompanii.SelectedItem as Companie;

            if (companie != null)
            {
                IncarcareChart(companie);
                IncarcareChartVolum(companie);
                IncarcareChartEvolutie(companie);
            }
        }

        private void IncarcareChart(Companie companie)
        {
            var closeValues = FakeDatabase.Zile
                .Where(c => c.Simbol == companie.Simbol)
                .OrderBy(c => c.Data)
                .ToList(); //nu e neaparat, oricum se face lista

            pretInchiderChart.Titles.Clear();
            pretInchiderChart.Titles.Add(companie.Nume);

            pretInchiderChart.ChartAreas.Clear();
            var area = new ChartArea();
            area.Name = "PretInchidere";

            area.AxisX.Name = "Data";
            area.AxisX.LineWidth = 3;
            area.AxisX.MajorGrid.LineColor = Color.LightGray;

            area.AxisY.Name = "Pret";
            area.AxisY.LineWidth = 3;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            var minValue = closeValues.Min(x => x.Close);
            var maxValue = closeValues.Max(x => x.Close);
            var buffer = (maxValue - minValue) * 0.05m;

            area.AxisY.Minimum = (double)(minValue - buffer);
            area.AxisY.Maximum = (double)(maxValue + buffer);

            pretInchiderChart.ChartAreas.Add(area);

            pretInchiderChart.Series.Clear();

            var series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.ChartArea = "PretInchidere";

            series.MarkerColor = Color.Orange;
            series.MarkerSize = 5;
            series.MarkerStyle = MarkerStyle.Circle;

            

            pretInchiderChart.Series.Add(series);

            foreach (var item in closeValues)
            {
                series.Points.AddXY(item.Data.ToString("dd.MM"), item.Close);   
            }

            pretInchiderChart.Legends.Clear();
        }

        private void IncarcareChartVolum(Companie companie)
        {
            var closeValues = FakeDatabase.Zile
                .Where(c => c.Simbol == companie.Simbol)
                .OrderBy(c => c.Data)
                .ToList(); //nu e neaparat, oricum se face lista

            volumChart.Titles.Clear();
            volumChart.Titles.Add(companie.Nume);

            volumChart.ChartAreas.Clear();
            var area = new ChartArea();
            area.Name = "Volum";

            area.AxisX.Name = "Data";
            area.AxisX.LineWidth = 3;
            area.AxisX.MajorGrid.LineColor = Color.LightGray;

            area.AxisY.Name = "Pret";
            area.AxisY.LineWidth = 3;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

         

            

            volumChart.ChartAreas.Add(area);

            volumChart.Series.Clear();

            var series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.ChartArea = "Volum";

            
            volumChart.Series.Add(series);

            foreach (var item in closeValues)
            {
                series.Points.AddXY(item.Data.ToString("dd.MM"), item.Volum);
            }

            volumChart.Legends.Clear();
        }

        private void IncarcareChartEvolutie(Companie companie)
        {
            var closeValues = FakeDatabase.Zile
                .Where(c => c.Simbol == companie.Simbol)
                .OrderBy(c => c.Data)
                .ToList(); //nu e neaparat, oricum se face lista

            evolutieChart.Titles.Clear();
            evolutieChart.Titles.Add(companie.Nume);

            evolutieChart.ChartAreas.Clear();
            var area = new ChartArea();
            area.Name = "Evolutie";

            area.AxisX.Name = "Data";
            area.AxisX.LineWidth = 3;
            area.AxisX.MajorGrid.LineColor = Color.LightGray;

            area.AxisY.Name = "Pret";
            area.AxisY.LineWidth = 3;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            var minValue = closeValues.Min(x => x.Close);
            var maxValue = closeValues.Max(x => x.Close);
            var buffer = (maxValue - minValue) * 0.05m;

            area.AxisY.Minimum = (double)(minValue - buffer);
            area.AxisY.Maximum = (double)(maxValue + buffer);

            evolutieChart.ChartAreas.Add(area);

            evolutieChart.Series.Clear();

            var series = new Series();
            series.ChartType = SeriesChartType.Candlestick;
            series.ChartArea = "Evolutie";
            series["PriceUpColor"] = "SeaGreen";
            series["PriceDownColor"] = "Tomato";

            

            evolutieChart.Series.Add(series);

            foreach (var item in closeValues)
            {
                series.Points.AddXY(item.Data, item.High, item.Low, item.Open, item.Close);
            }

            evolutieChart.Legends.Clear();
        }
    }
}
