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
    public partial class frmCreateAppointment : Form
    {

        IAppointmentRepository AppointmentRepository = new AppointmentRepository();
        public TblAppointment TblAppointment { get; set; }
        String user = Properties.Settings.Default.MyAccount;
        public frmCreateAppointment()
        {
            InitializeComponent();
        }
        #region
        private void AddItemToBox()
        {
            var bird = AppointmentRepository.GetBirdID(user).ToList();
            foreach (var item in bird)
            {
                cbbBirdID.Items.Add(item);
            }

            var Service = AppointmentRepository.GetServices().ToList();

            foreach (var item in Service)
            {
                cbbService.Items.Add(item);
            }
        }
        #endregion
        private void frmCreateAppointment_Load(object sender, EventArgs e)
        {
            txtUserID.Text = AppointmentRepository.GetUserNameFromEmail(user);
            AddItemToBox();
            cbbBirdID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbService.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(dtpDate.Text))
                {
                    MessageBox.Show("Please enter a date.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(cbbBirdID.Text))
                {
                    MessageBox.Show("Please select a bird ID.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cbbHour.Text))
                {
                    MessageBox.Show("Please select a bird ID.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cbbMinute.Text))
                {
                    MessageBox.Show("Please select a bird ID.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(cbbService.Text))
                {
                    MessageBox.Show("Please select a service.");
                    return;
                }

                DateTime selectedDate = dtpDate.Value.Date;
                DateTime currentDate = DateTime.Now.Date;
                if (selectedDate < currentDate)
                {
                    MessageBox.Show("Please select a date greater than the current day.");
                    return;
                }
                // Validate time
                TimeSpan selectedTime = TimeSpan.Parse(cbbHour.SelectedItem.ToString() + ":" + cbbMinute.SelectedItem.ToString());
                var appointment = new TblAppointment
                {
                    UserId = AppointmentRepository.GetUserIDByEmail(user),
                    BirdId = Int32.Parse(cbbBirdID.SelectedItem.ToString()),
                    AppointmentDate = selectedDate,
                    AppointmentTime =selectedTime,
                    Status = 0,
                    ServiceId = AppointmentRepository.GetServiceIDByName(cbbService.Text)
                };

                AppointmentRepository.insertAppointment(appointment);

                DialogResult result = MessageBox.Show("Appointment created successfully.", "Appointment", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while creating the appointment.");
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
