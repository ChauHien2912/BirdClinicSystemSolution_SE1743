using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BirdClinicSystemWinFromApp_SE1737
{
    public partial class frmBird : Form
    {
        IBridRepository birdRepository = new BirdRepository();
        IAppointmentRepository appointmentRepository = new AppointmentRepository();
        string email = Properties.Settings.Default.MyAccount;
        BindingSource source;
        public frmBird()
        {
            InitializeComponent();
        }

        private void frmBird_Load(object sender, EventArgs e)
        {
            AddIdToCBB();
            cbbBridID.DropDownStyle = ComboBoxStyle.DropDownList;
            btnUpdate.Enabled = false;
        }

        private void AddIdToCBB()
        {
            List<int> list = birdRepository.GetBirdID(appointmentRepository.GetUserIDByEmail(email)).ToList();

            foreach (int id in list)
            {
                cbbBridID.Items.Add(id);
            }
        }

        private void BindData(List<TblBird> list)
        {
            source = new BindingSource();
            source.DataSource = list;

            txtAge.DataBindings.Clear();
            txtDesc.DataBindings.Clear();
            txtGender.DataBindings.Clear();
            txtName.DataBindings.Clear();
            cbbSpecie.DataBindings.Clear();
            txtWeight.DataBindings.Clear();

            txtAge.DataBindings.Add("Text", source, "Age");
            txtDesc.DataBindings.Add("Text", source, "Description");
            txtGender.DataBindings.Add("Text", source, "Gender");
            txtName.DataBindings.Add("Text", source, "Name");
            cbbSpecie.DataBindings.Add("Text", source, "Species");
            txtWeight.DataBindings.Add("Text", source, "Weight");

            if (txtGender.Text == "True")
            {
                txtGender.Text = "Male";
            }
            else
                txtGender.Text = "Female";
        }

        private void cbbBridID_SelectedValueChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            var id = Int32.Parse(cbbBridID.SelectedItem.ToString());
            var value = birdRepository.GetBirdInfor(id);
            BindData(value);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateBird frmCreateBird = new frmCreateBird
            {

                ID = appointmentRepository.GetUserIDByEmail(email)
            };
            if (frmCreateBird.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Create Completed", "Notification");
                cbbBridID.Items.Clear();
                AddIdToCBB();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                ($"Are you sure you want to delete bird with ID:" +
                $"{cbbBridID.SelectedItem.ToString()} ?", "Notification", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                birdRepository.DeleteBird(Int32.Parse(cbbBridID.SelectedItem.ToString()));
                MessageBox.Show("Delete completed", "Notificaiton");
            }
            cbbBridID.Items.Clear();
            AddIdToCBB();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var bird = new TblBird
                {
                    Age = Int32.Parse(txtAge.Text),
                    Gender = txtGender.ToString() == "Male" ? true : false,
                    Name = txtName.Text.ToString(),
                    Species = cbbSpecie.SelectedItem.ToString(),
                    Description = txtDesc.Text.ToString(),
                    Weight = float.Parse(txtWeight.Text),
                };
                birdRepository.UpdateBird(bird);
                MessageBox.Show("Update Completed", "Notification");
            }

        }
        private bool ValidateInput()
        {
            // Validate txtName
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is required.");
                return false;
            }
            string specie = cbbSpecie.SelectedItem.ToString()
                .Trim();
            if (string.IsNullOrEmpty(specie))
            {
                MessageBox.Show("Specie is required.");
                return false;
            }
            string gender = txtGender.Text.Trim();
            if (string.IsNullOrEmpty(specie))
            {
                MessageBox.Show("Gender is required.");
                return false;
            }
            if (ContainsNumbersOrSpecialCharacters(name))
            {
                MessageBox.Show("Name should not contain numbers or special characters.");
                return false;
            }

            // Validate txtAge
            if (!int.TryParse(txtAge.Text, out int age) || age < 0)
            {
                MessageBox.Show("Age must be a valid positive integer.");
                return false;
            }

            // Validate txtWeight
            if (!float.TryParse(txtWeight.Text, out float weight) || weight < 0)
            {
                MessageBox.Show("Weight must be a valid positive floating-point number.");
                return false;
            }
            // All validations passed
            return true;
        }

        private bool ContainsNumbersOrSpecialCharacters(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c) || char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
