using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class departmantDAL
    {

        QLHSBAEntities db;
        public departmantDAL()
        {
            db = new QLHSBAEntities();
        }

        public dynamic FindAllDepartment1()
        {
            return db.spFindAllDepartment1().ToList();
        }

        public dynamic FindAllDepartment1BydepartmentNameLike(string departmentName)
        {
            return db.spFindAllDepartment1BydepartmentNameLike(departmentName).ToList();
        }

        public void InsertDepartment(string departmentName)
        {
            db.spInsertDepartment(departmentName);
            db.SaveChanges();
        }

        public void UpdateDepartment(string departmentName, string departmentID)
        {
            db.spUpdateDepartment(departmentName, departmentID);
            db.SaveChanges();
        }

        public void DeleteDepartment(string departmentID)
        {
            db.spDeleteDepartment(departmentID);
            db.SaveChanges();
        }
    }
}
