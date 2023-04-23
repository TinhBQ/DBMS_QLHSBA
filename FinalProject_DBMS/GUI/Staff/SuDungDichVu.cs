using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using BUS.impl;
using DAL;
using DAL.Model;

namespace GUI.Staff
{
    public partial class SuDungDichVu : Form
    {
        // INIT values
        private Patient patient;
        private Employee employee;
        private int formLoad = 1;

        // BUS values
        private PatientBUS_impl patientBUS = new PatientBUS_impl();
        private EmployeeBUS employeeBUS = new EmployeeBUS();
        private ServiceBUS_impl serviceBUS = new ServiceBUS_impl();
        private Exam_uService_BUS examBUS = new Exam_uService_BUS();

        // table values
        private List<Service> services = new List<Service>();
        private List<tempService> usingServices = new List<tempService>();

        public SuDungDichVu(string patientID, string employeeID)
        {
            InitializeComponent();

            this.patient = patientBUS.getById(patientID);
            this.employee = employeeBUS.findByID(employeeID);
        }

        private void SuDungDichVu_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void refreshTable()
        {
            formLoad = 1;
            usingServices.Clear();
            dataGridView_Service.Rows.Clear();
            dataGridView_usingService.Rows.Clear();

            services = serviceBUS.getAll();

            List<func_getListService_notYet_Result> notYet = examBUS.notYet(patient.patientID);
            foreach (var item in notYet)
            {
                usingServices.Add(new tempService(int.Parse(item.usingServiceID.ToString()), item.serviceID, item.serviceName, item.quantity == null ? default(byte) : item.quantity.Value));
            }

            foreach (var item in services)
            {
                int index = dataGridView_Service.Rows.Add();
                dataGridView_Service.Rows[index].Cells[0].Value = item.serviceID;
                dataGridView_Service.Rows[index].Cells[1].Value = item.serviceName;
                dataGridView_Service.Rows[index].Cells[2].Value = item.servicePrice;
            }

            foreach (var item in usingServices)
            {
                int index = dataGridView_usingService.Rows.Add();
                dataGridView_usingService.Rows[index].Cells[0].Value = item.serviceID.ToString();
                dataGridView_usingService.Rows[index].Cells[1].Value = item.serviceName.ToString();
                dataGridView_usingService.Rows[index].Cells[2].Value = item.quantity.ToString();
            }
            formLoad = 0;
        }

        private int checkExist(string id)
        {
            int index = -1;
            foreach (var item in usingServices)
            {
                index++;
                if (item.serviceID.Equals(id))
                {
                    return index;
                }
            }

            return -1;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            formLoad = 1;
            string serviceID = dataGridView_Service.CurrentRow.Cells[0].Value.ToString();
            string serviceName = dataGridView_Service.CurrentRow.Cells[1].Value.ToString();

            int index = checkExist(serviceID);
            if (index != -1)
            {
                byte quatity = ++ this.usingServices[index].quantity;
                examBUS.UpdateUsingService(usingServices[index].usingServiceID, usingServices[index].quantity);
            }
            else
            {
                examBUS.InsertUsingService(this.patient.patientID, serviceID, 1);
            }

            refreshTable();
        }

        private void dataGridView_Service_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            formLoad = 1;
            string serviceID = dataGridView_usingService.CurrentRow.Cells[0].Value.ToString();

            int index = 0;
            int id;
            foreach (var item in usingServices)
            {
                if (item.serviceID.Equals(serviceID))
                {
                    id = item.usingServiceID;
                    examBUS.removeUsingService(id);
                    break;
                }
                index++;
            }
            refreshTable();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView_usingService_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (formLoad != 1)
            {
                string serviceID = dataGridView_usingService.CurrentRow.Cells[0].Value.ToString();
                //string serviceName = dataGridView_usingService.CurrentRow.Cells[1].Value.ToString();
                Byte quantity = Byte.Parse(dataGridView_usingService.CurrentRow.Cells[2].Value.ToString());

                int index = 0;
                int id;
                foreach (var item in usingServices)
                {
                    if (item.serviceID.Equals(serviceID))
                    {
                        formLoad = 1;
                        id = item.usingServiceID;
                        examBUS.UpdateUsingService(id, quantity);
                        break;
                    }
                    index++;
                }
                refreshTable();
            }
        }
    }

    internal class tempService
    {
        public int usingServiceID { get; set; }
        public string serviceID { get; set; }
        public string serviceName { get; set; }
        public byte quantity { get; set; }

        public tempService(string serviceID, string serviceName, byte quantity)
        {
            this.serviceID = serviceID;
            this.serviceName = serviceName;
            this.quantity = quantity;
        }

        public tempService(int usingServiceID, string serviceID, string serviceName, byte quantity)
        {
            this.usingServiceID = usingServiceID;
            this.serviceID = serviceID;
            this.serviceName = serviceName;
            this.quantity = quantity;
        }
    }
}
