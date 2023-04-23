using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace GUI.Admin
{
    public partial class FrmPatients : Form
    {
        string err;
        Admin_PatientBUS dbbn = new Admin_PatientBUS();
        public FrmPatients()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dgvInfoPatien.DataSource = dbbn.getBenhNhan();
            dgvInfoPatien.AutoResizeColumns();
        }

        private void FrmPatients_Load(object sender, EventArgs e)
        {
            // 
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                dbbn.InsertBenhNhan(txtFirstName.Text, txtLastname.Text, txtGioitinh.Text,
                                        txtBirthday.Text, txtaddress.Text, txtphone.Text, txtCard.Text,
                                        txtjob.Text, txtbhyt.Text, txtlydo.Text, ref err);

                MessageBox.Show("Successful", "Thêm thành công");
                LoadData();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dbbn.UpdateBenhNhan(txtFirstName.Text, txtLastname.Text, txtGioitinh.Text,
                                    txtBirthday.Text, txtaddress.Text, txtphone.Text, txtCard.Text,
                                    txtjob.Text, txtbhyt.Text, txtlydo.Text, txtId.Text, ref err);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Chắc chắn thoát?(Y/N)", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void dgvInfoPatien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lưu lại dòng dữ liệu vừa kích chọn
            DataGridViewRow row = this.dgvInfoPatien.Rows[e.RowIndex];
            //Đưa dữ liệu vào textbox
            txtId.Text = row.Cells[0].Value.ToString();
            txtFirstName.Text = row.Cells[1].Value.ToString();
            txtLastname.Text = row.Cells[2].Value.ToString();
            txtGioitinh.Text = row.Cells[3].Value.ToString();
            txtBirthday.Text = row.Cells[4].Value.ToString();
            txtaddress.Text = row.Cells[5].Value.ToString();
            txtphone.Text = row.Cells[6].Value.ToString();
            txtCard.Text = row.Cells[7].Value.ToString();
            txtjob.Text = row.Cells[8].Value.ToString();
            txtbhyt.Text = row.Cells[9].Value.ToString();
            txtlydo.Text = row.Cells[10].Value.ToString();

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
            txtId.Enabled = false;
        }
    }
}
