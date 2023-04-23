using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.impl
{
    public class UsingServiceBUS_impl
    {
        QLHSBAEntities db = new QLHSBAEntities();

        public void Create(string patientID, string serviceID, byte quantity)
        {
            db.proc_InsertUsingService(patientID, serviceID, quantity);
            db.SaveChanges();
        }

        public List<func_getListService_notYet_Result> GetNotYet_Results(string patientID)
        {
            return db.func_getListService_notYet(patientID).ToList();
        }

        public int getTotalPay(string patientID)
        {
            var t = db.Database.SqlQuery<int>("SELECT [dbo].[func_getTotalPay_usingService]('" + patientID + "')")
                        .FirstOrDefault();
            return Convert.ToInt32(t);
        }

        public void payService(string patientID, string employeeID)
        {
            db.proc_Pay_service(patientID, employeeID);
            db.SaveChanges();
        }

        public void Delete(UsingService obj)
        {
            throw new NotImplementedException();
        }

        public List<UsingService> getAll()
        {
            throw new NotImplementedException();
        }

        public UsingService getById(string id)
        {
            throw new NotImplementedException();
        }

        public UsingService getByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<UsingService> Search(string keyword)
        {
            throw new NotImplementedException();
        }

        public void Update(string usingService, string patientID, string serviceID, byte quantity)
        {
            db.proc_UpdateUsingService(usingService, patientID, serviceID, quantity);
            db.SaveChanges();
        }
    }
}
