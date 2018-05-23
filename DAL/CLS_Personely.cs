using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
   public  class CLS_Personely
    {

        public DataTable  GetListOfActivePersonels()
        {
            Cls_Public.SqlStr = "select * from Personely.dbo.Vw_GetListOfActivePersonels order by lastname asc";
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }
    }
}
