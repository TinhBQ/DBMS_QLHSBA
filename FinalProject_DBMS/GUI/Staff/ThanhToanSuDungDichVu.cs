using BUS.impl;
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
    public partial class ThanhToanSuDungDichVu : Form
    {
        UsingServiceBUS_impl usingServiceBUS = new UsingServiceBUS_impl();
        string patientID;
        string employeeID;

        public ThanhToanSuDungDichVu(string patientID, string employeeID)
        {
            InitializeComponent();
            this.patientID = patientID;
            this.employeeID = employeeID;
            lb_totayPay.Text = "00";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận thanh toán", "Thanh toán", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                usingServiceBUS.payService(patientID, employeeID);

                MessageBox.Show("Đã thanh toán");
                dataGridView_usingService.Rows.Clear();
                lb_totayPay.Text = "00";
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void payUsingService_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView_usingService.Rows.Clear();

                // TABLE BASIC INFO
                foreach (var item in usingServiceBUS.GetNotYet_Results(patientID))
                {
                    int index = dataGridView_usingService.Rows.Add();
                    dataGridView_usingService.Rows[index].Cells[0].Value = item.serviceID.Trim();
                    dataGridView_usingService.Rows[index].Cells[1].Value = item.serviceName.Trim();
                    dataGridView_usingService.Rows[index].Cells[2].Value = String.Format("{0:0,0}", item.unitPrice);
                    dataGridView_usingService.Rows[index].Cells[3].Value = item.quantity.ToString();
                    dataGridView_usingService.Rows[index].Cells[4].Value = String.Format("{0:0,0}", item.payTotal);
                    dataGridView_usingService.Rows[index].Cells[5].Value = item.createdAt.Value.Date;
                }

                lb_totayPay.Text = String.Format("{0:0,0}", usingServiceBUS.getTotalPay(patientID));
            }
            catch (Exception)
            {
            }
        }
    }
}
