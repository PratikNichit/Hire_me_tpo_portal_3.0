namespace Hire_me_tpo_portal_3._0.AdminForms
{
    partial class FormExportDataToExcel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridApplications = new System.Windows.Forms.DataGridView();
            this.export = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.export);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1589, 83);
            this.panel1.TabIndex = 0;
            // 
            // DataGridApplications
            // 
            this.DataGridApplications.AllowUserToAddRows = false;
            this.DataGridApplications.AllowUserToDeleteRows = false;
            this.DataGridApplications.AllowUserToOrderColumns = true;
            this.DataGridApplications.AllowUserToResizeColumns = false;
            this.DataGridApplications.AllowUserToResizeRows = false;
            this.DataGridApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridApplications.BackgroundColor = System.Drawing.Color.White;
            this.DataGridApplications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridApplications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridApplications.ColumnHeadersHeight = 46;
            this.DataGridApplications.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridApplications.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridApplications.EnableHeadersVisualStyles = false;
            this.DataGridApplications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DataGridApplications.Location = new System.Drawing.Point(0, 83);
            this.DataGridApplications.MultiSelect = false;
            this.DataGridApplications.Name = "DataGridApplications";
            this.DataGridApplications.ReadOnly = true;
            this.DataGridApplications.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridApplications.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.DataGridApplications.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridApplications.RowTemplate.Height = 60;
            this.DataGridApplications.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridApplications.Size = new System.Drawing.Size(1589, 731);
            this.DataGridApplications.TabIndex = 2;
            // 
            // export
            // 
            this.export.IconChar = FontAwesome.Sharp.IconChar.None;
            this.export.IconColor = System.Drawing.Color.Black;
            this.export.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.export.Location = new System.Drawing.Point(1393, 14);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(182, 51);
            this.export.TabIndex = 0;
            this.export.Text = "Export to Excel";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // FormExportDataToExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 814);
            this.Controls.Add(this.DataGridApplications);
            this.Controls.Add(this.panel1);
            this.Name = "FormExportDataToExcel";
            this.Text = "FormExportDataToExcel";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridApplications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataGridApplications;
        private FontAwesome.Sharp.IconButton export;
    }
}