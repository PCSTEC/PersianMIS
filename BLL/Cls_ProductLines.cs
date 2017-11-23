using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using DAL;
namespace BLL
{
 public    class Cls_ProductLines
    {
        DAL.Cls_ProductLines DAL_ProductLines = new DAL.Cls_ProductLines();

        /// <summary>
        /// /Return List Of Product Lines
        /// </summary>
        /// <returns>Data Table </returns>
        public DataTable GetProductLines()
        {
            return DAL_ProductLines.GetProductLines();
        }

        public DataTable GetProductLinesWithSetForDeviceLine()
        {
            return DAL_ProductLines.GetProductLinesWithSetForDeviceLine();
        }


        public DataTable GetPerformanceType()
        {
            return DAL_ProductLines.GetPerformanceType();
        }


        public DataTable GetNatureType()
        {
            return DAL_ProductLines.GetNatureType();
        }




        public void Insert (string ProductLineId , string ProductLineDesc  , string Description   , string SalonDesc  , int NatureId , int PerformanceTypeId) 
        {
            DAL_ProductLines.Insert(ProductLineId, ProductLineDesc, Description,  SalonDesc,  NatureId,   PerformanceTypeId);
        }

        public void Update (string ProductLineId, string ProductLineDesc, string Description, string SalonDesc , int id, int NatureId, int PerformanceTypeId)
        {
            DAL_ProductLines.Update(ProductLineId, ProductLineDesc, Description,  SalonDesc,id , NatureId, PerformanceTypeId);
        }

    }
}
