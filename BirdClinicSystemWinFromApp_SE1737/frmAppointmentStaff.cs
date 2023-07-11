
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
    public partial class frmAppointmentStaff : Form
    {

        IAppointmentStaffRepository repository = new AppointmentStaffRepository();
        IAppointmentRepository appointmentRepository = new AppointmentRepository();
        string staffID = Properties.Settings.Default.MyStaff;
        public frmAppointmentStaff()
        {
            InitializeComponent();
        }

        private void GettblAppointment()
        {
            try
            {
                var listTblAppointment = repository.GetTblAppointments();
                BindingSource source = new BindingSource();
                source.DataSource = listTblAppointment;

                txtAppointmentID.DataBindings.Clear();
                txtBirdID.DataBindings.Clear();
                txtDoctorID.DataBindings.Clear();
                txtServiceID.DataBindings.Clear();
                txtStaffID.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtUserID.DataBindings.Clear();
                dtpAppointmentDate.DataBindings.Clear();
                txtAppointmentTime.DataBindings.Clear();

                txtAppointmentID.DataBindings.Add("Text", source, "AppointmentID");
                txtBirdID.DataBindings.Add("Text", source, "BirdID");
                txtDoctorID.DataBindings.Add("Text", source, "DoctorID");
                txtServiceID.DataBindings.Add("Text", source, "ServiceID");
                txtStaffID.DataBindings.Add("Text", source, "StaffID");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtUserID.DataBindings.Add("Text", source, "UserID");
                dtpAppointmentDate.DataBindings.Add("Text", source, "AppointmentDate");
                txtAppointmentTime.DataBindings.Add("Text", source, "AppointmentTime");

                dgvAppoinmentStaff.DataSource = null;
                dgvAppoinmentStaff.DataSource = source;
                dgvAppoinmentStaff.Columns["Bird"].Visible = false;
                dgvAppoinmentStaff.Columns["Doctor"].Visible = false;
                dgvAppoinmentStaff.Columns["Service"].Visible = false;
                dgvAppoinmentStaff.Columns["Staff"].Visible = false;
                dgvAppoinmentStaff.Columns["User"].Visible = false;
                dgvAppoinmentStaff.Columns["TblFeedbacks"].Visible = false;

                txtAppointmentID.ReadOnly = true;
                txtBirdID.ReadOnly = true;

                txtServiceID.ReadOnly = true;

                txtStatus.ReadOnly = true;
                txtUserID.ReadOnly = true;

                txtAppointmentTime.ReadOnly = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            GettblAppointment();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
            if (txtDoctorID.Text.Equals(""))
            {
                frmChooseDoctor frmChooseDoctor = new frmChooseDoctor();
                if (frmChooseDoctor.ShowDialog() == DialogResult.OK)
                {
                    
                    int chosenDoctorID = frmChooseDoctor.ChosenDoctorID;
                    repository.Accept(Convert.ToInt32(txtAppointmentID.Text), Convert.ToInt32(txtStatus.Text = "1")
                        , appointmentRepository.GetUserIDByEmail(staffID),chosenDoctorID);
                }
            }                        
            GettblAppointment();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            repository.Accept(Convert.ToInt32(txtAppointmentID.Text), Convert.ToInt32(txtStatus.Text = "2"));
            GettblAppointment();
        }


    }
}
