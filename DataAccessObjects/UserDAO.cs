using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;

namespace DataAccessObjects
{
    public class UserDAO
    {
        #region
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }
        #endregion
        public static void CreateUser(int roleID, String email, String password, String fullName, bool gender, String phone, String address)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {

                    TblUser tblUser = new TblUser()
                    {

                        RoleId = roleID,
                        Email = email,
                        Password = password,
                        FullName = fullName,
                        Gender = gender,
                        Phone = phone,
                        Address = address
                    };
                    context.TblUsers.Add(tblUser);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static TblUser GetTblUserById(int userID)
        {
            TblUser tblUser = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    var query = from a in context.TblUsers
                                where a.UserId == userID
                                select new
                                {
                                    a.UserId,
                                    a.RoleId,
                                    a.Email,
                                    a.Password,
                                    a.FullName,
                                    a.Gender,
                                    a.Phone,
                                    a.Address
                                };
                    foreach (var item in query)
                    {
                        tblUser = new TblUser()
                        {
                            UserId = item.UserId,
                            RoleId = item.RoleId,
                            Email = item.Email,
                            Password = item.Password,
                            FullName = item.FullName,
                            Gender = item.Gender,
                            Phone = item.Phone,
                            Address = item.Address,
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblUser;
        }

        public static void UpdateUser(int userID, int roleID, String email, String password, String fullName, bool gender, String phone, String address)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    TblUser tblUser = GetTblUserById(userID);
                    if (tblUser != null)
                    {
                        context.Attach(tblUser);
                        tblUser.UserId = userID;
                        tblUser.RoleId = roleID;
                        tblUser.Email = email;
                        tblUser.Password = password;
                        tblUser.FullName = fullName;
                        tblUser.Gender = gender;
                        tblUser.Phone = phone;
                        tblUser.Address = address;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteUser(int userID)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    TblUser tblUser = GetTblUserById(userID);
                    var exist = context.TblUsers.SingleOrDefault(o => o.UserId == tblUser.UserId);
                    context.TblUsers.Remove(exist);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<TblUser> getAllCus(bool isTrue)
        {
            List<TblUser> listUser = new List<TblUser>();
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    if (isTrue)
                    {
                        listUser = context.TblUsers.Where(r => r.RoleId == 3).ToList();
                    }
                    else
                    {
                        listUser = context.TblUsers.Where(r => r.RoleId == 4).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listUser;
        }

        public TblUser CheckLogin(string email, string password)
        {
            TblUser user = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    user = context.TblUsers.FirstOrDefault(u => u.Email == email && u.Password == password);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }
        private bool checkDuplicate(string email)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    var exist = context.TblUsers.FirstOrDefault(u => u.Email.Equals(email));
                    if (exist != null)
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }
        public bool Register(string fullName, string email, string password, string address, string phoneNumber, bool gender)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    if (checkDuplicate(email))
                    {
                        TblUser user = new TblUser()
                        {
                            FullName = fullName,
                            Email = email,
                            Password = password,
                            Address = address,
                            Phone = phoneNumber,
                            Gender = gender,
                            RoleId = 3
                        };
                        context.TblUsers.Add(user);
                        context.SaveChanges();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }
        public TblUser GetUserById(int id)
        {
            TblUser user = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    user = context.TblUsers.FirstOrDefault(u => u.UserId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }

        public List<TblUser> GetUserByEmail(string email)
        {
            List<TblUser> user = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    user = context.TblUsers
                        .Where(u => u.Email == email)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }

        public void UpdateProfile(int id, string fullName, string emal, bool gender, string phoneNumber, string address)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    TblUser user = context.TblUsers.FirstOrDefault(u => u.UserId == id);
                    if (user != null)
                    {
                        user.FullName = fullName;
                        user.Gender = gender;
                        user.Address = address;
                        user.Email = emal;
                        user.Phone = phoneNumber;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void ChangePassword(int id, string password)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    TblUser user = context.TblUsers.FirstOrDefault(u => u.UserId == id);
                    if (user != null)
                    {
                        user.Password = password;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<object> GetAppointmentsByVeterianarianId(int userId)
        {
            List<object> list = new List<object>();
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    var query = from a in context.TblAppointments
                                join u in context.TblUsers on a.UserId equals u.UserId
                                join b in context.TblBirds on a.BirdId equals b.BirdId
                                join s in context.TblServices on a.ServiceId equals s.ServiceId
                                where a.DoctorId == userId && a.Status == 1
                                select new
                                {
                                    a.AppointmentId,
                                    u.FullName,
                                    b.Species,
                                    a.AppointmentDate,
                                    a.AppointmentTime,
                                    s.ServiceName,
                                    s.Price
                                };
                    foreach (var item in query)
                    {
                        list.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public void CompleteAppointment(int appointmentID)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    TblAppointment appointment = context.TblAppointments.FirstOrDefault(a => a.AppointmentId == appointmentID);
                    if (appointment != null)
                    {
                        appointment.Status = 3;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public TblAppointment GetAppointmentById(int id)
        {
            TblAppointment appointment = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    appointment = context.TblAppointments.Include(f => f.User).Include(f => f.Bird).FirstOrDefault(a => a.AppointmentId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return appointment;
        }
        public void AddMedicalRecord(int userId, int birdId, int docId, DateTime date, string diagnosis, string intruction)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    TblMedicalRecord medicalRecord = new TblMedicalRecord()
                    {
                        UserId = userId,
                        BirdId = birdId,
                        DoctorId = docId,
                        Date = date,
                        Diagnosis = diagnosis,
                        Intruction = intruction
                    };
                    context.TblMedicalRecords.Add(medicalRecord);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dictionary<int, string> GetUserNameByID()
        {
            Dictionary<int, string> ListUsername = new Dictionary<int, string>();
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    var users = context.TblUsers.ToList(); // Retrieve all users from the database

                    foreach (var user in users)
                    {
                        ListUsername.Add(user.UserId, user.FullName);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ListUsername;
        }

    }

}
