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
using System.Xml.Linq;

namespace BirdClinicSystemWinFromApp_SE1737
{
    public partial class frmService : Form
    {
        public frmService()
        {
            InitializeComponent();
            loadService();
            txtServiceID.Enabled = false;
        }
        IServiceRepository repo = new ServiceRepository();
        private void loadService()
        {
            dGVService.DataSource = null;
            try
            {
                var service = repo.GetAllServices();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = service;

                txtServiceID.DataBindings.Clear();
                txtServiceName.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtDes.DataBindings.Clear();
                txtPrice.DataBindings.Clear();


                txtServiceID.DataBindings.Add("Text", bindingSource, "ServiceID");
                txtServiceName.DataBindings.Add("Text", bindingSource, "ServiceName");
                txtPrice.DataBindings.Add("Text", bindingSource, "Price");
                txtDes.DataBindings.Add("Text", bindingSource, "Description");
                txtStatus.DataBindings.Add("Text", bindingSource, "Status");


                dGVService.DataSource = bindingSource;
                dGVService.Columns["ServiceID"].Visible = true;
                dGVService.Columns["ServiceName"].Visible = true;
                dGVService.Columns["Status"].Visible = true;
                dGVService.Columns["Description"].Visible = true;
                dGVService.Columns["Price"].Visible = true;
                dGVService.Columns["TblAppointments"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Service");
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmServiceDetails frmServiceDetails = new frmServiceDetails();
            frmServiceDetails.ShowDialog();
            loadService();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtServiceID.Text);
            TblService service = repo.getServiceByID(id);
            frmServiceDetails serviceDetails = new frmServiceDetails(service);
            serviceDetails.ShowDialog();
            loadService();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool OK = MessageBoxQuestion("Do you want to delete the Service");
            repo.deleteService(Convert.ToInt32(txtServiceID.Text));
            loadService();
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
    }
}
