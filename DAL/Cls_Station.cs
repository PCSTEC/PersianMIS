﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
public     class Cls_Station
    {

        public void Insert(int ProductLineId, int DeviceId, int DeviceLineId, string StationDesc, string Description)
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@ProductLineId", System.Data.SqlDbType.Int, ProductLineId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@DeviceId", System.Data.SqlDbType.Int , DeviceId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@DeviceLineId", System.Data.SqlDbType.Int, DeviceLineId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@StationDesc", System.Data.SqlDbType.NVarChar , StationDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@Description", System.Data.SqlDbType.NVarChar , Description, System.Data.ParameterDirection.Input);
           
            Cls_Public.Pers.Sp_Exe("Sp_InsertStation", Cls_Public.CnnStr, true);
            Cls_Public.Pers.ClearParameter();
        }


        public void Delete(int StationId)
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("StationId", System.Data.SqlDbType.NVarChar, StationId, System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_Exe("SP_DeleteStation", Cls_Public.CnnStr, true);
            Cls_Public.Pers.ClearParameter();

        }

        public void Update (int ProductLineId, int DeviceId, int DeviceLineId, string StationDesc, string Description , int StationId)
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@ProductLineId", System.Data.SqlDbType.Int, ProductLineId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@DeviceId", System.Data.SqlDbType.Int, DeviceId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@DeviceLineId", System.Data.SqlDbType.Int, DeviceLineId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@StationDesc", System.Data.SqlDbType.NVarChar, StationDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@Description", System.Data.SqlDbType.NVarChar, Description, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("StationId", System.Data.SqlDbType.NVarChar, StationId, System.Data.ParameterDirection.Input);


            Cls_Public.Pers.Sp_Exe("SpUpdate_Station", Cls_Public.CnnStr, true);
            Cls_Public.Pers.ClearParameter();
        }


        public DataTable GetStations(int ProductLineId)
        {
            if (ProductLineId!= 0)
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
