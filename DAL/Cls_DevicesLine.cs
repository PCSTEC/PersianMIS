using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
 

namespace DAL
{
    public class Cls_DevicesLine
    {
        public void Insert(string SPname, int LineId, string LineDesc, int DeviceId, int PulsID, int InputPortTypeId, int ProductLineId, string ActiveColor, string DeActiveColor, Boolean LineActive, string ActiveStateDesc, string DeActiveStateDesc , int GapTime)
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@LineId", System.Data.SqlDbType.Int, LineId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@LineDesc", System.Data.SqlDbType.NVarChar, LineDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@DeviceId", System.Data.SqlDbType.Int, DeviceId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@PulsID", System.Data.SqlDbType.Int, PulsID, System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_AddParam("@InputPortTypeId", System.Data.SqlDbType.Int, InputPortTypeId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@ProductLineId", System.Data.SqlDbType.Int, ProductLineId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@ActiveColor", System.Data.SqlDbType.NVarChar, ActiveColor, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@DeActiveColor", System.Data.SqlDbType.NVarChar, DeActiveColor, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@LineActive", System.Data.SqlDbType.Bit, LineActive, System.Data.ParameterDirection.Input);
            
            Cls_Public.Pers.Sp_AddParam("@ActiveStateDesc", System.Data.SqlDbType.NVarChar, ActiveStateDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@DeActiveStateDesc", System.Data.SqlDbType.NVarChar, DeActiveStateDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@GapTime", System.Data.SqlDbType.Int, GapTime , System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_Exe(SPname, Cls_Public.CnnStr, true);
            Cls_Public.Pers.ClearParameter();
        }


        public void Update(string SPname, int LineId, string LineDesc, int DeviceId, int PulsID, int InputPortTypeId, int ProductLineId, string ActiveColor, string DeActiveColor, Boolean LineActive, string ActiveStateDesc, string DeActiveStateDesc , int GapTime)
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@LineId", System.Data.SqlDbType.Int, LineId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@LineDesc", System.Data.SqlDbType.NVarChar, LineDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@DeviceId", System.Data.SqlDbType.Int, DeviceId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@PulsID", System.Data.SqlDbType.Int, PulsID, System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_AddParam("@InputPortTypeId", System.Data.SqlDbType.Int, InputPortTypeId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@ProductLineId", System.Data.SqlDbType.Int, ProductLineId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@ActiveColor", System.Data.SqlDbType.NVarChar, ActiveColor, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@DeActiveColor", System.Data.SqlDbType.NVarChar, DeActiveColor, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@LineActive", System.Data.SqlDbType.Bit, LineActive, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@ActiveStateDesc", System.Data.SqlDbType.NVarChar, ActiveStateDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@DeActiveStateDesc", System.Data.SqlDbType.NVarChar, DeActiveStateDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@GapTime", System.Data.SqlDbType.Int, GapTime, System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_Exe(SPname, Cls_Public.CnnStr, true);
            Cls_Public.Pers.ClearParameter();
        }



        public void Delete(string SPName, string DeviceId, string LineId)
        {
            Cls_Public.Pers.Sp_AddParam("@DeviceId", System.Data.SqlDbType.Int, DeviceId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@LineId", System.Data.SqlDbType.Int, LineId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_Exe(SPName, Cls_Public.CnnStr, true);
            Cls_Public.Pers.ClearParameter();

        }


        public DataTable GetDeviceLineById(string DeviceId, string LineId)
        {

            if (LineId == "0")
            {
                Cls_Public.SqlStr = string.Format("select * from Vw_LineInfo where DeviceId={0}  ", DeviceId);

            }
            else
            {
                Cls_Public.SqlStr = string.Format("select * from Vw_LineInfo where DeviceId={0} and LineId={1}", DeviceId, LineId);

            }
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;

        }


        public DataTable GetSpecialLineStateByDate(string DeviceId, string LineId, string StartDate, string StartTime, string EndMiladiDate, string EndMiladiTime)
        {
            Cls_Public.SqlStr = "select * from GetSpecialLineStateByDate('" + DeviceId + "','" + LineId + "','" + StartDate + "','" + StartTime + "','" + EndMiladiDate+ "','" + EndMiladiTime + "')";


            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;

        }
        public DataTable GetSpecialLineStateByDateDateForCount(string DeviceId, string LineId, string StartDate, string StartTime,string EndTime,string EndDate)
        {
            Cls_Public.SqlStr = "select * from GetSpecialLineStateByDateForCount('" + DeviceId + "','" + LineId + "','" + StartDate + "','" + StartTime + "','" + EndTime +"','" + EndDate + "')";


            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;

        }

      

        public DataTable GetAllResource()
        {
            Cls_Public.SqlStr = "select * from Vw_Resources  ";
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }



        public DataTable GetLastResourceState()
        {
            Cls_Public.SqlStr = "select * from VW_LastResourceState  ";
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }
         

        public DataTable GetLastStateFromSpecialLineStateByDate(string DeviceId, string LineId, string StartDate, string StartTime)
        {
            Cls_Public.SqlStr = "select * from GetLastStateFromSpecialLineStateByDate('" + DeviceId + "','" + LineId + "','" + StartDate + "','" + StartTime + "')";

           
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;

        }



    }
}
