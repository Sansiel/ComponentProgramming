using System;
using System.Collections.Generic;
using System.Linq;
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

        public string FieldType {get; set;}

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
        public void AddGroupToList(List<object> o_group)
        {
            foreach (var obj in o_group)
            {
                string outstr = "";
                var filtredProp = obj.GetType().GetProperties().Where((x) => FieldType.Split(' ').Contains(x.Name));
                foreach (var x in filtredProp)
                {
                    outstr += " " + x.GetValue(obj).ToString();
                }
                listBox.Items.Add(outstr);
            }
        }
        



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
