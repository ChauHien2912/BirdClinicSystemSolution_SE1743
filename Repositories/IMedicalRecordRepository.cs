using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IMedicalRecordRepository
    {
        List<TblMedicalRecord> GetUserMedicalRecords(String email);

        string GetUserNameFromEmail(string email);
        string GetDoctorNameFromEmail(string email);

        
    }


}
