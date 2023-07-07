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
    public partial class frmCreateVeterian : Form
    {
        IUserRepository userRepository = new UserRepository();
        public frmCreateVeterian()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Length == 0 || txtRoleID.Text.Length == 0)
            {
                MessageBox.Show("Invalid Input", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                userRepository.CreateUser(Convert.ToInt32(txtRoleID.Text), txtEmail.Text, txtPassword.Text,
                    txtFullName.Text, Convert.ToBoolean(cboGender.Text), txtPhone.Text, txtAddress.Text);
                this.Close();
            }
        }
    }
}
