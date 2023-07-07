namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointment));
            panel1 = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            label5 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            cbbAppointmentID = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            txtBirdID = new System.Windows.Forms.TextBox();
            txtStaffID = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtDoctorID = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtStatusID = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtServiceID = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            txtTime = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            txtUserID = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            txtDate = new System.Windows.Forms.TextBox();
            btnCreate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnPay = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            btnFeedBack = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new System.Drawing.Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1020, 125);
            panel1.TabIndex = 15;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.line_removebg_preview;
            pictureBox3.Location = new System.Drawing.Point(890, 82);
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
            label5.Location = new System.Drawing.Point(332, 46);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(402, 29);
            label5.TabIndex = 7;
            label5.Text = "Taking Wing to New Heights of Care";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.line_removebg_preview;
            pictureBox2.Location = new System.Drawing.Point(106, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(127, 34);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 100);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 139);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(141, 20);
            label1.TabIndex = 16;
            label1.Text = "Select Appointment";
            // 
            // cbbAppointmentID
            // 
            cbbAppointmentID.FormattingEnabled = true;
            cbbAppointmentID.Location = new System.Drawing.Point(159, 136);
            cbbAppointmentID.Name = "cbbAppointmentID";
            cbbAppointmentID.Size = new System.Drawing.Size(151, 28);
            cbbAppointmentID.TabIndex = 17;
            cbbAppointmentID.Text = "Appointment ID";
            cbbAppointmentID.SelectedValueChanged += cbbAppointmentID_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 185);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 20);
            label2.TabIndex = 18;
            label2.Text = "Bird ID";
            // 
            // txtBirdID
            // 
            txtBirdID.Location = new System.Drawing.Point(68, 182);
            txtBirdID.Name = "txtBirdID";
            txtBirdID.Size = new System.Drawing.Size(125, 27);
            txtBirdID.TabIndex = 19;
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new System.Drawing.Point(332, 182);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new System.Drawing.Size(125, 27);
            txtStaffID.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(242, 185);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 20);
            label3.TabIndex = 20;
            label3.Text = "Staff Name";
            // 
            // txtDoctorID
            // 
            txtDoctorID.Location = new System.Drawing.Point(609, 182);
            txtDoctorID.Name = "txtDoctorID";
            txtDoctorID.Size = new System.Drawing.Size(125, 27);
            txtDoctorID.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(504, 185);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(99, 20);
            label4.TabIndex = 22;
            label4.Text = "Doctor Name";
            // 
            // txtStatusID
            // 
            txtStatusID.Location = new System.Drawing.Point(828, 182);
            txtStatusID.Name = "txtStatusID";
            txtStatusID.Size = new System.Drawing.Size(125, 27);
            txtStatusID.TabIndex = 25;
            txtStatusID.TextChanged += txtStatusID_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(773, 185);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(49, 20);
            label6.TabIndex = 24;
            label6.Text = "Status";
            // 
            // txtServiceID
            // 
            txtServiceID.Location = new System.Drawing.Point(68, 229);
            txtServiceID.Name = "txtServiceID";
            txtServiceID.Size = new System.Drawing.Size(125, 27);
            txtServiceID.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(12, 232);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(56, 20);
            label7.TabIndex = 26;
            label7.Text = "Service";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(242, 232);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(41, 20);
            label8.TabIndex = 28;
            label8.Text = "Date";
            // 
            // txtTime
            // 
            txtTime.Location = new System.Drawing.Point(609, 225);
            txtTime.Name = "txtTime";
            txtTime.Size = new System.Drawing.Size(125, 27);
            txtTime.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(504, 228);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(42, 20);
            label9.TabIndex = 30;
            label9.Text = "Time";
            // 
            // txtUserID
            // 
            txtUserID.Location = new System.Drawing.Point(434, 136);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new System.Drawing.Size(125, 27);
            txtUserID.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(332, 139);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(96, 20);
            label11.TabIndex = 34;
            label11.Text = "Owner Name";
            // 
            // txtDate
            // 
            txtDate.Location = new System.Drawing.Point(332, 225);
            txtDate.Multiline = true;
            txtDate.Name = "txtDate";
            txtDate.Size = new System.Drawing.Size(125, 27);
            txtDate.TabIndex = 36;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreate.Location = new System.Drawing.Point(242, 281);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(94, 29);
            btnCreate.TabIndex = 37;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Location = new System.Drawing.Point(363, 281);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = System.Drawing.Color.YellowGreen;
            btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPay.Location = new System.Drawing.Point(478, 281);
            btnPay.Name = "btnPay";
            btnPay.Size = new System.Drawing.Size(94, 29);
            btnPay.TabIndex = 39;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Location = new System.Drawing.Point(597, 281);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 40;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += button1_Click;
            // 
            // btnFeedBack
            // 
            btnFeedBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnFeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFeedBack.Location = new System.Drawing.Point(609, 134);
            btnFeedBack.Name = "btnFeedBack";
            btnFeedBack.Size = new System.Drawing.Size(94, 29);
            btnFeedBack.TabIndex = 41;
            btnFeedBack.Text = "FeedBack";
            btnFeedBack.UseVisualStyleBackColor = false;
            btnFeedBack.Click += btnFeedBack_Click;
            // 
            // frmAppointment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1018, 450);
            Controls.Add(btnFeedBack);
            Controls.Add(btnClose);
            Controls.Add(btnPay);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(txtDate);
            Controls.Add(txtUserID);
            Controls.Add(label11);
            Controls.Add(txtTime);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtServiceID);
            Controls.Add(label7);
            Controls.Add(txtStatusID);
            Controls.Add(label6);
            Controls.Add(txtDoctorID);
            Controls.Add(label4);
            Controls.Add(txtStaffID);
            Controls.Add(label3);
            Controls.Add(txtBirdID);
            Controls.Add(label2);
            Controls.Add(cbbAppointmentID);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmAppointment";
            Text = "Appointment";
            Load += frmAppointment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbAppointmentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBirdID;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatusID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFeedBack;
    }
}