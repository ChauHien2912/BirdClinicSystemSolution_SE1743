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
            var bird = AppointmentRepository.GetBirdType().ToList();
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
                if (string.IsNullOrWhiteSpace(mskDate.Text))
                {
                    MessageBox.Show("Please enter a date.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(mskTime.Text))
                {
                    MessageBox.Show("Please enter a time.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(cbbBirdID.Text))
                {
                    MessageBox.Show("Please select a bird ID.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(cbbService.Text))
                {
                    MessageBox.Show("Please select a service.");
                    return;
                }

                DateTime appointmentDate;

                if (DateTime.TryParseExact(mskDate.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out appointmentDate))
                {
                    string unmaskedTime = mskTime.Text.Replace(":", ""); // Remove any colons from the masked time

                    TimeSpan appointmentTime;

                    if (TimeSpan.TryParseExact(unmaskedTime, "hhmm", null, System.Globalization.TimeSpanStyles.None, out appointmentTime))
                    {
                        var appointment = new TblAppointment
                        {
                            UserId = AppointmentRepository.GetUserIDByEmail(user),
                            BirdId = AppointmentRepository.GetBirdIDByType(cbbBirdID.Text),
                            AppointmentDate = appointmentDate,
                            AppointmentTime = appointmentTime,
                            Status = 0,
                            ServiceId = AppointmentRepository.GetServiceIDByName(cbbService.Text)
                        };

                        AppointmentRepository.insertAppointment(appointment);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid time format. Please enter a valid time in 24-hour format (e.g., HH:mm).");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid date format. Please enter a valid date in dd/mm/yyyy format.");
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
            DialogResult d;
            d = MessageBox.Show("Create Completed", "Appointment",
                MessageBoxButtons.OK);
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
