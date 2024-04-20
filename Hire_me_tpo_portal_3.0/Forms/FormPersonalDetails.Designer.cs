namespace Hire_me_tpo_portal_3._0.Forms
{
    partial class FormPersonalDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonalDetails));
            this.bottonPanel = new System.Windows.Forms.Panel();
            this.iconEdit = new FontAwesome.Sharp.IconButton();
            this.iconSave = new FontAwesome.Sharp.IconButton();
            this.RenderPanel = new System.Windows.Forms.Panel();
            this.branchTextbox = new Hire_me_tpo_portal_3._0.ComboBoxWithLabel();
            this.isSeda = new Hire_me_tpo_portal_3._0.downMenu();
            this.pancardNumber = new Hire_me_tpo_portal_3._0.TextboxWithLabel();
            this.adharCardNumber = new Hire_me_tpo_portal_3._0.TextboxWithLabel();
            this.alternateNumber = new Hire_me_tpo_portal_3._0.TextboxWithLabel();
            this.personalEmail = new Hire_me_tpo_portal_3._0.TextboxWithLabel();
            this.contactNumber = new Hire_me_tpo_portal_3._0.TextboxWithLabel();
            this.nationalaity = new Hire_me_tpo_portal_3._0.TextboxWithLabel();
            this.birthdate = new Hire_me_tpo_portal_3._0.DatePickerWithLabel();
            this.lastName = new Hire_me_tpo_portal_3._0.TextboxWithLabel();
            this.middleName = new Hire_me_tpo_portal_3._0.TextboxWithLabel();
            this.firstName = new Hire_me_tpo_portal_3._0.TextboxWithLabel();
            this.gender = new Hire_me_tpo_portal_3._0.DropDownMenu();
            this.prnNumber = new Hire_me_tpo_portal_3._0.TextboxWithLabel();
            this.bottonPanel.SuspendLayout();
            this.RenderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottonPanel
            // 
            this.bottonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.bottonPanel.Controls.Add(this.iconEdit);
            this.bottonPanel.Controls.Add(this.iconSave);
            this.bottonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottonPanel.Location = new System.Drawing.Point(0, 785);
            this.bottonPanel.Name = "bottonPanel";
            this.bottonPanel.Size = new System.Drawing.Size(1607, 76);
            this.bottonPanel.TabIndex = 15;
            // 
            // iconEdit
            // 
            this.iconEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconEdit.BackColor = System.Drawing.Color.Salmon;
            this.iconEdit.FlatAppearance.BorderSize = 0;
            this.iconEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEdit.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.iconEdit.IconColor = System.Drawing.Color.Black;
            this.iconEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconEdit.Location = new System.Drawing.Point(1366, 14);
            this.iconEdit.Margin = new System.Windows.Forms.Padding(5);
            this.iconEdit.Name = "iconEdit";
            this.iconEdit.Size = new System.Drawing.Size(105, 48);
            this.iconEdit.TabIndex = 3;
            this.iconEdit.Text = "Edit";
            this.iconEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconEdit.UseVisualStyleBackColor = false;
            this.iconEdit.Click += new System.EventHandler(this.iconEdit_Click);
            // 
            // iconSave
            // 
            this.iconSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconSave.FlatAppearance.BorderSize = 0;
            this.iconSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconSave.IconColor = System.Drawing.Color.Black;
            this.iconSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconSave.Location = new System.Drawing.Point(1484, 14);
            this.iconSave.Margin = new System.Windows.Forms.Padding(5);
            this.iconSave.Name = "iconSave";
            this.iconSave.Size = new System.Drawing.Size(110, 48);
            this.iconSave.TabIndex = 2;
            this.iconSave.Text = "Save ";
            this.iconSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconSave.UseVisualStyleBackColor = false;
            this.iconSave.Click += new System.EventHandler(this.iconSave_Click);
            // 
            // RenderPanel
            // 
            this.RenderPanel.Controls.Add(this.branchTextbox);
            this.RenderPanel.Controls.Add(this.isSeda);
            this.RenderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RenderPanel.Location = new System.Drawing.Point(0, 0);
            this.RenderPanel.Name = "RenderPanel";
            this.RenderPanel.Size = new System.Drawing.Size(1607, 861);
            this.RenderPanel.TabIndex = 29;
            // 
            // branchTextbox
            // 
            this.branchTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.branchTextbox.ListItems = ((System.Collections.Generic.List<string>)(resources.GetObject("branchTextbox.ListItems")));
            this.branchTextbox.Location = new System.Drawing.Point(12, 336);
            this.branchTextbox.Name = "branchTextbox";
            this.branchTextbox.PlaceHolder = "Branch";
            this.branchTextbox.Size = new System.Drawing.Size(379, 123);
            this.branchTextbox.TabIndex = 19;
            // 
            // isSeda
            // 
            this.isSeda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.isSeda.Location = new System.Drawing.Point(413, 486);
            this.isSeda.Name = "isSeda";
            this.isSeda.PlaceholderName = "Are you a Seda Student ?";
            this.isSeda.Size = new System.Drawing.Size(379, 123);
            this.isSeda.TabIndex = 18;
            this.isSeda.TextboxValue = -1;
            // 
            // pancardNumber
            // 
            this.pancardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.pancardNumber.Location = new System.Drawing.Point(12, 486);
            this.pancardNumber.Name = "pancardNumber";
            this.pancardNumber.PlaceholderName = "Pancard Number";
            this.pancardNumber.Size = new System.Drawing.Size(379, 123);
            this.pancardNumber.TabIndex = 28;
            this.pancardNumber.TextboxValue = "";
            this.pancardNumber.value = false;
            // 
            // adharCardNumber
            // 
            this.adharCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.adharCardNumber.Location = new System.Drawing.Point(1216, 336);
            this.adharCardNumber.Name = "adharCardNumber";
            this.adharCardNumber.PlaceholderName = "Adhar Card Number";
            this.adharCardNumber.Size = new System.Drawing.Size(379, 123);
            this.adharCardNumber.TabIndex = 27;
            this.adharCardNumber.TextboxValue = "";
            this.adharCardNumber.value = false;
            // 
            // alternateNumber
            // 
            this.alternateNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.alternateNumber.Location = new System.Drawing.Point(814, 336);
            this.alternateNumber.Name = "alternateNumber";
            this.alternateNumber.PlaceholderName = "Alternate Contact Number";
            this.alternateNumber.Size = new System.Drawing.Size(379, 123);
            this.alternateNumber.TabIndex = 26;
            this.alternateNumber.TextboxValue = "";
            this.alternateNumber.value = false;
            // 
            // personalEmail
            // 
            this.personalEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.personalEmail.Location = new System.Drawing.Point(413, 336);
            this.personalEmail.Name = "personalEmail";
            this.personalEmail.PlaceholderName = "Personal Email Id";
            this.personalEmail.Size = new System.Drawing.Size(379, 123);
            this.personalEmail.TabIndex = 25;
            this.personalEmail.TextboxValue = "";
            this.personalEmail.value = false;
            // 
            // contactNumber
            // 
            this.contactNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.contactNumber.Location = new System.Drawing.Point(1216, 184);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.PlaceholderName = "Contact Number";
            this.contactNumber.Size = new System.Drawing.Size(379, 123);
            this.contactNumber.TabIndex = 24;
            this.contactNumber.TextboxValue = "";
            this.contactNumber.value = false;
            // 
            // nationalaity
            // 
            this.nationalaity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.nationalaity.Location = new System.Drawing.Point(814, 184);
            this.nationalaity.Name = "nationalaity";
            this.nationalaity.PlaceholderName = "Nationalaity";
            this.nationalaity.Size = new System.Drawing.Size(379, 123);
            this.nationalaity.TabIndex = 23;
            this.nationalaity.TextboxValue = "";
            this.nationalaity.value = false;
            // 
            // birthdate
            // 
            this.birthdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.birthdate.date = new System.DateTime(2024, 4, 1, 20, 44, 12, 487);
            this.birthdate.Location = new System.Drawing.Point(413, 184);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(379, 123);
            this.birthdate.TabIndex = 22;
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.lastName.Location = new System.Drawing.Point(1216, 35);
            this.lastName.Name = "lastName";
            this.lastName.PlaceholderName = "Last Name";
            this.lastName.Size = new System.Drawing.Size(379, 123);
            this.lastName.TabIndex = 21;
            this.lastName.TextboxValue = "";
            this.lastName.value = false;
            // 
            // middleName
            // 
            this.middleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.middleName.Location = new System.Drawing.Point(814, 35);
            this.middleName.Name = "middleName";
            this.middleName.PlaceholderName = "Middle Name";
            this.middleName.Size = new System.Drawing.Size(379, 123);
            this.middleName.TabIndex = 20;
            this.middleName.TextboxValue = "";
            this.middleName.value = false;
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.firstName.Location = new System.Drawing.Point(413, 35);
            this.firstName.Name = "firstName";
            this.firstName.PlaceholderName = "First Name";
            this.firstName.Size = new System.Drawing.Size(379, 123);
            this.firstName.TabIndex = 19;
            this.firstName.TextboxValue = "";
            this.firstName.value = false;
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.gender.Location = new System.Drawing.Point(12, 184);
            this.gender.Name = "gender";
            this.gender.PlaceholderName = "Gender";
            this.gender.Size = new System.Drawing.Size(379, 123);
            this.gender.TabIndex = 17;
            this.gender.TextboxValue = -1;
            // 
            // prnNumber
            // 
            this.prnNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.prnNumber.Location = new System.Drawing.Point(12, 35);
            this.prnNumber.Name = "prnNumber";
            this.prnNumber.PlaceholderName = "Registration Number";
            this.prnNumber.Size = new System.Drawing.Size(379, 123);
            this.prnNumber.TabIndex = 16;
            this.prnNumber.TextboxValue = "";
            this.prnNumber.value = false;
            // 
            // FormPersonalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1607, 861);
            this.Controls.Add(this.pancardNumber);
            this.Controls.Add(this.adharCardNumber);
            this.Controls.Add(this.alternateNumber);
            this.Controls.Add(this.personalEmail);
            this.Controls.Add(this.contactNumber);
            this.Controls.Add(this.nationalaity);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.prnNumber);
            this.Controls.Add(this.bottonPanel);
            this.Controls.Add(this.RenderPanel);
            this.Name = "FormPersonalDetails";
            this.Text = "Personal Details";
            this.Load += new System.EventHandler(this.FormPersonalDetails_Load);
            this.bottonPanel.ResumeLayout(false);
            this.RenderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel bottonPanel;
        private TextboxWithLabel prnNumber;
        private DropDownMenu gender;
        private downMenu isSeda;
        private TextboxWithLabel firstName;
        private TextboxWithLabel middleName;
        private TextboxWithLabel lastName;
        private DatePickerWithLabel birthdate;
        private TextboxWithLabel nationalaity;
        private TextboxWithLabel contactNumber;
        private TextboxWithLabel personalEmail;
        private TextboxWithLabel alternateNumber;
        private TextboxWithLabel adharCardNumber;
        private TextboxWithLabel pancardNumber;
        private FontAwesome.Sharp.IconButton iconEdit;
        private FontAwesome.Sharp.IconButton iconSave;
        private System.Windows.Forms.Panel RenderPanel;
        private ComboBoxWithLabel branchTextbox;
    }
}