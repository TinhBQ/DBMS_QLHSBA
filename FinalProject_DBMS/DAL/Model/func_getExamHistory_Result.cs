//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Model
{
    using System;
    
    public partial class func_getExamHistory_Result
    {
        public string examinateID { get; set; }
        public string patientID { get; set; }
        public string tenBenhNhan { get; set; }
        public string hoBenhNhan { get; set; }
        public string employeeID { get; set; }
        public string tenBacSi { get; set; }
        public string hoBacSi { get; set; }
        public Nullable<double> height { get; set; }
        public Nullable<double> weight { get; set; }
        public Nullable<double> temperature { get; set; }
        public Nullable<int> breathing { get; set; }
        public string symptom { get; set; }
        public Nullable<int> veins { get; set; }
        public Nullable<int> bloodPressure { get; set; }
        public string preliminaryDiagnosis { get; set; }
        public string finalDiagnosis { get; set; }
        public string treatmentDirection { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
    }
}
