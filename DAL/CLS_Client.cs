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
        public DataTable GetAllCientWithOutDiuratiion()
        {
            Cls_Public.SqlStr = "select * from GetAllCientWithOutDiuratiion() ";
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }

        public DataTable Get1000RecordOfCientData()
        {
            Cls_Public.SqlStr = "select * from Get1000RecordOfCientData() ";
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }


        public void UpdateClientDuratuin(string DeviceStateID , string Duration)
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@DeviceStateID", System.Data.SqlDbType.NVarChar , DeviceStateID, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@Duration", System.Data.SqlDbType.NVarChar, Duration, System.Data.ParameterDirection.Input);
         

            Cls_Public.Pers.Sp_Exe("SpUpdateClientDuration", Cls_Public.CnnStr, true);
            Cls_Public.Pers.ClearParameter();
        

    }
}
}
