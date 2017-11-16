using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL;
using System.Data;
using System.IO;

namespace BLL
{
   public   class Cls_PublicOperations
    {
        DAL.CLs_PublicOperations DAL_ClsPublicOperations = new CLs_PublicOperations();
       public static   DataTable Dt = new DataTable();
        /// <summary>
        /// Delete Special Record From Special table 
        /// </summary>
        /// <param name="SPName">Store Procuder Name </param>
        /// <param name="ParamName">Parameter Name </param>
        /// <param name="ParamValue">Parameter Value</param>
        public   void DeleteRecord(string SPName, string ParamName, string ParamValue)
        {
            DAL_ClsPublicOperations.DeleteRecord(SPName, ParamName, ParamValue); 
        }

        public   MemoryStream  GetBackgroundImagesFromDatabase (string UserId)
        {
           return  DAL.Cls_Public.GetBackgroundImagesFromDatabase(UserId);
        }

        /// <summary>
        /// Add  Record to Special table 
        /// </summary>
        /// <param name="SPName">Store Procuder Name </param>
        /// <param name="ParamName">Parameter Name </param>
        /// <param name="ParamValue">Parameter Value</param>
        public   void InsertRecord(string SPName, string ParamName, string ParamValue)
        {

            DAL_ClsPublicOperations.InsertRecord (SPName, ParamName, ParamValue);

        }


        public   DataTable GetDataTableFromTSQL(string Tsql)
        {
            return DAL_ClsPublicOperations.GetDataTableFromTSQL(Tsql);
        }



        public Boolean InsertBackgroundImage(string ImagePath , string UserId)
        {
return             DAL.Cls_Public.InsertBackgroundImgage(ImagePath, UserId);
        }
    }
}
