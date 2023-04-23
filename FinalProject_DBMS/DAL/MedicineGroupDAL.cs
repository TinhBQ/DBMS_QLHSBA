using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MedicineGroupDAL
    {
        QLHSBAEntities db;
        public MedicineGroupDAL()
        {
            db = new QLHSBAEntities();
        }

        public dynamic FindAllMedicineGroup()
        {
            return db.spFindAllMedicineGroup().ToList();
        }

        public void InsertMedicineGroup(string medGName)
        {
            db.spInsertMedicineGroup(medGName);
            db.SaveChanges();
        }

        public void UpdateMedicineGroup(string medGID, string medGName)
        {
            db.spUpdateMedicineGroup(medGID, medGName);
            db.SaveChanges();
        }

        public void DeleteMedicineGroup(string medGID)
        {
            db.spDeleteMedicineGroup(medGID);
            db.SaveChanges();
        }
    }
}
