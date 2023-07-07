using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdClinicSystemWinFromApp_SE1737
{
    public partial class frmChangePassword : Form
    {
        IUserRepository userRepository = new UserRepository();
        TblUser user { get; set; }
        public frmChangePassword(TblUser u)
        {
            InitializeComponent();
            this.user = u;
        }
        private bool MessageBoxQuestion(string content)
        {
            DialogResult d = MessageBox.Show(content, Text + " - Notification", MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                return true;
            }
            return false;
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text == user.Password)
            {
                if (txtConfirmPassword.Text == txtConfirmPassword.Text && txtConfirmPassword.Text.Length != 0)
                {
                    if (MessageBoxQuestion("Do you want to change password?"))
                    {
                        userRepository.ChangePassword(user.UserId, txtNewPassword.Text);
                        MessageBox.Show("Change Password successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Current Password does not match!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
