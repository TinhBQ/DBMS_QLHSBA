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

namespace GUI.Admin
{
    public partial class frmMedicine : Form
    {
        MedicineBUS medicineBUS;
        public frmMedicine()
        {
            InitializeComponent();
            medicineBUS = new MedicineBUS();
        }

        private void frmMedicine_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            medicineBUS.GetDataMedicineGroup_ComboBox(this.comboNhomThuoc);
            medicineBUS.FindAllMedicine1(this.dgvQLT);

            this.txtMaThuoc.ResetText();
            this.txtTenThuoc.ResetText();
            this.txtDonVi.ResetText();
            this.txtGia.ResetText();
            this.txtHinhDang.ResetText();
            this.txtSoTon.ResetText();
            this.txtHSD.ResetText();
            this.comboNhomThuoc.ResetText();
        }

        private void dgvQLT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetDataMedicineGroup(e.RowIndex);
        }

        private void GetDataMedicineGroup(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                DataGridViewRow row = this.dgvQLT.Rows[rowIndex];
                this.txtMaThuoc.Text = (string)row.Cells[0].Value;
                this.txtTenThuoc.Text = (string)row.Cells[1].Value;
                this.txtDonVi.Text = (string)row.Cells[2].Value;
                this.txtGia.Text = (string)row.Cells[3].Value.ToString();
                this.txtHSD.Text = (string)row.Cells[4].Value.ToString();
                this.txtSoTon.Text = (string)row.Cells[5].Value.ToString();
                this.txtHinhDang.Text = (string)row.Cells[6].Value;
                this.comboNhomThuoc.Text = (string)row.Cells[7].Value;
            }
            else
            {
                MessageBox.Show("Không có bộ nào trong bảng.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.IsCheck())
            {
                try
                {
                    bool add = medicineBUS.InsertMedicine(this.txtTenThuoc.Text, this.txtDonVi.Text, int.Parse(this.txtGia.Text), int.Parse(this.txtHSD.Text), int.Parse(this.txtSoTon.Text), this.txtHinhDang.Text, this.comboNhomThuoc.Text);
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
            else
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadData();
            }    
            
        }

        private bool IsCheck()
        {
            if (this.txtTenThuoc.Text == "" ||
                this.txtHinhDang.Text == "" ||
                this.txtDonVi.Text == "" ||
                this.txtGia.Text == "" ||
                this.txtHSD.Text == "" ||
                this.txtSoTon.Text == "" ||
                this.comboNhomThuoc.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtMaThuoc.Text != "")
            {
                try
                {
                    bool add = medicineBUS.UpdateMedicine(this.txtTenThuoc.Text, this.txtDonVi.Text, int.Parse(this.txtGia.Text), int.Parse(this.txtHSD.Text), int.Parse(this.txtSoTon.Text), this.txtHinhDang.Text, this.comboNhomThuoc.Text, this.txtMaThuoc.Text);
                    if (add == true)
                    {
                        MessageBox.Show("Cập nhật thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.LoadData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật không thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.LoadData();
                }
            } 
            else
            {
                MessageBox.Show("Bạn vui lòng chọn bộ mà bạn muốn cập nhật.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadData();
            }    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.txtMaThuoc.Text != "")
            {
                try
                {
                    bool add = medicineBUS.DeleteMedicine1(this.txtMaThuoc.Text);
                    if (add == true)
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
            else
            {
                MessageBox.Show("Bạn vui lòng chọn bộ mà bạn muốn xóa.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadData();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc muốn THOÁT?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void findMed_txt_TextChanged(object sender, EventArgs e)
        {
            medicineBUS.FindMedicineBymedicineNameLike(this.dgvQLT, this.findMed_txt);
        }

        private void btnMediDel_Click(object sender, EventArgs e)
        {
            frmMedicineDel a = new frmMedicineDel();
            a.ShowDialog();
        }
    }
}
