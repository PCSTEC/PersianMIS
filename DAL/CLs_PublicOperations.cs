using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public   class CLs_PublicOperations
    {
        /// <summary>
        /// Delete Special Record From Special table 
        /// </summary>
        /// <param name="SPName">Store Procuder Name </param>
        /// <param name="ParamName">Parameter Name </param>
        /// <param name="ParamValue">Parameter Value</param>
        public void  DeleteRecord (string SPName , string ParamName , string ParamValue)
        {

            Cls_Public.Pers.Sp_AddParam(ParamName, System.Data.SqlDbType.NVarChar, ParamValue,System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_Exe(SPName, Cls_Public.CnnStr, true) ;


        }




        /// <summary>
        /// Add  Record to Special table 
        /// </summary>
        /// <param name="SPName">Store Procuder Name </param>
        /// <param name="ParamName">Parameter Name </param>
        /// <param name="ParamValue">Parameter Value</param>
        public void InsertRecord(string SPName, string ParamName, string ParamValue)
        {

            Cls_Public.Pers.Sp_AddParam(ParamName, System.Data.SqlDbType.NVarChar, ParamValue, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_Exe(SPName, Cls_Public.CnnStr, true);
            Cls_Public.Pers.ClearParameter();

        }
    }
}
