using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class MedicineGroupBUS
    {
        MedicineGroupDAL medicineGroupDAL;

        public MedicineGroupBUS()
        {
            medicineGroupDAL = new MedicineGroupDAL();
        }

        public void FindAllMedicineGroup(DataGridView dgv)
        {
            dgv.DataSource = medicineGroupDAL.FindAllMedicineGroup();
            dgv.Columns[0].HeaderText = "Mã nhóm thuốc";
            dgv.Columns[1].HeaderText = "Tên nhóm thuôc";
            dgv.Columns[2].HeaderText = "Ngày tạo";
            dgv.Columns[3].HeaderText = "Cập nhật";

            dgv.Columns[0].Width = (int)(dgv.Width * 0.5);
            dgv.Columns[1].Width = (int)(dgv.Width * 0.5);
            dgv.Columns[2].Width = (int)(dgv.Width * 0.3);
            dgv.Columns[3].Width = (int)(dgv.Width * 0.3);
        }

        public bool InsertMedicineGroup(string medGName)
        {
            try
            {
                medicineGroupDAL.InsertMedicineGroup(medGName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateMedicineGroup(string medGID, string medGName)
        {
            try
            {
                medicineGroupDAL.UpdateMedicineGroup(medGID, medGName);  
                return true;
            }
            catch (Exception)
            {
                return false;
            } 
        }

        public bool DeleteMedicineGroup(string medGID)
        {
            try
            {
                medicineGroupDAL.DeleteMedicineGroup((string)medGID);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
