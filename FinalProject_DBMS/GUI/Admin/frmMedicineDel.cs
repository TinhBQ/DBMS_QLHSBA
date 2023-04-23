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
    public partial class frmMedicineDel : Form
    {
        MedicineBUS medicineBUS;
        public frmMedicineDel()
        {
            InitializeComponent();
            medicineBUS = new MedicineBUS();
        }

        private void LoadData()
        {
            medicineBUS.FindAllMedicine0(this.dgvQLTDel);

            this.txtMaThuoc.ResetText();
            this.txtTenThuoc.ResetText();
            this.txtDonVi.ResetText();
            this.txtGia.ResetText();
            this.txtHinhDang.ResetText();
            this.txtSoTon.ResetText();
            this.txtHSD.ResetText();
            this.comboNhomThuoc.ResetText();
        }

        private void frmMedicineDel_Load(object sender, EventArgs e)
        {
            this.LoadData();

        }

        private void GetDataMedicine(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                DataGridViewRow row = this.dgvQLTDel.Rows[rowIndex];
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

        private void dgvQLTDel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetDataMedicine(e.RowIndex);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtMaThuoc.Text != "")
            {
                try
                {
                    bool add = medicineBUS.RestoreMedicine(this.txtMaThuoc.Text);
                    if (add == true)
                    {
                        MessageBox.Show("Khôi phục thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Khôi phục không thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.LoadData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Khôi phục không thành công.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.LoadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn vui lòng chọn bộ mà bạn muốn xóa.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadData();
            }
        }
    }
}
