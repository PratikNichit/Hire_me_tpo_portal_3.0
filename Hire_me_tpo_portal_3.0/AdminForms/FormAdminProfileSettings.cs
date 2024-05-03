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

namespace Hire_me_tpo_portal_3._0.AdminForms
{
    public partial class FormAdminProfileSettings : Form
    {
        //fields
        public bool isEnable=false;
        public FormAdminProfileSettings()
        {
            InitializeComponent();
            disableAllCompoents();
        }

        public void disableAllCompoents()
        {
            EmployeeId.Enabled = false;
            firstName.Enabled = false;
            lastName.Enabled = false;   
            department.Enabled = false;
            position.Enabled = false;   
        }

        private void iconEdit_Click(object sender, EventArgs e)
        {
            if (isEnable == false)
            {
                enableAllCompoents();
            }
            else
            {
                disableAllCompoents();
            }
        }

        public void enableAllCompoents()
        {
            firstName.Enabled = true;
            lastName.Enabled = true;
            department.Enabled = true;
            position.Enabled = true;
        }
    }
}
