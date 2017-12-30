using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
   public  class CLS_Chart
    {

        public DataTable GetActiveChartThemplate()
        {
            Cls_Public.SqlStr = "select * from GetActiveChartThemplate() ";
            return Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
        }


        public  void  Insert(string  UserId , Boolean  IsMainThemplate  , string TSQL  , string  Caption  , string ChartType  ,int ChartFieldCaptionsType   )
        {
           
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@UserId", System.Data.SqlDbType.NVarChar, UserId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@IsMainThemplate", System.Data.SqlDbType.Bit , IsMainThemplate, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@TSQL", System.Data.SqlDbType.NVarChar, TSQL, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@Caption", System.Data.SqlDbType.NVarChar , Caption, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@ChartType", System.Data.SqlDbType.NChar , ChartType, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@ChartFieldCaptionsType", System.Data.SqlDbType.Int , ChartFieldCaptionsType, System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_Exe("SP_InsertChartOption", Cls_Public.CnnStr, false);
           


        }



        public DataTable GetListOFChartForSpecialUser(string UserId)
        {
            Cls_Public.SqlStr = "select * from GetListOFChartForSpecialUser('"+ UserId+"') ";
            return Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);

        }

        public DataTable GetSpecialChartParameterData(string ChartOptionId)
        {
            Cls_Public.SqlStr = "select * from GetSpecialChartParameterData('" + ChartOptionId + "') ";
            return Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);

        }


    }
}
