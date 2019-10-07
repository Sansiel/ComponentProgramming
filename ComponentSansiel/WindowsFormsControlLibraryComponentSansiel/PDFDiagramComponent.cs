using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using XsPDF.Charting;
using XsPDF.Drawing;
using XsPDF.Pdf;

namespace WindowsFormsControlLibraryComponentSansiel
{
    public partial class PDFDiagramComponent : Component
    {
        public static string FieldType { get; set; }

        public PDFDiagramComponent()
        {
            InitializeComponent();
        }

        public PDFDiagramComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <typeparam name="T"></typeparam>
        /// <param name="prods">Список продуктов.</param>
        /// <param name="name">Название свойства содержащего имя производителя.</param>
        /// <param name="count">Название свойства содержащего количество продукта.</param>
        /// <param name="path">Строка вида @"D:\path\to\diagram.pdf".</param>
        public static void CreateDiagram<T>(List<T> products, string name, double[] count, string path)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            Chart chart = null;
            foreach (var product in products)
            {
                var filtredProduct = product.GetType().GetProperties().Where((x) => FieldType.Split(' ').Contains(x.Name));
                foreach (var prod in filtredProduct)
                {
                    chart = ColumnChart(name, count);
                }
            }
            ChartFrame chartFrame = new ChartFrame();
            chartFrame.Location = new XPoint(30, 30);
            chartFrame.Size = new XSize(500, 600);
            chartFrame.Add(chart);

            XGraphics g = XGraphics.FromPdfPage(page);
            chartFrame.Draw(g);

            document.Save("ColumnChart.pdf");
        }

        static Chart ColumnChart(string name, double[] count)
        {
            Chart chart = new Chart(ChartType.Column2D);

            Series series = chart.SeriesCollection.AddSeries();
            series.Name = name;
            series.Add(count);

            chart.XAxis.TickLabels.Format = "00";
            chart.XAxis.MajorTickMark = TickMarkType.Outside;
            chart.XAxis.Title.Caption = "X-Axis";
            chart.YAxis.MajorTickMark = TickMarkType.Outside;
            chart.YAxis.HasMajorGridlines = true;

            chart.PlotArea.LineFormat.Color = XColors.DarkGray;
            chart.PlotArea.LineFormat.Width = 1;
            chart.PlotArea.LineFormat.Visible = true;

            chart.Legend.Docking = DockingType.Right;

            chart.DataLabel.Type = DataLabelType.Value;
            chart.DataLabel.Position = DataLabelPosition.OutsideEnd;

            return chart;
        }
    }
}
