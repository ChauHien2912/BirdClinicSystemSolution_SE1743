
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
    public partial class frmVeterian : Form
    {
        IUserRepository userRepository = new UserRepository();
        public frmVeterian()
        {
            InitializeComponent();
        }

        private void LoadListUser()
        {
            var user = userRepository.getUser(false);
            BindingSource source = new BindingSource();
            source.DataSource = user;

            txtUserID.DataBindings.Clear();
            txtRoleID.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtGender.DataBindings.Clear();
            txtFullName.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtAddress.DataBindings.Clear();

            txtUserID.DataBindings.Add("Text", source, "UserID");
            txtRoleID.DataBindings.Add("Text", source, "RoleID");
            txtEmail.DataBindings.Add("Text", source, "Email");
            txtPassword.DataBindings.Add("Text", source, "Password");
            txtFullName.DataBindings.Add("Text", source, "FullName");
            txtGender.DataBindings.Add("Text", source, "Gender");
            txtPhone.DataBindings.Add("Text", source, "Phone");
            txtAddress.DataBindings.Add("Text", source, "Address");

            txtUserID.Visible = false;
            lbUserID.Visible = false;

            dgvVeterian.DataSource = null;
            dgvVeterian.DataSource = source;
            dgvVeterian.Columns["Role"].Visible = false;
            dgvVeterian.Columns["tblBlogs"].Visible = false;
            dgvVeterian.Columns["tblAppointmentDoctors"].Visible = false;
            dgvVeterian.Columns["tblAppointmentStaffs"].Visible = false;
            dgvVeterian.Columns["tblAppointmentUsers"].Visible = false;
            dgvVeterian.Columns["tblMedicalRecordDoctors"].Visible = false;
            dgvVeterian.Columns["tblMedicalRecordUsers"].Visible = false;
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            LoadListUser();
        }

        private bool MessageBoxQuestion(string content)
        {
            bool OK = false;
            DialogResult d = MessageBox.Show(content, Text + " - Notification", MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                OK = true;
            }
            return OK;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Length == 0 || txtEmail.Text.Length == 0 || txtUserID.Text.Length == 0)
            {
                MessageBox.Show("Invalid Input", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool OK = MessageBoxQuestion("Do you want to update?");
                if (OK == true)
                {
                    userRepository.UpdateUser(Convert.ToInt32(txtUserID.Text), Convert.ToInt32(txtRoleID.Text), txtEmail.Text, txtPassword.Text,
                        txtFullName.Text, Convert.ToBoolean(txtGender.Text), txtPhone.Text, txtAddress.Text);
                    LoadListUser();
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateVeterian frmCreateVeterian = new frmCreateVeterian();
            this.Hide();
            frmCreateVeterian.ShowDialog();
            this.Show();
            LoadListUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool OK = MessageBoxQuestion("Do you want to delete?");
            userRepository.DeleteUser(Convert.ToInt32(txtUserID.Text));
            LoadListUser();
        }

        private void frmVeterian_Load(object sender, EventArgs e)
        {
            LoadListUser();
        }
    }
}
