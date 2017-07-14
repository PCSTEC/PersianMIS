using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
   public  class CLS_DeviceLine
    {
        DAL.Cls_DevicesLine DAL_DeviceLine = new Cls_DevicesLine();
        public void Insert(string SPname, int LineId, string LineDesc, int DeviceId, int PulsID,  int InputPortTypeId, int ProductLineId, string ActiveColor, string DeActiveColor, Boolean LineActive, string  ActiveStateDesc, string DeActiveStateDesc , int GapTime)
        {
            DAL_DeviceLine.Insert(SPname, LineId, LineDesc, DeviceId, PulsID, InputPortTypeId, ProductLineId, ActiveColor, DeActiveColor, LineActive,   ActiveStateDesc,   DeActiveStateDesc , GapTime );

        }

        public void Delete(string SPName, string DeviceId, string LineId)
        {
            DAL_DeviceLine.Delete(SPName, DeviceId, LineId);

        }
        public void Update (string SPname, int LineId, string LineDesc, int DeviceId, int PulsID, int InputPortTypeId, int ProductLineId, string ActiveColor, string DeActiveColor, Boolean LineActive, string ActiveStateDesc, string DeActiveStateDesc , int Gaptime)
        {
            DAL_DeviceLine.Update (SPname, LineId, LineDesc, DeviceId, PulsID, InputPortTypeId, ProductLineId, ActiveColor, DeActiveColor, LineActive,   ActiveStateDesc,   DeActiveStateDesc, Gaptime );

        }
        public DataTable GetDeviceLineById(string DeviceId, string LineId)
        {

            return DAL_DeviceLine.GetDeviceLineById(DeviceId, LineId);

        }


        public DataTable GetSpecialLineStateByDate (string DeviceId, string LineId , string StartDate , string StartTime,string EndMiladiDate,string EndMiladiTime)
        {
            return DAL_DeviceLine.GetSpecialLineStateByDate(DeviceId, LineId, StartDate, StartTime,EndMiladiDate,EndMiladiTime );

        }
        public DataTable GetLastStateFromSpecialLineStateByDate(string DeviceId, string LineId, string StartDate, string StartTime)
        {
            return DAL_DeviceLine.GetLastStateFromSpecialLineStateByDate(DeviceId, LineId, StartDate, StartTime);

        }

        public DataTable GetSpecialLineStateByDateDateForCount(string DeviceId, string LineId, string StartDate, string StartTime,string EndTime, string EndDate )
        {
            return DAL_DeviceLine.GetSpecialLineStateByDateDateForCount(DeviceId, LineId, StartDate, StartTime,EndTime,EndDate );

        }


       

        public DataTable GetAllResource()
        {
            return DAL_DeviceLine.GetAllResource();
        }

    }
    }
