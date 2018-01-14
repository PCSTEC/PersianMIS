using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using DAL;
namespace BLL
{
    public class CLS_Chart
    {
        DAL.CLS_Chart Dal_Chart = new DAL.CLS_Chart();


        public DataTable GetActiveChartThemplate()
        {
            return Dal_Chart.GetActiveChartThemplate();
        }


        public void Insert(string UserId, Boolean IsMainThemplate, string TSQL, string Caption, string ChartType, int ChartFieldCaptionsType, int ChartLegentType, int ChartTypeDataShow, int chartAxisXType, Boolean ShowChartCaption, Boolean ShowChartPurpose, Boolean ShowChart3D)
        {
            Dal_Chart.Insert(UserId, IsMainThemplate, TSQL, Caption, ChartType, ChartFieldCaptionsType,   ChartLegentType,   ChartTypeDataShow,   chartAxisXType,   ShowChartCaption,   ShowChartPurpose,   ShowChart3D);
        }


        public DataTable GetListOFChartForSpecialUser(string UserId)
        {
          
            return Dal_Chart.GetListOFChartForSpecialUser(UserId);

        }
        public DataTable GetSpecialChartParameterData(string ChartOptionId)
        {
            return Dal_Chart.GetSpecialChartParameterData(ChartOptionId);

        }



        public DataTable GetChartAxisXType()
        {
           return  Dal_Chart.GetChartAxisXType( );

        }


        public DataTable GetChartLegendType()
        {
          return   Dal_Chart.GetChartLegendType();

        }

        public DataTable GetChartShowType()
        {
            return Dal_Chart.GetChartShowType();

        }


    }
}
