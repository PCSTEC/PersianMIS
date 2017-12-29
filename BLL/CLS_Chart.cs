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


        public void Insert(string UserId, Boolean IsMainThemplate, string TSQL, string Caption, string ChartType, int ChartFieldCaptionsType)
        {
            Dal_Chart.Insert(UserId, IsMainThemplate, TSQL, Caption, ChartType, ChartFieldCaptionsType);
        }
    }
}
