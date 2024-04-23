using Dapper;
using Hire_me_tpo_portal_3._0.Models;
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

namespace Hire_me_tpo_portal_3._0.AdminForms
{
    public partial class FormExportData : Form 
    {

        // fields 
        Panel panelDesktop;
        private Form currentChildForm;
        public FormExportData(Panel panelDesktop)
        {
            InitializeComponent();
            loadDataIntoGrid();
            DataGridVacancy.CellClick += DataGridVacancy_CellClick;
            this.panelDesktop = panelDesktop;
        }

        public void loadDataIntoGrid()
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var vacancyInfos = connection.Query<VacancyInfo>("SELECT * FROM hire_me.vacancy_dashboard;");
                DataGridVacancy.DataSource = vacancyInfos.ToList();
            }

        }

        private void DataGridVacancy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is valid
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value of the clicked cell
                object cellValue = DataGridVacancy.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                int value = int.Parse(cellValue.ToString());
                openChidForm(new AdminForms.FormExportDataToExcel(value,panelDesktop));
            }
        }

        public void openChidForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
