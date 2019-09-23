using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsControlLibraryComponentSansiel
{
    public partial class SelectComponentControl : UserControl
    {
        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>

        private int _selectedIndex;

        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>

        private event EventHandler _comboBoxSelectedElementChange;

        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>

        [Category("Спецификация"), Description("Порядковый номер выбранного элемента")]

        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                if (value > -2 && value < comboBox.Items.Count)
                {
                    _selectedIndex = value;
                    comboBox.SelectedIndex = _selectedIndex;
                }
            }
        }
        /// <summary>
        /// Текст выбранной записи
        /// </summary>

        [Category("Спецификация"), Description("Текст выбранной записи")]

        public string SelectedText
        {
            get { return comboBox.Text; }
        }

        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>

        [Category("Спецификация"), Description("Событие выбора элемента из списка")]

        public event EventHandler ComboBoxSelectedElementChange
        {
            add { _comboBoxSelectedElementChange += value; }
            remove { _comboBoxSelectedElementChange -= value; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>

        public SelectComponentControl()
        {
            InitializeComponent();
            comboBox.SelectedIndexChanged += (sender, e) => {
                _comboBoxSelectedElementChange?.Invoke(sender, e);
            };
        }

        /// <summary>
        /// Заполнение списка значениями из справочника
        /// </summary>
        /// <param name="type">тип-справочник</param>

        public void LoadEnumeration(Type type)
        {
            foreach (var elem in Enum.GetValues(type))
            {
                comboBox.Items.Add(elem.ToString());
            }
        }
    }
}
