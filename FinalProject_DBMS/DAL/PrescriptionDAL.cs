using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PrescriptionDAL
    {
        QLHSBAEntities db;
        public PrescriptionDAL()
        {
            db = new QLHSBAEntities();
        }

        /*public void InsertPrescriptionNull(string patientID, string employeeID)
        {

            db.spInsertPrescription_Null(patientID, employeeID);
            db.SaveChanges();
        }*/

        public void InsertPrescription_Medicine(string prescriptionID, string medicineName, int quanlity)
        {
            db.spInsertPrescription_Medicine(prescriptionID, medicineName, quanlity);
            db.SaveChanges();
        }

        public dynamic FindAllPrescription_Medicine(string prescriptionID)
        {
            return db.spFindAllPrescription_Medicine(prescriptionID).ToList();
        }

        public void UpdatePrescription_Medicine(string prescriptionID, string medicineName, int quanlity)
        {
            db.spUpdatePrescription_Medicine(prescriptionID, medicineName, quanlity);
            db.SaveChanges();
        }

        public void DeletePrescription_Medicine(string prescriptionID, string medicineName)
        {
            db.spDeletePrescription_Medicine(prescriptionID, medicineName);
            db.SaveChanges();
        }

        public void UpdatePrescription(string prescriptionID, string descriptionPrescription)
        {
            db.spUpdatePrescription(prescriptionID, descriptionPrescription);
            db.SaveChanges();
        }

        public dynamic FindAllWaitDrugSupply()
        {
            return db.spWaitDrugSupply().ToList();
        }
    }
}
