namespace BirdClinicSystemWinFromApp_SE1737
{
    partial class frmCreateBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateBird));
            label1 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            cbbSpecie = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            cbbGender = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            txtAge = new System.Windows.Forms.TextBox();
            txtWeight = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtDes = new System.Windows.Forms.RichTextBox();
            btnCreate = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(110, 22);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(27, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Specie";
            // 
            // cbbSpecie
            // 
            cbbSpecie.FormattingEnabled = true;
            cbbSpecie.Items.AddRange(new object[] { "Parrot", "Canary", "Finch", "Pigeon" });
            cbbSpecie.Location = new System.Drawing.Point(110, 55);
            cbbSpecie.Name = "cbbSpecie";
            cbbSpecie.Size = new System.Drawing.Size(151, 28);
            cbbSpecie.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(28, 92);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 20);
            label3.TabIndex = 4;
            label3.Text = "Gender";
            // 
            // cbbGender
            // 
            cbbGender.FormattingEnabled = true;
            cbbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbbGender.Location = new System.Drawing.Point(110, 89);
            cbbGender.Name = "cbbGender";
            cbbGender.Size = new System.Drawing.Size(151, 28);
            cbbGender.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(28, 126);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 20);
            label4.TabIndex = 6;
            label4.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new System.Drawing.Point(110, 123);
            txtAge.Name = "txtAge";
            txtAge.Size = new System.Drawing.Size(75, 27);
            txtAge.TabIndex = 7;
            // 
            // txtWeight
            // 
            txtWeight.Location = new System.Drawing.Point(110, 156);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new System.Drawing.Size(125, 27);
            txtWeight.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(28, 159);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 20);
            label5.TabIndex = 8;
            label5.Text = "Weight";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(24, 217);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(80, 20);
            label6.TabIndex = 10;
            label6.Text = "Bird Detail";
            // 
            // txtDes
            // 
            txtDes.Location = new System.Drawing.Point(110, 189);
            txtDes.Name = "txtDes";
            txtDes.Size = new System.Drawing.Size(178, 80);
            txtDes.TabIndex = 11;
            txtDes.Text = "";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreate.Location = new System.Drawing.Point(28, 291);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(94, 29);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Location = new System.Drawing.Point(141, 291);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCreateBird
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(316, 361);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(txtDes);
            Controls.Add(label6);
            Controls.Add(txtWeight);
            Controls.Add(label5);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(cbbGender);
            Controls.Add(label3);
            Controls.Add(cbbSpecie);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "frmCreateBird";
            Text = "Create Bird";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbSpecie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDes;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
    }
}