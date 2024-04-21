namespace Hire_me_tpo_portal_3._0
{
    partial class TextboxWithLabel
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
            this.textbox = new System.Windows.Forms.TextBox();
            this.placeholder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.BackColor = System.Drawing.Color.White;
            this.textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox.Font = new System.Drawing.Font("Segoe UI Variable Small", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox.Location = new System.Drawing.Point(20, 59);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(328, 51);
            this.textbox.TabIndex = 2;
            // 
            // placeholder
            // 
            this.placeholder.AutoSize = true;
            this.placeholder.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholder.ForeColor = System.Drawing.Color.White;
            this.placeholder.Location = new System.Drawing.Point(16, 18);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(123, 27);
            this.placeholder.TabIndex = 3;
            this.placeholder.Text = "PRN number";
            // 
            // TextboxWithLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.placeholder);
            this.Controls.Add(this.textbox);
            this.Name = "TextboxWithLabel";
            this.Size = new System.Drawing.Size(379, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label placeholder;
    }
}
