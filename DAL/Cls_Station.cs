﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace DAL
{
    public class Cls_Station
    {

        public void Insert(string StationName, int CountOfParameters)
        {
            int NewStationId = -1;
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@StationName", System.Data.SqlDbType.NVarChar, StationName, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@CountOfParameters", System.Data.SqlDbType.Int, CountOfParameters, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@NewStationId", System.Data.SqlDbType.Int, NewStationId, System.Data.ParameterDirection.Output);

            Cls_Public.Pers.Sp_Exe("Sp_InsertStation", Cls_Public.CnnStr, false );
            NewStationId = (int)Cls_Public.Pers.ParameterCmd1[0].ParamValue;

            Cls_Public.Pers.ClearParameter();
        }


        public void Delete(int StationId)
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("StationId", System.Data.SqlDbType.NVarChar, StationId, System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_Exe("SP_DeleteStation", Cls_Public.CnnStr, true);
            Cls_Public.Pers.ClearParameter();

        }

        public void Update(string StationName, int CountOfParameters, int StationId)
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@CountOfParameters", System.Data.SqlDbType.Int, CountOfParameters, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@StationName", System.Data.SqlDbType.Int, StationName, System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_AddParam("StationId", System.Data.SqlDbType.NVarChar, StationId, System.Data.ParameterDirection.Input);


            Cls_Public.Pers.Sp_Exe("SpUpdate_Station", Cls_Public.CnnStr, true);
            Cls_Public.Pers.ClearParameter();
        }


   



        public DataTable GetStations(int ProductLineId)
        {
            if (ProductLineId != 0)
            {
                Cls_Public.SqlStr = "select * from GetListOfStations() where ProductLineId='" + ProductLineId + "'";
            }
            else
            {
                Cls_Public.SqlStr = "select * from GetListOfStations()  ";
            }
            return Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);

        }

    }

}
