using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MedicalRecordRepository : IMedicalRecordRepository
    {

        public string GetDoctorNameFromEmail(string email)
        {
            throw new NotImplementedException();
        }

        

        public List<TblMedicalRecord> GetUserMedicalRecords(string email)
        {
            return MedicalRecordDAO.Instance.GetUserMedicalRecords(email);
        }

        public string GetUserNameFromEmail(string email)
        {
            return MedicalRecordDAO.Instance.GetUserNameFromEmail(email);
        }
    }
}
