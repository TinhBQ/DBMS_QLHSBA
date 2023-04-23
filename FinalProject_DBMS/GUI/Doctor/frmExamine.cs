using BUS;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Doctor
{
    public partial class frmExamine : Form
    {
        private string doctorID;
        DoctorBUS doctorBUS;
        PatientBUS patientBUS;
        ExaminationBUS examinationBUS;
        PrescriptionBUS prescriptionBUS;
        public frmExamine(string doctorID)
        {
            InitializeComponent();
            doctorBUS = new DoctorBUS();
            patientBUS = new PatientBUS();
            examinationBUS = new ExaminationBUS();
            prescriptionBUS = new PrescriptionBUS();
            this.doctorID = doctorID;
        }

        private void FindAllPatientWait()
        {

            patientBUS.FindAllPatientWait(dgvPatientWait);
        }

        private void frmExamine_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void dgvPatientWait_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDataPatientWait(e.RowIndex);
        }

        private void GetDataPatientWait(int rowIndex)
        {
            try
            {
                if (rowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvPatientWait.Rows[rowIndex];
                    this.txtMaKhamBenh.Text = (string)row.Cells[0].Value;
                    this.txtMaBN.Text = (string)row.Cells[1].Value;
                    this.txtTen.Text = (string)row.Cells[2].Value;
                    this.txtHo.Text = (string)row.Cells[3].Value;
                    this.txtGioiTinh.Text = (string)row.Cells[4].Value;
                    this.txtNgaySinh.Text = (string)row.Cells[5].Value.ToString();
                    this.txtDiaChi.Text = (string)row.Cells[6].Value;
                    this.txtSDT.Text = (string)row.Cells[7].Value;
                    this.txtCMND.Text = (string)row.Cells[8].Value;
                    this.txtNgheNghiep.Text = (string)row.Cells[9].Value;
                    this.txtBHYT.Text = (string)row.Cells[10].Value;
                    this.txtLyDoKham.Text = (string)row.Cells[11].Value;
                }
                else
                {
                    MessageBox.Show("Dữ liệu không tồn tại hoặc không lấy được dữ liệu.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Không có bộ dữ liệu.");
            }

                


        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ISCheckInputExam())
            {
                try
                {
                    bool ins = examinationBUS.UpdateExamination((string)this.txtMaBN.Text,
                                                        (string)this.txtMaBS.Text,
                                                        double.Parse(this.txtChieuCao.Text),
                                                        double.Parse(this.txtCanNang.Text),
                                                        double.Parse(this.txtNhietDo.Text),
                                                        int.Parse(this.txtNhipTho.Text),
                                                        (string)this.txtTTHT.Text,
                                                        int.Parse(this.txtMach.Text),
                                                        int.Parse(this.txtHuyetAp.Text),
                                                        (string)this.txtCDSB.Text,
                                                        (string)this.txtCDSC.Text,
                                                        (string)this.txtHDT.Text,
                                                        (string)this.txtMaKhamBenh.Text);

                    if (ins)
                    {
                        MessageBox.Show("Thêm thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.LoadData();
                    }    
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm không thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.LoadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadData();
            }    
        }

        private void LoadData()
        {
            this.txtMaBS.Text = this.doctorID;
            doctorBUS.FindDepartmentNameByDoctorId(this.txtKhoaKham, doctorID);
            doctorBUS.FindFullNameDoctorByDoctorId(this.txtTenBS, doctorID);
            this.FindAllPatientWait();
            patientBUS.CountPatientsWait(txtCountPatientsWait);
            this.GetDataPatientWait(0);
            prescriptionBUS.FindAllWaitDrugSupply(this.dgvCapThuoc);
            /*examinationBUS.GetExaminateIDNext(txtMaKhamBenh);*/

            this.txtChieuCao.ResetText();
            this.txtCanNang.ResetText();
            this.txtNhietDo.ResetText();
            this.txtNhipTho.ResetText();
            this.txtMach.ResetText();
            this.txtHuyetAp.ResetText();
            this.txtTTHT.ResetText();
            this.txtCDSB.ResetText();
            this.txtCDSC.ResetText();
            this.txtHDT.ResetText();

            this.txtChieuCao.Enabled = false;
            this.txtCanNang.Enabled = false;
            this.txtNhietDo.Enabled = false;
            this.txtNhipTho.Enabled = false;
            this.txtMach.Enabled = false;
            this.txtHuyetAp.Enabled = false;
            this.txtTTHT.Enabled = false;
            this.txtCDSB.Enabled = false;
            this.txtCDSC.Enabled = false;
            this.txtHDT.Enabled = false;
        }

        private bool ISCheckInputExam()
        {
            if ((this.txtChieuCao.Text == "")   ||
                (this.txtCanNang.Text == "")    ||
                (this.txtNhietDo.Text == "")    ||
                (this.txtNhipTho.Text == "")    ||
                (this.txtMach.Text == "")       || 
                (this.txtHuyetAp.Text == "")    ||
                (this.txtTTHT.Text == "")       ||
                (this.txtCDSB.Text == "")       ||
                (this.txtCDSC.Text == "")       ||
                (this.txtHDT.Text == ""))
            {
                this.LoadData();
                return false;
            }
            return true;
        }

        private void btnCapThuoc_Click(object sender, EventArgs e)
        {
            if (this.txtMaDT.Text != "")
            {
                DialogResult tl = MessageBox.Show("Bạn có chắc muốn cấp thuốc", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    frmPrescription frm = new frmPrescription(this.txtMaDT.Text);
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn vui lòng chọn bệnh nhân cần cấp thuốc.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (this.txtChieuCao.Enabled == false)
            {
                this.txtChieuCao.Enabled = true;
                this.txtCanNang.Enabled = true;
                this.txtNhietDo.Enabled = true;
                this.txtNhipTho.Enabled = true;
                this.txtMach.Enabled = true;
                this.txtHuyetAp.Enabled = true;
                this.txtTTHT.Enabled = true;
                this.txtCDSB.Enabled = true;
                this.txtCDSC.Enabled = true;
                this.txtHDT.Enabled = true;

                this.txtChieuCao.Focus();
            }
            else
            {
                this.txtChieuCao.Enabled = false;
                this.txtCanNang.Enabled = false;
                this.txtNhietDo.Enabled = false;
                this.txtNhipTho.Enabled = false;
                this.txtMach.Enabled = false;
                this.txtHuyetAp.Enabled = false;
                this.txtTTHT.Enabled = false;
                this.txtCDSB.Enabled = false;
                this.txtCDSC.Enabled = false;
                this.txtHDT.Enabled = false;
            }    
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc muốn THOÁT?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvCapThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetDataWaitDrugSupply(e.RowIndex);
        }

        private void GetDataWaitDrugSupply(int rowIndex)
        {

            if (rowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCapThuoc.Rows[rowIndex];
                this.txtMaDT.Text = (string)row.Cells[0].Value;
                this.txtMaKhamBenh.Text = (string)row.Cells[1].Value;
                this.txtMaBN.Text = (string)row.Cells[2].Value;
                this.txtTen.Text = (string)row.Cells[3].Value;
                this.txtHo.Text = (string)row.Cells[4].Value;
                this.txtGioiTinh.Text = (string)row.Cells[5].Value;
                this.txtNgaySinh.Text = (string)row.Cells[6].Value.ToString();
                this.txtDiaChi.Text = (string)row.Cells[7].Value;
                this.txtSDT.Text = (string)row.Cells[8].Value;
                this.txtCMND.Text = (string)row.Cells[9].Value;
                this.txtNgheNghiep.Text = (string)row.Cells[10].Value;
                this.txtBHYT.Text = (string)row.Cells[11].Value;
                this.txtLyDoKham.Text = (string)row.Cells[12].Value;
            }
            else
            {
                MessageBox.Show("Dữ liệu không tồn tại hoặc không lấy được dữ liệu.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
