using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ViewExamination_BUS
    {
        private QLHSBAEntities db = new QLHSBAEntities();
        public List<View_Examination> getAll()
        {
            return db.View_Examination.ToList();
        }

        public func_getExamWithID_Result getWithID(string examinationID)
        {
            return db.func_getExamWithID(examinationID).FirstOrDefault();
        }

        public List<func_getListMedicion_withExamID_Result> getListMedicine_withExamID(string examID)
        {
            return db.func_getListMedicion_withExamID(examID).ToList();
        }

        public List<func_getPrecription_notYet_Result> getPrecription_NotYet(string patientID)
        {
            return db.func_getPrecription_notYet(patientID).ToList();
        }

        public int getTotalPay(string examID)
        {
            var t = db.Database.SqlQuery<int>("SELECT [dbo].[func_getTotalPay_ListMedicine_withExamID]('" + examID + "')")
                        .FirstOrDefault();
            return Convert.ToInt32(t);
        }

        public void payMedicine_withExamID(string patientID, string employeeID, string examinationID)
        {
            db.proc_Pay_Medicine(patientID, employeeID, examinationID);
            db.SaveChanges();
        }
    }
}
