namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmCreateAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAppointment));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtUserID = new System.Windows.Forms.TextBox();
            btnCreate = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            cbbBirdID = new System.Windows.Forms.ComboBox();
            cbbService = new System.Windows.Forms.ComboBox();
            dtpDate = new System.Windows.Forms.DateTimePicker();
            cbbHour = new System.Windows.Forms.ComboBox();
            cbbMinute = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(54, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Owner Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(54, 69);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Bird ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(55, 103);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(133, 20);
            label3.TabIndex = 2;
            label3.Text = "Appointment Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(54, 136);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(134, 20);
            label4.TabIndex = 3;
            label4.Text = "Appointment Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(55, 169);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "Service";
            // 
            // txtUserID
            // 
            txtUserID.Location = new System.Drawing.Point(193, 33);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new System.Drawing.Size(125, 27);
            txtUserID.TabIndex = 5;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnCreate.Location = new System.Drawing.Point(150, 212);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(94, 29);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Save";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.Red;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Location = new System.Drawing.Point(250, 212);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbbBirdID
            // 
            cbbBirdID.FormattingEnabled = true;
            cbbBirdID.Location = new System.Drawing.Point(193, 66);
            cbbBirdID.Name = "cbbBirdID";
            cbbBirdID.Size = new System.Drawing.Size(151, 28);
            cbbBirdID.TabIndex = 12;
            // 
            // cbbService
            // 
            cbbService.FormattingEnabled = true;
            cbbService.Location = new System.Drawing.Point(194, 166);
            cbbService.Name = "cbbService";
            cbbService.Size = new System.Drawing.Size(151, 28);
            cbbService.TabIndex = 15;
            // 
            // dtpDate
            // 
            dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDate.Location = new System.Drawing.Point(193, 100);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new System.Drawing.Size(250, 27);
            dtpDate.TabIndex = 16;
            // 
            // cbbHour
            // 
            cbbHour.FormattingEnabled = true;
            cbbHour.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19" });
            cbbHour.Location = new System.Drawing.Point(194, 132);
            cbbHour.Name = "cbbHour";
            cbbHour.Size = new System.Drawing.Size(62, 28);
            cbbHour.TabIndex = 17;
            cbbHour.Text = "Hour";
            // 
            // cbbMinute
            // 
            cbbMinute.FormattingEnabled = true;
            cbbMinute.Items.AddRange(new object[] { "00", "15", "30", "45" });
            cbbMinute.Location = new System.Drawing.Point(262, 132);
            cbbMinute.Name = "cbbMinute";
            cbbMinute.Size = new System.Drawing.Size(83, 28);
            cbbMinute.TabIndex = 18;
            cbbMinute.Text = "Minute";
            // 
            // frmCreateAppointment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(494, 301);
            Controls.Add(cbbMinute);
            Controls.Add(cbbHour);
            Controls.Add(dtpDate);
            Controls.Add(cbbService);
            Controls.Add(cbbBirdID);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(txtUserID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmCreateAppointment";
            Text = "Create Appointment";
            Load += frmCreateAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbbBirdID;
        private System.Windows.Forms.ComboBox cbbService;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ComboBox cbbHour;
        private System.Windows.Forms.ComboBox cbbMinute;
    }
}