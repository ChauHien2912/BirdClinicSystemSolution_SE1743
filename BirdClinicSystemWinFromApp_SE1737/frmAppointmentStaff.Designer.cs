namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmAppointmentStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointmentStaff));
            dgvAppoinmentStaff = new System.Windows.Forms.DataGridView();
            lbAppointmentID = new System.Windows.Forms.Label();
            lbUserID = new System.Windows.Forms.Label();
            lbStaffID = new System.Windows.Forms.Label();
            lbBirdID = new System.Windows.Forms.Label();
            lbDoctorID = new System.Windows.Forms.Label();
            lbAppointmentDate = new System.Windows.Forms.Label();
            lbAppointmentTime = new System.Windows.Forms.Label();
            lbStatus = new System.Windows.Forms.Label();
            lbServiceID = new System.Windows.Forms.Label();
            txtAppointmentID = new System.Windows.Forms.TextBox();
            txtUserID = new System.Windows.Forms.TextBox();
            txtBirdID = new System.Windows.Forms.TextBox();
            txtStaffID = new System.Windows.Forms.TextBox();
            txtDoctorID = new System.Windows.Forms.TextBox();
            txtStatus = new System.Windows.Forms.TextBox();
            txtServiceID = new System.Windows.Forms.TextBox();
            dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            btnAccept = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnView = new System.Windows.Forms.Button();
            txtAppointmentTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAppoinmentStaff).BeginInit();
            SuspendLayout();
            // 
            // dgvAppoinmentStaff
            // 
            dgvAppoinmentStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppoinmentStaff.Location = new System.Drawing.Point(12, 82);
            dgvAppoinmentStaff.Name = "dgvAppoinmentStaff";
            dgvAppoinmentStaff.RowHeadersWidth = 51;
            dgvAppoinmentStaff.RowTemplate.Height = 29;
            dgvAppoinmentStaff.Size = new System.Drawing.Size(635, 564);
            dgvAppoinmentStaff.TabIndex = 0;
            // 
            // lbAppointmentID
            // 
            lbAppointmentID.AutoSize = true;
            lbAppointmentID.Location = new System.Drawing.Point(678, 110);
            lbAppointmentID.Name = "lbAppointmentID";
            lbAppointmentID.Size = new System.Drawing.Size(116, 20);
            lbAppointmentID.TabIndex = 1;
            lbAppointmentID.Text = "AppointmentID ";
            // 
            // lbUserID
            // 
            lbUserID.AutoSize = true;
            lbUserID.Location = new System.Drawing.Point(678, 164);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new System.Drawing.Size(53, 20);
            lbUserID.TabIndex = 2;
            lbUserID.Text = "UserID";
            // 
            // lbStaffID
            // 
            lbStaffID.AutoSize = true;
            lbStaffID.Location = new System.Drawing.Point(678, 276);
            lbStaffID.Name = "lbStaffID";
            lbStaffID.Size = new System.Drawing.Size(55, 20);
            lbStaffID.TabIndex = 3;
            lbStaffID.Text = "StaffID";
            // 
            // lbBirdID
            // 
            lbBirdID.AutoSize = true;
            lbBirdID.Location = new System.Drawing.Point(678, 217);
            lbBirdID.Name = "lbBirdID";
            lbBirdID.Size = new System.Drawing.Size(51, 20);
            lbBirdID.TabIndex = 3;
            lbBirdID.Text = "BirdID";
            // 
            // lbDoctorID
            // 
            lbDoctorID.AutoSize = true;
            lbDoctorID.Location = new System.Drawing.Point(678, 332);
            lbDoctorID.Name = "lbDoctorID";
            lbDoctorID.Size = new System.Drawing.Size(70, 20);
            lbDoctorID.TabIndex = 4;
            lbDoctorID.Text = "DoctorID";
            // 
            // lbAppointmentDate
            // 
            lbAppointmentDate.AutoSize = true;
            lbAppointmentDate.Location = new System.Drawing.Point(678, 384);
            lbAppointmentDate.Name = "lbAppointmentDate";
            lbAppointmentDate.Size = new System.Drawing.Size(129, 20);
            lbAppointmentDate.TabIndex = 5;
            lbAppointmentDate.Text = "AppointmentDate";
            // 
            // lbAppointmentTime
            // 
            lbAppointmentTime.AutoSize = true;
            lbAppointmentTime.Location = new System.Drawing.Point(678, 430);
            lbAppointmentTime.Name = "lbAppointmentTime";
            lbAppointmentTime.Size = new System.Drawing.Size(130, 20);
            lbAppointmentTime.TabIndex = 6;
            lbAppointmentTime.Text = "AppointmentTime";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new System.Drawing.Point(678, 478);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new System.Drawing.Size(49, 20);
            lbStatus.TabIndex = 7;
            lbStatus.Text = "Status";
            // 
            // lbServiceID
            // 
            lbServiceID.AutoSize = true;
            lbServiceID.Location = new System.Drawing.Point(678, 529);
            lbServiceID.Name = "lbServiceID";
            lbServiceID.Size = new System.Drawing.Size(71, 20);
            lbServiceID.TabIndex = 8;
            lbServiceID.Text = "ServiceID";
            // 
            // txtAppointmentID
            // 
            txtAppointmentID.Location = new System.Drawing.Point(847, 107);
            txtAppointmentID.Name = "txtAppointmentID";
            txtAppointmentID.Size = new System.Drawing.Size(250, 27);
            txtAppointmentID.TabIndex = 9;
            // 
            // txtUserID
            // 
            txtUserID.Location = new System.Drawing.Point(847, 161);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new System.Drawing.Size(250, 27);
            txtUserID.TabIndex = 10;
            // 
            // txtBirdID
            // 
            txtBirdID.Location = new System.Drawing.Point(847, 214);
            txtBirdID.Name = "txtBirdID";
            txtBirdID.Size = new System.Drawing.Size(250, 27);
            txtBirdID.TabIndex = 11;
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new System.Drawing.Point(847, 273);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new System.Drawing.Size(250, 27);
            txtStaffID.TabIndex = 12;
            // 
            // txtDoctorID
            // 
            txtDoctorID.Location = new System.Drawing.Point(847, 329);
            txtDoctorID.Name = "txtDoctorID";
            txtDoctorID.Size = new System.Drawing.Size(250, 27);
            txtDoctorID.TabIndex = 13;
            // 
            // txtStatus
            // 
            txtStatus.Location = new System.Drawing.Point(847, 475);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new System.Drawing.Size(250, 27);
            txtStatus.TabIndex = 14;
            // 
            // txtServiceID
            // 
            txtServiceID.Location = new System.Drawing.Point(847, 526);
            txtServiceID.Name = "txtServiceID";
            txtServiceID.Size = new System.Drawing.Size(250, 27);
            txtServiceID.TabIndex = 15;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Location = new System.Drawing.Point(847, 379);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new System.Drawing.Size(250, 27);
            dtpAppointmentDate.TabIndex = 16;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAccept.Location = new System.Drawing.Point(678, 617);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new System.Drawing.Size(94, 29);
            btnAccept.TabIndex = 18;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Location = new System.Drawing.Point(992, 617);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnView
            // 
            btnView.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnView.Location = new System.Drawing.Point(847, 617);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(94, 29);
            btnView.TabIndex = 20;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // txtAppointmentTime
            // 
            txtAppointmentTime.Location = new System.Drawing.Point(847, 427);
            txtAppointmentTime.Name = "txtAppointmentTime";
            txtAppointmentTime.Size = new System.Drawing.Size(250, 27);
            txtAppointmentTime.TabIndex = 21;
            // 
            // frmAppointmentStaff
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1109, 672);
            Controls.Add(txtAppointmentTime);
            Controls.Add(btnView);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(dtpAppointmentDate);
            Controls.Add(txtServiceID);
            Controls.Add(txtStatus);
            Controls.Add(txtDoctorID);
            Controls.Add(txtStaffID);
            Controls.Add(txtBirdID);
            Controls.Add(txtUserID);
            Controls.Add(txtAppointmentID);
            Controls.Add(lbServiceID);
            Controls.Add(lbStatus);
            Controls.Add(lbAppointmentTime);
            Controls.Add(lbAppointmentDate);
            Controls.Add(lbDoctorID);
            Controls.Add(lbBirdID);
            Controls.Add(lbStaffID);
            Controls.Add(lbUserID);
            Controls.Add(lbAppointmentID);
            Controls.Add(dgvAppoinmentStaff);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmAppointmentStaff";
            Text = "Appointment Staff";
            ((System.ComponentModel.ISupportInitialize)dgvAppoinmentStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppoinmentStaff;
        private System.Windows.Forms.Label lbAppointmentID;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbStaffID;
        private System.Windows.Forms.Label lbBirdID;
        private System.Windows.Forms.Label lbDoctorID;
        private System.Windows.Forms.Label lbAppointmentDate;
        private System.Windows.Forms.Label lbAppointmentTime;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbServiceID;
        private System.Windows.Forms.TextBox txtAppointmentID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtBirdID;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txtAppointmentTime;
    }
}