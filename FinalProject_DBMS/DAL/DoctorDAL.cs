using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DoctorDAL 
    {
        QLHSBAEntities db;
        public DoctorDAL()
        {
            db = new QLHSBAEntities();
        }

        public dynamic FindAllDoctor()
        {
            var ds = db.FindAllDoctor();
            return ds.ToList();
            
        }

        public string FindDepartmentNameByDoctorId(string doctorID)
        {   
            var depName = db.FindDepartmentNameByDoctorId(doctorID);
            return depName.First(); 
        }

        public string FindFullNameDoctorByDoctorId(string doctorName)
        {
            var fullNameDoc = db.FindFullNameDoctorByDoctorId(doctorName);
            return fullNameDoc.First();
        }
    }
}
