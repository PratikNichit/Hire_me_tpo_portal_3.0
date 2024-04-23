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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hire_me_tpo_portal_3._0.Forms
{
    public partial class FormViewVacancyDetails : Form
    {
        //fields
        private int vacancyId;
        private int companyId;
        private Panel panelDesktop;
        private VacancyDataForCard data;
        private Form currentChildForm;
        public FormViewVacancyDetails(int vacancyId,int companyId,Panel panelDesktop)
        {
            InitializeComponent();
            this.vacancyId = vacancyId;
            this.companyId = companyId;
            this.panelDesktop = panelDesktop;
            loadDataIntoForm();
            loadDataIntoView();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            openChidForm(new FormPdfView(data.file_path));
        }

        public void loadDataIntoForm()
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new { id = 5, companyId = 8 };
                var vacancyDatas = connection.Query<VacancyDataForCard>("hire_me.get_vacancy_by_id", parameters, commandType: CommandType.StoredProcedure);
                vacancyDatas = vacancyDatas.ToList();
                foreach (var vacancyData in vacancyDatas)
                {
                    data = vacancyData;
                }
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

        public void loadDataIntoView()
        {
            FileName.Text = data.file_path;
            companyName.Value = data.company_name;
            location.Value = data.job_location;
            noOfVacancy.Value = data.no_of_vacancy.ToString();
            registation_start.Value = data.registation_start_date.ToString();
            registation_end.Value = data.registation_end_date.ToString();
            offerings.Value = data.offerings;
            cadidateType.Value = data.candidate_type;
            minPackage.Value = data.min_package;
            maxPackage.Value = data.max_package;
            dead_backlogs.Value = data.dead_backlogs;
            current_backlogs.Value = data.current_backlogs;
            year_down.Value = data.year_down;
            Pursuing_internship.Value = data.pursuing_internship;
            Stipend_amount.Value = data.stipend_amound.ToString();
            min_cgpa.Value = data.min_cgpa.ToString();
            min_scc.Value = data.min_ssc_percentage.ToString();
            min_hsc.Value = data.min_hsc_percentage.ToString();
            min_diploma.Value = data.min_diploma_percentage.ToString();
            // check 1
            if(data.computer_science == "1")
            {
                check1.Checked = true;
            }
            else
            {
                check1.Checked = false; 
            }
            // check 2
            if (data.information_technology == "1")
            {
                check2.Checked = true;
            }
            else
            {
                check2.Checked = false;
            }
            // check 3
            if (data.Artificial_Intelligence_and_Data_Science == "1")
            {
                check3.Checked = true;
            }
            else
            {
                check3.Checked = false;
            }
            // check 4
            if (data.Artificial_Intelligence_and_machine_learning == "1")
            {
                check4.Checked = true;
            }
            else
            {
                check4.Checked = false;
            }
            // check 5
            if (data.electronics_and_telecommunication == "1")
            {
                check5.Checked = true;
            }
            else
            {
                check5.Checked = false;
            }
            // check 6
            if (data.instrumentation == "1")
            {
                check6.Checked = true;
            }
            else
            {
                check6.Checked = false;
            }

            // check 7
            if (data.production == "1")
            {
                check7.Checked = true;
            }
            else
            {
                check7.Checked = false;
            }

            // check 8
            if (data.chemical == "1")
            {
                check8.Checked = true;
            }
            else
            {
                check8.Checked = false;
            }
        }
    }
}
