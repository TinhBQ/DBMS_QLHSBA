using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using DAL;
using System.Data;
namespace BUS
{
    public class DangNhapBUS
    {
        QLHSBAEntities accs = new QLHSBAEntities();
        public DataTable getAccount()
        {

            var acc = from a in accs.View_Account select a;
            DataTable dt = new DataTable();
            dt.Columns.Add("User name");
            dt.Columns.Add("password");
            dt.Columns.Add("RoleId");

            foreach (var i in acc)
            {
                dt.Rows.Add(i.Username, i.Password, i.RoleID);
            }
            return dt;
        }

        public DataTable getNhanvien()
        {
            var nvs = from nv in accs.View_Staff select nv;
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

        public DataTable getBacSi()
        {
            var bss = from bs in accs.View_Doctor select bs;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Bác sĩ");
            dt.Columns.Add("Họ");
            dt.Columns.Add("Tên");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("CMND/CCCD");

            foreach (var i in bss)
            {
                dt.Rows.Add(i.doctorID, i.doctorLastName, i.doctorFirstname, i.sex, i.birthDay, i.address, i.phone, i.cardID);
            }
            return dt;
        }

            public void DeleteAccount(string name)
        {
             accs.deleteAccount(name);
         
        }

        public void UpdateAccount(string name, string password, int Role)
        {
            accs.updateAccount(name, password, Role);
        }

        public void InsertAccount(string name,string pass, int role)
        {
            accs.InsertAccount2(name, pass, role); 
        }

        public int getRole(string name)
        {
            var t = accs.Database.SqlQuery<int>("Select [dbo].[fnGetRoleByAccountName]('" + name + "')").FirstOrDefault();
            return Convert.ToInt32(t);
        }

        public void getLogin(string name, string password)
        {
            accs.CheckLogin(name, password);
        }
    }
}
