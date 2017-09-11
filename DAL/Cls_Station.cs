using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace DAL
{
    public class Cls_Station
    {

        public int Insert(string StationName, int CountOfParameters)
        {
            int NewStationId = -1;
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@StationName", System.Data.SqlDbType.NVarChar, StationName, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@CountOfParameters", System.Data.SqlDbType.Int, CountOfParameters, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@NewStationId", System.Data.SqlDbType.Int, NewStationId, System.Data.ParameterDirection.Output);

            Cls_Public.Pers.Sp_Exe("Sp_InsertStation", Cls_Public.CnnStr, false);
            NewStationId = (int)Cls_Public.Pers.ParameterCmd1[3].ParamValue;

            Cls_Public.Pers.ClearParameter();
            return NewStationId;
        }

        public void InsertStationParameters(string ParameterName, string ParamaterTSQL, int StationId)
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@ParameterName", System.Data.SqlDbType.NVarChar, ParameterName, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@ParamaterTSQL", System.Data.SqlDbType.NVarChar, ParamaterTSQL, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@StationId", System.Data.SqlDbType.Int, StationId, System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_Exe("Sp_InsertStationParameters", Cls_Public.CnnStr, false);

            Cls_Public.Pers.ClearParameter();

        }

        public void Delete(int StationId)
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("StationId", System.Data.SqlDbType.NVarChar, StationId, System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_Exe("SP_DeleteStation", Cls_Public.CnnStr, true);
            Cls_Public.Pers.ClearParameter();

        }

        public void Update(string StationName, int StationId)
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@StationName", System.Data.SqlDbType.NVarChar, StationName, System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_AddParam("StationId", System.Data.SqlDbType.Int, StationId, System.Data.ParameterDirection.Input);


            Cls_Public.Pers.Sp_Exe("SpUpdate_Station", Cls_Public.CnnStr, true);
            Cls_Public.Pers.ClearParameter();
        }



        public DataTable GetClientData(  string ListOfStationId)
        {
            Cls_Public.SqlStr = "select * from GetStationData (  "+ ListOfStationId + "  ) as x  ";
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }


        public DataTable GetStations()
        {

            Cls_Public.SqlStr = "select * from GetListOfStations()  ";

            return Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);

        }

    }

}
