namespace Hire_me_tpo_portal_3._0
{
    partial class Card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cardTittlebar = new System.Windows.Forms.Panel();
            this.CompanyName1 = new System.Windows.Forms.Label();
            this.iconOffering = new FontAwesome.Sharp.IconPictureBox();
            this.labelOffering = new System.Windows.Forms.Label();
            this.iconEndTime = new FontAwesome.Sharp.IconPictureBox();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.iconStatus = new FontAwesome.Sharp.IconPictureBox();
            this.labelAppliedStatus = new System.Windows.Forms.Label();
            this.ApplyButton = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cardTittlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconOffering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // cardTittlebar
            // 
            this.cardTittlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.cardTittlebar.Controls.Add(this.CompanyName1);
            this.cardTittlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardTittlebar.Location = new System.Drawing.Point(0, 0);
            this.cardTittlebar.Name = "cardTittlebar";
            this.cardTittlebar.Size = new System.Drawing.Size(293, 69);
            this.cardTittlebar.TabIndex = 0;
            // 
            // CompanyName1
            // 
            this.CompanyName1.AutoSize = true;
            this.CompanyName1.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName1.ForeColor = System.Drawing.Color.White;
            this.CompanyName1.Location = new System.Drawing.Point(65, 20);
            this.CompanyName1.Name = "CompanyName1";
            this.CompanyName1.Size = new System.Drawing.Size(161, 37);
            this.CompanyName1.TabIndex = 0;
            this.CompanyName1.Text = "Tata Power";
            // 
            // iconOffering
            // 
            this.iconOffering.BackColor = System.Drawing.Color.White;
            this.iconOffering.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconOffering.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconOffering.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconOffering.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconOffering.IconSize = 30;
            this.iconOffering.Location = new System.Drawing.Point(28, 95);
            this.iconOffering.Name = "iconOffering";
            this.iconOffering.Size = new System.Drawing.Size(30, 32);
            this.iconOffering.TabIndex = 1;
            this.iconOffering.TabStop = false;
            // 
            // labelOffering
            // 
            this.labelOffering.AutoSize = true;
            this.labelOffering.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOffering.Location = new System.Drawing.Point(73, 99);
            this.labelOffering.Name = "labelOffering";
            this.labelOffering.Size = new System.Drawing.Size(139, 22);
            this.labelOffering.TabIndex = 2;
            this.labelOffering.Text = "Intenship + ppo";
            // 
            // iconEndTime
            // 
            this.iconEndTime.BackColor = System.Drawing.Color.White;
            this.iconEndTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconEndTime.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            this.iconEndTime.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconEndTime.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEndTime.IconSize = 30;
            this.iconEndTime.Location = new System.Drawing.Point(28, 163);
            this.iconEndTime.Name = "iconEndTime";
            this.iconEndTime.Size = new System.Drawing.Size(30, 32);
            this.iconEndTime.TabIndex = 3;
            this.iconEndTime.TabStop = false;
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndTime.Location = new System.Drawing.Point(73, 169);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(182, 22);
            this.labelEndTime.TabIndex = 4;
            this.labelEndTime.Text = "2024-05-05 12:00 pm";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(28, 231);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(57, 22);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status";
            this.labelStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconStatus
            // 
            this.iconStatus.BackColor = System.Drawing.Color.White;
            this.iconStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.iconStatus.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            this.iconStatus.IconColor = System.Drawing.Color.ForestGreen;
            this.iconStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconStatus.IconSize = 47;
            this.iconStatus.Location = new System.Drawing.Point(106, 218);
            this.iconStatus.Name = "iconStatus";
            this.iconStatus.Size = new System.Drawing.Size(50, 47);
            this.iconStatus.TabIndex = 6;
            this.iconStatus.TabStop = false;
            // 
            // labelAppliedStatus
            // 
            this.labelAppliedStatus.AutoSize = true;
            this.labelAppliedStatus.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppliedStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelAppliedStatus.Location = new System.Drawing.Point(162, 231);
            this.labelAppliedStatus.Name = "labelAppliedStatus";
            this.labelAppliedStatus.Size = new System.Drawing.Size(74, 22);
            this.labelAppliedStatus.TabIndex = 7;
            this.labelAppliedStatus.Text = "Applied";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.BackColor = System.Drawing.Color.ForestGreen;
            this.ApplyButton.FlatAppearance.BorderSize = 0;
            this.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButton.Font = new System.Drawing.Font("Segoe UI Variable Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyButton.ForeColor = System.Drawing.Color.White;
            this.ApplyButton.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.ApplyButton.IconColor = System.Drawing.Color.White;
            this.ApplyButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ApplyButton.IconSize = 35;
            this.ApplyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ApplyButton.Location = new System.Drawing.Point(152, 296);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(126, 46);
            this.ApplyButton.TabIndex = 8;
            this.ApplyButton.Text = "Apply Now";
            this.ApplyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApplyButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(191)))), ((int)(((byte)(34)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "More";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.labelAppliedStatus);
            this.Controls.Add(this.iconStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.iconEndTime);
            this.Controls.Add(this.labelOffering);
            this.Controls.Add(this.iconOffering);
            this.Controls.Add(this.cardTittlebar);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(293, 356);
            this.cardTittlebar.ResumeLayout(false);
            this.cardTittlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconOffering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel cardTittlebar;
        private System.Windows.Forms.Label CompanyName1;
        private FontAwesome.Sharp.IconPictureBox iconOffering;
        private System.Windows.Forms.Label labelOffering;
        private FontAwesome.Sharp.IconPictureBox iconEndTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.Label labelStatus;
        private FontAwesome.Sharp.IconPictureBox iconStatus;
        private System.Windows.Forms.Label labelAppliedStatus;
        private FontAwesome.Sharp.IconButton ApplyButton;
        private System.Windows.Forms.Button button1;
    }
}
