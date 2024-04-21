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
    public partial class DatePickerWithLabel : UserControl
    {
        public DatePickerWithLabel()
        {
            InitializeComponent();
        }

        [Category("Extra Properties")]
        public DateTime date
        {
            get { return datepicker.Value; }
            set
            {
                datepicker.Value = value;

            }
        }
    }
}