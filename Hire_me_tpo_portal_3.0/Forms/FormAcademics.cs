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
    public partial class FormAcademics : Form
    {
        //fields
        private bool isClicked = true;
        public FormAcademics()
        {
            InitializeComponent();
            disableAll();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconEdit_Click(object sender, EventArgs e)
        {
            if (isClicked)
            {
                enableAll();
                isClicked = false;
            }
            else
            {
                disableAll();
                isClicked = true;
            }
        }

        public void disableAll()
        {
            pursingYear.Enabled = false;
            currentBackLogs.Enabled = false;
            deadBacklogs.Enabled = false;
            currentCGPA.Enabled = false;
            pursingInternship.Enabled = false;
            isPlaced.Enabled= false;
        }

        public void enableAll()
        {
            pursingYear.Enabled = true;
            currentBackLogs.Enabled = true;
            deadBacklogs.Enabled = true;
            currentCGPA.Enabled = true;
            pursingInternship.Enabled = true;
            isPlaced.Enabled = true;
        }
    }
}
