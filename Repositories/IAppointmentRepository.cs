using BusinessObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IAppointmentRepository
    {

        List<TblFeedback> GetFeedbackFromAppointmentID(int ID);

        void InsertFeedback(TblFeedback feedback);

        void ChangeStatus( TblAppointment tblAppointment);

        int GetBirdIDByType(string type);
        int GetUserIDByEmail(string email);
        int GetServiceIDByName(string serviceName);
        List<TblAppointment> GetAllAppointmentsByEmail(String email);

        string GetUserNameFromEmail(string email);

        string GetService(int ServiceID);

        string getDoctorAndStaff(int ID);

        void insertAppointment(TblAppointment appointment);

        void deleteAppointment(TblAppointment appointment);

        List<String> GetBirdType();

        List<String> GetServices();

        string GetBirdTypeByID(int ID);

        double GetTotal(string ID);

        public IEnumerable getAllAppointment();
    }
}
