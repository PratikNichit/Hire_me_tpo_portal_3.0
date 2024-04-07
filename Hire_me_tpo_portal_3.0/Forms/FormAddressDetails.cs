using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hire_me_tpo_portal_3._0.Forms
{
    public partial class FormAddressDetails : Form
    {
        // fields 
        private bool _isEnabled = false;
        public FormAddressDetails()
        {
            InitializeComponent();
            disableAll();
        }

        private void iconEdit_Click(object sender, EventArgs e)
        {
            if (_isEnabled)
            {
                disableAll();
            }
            else
            {
                enableAll();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            currentAddress.Text = permanentAddress.Text;
        }

        private void enableAll()
        {
            currentAddress.Enabled = true;
            permanentAddress.Enabled = true;
            _isEnabled = true;
        }

        private void disableAll()
        {
            currentAddress.Enabled = false;
            permanentAddress.Enabled = false;
            _isEnabled = false;
        }

        private void iconSave_Click(object sender, EventArgs e)
        {
            // insert into query
        }
    }
}
