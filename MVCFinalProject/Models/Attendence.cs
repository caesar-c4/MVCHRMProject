//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCFinalProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attendence
    {
        public int ID { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public string InTime_Lanch { get; set; }
        public string OutTime_Lanch { get; set; }
        public Nullable<System.DateTime> Attend_Date { get; set; }
        public string Statuss { get; set; }
        public Nullable<int> EmpID { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
