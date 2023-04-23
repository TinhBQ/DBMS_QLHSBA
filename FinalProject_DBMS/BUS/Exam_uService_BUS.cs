using BUS.impl;
using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class Exam_uService_BUS
    {
        QLHSBAEntities db = new QLHSBAEntities();
        UsingServiceBUS_impl usingServiceBUS = new UsingServiceBUS_impl();

        public void InsertUsingService(string patientID, string serviceID, byte quantity)
        {
            usingServiceBUS.Create(patientID, serviceID, quantity);
        }

        public List<func_getListService_notYet_Result> notYet(string patientID)
        {
            return db.func_getListService_notYet(patientID).ToList();
        }

        public void removeUsingService(int usID)
        {
            UsingService us = db.UsingServices.Where(u => u.usingServiceID == usID).FirstOrDefault();
            db.UsingServices.Remove(us);
            db.SaveChanges();
        }

        public void UpdateUsingService(int usID, byte quantity)
        {
            UsingService us = db.UsingServices.Where(u => u.usingServiceID == usID).FirstOrDefault();
            us.quantity = quantity;
            db.SaveChanges();
        }

        public void Submit_Exam(string patientID, string employeeID)
        {
            db.proc_createNewNullExamination(patientID, employeeID);
            db.SaveChanges();
        }
    }
}
