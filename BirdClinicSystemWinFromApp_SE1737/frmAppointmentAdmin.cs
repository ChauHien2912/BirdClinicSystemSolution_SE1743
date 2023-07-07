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
using BusinessObjects;

namespace BirdClinicSystemWinFromApp_SE1737
{
    public partial class frmAppointmentAdmin : Form
    {
        public frmAppointmentAdmin()
        {
            InitializeComponent();
            getListAppointment();
            txtAppointmentID.Enabled = false;
        }

        IAppointmentRepository getAppointment = new AppointmentRepository();



        private void getListAppointment()
        {
            dGVListAppointment.DataSource = null;
            try
            {
                var Appointment = getAppointment.getAllAppointment();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = Appointment;

                txtAppointmentID.DataBindings.Clear();
                txtUserID.DataBindings.Clear();
                txtBirdID.DataBindings.Clear();
                txtStaffID.DataBindings.Clear();
                txtDoctorID.DataBindings.Clear();
                dtpAppointmentDate.DataBindings.Clear();
                dtpAppointmentTime.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtServiceID.DataBindings.Clear();

                txtAppointmentID.DataBindings.Add("Text", bindingSource, "AppointmentID");
                txtUserID.DataBindings.Add("Text", bindingSource, "UserID");
                txtBirdID.DataBindings.Add("Text", bindingSource, "BirdID");
                txtStaffID.DataBindings.Add("Text", bindingSource, "StaffID");
                txtDoctorID.DataBindings.Add("Text", bindingSource, "DoctorID");
                dtpAppointmentDate.DataBindings.Add("Text", bindingSource, "AppointmentDate");
                dtpAppointmentTime.DataBindings.Add("Text", bindingSource, "AppointmentTime");
                txtStatus.DataBindings.Add("Text", bindingSource, "Status");
                txtServiceID.DataBindings.Add("Text", bindingSource, "ServiceID");



                dGVListAppointment.DataSource = bindingSource;
                dGVListAppointment.Columns["AppointmentID"].Visible = true;
                dGVListAppointment.Columns["UserID"].Visible = true;
                dGVListAppointment.Columns["BirdID"].Visible = true;
                dGVListAppointment.Columns["StaffID"].Visible = true;
                dGVListAppointment.Columns["DoctorID"].Visible = true;
                dGVListAppointment.Columns["AppointmentDate"].Visible = true;
                dGVListAppointment.Columns["AppointmentTime"].Visible = true;
                dGVListAppointment.Columns["Status"].Visible = true;
                dGVListAppointment.Columns["ServiceID"].Visible = true;
                dGVListAppointment.Columns["Bird"].Visible = false;
                dGVListAppointment.Columns["Doctor"].Visible = false;
                dGVListAppointment.Columns["Service"].Visible = false;
                dGVListAppointment.Columns["Staff"].Visible = false;
                dGVListAppointment.Columns["User"].Visible = false;
                dGVListAppointment.Columns["TblFeedbacks"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Appointment");
            }

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCustomerView viewCustomer = new frmCustomerView();
            this.Hide();
            viewCustomer.ShowDialog();
            this.Show();

        }

        private void revevueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRevevue frmRevevue = new frmRevevue();
            this.Hide();
            frmRevevue.ShowDialog();
            this.Show();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmService service = new frmService();
            this.Hide();
            service.ShowDialog();
            this.Show();
        }

        private void veritarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVeterian veterian = new frmVeterian();
            this.Hide();
            veterian.ShowDialog();
            this.Show();
        }


    }
}
