using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.impl
{
    public class ServiceBUS_impl 
    {
        private QLHSBAEntities db = new QLHSBAEntities();

        public void Create(Service obj)
        {
            if (obj.GetType().Equals(typeof(Service)))
            {
                Service newService = (Service)obj;
                db.Services.Add(newService);
                db.SaveChanges();
            }
        }

        public void Delete(Service obj)
        {
            if (obj.GetType().Equals(typeof(Service)))
            {
                Service service = (Service)obj;
                db.Services.Remove(service);
                db.SaveChanges();
            }
        }

        public List<Service> getAll()
        {
            List<Service> services = db.Services.ToList();
            return services;
        }

        public Service getById(string id)
        {
            Service service = db.Services.Where(s => s.serviceID.Equals(id)).FirstOrDefault();
            return service;
        }

        public Service getByName(string name)
        {
            Service service = db.Services.Where(s => s.serviceName.Equals(name)).FirstOrDefault();
            return service;
        }

        public List<Service> Search(string keyword)
        {
            List<Service> services = db.Services.Where(s => s.serviceName.Contains(keyword)).ToList();
            return services;
        }

        public void Update(Service obj)
        {
            if (obj.GetType().Equals(typeof(Service)))
            {
                Service newService = (Service)obj;
                db.Services.AddOrUpdate(newService);
                db.SaveChanges();
            }
        }
    }
}
