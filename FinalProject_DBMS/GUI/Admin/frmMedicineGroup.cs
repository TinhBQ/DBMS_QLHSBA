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
    public partial class frmMedicineGroup : Form
    {
        MedicineGroupBUS medicineGroupBUS;
        public frmMedicineGroup()
        {
            InitializeComponent();
            medicineGroupBUS = new MedicineGroupBUS();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtMedGName.Text != "")
            {
                try
                {
                    bool add = medicineGroupBUS.InsertMedicineGroup((string)this.txtMedGName.Text);
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

        private void LoadData()
        { 
            this.txtMedGName.ResetText();
            this.txtMedGID.ResetText();
            medicineGroupBUS.FindAllMedicineGroup(this.dgvMedG);
        }

        private void GetDataMedicineGroup(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMedG.Rows[rowIndex];
                this.txtMedGID.Text = (string)row.Cells[0].Value;
                this.txtMedGName.Text = (string)row.Cells[1].Value;
            }
            else
            {
                MessageBox.Show("Không có bộ nào trong bảng.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void btnUpate_Click(object sender, EventArgs e)
        {
            if (this.txtMedGName.Text != "" || this.txtMedGID.Text != "")
            {
                try
                {
                    bool update = medicineGroupBUS.UpdateMedicineGroup((string)this.txtMedGID.Text, (string)this.txtMedGName.Text);
                    if (update)
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
                MessageBox.Show("Bạn vui lòng chọn bộ trong bảng cần cập nhật.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadData();
            }     
        }

        private void btnDetele_Click(object sender, EventArgs e)
        {
            if (this.txtMedGName.Text != "" || this.txtMedGID.Text != "")
            {
                try
                {
                    bool update = medicineGroupBUS.DeleteMedicineGroup((string)this.txtMedGID.Text);
                    if (update)
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
                MessageBox.Show("Bạn vui lòng chọn bộ trong bảng cần xóa.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadData();
            }
        }

        private void frmMedicineGroup_Load(object sender, EventArgs e)
        {
            this.LoadData();
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

        private void dgvMedG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetDataMedicineGroup(e.RowIndex);
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            frmMedicine a = new frmMedicine();
            a.ShowDialog();
        }
    }
}
