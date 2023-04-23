using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL
{
    public class Admin_DoctorsDAL
    {
        public List<View_Doctor> getThongTinBacSi()
        {
            List<View_Doctor> info_Doctors = new List<View_Doctor>();

            //kết nối db
            using (QLHSBAEntities db = new QLHSBAEntities())
            {
                //Lấy ra tất cả các column trong bảng Info_patient
                var tb_inforBS = from bs in db.View_Doctor
                                 select bs;
                foreach (var i in tb_inforBS)
                {
                    View_Doctor bs = new View_Doctor();
                    bs.doctorID = i.doctorID;
                    bs.doctorLastName = i.doctorLastName;
                    bs.doctorFirstname = i.doctorFirstname;
                    bs.sex = i.sex;
                    bs.birthDay = i.birthDay;
                    bs.address = i.address;
                    bs.phone = i.phone;
                    bs.cardID = i.cardID;
                    bs.departmentName = i.departmentName;
                    bs.departmentID = i.departmentID;
                    bs.createdAt = i.createdAt;
                    bs.updatedAt = i.updatedAt;
                    info_Doctors.Add(bs);
                }
            }
            return info_Doctors;
        }
    }
}
