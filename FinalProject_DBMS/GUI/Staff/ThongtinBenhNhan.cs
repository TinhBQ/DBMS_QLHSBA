using BUS;
using BUS.impl;
using DAL;
using DAL.Model;
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
    public partial class ThongtinBenhNhan : Form
    {
        private View_Patients basicInfo_Patient = null;
        private basicInfoPatientBUS basicInfoPatientBUS = new basicInfoPatientBUS();

        public ThongtinBenhNhan(View_Patients basicInfo_Patient)
        {
            InitializeComponent();

            if (basicInfo_Patient != null)
            {
                this.basicInfo_Patient = basicInfo_Patient;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnAddRelative.Enabled = false;
            }
        }

        private void ThongtinBenhNhan_Load(object sender, EventArgs e)
        {
            try
            {
                if (basicInfo_Patient != null)
                {
                    txtIDpatient.Text = basicInfo_Patient.patientID;
                    txtFirstName.Text = basicInfo_Patient.patientFirstName;
                    txtLastName.Text = basicInfo_Patient.patientLastname;
                    cmbSex.SelectedIndex = cmbSex.Items.IndexOf(basicInfo_Patient.sex);
                    dtpBirthday.Value = basicInfo_Patient.birthDay;
                    txtAddress.Text = basicInfo_Patient.address;
                    txtPhone.Text = basicInfo_Patient.phone;
                    txtCardID.Text = basicInfo_Patient.cardID;
                    txtJob.Text = basicInfo_Patient.patientJob;
                    txtHealthInsurance.Text = basicInfo_Patient.healthInsurance;
                    txtReason.Text = basicInfo_Patient.reason;


                    dataGridView_Relatives.Rows.Clear();

                    foreach (var item in basicInfoPatientBUS.getRelatives(this.basicInfo_Patient.patientID))
                    {
                        int index = dataGridView_Relatives.Rows.Add();
                        dataGridView_Relatives.Rows[index].Cells[0].Value = item.relativeID;
                        dataGridView_Relatives.Rows[index].Cells[1].Value = item.firstName + " " + item.lastName;
                    }

                    dataGridViewHistory.Rows.Clear();
                    foreach (var item in basicInfoPatientBUS.GetHistoryExams(this.basicInfo_Patient.patientID))
                    {
                        int index = dataGridViewHistory.Rows.Add();
                        dataGridViewHistory.Rows[index].Cells[0].Value = item.examinateID.Trim();
                        dataGridViewHistory.Rows[index].Cells[1].Value = item.tenBacSi.Trim() + " " + item.hoBacSi.Trim();
                        dataGridViewHistory.Rows[index].Cells[2].Value = item.createdAt.Value.Date.ToString();
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Hiển thị lỗi");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                View_Patients newInfo = basicInfo_Patient;

                // Update thuộc tính
                newInfo.patientFirstName = txtFirstName.Text;
                newInfo.patientLastname = txtLastName.Text;
                newInfo.sex = cmbSex.SelectedItem.ToString();
                newInfo.birthDay = dtpBirthday.Value;
                newInfo.address = txtAddress.Text;
                newInfo.phone = txtPhone.Text;
                newInfo.cardID = txtCardID.Text;
                newInfo.patientJob = txtJob.Text;
                newInfo.healthInsurance = txtHealthInsurance.Text;
                newInfo.reason = txtReason.Text;

                // Save
                basicInfoPatientBUS.Update(newInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Cập nhật thành công");

        }

        private void btnAddRelative_Click(object sender, EventArgs e)
        {
            ThemThanNhan themThanNhan = new ThemThanNhan(basicInfo_Patient.patientID);
            themThanNhan.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PatientBUS_impl patientBUS = new PatientBUS_impl();
            Person newPerson = new Person();
            newPerson.firstName = txtFirstName.Text;
            newPerson.lastName = txtLastName.Text;
            newPerson.sex = cmbSex.Text;
            newPerson.birthDay = dtpBirthday.Value;
            newPerson.address = txtAddress.Text;
            newPerson.phone = txtPhone.Text;
            newPerson.cardID = txtCardID.Text;

            Patient newPatient = new Patient();
            newPatient.patientJob = txtJob.Text;
            newPatient.healthInsurance = txtHealthInsurance.Text;
            newPatient.reason = txtReason.Text;

            patientBUS.Create(newPerson, newPatient);

            string msg = "Đã thêm bệnh nhân";
            MessageBox.Show(msg);
            Dispose();
        }

        private void btnInfoExam_Click(object sender, EventArgs e)
        {
            try
            {
                string idExam = dataGridViewHistory.CurrentRow.Cells[0].Value.ToString();
                if (idExam.Length < 0)
                {
                    MessageBox.Show("Chưa chọn đơn khám");
                }
                else
                {
                    ThongTinDonKham thongTinDonKham = new ThongTinDonKham(idExam);
                    thongTinDonKham.ShowDialog();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
