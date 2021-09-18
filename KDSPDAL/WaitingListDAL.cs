using KDSPModelDTOs;
using KDSPModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDSPDAL
{
    public class WaitingListDAL
    {
        public static bool SaveWaitingList(WaitingList Stu) // calling SaveStudentMethod for insert a new record    
        {
            bool result = false;
            using (KDSPEntities _entity = new KDSPEntities())
            {
                _entity.WaitingLists.Add(Stu);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        public static bool UpdateWaitingListToBooked(int WLId) // calling SaveStudentMethod for insert a new record    
        {
            bool result = false;
            using (KDSPEntities _entity = new KDSPEntities())
            {
                WaitingList wl = _entity.WaitingLists.Find(WLId);
                wl.Status = "Booked";
                
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        public static bool UpdateWaitingListRemarks(int WLId, string remarks) // calling SaveStudentMethod for insert a new record    
        {
            bool result = false;
            using (KDSPEntities _entity = new KDSPEntities())
            {
                WaitingList wl = _entity.WaitingLists.Find(WLId);
                wl.Remarks = remarks;

                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
        public static List<PatientWaitingDTO> GetPatientWaitings()
        {
            using (KDSPEntities _entity = new KDSPEntities())
            {
                var innerJoin = from p in _entity.Patients
                                join wl in _entity.WaitingLists on p.Id equals wl.PatientId
                                orderby wl.DateCreated
                                select new PatientWaitingDTO
                                {
                                    PId = p.Id,
                                    PatientFullName = p.PatientFullName,
                                    TherapyDept = p.TherapyDept,
                                    PStatus = p.Status,
                                    VisitFrequency = p.VisitFrequency,
                                    PatientRegNo = p.PatientRegNo,
                                    WId = wl.Id,
                                    WLStatus = wl.Status,
                                    DateCreated = wl.DateCreated
                                };

                return (List<PatientWaitingDTO>)innerJoin;
            }
        }



    }
}
