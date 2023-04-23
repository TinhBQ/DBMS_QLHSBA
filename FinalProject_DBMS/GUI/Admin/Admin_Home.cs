using GUI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void btnEm_Click(object sender, EventArgs e)
        {
            FrmTatCaNhanVien nv = new FrmTatCaNhanVien();
            this.Hide();
            nv.ShowDialog();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            FrmDoctors nv = new FrmDoctors();
            this.Hide();
            nv.ShowDialog();
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FrmTatCaNhanVien em = new FrmTatCaNhanVien();
            em.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            FrmDoctors nv = new FrmDoctors();
            nv.ShowDialog();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            frmMedicineGroup nv = new frmMedicineGroup();
            nv.ShowDialog();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            frmDepartment nv = new frmDepartment();
            nv.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            FrmAccount acc = new FrmAccount();
            acc.ShowDialog();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            frmService dv = new frmService();
            dv.ShowDialog();
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
