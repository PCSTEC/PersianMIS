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

        public void Update(string StationName, int StationId)
        {
            Dal_Station.Update (StationName,  StationId);
        }

        public DataTable GetStations(  )
        {
            return Dal_Station.GetStations();
        }

        public void Delete(int StationId)
        {
            Dal_Station.Delete(StationId);
        }

        public void  InsertStationParameters(string  ParameterName  ,string  ParamaterTSQL  ,   int StationId    )
        {
              Dal_Station.InsertStationParameters(ParameterName,    ParamaterTSQL,   StationId);
        }

        

    }
}
