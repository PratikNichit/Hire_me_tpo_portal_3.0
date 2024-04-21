using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            industryType.ListItems = new List<string> { 
                "Information Technology",
                "Electronics Core",
                "Core Engineering",
                "Finance and Consulting",
                "Automobile",
                "Research and Development",
                "Startups",
                "manufacturing "
            };
        }

        private void companyType_Load(object sender, EventArgs e)
        {
            companyType.ListItems = new List<string> { "Regular","special"};
        }

        private void offerings_Load(object sender, EventArgs e)
        {
            offerings.ListItems = new List<string> { "Internships", "Internships + PPO", "Placement" };
        }

        private void iconAdd_Click(object sender, EventArgs e)
        {
            insertData();

        }

        public void insertData()
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new
                {
                    industry_type = industryType.Value,
                    name = companyName.Value,
                    company_type = companyType.Value,
                    location  = location.Value,
                    offerings = offerings.Value,
                    company_address = address.Value,
                    company_email_id = email.Value,
                    min_package = minPackage.Value,
                    max_pachage = maxPackage.Value,
                    about = about.Value,
                };
                connection.Execute("hire_me.add_company_info", parameters, commandType: CommandType.StoredProcedure);
                MessageBox.Show("Data Uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
