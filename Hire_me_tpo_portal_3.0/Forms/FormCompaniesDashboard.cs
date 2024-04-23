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
using MySql.Data;
using MySql.Data.MySqlClient;
using Dapper;
using System.Reflection;

namespace Hire_me_tpo_portal_3._0.Forms
{
    public partial class FormCompaniesDashboard : Form
    {
        public FormCompaniesDashboard()
        {
            InitializeComponent();
            DataTable dt = new DataTable();


        }

        private void FormCompaniesDashboard_Load(object sender, EventArgs e)
        {
            loadDataIntoGrid();
        }

        public void loadDataIntoGrid()
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var company = connection.Query<CompanyInfo>("SELECT * FROM company_dashboard");
                dataGridCompanies.DataSource =  company.ToList();
            }

        }


    }
}
