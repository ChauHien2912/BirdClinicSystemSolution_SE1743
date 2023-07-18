using BusinessObjects;
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
    public partial class frmUpdateBird : Form
    {
        public Boolean isUpdate { get; set; }
        public frmUpdateBird()
        {
            InitializeComponent();
            if (isUpdate)
            {
                MessageBox.Show("123");
            }
            
        }     
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close?", "Notification", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
