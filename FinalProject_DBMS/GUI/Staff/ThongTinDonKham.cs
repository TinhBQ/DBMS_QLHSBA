using BUS;
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
    public partial class ThongTinDonKham : Form
    {
        private string thisExamID = null;
        private ViewExamination_BUS viewExamBus = new ViewExamination_BUS();

        public ThongTinDonKham(string examID)
        {
            InitializeComponent();
            thisExamID = examID;
        }

        private void ThongTinDonKham_Load(object sender, EventArgs e)
        {
            var examView = viewExamBus.getWithID(thisExamID);

            txtExamID.Text = examView.examinateID;
            txtpPatientID.Text = examView.patientID;
            txtDoctorID.Text = examView.employeeID;
            txtPatientName.Text = examView.tenBenhNhan + " " + examView.hoBenhNhan;
            txtDoctorName.Text = examView.tenBacSi + " " + examView.tenBacSi;
            txtExamDate.Text = examView.createdAt.Value.Date.ToString();
            txtHeight.Text = examView.height.ToString();
            txtWeight.Text = examView.weight.ToString();
            txtTemperature.Text = examView.temperature.ToString();
            txtBreathing.Text = examView.breathing.ToString();
            txtBloodPressure.Text = examView.bloodPressure.ToString();
            txtVeins.Text = examView.veins.ToString();
            txtSymptom.Text = examView.symptom;
            txtPreliminaryDiagnosis.Text = examView.preliminaryDiagnosis;
            txtFinalDiagnosis.Text = examView.finalDiagnosis;
            txtTreatmentDirection.Text = examView.treatmentDirection;


            dataGridView_listMedicine.Rows.Clear();
            foreach (var item in viewExamBus.getListMedicine_withExamID(thisExamID))
            {
                int index = dataGridView_listMedicine.Rows.Add();
                dataGridView_listMedicine.Rows[index].Cells[0].Value = item.medicineID.Trim();
                dataGridView_listMedicine.Rows[index].Cells[1].Value = item.medicineName.Trim();
                dataGridView_listMedicine.Rows[index].Cells[2].Value = item.quanlity.ToString();
            }
        }
    }
}
