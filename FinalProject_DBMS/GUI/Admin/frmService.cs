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
    public partial class frmService : Form
    {
        ServiceBUS serviceBUS;
        public frmService()
        {
            InitializeComponent();
            serviceBUS = new ServiceBUS();
        }

        private void LoadData()
        {
            serviceBUS.FindAllService(dgvDV);

            this.txtDVID.ResetText();
            this.txtDVName.ResetText(); ;
            this.txtGia.ResetText();
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void GetDataService(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDV.Rows[rowIndex];
                this.txtDVID.Text = (string)row.Cells[0].Value;
                this.txtDVName.Text = (string)row.Cells[1].Value;
                this.txtGia.Text = Convert.ToString(row.Cells[2].Value);
            }
            else
            {
                MessageBox.Show("Không có bộ nào trong bảng.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetDataService(e.RowIndex);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtDVName.Text != "" && this.txtGia.Text != "")
            {
                try
                {
                    bool add = serviceBUS.InsertService(this.txtDVName.Text, int.Parse(this.txtGia.Text));
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

        private void btnUpate_Click(object sender, EventArgs e)
        {
            if (this.txtDVName.Text != "" && this.txtGia.Text != "")
            {
                try
                {
                    bool up = serviceBUS.UpdateService(this.txtDVName.Text, int.Parse(this.txtGia.Text), this.txtDVID.Text);
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

        private void btnDetele_Click(object sender, EventArgs e)
        {
            if (this.txtDVID.Text != "")
            {
                try
                {
                    bool del = serviceBUS.DeleteService(this.txtDVID.Text);
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

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            serviceBUS.FindAllServiceByServiceNameLike(dgvDV, this.txtTK);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc muốn THOÁT?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
