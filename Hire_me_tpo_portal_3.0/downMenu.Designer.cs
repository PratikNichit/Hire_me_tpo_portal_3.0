namespace Hire_me_tpo_portal_3._0
{
    partial class downMenu
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
            this.placeholder = new System.Windows.Forms.Label();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // placeholder
            // 
            this.placeholder.AutoSize = true;
            this.placeholder.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholder.ForeColor = System.Drawing.Color.White;
            this.placeholder.Location = new System.Drawing.Point(25, 12);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(230, 27);
            this.placeholder.TabIndex = 5;
            this.placeholder.Text = "Are you a Seda Student ?";
            // 
            // combobox
            // 
            this.combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox.Font = new System.Drawing.Font("Segoe UI Variable Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox.FormattingEnabled = true;
            this.combobox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.combobox.Location = new System.Drawing.Point(26, 54);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(328, 48);
            this.combobox.TabIndex = 6;
            // 
            // downMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.placeholder);
            this.Name = "downMenu";
            this.Size = new System.Drawing.Size(379, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label placeholder;
        private System.Windows.Forms.ComboBox combobox;
    }
}
