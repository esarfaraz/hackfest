using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDSPModelDTOs
{
    public class PatientWaitingDTO
    {
        public int PId { get; set; }
        public string PatientFullName { get; set; }
        public string TherapyDept { get; set; }
        public string PStatus { get; set; }
        public string VisitFrequency { get; set; }
        public string PatientRegNo { get; set; }
        public int WId { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string WLStatus { get; set; }
    }
}
