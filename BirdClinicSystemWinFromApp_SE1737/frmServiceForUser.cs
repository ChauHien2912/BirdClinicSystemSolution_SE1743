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
    public partial class frmServiceForUser : Form
    {
        IServiceRepository ServiceRepository = new ServiceRepository();
        BindingSource source;
        public frmServiceForUser()
        {
            InitializeComponent();
        }

        private void BindData(List<TblService> list)
        {
            source = new BindingSource();
            source.DataSource = list;

            txtServiceID.DataBindings.Clear();
            txtServiceName.DataBindings.Clear();
            txtDescription.DataBindings.Clear();
            txtStatus.DataBindings.Clear();
            txtPrice.DataBindings.Clear();

            txtServiceID.DataBindings.Add("Text", source, "ServiceID");
            txtServiceName.DataBindings.Add("Text", source, "ServiceName");
            txtPrice.DataBindings.Add("Text", source, "Price");
            txtDescription.DataBindings.Add("Text", source, "Description");
            txtStatus.DataBindings.Add("Text", source, "Status");

            txtServiceID.ReadOnly = true;
            txtServiceName.ReadOnly = true;
            txtDescription.ReadOnly = true;
            txtStatus.ReadOnly = true;
            txtPrice.ReadOnly = true;

        }

        private void addServiceNameToBox()
        {
            var serviceName = ServiceRepository.GetAllServices().Select(x => x.ServiceName).ToList();
            foreach (var service in serviceName)
            {
                cbbService.Items.Add(service);
            }
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            addServiceNameToBox();
            cbbService.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cbbService_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedName = cbbService.SelectedItem.ToString();
            var service = ServiceRepository.GetAllServices().Where(s => s.ServiceName == selectedName).ToList();
            BindData(service);
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            if (txtStatus.Text.Equals("1"))
            {
                txtStatus.Text = "Working";
            }
            else if (txtStatus.Text.Equals("2"))
            { txtStatus.Text = "Out of order"; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
