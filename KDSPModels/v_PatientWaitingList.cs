//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KDSPModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class v_PatientWaitingList
    {
        public int PId { get; set; }
        public string PatientRegNo { get; set; }
        public string PatientFullName { get; set; }
        public string TherapyDept { get; set; }
        public string PStatus { get; set; }
        public string VisitFrequency { get; set; }
        public int WLId { get; set; }
        public string WLStatus { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    }
}
