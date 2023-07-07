namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmRevevue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRevevue));
            dGVRevevueList = new System.Windows.Forms.DataGridView();
            lblTitle = new System.Windows.Forms.Label();
            lblServiceID = new System.Windows.Forms.Label();
            lblServiceName = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            lblPrice = new System.Windows.Forms.Label();
            txtServiceID = new System.Windows.Forms.TextBox();
            txtServiceName = new System.Windows.Forms.TextBox();
            txtStatus = new System.Windows.Forms.TextBox();
            txtDes = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            lblDate = new System.Windows.Forms.Label();
            lbltime = new System.Windows.Forms.Label();
            dtPDate = new System.Windows.Forms.DateTimePicker();
            dtpTime = new System.Windows.Forms.DateTimePicker();
            lblStaffID = new System.Windows.Forms.Label();
            lblDoctorID = new System.Windows.Forms.Label();
            txtStaffID = new System.Windows.Forms.TextBox();
            txtDoctorID = new System.Windows.Forms.TextBox();
            lblTotal = new System.Windows.Forms.Label();
            dtpfromDate = new System.Windows.Forms.DateTimePicker();
            dtpToDate = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnSearch = new System.Windows.Forms.Button();
            btnReset = new System.Windows.Forms.Button();
            txtFullName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtDoctor = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dGVRevevueList).BeginInit();
            SuspendLayout();
            // 
            // dGVRevevueList
            // 
            dGVRevevueList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVRevevueList.Location = new System.Drawing.Point(34, 487);
            dGVRevevueList.Name = "dGVRevevueList";
            dGVRevevueList.RowHeadersWidth = 51;
            dGVRevevueList.RowTemplate.Height = 29;
            dGVRevevueList.Size = new System.Drawing.Size(1107, 172);
            dGVRevevueList.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            lblTitle.Location = new System.Drawing.Point(480, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(201, 52);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Revevue";
            // 
            // lblServiceID
            // 
            lblServiceID.AutoSize = true;
            lblServiceID.Location = new System.Drawing.Point(158, 112);
            lblServiceID.Name = "lblServiceID";
            lblServiceID.Size = new System.Drawing.Size(75, 20);
            lblServiceID.TabIndex = 2;
            lblServiceID.Text = "Service ID";
            // 
            // lblServiceName
            // 
            lblServiceName.AutoSize = true;
            lblServiceName.Location = new System.Drawing.Point(158, 171);
            lblServiceName.Name = "lblServiceName";
            lblServiceName.Size = new System.Drawing.Size(100, 20);
            lblServiceName.TabIndex = 3;
            lblServiceName.Text = "Service Name";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(588, 234);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(49, 20);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(553, 283);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(85, 20);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(421, 398);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(41, 20);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // txtServiceID
            // 
            txtServiceID.Location = new System.Drawing.Point(290, 109);
            txtServiceID.Name = "txtServiceID";
            txtServiceID.Size = new System.Drawing.Size(250, 27);
            txtServiceID.TabIndex = 7;
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new System.Drawing.Point(290, 164);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new System.Drawing.Size(250, 27);
            txtServiceName.TabIndex = 8;
            // 
            // txtStatus
            // 
            txtStatus.Location = new System.Drawing.Point(668, 227);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new System.Drawing.Size(250, 27);
            txtStatus.TabIndex = 9;
            // 
            // txtDes
            // 
            txtDes.Location = new System.Drawing.Point(668, 276);
            txtDes.Name = "txtDes";
            txtDes.Size = new System.Drawing.Size(250, 27);
            txtDes.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(480, 391);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(250, 27);
            txtPrice.TabIndex = 11;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(158, 232);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(41, 20);
            lblDate.TabIndex = 12;
            lblDate.Text = "Date";
            // 
            // lbltime
            // 
            lbltime.AutoSize = true;
            lbltime.Location = new System.Drawing.Point(158, 283);
            lbltime.Name = "lbltime";
            lbltime.Size = new System.Drawing.Size(42, 20);
            lbltime.TabIndex = 13;
            lbltime.Text = "Time";
            // 
            // dtPDate
            // 
            dtPDate.Location = new System.Drawing.Point(290, 225);
            dtPDate.Name = "dtPDate";
            dtPDate.Size = new System.Drawing.Size(250, 27);
            dtPDate.TabIndex = 14;
            // 
            // dtpTime
            // 
            dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpTime.Location = new System.Drawing.Point(290, 276);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new System.Drawing.Size(250, 27);
            dtpTime.TabIndex = 15;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Location = new System.Drawing.Point(578, 116);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new System.Drawing.Size(59, 20);
            lblStaffID.TabIndex = 16;
            lblStaffID.Text = "Staff ID";
            // 
            // lblDoctorID
            // 
            lblDoctorID.AutoSize = true;
            lblDoctorID.Location = new System.Drawing.Point(567, 171);
            lblDoctorID.Name = "lblDoctorID";
            lblDoctorID.Size = new System.Drawing.Size(70, 20);
            lblDoctorID.TabIndex = 17;
            lblDoctorID.Text = "DoctorID";
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new System.Drawing.Point(668, 109);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new System.Drawing.Size(250, 27);
            txtStaffID.TabIndex = 18;
            // 
            // txtDoctorID
            // 
            txtDoctorID.Location = new System.Drawing.Point(668, 164);
            txtDoctorID.Name = "txtDoctorID";
            txtDoctorID.Size = new System.Drawing.Size(250, 27);
            txtDoctorID.TabIndex = 19;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new System.Drawing.Point(67, 442);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(0, 20);
            lblTotal.TabIndex = 20;
            // 
            // dtpfromDate
            // 
            dtpfromDate.Location = new System.Drawing.Point(290, 437);
            dtpfromDate.Name = "dtpfromDate";
            dtpfromDate.Size = new System.Drawing.Size(250, 27);
            dtpfromDate.TabIndex = 21;
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new System.Drawing.Point(668, 435);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new System.Drawing.Size(250, 27);
            dtpToDate.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(199, 442);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 20);
            label1.TabIndex = 23;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(588, 440);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(25, 20);
            label2.TabIndex = 24;
            label2.Text = "To";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Location = new System.Drawing.Point(976, 433);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(150, 35);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnReset.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnReset.ForeColor = System.Drawing.Color.White;
            btnReset.Location = new System.Drawing.Point(522, 672);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(150, 35);
            btnReset.TabIndex = 26;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new System.Drawing.Point(290, 340);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(250, 27);
            txtFullName.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(158, 347);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 20);
            label3.TabIndex = 28;
            label3.Text = "Full Name";
            // 
            // txtDoctor
            // 
            txtDoctor.Location = new System.Drawing.Point(675, 340);
            txtDoctor.Name = "txtDoctor";
            txtDoctor.Size = new System.Drawing.Size(243, 27);
            txtDoctor.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(582, 343);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 20);
            label4.TabIndex = 30;
            label4.Text = "Doctor";
            // 
            // frmRevevue
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1174, 719);
            Controls.Add(label4);
            Controls.Add(txtDoctor);
            Controls.Add(label3);
            Controls.Add(txtFullName);
            Controls.Add(btnReset);
            Controls.Add(btnSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpToDate);
            Controls.Add(dtpfromDate);
            Controls.Add(lblTotal);
            Controls.Add(txtDoctorID);
            Controls.Add(txtStaffID);
            Controls.Add(lblDoctorID);
            Controls.Add(lblStaffID);
            Controls.Add(dtpTime);
            Controls.Add(dtPDate);
            Controls.Add(lbltime);
            Controls.Add(lblDate);
            Controls.Add(txtPrice);
            Controls.Add(txtDes);
            Controls.Add(txtStatus);
            Controls.Add(txtServiceName);
            Controls.Add(txtServiceID);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblStatus);
            Controls.Add(lblServiceName);
            Controls.Add(lblServiceID);
            Controls.Add(lblTitle);
            Controls.Add(dGVRevevueList);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmRevevue";
            Text = "Revevue";
            ((System.ComponentModel.ISupportInitialize)dGVRevevueList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dGVRevevueList;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.DateTimePicker dtPDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtpfromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.Label label4;
    }
}