using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Configuration;
using Dapper;
using Hire_me_tpo_portal_3._0.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Mysqlx.Crud;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;

namespace Hire_me_tpo_portal_3._0.AdminForms
{
    public partial class FormAddVacancy : Form
    {
        // fields
        public string filePath;
        public FormAddVacancy()
        {
            InitializeComponent();
            loadSource();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName.Text = openFileDialog.FileName;
            }
        }

        public void saveFile()
        {
            File.Copy(FileName.Text,Path.Combine(@"C:\Users\Pratik Nichit\source\repos\Hire_me_tpo_portal_3.0\Hire_me_tpo_portal_3.0\Company_Attachments\",Path.GetFileName(FileName.Text)),true);
            filePath = Path.Combine(@"C:\Users\Pratik Nichit\source\repos\Hire_me_tpo_portal_3.0\Hire_me_tpo_portal_3.0\Company_Attachments\", Path.GetFileName(FileName.Text));
            MessageBox.Show("File Uploaded !!"+filePath);
            FileName.Text = Path.GetFileName(FileName.Text);
        }

        private void uploadFile_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        public void loadSource()
        {
            setDataSoruce();
            cadidateType.ListItems = new List<string> { "General", "Female Only" };
            offerings.ListItems = new List<string> { "Internships", "Internships + PPO", "Placement" };
            dead_backlogs.ListItems = new List<string> { "Not Allowed", "Allowed" };
            current_backlogs.ListItems = new List<string> { "Not Allowed", "Allowed" };
            year_down.ListItems = new List<string> { "Not Allowed", "Allowed" };
            Pursuing_internship.ListItems = new List<string> { "Not Allowed", "Allowed" };
        }
        private void setDataSoruce()
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var company = connection.Query<Companies>("SELECT name from hire_me.company_info");
                company.ToList();
                List<string> list = new List<string>();
                foreach (var value in company)
                {
                    list.Add(value.name);
                }

                companyName.ListItems = list;
            }
        }

        public void insertData()
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new
                {
                    company_name = companyName.Value,
                    job_location = location.Value,
                    no_of_vacancy = int.Parse(noOfVacancy.Value),
                    registation_start_date = registation_start.Value,
                    registation_end_date = registation_end.Value,
                    min_package = double.Parse(minPackage.Value),
                    max_package = double.Parse(maxPackage.Value),
                    offering_name = offerings.Value,
                    dead_backlogs = mapBooleanValues(dead_backlogs.Value),
                    current_backlogs = mapBooleanValues(current_backlogs.Value),
                    year_down = mapBooleanValues(year_down.Value),
                    pursuing_internship = mapBooleanValues(Pursuing_internship.Value),
                    candidate_type = cadidateType.Value,
                    stipend_amound = double.Parse(Stipend_amount.Value),
                    min_cgpa = double.Parse(min_cgpa.Value),
                    min_ssc_percentage = double.Parse(min_scc.Value),
                    min_hsc_percentage = double.Parse(min_hsc.Value),
                    min_diploma_percentage = double.Parse(min_diploma.Value),
                    computer_science = checkIf(check1),
                    information_technology = checkIf(check2),
                    Artificial_Intelligence_and_Data_Science = checkIf(check3),
                    Artificial_Intelligence_and_machine_learning = checkIf(check4),
                    Electronics_and_telecommunication = checkIf(check5),
                    instrumentation = checkIf(check6),
                    production = checkIf(check7),
                    chemical = checkIf(check8),
                    filePath = filePath
                };
                connection.Execute("hire_me.insert_into_vacancy", parameters, commandType: CommandType.StoredProcedure);
                MessageBox.Show("Data Uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public int mapBooleanValues(string value)
        {
            if (value == "Applied")
            {
                return 1;
            }
            return 0;
        }

        public int checkIf(CheckBox box)
        {
            if (box.Checked)
            {
                return 1;
            }
            return 0;
        }

        private void iconAdd_Click(object sender, EventArgs e)
        {
            insertData();
        }
    }
}
