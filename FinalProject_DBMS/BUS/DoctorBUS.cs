using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class DoctorBUS
    {
        DoctorDAL doctorDAL;
        public DoctorBUS()
        {
            doctorDAL = new DoctorDAL();
        }

        public void FindAllDoctor(DataGridView dgv)
        {
            dgv.DataSource = doctorDAL.FindAllDoctor();
        }

        public void FindDepartmentNameByDoctorId(TextBox txt,string doctorId)
        {
            txt.Text = doctorDAL.FindDepartmentNameByDoctorId(doctorId);
        }

        public void FindFullNameDoctorByDoctorId(TextBox txt, string doctorId)
        {
            txt.Text = doctorDAL.FindFullNameDoctorByDoctorId(doctorId);
        }
    }
}
