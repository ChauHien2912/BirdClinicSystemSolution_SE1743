namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmService));
            label1 = new System.Windows.Forms.Label();
            dGVService = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lblPrice = new System.Windows.Forms.Label();
            txtServiceID = new System.Windows.Forms.TextBox();
            txtServiceName = new System.Windows.Forms.TextBox();
            txtStatus = new System.Windows.Forms.TextBox();
            txtDes = new System.Windows.Forms.RichTextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            btnCreate = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dGVService).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 25.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label1.Location = new System.Drawing.Point(93, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(464, 60);
            label1.TabIndex = 0;
            label1.Text = "Service Management";
            // 
            // dGVService
            // 
            dGVService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVService.Location = new System.Drawing.Point(32, 102);
            dGVService.Name = "dGVService";
            dGVService.RowHeadersWidth = 51;
            dGVService.RowTemplate.Height = 29;
            dGVService.Size = new System.Drawing.Size(581, 421);
            dGVService.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(671, 113);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "ServiceID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(671, 174);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(100, 20);
            label3.TabIndex = 3;
            label3.Text = "Service Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(671, 233);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 20);
            label4.TabIndex = 4;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(671, 286);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(85, 20);
            label5.TabIndex = 5;
            label5.Text = "Description";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(679, 434);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(41, 20);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // txtServiceID
            // 
            txtServiceID.Location = new System.Drawing.Point(788, 106);
            txtServiceID.Name = "txtServiceID";
            txtServiceID.Size = new System.Drawing.Size(227, 27);
            txtServiceID.TabIndex = 7;
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new System.Drawing.Point(788, 167);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new System.Drawing.Size(227, 27);
            txtServiceName.TabIndex = 8;
            // 
            // txtStatus
            // 
            txtStatus.Location = new System.Drawing.Point(788, 226);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new System.Drawing.Size(227, 27);
            txtStatus.TabIndex = 9;
            // 
            // txtDes
            // 
            txtDes.Location = new System.Drawing.Point(788, 283);
            txtDes.Name = "txtDes";
            txtDes.Size = new System.Drawing.Size(227, 120);
            txtDes.TabIndex = 10;
            txtDes.Text = "";
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(788, 427);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(221, 27);
            txtPrice.TabIndex = 11;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnCreate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCreate.ForeColor = System.Drawing.Color.White;
            btnCreate.Location = new System.Drawing.Point(637, 490);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(150, 35);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(793, 490);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(150, 35);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(948, 490);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(150, 35);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmService
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1101, 573);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(txtPrice);
            Controls.Add(txtDes);
            Controls.Add(txtStatus);
            Controls.Add(txtServiceName);
            Controls.Add(txtServiceID);
            Controls.Add(lblPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dGVService);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmService";
            Text = "Service";
            ((System.ComponentModel.ISupportInitialize)dGVService).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.RichTextBox txtDes;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}