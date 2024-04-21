namespace Hire_me_tpo_portal_3._0.AdminForms
{
    partial class FormAddCompany
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCompany));
            this.panel1 = new System.Windows.Forms.Panel();
            this.about = new Hire_me_tpo_portal_3._0.OneLineTextboxWithLabel();
            this.address = new Hire_me_tpo_portal_3._0.OneLineTextboxWithLabel();
            this.maxPackage = new Hire_me_tpo_portal_3._0.OneLineTextboxWithLabel();
            this.minPackage = new Hire_me_tpo_portal_3._0.OneLineTextboxWithLabel();
            this.email = new Hire_me_tpo_portal_3._0.OneLineTextboxWithLabel();
            this.offerings = new Hire_me_tpo_portal_3._0.oneLineComboBox();
            this.companyType = new Hire_me_tpo_portal_3._0.oneLineComboBox();
            this.industryType = new Hire_me_tpo_portal_3._0.oneLineComboBox();
            this.location = new Hire_me_tpo_portal_3._0.OneLineTextboxWithLabel();
            this.companyName = new Hire_me_tpo_portal_3._0.OneLineTextboxWithLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconAdd = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.about);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.maxPackage);
            this.panel1.Controls.Add(this.minPackage);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.offerings);
            this.panel1.Controls.Add(this.companyType);
            this.panel1.Controls.Add(this.industryType);
            this.panel1.Controls.Add(this.location);
            this.panel1.Controls.Add(this.companyName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(107, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1397, 482);
            this.panel1.TabIndex = 0;
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.White;
            this.about.Location = new System.Drawing.Point(710, 380);
            this.about.MultiLine = true;
            this.about.Name = "about";
            this.about.PlaceHolder = "About";
            this.about.Size = new System.Drawing.Size(655, 60);
            this.about.TabIndex = 10;
            this.about.Value = "";
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.White;
            this.address.Location = new System.Drawing.Point(710, 302);
            this.address.MultiLine = true;
            this.address.Name = "address";
            this.address.PlaceHolder = "Address";
            this.address.Size = new System.Drawing.Size(655, 60);
            this.address.TabIndex = 9;
            this.address.Value = "";
            // 
            // maxPackage
            // 
            this.maxPackage.BackColor = System.Drawing.Color.White;
            this.maxPackage.Location = new System.Drawing.Point(710, 242);
            this.maxPackage.MultiLine = false;
            this.maxPackage.Name = "maxPackage";
            this.maxPackage.PlaceHolder = "Maximun Package";
            this.maxPackage.Size = new System.Drawing.Size(655, 47);
            this.maxPackage.TabIndex = 8;
            this.maxPackage.Value = "";
            // 
            // minPackage
            // 
            this.minPackage.BackColor = System.Drawing.Color.White;
            this.minPackage.Location = new System.Drawing.Point(710, 169);
            this.minPackage.MultiLine = false;
            this.minPackage.Name = "minPackage";
            this.minPackage.PlaceHolder = "Minimum Package";
            this.minPackage.Size = new System.Drawing.Size(655, 47);
            this.minPackage.TabIndex = 7;
            this.minPackage.Value = "";
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(710, 94);
            this.email.MultiLine = false;
            this.email.Name = "email";
            this.email.PlaceHolder = "Company\'s Email ID";
            this.email.Size = new System.Drawing.Size(655, 47);
            this.email.TabIndex = 6;
            this.email.Value = "";
            // 
            // offerings
            // 
            this.offerings.ListItems = ((System.Collections.Generic.List<string>)(resources.GetObject("offerings.ListItems")));
            this.offerings.Location = new System.Drawing.Point(31, 393);
            this.offerings.Name = "offerings";
            this.offerings.PlaceHolder = "Offerings";
            this.offerings.Size = new System.Drawing.Size(655, 47);
            this.offerings.TabIndex = 5;
            this.offerings.Load += new System.EventHandler(this.offerings_Load);
            // 
            // companyType
            // 
            this.companyType.ListItems = ((System.Collections.Generic.List<string>)(resources.GetObject("companyType.ListItems")));
            this.companyType.Location = new System.Drawing.Point(31, 315);
            this.companyType.Name = "companyType";
            this.companyType.PlaceHolder = "Company Type";
            this.companyType.Size = new System.Drawing.Size(655, 47);
            this.companyType.TabIndex = 4;
            this.companyType.Load += new System.EventHandler(this.companyType_Load);
            // 
            // industryType
            // 
            this.industryType.ListItems = ((System.Collections.Generic.List<string>)(resources.GetObject("industryType.ListItems")));
            this.industryType.Location = new System.Drawing.Point(31, 242);
            this.industryType.Name = "industryType";
            this.industryType.PlaceHolder = "Industry Type";
            this.industryType.Size = new System.Drawing.Size(655, 47);
            this.industryType.TabIndex = 3;
            this.industryType.Load += new System.EventHandler(this.industryType_Load);
            // 
            // location
            // 
            this.location.BackColor = System.Drawing.Color.White;
            this.location.Location = new System.Drawing.Point(31, 169);
            this.location.MultiLine = false;
            this.location.Name = "location";
            this.location.PlaceHolder = "Job location";
            this.location.Size = new System.Drawing.Size(655, 47);
            this.location.TabIndex = 2;
            this.location.Value = "";
            // 
            // companyName
            // 
            this.companyName.BackColor = System.Drawing.Color.White;
            this.companyName.Location = new System.Drawing.Point(31, 94);
            this.companyName.MultiLine = false;
            this.companyName.Name = "companyName";
            this.companyName.PlaceHolder = "Company\'s Name";
            this.companyName.Size = new System.Drawing.Size(655, 47);
            this.companyName.TabIndex = 1;
            this.companyName.Value = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1395, 64);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Companies\'s Information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.iconAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 785);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1607, 76);
            this.panel3.TabIndex = 6;
            // 
            // iconAdd
            // 
            this.iconAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconAdd.FlatAppearance.BorderSize = 0;
            this.iconAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iconAdd.IconColor = System.Drawing.Color.Black;
            this.iconAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconAdd.Location = new System.Drawing.Point(1482, 14);
            this.iconAdd.Margin = new System.Windows.Forms.Padding(5);
            this.iconAdd.Name = "iconAdd";
            this.iconAdd.Size = new System.Drawing.Size(110, 48);
            this.iconAdd.TabIndex = 7;
            this.iconAdd.Text = "Add";
            this.iconAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconAdd.UseVisualStyleBackColor = false;
            this.iconAdd.Click += new System.EventHandler(this.iconAdd_Click);
            // 
            // FormAddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1607, 861);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddCompany";
            this.Text = "Add Company";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private OneLineTextboxWithLabel companyName;
        private OneLineTextboxWithLabel location;
        private oneLineComboBox industryType;
        private oneLineComboBox companyType;
        private oneLineComboBox offerings;
        private OneLineTextboxWithLabel maxPackage;
        private OneLineTextboxWithLabel minPackage;
        private OneLineTextboxWithLabel email;
        private OneLineTextboxWithLabel address;
        private OneLineTextboxWithLabel about;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconAdd;
    }
}