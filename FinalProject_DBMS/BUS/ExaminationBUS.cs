using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class ExaminationBUS
    {
        ExaminationDAL examinationDAL;

        public ExaminationBUS()
        {
            examinationDAL = new ExaminationDAL();
        }

        /*public void GetExaminateIDNext(TextBox txt)
        {
            txt.Text = examinationDAL.GetExaminateIDNext();
        }*/

        public bool UpdateExamination(string patientID, string employeeID, double height, double weight, double temperature, int breathing, string symptom, int veins, int bloodPressure, string preliminaryDiagnosis, string finalDiagnosis, string treatmentDirection, string examinateID)
        {
            try
            {
                examinationDAL.UpdateExamination(patientID, employeeID, height, weight, temperature, breathing, symptom, veins, bloodPressure, preliminaryDiagnosis, finalDiagnosis, treatmentDirection, examinateID);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
