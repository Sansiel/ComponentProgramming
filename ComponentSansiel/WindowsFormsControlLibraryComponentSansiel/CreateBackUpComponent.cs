using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;

namespace WindowsFormsControlLibraryComponentSansiel
{
    public partial class CreateBackUpComponent : Component
    {
        public CreateBackUpComponent()
        {
            InitializeComponent();
        }

        public CreateBackUpComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void BackUp<T>(List<T> toBackUp)
        {
            foreach (var temp in toBackUp)
            {
                var typeTemp = temp.GetType().CustomAttributes;
                if (typeTemp.Count() == 0)
                {
                    MessageBox.Show("No attributs");
                    return;
                }
                foreach (var t in typeTemp)
                {
                    if (!(t.AttributeType.Name.Equals("DataContractAttribute")))
                    {
                        MessageBox.Show("Not atach serialization");
                        return;
                    }
                }
            }
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, toBackUp);
            }
        }
    }
}
