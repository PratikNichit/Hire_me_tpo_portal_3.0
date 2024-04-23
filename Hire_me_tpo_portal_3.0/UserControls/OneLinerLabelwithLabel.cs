using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hire_me_tpo_portal_3._0.UserControls
{
    public partial class OneLinerLabelwithLabel : UserControl
    {
        public OneLinerLabelwithLabel()
        {
            InitializeComponent();
        }
        [Category("extra Properties")]
        public string PlaceHolder
        {
            get { return placeholder.Text; }
            set { placeholder.Text = value; }
        }

        [Category("extra Properties")]
        public string Value
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

    }
}
