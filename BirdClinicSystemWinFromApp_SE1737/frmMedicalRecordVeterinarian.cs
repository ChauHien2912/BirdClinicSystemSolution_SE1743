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
    public partial class frmMedicalRecordVeterinarian : Form
    {
        IUserRepository userRepository = new UserRepository();
        private int AppointmentId { get; set; }

        TblAppointment Appointment { get; set; }
        public frmMedicalRecordVeterinarian(int id)
        {
            InitializeComponent();
            this.AppointmentId = id;
            Load();
        }
        public void Load()
        {
            Appointment = userRepository.GetAppointmentById(AppointmentId);
            txtCustomerName.Text = Appointment.User.FullName;
            txtBird.Text = Appointment.Bird.Species;
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBoxQuestion("Do you want to save?"))
            {
                userRepository.AddMedicalRecord((int)Appointment.UserId, (int)Appointment.BirdId, (int)Appointment.DoctorId, DateTime.Now, txtDiagnosis.Text, txtIntruction.Text);
                userRepository.CompleteAppointment(AppointmentId);
                this.Close();
            }
        }
    }
}
