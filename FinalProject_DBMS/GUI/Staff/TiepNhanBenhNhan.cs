using BUS;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.Staff
{
    public partial class TiepNhanBenhNhan : Form
    {
        private basicInfoPatientBUS basicInfoPatient_dataBUS = new basicInfoPatientBUS();
        private ViewExamination_BUS viewExamination_BUS = new ViewExamination_BUS();
        private Exam_uService_BUS exam_UService_BUS = new Exam_uService_BUS();

        private List<View_Patients> basicInfo_Patients = new List<View_Patients>();
        private List<func_getExamHistory_Result> basicInfo_PatientHistory = new List<func_getExamHistory_Result>();
        
        private Employee employee;
        private View_Patients singlePatient = new View_Patients();
        private func_getExamWithID_Result singleExam = null;
        private Employee employee1;

        public TiepNhanBenhNhan(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void refreshGrid()
        {
            basicInfo_Patients = basicInfoPatient_dataBUS.getAll();

            dataGridViewInfoPatient.Rows.Clear();

            // TABLE BASIC INFO
            foreach (var item in basicInfo_Patients)
            {
                int index = dataGridViewInfoPatient.Rows.Add();
                dataGridViewInfoPatient.Rows[index].Cells[0].Value = item.patientID.Trim();
                dataGridViewInfoPatient.Rows[index].Cells[1].Value = item.patientFirstName.Trim();
                dataGridViewInfoPatient.Rows[index].Cells[2].Value = item.patientLastname.Trim();
                dataGridViewInfoPatient.Rows[index].Cells[3].Value = item.sex.Trim();
                dataGridViewInfoPatient.Rows[index].Cells[4].Value = item.birthDay.ToString();
                dataGridViewInfoPatient.Rows[index].Cells[5].Value = item.address.Trim();
                dataGridViewInfoPatient.Rows[index].Cells[6].Value = item.phone.Trim();
                dataGridViewInfoPatient.Rows[index].Cells[7].Value = item.cardID.Trim();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIDpatient.Text.Length < 0)
            {
                MessageBox.Show("Chọn bệnh nhân đã");
            }
            else
            {
                ThongtinBenhNhan thongtinBenhNhan = new ThongtinBenhNhan(singlePatient);
                thongtinBenhNhan.ShowDialog();
            }

            this.Refresh(); 
        }

        private void TiepNhanBenhNhan_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshGrid();
            txtIDpatient.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            cmbSex.SelectedIndex = 0;
            dtpBirthday.Value = DateTime.Today;
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtCardID.Text = "";
            txtJob.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThongtinBenhNhan themBenhNhan = new ThongtinBenhNhan(null);
            themBenhNhan.ShowDialog();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            if (txtIDpatient.Text.Length > 0)
            {
                // Tạo exam 
                exam_UService_BUS.Submit_Exam(singlePatient.patientID, employee.employeeID);

                string msg = "Đã thêm bệnh nhân vào hàng đợi";
                MessageBox.Show(msg);

                btnExam.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chọn bệnh nhân đã");
            }
        }

        private void dataGridViewInfoPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExam.Enabled = true;
            try
            {
                string rowIndex = dataGridViewInfoPatient.CurrentRow.Cells[0].Value.ToString();
                singlePatient = basicInfoPatient_dataBUS.findByID(rowIndex);

                txtIDpatient.Text = singlePatient.patientID;
                txtFirstName.Text = singlePatient.patientFirstName;
                txtLastName.Text = singlePatient.patientLastname;
                cmbSex.SelectedIndex = cmbSex.Items.IndexOf(singlePatient.sex);
                dtpBirthday.Value = singlePatient.birthDay;
                txtAddress.Text = singlePatient.address;
                txtPhone.Text = singlePatient.phone;
                txtCardID.Text = singlePatient.cardID;
                txtJob.Text = singlePatient.patientJob;
            }
            catch (Exception)
            {
                // Do nothing
            }
        }

        private void btnUsingService_Click(object sender, EventArgs e)
        {
            if (txtIDpatient.Text.Length > 0)
            {
                SuDungDichVu suDungDichVu = new SuDungDichVu(txtIDpatient.Text, this.employee.employeeID);
                suDungDichVu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chọn bệnh nhân đã");
            }
        }

        private void btnPay_service_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDpatient.Text.Length < 1)
                {
                    MessageBox.Show("Chọn bệnh nhân chưa thế?");
                }
                else
                {
                    ThanhToanSuDungDichVu thanhToanDichVu = new ThanhToanSuDungDichVu(txtIDpatient.Text, employee.employeeID);
                    thanhToanDichVu.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnPay_medicine_Click(object sender, EventArgs e)
        {
            ThanhToanDonThuoc thanhToanDonThuoc = new ThanhToanDonThuoc(singlePatient.patientID, employee.employeeID);
            thanhToanDonThuoc.ShowDialog();
        }
    }
}
