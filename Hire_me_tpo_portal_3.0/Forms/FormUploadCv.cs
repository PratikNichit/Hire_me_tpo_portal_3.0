using Dapper;
using Hire_me_tpo_portal_3._0.Models;
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
    public partial class FormUploadCv : Form
    {
        // fields
        private Users users;
        private ResumeLink resumeLink;
        public FormUploadCv(Users users)
        {
            InitializeComponent();
            this.users = users;
            loadData();
            if(resumeLink != null)
            {
                linkAddress.Text = resumeLink.resume_link;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new
                {
                    id = users.key_value,
                    link = linkAddress.Text
                };
                connection.Execute("hire_me.update_resume_link", parameters, commandType: CommandType.StoredProcedure);
            }

            MessageBox.Show("Data Uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadData()
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new { id = users.key_value };
                var resumes = connection.Query<ResumeLink>("hire_me.get_remume_link;", parameters, commandType: CommandType.StoredProcedure);
                resumes = resumes.ToList();
                foreach (ResumeLink resume in resumes)
                {
                    resumeLink = resume;
                }
            }
        }
    }
}
