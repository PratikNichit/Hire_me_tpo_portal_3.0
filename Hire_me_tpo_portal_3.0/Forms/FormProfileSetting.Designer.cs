 using System.Windows.Media.Media3D;

namespace Hire_me_tpo_portal_3._0.Forms
{
    partial class FormProfileSetting
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
            this.personalDetailsTittleBar = new System.Windows.Forms.Panel();
            this.iconBack = new FontAwesome.Sharp.IconButton();
            this.iconNext = new FontAwesome.Sharp.IconButton();
            this.profileDesktopPanel = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.personalDetailsTittleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // personalDetailsTittleBar
            // 
            this.personalDetailsTittleBar.AutoScroll = true;
            this.personalDetailsTittleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.personalDetailsTittleBar.Controls.Add(this.labelTitle);
            this.personalDetailsTittleBar.Controls.Add(this.iconBack);
            this.personalDetailsTittleBar.Controls.Add(this.iconNext);
            this.personalDetailsTittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.personalDetailsTittleBar.Location = new System.Drawing.Point(0, 0);
            this.personalDetailsTittleBar.Name = "personalDetailsTittleBar";
            this.personalDetailsTittleBar.Size = new System.Drawing.Size(1607, 57);
            this.personalDetailsTittleBar.TabIndex = 0;
            // 
            // iconBack
            // 
            this.iconBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.iconBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconBack.FlatAppearance.BorderSize = 0;
            this.iconBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBack.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.iconBack.IconColor = System.Drawing.Color.Black;
            this.iconBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBack.IconSize = 30;
            this.iconBack.Location = new System.Drawing.Point(0, 0);
            this.iconBack.Name = "iconBack";
            this.iconBack.Size = new System.Drawing.Size(55, 57);
            this.iconBack.TabIndex = 1;
            this.iconBack.UseVisualStyleBackColor = false;
            this.iconBack.Click += new System.EventHandler(this.iconBack_Click);
            // 
            // iconNext
            // 
            this.iconNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.iconNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconNext.FlatAppearance.BorderSize = 0;
            this.iconNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconNext.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.iconNext.IconColor = System.Drawing.Color.Black;
            this.iconNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconNext.IconSize = 30;
            this.iconNext.Location = new System.Drawing.Point(1552, 0);
            this.iconNext.Name = "iconNext";
            this.iconNext.Size = new System.Drawing.Size(55, 57);
            this.iconNext.TabIndex = 0;
            this.iconNext.UseVisualStyleBackColor = false;
            this.iconNext.Click += new System.EventHandler(this.iconNext_Click);
            // 
            // profileDesktopPanel
            // 
            this.profileDesktopPanel.BackColor = System.Drawing.Color.White;
            this.profileDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileDesktopPanel.Location = new System.Drawing.Point(0, 57);
            this.profileDesktopPanel.Name = "profileDesktopPanel";
            this.profileDesktopPanel.Size = new System.Drawing.Size(1607, 804);
            this.profileDesktopPanel.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(62, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(153, 25);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Personal Details";
            // 
            // FormProfileSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 861);
            this.Controls.Add(this.profileDesktopPanel);
            this.Controls.Add(this.personalDetailsTittleBar);
            this.Name = "FormProfileSetting";
            this.Text = "PROFILE SETTING";
            this.Load += new System.EventHandler(this.FormProfileSetting_Load);
            this.personalDetailsTittleBar.ResumeLayout(false);
            this.personalDetailsTittleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel personalDetailsTittleBar;
        private FontAwesome.Sharp.IconButton iconNext;
        private System.Windows.Forms.Panel profileDesktopPanel;
        private FontAwesome.Sharp.IconButton iconBack;
        private System.Windows.Forms.Label labelTitle;
    }
}