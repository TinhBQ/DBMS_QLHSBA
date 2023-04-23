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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Staff
{
    public partial class ThemThanNhan : Form
    {
        private PeopleBUS_impl peopleBUS = new PeopleBUS_impl();
        private basicInfoPatientBUS basicInfoPatientBUS = new basicInfoPatientBUS();
        
        private Person singlePerson;
        private string thisPatientID;
        private List<Person> existPeople;

        public ThemThanNhan(string patientID)
        {
            InitializeComponent();

            existPeople = peopleBUS.getAll();
            this.thisPatientID = patientID;
        }

        private void ThemThanNhan_Load(object sender, EventArgs e)
        {
            dataGridView_listPeople.Rows.Clear();

            foreach (var item in existPeople)
            {
                if (item.peopleID != thisPatientID)
                {
                    int index = dataGridView_listPeople.Rows.Add();
                    dataGridView_listPeople.Rows[index].Cells[0].Value = item.peopleID.Trim();
                    dataGridView_listPeople.Rows[index].Cells[1].Value = item.firstName.Trim();
                    dataGridView_listPeople.Rows[index].Cells[2].Value = item.lastName.Trim();
                    dataGridView_listPeople.Rows[index].Cells[3].Value = item.sex.Trim();
                }
            }
        }

        private void dataGridView_listPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnNonExist_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person();
            newPerson.firstName = txtFirstName.Text;
            newPerson.lastName = txtLastName.Text;
            newPerson.sex = cmbSex.Text;
            newPerson.birthDay = dtpBirthday.Value;
            newPerson.address = txtAddress.Text;
            newPerson.phone = txtPhone.Text;
            newPerson.cardID = txtCardID.Text;

            // Thêm ngưòi
            basicInfoPatientBUS.addRelative_nonExist(newPerson, thisPatientID);

            string msg = "Đã thêm thân nhân";
            MessageBox.Show(msg);
            Dispose();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            string id = dataGridView_listPeople.CurrentRow.Cells[0].Value.ToString();
            txtID_relative.Text = id;
            singlePerson = peopleBUS.getById(id);

            if (txtID_relative.Text.Length > 0)
            {
                basicInfoPatientBUS.addRelative_Exist(thisPatientID, txtID_relative.Text);
            }

            string msg = "Đã thêm thân nhân";
            MessageBox.Show(msg);
            Dispose();
        }
    }
}
