using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
 public    class CLS_Device
    {
        DAL.Cls_Device DAL_Device = new Cls_Device();
        public int Insert(string DeviceDesc, string computerName, string PortName)
        {
            return DAL_Device.Insert(DeviceDesc,computerName, PortName);
        }

        public void  Update (string DeviceDesc, string computerName, string PortName,int DeviceId)
        {
              DAL_Device.Update(DeviceDesc, computerName, PortName, DeviceId);
        }

        public DataTable GetListOfDevice()
        {
            return DAL_Device.GetListOfDevice();

        }
        public void ChangeDeviceState(int DeviceId, Boolean DeviceState)
        {
            DAL_Device.ChangeDeviceState(DeviceId, DeviceState);

        }

        public void DeleteDevice(int DeviceId)
        {

            DAL_Device.DeleteDevice(DeviceId);
   
        }


        public DataTable GetListOfDeviceByProductLine(string ProductLineId)
        {
            return DAL_Device.GetListOfDeviceByProductLine(ProductLineId);
        }

    }
}
