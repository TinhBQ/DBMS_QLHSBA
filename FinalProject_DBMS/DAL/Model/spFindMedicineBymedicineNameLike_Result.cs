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
    
    public partial class spFindMedicineBymedicineNameLike_Result
    {
        public string medicineID { get; set; }
        public string medicineName { get; set; }
        public string unit { get; set; }
        public Nullable<int> medicinePrice { get; set; }
        public int expiry { get; set; }
        public int count { get; set; }
        public string shape { get; set; }
        public string medicineGroupName { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
        public Nullable<System.DateTime> updatedAt { get; set; }
    }
}
