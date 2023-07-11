namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmAppointmentAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointmentAdmin));
            dGVListAppointment = new System.Windows.Forms.DataGridView();
            lblAppointmentID = new System.Windows.Forms.Label();
            lblUserID = new System.Windows.Forms.Label();
            lblBirdID = new System.Windows.Forms.Label();
            lblStaffID = new System.Windows.Forms.Label();
            lblDoctorID = new System.Windows.Forms.Label();
            lblAppointmentDate = new System.Windows.Forms.Label();
            lblAppointmentTime = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            lblserviceID = new System.Windows.Forms.Label();
            txtAppointmentID = new System.Windows.Forms.TextBox();
            txtUserID = new System.Windows.Forms.TextBox();
            txtBirdID = new System.Windows.Forms.TextBox();
            txtStaffID = new System.Windows.Forms.TextBox();
            txtDoctorID = new System.Windows.Forms.TextBox();
            dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            dtpAppointmentTime = new System.Windows.Forms.DateTimePicker();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            txtStatus = new System.Windows.Forms.TextBox();
            txtServiceID = new System.Windows.Forms.TextBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            revevueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            veritarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ltlTilte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dGVListAppointment).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dGVListAppointment
            // 
            dGVListAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVListAppointment.Location = new System.Drawing.Point(61, 407);
            dGVListAppointment.Name = "dGVListAppointment";
            dGVListAppointment.RowHeadersWidth = 51;
            dGVListAppointment.RowTemplate.Height = 29;
            dGVListAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dGVListAppointment.Size = new System.Drawing.Size(805, 227);
            dGVListAppointment.TabIndex = 0;
            // 
            // lblAppointmentID
            // 
            lblAppointmentID.AutoSize = true;
            lblAppointmentID.Location = new System.Drawing.Point(71, 156);
            lblAppointmentID.Name = "lblAppointmentID";
            lblAppointmentID.Size = new System.Drawing.Size(112, 20);
            lblAppointmentID.TabIndex = 1;
            lblAppointmentID.Text = "AppointmentID";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new System.Drawing.Point(101, 204);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new System.Drawing.Size(53, 20);
            lblUserID.TabIndex = 2;
            lblUserID.Text = "UserID";
            // 
            // lblBirdID
            // 
            lblBirdID.AutoSize = true;
            lblBirdID.Location = new System.Drawing.Point(103, 244);
            lblBirdID.Name = "lblBirdID";
            lblBirdID.Size = new System.Drawing.Size(51, 20);
            lblBirdID.TabIndex = 3;
            lblBirdID.Text = "BirdID";
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Location = new System.Drawing.Point(103, 290);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new System.Drawing.Size(55, 20);
            lblStaffID.TabIndex = 4;
            lblStaffID.Text = "StaffID";
            // 
            // lblDoctorID
            // 
            lblDoctorID.AutoSize = true;
            lblDoctorID.Location = new System.Drawing.Point(101, 335);
            lblDoctorID.Name = "lblDoctorID";
            lblDoctorID.Size = new System.Drawing.Size(70, 20);
            lblDoctorID.TabIndex = 5;
            lblDoctorID.Text = "DoctorID";
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Location = new System.Drawing.Point(445, 158);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new System.Drawing.Size(129, 20);
            lblAppointmentDate.TabIndex = 6;
            lblAppointmentDate.Text = "AppointmentDate";
            // 
            // lblAppointmentTime
            // 
            lblAppointmentTime.AutoSize = true;
            lblAppointmentTime.Location = new System.Drawing.Point(445, 208);
            lblAppointmentTime.Name = "lblAppointmentTime";
            lblAppointmentTime.Size = new System.Drawing.Size(130, 20);
            lblAppointmentTime.TabIndex = 7;
            lblAppointmentTime.Text = "AppointmentTime";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(488, 244);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(49, 20);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status";
            // 
            // lblserviceID
            // 
            lblserviceID.AutoSize = true;
            lblserviceID.Location = new System.Drawing.Point(488, 287);
            lblserviceID.Name = "lblserviceID";
            lblserviceID.Size = new System.Drawing.Size(69, 20);
            lblserviceID.TabIndex = 9;
            lblserviceID.Text = "serviceID";
            // 
            // txtAppointmentID
            // 
            txtAppointmentID.Location = new System.Drawing.Point(189, 149);
            txtAppointmentID.Name = "txtAppointmentID";
            txtAppointmentID.Size = new System.Drawing.Size(224, 27);
            txtAppointmentID.TabIndex = 10;
            // 
            // txtUserID
            // 
            txtUserID.Location = new System.Drawing.Point(189, 201);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new System.Drawing.Size(224, 27);
            txtUserID.TabIndex = 11;
            
            // 
            // txtBirdID
            // 
            txtBirdID.Location = new System.Drawing.Point(189, 241);
            txtBirdID.Name = "txtBirdID";
            txtBirdID.Size = new System.Drawing.Size(224, 27);
            txtBirdID.TabIndex = 12;
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new System.Drawing.Point(189, 287);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new System.Drawing.Size(224, 27);
            txtStaffID.TabIndex = 13;
            // 
            // txtDoctorID
            // 
            txtDoctorID.Location = new System.Drawing.Point(189, 332);
            txtDoctorID.Name = "txtDoctorID";
            txtDoctorID.Size = new System.Drawing.Size(224, 27);
            txtDoctorID.TabIndex = 14;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Location = new System.Drawing.Point(581, 151);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new System.Drawing.Size(250, 27);
            dtpAppointmentDate.TabIndex = 15;
            // 
            // dtpAppointmentTime
            // 
            dtpAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpAppointmentTime.Location = new System.Drawing.Point(581, 201);
            dtpAppointmentTime.Name = "dtpAppointmentTime";
            dtpAppointmentTime.Size = new System.Drawing.Size(250, 27);
            dtpAppointmentTime.TabIndex = 16;
            dtpAppointmentTime.Value = new System.DateTime(2023, 6, 28, 0, 0, 0, 0);
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // txtStatus
            // 
            txtStatus.Location = new System.Drawing.Point(581, 241);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new System.Drawing.Size(250, 27);
            txtStatus.TabIndex = 17;
            // 
            // txtServiceID
            // 
            txtServiceID.Location = new System.Drawing.Point(581, 287);
            txtServiceID.Name = "txtServiceID";
            txtServiceID.Size = new System.Drawing.Size(250, 27);
            txtServiceID.TabIndex = 18;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { appointmentToolStripMenuItem, customerToolStripMenuItem, revevueToolStripMenuItem, serviceToolStripMenuItem, veritarianToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(924, 28);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // appointmentToolStripMenuItem
            // 
            appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            appointmentToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            customerToolStripMenuItem.Text = "Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // revevueToolStripMenuItem
            // 
            revevueToolStripMenuItem.Name = "revevueToolStripMenuItem";
            revevueToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            revevueToolStripMenuItem.Text = "Revevue";
            revevueToolStripMenuItem.Click += revevueToolStripMenuItem_Click;
            // 
            // serviceToolStripMenuItem
            // 
            serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            serviceToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            serviceToolStripMenuItem.Text = "Service";
            serviceToolStripMenuItem.Click += serviceToolStripMenuItem_Click;
            // 
            // veritarianToolStripMenuItem
            // 
            veritarianToolStripMenuItem.Name = "veritarianToolStripMenuItem";
            veritarianToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            veritarianToolStripMenuItem.Text = "Veterian";
            veritarianToolStripMenuItem.Click += veritarianToolStripMenuItem_Click;
            // 
            // ltlTilte
            // 
            ltlTilte.AutoSize = true;
            ltlTilte.BackColor = System.Drawing.SystemColors.Control;
            ltlTilte.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ltlTilte.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            ltlTilte.Location = new System.Drawing.Point(297, 56);
            ltlTilte.Name = "ltlTilte";
            ltlTilte.Size = new System.Drawing.Size(277, 52);
            ltlTilte.TabIndex = 20;
            ltlTilte.Text = "Appointment";
            // 
            // frmAppointmentAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(924, 666);
            Controls.Add(ltlTilte);
            Controls.Add(txtServiceID);
            Controls.Add(txtStatus);
            Controls.Add(dtpAppointmentTime);
            Controls.Add(dtpAppointmentDate);
            Controls.Add(txtDoctorID);
            Controls.Add(txtStaffID);
            Controls.Add(txtBirdID);
            Controls.Add(txtUserID);
            Controls.Add(txtAppointmentID);
            Controls.Add(lblserviceID);
            Controls.Add(lblStatus);
            Controls.Add(lblAppointmentTime);
            Controls.Add(lblAppointmentDate);
            Controls.Add(lblDoctorID);
            Controls.Add(lblStaffID);
            Controls.Add(lblBirdID);
            Controls.Add(lblUserID);
            Controls.Add(lblAppointmentID);
            Controls.Add(dGVListAppointment);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmAppointmentAdmin";
            Text = "Appointment Admin";
            ((System.ComponentModel.ISupportInitialize)dGVListAppointment).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dGVListAppointment;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblBirdID;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblAppointmentTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblserviceID;
        private System.Windows.Forms.TextBox txtAppointmentID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtBirdID;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.DateTimePicker dtpAppointmentTime;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revevueToolStripMenuItem;
        private System.Windows.Forms.Label ltlTilte;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veritarianToolStripMenuItem;
    }
}