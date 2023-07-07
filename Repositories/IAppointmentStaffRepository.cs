using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IAppointmentStaffRepository
    {
        List<TblAppointment> GetTblAppointments();
        TblAppointment GetTblAppointmentByID(int id);
        void Accept(int id, int Status,int? staffid = null,int? doctorid=null);
        void Cancel(int id, int Status);
    }
}
