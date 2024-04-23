namespace Hire_me_tpo_portal_3._0.AdminForms
{
    partial class FormExportData
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
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.DataGridVacancy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVacancy)).BeginInit();
            this.SuspendLayout();
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // DataGridVacancy
            // 
            this.DataGridVacancy.AllowUserToAddRows = false;
            this.DataGridVacancy.AllowUserToDeleteRows = false;
            this.DataGridVacancy.AllowUserToOrderColumns = true;
            this.DataGridVacancy.AllowUserToResizeColumns = false;
            this.DataGridVacancy.AllowUserToResizeRows = false;
            this.DataGridVacancy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridVacancy.BackgroundColor = System.Drawing.Color.White;
            this.DataGridVacancy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridVacancy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridVacancy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridVacancy.ColumnHeadersHeight = 46;
            this.DataGridVacancy.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridVacancy.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridVacancy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridVacancy.EnableHeadersVisualStyles = false;
            this.DataGridVacancy.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DataGridVacancy.Location = new System.Drawing.Point(0, 0);
            this.DataGridVacancy.MultiSelect = false;
            this.DataGridVacancy.Name = "DataGridVacancy";
            this.DataGridVacancy.ReadOnly = true;
            this.DataGridVacancy.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridVacancy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.DataGridVacancy.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridVacancy.RowTemplate.Height = 60;
            this.DataGridVacancy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridVacancy.Size = new System.Drawing.Size(1589, 814);
            this.DataGridVacancy.TabIndex = 1;
            // 
            // FormExportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 814);
            this.Controls.Add(this.DataGridVacancy);
            this.Name = "FormExportData";
            this.Text = "Export Data";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVacancy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private System.Windows.Forms.DataGridView DataGridVacancy;
    }
}