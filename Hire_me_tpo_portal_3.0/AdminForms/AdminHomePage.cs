using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hire_me_tpo_portal_3._0.AdminForms
{
    public partial class AdminHomePage : Form
    {
        // fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public AdminHomePage()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ActiveButton();
            openChidForm(new AdminForms.FormAdminDashboard());
        }

        // Structur for RBG colors
        private struct RBGcolors
        {
            public static Color color1 = Color.FromArgb(0, 191, 159);
            public static Color color2 = Color.FromArgb(255, 108, 131);
            public static Color color3 = Color.FromArgb(129, 131, 255);
            public static Color color4 = Color.FromArgb(211, 211, 211);
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
            labelTitleChidForm.Text = childForm.Text;
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGcolors.color1);
            openChidForm(new AdminForms.FormAdminDashboard());
        }

        private void AddCompany_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGcolors.color2);
            openChidForm(new AdminForms.FormAddCompany());
        }

        private void AddVacancy_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGcolors.color3);
            openChidForm(new AdminForms.FormAddVacancy());
        }

        private void ExportData_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGcolors.color4);
            openChidForm(new AdminForms.FormExportData(panelDesktop));
        }

        private void profileSetting_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGcolors.color5);
            openChidForm(new AdminForms.FormAdminProfileSettings());
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconFullScreen_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
    }
}
