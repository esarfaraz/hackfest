using KDSPModelDTOs;
using KDSPModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDSPDAL
{
    public class AppointmentDAL
    {
        public static bool SaveBookAppointment(List<BookAppointmentDTO> lst) // calling SaveStudentMethod for insert a new record    
        {
            bool result = false;
            using (KDSPEntities _entity = new KDSPEntities())
            {
                int SessionNumber = 1;
                foreach(var obj in lst)
                {
                    _entity.usp_BookTherapistSchedule(obj.TherapistName, obj.ScheduleDate, obj.StartTime, obj.EndTime, obj.PatientId, SessionNumber++);
  
                }
                result = true;
            }
            return result;
        }

        public static List<AppointmentDTO> GetAppointmentsByPatient(int PatientId)
        {
            using (KDSPEntities _entity = new KDSPEntities())
            {
                var appointments = (from pa in _entity.PatientAppointments
                                join p in _entity.Patients on pa.PatientId equals p.Id
                                join t in _entity.Therapists on pa.TherapistId equals t.Id
                                join ts in _entity.TherapistSchedules on pa.TherapistScheduleId equals ts.Id
                                where p.Id == PatientId
                                select new AppointmentDTO()
                                {
                                    TherapistScheduleId = pa.TherapistScheduleId, PatientFullName=p.PatientFullName, TherapistFullName=t.TherapistFullName,
                                    PatientId = pa.PatientId, TherapistId=pa.TherapistId, AppointmentDate = pa.AppointmentDate, StartTime = ts.StartTime, EndTime=ts.EndTime,
                                    Status = pa.Status, PaymentStatus = pa.PaymentStatus, SessionNumber = pa.SessionNumber, AppId = pa.Id, Therapy = p.TherapyDept
                                     
                                }).ToList<AppointmentDTO>();
                return appointments;

            }
        }

        public static List<AppointmentDTO> GetAppointmentsByTherapist(int TherapistId)
        {
            using (KDSPEntities _entity = new KDSPEntities())
            {
                var appointments = (from pa in _entity.PatientAppointments
                                    join p in _entity.Patients on pa.PatientId equals p.Id
                                    join t in _entity.Therapists on pa.TherapistId equals t.Id
                                    join ts in _entity.TherapistSchedules on pa.TherapistScheduleId equals ts.Id
                                    where t.Id == TherapistId
                                    select new AppointmentDTO()
                                    {
                                        TherapistScheduleId = pa.TherapistScheduleId,
                                        PatientFullName = p.PatientFullName,
                                        TherapistFullName = t.TherapistFullName,
                                        PatientId = pa.PatientId,
                                        TherapistId = pa.TherapistId,
                                        AppointmentDate = pa.AppointmentDate,
                                        StartTime = ts.StartTime,
                                        EndTime = ts.EndTime,
                                        Status = pa.Status,
                                        PaymentStatus = pa.PaymentStatus,
                                        SessionNumber = pa.SessionNumber,
                                        AppId = pa.Id

                                    }).ToList<AppointmentDTO>();
                return appointments;

            }
        }

        public static bool UpdateAppointmentStatus(int AppId, string Status) // calling SaveStudentMethod for insert a new record    
        {
            bool result = false;
            using (KDSPEntities _entity = new KDSPEntities())
            {
                PatientAppointment wl = _entity.PatientAppointments.Find(AppId);
                wl.Status = Status;

                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        public static bool ReceivePayment(int AppId, string PaymentStatus, int Amount, string ReceiptNo) // calling SaveStudentMethod for insert a new record    
        {
            bool result = false;
            using (KDSPEntities _entity = new KDSPEntities())
            {
                _entity.usp_ReceivePayment(AppId, PaymentStatus, Amount, ReceiptNo);
                result = true;
            }
            return result;
        }
    }
}
