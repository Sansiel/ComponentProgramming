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
        string regex = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";

        public string TemplateMail
        {
            get { return maskedTextBox.Text; }
            set { maskedTextBox.Text = value; }
        }

        public EnterFieldControl()
        {
            InitializeComponent();
            DangerColor = Color.Red;
            AcceptColor = Color.Green;
        }

        public EnterFieldControl(Color dangerColor, Color acceptColor)
        {
            InitializeComponent();
            this.DangerColor = dangerColor;
            this.AcceptColor = acceptColor;
        }

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
