using Dapper;
using MySql.Data.MySqlClient;
using Mysqlx.Connection;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hire_me_tpo_portal_3._0
{
    public partial class LoginPage : Form
    {
        //fields
        private string placeholder;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // Calculate the position to center the panel
            int panelX = (this.ClientSize.Width - panel.Width) / 2;
            int panelY = (this.ClientSize.Height - panel.Height) / 2;

            // Set the panel's location
            panel.Location = new System.Drawing.Point(panelX, panelY);
            SignInPanel.Location = new System.Drawing.Point((int)panelX, (int)panelY-150);
            loginButton.Focus();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            using (var connection  = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new { email = email_id.Text, pass = password.Text };
                var user = connection.Query<Users>("hire_me.get_login_creads", parameters, commandType: CommandType.StoredProcedure);
                user = user.ToList();

                if(user.Count() == 0)
                {
                    password_error.Text = "invalid email id or password";
                }

                foreach(var user_data in user)
                {
                    // login login and from Routing will be done 
                    if (email_id.Text == user_data.email_id && password.Text == user_data.password)
                    {
                        this.Hide();
                        if(user_data.user_type == "Student")
                        {
                            Form1 form1 = new Form1(user_data);
                            form1.Show();
                        }
                        else
                        {
                            AdminForms.AdminHomePage adminHomePage = new AdminForms.AdminHomePage();
                            adminHomePage.Show();
                        }

                    }
                    else
                    {
                        email_error.Text = "invalid email";
                        password_error.Text = "invalid passowrd";
                    }
                }


            }
               
        }

        private void email_id_Enter(object sender, EventArgs e)
        {
            email_id.Text = string.Empty;
            email_id.ForeColor = Color.Black;
        }

        private void password_Enter(object sender, EventArgs e)
        {
            password.Text = string.Empty;  
            password.ForeColor = Color.Black;
            password.UseSystemPasswordChar = true;
        }

        private void panel3_Leave(object sender, EventArgs e)
        {
            if(email_id.Text == "")
            {
                email_id.Text = " email";
                email_id.ForeColor = Color.DarkGray;
            }

        }

        private void password_Leave(object sender, EventArgs e)
        {
            if(password.Text == "")
            {
                password.Text = " password";
                password.ForeColor = Color.DarkGray;
                password.UseSystemPasswordChar = false;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel.Visible = false;
            SignInPanel.Visible = true;
        }

        private void SignInEmail_Enter(object sender, EventArgs e)
        {
            SignInEmail.Text = string.Empty;
            SignInEmail.ForeColor = Color.Black;
        }

        private void SignInEmail_Leave(object sender, EventArgs e)
        {
            if(SignInEmail.Text == "")
            {
                SignInEmail.Text = " email";
                SignInEmail.ForeColor = Color.DarkGray;
            }
        }

        private void SignInPassword_Enter(object sender, EventArgs e)
        {
            SignInPassword.Text = string.Empty;
            SignInPassword.ForeColor = Color.Black;
            SignInPassword.UseSystemPasswordChar=true;
        }

        private void SignInPassword_Leave(object sender, EventArgs e)
        {
            if(SignInPassword.Text == "")
            {
                SignInPassword.Text = " password";
                SignInPassword.ForeColor = Color.DarkGray;
                SignInPassword.UseSystemPasswordChar =false;
            }
        }



        private void SignInType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SignInType.SelectedItem.ToString() == "Student")
            {
                key.Text = "prn number";
                key.ForeColor = Color.DarkGray;
            }
            if(SignInType.SelectedItem.ToString() == "Admin")
            {
                key.Text = "employe id";
                key.ForeColor = Color.DarkGray;
            }
        }

        private void key_Enter(object sender, EventArgs e)
        {
            placeholder = key.Text;
            key.Text = string.Empty;
            key.ForeColor = Color.Black;
        }

        private void key_Leave(object sender, EventArgs e)
        {
            if(key.Text == "")
            {
                key.Text = placeholder;
                key.ForeColor = Color.DarkGray;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel.Visible = true;
            SignInPanel.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            insertUser();

            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new { email = SignInEmail.Text, pass = SignInPassword.Text };
                var user = connection.Query<Users>("hire_me.get_login_creads", parameters, commandType: CommandType.StoredProcedure);
                foreach (var user_data in user)
                {
                      this.Hide();
                      Form1 form1 = new Form1(user_data);
                      form1.Show();
                }

            }

        }

        public void insertUser()
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new { email_id = SignInEmail.Text, password = SignInPassword.Text, key_value = long.Parse(key.Text), user_type = SignInType.Text };
                var user = connection.Query<Users>("hire_me.create_user", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
