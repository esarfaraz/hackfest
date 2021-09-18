using KDSPModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDSPDAL
{
    public class TherapistDAL
    {
        public static bool SaveTherapist(Therapist Stu) // calling SaveStudentMethod for insert a new record    
        {
            bool result = false;
            using (KDSPEntities _entity = new KDSPEntities())
            {
                _entity.Therapists.Add(Stu);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        public static bool GenerateSchedule(int TherpaistId)
        {
            bool result = false;
            using (KDSPEntities _entity = new KDSPEntities())
            {
                _entity.usp_GenerateTherapistSchedule(TherpaistId);
                
                result = true;
            }
            return result;
        }
    }
}
