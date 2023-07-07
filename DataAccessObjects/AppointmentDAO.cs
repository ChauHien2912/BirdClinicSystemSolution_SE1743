using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessObjects
{
    public class AppointmentDAO
    {
        private static AppointmentDAO instance = null;
        private static readonly object instanceLock = new object();
        public static AppointmentDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AppointmentDAO();
                    }
                    return instance;
                }
            }
        }
        #region  
        public List<TblAppointment> GetAllAppointmentsByEmail(string email)
        {
            List<TblAppointment> services = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    services = (from a in context.TblAppointments
                                join u in context.TblUsers on a.UserId equals u.UserId
                                where u.Email
                                .Equals(email)
                                select a)
                               .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return services;
        }

        public string GetUserNameFromEmail(string email)
        {
            string name = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    name = (
                                from a in context.TblAppointments
                                join u in context.TblUsers on a.UserId equals u.UserId
                                where u.Email.Equals(email)
                                select u.FullName
                            ).Distinct()
                            .FirstOrDefault()
                            .ToString();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return name;
        }
        #endregion

        public void InsertFeedback(TblFeedback feedback)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {

                    var existingFeedback = context.TblFeedbacks.FirstOrDefault(f => f.AppointmentId == feedback.AppointmentId);
                    if (existingFeedback != null)
                    {
                        // Update existing feedback
                        existingFeedback.Rating = feedback.Rating;
                        existingFeedback.Comment = feedback.Comment;
                    }
                    else
                    {
                        // Create new feedback
                        TblFeedback newFeedback = new TblFeedback
                        {
                            AppointmentId = feedback.AppointmentId,
                            Rating = feedback.Rating,
                            Comment = feedback.Comment
                        };

                        // Add the new feedback object to the TblFeedbacks DbSet
                        context.TblFeedbacks.Add(newFeedback);
                    }

                    // Save the changes to the database
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<TblFeedback> GetFeedbackFromAppointmentID(int id)
        {
            List<TblFeedback> list = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    list = context.TblFeedbacks
                        .Where(s => s.AppointmentId == id)
                        .ToList();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        public static List<TblAppointment> GetAllAppointment()
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
        public void insertAppointment(TblAppointment appointment)
        {
            try
            {
                using var context = new BirdClinicDBContext();
                {
                    context.TblAppointments.Add(appointment);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string GetService(int ServiceID)
        {
            string name = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {

                    name = context.TblServices
                        .Where(s => s.ServiceId == ServiceID)
                        .Select(s => s.ServiceName)
                        .FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return name;
        }

        public string getDoctorAndStaff(int ID)
        {
            string name = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {

                    name = context.TblUsers
                        .Where(s => s.UserId == ID)
                        .Select(s => s.FullName)
                        .FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return name;
        }

        public List<string> GetBirdType()
        {
            List<string> name = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {

                    name = context.TblBirds
                        .Select(s => s.Species)
                        .ToList();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return name;
        }

        public List<string> GetServices()
        {
            List<string> list = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {

                    list = context.TblServices
                        .Select(s => s.ServiceName)
                        .ToList();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return list;
        }

        public int GetUserIDByEmail(string email)
        {
            int name;
            try
            {
                using (var context = new BirdClinicDBContext())
                {

                    name = context.TblUsers
                        .Where(s => s.Email == email)
                        .Select(s => s.UserId)
                        .FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return name;
        }

        public int GetBirdIDByType(String type)
        {
            int name;
            try
            {
                using (var context = new BirdClinicDBContext())
                {

                    name = context.TblBirds
                        .Where(s => s.Species.Equals(type))
                        .Select(s => s.BirdId)
                        .FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return name;
        }

        public int GetServiceIDByName(String serviceName)
        {
            int name;
            try
            {
                using (var context = new BirdClinicDBContext())
                {

                    name = context.TblServices
                        .Where(s => s.ServiceName.Equals(serviceName))
                        .Select(s => s.ServiceId)
                        .FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return name;
        }

        public string GetBirdTypeByID(int id)
        {
            string name;
            try
            {
                using (var context = new BirdClinicDBContext())
                {

                    name = context.TblBirds
                        .Where(s => s.BirdId == id)
                        .Select(s => s.Species)
                        .FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return name;
        }

        public void deleteAppointment(TblAppointment appointment)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    var a1 = context.TblAppointments.FirstOrDefault(m => m.AppointmentId == appointment.AppointmentId);
                    context.TblAppointments.Remove(a1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ChangeStatus(TblAppointment appointment)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    var a1 = context.TblAppointments.FirstOrDefault(m => m.AppointmentId == appointment.AppointmentId);
                    a1.Status = 3;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double GetTotal(string id)
        {
            double total;
            try
            {
                using (var context = new BirdClinicDBContext())
                {

                    total = (double)context.TblServices
                        .Where(s => s.ServiceName.Equals(id))
                        .Select(s => s.Price)
                        .FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return total;
        }
    }

}
