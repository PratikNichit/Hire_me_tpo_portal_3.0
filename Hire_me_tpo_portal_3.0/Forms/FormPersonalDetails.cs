using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public FormPersonalDetails()
        {
            InitializeComponent();
            disableAllCompoents();
        }

        private void iconEdit_Click(object sender, EventArgs e)
        {
            if (hasclicked == false)
            {
                disableAllCompoents();
            }
            else
            {
                prnNumber.Enabled = true;
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
            hasclicked = true;
        }

        private void iconSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(prnNumber.TextboxValue + " " +
                firstName.TextboxValue + " " +
                middleName.TextboxValue + " " +
                lastName.TextboxValue + " " +
                gender.TextboxValue + " " +
                birthdate.date + " " +
                nationalaity.TextboxValue + " " +
                contactNumber.TextboxValue + " " +
                isSeda.TextboxValue + " " +
                personalEmail.TextboxValue + " " +
                alternateNumber.TextboxValue + " " +
                adharCardNumber.TextboxValue + " " +
                pancardNumber.TextboxValue + " ");
        }
    }
}
