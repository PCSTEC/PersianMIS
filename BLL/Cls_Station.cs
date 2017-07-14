using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class Cls_Station
    {
        DAL.Cls_Station Dal_Station = new DAL.Cls_Station();
        public void Insert(int ProductLineId   , int DeviceId  ,int DeviceLineId   , string  StationDesc  , string   Description)
        {
            Dal_Station.Insert(ProductLineId, DeviceId, DeviceLineId, StationDesc, Description);
        }

        public void Update(int ProductLineId, int DeviceId, int DeviceLineId, string StationDesc, string Description, int StationId)
        {
            Dal_Station.Update (ProductLineId, DeviceId, DeviceLineId, StationDesc, Description,StationId );
        }

        public DataTable GetStations(int ProductLineId )
        {
            return Dal_Station.GetStations(ProductLineId);
        }

        public void Delete(int StationId)
        {
            Dal_Station.Delete(StationId);
        }

        public DataTable GetAllStationData(string StartDate , string EndDate)
        {
            return Dal_Station.GetAllStationData(StartDate,EndDate );
        }

    }
}
