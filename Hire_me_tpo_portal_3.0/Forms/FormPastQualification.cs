using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Hire_me_tpo_portal_3._0.Forms
{
    public partial class FormPastQualification : Form
    {
        // fields
        private bool _isenabled = false;
        public FormPastQualification()
        {
            InitializeComponent();
            DisableAll();
        }

        private void FormPastQualification_Load(object sender, EventArgs e)
        {

        }

        private void iconEdit_Click(object sender, EventArgs e)
        {
            if (_isenabled)
            {
                DisableAll();
            }
            else
            {
                enableAll();
            }

        }

        private void DisableAll()
        {
            educationCard1.Enabled = false;
            educationCard2.Enabled = false;
            educationCard3.Enabled = false;
            _isenabled = false;
        } 
        
        private void enableAll()
        {
            educationCard1.Enabled = true;
            educationCard2.Enabled = true;
            educationCard3.Enabled = true;
            _isenabled = true;
        }

        private void iconSave_Click(object sender, EventArgs e)
        {
            // insert into query 
        }
    }
}
