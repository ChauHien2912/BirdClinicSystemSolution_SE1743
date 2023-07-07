using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class MedicalRecordDAO
    {

        private static MedicalRecordDAO instance = null;
        private static readonly object instanceLock = new object();
        public static MedicalRecordDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MedicalRecordDAO();
                    }
                    return instance;
                }
            }
        }
        public List<TblMedicalRecord> GetUserMedicalRecords(string email)
        {
            List<TblMedicalRecord> list = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    list = (from u in context.TblUsers
                            join mr in context.TblMedicalRecords on u.UserId equals mr.UserId
                            where u.Email == email
                            select mr)
                                         .ToList();

                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
            return list;
        }

        public string GetUserNameFromEmail(String username)
        {
            string list = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    list = (from mr in context.TblMedicalRecords
                            join u in context.TblUsers on mr.UserId equals u.UserId
                            where u.Email.Equals(username)
                            select u.FullName)
                                         .Distinct()
                                         .FirstOrDefault()?
                                         .ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            return list;
        }

        

        public string GetDoctorNameFromEmail(String username)
            {
                string list = null;
                try
                {
                    using (var context = new BirdClinicDBContext())
                    {


                    }
                }
                catch (Exception ex)
                {
                    throw new Exception();
                }
                return list;
            }
        }
    }


