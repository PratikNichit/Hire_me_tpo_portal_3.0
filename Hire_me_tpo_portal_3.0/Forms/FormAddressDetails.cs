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

namespace Hire_me_tpo_portal_3._0.Forms
{
    public partial class FormAddressDetails : Form
    {
        // fields 
        private bool _isEnabled = false;
        public Users user;
        public PersonalData personaldata;
        public FormAddressDetails(Users user,PersonalData personaldata)
        {
            this.user = user;
            InitializeComponent();
            disableAll();
            this.user = user;
            this.personaldata = personaldata;
            loadData();
        }

        private void iconEdit_Click(object sender, EventArgs e)
        {
            if (_isEnabled)
            {
                disableAll();
            }
            else
            {
                enableAll();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            currentAddress.Text = permanentAddress.Text;
        }

        private void enableAll()
        {
            currentAddress.Enabled = true;
            permanentAddress.Enabled = true;
            _isEnabled = true;
        }

        private void disableAll()
        {
            currentAddress.Enabled = false;
            permanentAddress.Enabled = false;
            _isEnabled = false;
        }

        private void iconSave_Click(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new
                {
                     prn_number = user.key_value,
                     current = currentAddress.Text,
                     permanent = permanentAddress.Text
                };
                connection.Execute("hire_me.add_address_details", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void loadData()
        {
            if(personaldata != null)
            {
                permanentAddress.Text = personaldata.permanent_address;
                currentAddress.Text = personaldata.current_address;
            }
        }
    }
}
