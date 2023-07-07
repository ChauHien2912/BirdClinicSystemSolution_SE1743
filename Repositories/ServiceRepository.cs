using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        public List<TblService> GetAllServices()
        {
            return ServicesDAO.Instance.GetAllServices();
        }

        public void createService(string serviceName, int status, string des, double price) => ServicesDAO.createService(serviceName, status, des, price);


        public void deleteService(int id) => ServicesDAO.deleteService(id);


        public List<object> getRevevue() => ServicesDAO.getAllRevevue();

        public TblService getServiceByID(int id) => ServicesDAO.getServiceById(id);


        public List<object> searchRevevue(DateTime fDate, DateTime tDate) => ServicesDAO.searchRevevueByDate(fDate, tDate);

        public void UpdateService(int id, string serviceName, int status, string des, double price) => ServicesDAO.updateService(id, serviceName, status, des, price);

        
    }
}
