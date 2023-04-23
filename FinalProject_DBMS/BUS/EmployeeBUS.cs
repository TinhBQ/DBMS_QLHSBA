using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class EmployeeBUS
    {
        private QLHSBAEntities db = new QLHSBAEntities();

        public Employee findByID(string employeeID)
        {
            return db.Employees.Where(e => e.employeeID.Equals(employeeID)).FirstOrDefault();
        }
    }
}
