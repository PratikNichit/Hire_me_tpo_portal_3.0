﻿namespace Hire_me_tpo_portal_3._0.Forms
{
    partial class FormPdfView
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
            this.close = new System.Windows.Forms.Button();
            this.pdfViewer = new Spire.PdfViewer.Forms.PdfViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1571, 56);
            this.panel1.TabIndex = 1;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(1467, 10);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(91, 35);
            this.close.TabIndex = 0;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.pdfViewer.FormFillEnabled = false;
            this.pdfViewer.IgnoreCase = false;
            this.pdfViewer.IsToolBarVisible = true;
            this.pdfViewer.Location = new System.Drawing.Point(0, 56);
            this.pdfViewer.MultiPagesThreshold = 60;
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.OnRenderPageExceptionEvent = null;
            this.pdfViewer.Size = new System.Drawing.Size(1571, 711);
            this.pdfViewer.TabIndex = 2;
            this.pdfViewer.Text = "pdfViewer1";
            this.pdfViewer.Threshold = 60;
            this.pdfViewer.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // FormPdfView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 767);
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.panel1);
            this.Name = "FormPdfView";
            this.Text = "FormPdfView";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close;
        private Spire.PdfViewer.Forms.PdfViewer pdfViewer;
    }
}