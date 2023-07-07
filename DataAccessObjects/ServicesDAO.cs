using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class ServicesDAO
    {
        private static ServicesDAO  instance = null;
        private static readonly object instanceLock = new object();
        public static ServicesDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ServicesDAO();
                    }
                    return instance;
                }
            }
        }
        public List<TblService> GetAllServices()
        {
            List<TblService> services = null;
            try
            {
                using(var context = new BirdClinicDBContext())
                {
                    services = context.TblServices.ToList();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return services;
        }
        public static List<object> getAllRevevue()
        {
            List<object> listService = new List<object>();
            try
            {
                using (var contex = new BirdClinicDBContext())
                {
                    var query = from s in contex.TblServices
                                join a in contex.TblAppointments on s.ServiceId equals a.ServiceId
                                join u in contex.TblUsers on a.UserId equals u.UserId
                                select new
                                {
                                    s.ServiceId,
                                    s.ServiceName,
                                    u.FullName,
                                    a.AppointmentDate,
                                    a.AppointmentTime,
                                    a.StaffId,
                                    a.DoctorId,
                                    s.Status,
                                    s.Description,
                                    s.Price
                                };
                    foreach (var item in query)
                    {
                        listService.Add(item);
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listService;
        }

        public static List<object> searchRevevueByDate(DateTime fromDate, DateTime toDate)
        {
            List<object> listService = new List<object>();
            try
            {
                using (var contex = new BirdClinicDBContext())
                {
                    var query = from s in contex.TblServices
                                join a in contex.TblAppointments
                                 on s.ServiceId equals a.ServiceId
                                where a.AppointmentDate >= fromDate && a.AppointmentDate <= toDate
                                select new
                                {
                                    s.ServiceId,
                                    s.ServiceName,
                                    a.AppointmentDate,
                                    a.AppointmentTime,
                                    a.StaffId,
                                    a.DoctorId,
                                    s.Status,
                                    s.Description,
                                    s.Price
                                };
                    foreach (var item in query)
                    {
                        listService.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return listService;
        }

        public static TblService getServiceById(int serviceId)
        {
            TblService service = null;
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    var query = from s in context.TblServices
                                where s.ServiceId == serviceId
                                select new
                                {
                                    s.ServiceId,
                                    s.ServiceName,
                                    s.Status,
                                    s.Description,
                                    s.Price
                                };
                    foreach (var item in query)
                    {
                        service = new TblService()
                        {
                            ServiceId = item.ServiceId,
                            ServiceName = item.ServiceName,
                            Status = item.Status,
                            Description = item.Description,
                            Price = item.Price
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            return service;
        }

        public static void createService(string serviceName, int status, string Des, double price)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {

                    TblService service = new TblService()
                    {
                        ServiceName = serviceName,
                        Status = status,
                        Description = Des,
                        Price = price
                    };
                    context.TblServices.Add(service);
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }


        public static void updateService(int serviceid, string serviceName, int status, string Des, double price)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    TblService service = getServiceById(serviceid);
                    if (service != null)
                    {
                        context.Attach(service);
                        service.ServiceName = serviceName;
                        service.Status = status;
                        service.Description = Des;
                        service.Price = price;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void deleteService(int serviceid)
        {
            try
            {
                using (var context = new BirdClinicDBContext())
                {
                    TblService service = getServiceById(serviceid);

                    var existingService = context.TblServices.FirstOrDefault(s => s.ServiceId == serviceid);
                    if (existingService != null)
                    {
                        context.TblServices.Remove(existingService);
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
