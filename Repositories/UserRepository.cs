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
    public class UserRepository : IUserRepository
    {

        public void UpdateUser(int UserID, int roleId, string email, string password, string fullName, bool gender, string phone, string address)
       => UserDAO.UpdateUser(UserID, roleId, email, password, fullName, gender, phone, address);

        public void CreateUser(int roleID, string email, string password, string fullName, bool gender, string phone, string address)
        => UserDAO.CreateUser(roleID, email, password, fullName, gender, phone, address);

        public void DeleteUser(int userID)
        => UserDAO.DeleteUser(userID);
        public void AddMedicalRecord(int userId, int birdId, int docId, DateTime date, string diagnosis, string intruction) => UserDAO.Instance.AddMedicalRecord(userId, birdId, docId, date, diagnosis, intruction);

        public void ChangePassword(int id, string password) => UserDAO.Instance.ChangePassword(id, password);   

        public TblUser CheckLogin(string email, string password) => UserDAO.Instance.CheckLogin(email, password);

        public void CompleteAppointment(int appointmentsId) => UserDAO.Instance.CompleteAppointment(appointmentsId);

        public TblAppointment GetAppointmentById(int id) => UserDAO.Instance.GetAppointmentById(id);

        public IEnumerable GetAppointmentsByVeterianarianId(int veterianarianId) => UserDAO.Instance.GetAppointmentsByVeterianarianId(veterianarianId);

        public List<TblUser> GetUserByEmail(string email)
        {
            return UserDAO.Instance.GetUserByEmail(email);
        }

        public TblUser GetUserById(int id) => UserDAO.Instance.GetUserById(id);

        public bool Register(string fullName, string email, string password, string address, string phoneNumber, bool gender) => UserDAO.Instance.Register(fullName, email, password, address, phoneNumber, gender);

        public IEnumerable getUser(bool i) => UserDAO.getAllCus(i);
        public void UpdateProfile(int id, string fullName, string emal, bool gender, string phoneNumber, string address) => UserDAO.Instance.UpdateProfile(id, fullName, emal, gender, phoneNumber, address);

        public Dictionary<int,string> GetUserNameByID() => UserDAO.Instance.GetUserNameByID();
        
    }
}
