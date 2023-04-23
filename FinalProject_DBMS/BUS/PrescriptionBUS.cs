using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class PrescriptionBUS
    {
        PrescriptionDAL prescriptionDAL;
        MedicineDAL medicineDAL;

        public PrescriptionBUS()
        {
            prescriptionDAL = new PrescriptionDAL();
            medicineDAL = new MedicineDAL();
        }

        /*public bool InsertPrescriptionNull(string patientID, string employeeID)
        {
            try
            {
                prescriptionDAL.InsertPrescriptionNull(patientID, employeeID);
                return true;
            }
            catch (Exception)
            {   
               return false;   
            }
        }*/

        public void GetDataMedicine_ComboBox(ComboBox combo)
        {
            try
            {
                combo.DataSource = medicineDAL.FindAllMedicine1();
                combo.DisplayMember = "medicineName";
                combo.ValueMember = "medicineName";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void GetMedicineByMedicineName(string medicineName, TextBox txtMaThuoc, TextBox txtNhomThuoc,
                                                 TextBox txtHinhDang, TextBox txtDonVi,
                                                TextBox txtGia, TextBox txtHSD, TextBox txtSoTon)

        {
            try
            {
                dynamic ds = medicineDAL.FindAllMedicine1ByMedicineName(medicineName);
                txtMaThuoc.DataBindings.Clear();
                txtMaThuoc.DataBindings.Add("Text", ds, "medicineID");

                txtNhomThuoc.DataBindings.Clear();
                txtNhomThuoc.DataBindings.Add("Text", ds, "medicineGroupName");

                txtHinhDang.DataBindings.Clear();
                txtHinhDang.DataBindings.Add("Text", ds, "shape");

                txtDonVi.DataBindings.Clear();
                txtDonVi.DataBindings.Add("Text", ds, "unit");

                txtGia.DataBindings.Clear();
                txtGia.DataBindings.Add("Text", ds, "medicinePrice");

                txtHSD.DataBindings.Clear();
                txtHSD.DataBindings.Add("Text", ds, "expiry");

                txtSoTon.DataBindings.Clear();
                txtSoTon.DataBindings.Add("Text", ds, "count");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool InsertPrescription_Medicine(string prescriptionID, string medicineName, int quanlity)
        {
            try
            {
                prescriptionDAL.InsertPrescription_Medicine(prescriptionID, medicineName, quanlity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void FindAllPrescription_Medicine(DataGridView dgv, string prescriptionID)
        {
            dgv.DataSource = prescriptionDAL.FindAllPrescription_Medicine(prescriptionID);
        }

        public void FindAllWaitDrugSupply(DataGridView dgv)
        {
            dgv.DataSource = prescriptionDAL.FindAllWaitDrugSupply();

            dgv.Columns[0].HeaderText = "Mã cấp thuốc";
            dgv.Columns[1].HeaderText = "Mã khám bệnh";
            dgv.Columns[2].HeaderText = "Mã BN";
            dgv.Columns[3].HeaderText = "Tên";
            dgv.Columns[4].HeaderText = "Họ";
            dgv.Columns[5].HeaderText = "Giới tính";
            dgv.Columns[6].HeaderText = "Ngày sinh";
            dgv.Columns[7].HeaderText = "Địa chỉ";
            dgv.Columns[8].HeaderText = "SĐT";
            dgv.Columns[9].HeaderText = "CCCN/CMND";
            dgv.Columns[10].HeaderText = "Nghề nghiệp";
            dgv.Columns[11].HeaderText = "BHYT";
            dgv.Columns[12].HeaderText = "Lý do khám";
            dgv.Columns[13].HeaderText = "Ngày tạo";
            dgv.Columns[14].HeaderText = "Ngày cập nhật";

            dgv.Columns[0].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[1].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[2].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[3].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[4].Width = (int)(dgv.Width * 0.2);
            dgv.Columns[5].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[6].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[7].Width = (int)(dgv.Width * 0.3);
            dgv.Columns[8].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[9].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[10].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[11].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[12].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[13].Width = (int)(dgv.Width * 0.15);
            dgv.Columns[14].Width = (int)(dgv.Width * 0.15);
        }

        public bool UpdatePrescription_Medicine(string prescriptionID, string medicineName, int quanlity)
        {
            try
            {
                prescriptionDAL.UpdatePrescription_Medicine(prescriptionID, medicineName, quanlity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeletePrescription_Medicine(string prescriptionID, string medicineName)
        {
            try
            {
                prescriptionDAL.DeletePrescription_Medicine(prescriptionID, medicineName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdatePrescription(string prescriptionID, string descriptionPrescription)
        {
            try
            {
                prescriptionDAL.UpdatePrescription(prescriptionID, descriptionPrescription);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
