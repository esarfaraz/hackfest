using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDSPModelDTOs
{
    public class AppointmentDTO
    {
        public int AppId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public string PatientFullName { get; set; }
        public Nullable<int> TherapistId { get; set; }
        public string TherapistFullName { get; set; }
        public Nullable<int> SessionNumber { get; set; }
        public Nullable<int> TherapistScheduleId { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public string Status { get; set; }
        public string PaymentStatus { get; set; }
        public System.DateTime AppointmentDate { get; set; }
        public string Therapy { get; set; }
    }
}
