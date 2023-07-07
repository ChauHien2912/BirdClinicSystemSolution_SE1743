namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmDeleteAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteAppointment));
            cbbService = new System.Windows.Forms.ComboBox();
            mskTime = new System.Windows.Forms.MaskedTextBox();
            btnCancel = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            txtUserID = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtDate = new System.Windows.Forms.TextBox();
            txtBirdID = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // cbbService
            // 
            cbbService.FormattingEnabled = true;
            cbbService.Location = new System.Drawing.Point(163, 165);
            cbbService.Name = "cbbService";
            cbbService.Size = new System.Drawing.Size(151, 28);
            cbbService.TabIndex = 27;
            // 
            // mskTime
            // 
            mskTime.Location = new System.Drawing.Point(163, 132);
            mskTime.Mask = "00:00";
            mskTime.Name = "mskTime";
            mskTime.Size = new System.Drawing.Size(125, 27);
            mskTime.TabIndex = 26;
            mskTime.ValidatingType = typeof(System.DateTime);
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Location = new System.Drawing.Point(162, 211);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.Red;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Location = new System.Drawing.Point(62, 211);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtUserID
            // 
            txtUserID.Location = new System.Drawing.Point(162, 32);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new System.Drawing.Size(125, 27);
            txtUserID.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(24, 168);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 20);
            label5.TabIndex = 20;
            label5.Text = "Service";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(23, 135);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(134, 20);
            label4.TabIndex = 19;
            label4.Text = "Appointment Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(24, 102);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(133, 20);
            label3.TabIndex = 18;
            label3.Text = "Appointment Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(23, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 20);
            label2.TabIndex = 17;
            label2.Text = "Bird Tpye";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(23, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 20);
            label1.TabIndex = 16;
            label1.Text = "Owner Name";
            // 
            // txtDate
            // 
            txtDate.Location = new System.Drawing.Point(163, 99);
            txtDate.Name = "txtDate";
            txtDate.Size = new System.Drawing.Size(125, 27);
            txtDate.TabIndex = 28;
            // 
            // txtBirdID
            // 
            txtBirdID.Location = new System.Drawing.Point(162, 65);
            txtBirdID.Name = "txtBirdID";
            txtBirdID.Size = new System.Drawing.Size(125, 27);
            txtBirdID.TabIndex = 29;
            // 
            // frmDeleteAppointment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(354, 313);
            Controls.Add(txtBirdID);
            Controls.Add(txtDate);
            Controls.Add(cbbService);
            Controls.Add(mskTime);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(txtUserID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmDeleteAppointment";
            Text = "Delete Appointment";
            Load += frmDeleteAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbbService;
        private System.Windows.Forms.MaskedTextBox mskTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtBirdID;
    }
}