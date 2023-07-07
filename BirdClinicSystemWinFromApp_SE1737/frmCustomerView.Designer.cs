namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmCustomerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerView));
            dGVListUser = new System.Windows.Forms.DataGridView();
            lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dGVListUser).BeginInit();
            SuspendLayout();
            // 
            // dGVListUser
            // 
            dGVListUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVListUser.Location = new System.Drawing.Point(34, 140);
            dGVListUser.Name = "dGVListUser";
            dGVListUser.RowHeadersWidth = 51;
            dGVListUser.RowTemplate.Height = 29;
            dGVListUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dGVListUser.Size = new System.Drawing.Size(922, 276);
            dGVListUser.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            lblTitle.Location = new System.Drawing.Point(356, 41);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(235, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Customer";
            // 
            // frmCustomerView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(989, 445);
            Controls.Add(lblTitle);
            Controls.Add(dGVListUser);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmCustomerView";
            Text = "Customer View";
            Load += frmCustomerView_Load;
            ((System.ComponentModel.ISupportInitialize)dGVListUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dGVListUser;
        private System.Windows.Forms.Label lblTitle;
    }
}