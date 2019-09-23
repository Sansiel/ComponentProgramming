using System.Windows.Forms;

namespace WindowsFormsControlLibraryComponentSansiel
{
    public partial class OutputComponentControl : UserControl
    {
        public int ListIndex
        {
            get { return listBox.SelectedIndex; }
        }

        public string ListElement
        {
            get { return ""+listBox.SelectedItem; }
            set { listBox.SelectedItem = value; }
        }

        public void AddGroupToList(string[] group) { listBox.Items.AddRange(group); }
        public void AddToList(string element) { listBox.Items.Add(element); }
        public void RemoveFromList(string element) { listBox.Items.Remove(element); }
        public void RemoveList() { listBox.Items.Clear(); }

        public OutputComponentControl()
        {
            InitializeComponent();
        }
    }
}
