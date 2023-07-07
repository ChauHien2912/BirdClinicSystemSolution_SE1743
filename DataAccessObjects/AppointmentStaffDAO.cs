using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class AppointmentStaffDAO
    {
        public static List<TblAppointment> GetTblAppointments()
        {
            List<TblAppointment> list = new List<TblAppointment>();
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    list = context.TblAppointments.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public static TblAppointment GetTblAppointmentByID(int id)
        {
            TblAppointment tblAppointment = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    var query = from a in context.TblAppointments
                                where a.AppointmentId == id
                                select new
                                {
                                    a.AppointmentId,
                                    a.Status
                                };
                    foreach (var item in query)
                    {
                        tblAppointment = new TblAppointment()
                        {
                            AppointmentId = item.AppointmentId,
                            Status = item.Status
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblAppointment;
        }

        public static void Accept(int id, int status,int? staffid=null,int? doctorid = null)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    TblAppointment tblAppointments = GetTblAppointmentByID(id);
                    if (tblAppointments != null)
                    {
                        context.Attach(tblAppointments);
                        tblAppointments.StaffId = staffid;
                        tblAppointments.DoctorId= doctorid;
                        tblAppointments.Status = status;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void Cancel(int id, int status)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    TblAppointment tblAppointment = GetTblAppointmentByID(id);
                    if (tblAppointment != null)
                    {
                        context.Attach(tblAppointment);
                        tblAppointment.Status = status;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
