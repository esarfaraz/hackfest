using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDSPModelDTOs
{
    public class BookAppointmentDTO
    {
        public int PatientId { get; set; }
        public string TherapistName { get; set; }
        public Nullable<System.DateTime> ScheduleDate { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public int SessionNumber { get; set; }
        public int WaitingListId { get; set; }
    }
}
