using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
  public   class Cls_Logs
    {
        public void InsertLoginsLog( DateTime  LoginTime , string   ComputerId , string UserName)
        {
            Cls_Public.Pers.ClearParameter();
             
            Cls_Public.Pers.Sp_AddParam("@LoginTime", System.Data.SqlDbType.DateTime, LoginTime, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@ComputerId", System.Data.SqlDbType.NChar , ComputerId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@UserName", System.Data.SqlDbType.NChar, UserName, System.Data.ParameterDirection.Input);

            
            Cls_Public.Pers.Sp_Exe("Sp_InsertLoginsLog", Cls_Public.CnnStr, false);

            Cls_Public.Pers.ClearParameter();
        }

        

    }
}
