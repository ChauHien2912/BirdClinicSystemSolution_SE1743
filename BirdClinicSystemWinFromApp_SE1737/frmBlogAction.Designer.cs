namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmBlogAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBlogAction));
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel1 = new System.Windows.Forms.Panel();
            lbDr = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtTitle = new System.Windows.Forms.TextBox();
            txtContent = new System.Windows.Forms.TextBox();
            txtTag = new System.Windows.Forms.TextBox();
            btnAction = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            dtpDatePublish = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            cbAuthors = new System.Windows.Forms.ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(lbDr);
            panel1.Controls.Add(label8);
            panel1.Location = new System.Drawing.Point(12, 21);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(736, 72);
            panel1.TabIndex = 21;
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
            label8.Size = new System.Drawing.Size(286, 37);
            label8.TabIndex = 0;
            label8.Text = "Blog Management";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(50, 124);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 20);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(50, 221);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 20);
            label2.TabIndex = 22;
            label2.Text = "Content";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(394, 128);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 20);
            label3.TabIndex = 23;
            label3.Text = "Tag";
            // 
            // txtTitle
            // 
            txtTitle.Location = new System.Drawing.Point(132, 121);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(215, 27);
            txtTitle.TabIndex = 24;
            // 
            // txtContent
            // 
            txtContent.Location = new System.Drawing.Point(132, 218);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new System.Drawing.Size(543, 326);
            txtContent.TabIndex = 25;
            // 
            // txtTag
            // 
            txtTag.Location = new System.Drawing.Point(498, 121);
            txtTag.Name = "txtTag";
            txtTag.Size = new System.Drawing.Size(250, 27);
            txtTag.TabIndex = 26;
            // 
            // btnAction
            // 
            btnAction.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnAction.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAction.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnAction.Location = new System.Drawing.Point(565, 553);
            btnAction.Name = "btnAction";
            btnAction.Size = new System.Drawing.Size(110, 33);
            btnAction.TabIndex = 38;
            btnAction.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(50, 173);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 20);
            label4.TabIndex = 40;
            label4.Text = "Author";
            // 
            // dtpDatePublish
            // 
            dtpDatePublish.Location = new System.Drawing.Point(498, 173);
            dtpDatePublish.Name = "dtpDatePublish";
            dtpDatePublish.Size = new System.Drawing.Size(250, 27);
            dtpDatePublish.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(394, 178);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(92, 20);
            label5.TabIndex = 42;
            label5.Text = "Date Publish";
            // 
            // cbAuthors
            // 
            cbAuthors.FormattingEnabled = true;
            cbAuthors.Location = new System.Drawing.Point(132, 170);
            cbAuthors.Name = "cbAuthors";
            cbAuthors.Size = new System.Drawing.Size(215, 28);
            cbAuthors.TabIndex = 43;
            // 
            // frmBlogAction
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(760, 598);
            Controls.Add(cbAuthors);
            Controls.Add(label5);
            Controls.Add(dtpDatePublish);
            Controls.Add(label4);
            Controls.Add(btnAction);
            Controls.Add(txtTag);
            Controls.Add(txtContent);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmBlogAction";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Blog Action";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatePublish;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAuthors;
    }
}