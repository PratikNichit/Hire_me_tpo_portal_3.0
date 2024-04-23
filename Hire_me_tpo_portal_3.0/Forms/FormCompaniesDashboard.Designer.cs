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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridCompanies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCompanies
            // 
            this.dataGridCompanies.AllowUserToAddRows = false;
            this.dataGridCompanies.AllowUserToDeleteRows = false;
            this.dataGridCompanies.AllowUserToOrderColumns = true;
            this.dataGridCompanies.AllowUserToResizeColumns = false;
            this.dataGridCompanies.AllowUserToResizeRows = false;
            this.dataGridCompanies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridCompanies.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCompanies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCompanies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCompanies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCompanies.ColumnHeadersHeight = 46;
            this.dataGridCompanies.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCompanies.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCompanies.EnableHeadersVisualStyles = false;
            this.dataGridCompanies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridCompanies.Location = new System.Drawing.Point(0, 0);
            this.dataGridCompanies.MultiSelect = false;
            this.dataGridCompanies.Name = "dataGridCompanies";
            this.dataGridCompanies.ReadOnly = true;
            this.dataGridCompanies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridCompanies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridCompanies.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCompanies.RowTemplate.Height = 60;
            this.dataGridCompanies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridCompanies.Size = new System.Drawing.Size(1607, 861);
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