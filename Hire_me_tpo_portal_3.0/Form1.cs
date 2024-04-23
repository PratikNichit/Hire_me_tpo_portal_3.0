using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Hire_me_tpo_portal_3._0.Forms;

namespace Hire_me_tpo_portal_3._0
{
    public partial class Form1 : Form
    {
        // fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public Users user;

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ActiveButton();
            openChidForm(new Forms.FormDashBoard());
        }

        public Form1(Users users)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ActiveButton();
            openChidForm(new Forms.FormDashBoard());
            aboutEmail.Text = users.email_id.ToString();
            aboutType.Text = users.user_type.ToString();
            user = users;
        }

        // Structur for RBG colors
        private struct RBGcolors
        {
            public static Color color1 = Color.FromArgb(0, 191, 159);
            public static Color color2 = Color.FromArgb(255, 108, 131);
            public static Color color3 = Color.FromArgb(129, 131, 255);
            public static Color color4 = Color.FromArgb(235, 105, 73);
            public static Color color5 = Color.FromArgb(250, 191, 34);

        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Icon current chid form
                iconCurrentChidForm.IconChar = currentBtn.IconChar;
                iconCurrentChidForm.IconColor = color;

            }
        }

        private void ActiveButton()
        {

                currentBtn = (IconButton)Dashboard;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.FromArgb(0, 191, 159);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(0, 191, 159);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Left border button
                leftBorderBtn.BackColor = Color.FromArgb(0, 191, 159);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Icon current chid form
                iconCurrentChidForm.IconChar = currentBtn.IconChar;
                iconCurrentChidForm.IconColor = Color.FromArgb(0, 191, 159);

        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(97, 110, 254);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        public void openChidForm(Form childForm)
        {
            if(currentChildForm != null)
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
            labelTitleChidForm.Text = childForm.Text;
            labelTitleChidForm.ForeColor = iconCurrentChidForm.ForeColor;
        }



        // Menu Buttons
        private void Dashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGcolors.color1);
            openChidForm(new Forms.FormDashBoard());
        }

        private void sheheduled_companies_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGcolors.color2);
            openChidForm(new Forms.FormSheheduledCompanies(user,panelDesktop));
        }

        private void companies_dashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGcolors.color3);
            openChidForm(new Forms.FormCompaniesDashboard());
        }

        private void applied_companies_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGcolors.color4);
            openChidForm(new Forms.FormAppliedCompanies(user,panelDesktop));
        }

        private void profile_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGcolors.color5);
            openChidForm(new Forms.FormProfileSetting(user));
        }

        private void iconPictureBoxLogo_Click(object sender, EventArgs e)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChidForm.IconChar = IconChar.Home;
            iconCurrentChidForm.IconColor = Color.FromArgb(0, 191, 159);
            labelTitleChidForm.Text = "Dashboard";
        }


     // Title Bar Control button

        // close button
        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimize button
        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // maximize Button
        private void iconFullScreen_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
    }
}
