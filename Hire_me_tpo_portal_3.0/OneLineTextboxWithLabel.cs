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
    public partial class OneLineTextboxWithLabel : UserControl
    {
        public OneLineTextboxWithLabel()
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

        [Category("extra Properties")]
        public bool MultiLine
        {
            get { return textBox.Multiline; }
            set 
            {
                if(value == true)
                {
                    textBox.Height = 40;
                    textBox.Multiline = value;
                }
                textBox.Multiline = value; 
            }
        }
    }
}
