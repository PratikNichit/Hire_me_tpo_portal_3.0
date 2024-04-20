using Dapper;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X509.SigI;
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

namespace Hire_me_tpo_portal_3._0.Forms
{
    public partial class FormAcademics : Form
    {
        //fields
        private bool isClicked = true;
        public Users user;
        public PersonalData personalData;
        public FormAcademics(Users user, PersonalData personalData)
        {
            this.user = user;
            InitializeComponent();
            disableAll();
            this.personalData = personalData;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconEdit_Click(object sender, EventArgs e)
        {
            if (isClicked)
            {
                enableAll();
                isClicked = false;
            }
            else
            {
                disableAll();
                isClicked = true;
            }
        }

        public void disableAll()
        {
            pursingYear.Enabled = false;
            currentBackLogs.Enabled = false;
            deadBacklogs.Enabled = false;
            currentCGPA.Enabled = false;
            pursingInternship.Enabled = false;
            isPlaced.Enabled= false;
        }

        public void enableAll()
        {
            pursingYear.Enabled = true;
            currentBackLogs.Enabled = true;
            deadBacklogs.Enabled = true;
            currentCGPA.Enabled = true;
            pursingInternship.Enabled = true;
            isPlaced.Enabled = true;
        }

        private void iconSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               pursingYear.Text+" "+
               currentBackLogs.Value+" "+
               deadBacklogs.Value+" "+
               currentCGPA.Text+" "+
               pursingInternship.Text+" "+
               isPlaced.Text
            );

            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new
                {
                    prn_number = user.key_value,
                    pursuing_year = int.Parse(pursingYear.Text),
                    current_backlog = currentBackLogs.Value,
                    dead_backlog = deadBacklogs.Value,
                    current_cgpa = float.Parse(currentCGPA.Text),
                    pursing_internship = pursingInternship.SelectedIndex,
                    is_placed  = isPlaced.SelectedIndex,
                };
                connection.Execute("hire_me.add_academic_details", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        // form on load 
        private void FormAcademics_Load(object sender, EventArgs e)
        {
            if (personalData != null)
            {
                pursingYear.Text = personalData.pursuing_year.ToString();
                currentBackLogs.Value = personalData.current_backlog;
                deadBacklogs.Value = personalData.dead_backlog;
                currentCGPA.Text = personalData.current_cgpa.ToString();
                pursingInternship.SelectedIndex = personalData.pursing_internship;
                isPlaced.SelectedIndex = personalData.is_placed;
            }

        }
    }
}
