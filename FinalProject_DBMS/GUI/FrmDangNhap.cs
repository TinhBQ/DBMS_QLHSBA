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
using GUI.Admin;
using GUI.Doctor;
using GUI.Staff;

namespace GUI
{
    public partial class FrmDangNhap : Form
    {
        string err;
        DangNhapBUS dbdn = new DangNhapBUS();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtid == null || txtPassword == null)
            {
                MessageBox.Show("Thông báo", "Trường Username hoặc password không thể rỗng!");
            }
            else
            {
                try
                {
                    dbdn.getLogin(txtid.Text, txtPassword.Text);
                    {

                        if (dbdn.getRole(txtid.Text) == 1)
                        {
                            Admin_Home am = new Admin_Home();
                            
                            am.ShowDialog();
                        }
                        //role=doctor
                        if (dbdn.getRole(txtid.Text) == 2)
                        {
                            frmExamine am = new frmExamine(txtid.Text);
                          
                            am.ShowDialog();
                        }
                        //role = nhan vien
                        if (dbdn.getRole(txtid.Text) == 3)
                        {
                            EmployeeBUS bruh = new EmployeeBUS();
                            TiepNhanBenhNhan am = new TiepNhanBenhNhan(bruh.findByID(txtid.Text));
                            am.ShowDialog();
                        }

                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Lỗi!!!");
                }
            }
            
        }
    }
}
