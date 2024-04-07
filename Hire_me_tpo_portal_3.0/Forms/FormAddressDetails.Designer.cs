namespace Hire_me_tpo_portal_3._0.Forms
{
    partial class FormAddressDetails
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
            this.iconSave = new FontAwesome.Sharp.IconButton();
            this.iconEdit = new FontAwesome.Sharp.IconButton();
            this.AddressDetailsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.permanentAddress = new System.Windows.Forms.TextBox();
            this.currentAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.AddressDetailsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iconSave);
            this.panel1.Controls.Add(this.iconEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 785);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1607, 76);
            this.panel1.TabIndex = 5;
            // 
            // iconSave
            // 
            this.iconSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.iconSave.FlatAppearance.BorderSize = 0;
            this.iconSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconSave.IconColor = System.Drawing.Color.Black;
            this.iconSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconSave.Location = new System.Drawing.Point(1482, 14);
            this.iconSave.Margin = new System.Windows.Forms.Padding(5);
            this.iconSave.Name = "iconSave";
            this.iconSave.Size = new System.Drawing.Size(110, 48);
            this.iconSave.TabIndex = 7;
            this.iconSave.Text = "Save ";
            this.iconSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconSave.UseVisualStyleBackColor = false;
            this.iconSave.Click += new System.EventHandler(this.iconSave_Click);
            // 
            // iconEdit
            // 
            this.iconEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconEdit.BackColor = System.Drawing.Color.Salmon;
            this.iconEdit.FlatAppearance.BorderSize = 0;
            this.iconEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEdit.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.iconEdit.IconColor = System.Drawing.Color.Black;
            this.iconEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconEdit.Location = new System.Drawing.Point(1364, 14);
            this.iconEdit.Margin = new System.Windows.Forms.Padding(5);
            this.iconEdit.Name = "iconEdit";
            this.iconEdit.Size = new System.Drawing.Size(105, 48);
            this.iconEdit.TabIndex = 6;
            this.iconEdit.Text = "Edit";
            this.iconEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconEdit.UseVisualStyleBackColor = false;
            this.iconEdit.Click += new System.EventHandler(this.iconEdit_Click);
            // 
            // AddressDetailsPanel
            // 
            this.AddressDetailsPanel.BackColor = System.Drawing.Color.White;
            this.AddressDetailsPanel.Controls.Add(this.checkBox1);
            this.AddressDetailsPanel.Controls.Add(this.currentAddress);
            this.AddressDetailsPanel.Controls.Add(this.label3);
            this.AddressDetailsPanel.Controls.Add(this.permanentAddress);
            this.AddressDetailsPanel.Controls.Add(this.label2);
            this.AddressDetailsPanel.Controls.Add(this.panel2);
            this.AddressDetailsPanel.Location = new System.Drawing.Point(110, 86);
            this.AddressDetailsPanel.Name = "AddressDetailsPanel";
            this.AddressDetailsPanel.Size = new System.Drawing.Size(1344, 523);
            this.AddressDetailsPanel.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1344, 68);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Permanent Address";
            // 
            // permanentAddress
            // 
            this.permanentAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.permanentAddress.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permanentAddress.Location = new System.Drawing.Point(49, 154);
            this.permanentAddress.Multiline = true;
            this.permanentAddress.Name = "permanentAddress";
            this.permanentAddress.Size = new System.Drawing.Size(517, 273);
            this.permanentAddress.TabIndex = 2;
            // 
            // currentAddress
            // 
            this.currentAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentAddress.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAddress.Location = new System.Drawing.Point(745, 153);
            this.currentAddress.Multiline = true;
            this.currentAddress.Name = "currentAddress";
            this.currentAddress.Size = new System.Drawing.Size(517, 273);
            this.currentAddress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(741, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Current Address";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(49, 464);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(414, 26);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Current address is same as Permanent Address";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormAddressDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 861);
            this.Controls.Add(this.AddressDetailsPanel);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddressDetails";
            this.Text = "Address Details";
            this.panel1.ResumeLayout(false);
            this.AddressDetailsPanel.ResumeLayout(false);
            this.AddressDetailsPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconSave;
        private FontAwesome.Sharp.IconButton iconEdit;
        private System.Windows.Forms.Panel AddressDetailsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox currentAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox permanentAddress;
    }
}