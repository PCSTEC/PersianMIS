using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistent.DataAccess;
using System.Data;
namespace DAL
{
    
 public    class Cls_GetData
    {
        Persistent.DataAccess.DataAccess pers = new Persistent.DataAccess.DataAccess();


        /// <summary>
        /// /Return List Of InputPortTypes
        /// </summary>
        /// <returns>Data Table </returns>
      public  DataTable GetListOfInputPortTypes()
        {
            Cls_Public.SqlStr = "select * from GetListOfInputPortTypes() ";
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }



        /// <summary>
        /// /Return List Of PulsTypes
        /// </summary>
        /// <returns>Data Table </returns>
        public DataTable GetListOfPulsTypes()
        {
            Cls_Public.SqlStr = "select * from GetPulsTypes() ";
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }


      
        
    }
}
