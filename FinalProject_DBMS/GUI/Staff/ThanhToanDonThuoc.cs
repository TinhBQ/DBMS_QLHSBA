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

namespace GUI.Staff
{
    public partial class ThanhToanDonThuoc : Form
    {
        private string patientID;
        private string employeeID;
        private string examID;

        private ViewExamination_BUS viewExamBUS = new ViewExamination_BUS();
        private basicInfoPatientBUS basicInfoPatientBUS = new basicInfoPatientBUS();

        public ThanhToanDonThuoc(string patientID, string employeeID)
        {
            InitializeComponent();
            this.patientID = patientID;
            this.employeeID = employeeID;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewHistory.RowCount == 0)
                {
                    MessageBox.Show("Không có đơn khám để thanh toán");
                    return;
                }
                if (examID.Length < 0)
                {
                    MessageBox.Show("Chưa chọn đơn khám");
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Xác nhận thanh toán", "Thanh toán", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        viewExamBUS.payMedicine_withExamID(patientID, employeeID, examID);

                        MessageBox.Show("Đã thanh toán");
                        refresh();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
            }catch (Exception) { }
            refresh();
        }

        private void ThanhToanDonThuoc_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            dataGridViewHistory.Rows.Clear();
            foreach (var item in viewExamBUS.getPrecription_NotYet(patientID))
            {
                int index = dataGridViewHistory.Rows.Add();
                dataGridViewHistory.Rows[index].Cells[0].Value = item.examinateID.Trim();
                dataGridViewHistory.Rows[index].Cells[1].Value = item.TenBacSi.Trim() + " " + item.HoBacSi.Trim();
                dataGridViewHistory.Rows[index].Cells[2].Value = item.createdAt.Value.Date.ToString();
            }

            dataGridView_listMedicine.Rows.Clear();
            lb_totayPay.Text = "";
        }

        private void dataGridViewHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.examID = dataGridViewHistory.CurrentRow.Cells[0].Value.ToString();

                dataGridView_listMedicine.Rows.Clear();

                foreach (var item in viewExamBUS.getListMedicine_withExamID(examID))
                {
                    int index = dataGridView_listMedicine.Rows.Add();
                    dataGridView_listMedicine.Rows[index].Cells[0].Value = item.prescriptionID.Trim();
                    dataGridView_listMedicine.Rows[index].Cells[1].Value = item.medicineName.Trim();
                    dataGridView_listMedicine.Rows[index].Cells[2].Value = item.medicinePrice.ToString();
                    dataGridView_listMedicine.Rows[index].Cells[3].Value = item.quanlity.ToString();
                    dataGridView_listMedicine.Rows[index].Cells[4].Value = item.totalPrice.ToString();
                }

                lb_totayPay.Text = String.Format("{0:0,0}", viewExamBUS.getTotalPay(examID));
            }
            catch (Exception)
            {
            }
        }
    }
}
