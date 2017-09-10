using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
 

namespace DAL
{
   public  class CLS_Client
    {
        /// <summary>
        /// /Return List Of Client Data With Out Calc Duration Time
        /// </summary>
        /// <returns>Data Table </returns>
     

      

 
        public DataTable GetAllClientData(string StartDate, String EndDate, string ListOfProductionLines)
        {
            Cls_Public.SqlStr = "select * from GetAllClientData (CONVERT(DATETIME, '" + StartDate + "', 102),CONVERT(DATETIME, '" + EndDate + "', 102)," + ListOfProductionLines + "  ) as x  where duration>60  ";
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }
    }
}
