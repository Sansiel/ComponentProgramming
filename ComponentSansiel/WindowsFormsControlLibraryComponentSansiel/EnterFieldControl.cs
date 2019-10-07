using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsControlLibraryComponentSansiel
{
    public partial class EnterFieldControl : UserControl
    {
        public Color DangerColor { get; set; }
        public Color AcceptColor { get; set; }
        //string regex = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
        string regex = @"\d\d\.\d\d\.\d\d\d\d";

        /// <summary>
        /// Изменение регулярки
        /// </summary>
        public string TemplateRegex
        {
            get { return regex; }
            set { regex = value; }
        }

        /// <summary>
        /// Получение или измененние значения в максБоксе
        /// </summary>
        public string TemplateText
        {
            get { return maskedTextBox.Text; }
            set { maskedTextBox.Text = value; }
        }

        /// <summary>
        /// Получение или измененние значения в максБоксе в виде даты
        /// </summary>
        public string TemplateData
        {
            get { return maskedTextBox.Text; }
            set { maskedTextBox.Text = value; }
        }

        /// <summary>
        /// конструктор
        /// </summary>
        public EnterFieldControl()
        {
            InitializeComponent();
            DangerColor = Color.Red;
            AcceptColor = Color.Green;
        }

        /// <summary>
        /// Конструктор меняющий цвета
        /// </summary>
        public EnterFieldControl(Color dangerColor, Color acceptColor)
        {
            InitializeComponent();
            this.DangerColor = dangerColor;
            this.AcceptColor = acceptColor;
        }

        /// <summary>
        /// Проверка на вшивость
        /// </summary>
        private void maskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(maskedTextBox.Text, regex))
            {
                maskedTextBox.BackColor = DangerColor;
            }
            else
            {
                maskedTextBox.BackColor = AcceptColor;
            }
        }
    }
}
