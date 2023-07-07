using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {

        public List<TblFeedback> GetFeedbackFromAppointmentID(int ID)
        {
            return AppointmentDAO.Instance.GetFeedbackFromAppointmentID(ID);
        }
        public void deleteAppointment(TblAppointment appointment)
        {
            AppointmentDAO.Instance.deleteAppointment(appointment);
        }

        public List<TblAppointment> GetAllAppointmentsByEmail(string email)
        {
            return AppointmentDAO.Instance.GetAllAppointmentsByEmail(email);
        }

        public int GetBirdIDByType(string type)
        {
            return AppointmentDAO.Instance.GetBirdIDByType(type);
        }

        public List<string> GetBirdType()
        {
            return AppointmentDAO.Instance.GetBirdType();
        }

        public string getDoctorAndStaff(int ID)
        {
            return AppointmentDAO.Instance.getDoctorAndStaff(ID);
        }

        public string GetService(int ServiceID)
        {
            return AppointmentDAO.Instance.GetService(ServiceID);
        }

        public int GetServiceIDByName(string serviceName)
        {
            return AppointmentDAO.Instance.GetServiceIDByName(serviceName);
        }

        public List<string> GetServices()
        {
            return AppointmentDAO.Instance.GetServices();
        }

        public int GetUserIDByEmail(string email)
        {
            return AppointmentDAO.Instance.GetUserIDByEmail(email);
        }

        public string GetUserNameFromEmail(string email)
        {
            return AppointmentDAO.Instance.GetUserNameFromEmail(email);
        }

        public void insertAppointment(TblAppointment appointment)
        {
            AppointmentDAO.Instance.insertAppointment(appointment);
        }

        public String GetBirdTypeByID(int ID)
        {
            return AppointmentDAO.Instance.GetBirdTypeByID((int)ID);
        }

        public double GetTotal(string ID)
        {
           return AppointmentDAO.Instance.GetTotal(ID);
        }

        public void ChangeStatus(TblAppointment tblAppointment)
        {
            AppointmentDAO.Instance.ChangeStatus(tblAppointment);
        }

        public IEnumerable getAllAppointment() => AppointmentDAO.GetAllAppointment();

        public void InsertFeedback(TblFeedback feedback)
        {
            AppointmentDAO.Instance.InsertFeedback(feedback);
        }
    }
}
