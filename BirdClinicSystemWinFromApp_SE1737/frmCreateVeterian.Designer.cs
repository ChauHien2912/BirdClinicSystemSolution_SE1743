namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmCreateVeterian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateVeterian));
            lbRoleID = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbFullName = new System.Windows.Forms.Label();
            lbGender = new System.Windows.Forms.Label();
            lbPhone = new System.Windows.Forms.Label();
            lbAddress = new System.Windows.Forms.Label();
            txtRoleID = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtFullName = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            lblTitle = new System.Windows.Forms.Label();
            btnCreate = new System.Windows.Forms.Button();
            cboGender = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // lbRoleID
            // 
            lbRoleID.AutoSize = true;
            lbRoleID.Location = new System.Drawing.Point(34, 88);
            lbRoleID.Name = "lbRoleID";
            lbRoleID.Size = new System.Drawing.Size(54, 20);
            lbRoleID.TabIndex = 1;
            lbRoleID.Text = "RoleID";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(34, 130);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(34, 177);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Location = new System.Drawing.Point(34, 224);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new System.Drawing.Size(72, 20);
            lbFullName.TabIndex = 4;
            lbFullName.Text = "FullName";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new System.Drawing.Point(34, 271);
            lbGender.Name = "lbGender";
            lbGender.Size = new System.Drawing.Size(57, 20);
            lbGender.TabIndex = 5;
            lbGender.Text = "Gender";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new System.Drawing.Point(34, 318);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new System.Drawing.Size(50, 20);
            lbPhone.TabIndex = 6;
            lbPhone.Text = "Phone";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new System.Drawing.Point(34, 370);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new System.Drawing.Size(62, 20);
            lbAddress.TabIndex = 7;
            lbAddress.Text = "Address";
            // 
            // txtRoleID
            // 
            txtRoleID.Location = new System.Drawing.Point(141, 85);
            txtRoleID.Name = "txtRoleID";
            txtRoleID.Size = new System.Drawing.Size(251, 27);
            txtRoleID.TabIndex = 9;
            txtRoleID.Text = "4";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(141, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(251, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(141, 174);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(251, 27);
            txtPassword.TabIndex = 11;
            // 
            // txtFullName
            // 
            txtFullName.Location = new System.Drawing.Point(141, 221);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(251, 27);
            txtFullName.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(141, 315);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(251, 27);
            txtPhone.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(141, 367);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(251, 27);
            txtAddress.TabIndex = 15;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            lblTitle.Location = new System.Drawing.Point(34, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(342, 52);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "Create Veterian";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreate.Location = new System.Drawing.Point(192, 409);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(112, 32);
            btnCreate.TabIndex = 18;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "True", "False" });
            cboGender.Location = new System.Drawing.Point(141, 268);
            cboGender.Name = "cboGender";
            cboGender.Size = new System.Drawing.Size(249, 28);
            cboGender.TabIndex = 19;
            // 
            // frmCreateVeterian
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(482, 453);
            Controls.Add(cboGender);
            Controls.Add(btnCreate);
            Controls.Add(lblTitle);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtRoleID);
            Controls.Add(lbAddress);
            Controls.Add(lbPhone);
            Controls.Add(lbGender);
            Controls.Add(lbFullName);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbRoleID);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmCreateVeterian";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Create Veterian";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lbRoleID;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtRoleID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cboGender;
    }
}