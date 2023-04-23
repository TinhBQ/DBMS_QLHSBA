using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class Admin_PatientBUS
    {
        QLHSBAEntities benhnhan = new QLHSBAEntities();
        public DataTable getBenhNhan()
        {

            var bns = from bn in benhnhan.View_Patients_Wait select bn;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã bệnh nhân");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("CMND/CCCD");
            dt.Columns.Add("Công việc");
            dt.Columns.Add("Mã bảo hiểm y tế");
            dt.Columns.Add("Lý do vào viện");
            dt.Columns.Add("Ngày tạo");
            dt.Columns.Add("Ngày sửa");

            foreach (var i in bns)
            {
                dt.Rows.Add(i.patientID, i.patientLastname, i.patientFirstName, i.sex, i.birthDay, i.address, i.phone, i.cardID, i.patientJob, i.healthInsurance, i.reason, i.createdAt, i.updatedAt);
            }
            return dt;
        }



        public void InsertBenhNhan(string firstnam, string lastname, string sex, string birthday, string address, string sdt, string cardid, string job,
            string bhytid, string lydo, ref string err)
        {
            benhnhan.InsertPatient(firstnam, lastname, sex, Convert.ToDateTime(birthday), address, sdt, cardid, job, bhytid, lydo);
        }
        public void UpdateBenhNhan(string firstnam, string lastname, string sex, string birthday, string address, string sdt, string cardid, string job,
            string bhytid, string lydo, string id, ref string err)
        {
            benhnhan.UpdatePatient(firstnam, lastname, sex, Convert.ToDateTime(birthday), address, sdt, cardid, job, bhytid, lydo, id);
        }
    }
}
