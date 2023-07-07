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
    public partial class frmDeleteAppointment : Form
    {
        IAppointmentRepository AppointmentRepository = new AppointmentRepository();
        public string AppointmentID { get; set; }
        public string UserID { get; set; }
        public string BirdType { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Service { get; set; }

        public bool DeleteOrPay { get; set; }
        public frmDeleteAppointment()
        {
            InitializeComponent();
        }

        private void frmDeleteAppointment_Load(object sender, EventArgs e)
        {
            txtUserID.Text = UserID;
            txtBirdID.Text = BirdType;
            txtDate.Text = Date;
            mskTime.Text = Time;
            cbbService.Text = Service;
            if (!DeleteOrPay)
            {
                btnDelete.Text = "Pay";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeleteOrPay)
            {
                DialogResult d;
                d = MessageBox.Show("Do you really want to delete this record?", "Appointment",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    var a = new TblAppointment
                    {
                        AppointmentId = int.Parse(AppointmentID),
                    };
                    AppointmentRepository.deleteAppointment(a);
                    Close();
                }
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("Your Payment is : $ " + AppointmentRepository.GetTotal(cbbService.Text), "Payment",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    var a = new TblAppointment
                    {
                        AppointmentId = int.Parse(AppointmentID),
                    };
                    AppointmentRepository.ChangeStatus(a);
                    DialogResult d1;
                    d = MessageBox.Show("Your Payment is completed", "Payment",
                        MessageBoxButtons.OK
                        );
                    Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are You Sure You Want To Close", "Close",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
