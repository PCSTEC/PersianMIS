using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
   public  class Cls_Logs
    {
        DAL.Cls_Logs DAL_Logs = new DAL.Cls_Logs();
        public void InsertLoginsLog(  DateTime LoginTime, string ComputerId, string UserName)
        {
            DAL_Logs.InsertLoginsLog(   LoginTime, ComputerId , UserName);  
        }
    }
}
