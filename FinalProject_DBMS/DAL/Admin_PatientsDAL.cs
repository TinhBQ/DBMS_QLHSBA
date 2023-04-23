using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
namespace DAL
{
    public class Admin_PatientsDAL
    {
        public List<View_Patients_Wait> getThongTinBenhNhan()
        {
            List<View_Patients_Wait> info_BenhNhan = new List<View_Patients_Wait>();
            //kết nố db
            using (QLHSBAEntities db = new QLHSBAEntities())
            {
                //Lấy ra tất cả các column trong bảng Info_patient
                var tb_infoBN = from bn in db.View_Patients_Wait
                                select bn;
                foreach (var i in tb_infoBN)
                {
                    View_Patients_Wait bn = new View_Patients_Wait();
                    bn.patientID = i.patientID;
                    bn.patientFirstName = i.patientFirstName;
                    bn.patientLastname = i.patientLastname;
                    bn.sex = i.sex;
                    bn.birthDay = i.birthDay;
                    bn.address = i.address;
                    bn.phone = i.phone;
                    bn.cardID = i.cardID;
                    bn.patientJob = i.patientJob;
                    bn.healthInsurance = i.healthInsurance;
                    bn.reason = i.reason;
                    bn.createdAt = i.createdAt;
                    bn.updatedAt = i.updatedAt;
                    info_BenhNhan.Add(bn);
                }
            }
            return info_BenhNhan;
        }
    }
}
