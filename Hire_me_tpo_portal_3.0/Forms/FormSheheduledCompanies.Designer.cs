namespace Hire_me_tpo_portal_3._0.Forms
{
    partial class FormSheheduledCompanies
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
            this.flowDesktopPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowDesktopPanel
            // 
            this.flowDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowDesktopPanel.Location = new System.Drawing.Point(0, 0);
            this.flowDesktopPanel.Name = "flowDesktopPanel";
            this.flowDesktopPanel.Padding = new System.Windows.Forms.Padding(20);
            this.flowDesktopPanel.Size = new System.Drawing.Size(1607, 861);
            this.flowDesktopPanel.TabIndex = 0;
            // 
            // FormSheheduledCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 861);
            this.Controls.Add(this.flowDesktopPanel);
            this.Name = "FormSheheduledCompanies";
            this.Text = "SCHEDULED COMPANIES";
            this.Load += new System.EventHandler(this.FormSheheduledCompanies_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowDesktopPanel;
    }
}