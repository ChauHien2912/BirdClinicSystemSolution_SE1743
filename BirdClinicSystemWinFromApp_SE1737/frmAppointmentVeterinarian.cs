using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using BusinessObjects;
using System.Windows.Forms;

namespace BirdClinicSystemWinFromApp_SE1737
{
    public partial class frmAppointmentVeterinarian : Form
    {
        IUserRepository userRepository = new UserRepository();
        TblUser user { get; set; }
        public frmAppointmentVeterinarian(TblUser u)
        {
            InitializeComponent();
            this.user = u;
            LoadAppointments();
        }
        #region Methods
        private void LoadAppointments()
        {
            lbDr.Text = user.FullName;
            var appointments = userRepository.GetAppointmentsByVeterianarianId(user.UserId);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = appointments;

            txtUserName.DataBindings.Clear();
            txtAppointmentID.DataBindings.Clear();
            txtBird.DataBindings.Clear();
            txtService.DataBindings.Clear();
            dtpAppointmentDate.DataBindings.Clear();
            dtpAppointmentTime.DataBindings.Clear();
            lbPrice.DataBindings.Clear();

            if (bindingSource.Count > 0)
            {
                txtAppointmentID.DataBindings.Add("Text", bindingSource, "AppointmentId");
                txtUserName.DataBindings.Add("Text", bindingSource, "FullName");
                txtBird.DataBindings.Add("Text", bindingSource, "Species");
                dtpAppointmentDate.DataBindings.Add("Text", bindingSource, "AppointmentDate");
                dtpAppointmentTime.DataBindings.Add("Text", bindingSource, "AppointmentTime");
                txtService.DataBindings.Add("Text", bindingSource, "ServiceName");
                lbPrice.DataBindings.Add("Text", bindingSource, "Price", true, DataSourceUpdateMode.OnPropertyChanged);
                lbPrice.DataBindings["Text"].Format += (sender, e) =>
                {
                    if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        e.Value = "$" + e.Value.ToString();
                    }
                };
            }


            dtgvAppointments.DataSource = bindingSource;
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

        #region Methods
        private void btnComplete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want to complete the appointment?", "Notification",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                       MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Yes)
            {
                userRepository.CompleteAppointment(Convert.ToInt32(txtAppointmentID.Text));
                LoadAppointments();
            }
        }
        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfileDetail frmProfileDetail = new frmProfileDetail(user);
            frmProfileDetail.ShowDialog();
            LoadAppointments();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(userRepository.GetUserById(user.UserId));
            frmChangePassword.ShowDialog();
        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBlog frmPost = new frmBlog();
            this.Hide();
            frmPost.ShowDialog();
            this.Show();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            frmMedicalRecordVeterinarian frmMedicalRecordVeterinarian = new frmMedicalRecordVeterinarian(Convert.ToInt32(txtAppointmentID.Text));
            frmMedicalRecordVeterinarian.ShowDialog();
            LoadAppointments();
        }
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBlogAction frmBlogAction = new frmBlogAction();
            this.Hide();
            frmBlogAction.ShowDialog();
            this.Show();
        }
        private void btnComplete_Click_1(object sender, EventArgs e)
        {
            if(MessageBoxQuestion("Do you want to complete"))
            {
                userRepository.CompleteAppointment(Convert.ToInt32(txtAppointmentID.Text));
                LoadAppointments();
            }
        }
        #endregion
    }
}
