using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
   public  class Cls_ProductLines

    { 
    
                /// <summary>
                /// /Return List Of Product Lines
                /// </summary>
                /// <returns>Data Table </returns>
        public DataTable GetProductLines()
        {
            Cls_Public.SqlStr = "select * from GetListOfProductLines() ";
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }

        public void Insert(string ProductLineId, string ProductLineDesc, string Description, string MizaneTolid, string SalonDesc)
        {
           
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@ProductLineId", System.Data.SqlDbType.NVarChar, ProductLineId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@ProductLineDesc", System.Data.SqlDbType.NVarChar, ProductLineDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@Description", System.Data.SqlDbType.NVarChar, Description, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@MizaneTolid", System.Data.SqlDbType.NVarChar, MizaneTolid, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@SalonDesc", System.Data.SqlDbType.NVarChar, SalonDesc, System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_Exe("SP_InsertProductLine", Cls_Public.CnnStr, false);
            
            Cls_Public.Pers.ClearParameter();
        }

        public void Update (string ProductLineId, string ProductLineDesc, string Description, string MizaneTolid, string SalonDesc, int id)
        {

            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@ProductLineId", System.Data.SqlDbType.NVarChar, ProductLineId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@ProductLineDesc", System.Data.SqlDbType.NVarChar, ProductLineDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@Description", System.Data.SqlDbType.NVarChar, Description, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@MizaneTolid", System.Data.SqlDbType.NVarChar, MizaneTolid, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@SalonDesc", System.Data.SqlDbType.NVarChar, SalonDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@id", System.Data.SqlDbType.Int , id , System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_Exe("SP_UpdateProductLine", Cls_Public.CnnStr, false);

            Cls_Public.Pers.ClearParameter();
        }


    }

}
