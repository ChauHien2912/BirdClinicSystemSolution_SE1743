namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmBlog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBlog));
            flBlog = new System.Windows.Forms.FlowLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            label8 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnRemove = new System.Windows.Forms.Button();
            txtBlogID = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flBlog
            // 
            flBlog.AutoScroll = true;
            flBlog.Location = new System.Drawing.Point(12, 101);
            flBlog.Name = "flBlog";
            flBlog.Size = new System.Drawing.Size(776, 320);
            flBlog.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(label8);
            panel1.Location = new System.Drawing.Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(776, 72);
            panel1.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label8.Location = new System.Drawing.Point(26, 11);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(105, 47);
            label8.TabIndex = 0;
            label8.Text = "Blog";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnAdd.Location = new System.Drawing.Point(678, 428);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(110, 33);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnUpdate.Location = new System.Drawing.Point(562, 428);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(110, 33);
            btnUpdate.TabIndex = 39;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemove.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnRemove.Location = new System.Drawing.Point(446, 427);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(110, 33);
            btnRemove.TabIndex = 40;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // txtBlogID
            // 
            txtBlogID.Location = new System.Drawing.Point(163, 431);
            txtBlogID.Name = "txtBlogID";
            txtBlogID.Size = new System.Drawing.Size(125, 27);
            txtBlogID.TabIndex = 41;
            txtBlogID.Visible = false;
            // 
            // frmBlog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(804, 473);
            Controls.Add(txtBlogID);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Controls.Add(flBlog);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmBlog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Blog";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flBlog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtBlogID;
    }
}