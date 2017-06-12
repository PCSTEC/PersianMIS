using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    public class Cls_Device
    {
        public int Insert(string DeviceDesc, string computerName, string PortName)
        {
            string Result = "";
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@DeviceDesc", System.Data.SqlDbType.NVarChar, DeviceDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@computerName", System.Data.SqlDbType.NVarChar, computerName, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@PortName", System.Data.SqlDbType.NVarChar, PortName, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@id", System.Data.SqlDbType.Int, Result, System.Data.ParameterDirection.Output);
            Cls_Public.Pers.Sp_Exe("SP_InsertDevices", Cls_Public.CnnStr, false);
            return Convert.ToInt32(Cls_Public.Pers.ParameterCmd1[4].ParamValue.ToString());
            Cls_Public.Pers.ClearParameter();


        }

        public void  Update(string DeviceDesc, string computerName, string PortName, int DeviceId)
        {
            
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@DeviceDesc", System.Data.SqlDbType.NVarChar, DeviceDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@computerName", System.Data.SqlDbType.NVarChar, computerName, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@PortName", System.Data.SqlDbType.NVarChar, PortName, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@DeviceId", System.Data.SqlDbType.Int, DeviceId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_Exe("SP_UpdateDevice", Cls_Public.CnnStr, false);
             
            Cls_Public.Pers.ClearParameter();
        }
        public void ChangeDeviceState(int DeviceId, Boolean DeviceState)
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@DeviceID", System.Data.SqlDbType.Int, DeviceId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@DeviceState", System.Data.SqlDbType.Bit, DeviceState, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_Exe("SP_ChangeDeviceState", Cls_Public.CnnStr, false);

        }

        public DataTable GetListOfDevice()
        {
            Cls_Public.SqlStr = "select * from GetDeviceInfo() ";
            return Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
        }


        public void DeleteDevice( int DeviceId)
        {
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@DeviceID", System.Data.SqlDbType.Int, DeviceId, System.Data.ParameterDirection.Input);
           
            Cls_Public.Pers.Sp_Exe("SP_DeleteDevice", Cls_Public.CnnStr, false);
            
        }

        public DataTable GetListOfDeviceByProductLine(string ProductLineId)
        {
            Cls_Public.SqlStr =string.Format( "select * from GetListOfDeviceByProductLine({0}) ", ProductLineId);
            return Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
        }



    }
}
