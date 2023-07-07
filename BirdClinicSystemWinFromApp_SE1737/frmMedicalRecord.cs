using BusinessObjects;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmMedicalRecord : Form
    {
        private String User = Properties.Settings.Default.MyAccount;
        IMedicalRecordRepository MedicalRecordRepository = new MedicalRecordRepository();
        IAppointmentRepository AppointmentRepository = new AppointmentRepository();
        BindingSource source;
        public frmMedicalRecord()
        {
            InitializeComponent();
        }
        private void BindData(List<TblMedicalRecord> list)
        {
            source = new BindingSource();
            source.DataSource = list;

            txtBirdID.DataBindings.Clear();
            txtDate.DataBindings.Clear();
            txtMedicalID.DataBindings.Clear();
            txtDiagnosis.DataBindings.Clear();
            txtDoctorID.DataBindings.Clear();
            txtInstruction.DataBindings.Clear();



            txtBirdID.DataBindings.Add("Text", source, "BirdID");
            txtDate.DataBindings.Add("Text", source, "Date");
            txtMedicalID.DataBindings.Add("Text", source, "MedicalID");
            txtDiagnosis.DataBindings.Add("Text", source, "Diagnosis");
            txtDoctorID.DataBindings.Add("Text", source, "DoctorID");
            txtInstruction.DataBindings.Add("Text", source, "Intruction");

            txtBirdID.Text = AppointmentRepository.GetBirdTypeByID(int.Parse(txtBirdID.Text));
            int doctorID = Int32.Parse(txtDoctorID.Text);
            txtDoctorID.Text = AppointmentRepository.getDoctorAndStaff(doctorID);
        }

        private void addMedicalIDToBox()
        {
            var medical = MedicalRecordRepository
                .GetUserMedicalRecords(User)
                .Select(s => s.MedicalId)
                .ToList();

            foreach (var medicalRecord in medical)
            {
                cbbMedicalRecord.Items.Add(medicalRecord);
            }

        }

        private void frmMedicalRecord_Load(object sender, EventArgs e)
        {
            addMedicalIDToBox();
            cbbMedicalRecord.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cbbMedicalRecord_SelectedValueChanged(object sender, EventArgs e)
        {
            int value = (int)cbbMedicalRecord.SelectedItem;
            var medical = MedicalRecordRepository
                .GetUserMedicalRecords(User)
                .Where(s => s.MedicalId == value)
                .ToList();
            BindData(medical);
            addTextToTxtBox();

        }

        private void addTextToTxtBox()
        {
            txtUserID.Text = MedicalRecordRepository
                .GetUserNameFromEmail(User)
                .ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFeedBack_Click(object sender, EventArgs e)
        {
            frmFeedback frmFeedback = new frmFeedback
            {
                AppID = Int32.Parse(cbbMedicalRecord.Text)
            };
            frmFeedback.ShowDialog();
        }
    }
}
