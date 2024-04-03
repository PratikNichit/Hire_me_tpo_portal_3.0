using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hire_me_tpo_portal_3._0.Forms
{
    public partial class FormProfileSetting : Form
    {

        // fields
        private Form currentForm = new FormPersonalDetails();
        private List<Form> forms = new List<Form>();
        public int currentChlidFormNumber=0;

        // Array of Form
        public FormProfileSetting()
        {
            InitializeComponent();
            forms.Add(new FormPersonalDetails());
            forms.Add(new FormAcademics());
            forms.Add(new FormPastQualification());
            forms.Add(new FormAddressDetails());
            forms.Add(new FormUploadCv());


            showCurrentFrom();
        }


        private void FormProfileSetting_Load(object sender, EventArgs e)
        {

        }

        private void iconNext_Click(object sender, EventArgs e)
        {
            currentChlidFormNumber++;

            if(currentChlidFormNumber >= forms.Count)
            {
                currentChlidFormNumber = 0;
                showCurrentFrom();

            }

            showCurrentFrom();
        }

        private void showCurrentFrom()
        {
            foreach(Form form in forms)
            {
                form.Hide();
            }

            profileDesktopPanel.Controls.Clear();
            Form current = forms[currentChlidFormNumber];
            current.TopLevel = false;
            current.FormBorderStyle = FormBorderStyle.None;
            current.Dock = DockStyle.Fill;
            profileDesktopPanel.Controls.Add(current);
            current.BringToFront();
            current.Show();
            labelTitle.Text = current.Text;
        }

        private void iconBack_Click(object sender, EventArgs e)
        {
            currentChlidFormNumber--;
            if (currentChlidFormNumber <= -1)
            {
                currentChlidFormNumber = 4;
                showCurrentFrom();

            }
            showCurrentFrom();
        }
    }
}
