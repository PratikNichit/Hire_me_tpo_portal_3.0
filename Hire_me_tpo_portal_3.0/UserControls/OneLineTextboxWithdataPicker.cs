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
    public partial class OneLineTextboxWithdataPicker : UserControl
    {
        public OneLineTextboxWithdataPicker()
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
        public DateTime Value
        {
            get { return datePicker1.Value; }
            set 
            {
                datePicker1.Value = value;
            }
        }

    }
}
