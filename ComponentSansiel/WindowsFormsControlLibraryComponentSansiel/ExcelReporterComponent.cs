using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace WindowsFormsControlLibraryComponentSansiel
{
    public partial class ExcelReporterComponent : Component
    {

        public ExcelReporterComponent()
        {
            InitializeComponent();
        }

        public ExcelReporterComponent(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public static void CreateExcelReport<T>(List<T> toReport, List<T> toReportData, string name)
        {
            // Открываем приложение
            Application application = new Application
            {
                DisplayAlerts = false
            };

            // Файл шаблона
            const string template = "template.xlsm";

            // Открываем книгу
            Workbook workBook = application.Workbooks.Open(Path.Combine(Environment.CurrentDirectory, template));

            // Получаем активную таблицу
            Worksheet workSheet = workBook.ActiveSheet as Worksheet;

            // Записываем данные
            int j = 1;
            foreach (var temp in toReport)
            {
                workSheet.Cells[1, j] = temp;
                j++;
            }
            j = 1;
            foreach (var temp in toReportData)
            {
                workSheet.Cells[2, j] = temp;
                j++;
            }

            //Save
            string savedFileName = "book1.xlsm";
            if (name != null) savedFileName = name;
            workBook.SaveAs(Path.Combine(Environment.CurrentDirectory, savedFileName));

            //Close Excel
            if (application != null)
            {
                int excelProcessId = -1;
                GetWindowThreadProcessId(application.Hwnd, ref excelProcessId);

                Marshal.ReleaseComObject(workSheet);
                workBook.Close();
                Marshal.ReleaseComObject(workBook);
                application.Quit();
                Marshal.ReleaseComObject(application);

                application = null;
                // Прибиваем висящий процесс
                try
                {
                    Process process = Process.GetProcessById(excelProcessId);
                    process.Kill();
                }
                finally { }
            }
        }
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(int hWnd, ref int lpdwProcessId);

    }
}
