//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class H_Billdetails
    {
        public int Bill_No { get; set; }
        public System.DateTime Date { get; set; }
        public int Patient_Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Admission_date { get; set; }
        public string Discharge_date { get; set; }
        public int Room_charges { get; set; }
        public int pathology_fee { get; set; }
        public int doctor_fee { get; set; }
        public int miscellaneous { get; set; }
        public int Total { get; set; }
    }
}
