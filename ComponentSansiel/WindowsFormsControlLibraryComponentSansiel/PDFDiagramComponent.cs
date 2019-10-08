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
using System.Reflection;

namespace WindowsFormsControlLibraryComponentSansiel
{
    public partial class PDFDiagramComponent : Component
    {
        public string FieldType { get; set; }

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
        public void CreateDiagram<T>(List<T> products, string path)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();

            var props = typeof(T).GetProperties().Where((x) => FieldType.Split(' ').Contains(x.Name)).ToList();

            Dictionary<string, int> producers = new Dictionary<string, int>();

            foreach (var p in products)
            {
                var prod = props[0].GetValue(p).ToString();
                if (!producers.ContainsKey(prod))
                {
                    producers.Add(prod, 0);
                }
                producers[prod] += (int) props[1].GetValue(p);
            }

            ChartFrame chartFrame = new ChartFrame();
            chartFrame.Location = new XPoint(30, 30);
            chartFrame.Size = new XSize(500, 600);
            chartFrame.Add(ColumnChart(producers));

            XGraphics g = XGraphics.FromPdfPage(page);
            chartFrame.Draw(g);

            document.Save(path);
        }

        Chart ColumnChart(Dictionary<string, int> producers)
        {
            Chart chart = new Chart(ChartType.Column2D);

            foreach (var kv in producers)
            {
                Series series = chart.SeriesCollection.AddSeries();
                series.Name = kv.Key;
                series.Add(kv.Value);
            }

            chart.XAxis.TickLabels.Format = "00";
            chart.XAxis.MajorTickMark = TickMarkType.Outside;
            chart.XAxis.Title.Caption = "Made by Sansiel";
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
