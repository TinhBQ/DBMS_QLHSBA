using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class departmentBUS
    {
        departmantDAL departmantDAL;


        public departmentBUS()
        {
            departmantDAL = new departmantDAL();
        }

        public void FindAllDepartment1(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = departmantDAL.FindAllDepartment1();
                dgv.Columns[0].HeaderText = "Mã phòng";
                dgv.Columns[1].HeaderText = "Tên phòng";
                dgv.Columns[2].HeaderText = "Ngày tạo";
                dgv.Columns[3].HeaderText = "Ngày cập nhật";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void FindAllDepartment1BydepartmentNameLike(DataGridView dgv, TextBox txt)
        {
            try
            {
                dgv.DataSource = departmantDAL.FindAllDepartment1BydepartmentNameLike(txt.Text);
                dgv.Columns[0].HeaderText = "Mã phòng";
                dgv.Columns[1].HeaderText = "Tên phòng";
                dgv.Columns[2].HeaderText = "Ngày tạo";
                dgv.Columns[3].HeaderText = "Ngày cập nhật";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool InsertDepartment(string departmentName)
        {
            try
            {
                departmantDAL.InsertDepartment(departmentName);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool UpdateDepartment(string departmentName, string departmentID)
        {
            try
            {
                departmantDAL.UpdateDepartment(departmentName, departmentID);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool DeleteDepartment(string departmentID)
        {
            try
            {
                departmantDAL.DeleteDepartment(departmentID);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
