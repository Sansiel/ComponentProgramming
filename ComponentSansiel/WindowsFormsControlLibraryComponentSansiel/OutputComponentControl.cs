using System.Windows.Forms;

namespace WindowsFormsControlLibraryComponentSansiel
{
    public partial class OutputComponentControl : UserControl
    {
        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        public int ListIndex
        {
            get { return listBox.SelectedIndex; }
        }

        /// <summary>
        /// Значение выбранного элемента
        /// </summary>
        public string ListElement
        {
            get { return ""+listBox.SelectedItem; }
            set { listBox.SelectedItem = value; }
        }

        /// <summary>
        /// Методы добавления
        /// </summary>
        public void AddGroupToList(string[] group) { listBox.Items.AddRange(group); }
        public void AddToList(string element) { listBox.Items.Add(element); }

        /// <summary>
        /// Методы удаления
        /// </summary>
        public void RemoveFromList(string element) { listBox.Items.Remove(element); }
        public void RemoveList() { listBox.Items.Clear(); }

        /// <summary>
        /// Конструктор
        /// </summary>
        public OutputComponentControl()
        {
            InitializeComponent();
        }
    }
}
