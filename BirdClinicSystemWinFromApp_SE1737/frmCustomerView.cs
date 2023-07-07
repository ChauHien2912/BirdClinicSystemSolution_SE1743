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
    public partial class frmCustomerView : Form
    {
        public frmCustomerView()
        {
            InitializeComponent();
        }

        IUserRepository listuser = new UserRepository();

        public void getUser()
        {
            List<TblUser> tblUsers = (List<TblUser>)listuser.getUser(true);
            dGVListUser.DataSource = tblUsers;

            dGVListUser.Columns["Password"].Visible = false;
            dGVListUser.Columns["Role"].Visible = false;
            dGVListUser.Columns["TblAppointmentDoctors"].Visible = false;
            dGVListUser.Columns["TblAppointmentStaffs"].Visible = false;
            dGVListUser.Columns["TblAppointmentUsers"].Visible = false;
            dGVListUser.Columns["TblBlogs"].Visible = false;
            dGVListUser.Columns["TblMedicalRecordDoctors"].Visible = false;
            dGVListUser.Columns["TblMedicalRecordUsers"].Visible = false;
        }

        private void frmCustomerView_Load(object sender, EventArgs e)
        {
            getUser();
        }
    }
}
