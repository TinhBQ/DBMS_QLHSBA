using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class basicInfoPatientBUS
    {
        private QLHSBAEntities db = new QLHSBAEntities();

        public List<View_Patients> getAll()
        {
            return db.View_Patients.ToList();
        }

        public View_Patients findByID(string ID)
        {
            return db.View_Patients.Where(b => b.patientID == ID).FirstOrDefault();
        }

        public List<func_getRelatives_Result> getRelatives(string patientID)
        {
            List<func_getRelatives_Result> relatives = db.func_getRelatives(patientID).ToList();
            return relatives;
        }

        public void addRelative_Exist(string patientID, string relativeID)
        {
            db.InsertRelative_Exist(patientID, relativeID);
            db.SaveChanges();
        }

        public void addRelative_nonExist(Person person, string patientID)
        {
            db.InsertRelative(
                                person.firstName,
                                person.lastName, 
                                person.sex, 
                                person.birthDay, 
                                person.address, 
                                person.phone,
                                person.cardID, 
                                patientID);
            db.SaveChanges();
        }

        public List<func_getExamHistory_Result> GetHistoryExams(string patientID)
        {
            List<func_getExamHistory_Result> history = db.func_getExamHistory(patientID).ToList();
            return history;
        }

        public void Update(View_Patients newInfo)
        {
            // Update people
            Person person = db.People.Single(p => p.peopleID.Equals(newInfo.patientID));
            person.firstName = newInfo.patientFirstName;
            person.lastName = newInfo.patientLastname;
            person.sex = newInfo.sex;
            person.birthDay = newInfo.birthDay;
            person.address = newInfo.address;
            person.phone = newInfo.phone;
            person.cardID = newInfo.cardID;
            db.People.AddOrUpdate(person);
            db.SaveChanges();

            // Update patient
            Patient patient = db.Patients.Single(p => p.patientID.Equals(newInfo.patientID));
            patient.patientJob = newInfo.patientJob;
            patient.healthInsurance = newInfo.healthInsurance;
            patient.reason = newInfo.reason;
            db.Patients.AddOrUpdate(patient);
            db.SaveChanges();
        }
    }
}