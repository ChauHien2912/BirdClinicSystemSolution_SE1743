namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmMedicalRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicalRecord));
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            label5 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            cbbMedicalRecord = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            txtMedicalID = new System.Windows.Forms.TextBox();
            txtUserID = new System.Windows.Forms.TextBox();
            txtBirdID = new System.Windows.Forms.TextBox();
            txtDoctorID = new System.Windows.Forms.TextBox();
            txtDate = new System.Windows.Forms.TextBox();
            txtInstruction = new System.Windows.Forms.RichTextBox();
            txtDiagnosis = new System.Windows.Forms.RichTextBox();
            btnClose = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(810, 125);
            panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 100);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.line_removebg_preview;
            pictureBox3.Location = new System.Drawing.Point(680, 82);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(127, 34);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Transparent;
            label5.Location = new System.Drawing.Point(263, 52);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(402, 29);
            label5.TabIndex = 7;
            label5.Text = "Taking Wing to New Heights of Care";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.line_removebg_preview;
            pictureBox2.Location = new System.Drawing.Point(109, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(127, 34);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // cbbMedicalRecord
            // 
            cbbMedicalRecord.FormattingEnabled = true;
            cbbMedicalRecord.Location = new System.Drawing.Point(175, 151);
            cbbMedicalRecord.Name = "cbbMedicalRecord";
            cbbMedicalRecord.Size = new System.Drawing.Size(151, 28);
            cbbMedicalRecord.TabIndex = 16;
            cbbMedicalRecord.Text = "Medical Record ID";
            cbbMedicalRecord.SelectedValueChanged += cbbMedicalRecord_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 154);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(157, 20);
            label1.TabIndex = 17;
            label1.Text = "Select Medical Record";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 208);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 20);
            label2.TabIndex = 18;
            label2.Text = "Medical ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(292, 208);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(96, 20);
            label3.TabIndex = 19;
            label3.Text = "Owner Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(541, 208);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 20);
            label4.TabIndex = 20;
            label4.Text = "Bird Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(289, 254);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(99, 20);
            label6.TabIndex = 21;
            label6.Text = "Doctor Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(12, 258);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(107, 20);
            label7.TabIndex = 22;
            label7.Text = "Check-up Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(365, 314);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(74, 20);
            label8.TabIndex = 23;
            label8.Text = "Diagnosis";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(12, 314);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(78, 20);
            label9.TabIndex = 24;
            label9.Text = "Instruction";
            // 
            // txtMedicalID
            // 
            txtMedicalID.Location = new System.Drawing.Point(132, 205);
            txtMedicalID.Name = "txtMedicalID";
            txtMedicalID.Size = new System.Drawing.Size(125, 27);
            txtMedicalID.TabIndex = 25;
            // 
            // txtUserID
            // 
            txtUserID.Location = new System.Drawing.Point(394, 205);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new System.Drawing.Size(125, 27);
            txtUserID.TabIndex = 26;
            // 
            // txtBirdID
            // 
            txtBirdID.Location = new System.Drawing.Point(641, 205);
            txtBirdID.Name = "txtBirdID";
            txtBirdID.Size = new System.Drawing.Size(125, 27);
            txtBirdID.TabIndex = 27;
            // 
            // txtDoctorID
            // 
            txtDoctorID.Location = new System.Drawing.Point(394, 251);
            txtDoctorID.Name = "txtDoctorID";
            txtDoctorID.Size = new System.Drawing.Size(125, 27);
            txtDoctorID.TabIndex = 28;
            // 
            // txtDate
            // 
            txtDate.Location = new System.Drawing.Point(132, 255);
            txtDate.Name = "txtDate";
            txtDate.Size = new System.Drawing.Size(125, 27);
            txtDate.TabIndex = 29;
            // 
            // txtInstruction
            // 
            txtInstruction.Location = new System.Drawing.Point(12, 337);
            txtInstruction.Name = "txtInstruction";
            txtInstruction.Size = new System.Drawing.Size(314, 79);
            txtInstruction.TabIndex = 30;
            txtInstruction.Text = "";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new System.Drawing.Point(365, 337);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new System.Drawing.Size(314, 79);
            txtDiagnosis.TabIndex = 31;
            txtDiagnosis.Text = "";
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Location = new System.Drawing.Point(318, 434);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 32;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmMedicalRecord
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(811, 475);
            Controls.Add(btnClose);
            Controls.Add(txtDiagnosis);
            Controls.Add(txtInstruction);
            Controls.Add(txtDate);
            Controls.Add(txtDoctorID);
            Controls.Add(txtBirdID);
            Controls.Add(txtUserID);
            Controls.Add(txtMedicalID);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbbMedicalRecord);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmMedicalRecord";
            Text = "Medical Record";
            Load += frmMedicalRecord_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbbMedicalRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMedicalID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtBirdID;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.RichTextBox txtInstruction;
        private System.Windows.Forms.RichTextBox txtDiagnosis;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}