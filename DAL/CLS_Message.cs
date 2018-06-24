using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace DAL
{
    public class CLS_Message
    {
        public void Insert(int PersonCode, int DeviceLinePrimaryId, int StateId, int DurationTime, string MssagePrefixTitle, string MessageBodyFormat, int RepeatMessageAtTime)
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@PersonCode", System.Data.SqlDbType.Int, PersonCode, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@DeviceLinePrimaryId", System.Data.SqlDbType.Int, DeviceLinePrimaryId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@StateId", System.Data.SqlDbType.Int, StateId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@DurationTime", System.Data.SqlDbType.Int, DurationTime, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@MssagePrefixTitle", System.Data.SqlDbType.NVarChar, MssagePrefixTitle, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@MessageBodyFormat", System.Data.SqlDbType.NVarChar, MessageBodyFormat, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@RepeatMessageAtTime", System.Data.SqlDbType.Int, RepeatMessageAtTime, System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_Exe("SP_InsertMessageThemplate", Cls_Public.CnnStr, false);

            Cls_Public.Pers.ClearParameter();
        }



        public void InsertMessageServerSettings(int MessageServerNumber, Boolean IsFlash, string UserName, string Password)
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@MessageServerNumber", System.Data.SqlDbType.Int, MessageServerNumber, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@IsFlash", System.Data.SqlDbType.Bit, IsFlash, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@UserName", System.Data.SqlDbType.NVarChar, UserName, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@Password", System.Data.SqlDbType.NVarChar, Password, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_Exe("Sp_InsertMessageServerSettings", Cls_Public.CnnStr, false);
            Cls_Public.Pers.ClearParameter();
        }



        public void Update(int PersonCode, int DeviceLinePrimaryId, int StateId, int DurationTime, string MssagePrefixTitle, string MessageBodyFormat, int MessageThemplateID, int RepeatMessageAtTime)
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@PersonCode", System.Data.SqlDbType.Int, PersonCode, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@DeviceLinePrimaryId", System.Data.SqlDbType.Int, DeviceLinePrimaryId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@StateId", System.Data.SqlDbType.Int, StateId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@DurationTime", System.Data.SqlDbType.Int, DurationTime, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@MssagePrefixTitle", System.Data.SqlDbType.NVarChar, MssagePrefixTitle, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@MessageBodyFormat", System.Data.SqlDbType.NVarChar, MessageBodyFormat, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@MessageThemplateID", System.Data.SqlDbType.Int, MessageThemplateID, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@RepeatMessageAtTime", System.Data.SqlDbType.Int, RepeatMessageAtTime, System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_Exe("SP_UpdateMessageThemplate", Cls_Public.CnnStr, false);

            Cls_Public.Pers.ClearParameter();
        }

        public void InsertSendMessages(int MessageThemplateID, DateTime SendDateTime )
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@MessageThemplateID", System.Data.SqlDbType.Int, MessageThemplateID, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@SendDateTime", System.Data.SqlDbType.DateTime, SendDateTime, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_Exe("SP_InsertSendMessages", Cls_Public.CnnStr, false);

            Cls_Public.Pers.ClearParameter();
        }



        public DataTable GetListOfMessageBodyItems()
        {
            Cls_Public.SqlStr = "select * from GetListOfMessageBodyItems()  ";
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }
        public DataTable GetAllMessageThemplates()
        {
            Cls_Public.SqlStr = "select * from GetAllMessageThemplates()  ";
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }


        public DataTable GetSpecialMessageThemplateById(int MessageThemplateID)
        {
            Cls_Public.SqlStr = string.Format("select * from GetAllMessageThemplates() where MessageThemplateID={0}", MessageThemplateID);
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }


        public DataTable GetEmergancyMessageList()
        {
            Cls_Public.SqlStr = string.Format("select * from EmergancyMessageList()");
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }

        public DataTable GetSendMessagesByMessageThemplateID(int MessageThemplateID)
        {
            Cls_Public.SqlStr = string.Format("select * from GetSendMessagesByMessageThemplateID({0})", MessageThemplateID);
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }

        public DataTable Get_AllMessageServerSettings()
        {
            Cls_Public.SqlStr = string.Format("select * from Get_AllMessageServerSettings()");
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }




    }
}
