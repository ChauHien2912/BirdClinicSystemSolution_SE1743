namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmServiceDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceDetails));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtServiceID = new System.Windows.Forms.TextBox();
            txtServiceName = new System.Windows.Forms.TextBox();
            txtStatus = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            btnAction = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtDes = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 25.8000011F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label1.Location = new System.Drawing.Point(92, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(328, 60);
            label1.TabIndex = 0;
            label1.Text = "Service Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(92, 160);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Service ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(92, 220);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Service Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(92, 289);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(92, 352);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(100, 474);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(41, 20);
            label6.TabIndex = 5;
            label6.Text = "Price";
            // 
            // txtServiceID
            // 
            txtServiceID.Location = new System.Drawing.Point(219, 153);
            txtServiceID.Name = "txtServiceID";
            txtServiceID.Size = new System.Drawing.Size(177, 27);
            txtServiceID.TabIndex = 6;
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new System.Drawing.Point(219, 213);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new System.Drawing.Size(177, 27);
            txtServiceName.TabIndex = 7;
            // 
            // txtStatus
            // 
            txtStatus.Location = new System.Drawing.Point(219, 282);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new System.Drawing.Size(177, 27);
            txtStatus.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(219, 474);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(177, 27);
            txtPrice.TabIndex = 10;
            // 
            // btnAction
            // 
            btnAction.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnAction.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAction.ForeColor = System.Drawing.Color.White;
            btnAction.Location = new System.Drawing.Point(71, 565);
            btnAction.Name = "btnAction";
            btnAction.Size = new System.Drawing.Size(150, 35);
            btnAction.TabIndex = 11;
            btnAction.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(270, 565);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(150, 35);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtDes
            // 
            txtDes.Location = new System.Drawing.Point(219, 336);
            txtDes.Name = "txtDes";
            txtDes.Size = new System.Drawing.Size(177, 120);
            txtDes.TabIndex = 13;
            txtDes.Text = "";
            // 
            // frmServiceDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(503, 666);
            Controls.Add(txtDes);
            Controls.Add(btnCancel);
            Controls.Add(btnAction);
            Controls.Add(txtPrice);
            Controls.Add(txtStatus);
            Controls.Add(txtServiceName);
            Controls.Add(txtServiceID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmServiceDetails";
            Text = "Service Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox txtDes;
    }
}