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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BirdClinicSystemWinFromApp_SE1737
{
    public partial class frmProfileDetail : Form
    {
        IUserRepository userRepository = new UserRepository();
        public TblUser user { get; set; }
        public frmProfileDetail(TblUser u)
        {
            InitializeComponent();
            this.user = u;
            LoadUser();
        }
        #region Methods
        private void LoadUser()
        {
            user = userRepository.GetUserById(user.UserId);
            txtUserID.Text = user.UserId.ToString();
            txtFullName.Text = user.FullName;
            txtEmail.Text = user.Email;
            txtAddress.Text = user.Address;
            txtPhoneNumber.Text = user.Phone;
            txtPassword.Text = user.Password;
            if (user.Gender == false) rdMale.Checked = true;
            else rdFemale.Checked = true;
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
        #endregion

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Length == 0 || txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Invadlid input, FullName and Email can not be EMPTY", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                bool OK = MessageBoxQuestion("Do you want to edit your profile?");
                bool gender = rdFemale.Checked;

                if (OK)
                {
                    userRepository.UpdateProfile(Convert.ToInt32(txtUserID.Text), txtFullName.Text, txtEmail.Text, gender, txtPhoneNumber.Text, txtAddress.Text);
                    LoadUser();
                }
            }
        }
        #endregion


    }
}
