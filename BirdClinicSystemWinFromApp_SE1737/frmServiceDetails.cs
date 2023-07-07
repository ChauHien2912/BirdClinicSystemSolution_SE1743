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
    public partial class frmServiceDetails : Form
    {
        public frmServiceDetails(TblService Service)
        {
            InitializeComponent();
            this.Service = Service;
            btnAction.Text = "Update";
            LoadService();
            btnAction.Click += btnUpdate_Click;
        }

        private void BtnAction_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public frmServiceDetails()
        {
            InitializeComponent();
            btnAction.Text = "Create";
            txtServiceID.Visible = false;
            label2.Visible = false;
            btnAction.Click += btnCreate_Click;

        }

        IServiceRepository repo = new ServiceRepository();

        public TblService Service { get; set; }


        private void LoadService()
        {
            txtServiceID.Text = Service.ServiceId.ToString();
            txtServiceID.Enabled = false;
            txtServiceName.Text = Service.ServiceName;
            txtStatus.Text = Service.Status.ToString();
            txtDes.Text = Service.Description;
            txtPrice.Text = Service.Price.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text.Length == 0 || txtDes.Text.Length == 0)
            {
                MessageBox.Show("Invalid input", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                bool OK = MessageBoxQuestion("Do you want to update the Service");
                if (OK == true)
                {

                    repo.UpdateService(Convert.ToInt32(txtServiceID.Text), txtServiceName.Text, Convert.ToInt32(txtStatus.Text), txtDes.Text, Convert.ToDouble(txtPrice.Text));
                    this.Close();
                }
            }
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text.Length == 0 || txtDes.Text.Length == 0)
            {
                MessageBox.Show("Invalid input", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {

                repo.createService(txtServiceName.Text, Convert.ToInt32(txtStatus.Text), txtDes.Text, Convert.ToDouble(txtPrice.Text));
                this.Close();
            }
        }
    }
}
