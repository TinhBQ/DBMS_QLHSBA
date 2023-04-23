using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.Model;

namespace BUS
{
    public class Admin_DoctorsBUS 
    { 
        QLHSBAEntities bacsi = new QLHSBAEntities();
        public DataTable getBacSi()
        {
            var bss = from bs in bacsi.View_Doctor select bs;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Bác sĩ");
            dt.Columns.Add("Họ");
            dt.Columns.Add("Tên");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("CMND/CCCD");
            dt.Columns.Add("Khoa");
            dt.Columns.Add("ID khoa");
            dt.Columns.Add("Ngày tạo");
            dt.Columns.Add("Ngày chỉnh sửa");

            foreach (var i in bss)
            {
                dt.Rows.Add(i.doctorID, i.doctorLastName, i.doctorFirstname, i.sex, i.birthDay, i.address, i.phone, i.cardID, i.departmentName, i.departmentID, i.createdAt, i.updatedAt);
            }
            return dt;
        }
        public void InsertBacSi(string firstnam, string lastname, string sex, string birthday, string address, string sdt, string cardid,
            string idkhoa, ref string err)
        {
            bacsi.InsertDoctor(firstnam, lastname, sex, Convert.ToDateTime(birthday), address, sdt, cardid,idkhoa);
        }
        public void UpdateBacSi(string firstname, string lastname, string sex, string birthday, string address, string sdt, string cardid,
            string idkhoa, string idpeo, ref string err)
        {
            bacsi.UpdateDoctor_Staff(firstname, lastname, sex, Convert.ToDateTime(birthday), address, sdt, cardid, idkhoa, idpeo);
        }
    }
}
