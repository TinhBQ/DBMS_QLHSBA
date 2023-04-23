using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MedicineDAL
    {
        QLHSBAEntities db;
        public MedicineDAL()
        {
            db = new QLHSBAEntities();
        }

        public dynamic FindAllMedicine1()
        {
            return db.spFindAllMedicine1().ToList();
        }

        public dynamic FindAllMedicine0()
        {
            return db.spFindAllMedicine0().ToList();
        }

        public dynamic FindAllMedicine1ByMedicineName(string medicineName)
        {
            return db.spFindAllMedicine1ByMedicineName(medicineName).ToList();
        }

        public dynamic FindMedicineBymedicineNameLike(string medicineName)
        {
            return db.spFindMedicineBymedicineNameLike(medicineName).ToList();
        }

        public void InsertMedicine(string medicineName, string unit, 
                                    int medicinePrice, int expiry, 
                                    int count, string shape, string medicineGroupName)
        {
            db.spInsertMedicine(medicineName, unit, medicinePrice, expiry, count, shape, medicineGroupName);
            db.SaveChanges();
        }
        
        public void UpdateMedicine(string medicineName, string unit,
                                    int medicinePrice, int expiry,
                                    int count, string shape, 
                                    string medicineGroupName, string medicineID)
        {
            db.spUpdateMedicine(medicineName, unit, medicinePrice, expiry, count, shape, medicineGroupName, medicineID);
            db.SaveChanges();
        }

        public void DeleteMedicine1(string medicineID)
        {
            db.spDeleteMedicine1(medicineID);
            db.SaveChanges();
        }

        public void RestoreMedicine(string medicineID)
        {
            db.spRestoreMedicine(medicineID);
            db.SaveChanges();
        }
    }
}
