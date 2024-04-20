using Dapper;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X509.SigI;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Hire_me_tpo_portal_3._0.Forms
{
    public partial class FormPastQualification : Form
    {
        // fields
        private bool _isenabled = false;
        public Users user;
        public FormPastQualification(Users user)
        {
            this.user = user;
            InitializeComponent();
            DisableAll();
            loadData(user);
        }

        private void FormPastQualification_Load(object sender, EventArgs e)
        {

        }

        private void iconEdit_Click(object sender, EventArgs e)
        {
            if (_isenabled)
            {
                DisableAll();
            }
            else
            {
                enableAll();
            }

        }

        private void DisableAll()
        {
            educationCard1.Enabled = false;
            educationCard2.Enabled = false;
            educationCard3.Enabled = false;
            _isenabled = false;
        } 
        
        private void enableAll()
        {
            educationCard1.Enabled = true;
            educationCard2.Enabled = true;
            educationCard3.Enabled = true;
            _isenabled = true;
        }

        private void iconSave_Click(object sender, EventArgs e)
        {
            // insert data of education card 1 
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new
                {
                    prn_number = user.key_value,
                    education = educationCard1.education,
                    university = educationCard1.university,
                    institute_name = educationCard1.institueName,
                    percentage = educationCard1.percentage,
                    passing_year = educationCard1.passingYear
                };
                connection.Execute("hire_me.add_past_qualifaction", parameters, commandType: CommandType.StoredProcedure);
            }

            // insert data of education card 2
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new
                {
                    prn_number = user.key_value,
                    education = educationCard2.education,
                    university = educationCard2.university,
                    institute_name = educationCard2.institueName,
                    percentage = educationCard2.percentage,
                    passing_year = educationCard2.passingYear
                };
                connection.Execute("hire_me.add_past_qualifaction", parameters, commandType: CommandType.StoredProcedure);
            }

            // insert data of education card 3 
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new
                {
                    prn_number = user.key_value,
                    education = educationCard3.education,
                    university = educationCard3.university,
                    institute_name = educationCard3.institueName,
                    percentage = educationCard3.percentage,
                    passing_year = educationCard3.passingYear
                };
                connection.Execute("hire_me.add_past_qualifaction", parameters, commandType: CommandType.StoredProcedure);
            }

            MessageBox.Show("Data Uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void loadData(Users user)
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new { prn_number = user.key_value };
                var pastQualifactions = connection.Query<PastQualifaction>("hire_me.get_past_qualifaction;", parameters, commandType: CommandType.StoredProcedure);
                if(pastQualifactions == null)
                {
                    return;
                }
                pastQualifactions = pastQualifactions.ToList();
                int count = 1;
                foreach (PastQualifaction pastQualifaction in pastQualifactions)
                {
                    if (count == 1)
                    {
                        educationCard1.education = pastQualifaction.education;
                        educationCard1.university = pastQualifaction.university;
                        educationCard1.institueName = pastQualifaction.institute_name;
                        educationCard1.percentage = pastQualifaction.percentage;
                        educationCard1.passingYear = pastQualifaction.passing_year;
                    }

                    if (count == 2)
                    {
                        educationCard2.education = pastQualifaction.education;
                        educationCard2.university = pastQualifaction.university;
                        educationCard2.institueName = pastQualifaction.institute_name;
                        educationCard2.percentage = pastQualifaction.percentage;
                        educationCard2.passingYear = pastQualifaction.passing_year;
                    }

                    if (count == 3)
                    {
                        educationCard3.education = pastQualifaction.education;
                        educationCard3.university = pastQualifaction.university;
                        educationCard3.institueName = pastQualifaction.institute_name;
                        educationCard3.percentage = pastQualifaction.percentage;
                        educationCard3.passingYear = pastQualifaction.passing_year;
                    }

                    if (count > 3)
                    {
                        count = 0;
                    }
                    count++;
                }
               
            }
        }
    }
}
