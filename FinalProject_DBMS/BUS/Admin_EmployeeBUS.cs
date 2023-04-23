using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.Model;

namespace BUS
{
    public class Admin_EmployeeBUS
    {
        QLHSBAEntities nhanvien = new QLHSBAEntities();

        public DataTable getNhanvien()
        {
            var nvs = from nv in nhanvien.View_Staff select nv;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("CMND/CCCD");
            dt.Columns.Add("Khoa");
            dt.Columns.Add("ID khoa");
            dt.Columns.Add("Ngày tạo");
            dt.Columns.Add("Ngày cập nhật");
            foreach (var i in nvs)
            {
                dt.Rows.Add(i.doctorID, i.doctorLastName, i.doctorFirstname, i.sex, i.birthDay,
                    i.address, i.phone, i.cardID, i.departmentName, i.departmentID, i.createdAt, i.updatedAt);
            }
            return dt;
        }
        public void InsertNhanVien(string firstnam, string lastname, string sex, string birthday, string address, string sdt, string cardid, 
            string depid, ref string err)
        {
          
                nhanvien.InsertStaff(firstnam, lastname, sex, Convert.ToDateTime(birthday), address, sdt, cardid, depid);
                nhanvien.SaveChanges();
       
        }
        public void UpdateNhanVien(string firstnam, string lastname, string sex, string birthday, string address, string sdt, string cardid, 
             string depid,string peoid, ref string err)
        {
            nhanvien.UpdateDoctor_Staff(firstnam, lastname, sex, Convert.ToDateTime(birthday), address, sdt, cardid, depid, peoid);
        }
    }
}
