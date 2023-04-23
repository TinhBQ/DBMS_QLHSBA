using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Doctor
{
    public partial class frmPrescription : Form
    {
        private string maDonThuoc;
        PrescriptionBUS prescriptionBUS;
        public frmPrescription(string maDonThuoc)
        {
            InitializeComponent();
            prescriptionBUS = new PrescriptionBUS();
            this.maDonThuoc = maDonThuoc;
        }

        private void frmPrescription_Load(object sender, EventArgs e)
        {
            
            this.LoadData();
        }

        private void LoadData()
        {
            this.txtMaDonThuoc.Text = maDonThuoc;
            prescriptionBUS.GetDataMedicine_ComboBox(comboTenThuoc);
            prescriptionBUS.FindAllPrescription_Medicine(this.dgvLayThuoc, this.txtMaDonThuoc.Text.ToString());

            this.comboTenThuoc.ResetText();
            this.txtSoLuong.ResetText();
            this.txtMota.ResetText();
            this.txtMaThuoc.ResetText();
            this.txtHinhDang.ResetText();
            this.txtGia.ResetText();
            this.txtNhomThuoc.ResetText();
            this.txtDonVi.ResetText();
            this.txtSoTon.ResetText();
            this.txtSoLuong.ResetText();
            this.txtMota.ResetText();
            this.txtHSD.ResetText();
        }

        private void comboTenThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            prescriptionBUS.GetMedicineByMedicineName(this.comboTenThuoc.Text, this.txtMaThuoc, this.txtNhomThuoc, this.txtHinhDang, this.txtDonVi, this.txtGia, this.txtHSD, this.txtSoTon);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool add = prescriptionBUS.InsertPrescription_Medicine(this.txtMaDonThuoc.Text, this.comboTenThuoc.Text, int.Parse(this.txtSoLuong.Text));
                if (add == true)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool update = prescriptionBUS.UpdatePrescription_Medicine(this.txtMaDonThuoc.Text, this.comboTenThuoc.Text, int.Parse(this.txtSoLuong.Text));
                if(update == true)
                {
                    MessageBox.Show("Cập nhập thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhập  không thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.LoadData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhập  không thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadData();
            }
        }

        private void dgvLayThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvLayThuoc.Rows[e.RowIndex];
                this.txtMaDonThuoc.Text = (string)row.Cells[0].Value;
                this.txtMaThuoc.Text = (string)row.Cells[1].Value;
                this.comboTenThuoc.Text = (string)row.Cells[2].Value;
                this.txtNhomThuoc.Text = (string)row.Cells[3].Value;
                this.txtHinhDang.Text = (string)row.Cells[4].Value;
                this.txtDonVi.Text = (string)row.Cells[5].Value.ToString();
                this.txtGia.Text = (string)row.Cells[6].Value.ToString();
                this.txtHSD.Text = (string)row.Cells[7].Value.ToString();
                this.txtSoTon.Text = (string)row.Cells[8].Value.ToString();
                this.txtSoLuong.Text = (string)(row.Cells[9].Value).ToString();
            }
            else
            {
                MessageBox.Show("Không có bộ nào trong bảng.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool delete = prescriptionBUS.DeletePrescription_Medicine(this.txtMaDonThuoc.Text, this.comboTenThuoc.Text);
                if(delete == true)
                {
                    MessageBox.Show("Xóa thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.LoadData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool save = prescriptionBUS.UpdatePrescription(this.txtMaDonThuoc.Text, this.txtMota.Text);
                if (save == true)
                {
                    DialogResult tl = MessageBox.Show("Thêm đơn thuốc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (tl == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Thêm đơn thuốc không thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.LoadData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm đơn thuốc không thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadData();
            }
        }
    }
}
