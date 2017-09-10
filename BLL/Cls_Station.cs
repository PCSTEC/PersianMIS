using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL;
using System.Data;
namespace BLL
{
    public class Cls_Station
    {
        DAL.Cls_Station Dal_Station = new DAL.Cls_Station();
        public int  Insert(string StationName, int CountOfParameters)
        {
          return   Dal_Station.Insert( StationName,  CountOfParameters);
        }

        public void Update(string StationName, int CountOfParameters, int StationId)
        {
            Dal_Station.Update (StationName,  CountOfParameters,  StationId);
        }

        public DataTable GetStations(int ProductLineId )
        {
            return Dal_Station.GetStations(ProductLineId);
        }

        public void Delete(int StationId)
        {
            Dal_Station.Delete(StationId);
        }


       

    }
}
