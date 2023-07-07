using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AppointmentStaffRepository : IAppointmentStaffRepository
    {
        public void Accept(int id, int Status, int? staffid=null, int? doctorid = null)
            => AppointmentStaffDAO.Accept(id, Status,staffid,doctorid);

        public void Cancel(int id, int Status)
            => AppointmentStaffDAO.Cancel(id, Status);

        public TblAppointment GetTblAppointmentByID(int id)
            => AppointmentStaffDAO.GetTblAppointmentByID(id);

        public List<TblAppointment> GetTblAppointments()
            => AppointmentStaffDAO.GetTblAppointments();

    }
}
