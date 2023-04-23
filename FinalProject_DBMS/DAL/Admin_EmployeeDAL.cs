﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL
{
    public class Admin_EmployeeDAL
    {
        public List<View_Staff> getThongTinNhanVien()
        {
            List<View_Staff> info_Nhanvien = new List<View_Staff>();
            //kết nố db
            using (QLHSBAEntities db = new QLHSBAEntities())
            {
                //Lấy ra tất cả các column trong bảng Info_patient
                var tb_infoNV = from nv in db.View_Staff
                                select nv;
                foreach (var i in tb_infoNV)
                {
                    View_Staff nv = new View_Staff();
                    nv.doctorID = i.doctorID;
                    nv.doctorFirstname = i.doctorFirstname;
                    nv.doctorLastName = i.doctorLastName;
                    nv.sex = i.sex;
                    nv.birthDay = i.birthDay;
                    nv.address = i.address;
                    nv.phone = i.phone;
                    nv.cardID = i.cardID;
                    nv.departmentName = i.departmentName;
                    nv.departmentID = i.departmentID;

                    info_Nhanvien.Add(nv);
                }
            }
            return info_Nhanvien;
        }
    }
}
