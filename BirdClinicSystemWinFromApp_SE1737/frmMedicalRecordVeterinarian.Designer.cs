namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmMedicalRecordVeterinarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicalRecordVeterinarian));
            panel1 = new System.Windows.Forms.Panel();
            label8 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtCustomerName = new System.Windows.Forms.TextBox();
            txtBird = new System.Windows.Forms.TextBox();
            txtDiagnosis = new System.Windows.Forms.TextBox();
            txtIntruction = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            cbService = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(label8);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(675, 72);
            panel1.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label8.Location = new System.Drawing.Point(26, 11);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(331, 47);
            label8.TabIndex = 0;
            label8.Text = "Medical Record";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(100, 129);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 20);
            label1.TabIndex = 21;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(100, 172);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 20);
            label2.TabIndex = 22;
            label2.Text = "Bird";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(100, 269);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 20);
            label3.TabIndex = 23;
            label3.Text = "Diagnosis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(100, 362);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 20);
            label4.TabIndex = 24;
            label4.Text = "Intruction";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Enabled = false;
            txtCustomerName.Location = new System.Drawing.Point(268, 129);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(235, 27);
            txtCustomerName.TabIndex = 25;
            // 
            // txtBird
            // 
            txtBird.Enabled = false;
            txtBird.Location = new System.Drawing.Point(268, 172);
            txtBird.Name = "txtBird";
            txtBird.Size = new System.Drawing.Size(235, 27);
            txtBird.TabIndex = 26;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new System.Drawing.Point(268, 269);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new System.Drawing.Size(235, 77);
            txtDiagnosis.TabIndex = 27;
            // 
            // txtIntruction
            // 
            txtIntruction.Location = new System.Drawing.Point(268, 362);
            txtIntruction.Multiline = true;
            txtIntruction.Name = "txtIntruction";
            txtIntruction.Size = new System.Drawing.Size(235, 77);
            txtIntruction.TabIndex = 28;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnSave.Location = new System.Drawing.Point(393, 445);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(110, 33);
            btnSave.TabIndex = 39;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cbService
            // 
            cbService.FormattingEnabled = true;
            cbService.Location = new System.Drawing.Point(268, 220);
            cbService.Name = "cbService";
            cbService.Size = new System.Drawing.Size(235, 28);
            cbService.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(100, 228);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 20);
            label5.TabIndex = 41;
            label5.Text = "Service";
            // 
            // frmMedicalRecordVeterinarian
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(699, 490);
            Controls.Add(label5);
            Controls.Add(cbService);
            Controls.Add(btnSave);
            Controls.Add(txtIntruction);
            Controls.Add(txtDiagnosis);
            Controls.Add(txtBird);
            Controls.Add(txtCustomerName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmMedicalRecordVeterinarian";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Medical Record Veterinarian";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtBird;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.TextBox txtIntruction;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.Label label5;
    }
}