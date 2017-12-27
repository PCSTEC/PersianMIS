using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
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

        public DataTable GetProductLinesWithSetForDeviceLine()
        {
            Cls_Public.SqlStr = "select * from GetProductLinesWithSetForDeviceLine() ";
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }
        public DataTable GetProductLineToHowDeviceSet()
        {
            Cls_Public.SqlStr = "select * from GetProductLineToHowDeviceSet() ";
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }


        public DataTable GetNatureType()
        {
            Cls_Public.SqlStr = "select * from Tb_NatureType  ";
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }




        public DataTable GetPerformanceType()
        {
            Cls_Public.SqlStr = "select * from Tb_PerformanceType ";
            Cls_Public.PublicDT = Cls_Public.Pers.GetDataTable(Cls_Public.CnnStr, Cls_Public.SqlStr);
            return Cls_Public.PublicDT;
        }


        public void Insert(string ProductLineId, string ProductLineDesc, string Description, string SalonDesc,  int NatureId, int PerformanceTypeId)
        {
           
            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@ProductLineId", System.Data.SqlDbType.NVarChar, ProductLineId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@ProductLineDesc", System.Data.SqlDbType.NVarChar, ProductLineDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@Description", System.Data.SqlDbType.NVarChar, Description, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@NatureId", System.Data.SqlDbType.Int, NatureId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@SalonDesc", System.Data.SqlDbType.NVarChar, SalonDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@PerformanceTypeId", System.Data.SqlDbType.Int, PerformanceTypeId, System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_Exe("SP_InsertProductLine", Cls_Public.CnnStr, false);
            
            Cls_Public.Pers.ClearParameter();
        }

        public void Update (string ProductLineId, string ProductLineDesc, string Description,  string SalonDesc, int id ,    int NatureId, int PerformanceTypeId)
        {

            Cls_Public.Pers.ClearParameter();
            Cls_Public.Pers.Sp_AddParam("@ProductLineId", System.Data.SqlDbType.NVarChar, ProductLineId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@ProductLineDesc", System.Data.SqlDbType.NVarChar, ProductLineDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@Description", System.Data.SqlDbType.NVarChar, Description, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@SalonDesc", System.Data.SqlDbType.NVarChar, SalonDesc, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@id", System.Data.SqlDbType.Int , id , System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@PerformanceTypeId", System.Data.SqlDbType.Int, PerformanceTypeId, System.Data.ParameterDirection.Input);
            Cls_Public.Pers.Sp_AddParam("@NatureId", System.Data.SqlDbType.Int, NatureId, System.Data.ParameterDirection.Input);

            Cls_Public.Pers.Sp_Exe("SP_UpdateProductLine", Cls_Public.CnnStr, false);

            Cls_Public.Pers.ClearParameter();
        }


    }

}
