namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            panel1 = new System.Windows.Forms.Panel();
            lbDr = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnChange = new System.Windows.Forms.Button();
            txtCurrentPassword = new System.Windows.Forms.TextBox();
            txtNewPassword = new System.Windows.Forms.TextBox();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(lbDr);
            panel1.Controls.Add(label8);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(479, 72);
            panel1.TabIndex = 20;
            // 
            // lbDr
            // 
            lbDr.AutoSize = true;
            lbDr.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbDr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lbDr.Location = new System.Drawing.Point(642, 17);
            lbDr.Name = "lbDr";
            lbDr.Size = new System.Drawing.Size(0, 37);
            lbDr.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label8.Location = new System.Drawing.Point(22, 15);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(279, 37);
            label8.TabIndex = 0;
            label8.Text = "Change Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(34, 120);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(122, 20);
            label4.TabIndex = 24;
            label4.Text = "Current Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(34, 159);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 20);
            label1.TabIndex = 25;
            label1.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(34, 194);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(127, 20);
            label2.TabIndex = 26;
            label2.Text = "Confirm Password";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnCancel.Location = new System.Drawing.Point(327, 235);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(110, 33);
            btnCancel.TabIndex = 36;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnChange
            // 
            btnChange.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            btnChange.FlatAppearance.BorderSize = 0;
            btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnChange.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnChange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnChange.Location = new System.Drawing.Point(211, 235);
            btnChange.Name = "btnChange";
            btnChange.Size = new System.Drawing.Size(110, 33);
            btnChange.TabIndex = 37;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new System.Drawing.Point(211, 117);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new System.Drawing.Size(226, 27);
            txtCurrentPassword.TabIndex = 38;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new System.Drawing.Point(211, 154);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new System.Drawing.Size(226, 27);
            txtNewPassword.TabIndex = 39;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new System.Drawing.Point(211, 191);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new System.Drawing.Size(226, 27);
            txtConfirmPassword.TabIndex = 40;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(503, 313);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(btnChange);
            Controls.Add(btnCancel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmChangePassword";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Change Password";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
    }
}