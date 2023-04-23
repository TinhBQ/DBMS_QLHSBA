using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS.impl
{
    public class PatientBUS_impl 
    {
        private QLHSBAEntities db = new QLHSBAEntities();

        public void Create(Person person, Patient patient)
        {
            db.InsertPatient(person.firstName,
                            person.lastName,
                            person.sex,
                            person.birthDay,
                            person.address,
                            person.phone,
                            person.cardID,
                            patient.patientJob,
                            patient.healthInsurance,
                            patient.reason);
            db.SaveChanges();
        }

        public void Delete(Patient obj)
        {
            if (obj.GetType().Equals(typeof(Patient)))
            {
                Patient patient = (Patient)obj;
                db.Patients.Remove(patient);
                db.SaveChanges();
            }
        }

        public List<Patient> getAll()
        {
            List<Patient> patients = db.Patients.ToList();
            return patients;
        }

        public Patient getById(string id)
        {
            Patient patient = db.Patients.Where(s => s.patientID.Equals(id)).FirstOrDefault();
            return patient;
        }

        public Patient getByName(string name)
        {
            return null;
        }

        public List<Patient> Search(Patient patient)
        {
            List<Patient> findings = db.Patients.Where(p => p.patientID.Equals(patient)
                                                        || p.patientJob.Equals(patient.patientJob)
                                                        || p.healthInsurance.Equals(patient.healthInsurance)
                                                        || p.reason.Equals(patient.reason)
                                                        || p.Person.Equals(patient.Person))
                                        .ToList();
            return findings;
        }

        public void Update(Patient obj)
        {
            if (obj.GetType().Equals(typeof(Person)))
            {
                Patient patient = (Patient)obj;
                db.Patients.AddOrUpdate(patient);
                db.SaveChanges();
            }
        }
    }
}
