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
    public partial class downMenu : UserControl
    {
        //fields 
        private string placeholderName;

        public downMenu()
        {
            InitializeComponent();
        }
        [Category("Extra Properties")]
        public string PlaceholderName
        {
            get
            {
                return placeholder.Text;
            }
            set
            {
                placeholder.Text = value;
            }
        }

        [Category("Extra Properties")]
        public int TextboxValue
        {
            get { return combobox.SelectedIndex; }
            set
            {
                combobox.SelectedIndex = value;
            }
        }
    }
}
