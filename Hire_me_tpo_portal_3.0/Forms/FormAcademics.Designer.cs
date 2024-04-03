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
            this.academicsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // academicsPanel
            // 
            this.academicsPanel.BackColor = System.Drawing.Color.White;
            this.academicsPanel.Controls.Add(this.panel1);
            this.academicsPanel.Location = new System.Drawing.Point(76, 104);
            this.academicsPanel.Name = "academicsPanel";
            this.academicsPanel.Size = new System.Drawing.Size(403, 447);
            this.academicsPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 76);
            this.panel1.TabIndex = 0;
            // 
            // FormAcademics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 861);
            this.Controls.Add(this.academicsPanel);
            this.Name = "FormAcademics";
            this.Text = "Academics";
            this.academicsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel academicsPanel;
        private System.Windows.Forms.Panel panel1;
    }
}