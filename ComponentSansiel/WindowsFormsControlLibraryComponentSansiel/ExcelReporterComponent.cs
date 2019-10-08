using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Application = Microsoft.Office.Interop.Excel.Application;
using IronXL;

namespace WindowsFormsControlLibraryComponentSansiel
{
    public partial class ExcelReporterComponent : Component
    {
        public string FieldType { get; set; }

        public ExcelReporterComponent()
        {
            InitializeComponent();
        }

        public ExcelReporterComponent(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public  void CreateExcelReport<T>(List<T> toReport, string path)
        {
            WorkBook xlsxWorkbook = WorkBook.Create(ExcelFileFormat.XLSX);
            WorkSheet xlsSheet = xlsxWorkbook.CreateWorkSheet("main_sheet");

            var props = typeof(T).GetProperties().Where((x) => FieldType.Split(' ').Contains(x.Name)).ToList();

            Dictionary<string, string> products = new Dictionary<string, string>();

            foreach (var p in toReport)
            {
                var prod = props[0].GetValue(p).ToString();
                if (!products.ContainsKey(prod))
                {
                    products.Add(prod, "");
                }
                products[prod] += props[2].GetValue(p).ToString() + " ";
            }

            int j = 1;
            foreach (var kv in products)
            {
                string cell1 = "A";
                string cell2 = "B";
                cell1 += j;
                cell2 += j;
                xlsSheet[cell1].Value = kv.Key;
                xlsSheet[cell2].Value = kv.Value;
                j++;
            }
            xlsxWorkbook.SaveAs(path+ ".xlsx");
        }

    }
}
