using System;
using System.Windows.Forms;

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

        private void buttonChange_Click_1(object sender, EventArgs e)
        {
            //selectComponentControl.SelectedIndex = 0;
            //MessageBox.Show(enterFieldControl1.TemplateMail);
            string[] countries = { "Бразилия", "Аргентина", "Чили", "Уругвай", "Колумбия" };
            outputComponentControl1.AddGroupToList(countries);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(outputComponentControl1.ListElement);
        }
    }
}
