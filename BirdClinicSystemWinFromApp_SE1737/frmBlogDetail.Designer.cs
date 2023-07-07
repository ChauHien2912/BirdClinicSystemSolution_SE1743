namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmBlogDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBlogDetail));
            lbTitle = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtContent = new System.Windows.Forms.TextBox();
            lbAuthor = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lbPublishDate = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTitle.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            lbTitle.Location = new System.Drawing.Point(158, 27);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(0, 47);
            lbTitle.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(598, 548);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Author:";
            // 
            // txtContent
            // 
            txtContent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtContent.Location = new System.Drawing.Point(12, 77);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new System.Drawing.Size(776, 451);
            txtContent.TabIndex = 4;
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.Location = new System.Drawing.Point(651, 548);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new System.Drawing.Size(0, 20);
            lbAuthor.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 548);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 20);
            label1.TabIndex = 6;
            label1.Text = "Published Date:";
            // 
            // lbPublishDate
            // 
            lbPublishDate.AutoSize = true;
            lbPublishDate.Location = new System.Drawing.Point(130, 548);
            lbPublishDate.Name = "lbPublishDate";
            lbPublishDate.Size = new System.Drawing.Size(0, 20);
            lbPublishDate.TabIndex = 7;
            // 
            // frmBlogDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 615);
            Controls.Add(lbPublishDate);
            Controls.Add(label1);
            Controls.Add(lbAuthor);
            Controls.Add(txtContent);
            Controls.Add(label3);
            Controls.Add(lbTitle);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmBlogDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Blog Detail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPublishDate;
    }
}