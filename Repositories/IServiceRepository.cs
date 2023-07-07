using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IServiceRepository
    {
        public List<TblService> GetAllServices();

        List<object> getRevevue();

        List<object> searchRevevue(DateTime fDate, DateTime tDate);

        public void createService(string serviceName, int status, string des, double price);

        public void UpdateService(int id, string serviceName, int status, string des, double price);

        public void deleteService(int id);

        public TblService getServiceByID(int id);

       
    }
}
