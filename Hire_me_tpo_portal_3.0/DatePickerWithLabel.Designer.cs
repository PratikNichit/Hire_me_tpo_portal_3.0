namespace Hire_me_tpo_portal_3._0
{
    partial class DatePickerWithLabel
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
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // placeholder
            // 
            this.placeholder.AutoSize = true;
            this.placeholder.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholder.ForeColor = System.Drawing.Color.White;
            this.placeholder.Location = new System.Drawing.Point(24, 18);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(99, 27);
            this.placeholder.TabIndex = 5;
            this.placeholder.Text = "Birth Date";
            // 
            // datepicker
            // 
            this.datepicker.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker.Location = new System.Drawing.Point(26, 58);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(328, 34);
            this.datepicker.TabIndex = 6;
            // 
            // DatePickerWithLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.placeholder);
            this.Name = "DatePickerWithLabel";
            this.Size = new System.Drawing.Size(379, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label placeholder;
        private System.Windows.Forms.DateTimePicker datepicker;
    }
}
