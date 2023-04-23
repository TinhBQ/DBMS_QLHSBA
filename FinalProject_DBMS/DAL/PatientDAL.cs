using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PatientDAL
    {
        QLHSBAEntities db;
        public PatientDAL()
        {
            db = new QLHSBAEntities();
        }

        public dynamic FindAllPatientWait()
        {
            var courses = db.FindAllPatientWait();
            return courses.ToList();
        }

        public int CountPatientsWait()
        {
            var count = db.spCountPatientsWait();
            return int.Parse(count.First().ToString());
        }
    }
}
