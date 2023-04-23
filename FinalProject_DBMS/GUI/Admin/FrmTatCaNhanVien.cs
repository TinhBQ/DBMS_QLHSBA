using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI.Admin
{
    public partial class FrmTatCaNhanVien : Form
    {
        string err;
        Admin_EmployeeBUS dbnv = new Admin_EmployeeBUS();
        public FrmTatCaNhanVien()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                dgvInfoEmployee.DataSource = dbnv.getNhanvien();
                dgvInfoEmployee.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không truy xuất được dữ liệu", "Lỗi");
            }
        }

        private void FrmTatCaNhanVien_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dbnv.InsertNhanVien(txtfirst.Text, txtLastname.Text, txtGioitinh.Text,
                                        txtBirthday.Text, txtaddress.Text, txtsdt.Text, txtCard.Text,
                                        txtidkhoa.Text, ref err);
                LoadData();
                MessageBox.Show("Successful", "Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi", "Không thêm được");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                dbnv.UpdateNhanVien(txtfirst.Text, txtLastname.Text, txtGioitinh.Text,
                                        txtBirthday.Text, txtaddress.Text, txtsdt.Text, txtCard.Text,
                                        txtidkhoa.Text, txtidpeo.Text, ref err);
                LoadData();
                MessageBox.Show("Successful", "Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi", "Không sửa được");
            }
        }

        private void dgvInfoEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvInfoEmployee.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtidpeo.Text = row.Cells[0].Value.ToString();
                txtLastname.Text = row.Cells[1].Value.ToString();
                txtfirst.Text = row.Cells[2].Value.ToString();
                txtGioitinh.Text = row.Cells[3].Value.ToString();
                txtBirthday.Text = row.Cells[4].Value.ToString();
                txtaddress.Text = row.Cells[5].Value.ToString();
                txtsdt.Text = row.Cells[6].Value.ToString();
                txtCard.Text = row.Cells[7].Value.ToString();
                txtidkhoa.Text = row.Cells[9].Value.ToString();

                //Không cho phép sửa trường STT
                txtidpeo.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Chắc chắn thoát?(Y/N)", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }
    }
}
