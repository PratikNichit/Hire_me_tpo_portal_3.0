using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hire_me_tpo_portal_3._0
{
    public partial class oneLineComboBox : UserControl
    {
        public oneLineComboBox()
        {
            InitializeComponent();
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        [Category("extra Properties")]
        public string PlaceHolder
        {
            get { return placeholder.Text; }
            set { placeholder.Text = value; }
        }

        [Category("extra Properties")]
        public List<string> ListItems
        {
            get
            {
                List<string> items = new List<string>();
                foreach (var item in comboBox.Items)
                {
                    items.Add(item.ToString());
                }
                return items;
            }
            set
            {
                comboBox.Items.Clear();
                foreach (var item in value)
                {
                    comboBox.Items.Add(item);
                }
            }
        }

        [Category("extra Properties")]
        public string Value
        {
            get 
            { 
                if(comboBox.SelectedItem == null)
                {
                    return " ";
                }
                else
                {
                    return comboBox.SelectedItem.ToString();
                }
            }
        }

        private void comboBox_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
    