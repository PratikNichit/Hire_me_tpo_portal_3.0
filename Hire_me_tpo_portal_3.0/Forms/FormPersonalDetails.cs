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
    public partial class FormPersonalDetails : Form
    {
        // fields
        private bool hasclicked = false;
        public Users user;
        public PersonalData personaldata;
        public FormPersonalDetails()
        {
            InitializeComponent();
            disableAllCompoents();
            setDataSoruce();
        }

        public FormPersonalDetails(Users user, PersonalData personalData)
        {
            InitializeComponent();
            disableAllCompoents();
            setDataSoruce();
            this.user = user;
            this.personaldata = personalData;
            prnNumber.TextboxValue = this.user.key_value.ToString();
        }

        private void iconEdit_Click(object sender, EventArgs e)
        {
            if (hasclicked == false)
            {
                disableAllCompoents();
            }
            else
            {
                firstName.Enabled = true;
                middleName.Enabled = true;
                lastName.Enabled = true;
                gender.Enabled = true;
                birthdate.Enabled = true;
                nationalaity.Enabled = true;
                contactNumber.Enabled = true;
                isSeda.Enabled = true;
                personalEmail.Enabled = true;
                alternateNumber.Enabled = true;
                adharCardNumber.Enabled = true;
                pancardNumber.Enabled = true;
                hasclicked = false;
                branchTextbox.Enabled = true;
            }

        }

        private void disableAllCompoents()
        {
            prnNumber.Enabled = false;
            firstName.Enabled = false;
            middleName.Enabled = false;
            lastName.Enabled = false;
            gender.Enabled = false;
            birthdate.Enabled = false;
            nationalaity.Enabled = false;
            contactNumber.Enabled = false;
            isSeda.Enabled = false;
            personalEmail.Enabled = false;
            alternateNumber.Enabled = false;
            adharCardNumber.Enabled = false;
            pancardNumber.Enabled = false;
            branchTextbox.Enabled = false;
            hasclicked = true;
        }

        private void setDataSoruce() 
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var branch = connection.Query<Branches>("SELECT program_name FROM Programs");
                branch.ToList();
                List<string> list = new List<string>();
                foreach(var value in branch)
                {
                    list.Add(value.program_name);
                }

                branchTextbox.ListItems = list;
            }
        }

        private void iconSave_Click(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new
                {
                    prn_number = long.Parse(prnNumber.TextboxValue),
                    first_name = firstName.TextboxValue,
                    middle_name = middleName.TextboxValue,
                    last_name = lastName.TextboxValue,
                    branch_name = branchTextbox.Value,
                    gender = gender.TextboxValue,
                    birth_date = birthdate.date,
                    nationality = nationalaity.TextboxValue,
                    contact_no = long.Parse(contactNumber.TextboxValue),
                    is_seda = isSeda.TextboxValue,
                    personal_email_id = personalEmail.TextboxValue,
                    alternate_contact_no = long.Parse(alternateNumber.TextboxValue),
                    adhar_card_no = long.Parse(adharCardNumber.TextboxValue),
                    pan_card_no  = pancardNumber.TextboxValue
                };
                connection.Execute("hire_me.update_students_personal_details", parameters, commandType: CommandType.StoredProcedure);
            }

            MessageBox.Show("Data Updated Successfully");
        }


        // form onload 
        private void FormPersonalDetails_Load(object sender, EventArgs e)
        {
            if(personaldata != null)
            {
                firstName.TextboxValue = personaldata.first_name;
                middleName.TextboxValue = personaldata.middle_name;
                lastName.TextboxValue = personaldata.last_name;
                branchTextbox.selectIndex = int.Parse(personaldata.branch_name)-1;
                gender.TextboxValue = personaldata.gender;
                birthdate.date = DateTime.Parse(personaldata.birth_date);
                nationalaity.TextboxValue = personaldata.nationality;
                contactNumber.TextboxValue = personaldata.contact_no.ToString();
                isSeda.TextboxValue = personaldata.is_seda;
                personalEmail.TextboxValue = personaldata.personal_email_id;
                alternateNumber.TextboxValue = personaldata.alternate_contact_no.ToString();
                adharCardNumber.TextboxValue = personaldata.adhar_card_no.ToString();
                pancardNumber.TextboxValue = personaldata.pan_card_no.ToString();
            }

        }
    }
}
