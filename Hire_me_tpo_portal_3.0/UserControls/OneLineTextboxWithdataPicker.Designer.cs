namespace Hire_me_tpo_portal_3._0
{
    partial class OneLineTextboxWithdataPicker
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
            this.label3 = new System.Windows.Forms.Label();
            this.placeholder = new System.Windows.Forms.Label();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(270, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // placeholder
            // 
            this.placeholder.AutoSize = true;
            this.placeholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(159)))));
            this.placeholder.Location = new System.Drawing.Point(14, 16);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(151, 22);
            this.placeholder.TabIndex = 4;
            this.placeholder.Text = "Company\'s Name";
            // 
            // datePicker1
            // 
            this.datePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datePicker1.Location = new System.Drawing.Point(291, 16);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(349, 30);
            this.datePicker1.TabIndex = 7;
            // 
            // OneLineTextboxWithdataPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.placeholder);
            this.Name = "OneLineTextboxWithdataPicker";
            this.Size = new System.Drawing.Size(655, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label placeholder;
        private System.Windows.Forms.DateTimePicker datePicker1;
    }
}
