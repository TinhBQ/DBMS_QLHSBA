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
    public partial class FrmDoctors : Form
    {
        string err;
        Admin_DoctorsBUS dbbs = new Admin_DoctorsBUS();
        public FrmDoctors()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            
                dgvInforDoctor.DataSource = dbbs.getBacSi();
                dgvInforDoctor.AutoResizeColumns();
            
        }


        private void FrmDoctors_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dbbs.InsertBacSi(txtFirstName.Text, txtLastname.Text, txtGioitinh.Text,
                                        txtBirthday.Text, txtaddress.Text, txtphone.Text, txtCard.Text
                                        , txtidkhoa.Text, ref err);
                MessageBox.Show("Successful", "Thêm thành công");
                LoadData();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Không thể thêm");
            }
        }

        private void dgvInforDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lưu lại dòng dữ liệu vừa kích chọn
            DataGridViewRow row = this.dgvInforDoctor.Rows[e.RowIndex];
            //Đưa dữ liệu vào textbox
            txtid.Text = row.Cells[0].Value.ToString();
            txtFirstName.Text = row.Cells[1].Value.ToString();
            txtLastname.Text = row.Cells[2].Value.ToString();
            txtGioitinh.Text = row.Cells[3].Value.ToString();
            txtBirthday.Text = row.Cells[4].Value.ToString();
            txtaddress.Text = row.Cells[5].Value.ToString();
            txtphone.Text = row.Cells[6].Value.ToString();
            txtCard.Text = row.Cells[7].Value.ToString();
            txtidkhoa.Text = row.Cells[9].Value.ToString();

            //dt.Columns.Add("Mã nhân viên");
            //dt.Columns.Add("Last Name");
            //dt.Columns.Add("First Name");
            //dt.Columns.Add("Giới tính");
            //dt.Columns.Add("Ngày sinh");
            //dt.Columns.Add("Địa chỉ");
            //dt.Columns.Add("Số điện thoại");
            //dt.Columns.Add("CMND/CCCD");
            //dt.Columns.Add("Chức vụ");
            //dt.Columns.Add("ID Khoa");

            //Không cho phép sửa trường STT
            txtid.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
              dbbs.UpdateBacSi(txtFirstName.Text, txtLastname.Text, txtGioitinh.Text,
                                        txtBirthday.Text, txtaddress.Text, txtphone.Text, txtCard.Text
                                        , txtidkhoa.Text, txtid.Text, ref err);
                MessageBox.Show("Successful", "Sửa thành công");
                LoadData();
            
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
