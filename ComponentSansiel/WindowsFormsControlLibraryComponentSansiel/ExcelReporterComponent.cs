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

            int propsLength = props.Capacity;
            string[] cells = { "A", "B", "C", "D", "E", "F", "G" };
            int j = 0;
            string cell;
            foreach (var p in toReport)
            {
                cell = cells[j];
                for (int i=1; i < propsLength; i++)
                {
                    
                    cell += i;
                    xlsSheet[cell].Value = props[i-1].GetValue(p).ToString();
                    cell = cells[j];
                }
                j++;
            }

            xlsxWorkbook.SaveAs(path+ ".xlsx");
        }

    }
}
