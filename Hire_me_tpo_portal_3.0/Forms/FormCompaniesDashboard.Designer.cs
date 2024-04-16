namespace Hire_me_tpo_portal_3._0.Forms
{
    partial class FormCompaniesDashboard
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
            this.dataGridCompanies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCompanies
            // 
            this.dataGridCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompanies.Location = new System.Drawing.Point(85, 60);
            this.dataGridCompanies.Name = "dataGridCompanies";
            this.dataGridCompanies.RowHeadersWidth = 51;
            this.dataGridCompanies.RowTemplate.Height = 24;
            this.dataGridCompanies.Size = new System.Drawing.Size(1454, 725);
            this.dataGridCompanies.TabIndex = 0;
            // 
            // FormCompaniesDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 861);
            this.Controls.Add(this.dataGridCompanies);
            this.Name = "FormCompaniesDashboard";
            this.Text = "COMPANIES DASHBOARD";
            this.Load += new System.EventHandler(this.FormCompaniesDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompanies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCompanies;
    }
}