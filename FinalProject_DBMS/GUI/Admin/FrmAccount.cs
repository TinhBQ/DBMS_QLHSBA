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

namespace GUI
{
    public partial class FrmAccount : Form
    {
        string err;
        DangNhapBUS dbacc = new DangNhapBUS();
        public FrmAccount()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                dgvAccount.DataSource = dbacc.getAccount();
                dgvAccount.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Không thể lấy dữ liệu");
            }
        }

        public void LoadData2()
        {
            try
            {
                dgvEmp.DataSource = dbacc.getNhanvien();
                dgvEmp.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Không thể lấy dữ liệu");
            }
        }

        public void LoadData3()
        {
            try
            {
                dgvDoctor.DataSource = dbacc.getBacSi();
                dgvDoctor.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Không thể lấy dữ liệu");
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dbacc.InsertAccount(txtName.Text, txtPass.Text, Convert.ToInt32(txtRole.Text));
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
          
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvAccount.Rows[e.RowIndex];
            //Đưa dữ liệu vào textbox
            txtName.Text = row.Cells[0].Value.ToString();
            txtPass.Text = row.Cells[1].Value.ToString();
            txtRole.Text = row.Cells[2].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                dbacc.DeleteAccount(txtName.Text);
                LoadData();
                MessageBox.Show("Successful", "Xóa");
            }
            catch
            {
                MessageBox.Show("Lỗi", "Không xóa được");
            }
            
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSBADataSet.People' table. You can move, or remove it, as needed.
       
            LoadData();
            LoadData2();
            LoadData3();
        }

        private void dgvEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvEmp.Rows[e.RowIndex];
            txtName.Text = row.Cells[0].Value.ToString();
        }

        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDoctor.Rows[e.RowIndex];
            txtName.Text = row.Cells[0].Value.ToString();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                dbacc.UpdateAccount(txtName.Text, txtPass.Text, Convert.ToInt32(txtRole.Text));
                LoadData();
                MessageBox.Show("Successful", "Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi", "Không sửa được");
            }
        }
    }
}
