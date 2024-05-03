namespace Hire_me_tpo_portal_3._0.AdminForms
{
    partial class FormAdminProfileSettings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lastName = new Hire_me_tpo_portal_3._0.OneLineTextboxWithLabel();
            this.department = new Hire_me_tpo_portal_3._0.OneLineTextboxWithLabel();
            this.firstName = new Hire_me_tpo_portal_3._0.OneLineTextboxWithLabel();
            this.EmployeeId = new Hire_me_tpo_portal_3._0.OneLineTextboxWithLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.position = new Hire_me_tpo_portal_3._0.OneLineTextboxWithLabel();
            this.bottonPanel = new System.Windows.Forms.Panel();
            this.iconEdit = new FontAwesome.Sharp.IconButton();
            this.iconSave = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bottonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.position);
            this.panel1.Controls.Add(this.lastName);
            this.panel1.Controls.Add(this.department);
            this.panel1.Controls.Add(this.firstName);
            this.panel1.Controls.Add(this.EmployeeId);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(449, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 482);
            this.panel1.TabIndex = 1;
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.Color.White;
            this.lastName.Location = new System.Drawing.Point(31, 231);
            this.lastName.MultiLine = false;
            this.lastName.Name = "lastName";
            this.lastName.PlaceHolder = "Last Name";
            this.lastName.Size = new System.Drawing.Size(655, 47);
            this.lastName.TabIndex = 7;
            this.lastName.Value = "";
            // 
            // department
            // 
            this.department.BackColor = System.Drawing.Color.White;
            this.department.Location = new System.Drawing.Point(31, 296);
            this.department.MultiLine = false;
            this.department.Name = "department";
            this.department.PlaceHolder = "Department";
            this.department.Size = new System.Drawing.Size(655, 47);
            this.department.TabIndex = 6;
            this.department.Value = "";
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.Color.White;
            this.firstName.Location = new System.Drawing.Point(31, 169);
            this.firstName.MultiLine = false;
            this.firstName.Name = "firstName";
            this.firstName.PlaceHolder = "First Name";
            this.firstName.Size = new System.Drawing.Size(655, 47);
            this.firstName.TabIndex = 2;
            this.firstName.Value = "";
            // 
            // EmployeeId
            // 
            this.EmployeeId.BackColor = System.Drawing.Color.White;
            this.EmployeeId.Location = new System.Drawing.Point(31, 94);
            this.EmployeeId.MultiLine = false;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.PlaceHolder = "Employee ID";
            this.EmployeeId.Size = new System.Drawing.Size(655, 47);
            this.EmployeeId.TabIndex = 1;
            this.EmployeeId.Value = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 64);
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
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Profile";
            // 
            // position
            // 
            this.position.BackColor = System.Drawing.Color.White;
            this.position.Location = new System.Drawing.Point(31, 359);
            this.position.MultiLine = false;
            this.position.Name = "position";
            this.position.PlaceHolder = "Position";
            this.position.Size = new System.Drawing.Size(655, 47);
            this.position.TabIndex = 8;
            this.position.Value = "";
            // 
            // bottonPanel
            // 
            this.bottonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.bottonPanel.Controls.Add(this.iconEdit);
            this.bottonPanel.Controls.Add(this.iconSave);
            this.bottonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottonPanel.Location = new System.Drawing.Point(0, 738);
            this.bottonPanel.Name = "bottonPanel";
            this.bottonPanel.Size = new System.Drawing.Size(1589, 76);
            this.bottonPanel.TabIndex = 16;
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
            this.iconEdit.Location = new System.Drawing.Point(1348, 14);
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
            this.iconSave.Location = new System.Drawing.Point(1466, 14);
            this.iconSave.Margin = new System.Windows.Forms.Padding(5);
            this.iconSave.Name = "iconSave";
            this.iconSave.Size = new System.Drawing.Size(110, 48);
            this.iconSave.TabIndex = 2;
            this.iconSave.Text = "Save ";
            this.iconSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconSave.UseVisualStyleBackColor = false;
            // 
            // FormAdminProfileSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1589, 814);
            this.Controls.Add(this.bottonPanel);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdminProfileSettings";
            this.Text = "Profile Settings";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bottonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private OneLineTextboxWithLabel lastName;
        private OneLineTextboxWithLabel department;
        private OneLineTextboxWithLabel firstName;
        private OneLineTextboxWithLabel EmployeeId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private OneLineTextboxWithLabel position;
        private System.Windows.Forms.Panel bottonPanel;
        private FontAwesome.Sharp.IconButton iconEdit;
        private FontAwesome.Sharp.IconButton iconSave;
    }
}