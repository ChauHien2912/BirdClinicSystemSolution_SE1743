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
    public partial class frmHome : Form
    {
        IUserRepository userRepository = new UserRepository();
        BindingSource source;
        String user = Properties.Settings.Default.MyAccount;

        private Dictionary<string, Form> openForms;

        public frmHome()
        {
            InitializeComponent();
            openForms = new Dictionary<string, Form>();
        }

        private void OpenForm(Form formInstance)
        {
            string formName = formInstance.GetType().Name;

            if (openForms.ContainsKey(formName))
            {
                Form existingForm = openForms[formName];

                if (existingForm.WindowState == FormWindowState.Minimized)
                    existingForm.WindowState = FormWindowState.Normal;

                existingForm.Focus();
            }
            else
            {
                openForms.Add(formName, formInstance);
                formInstance.FormClosed += (sender, args) => openForms.Remove(formName);
                formInstance.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmServiceForUser frmService = new frmServiceForUser();
            OpenForm(frmService);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMedicalRecord frmMedicalRecord = new frmMedicalRecord();
            OpenForm(frmMedicalRecord);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAppointment frmAppointment = new frmAppointment();
            OpenForm(frmAppointment);
        }

        private void BindData(List<TblUser> list)
        {
            source = new BindingSource();
            source.DataSource = list;
            txtAddress.DataBindings.Clear();
            txtFullname.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtGender.DataBindings.Clear();

            txtAddress.DataBindings.Add("Text", source, "Address");
            txtFullname.DataBindings.Add("Text", source, "Fullname");
            txtPhone.DataBindings.Add("Text", source, "Phone");
            txtGender.DataBindings.Add("Text", source, "Gender");

            if (txtGender.Text == "True")
            {
                txtGender.Text = "Male";
            }
            else
            {
                txtGender.Text = "Female";
            }

            txtAddress.ReadOnly = true;
            txtFullname.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtGender.ReadOnly = true;
        }

        private void GetUser()
        {
            var u = userRepository.GetUserByEmail(user).ToList();
            BindData(u);
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            GetUser();
        }
    }
}
