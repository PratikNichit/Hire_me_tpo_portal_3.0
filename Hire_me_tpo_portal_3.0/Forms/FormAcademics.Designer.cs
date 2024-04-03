namespace Hire_me_tpo_portal_3._0.Forms
{
    partial class FormAcademics
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
            this.academicsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pursingYear = new System.Windows.Forms.TextBox();
            this.currentBackLogs = new System.Windows.Forms.NumericUpDown();
            this.deadBacklogs = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pursingInternship = new System.Windows.Forms.ComboBox();
            this.isPlaced = new System.Windows.Forms.ComboBox();
            this.currentCGPA = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconEdit = new FontAwesome.Sharp.IconButton();
            this.iconSave = new FontAwesome.Sharp.IconButton();
            this.academicsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentBackLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadBacklogs)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // academicsPanel
            // 
            this.academicsPanel.BackColor = System.Drawing.Color.White;
            this.academicsPanel.Controls.Add(this.currentCGPA);
            this.academicsPanel.Controls.Add(this.deadBacklogs);
            this.academicsPanel.Controls.Add(this.currentBackLogs);
            this.academicsPanel.Controls.Add(this.pursingYear);
            this.academicsPanel.Controls.Add(this.label5);
            this.academicsPanel.Controls.Add(this.label4);
            this.academicsPanel.Controls.Add(this.label3);
            this.academicsPanel.Controls.Add(this.label2);
            this.academicsPanel.Controls.Add(this.panel1);
            this.academicsPanel.Location = new System.Drawing.Point(107, 103);
            this.academicsPanel.Name = "academicsPanel";
            this.academicsPanel.Size = new System.Drawing.Size(576, 435);
            this.academicsPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Academics Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pursing year         :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Backlogs :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dead Backlogs     :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current CGPA       :";
            // 
            // pursingYear
            // 
            this.pursingYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pursingYear.Font = new System.Drawing.Font("Segoe UI Variable Small", 13.8F);
            this.pursingYear.Location = new System.Drawing.Point(210, 109);
            this.pursingYear.Name = "pursingYear";
            this.pursingYear.Size = new System.Drawing.Size(325, 38);
            this.pursingYear.TabIndex = 9;
            // 
            // currentBackLogs
            // 
            this.currentBackLogs.Font = new System.Drawing.Font("Segoe UI Variable Small", 13.8F);
            this.currentBackLogs.Location = new System.Drawing.Point(210, 193);
            this.currentBackLogs.Name = "currentBackLogs";
            this.currentBackLogs.Size = new System.Drawing.Size(325, 38);
            this.currentBackLogs.TabIndex = 10;
            // 
            // deadBacklogs
            // 
            this.deadBacklogs.Font = new System.Drawing.Font("Segoe UI Variable Small", 13.8F);
            this.deadBacklogs.Location = new System.Drawing.Point(210, 267);
            this.deadBacklogs.Name = "deadBacklogs";
            this.deadBacklogs.Size = new System.Drawing.Size(325, 38);
            this.deadBacklogs.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.isPlaced);
            this.panel2.Controls.Add(this.pursingInternship);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(826, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 435);
            this.panel2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 27);
            this.label9.TabIndex = 1;
            this.label9.Text = "Are you pursing Internship  :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 76);
            this.panel3.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Placement Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "Are you Placed                       :";
            // 
            // pursingInternship
            // 
            this.pursingInternship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pursingInternship.Font = new System.Drawing.Font("Segoe UI Variable Small", 13.8F);
            this.pursingInternship.FormattingEnabled = true;
            this.pursingInternship.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.pursingInternship.Location = new System.Drawing.Point(290, 104);
            this.pursingInternship.Name = "pursingInternship";
            this.pursingInternship.Size = new System.Drawing.Size(269, 39);
            this.pursingInternship.TabIndex = 3;
            // 
            // isPlaced
            // 
            this.isPlaced.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isPlaced.Font = new System.Drawing.Font("Segoe UI Variable Small", 13.8F);
            this.isPlaced.FormattingEnabled = true;
            this.isPlaced.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.isPlaced.Location = new System.Drawing.Point(290, 180);
            this.isPlaced.Name = "isPlaced";
            this.isPlaced.Size = new System.Drawing.Size(269, 39);
            this.isPlaced.TabIndex = 4;
            // 
            // currentCGPA
            // 
            this.currentCGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentCGPA.Font = new System.Drawing.Font("Segoe UI Variable Small", 13.8F);
            this.currentCGPA.Location = new System.Drawing.Point(210, 352);
            this.currentCGPA.Name = "currentCGPA";
            this.currentCGPA.Size = new System.Drawing.Size(325, 38);
            this.currentCGPA.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.panel4.Controls.Add(this.iconEdit);
            this.panel4.Controls.Add(this.iconSave);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 785);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1607, 76);
            this.panel4.TabIndex = 14;
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
            this.iconEdit.Location = new System.Drawing.Point(1364, 14);
            this.iconEdit.Margin = new System.Windows.Forms.Padding(5);
            this.iconEdit.Name = "iconEdit";
            this.iconEdit.Size = new System.Drawing.Size(105, 48);
            this.iconEdit.TabIndex = 5;
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
            this.iconSave.Location = new System.Drawing.Point(1482, 14);
            this.iconSave.Margin = new System.Windows.Forms.Padding(5);
            this.iconSave.Name = "iconSave";
            this.iconSave.Size = new System.Drawing.Size(110, 48);
            this.iconSave.TabIndex = 4;
            this.iconSave.Text = "Save ";
            this.iconSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconSave.UseVisualStyleBackColor = false;
            // 
            // FormAcademics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 861);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.academicsPanel);
            this.Name = "FormAcademics";
            this.Text = "Academics";
            this.academicsPanel.ResumeLayout(false);
            this.academicsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentBackLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadBacklogs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel academicsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pursingYear;
        private System.Windows.Forms.NumericUpDown currentBackLogs;
        private System.Windows.Forms.NumericUpDown deadBacklogs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox isPlaced;
        private System.Windows.Forms.ComboBox pursingInternship;
        private System.Windows.Forms.TextBox currentCGPA;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconEdit;
        private FontAwesome.Sharp.IconButton iconSave;
    }
}