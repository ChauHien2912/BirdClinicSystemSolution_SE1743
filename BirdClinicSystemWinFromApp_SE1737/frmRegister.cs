using Repositories;
using System;
using System.Windows.Forms;

namespace BirdClinicSystemWinFromApp_SE1737
{
    public partial class frmRegister : Form
    {
        IUserRepository userRepository = new UserRepository();
        public frmRegister()
        {
            InitializeComponent();
        }

        #region Methods
        private void MessageShow(string content)
        {
            MessageBox.Show(content, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }
        #endregion

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text && txtPassword.Text.Length != 0)
            {
                if (txtFullName.Text.Length != 0)
                {
                    int phoneNumber = 0;
                    if (txtEmail.Text.Contains("@gmail.com"))
                    {
                        int phonNumber = 0;
                        if (int.TryParse(txtPhoneNumber.Text, out phonNumber) && txtPhoneNumber.Text.Length >= 10)
                        {
                            bool gender = rdFemale.Checked;
                            bool success = userRepository.Register(txtFullName.Text, txtEmail.Text, txtPassword.Text, txtAddress.Text, txtPhoneNumber.Text, gender);
                            if (success)
                            {
                                MessageBox.Show("Register Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("This Email was registered!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                            }
                        }
                        else
                        {
                            MessageShow("The phone number should not contain any numeric characters and more than 9. Please enter a valid phone number.");
                            txtPhoneNumber.Focus();
                        }
                    }
                    else
                    {
                        MessageShow("The email you entered is not valid. Please make sure it follows the format 'example@gmail.com'.");
                        txtEmail.Focus();
                    }
                }
                else
                {
                    MessageShow("Full Name can not be empty.");
                    txtFullName.Focus();
                }
            }
            else
            {
                MessageShow("Password does not match. Please check again!");
                txtPassword.Focus();
            }
        }
    }
}
