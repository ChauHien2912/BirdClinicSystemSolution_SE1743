namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmAppointmentVeterinarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointmentVeterinarian));
            dtgvAppointments = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtAppointmentID = new System.Windows.Forms.TextBox();
            dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            dtpAppointmentTime = new System.Windows.Forms.DateTimePicker();
            txtUserName = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            lbDr = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            txtBird = new System.Windows.Forms.TextBox();
            txtService = new System.Windows.Forms.TextBox();
            lbPrice = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            postToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnSave = new System.Windows.Forms.Button();
            btnComplete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dtgvAppointments).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvAppointments
            // 
            dtgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAppointments.Location = new System.Drawing.Point(12, 116);
            dtgvAppointments.Name = "dtgvAppointments";
            dtgvAppointments.RowHeadersWidth = 51;
            dtgvAppointments.RowTemplate.Height = 29;
            dtgvAppointments.Size = new System.Drawing.Size(583, 544);
            dtgvAppointments.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(631, 142);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 20);
            label1.TabIndex = 1;
            label1.Text = "AppointmentID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(631, 191);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 20);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(631, 237);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 20);
            label3.TabIndex = 3;
            label3.Text = "Bird";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(631, 285);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(133, 20);
            label4.TabIndex = 4;
            label4.Text = "Appointment Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(630, 333);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(134, 20);
            label5.TabIndex = 5;
            label5.Text = "Appointment Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(630, 377);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(106, 20);
            label6.TabIndex = 6;
            label6.Text = "Services Name";
            // 
            // txtAppointmentID
            // 
            txtAppointmentID.Enabled = false;
            txtAppointmentID.Location = new System.Drawing.Point(803, 135);
            txtAppointmentID.Name = "txtAppointmentID";
            txtAppointmentID.Size = new System.Drawing.Size(250, 27);
            txtAppointmentID.TabIndex = 7;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Location = new System.Drawing.Point(803, 280);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new System.Drawing.Size(250, 27);
            dtpAppointmentDate.TabIndex = 8;
            // 
            // dtpAppointmentTime
            // 
            dtpAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpAppointmentTime.Location = new System.Drawing.Point(803, 326);
            dtpAppointmentTime.Name = "dtpAppointmentTime";
            dtpAppointmentTime.Size = new System.Drawing.Size(250, 27);
            dtpAppointmentTime.TabIndex = 10;
            // 
            // txtUserName
            // 
            txtUserName.Location = new System.Drawing.Point(803, 184);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(250, 27);
            txtUserName.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label7.Location = new System.Drawing.Point(631, 417);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(71, 31);
            label7.TabIndex = 13;
            label7.Text = "Price:";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(lbDr);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Location = new System.Drawing.Point(12, 38);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1085, 72);
            panel1.TabIndex = 18;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label9.Location = new System.Drawing.Point(453, 17);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(202, 37);
            label9.TabIndex = 1;
            label9.Text = "Welcome Dr.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label8.Location = new System.Drawing.Point(45, 17);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(420, 37);
            label8.TabIndex = 0;
            label8.Text = "Appointment Management,";
            // 
            // txtBird
            // 
            txtBird.Location = new System.Drawing.Point(803, 234);
            txtBird.Name = "txtBird";
            txtBird.Size = new System.Drawing.Size(250, 27);
            txtBird.TabIndex = 19;
            // 
            // txtService
            // 
            txtService.Location = new System.Drawing.Point(803, 374);
            txtService.Name = "txtService";
            txtService.Size = new System.Drawing.Size(250, 27);
            txtService.TabIndex = 20;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbPrice.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            lbPrice.Location = new System.Drawing.Point(696, 417);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(40, 31);
            lbPrice.TabIndex = 21;
            lbPrice.Text = "$0";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { profileToolStripMenuItem, postToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1109, 28);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { viewProfileToolStripMenuItem, changePasswordToolStripMenuItem });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // viewProfileToolStripMenuItem
            // 
            viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            viewProfileToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            viewProfileToolStripMenuItem.Text = "View Profile";
            viewProfileToolStripMenuItem.Click += viewProfileToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // postToolStripMenuItem
            // 
            postToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { createToolStripMenuItem, viewToolStripMenuItem });
            postToolStripMenuItem.Name = "postToolStripMenuItem";
            postToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            postToolStripMenuItem.Text = "Post";
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            createToolStripMenuItem.Text = "Create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnSave.Location = new System.Drawing.Point(803, 458);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(250, 36);
            btnSave.TabIndex = 23;
            btnSave.Text = "Create medical course";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnComplete
            // 
            btnComplete.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnComplete.FlatAppearance.BorderSize = 0;
            btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnComplete.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnComplete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnComplete.Location = new System.Drawing.Point(803, 509);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new System.Drawing.Size(250, 36);
            btnComplete.TabIndex = 24;
            btnComplete.Text = "Complete";
            btnComplete.UseVisualStyleBackColor = false;
            btnComplete.Click += btnComplete_Click_1;
            // 
            // frmAppointmentVeterinarian
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1109, 672);
            Controls.Add(btnComplete);
            Controls.Add(btnSave);
            Controls.Add(lbPrice);
            Controls.Add(txtService);
            Controls.Add(txtBird);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(txtUserName);
            Controls.Add(dtpAppointmentTime);
            Controls.Add(dtpAppointmentDate);
            Controls.Add(txtAppointmentID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgvAppointments);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmAppointmentVeterinarian";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Appointment Veterinarian";
            ((System.ComponentModel.ISupportInitialize)dtgvAppointments).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvAppointments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAppointmentID;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.DateTimePicker dtpAppointmentTime;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBird;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbDr;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnComplete;
    }
}