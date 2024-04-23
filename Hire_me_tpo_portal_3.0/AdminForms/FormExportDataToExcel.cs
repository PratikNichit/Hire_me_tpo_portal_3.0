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
using OfficeOpenXml;
using System.IO;


namespace Hire_me_tpo_portal_3._0.AdminForms
{
    public partial class FormExportDataToExcel : Form
    {
        //fields 
        private int vacancyId;
        private Panel panelDesktop;
        private Form currentChildForm;
        public FormExportDataToExcel( int vacancyId, Panel panelDesktop)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            InitializeComponent();
            this.vacancyId = vacancyId;
            loadDataIntoGrid();
            this.panelDesktop = panelDesktop;
        }

        public void loadDataIntoGrid()
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new { id = vacancyId };
                var applications = connection.Query<ApplicationData>("hire_me.get_applications_by_vacancy_id", parameters, commandType: CommandType.StoredProcedure);
                DataGridApplications.DataSource = applications.ToList();
            }

        }

        public static void ExportToExcel(DataGridView dataGridView)
        {
            // Create and configure SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save Excel File";
            saveFileDialog.FileName = "ExportedData.xlsx"; // Default filename

            // Show SaveFileDialog and export data if user selects a file
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                    // Write column headers
                    for (int i = 0; i < dataGridView.ColumnCount; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                    }

                    // Write data
                    for (int i = 0; i < dataGridView.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView.ColumnCount; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value;
                        }
                    }

                    // Save the Excel file
                    FileInfo excelFile = new FileInfo(filePath);
                    excelPackage.SaveAs(excelFile);

                    MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            ExportToExcel(DataGridApplications);
            openChidForm(new AdminForms.FormExportData(panelDesktop));
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
