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



        public void Insert (string ProductLineId , string ProductLineDesc  , string Description  , string MizaneTolid  , string SalonDesc ) 
        {
            DAL_ProductLines.Insert(ProductLineId, ProductLineDesc, Description, MizaneTolid, SalonDesc);
        }

        public void Update (string ProductLineId, string ProductLineDesc, string Description, string MizaneTolid, string SalonDesc , int id)
        {
            DAL_ProductLines.Update(ProductLineId, ProductLineDesc, Description, MizaneTolid, SalonDesc,id  );
        }

    }
}
