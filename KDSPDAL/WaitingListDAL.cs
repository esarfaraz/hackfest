﻿using KDSPModels;
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
    }
}
