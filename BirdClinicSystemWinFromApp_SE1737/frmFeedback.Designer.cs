namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeedback));
            label1 = new System.Windows.Forms.Label();
            cbbRating = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            txtComment = new System.Windows.Forms.RichTextBox();
            label5 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(94, 83);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Rating";
            // 
            // cbbRating
            // 
            cbbRating.Items.AddRange(new object[] { "5", "4", "3", "2", "1" });
            cbbRating.Location = new System.Drawing.Point(200, 83);
            cbbRating.Name = "cbbRating";
            cbbRating.Size = new System.Drawing.Size(151, 28);
            cbbRating.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(94, 129);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Comment";
            // 
            // txtComment
            // 
            txtComment.Location = new System.Drawing.Point(200, 129);
            txtComment.Name = "txtComment";
            txtComment.Size = new System.Drawing.Size(262, 120);
            txtComment.TabIndex = 3;
            txtComment.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(167, 19);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(184, 29);
            label5.TabIndex = 8;
            label5.Text = "Feedback Form";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(110, 255);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(233, 255);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmFeedback
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(600, 341);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(txtComment);
            Controls.Add(label2);
            Controls.Add(cbbRating);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmFeedback";
            Text = "FeedBack";
            Load += frmFeedback_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbRating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}