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
    public partial class frmCreateBird : Form
    {
        IBridRepository birdRepository = new BirdRepository();
        public int ID { get; set; }

        public frmCreateBird()
        {
            InitializeComponent();
            cbbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSpecie.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close?", "Notification", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var bird = new TblBird
                {
                    Age = Int32.Parse(txtAge.Text),
                    Gender = cbbGender.SelectedItem.ToString() == "Male" ? true : false,
                    Name = txtName.Text.ToString(),
                    Species = cbbSpecie.SelectedItem.ToString(),
                    Description = txtDes.Text.ToString(),
                    Weight = float.Parse(txtWeight.Text),
                    UserId = ID
                };
                birdRepository.AddBird(bird);
                Close();
                DialogResult = DialogResult.OK;
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
            if (cbbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbbSpecie.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a species.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
