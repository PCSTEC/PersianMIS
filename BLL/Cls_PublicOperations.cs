using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
   public  class Cls_PublicOperations
    {
        DAL.CLs_PublicOperations DAL_ClsPublicOperations = new CLs_PublicOperations();
       public static   DataTable Dt = new DataTable();
        /// <summary>
        /// Delete Special Record From Special table 
        /// </summary>
        /// <param name="SPName">Store Procuder Name </param>
        /// <param name="ParamName">Parameter Name </param>
        /// <param name="ParamValue">Parameter Value</param>
        public void DeleteRecord(string SPName, string ParamName, string ParamValue)
        {
            DAL_ClsPublicOperations.DeleteRecord(SPName, ParamName, ParamValue); 
        }



        /// <summary>
        /// Add  Record to Special table 
        /// </summary>
        /// <param name="SPName">Store Procuder Name </param>
        /// <param name="ParamName">Parameter Name </param>
        /// <param name="ParamValue">Parameter Value</param>
        public void InsertRecord(string SPName, string ParamName, string ParamValue)
        {

            DAL_ClsPublicOperations.InsertRecord (SPName, ParamName, ParamValue);

        }
    }
}
