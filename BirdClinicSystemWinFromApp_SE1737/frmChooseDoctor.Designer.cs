namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmChooseDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChooseDoctor));
            cbbDoctorID = new System.Windows.Forms.ComboBox();
            btnAccept = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // cbbDoctorID
            // 
            cbbDoctorID.FormattingEnabled = true;
            cbbDoctorID.Location = new System.Drawing.Point(45, 44);
            cbbDoctorID.Name = "cbbDoctorID";
            cbbDoctorID.Size = new System.Drawing.Size(151, 28);
            cbbDoctorID.TabIndex = 0;
            // 
            // btnAccept
            // 
            btnAccept.Location = new System.Drawing.Point(12, 121);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new System.Drawing.Size(94, 29);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(112, 121);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmChooseDoctor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(250, 212);
            Controls.Add(btnClose);
            Controls.Add(btnAccept);
            Controls.Add(cbbDoctorID);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmChooseDoctor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Choose Doctor";
            Load += frmChooseDoctor_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox cbbDoctorID;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnClose;
    }
}