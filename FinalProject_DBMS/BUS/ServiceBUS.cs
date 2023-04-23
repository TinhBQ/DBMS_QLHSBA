using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class ServiceBUS
    {

        ServiceDAL serviceDAL;
        public ServiceBUS()
        {
            serviceDAL = new ServiceDAL();
        }

        public void FindAllService(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = serviceDAL.FindAllService();
                dgv.Columns[0].HeaderText = "Mã dịch vụ";
                dgv.Columns[1].HeaderText = "Tên dịch vụ";
                dgv.Columns[2].HeaderText = "Giá";
                dgv.Columns[3].HeaderText = "Ngày tạo";
                dgv.Columns[4].HeaderText = "Ngày cập nhật";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void FindAllServiceByServiceNameLike(DataGridView dgv, TextBox txt)
        {
            try
            {
                dgv.DataSource = serviceDAL.FindAllServiceByServiceNameLike(txt.Text);
                dgv.Columns[0].HeaderText = "Mã dịch vụ";
                dgv.Columns[1].HeaderText = "Tên dịch vụ";
                dgv.Columns[2].HeaderText = "Giá";
                dgv.Columns[3].HeaderText = "Ngày tạo";
                dgv.Columns[4].HeaderText = "Ngày cập nhật";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool InsertService(string serviceName, int servicePrice)
        {
            try
            {
                serviceDAL.InsertService(serviceName, servicePrice);  
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool UpdateService(string serviceName, int servicePrice, string serviceID)
        {
            try
            {
                serviceDAL.UpdateService(serviceName, servicePrice, serviceID);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool DeleteService(string serviceID)
        {
            try
            {
                serviceDAL.DeleteService(serviceID);
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
