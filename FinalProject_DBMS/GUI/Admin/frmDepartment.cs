using BUS;
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

namespace GUI.Admin
{
    public partial class frmDepartment : Form
    {
        departmentBUS departmentBUS;
     
        public frmDepartment()
        {
            InitializeComponent();
            departmentBUS = new departmentBUS();
        }

        public void LoadData()
        {
            try
            {
                departmentBUS.FindAllDepartment1(dgvDepartment);
                dgvDepartment.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không thể lấy thông tin!", "Lỗi");
            }
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetDataDepartment(e.RowIndex);
        }

        private void GetDataDepartment(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDepartment.Rows[rowIndex];
                this.ID_dep_txt.Text = (string)row.Cells[0].Value.ToString();
                this.name_dep_txt.Text = (string)row.Cells[1].Value.ToString();
                this.createAt_txt.Text = (string)row.Cells[2].Value.ToString();
                this.updateAt_txt.Text = Convert.ToString(row.Cells[3].Value);
            }
            else
            {
                MessageBox.Show("Không có bộ nào trong bảng.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            if (this.name_dep_txt.Text != "")
            {
                try
                {
                    bool ins = departmentBUS.InsertDepartment(this.name_dep_txt.Text);
                    if (ins == true)
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
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadData();
            }
        }

        private void Sua_btn_Click(object sender, EventArgs e)
        {
            if (this.name_dep_txt.Text != "")
            {
                try
                {
                    bool up = departmentBUS.UpdateDepartment(this.name_dep_txt.Text, this.ID_dep_txt.Text);
                    if (up == true)
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

        private void xoa_btn_Click(object sender, EventArgs e)
        {
            if (this.name_dep_txt.Text != "")
            {
                try
                {
                    bool del = departmentBUS.DeleteDepartment(this.ID_dep_txt.Text);
                    if (del == true)
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

        private void findDep_txt_TextChanged(object sender, EventArgs e)
        {
            departmentBUS.FindAllDepartment1BydepartmentNameLike(dgvDepartment, findDep_txt);
        }
    }
}
