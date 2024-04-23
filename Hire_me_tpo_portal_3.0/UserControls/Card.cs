using Dapper;
using FontAwesome.Sharp;
using Hire_me_tpo_portal_3._0.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
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
using System.Windows.Markup;

namespace Hire_me_tpo_portal_3._0
{
    public partial class Card : UserControl
    {

        //fields 
        public int vancancyId;
        public int companyId;
        public Users users;
        private Form currentChildForm;
        private Panel panelDesktop;
        private VacancyDataForCard data;
        private CriteriaData criteriaData;
        public Card()
        {
            InitializeComponent();
        }
        public Card(Panel panelDesktop,Users users,bool off)
        {
            InitializeComponent();
            this.panelDesktop = panelDesktop;   
            this.users = users;
            if (off)
            {
                ApplyButton.Enabled = false;
            }
        }

        [Category("Extra Properties")]
        public string nameOfCompany
        {
            get
            {
                return CompanyName1.Text;
            }
            set
            {
                CompanyName1.Text = value;
            }
        }

        [Category("Extra Properties")]
        public string companyOffering
        {
            get
            {
                return labelOffering.Text;
            }
            set
            {
                labelOffering.Text = value;
            }
        }

        [Category("Extra Properties")]
        public string registrationEndDate
        {
            get
            {
                return labelEndTime.Text;
            }
            set
            {
                labelEndTime.Text = value;
            }
        }

        [Category("Extra Properties")]
        public string status
        {
            get
            {
                return labelAppliedStatus.Text;
            }
            set
            {
                if(value == "not Applied")
                {
                    labelAppliedStatus.Text = value;
                    labelAppliedStatus.ForeColor = Color.Red;
                }

            }
        }

        [Category("Extra Properties")]
        public string logo
        {
            get
            {
                if(iconStatus.IconChar.ToString() == "ThumbsUp")
                {
                    return "up";
                }

                if (iconStatus.IconChar.ToString() == "ThumbsDown")
                {
                    return "down";
                }

                return iconStatus.IconChar.ToString();
            }
            set
            {
                if(value == "up")
                {
                    iconStatus.IconChar = IconChar.ThumbsUp;
                }
                if(value == "down")
                {
                    iconStatus.IconChar = IconChar.ThumbsDown;
                    iconStatus.ForeColor = Color.Red;
                }

            }
        }

        [Category("Extra Properties")]
        public int Vacancyid
        {
            get
            {
                return vancancyId;
            }
            set
            {
                vancancyId = value;
            }
        }

        [Category("Extra Properties")]
        public int Companyid
        {
            get
            {
                return companyId;
            }
            set
            {
                companyId = value;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChidForm(new Forms.FormViewVacancyDetails(vancancyId,companyId,panelDesktop));
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

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            loadCriteriaData();
            loadVacancyDataIntoForm();
            checkIfCriteriaMatch();

        }

        private void checkIfCriteriaMatch()
        {
            if (criteriaData.profile_status != 1)
            {
                MessageBox.Show("Complete your profile Before applying to any Vacancy");
                return;
            }
            DateTime now = DateTime.Now;
            int result1 = DateTime.Compare(now, data.registation_start_date);
            int result2 = DateTime.Compare(now, data.registation_end_date);
            if ( result1 >= 0)
            {
                if( result2 <= 0)
                {
                    if (checkMarks())
                    {
                        if(data.candidate_type == "General")
                        {
                            if (checkLogs())
                            {
                                insertIntoApplications();
                            }
                            else
                            {
                                return;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Gender criteria do not Match ");
                            return;
                        }

                        if( data.candidate_type == "Female Only" & criteriaData.gender == "Female")
                        {
                            if (checkLogs())
                            {
                                insertIntoApplications();
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Registation Date has End");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Registation has Not stated yet ");
            }

        }

        private void insertIntoApplications()
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new
                {
                    id = users.key_value,
                    id_vacancy = 5,
                    id_company = 8,
                    registation_start = data.registation_start_date
                };
                connection.Execute("hire_me.insert_into_Applications", parameters, commandType: CommandType.StoredProcedure);
                MessageBox.Show("sucessfully applied for the vacancy");
            }
        }

        private bool checkMarks()
        {
            if(criteriaData.current_cgpa < data.min_cgpa)
            {
                MessageBox.Show("CGPA criteria do not Match ");
                return false;
            }

            if (criteriaData.scc_percentage < data.min_ssc_percentage)
            {
                MessageBox.Show("Scc percentage criteria do not Match ");
                return false;

            }
            if(criteriaData.is_seda == 1)
            {
                if(criteriaData.diploma_percentage < data.min_diploma_percentage)
                {
                    MessageBox.Show("Diploma percentage criteria do not Match ");
                    return false;
                }
            }
            else
            {
                if (criteriaData.hsc_percentage < data.min_hsc_percentage)
                {
                    MessageBox.Show("HSC percentage criteria do not Match ");
                    return false;
                }
            }

            return true;
        }

        public bool checkLogs()
        {
            if(data.current_backlogs == "Not Allowed")
            {
                if(criteriaData.current_backlog > 0)
                {
                    MessageBox.Show("Criteria Do Not Match");
                    return false;
                }
            }

            if(data.dead_backlogs == "Not Allowed")
            {
                if (criteriaData.dead_backlog > 0)
                {
                    MessageBox.Show("Criteria Do Not Match");
                    return false;
                }
            }

            if (data.pursuing_internship == "Not Allowed")
            {
                if (criteriaData.pursing_internship == 1)
                {
                    MessageBox.Show("Criteria Do Not Match");
                    return false;
                }
            }

            return true;
        }

        public void loadVacancyDataIntoForm()
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

        public void loadCriteriaData()
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new { id = users.key_value };
                var criteria = connection.Query<CriteriaData>("hire_me.get_marks", parameters, commandType: CommandType.StoredProcedure);
                criteria = criteria.ToList();
                foreach (var item in criteria)
                {
                    criteriaData = item;
                }
            }
        } 
    }
}
