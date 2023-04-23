using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ServiceDAL
    {
        QLHSBAEntities db;
        public ServiceDAL()
        {
            db = new QLHSBAEntities();
        }

        public dynamic FindAllService()
        {
            return db.spFindAllService().ToList();
        }
        public dynamic FindAllServiceByServiceNameLike(string serviceName)
        {
            return db.spFindAllServiceByServiceNameLike(serviceName).ToList();
        }

        public void InsertService(string serviceName, int servicePrice)
        {
            db.spInsertService(serviceName, servicePrice);
            db.SaveChanges();
        }

        public void UpdateService(string serviceName, int servicePrice, string serviceID)
        {
            db.spUpdateService(serviceName, servicePrice, serviceID);
            db.SaveChanges();
        }

        public void DeleteService(string serviceID)
        {
            db.spDeleteService(serviceID);
            db.SaveChanges();
        }

    }
}
