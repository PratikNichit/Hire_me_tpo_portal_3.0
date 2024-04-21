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
    public partial class TextboxWithLabel : UserControl
    {
        //fields 
        private string placeholderName;

        public TextboxWithLabel()
        {
            InitializeComponent();
        }

        [Category("Get and Set Properties")]
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

        [Category("Get and Set Properties")]
        public string TextboxValue
        {
            get { return textbox.Text; }
            set
            {
                textbox.Text = value;
            }
        }

        [Category("Get and Set Properties")]
        public Boolean value
        {
            get { return textbox.ReadOnly; }
            set
            {
                textbox.ReadOnly = value;
            }
        }
    }
}
