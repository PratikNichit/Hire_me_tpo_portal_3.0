namespace Hire_me_tpo_portal_3._0.Forms
{
    partial class FormDashBoard
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
            this.card1 = new Hire_me_tpo_portal_3._0.Card();
            this.SuspendLayout();
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.White;
            this.card1.Companyid = 1;
            this.card1.companyOffering = "Intenship + ppo";
            this.card1.Location = new System.Drawing.Point(12, 12);
            this.card1.logo = "down";
            this.card1.Name = "card1";
            this.card1.nameOfCompany = "Barclays";
            this.card1.registrationEndDate = "2024-05-05 12:00 pm";
            this.card1.Size = new System.Drawing.Size(293, 356);
            this.card1.status = "Not Applied";
            this.card1.TabIndex = 0;
            this.card1.Vacancyid = 1;
            // 
            // FormDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 861);
            this.Controls.Add(this.card1);
            this.Name = "FormDashBoard";
            this.Text = "DASHBOARD";
            this.ResumeLayout(false);

        }

        #endregion

        private Card card1;
    }
}