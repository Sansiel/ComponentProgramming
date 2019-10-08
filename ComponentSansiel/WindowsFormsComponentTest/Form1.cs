using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows.Forms;
using WindowsFormsControlLibraryComponentSansiel;

namespace WindowsFormsComponentTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            selectComponentControl.LoadEnumeration(typeof(TestEnum));
        }
        private void controlComboBoxSelected_ComboBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(selectComponentControl.SelectedText);
        }

        [DataContract]
        public class User
        {
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public int Age { get; set; }
        }

        [DataContract]
        public class Product
        {
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public string Pname { get; set; }
            [DataMember]
            public int Count { get; set; }
        }

        private void buttonChange_Click_1(object sender, EventArgs e)
        {
            //selectComponentControl.SelectedIndex = 0;
            //MessageBox.Show(enterFieldControl1.TemplateText);
            //string[] countries = { "Бразилия", "Аргентина", "Чили", "Уругвай", "Колумбия" };

            //outputComponentControl1.AddGroupToList(countries);
            var x = new List<object>();
            x.Add((object)new User { Name = "Petya", Age = 13 });
            x.Add((object)new User { Name = "Masha", Age = 14 });
            outputComponentControl.AddGroupToList(x);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(outputComponentControl.ListElement);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var y = new List<Product>();
            y.Add(new Product { Name = "Petya", Pname = "Hren", Count = 14 });
            y.Add(new Product { Name = "Masha", Pname = "Tomato", Count = 15 });
            y.Add(new Product { Name = "Petya", Pname = "Tomato", Count = 16 });
            pdfDiagramComponent1.CreateDiagram(y, @"D:\diagram.pdf");
            createBackUpComponent1.BackUp(y, @"D:\backUp.json");
            excelReporterComponent1.CreateExcelReport(y, @"D:\book1");
        }
    }
}
