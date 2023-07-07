using Repositories;
using System;
using System.Windows.Forms;

namespace BirdClinicSystemWinFromApp_SE1737
{
    public partial class frmRevevue : Form
    {
        public frmRevevue()
        {
            InitializeComponent();
            LoadRevevue();
        }

        IServiceRepository repo = new ServiceRepository();

        public void BindingService(dynamic Service)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Service;

            txtServiceID.DataBindings.Clear();
            txtServiceName.DataBindings.Clear();
            dtPDate.DataBindings.Clear();
            dtpTime.DataBindings.Clear();
            txtStaffID.DataBindings.Clear();
            txtDoctorID.DataBindings.Clear();
            txtStatus.DataBindings.Clear();
            txtFullName.DataBindings.Clear();
            txtDes.DataBindings.Clear();
            txtPrice.DataBindings.Clear();

            if (Service.Count > 0)
            {
                txtServiceID.DataBindings.Add("Text", bindingSource, "ServiceID");
                txtServiceName.DataBindings.Add("Text", bindingSource, "ServiceName");
                dtPDate.DataBindings.Add("Text", bindingSource, "AppointmentDate");
                dtpTime.DataBindings.Add("Text", bindingSource, "AppointmentTime");
                txtStaffID.DataBindings.Add("Text", bindingSource, "StaffID");
                txtDoctorID.DataBindings.Add("Text", bindingSource, "DoctorID");
                txtStatus.DataBindings.Add("Text", bindingSource, "Status");
                txtDes.DataBindings.Add("Text", bindingSource, "Description");
                txtPrice.DataBindings.Add("Text", bindingSource, "Price");
                //txtFullName.DataBindings.Add("Text", bindingSource, "FullName");
                //txtDoctor.DataBindings.Add("Text", bindingSource, "FullName");
            }
            else
            {
                txtServiceID.Text = "";
                txtServiceName.Text = "";
                txtStaffID.Text = "";
                txtDoctorID.Text = "";
                txtStatus.Text = "";
                txtDes.Text = "";
                txtPrice.Text = "";
                txtFullName.Text = "";
                txtDoctor.Text = "";
            }

            dGVRevevueList.DataSource = null;
            dGVRevevueList.DataSource = bindingSource;

            float total = 0;
            foreach (var service in Service)
            {
                decimal decimalValue = (decimal)service.GetType().GetProperty("Price")?.GetValue(service);
                total += Convert.ToSingle(decimalValue);
                ;
            }
            lblTotal.Text = "Total: " + total.ToString() + ".0000₫";
        }
        public void LoadRevevue()
        {
            var revevue = repo.getRevevue();
            BindingService(revevue);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var service = repo.searchRevevue(Convert.ToDateTime(dtpfromDate.Text), Convert.ToDateTime(dtpToDate.Text));
            BindingService(service);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadRevevue();
        }
    }
}
