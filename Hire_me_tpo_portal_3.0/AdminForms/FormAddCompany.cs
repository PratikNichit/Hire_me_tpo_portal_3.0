using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hire_me_tpo_portal_3._0.AdminForms
{
    public partial class FormAddCompany : Form
    {
        public FormAddCompany()
        {
            InitializeComponent();
        }

        private void industryType_Load(object sender, EventArgs e)
        {
            industryType.ListItems = new List<string> { "IT", "Entc Core", "Mech" };
        }

        private void companyType_Load(object sender, EventArgs e)
        {
            companyType.ListItems = new List<string> { "Regular","special"};
        }

        private void offerings_Load(object sender, EventArgs e)
        {
            offerings.ListItems = new List<string> {"InternShip","Internship + PPO ","Placement"};
        }

        private void iconAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               companyName.Value+" "+
               companyType.Value+" "+
               industryType.Value+" "+
               location.Value+" "+
               offerings.Value+" "+
               email.Value+" "+
               minPackage.Value+" "+
               maxPackage.Value+" "+
               address.Value+" "+
               about.Value+" "
            ) ;
        }
    }
}
