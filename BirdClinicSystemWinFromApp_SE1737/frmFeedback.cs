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
    public partial class frmFeedback : Form
    {
        BindingSource source;
        IAppointmentRepository appointmentRepository = new AppointmentRepository();
        public int AppID { get; set; }
        public frmFeedback()
        {
            InitializeComponent();
        }

        private void frmFeedback_Load(object sender, EventArgs e)
        {

            BindData(appointmentRepository.GetFeedbackFromAppointmentID(AppID));
            cbbRating.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BindData(List<TblFeedback> list)
        {
            source = new BindingSource();
            source.DataSource = list;

            cbbRating.DataBindings.Clear();
            txtComment.DataBindings.Clear();

            cbbRating.DataBindings.Add("Text", source, "Rating");
            txtComment.DataBindings.Add("Text", source, "Comment");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TblFeedback tblFeedback = new TblFeedback
            {
                AppointmentId = AppID,
                Rating = cbbRating.SelectedIndex,
                Comment = txtComment.Text,
            };

            appointmentRepository.InsertFeedback(tblFeedback);
            Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want to close feedback form?", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
