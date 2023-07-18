using BusinessObjects;
using DataAccessObjects;
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

    public partial class frmAppointment : Form
    {

        IAppointmentRepository AppointmentRepository = new AppointmentRepository();
        BindingSource source;
        String user = Properties.Settings.Default.MyAccount;
        public frmAppointment()
        {
            InitializeComponent();
        }

        #region
        private void AddAppointmentIDToBox()
        {
            cbbAppointmentID.Items.Clear();
            var AppointmentID = AppointmentRepository
                .GetAllAppointmentsByEmail(user)
                .Select(x => x.AppointmentId)
                .ToList();

            foreach (var app in AppointmentID)
            {
                cbbAppointmentID.Items.Add(app);
            }
        }

        private void frmAppointment_Load(object sender, EventArgs e)
        {
            AddAppointmentIDToBox();
            btnPay.Enabled = false;
            btnFeedBack.Enabled = false;
            cbbAppointmentID.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #endregion

        private void ClearData(bool isTrue)
        {
            if (isTrue)
            {
                txtBirdID.DataBindings.Clear();
                txtDate.DataBindings.Clear();
                txtDoctorID.DataBindings.Clear();
                txtServiceID.DataBindings.Clear();
                txtStaffID.DataBindings.Clear();
                txtStatusID.DataBindings.Clear();
                txtTime.DataBindings.Clear();
                txtUserID.DataBindings.Clear();
            }
            else
            {

                txtBirdID.Clear();
                txtDate.Clear();
                txtDoctorID.Clear();
                txtServiceID.Clear();
                txtStaffID.Clear();
                txtStatusID.Clear();
                txtTime.Clear();
                txtUserID.Clear();
            }
        }

        private void BindData(List<TblAppointment> list)
        {
            source = new BindingSource();
            source.DataSource = list;

            ClearData(true);

            txtBirdID.DataBindings.Add("Text", source, "BirdID");
            txtDate.DataBindings.Add("Text", source, "AppointmentDate");
            txtDoctorID.DataBindings.Add("Text", source, "DoctorID");
            txtServiceID.DataBindings.Add("Text", source, "ServiceID");
            txtStaffID.DataBindings.Add("Text", source, "StaffID");
            txtStatusID.DataBindings.Add("Text", source, "Status");
            txtTime.DataBindings.Add("Text", source, "AppointmentTime");
            txtUserID.Text = AppointmentRepository.GetUserNameFromEmail(user);

            if (txtStatusID.Text == "0")
            {
                txtStatusID.Text = "Pending";
            }
            else if (txtStatusID.Text == "1") { txtStatusID.Text = "Approved"; }
            else if (txtStatusID.Text == "2") { txtStatusID.Text = "Canceled"; }
            else if (txtStatusID.Text == "3") { txtStatusID.Text = "Completed"; }
            int serviceID = Int32.Parse(txtServiceID.Text);
            txtServiceID.Text = AppointmentRepository.GetService(serviceID);
            if (!txtDoctorID.Text.Equals("") && !txtStaffID.Text.Equals(""))
            {
                int doctorID = Int32.Parse(txtDoctorID.Text);
                txtDoctorID.Text = AppointmentRepository.getDoctorAndStaff(doctorID);

                int staffID = Int32.Parse(txtStaffID.Text);
                txtStaffID.Text = AppointmentRepository.getDoctorAndStaff(staffID);
            }

            // txtBirdID.Text = AppointmentRepository.GetBirdNameByID(int.Parse(txtBirdID.Text));


            txtBirdID.ReadOnly = true;
            txtDate.ReadOnly = true;
            txtDoctorID.ReadOnly = true;
            txtServiceID.ReadOnly = true;
            txtStaffID.ReadOnly = true;
            txtStatusID.ReadOnly = true;
            txtTime.ReadOnly = true;
            txtUserID.ReadOnly = true;
        }

        private void cbbAppointmentID_SelectedValueChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnDelete.BackColor = Color.OrangeRed;
            btnFeedBack.Enabled = true;
            btnFeedBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            int selectedValue = (int)cbbAppointmentID.SelectedItem;
            var appointment = AppointmentRepository
                .GetAllAppointmentsByEmail(user)
                .Where(a => a.AppointmentId == selectedValue)
                .ToList();
            BindData(appointment);
            if (txtStatusID.Text == "Approved")
            {
                btnPay.Enabled = true;
                btnDelete.Enabled = false;
                btnDelete.BackColor = SystemColors.Control;
            }
            if (txtStatusID.Text == "Completed")
            {
                btnFeedBack.Enabled = true;
                btnDelete.Enabled = false;
                btnDelete.BackColor = SystemColors.Control;
            }
            else
            {
                btnFeedBack.Enabled = false;
                btnFeedBack.BackColor = SystemColors.Control;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateAppointment frmCreateAppointment = new frmCreateAppointment();
            frmCreateAppointment.ShowDialog();
            AddAppointmentIDToBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDeleteAppointment frmDeleteAppointment = new frmDeleteAppointment
            {
                DeleteOrPay = true,
                AppointmentID = cbbAppointmentID.Text,
                UserID = txtUserID.Text,
                BirdType = txtBirdID.Text,
                Date = txtDate.Text,
                Time = txtTime.Text,
                Service = txtServiceID.Text,
            };
            frmDeleteAppointment.ShowDialog();
            ClearData(false);
            cbbAppointmentID.ResetText();
            AddAppointmentIDToBox();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            frmDeleteAppointment frmDeleteAppointment = new frmDeleteAppointment
            {
                DeleteOrPay = false,
                Text = "Pay For Appointment",
                AppointmentID = cbbAppointmentID.Text,
                UserID = txtUserID.Text,
                BirdType = txtBirdID.Text,
                Date = txtDate.Text,
                Time = txtTime.Text,
                Service = txtServiceID.Text,
            };
            frmDeleteAppointment.ShowDialog();
            ClearData(false);
            cbbAppointmentID.ResetText();
            AddAppointmentIDToBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtStatusID_TextChanged(object sender, EventArgs e)
        {
            string txt = txtStatusID.Text;
            if (txt != "Approved")
            {
                btnPay.Enabled = false;
            }
        }

        private void btnFeedBack_Click(object sender, EventArgs e)
        {
            frmFeedback frmFeedback = new frmFeedback()
            {
                AppID = Int32.Parse(cbbAppointmentID.Text)
            };
            frmFeedback.ShowDialog();
        }
    }
}
