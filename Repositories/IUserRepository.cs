using BusinessObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public interface IUserRepository
    {

        public IEnumerable getUser(bool isTrue);
        List<TblUser> GetUserByEmail(string email);
        public TblUser CheckLogin(string email, string password);
        public bool Register(string fullName, string email, string password, string address, string phoneNumber, bool gender);
        public void UpdateProfile(int id, string fullName, string emal, bool gender, string phoneNumber, string address);
        public IEnumerable GetAppointmentsByVeterianarianId(int veterianarianId);
        public void CompleteAppointment(int appointmentsId);
        public TblUser GetUserById(int id);
        public void ChangePassword(int id, string password);

        public void UpdateUser(int UserID, int roleId, string email, string password, string fullName, bool gender, string phone, string address);
        public void DeleteUser(int userID);
        public TblAppointment GetAppointmentById(int id);

        public void CreateUser(int roleID, String email, String password, String fullName, bool gender, String phone, String address);

        Dictionary<int,string> GetUserNameByID();
        
        public void AddMedicalRecord(int userId, int birdId, int docId, DateTime date, string diagnosis, string intruction);
    }
}
