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
    public partial class frmLogin : Form
    {
        IUserRepository userRepository = new UserRepository();
        public frmLogin()
        {
            InitializeComponent();
        }
        #region Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
        #region Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            TblUser user = userRepository.CheckLogin(txtEmail.Text, txtPassword.Text);
            if (user != null)
            {
                if (user.RoleId == 1)
                {
                    frmAppointmentAdmin frmApp = new frmAppointmentAdmin();
                    this.Hide();
                    frmApp.ShowDialog();
                    this.Close();
                }
                else if (user.RoleId == 2)
                {
                    Properties.Settings.Default.MyStaff = txtEmail.Text;
                    frmAppointmentStaff frmAppointmentStaff = new frmAppointmentStaff();
                    this.Hide();
                    frmAppointmentStaff.ShowDialog();
                    this.Show();

                }
                else if (user.RoleId == 3)
                {

                    Properties.Settings.Default.MyAccount = txtEmail.Text;
                    frmHome frmHome = new frmHome();
                    frmHome.ShowDialog();

                }
                else if (user.RoleId == 4)
                {

                    frmAppointmentVeterinarian frmAppointmentVeterinarian = new frmAppointmentVeterinarian(user);
                    this.Hide();
                    frmAppointmentVeterinarian.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("Invalid Email or Password", "Login Notification",
                                           MessageBoxButtons.OKCancel, MessageBoxIcon.Error,
                                           MessageBoxDefaultButton.Button1);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }
        #endregion
    }
}
