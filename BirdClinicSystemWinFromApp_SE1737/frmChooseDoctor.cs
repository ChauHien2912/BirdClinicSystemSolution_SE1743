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
    public partial class frmChooseDoctor : Form
    {
        public int ChosenDoctorID { get; private set; }
        IAppointmentRepository appointmentRepository = new AppointmentRepository();
        public frmChooseDoctor()
        {
            InitializeComponent();
        }

        private void frmChooseDoctor_Load(object sender, EventArgs e)
        {
            cbbDoctorID.DropDownStyle = ComboBoxStyle.DropDownList;
            var list = appointmentRepository.GetDoctorID().ToList();
            foreach (var item in list)
            {
                cbbDoctorID.Items.Add(item);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ChosenDoctorID = Int32.Parse(cbbDoctorID.SelectedItem.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
