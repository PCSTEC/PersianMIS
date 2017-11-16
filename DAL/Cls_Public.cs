using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using System.Data;
using Persistent.DataAccess;
using System.Data.SqlClient;
using System.IO;
  
namespace DAL
{
    public static class Cls_Public
    {
        public static Persistent.DataAccess.DataAccess Pers = new DataAccess();
        //     public static  string CnnStr= "Data Source=.;Initial Catalog=pcstec;Integrated Security=True";
        public static string CnnStr = "Data Source=pcstecserver\\pcstecserver;Initial Catalog=PCSTEC;User ID=sa;password=afarinesh";
        public static string SqlStr = "";
        public static DataTable PublicDT = new DataTable();


        public static Boolean InsertBackgroundImgage(string ImgPath, string UserId)
        {
           
            try
            {
                byte[] imageData = ReadFile(ImgPath);

                SqlConnection CN = new SqlConnection(CnnStr);

            
                string qry = "insert into Tb_Background (BackgroundUserId,BackgroundImg) values(@BackgroundUserId, @BackgroundImg)";

                SqlCommand SqlCom = new SqlCommand(qry, CN);

                SqlCom.Parameters.Add(new SqlParameter("@BackgroundUserId",
                               (object)UserId));

                SqlCom.Parameters.Add(new SqlParameter("@BackgroundImg",
                (object)imageData));

                CN.Open();
                SqlCom.ExecuteNonQuery();
                CN.Close();
                return true;
            }
            catch { return false; }

        }

        public static System.Drawing.Bitmap GetBackgroundImagesFromDatabase(string UserId)
        {
            MemoryStream ms = new MemoryStream();
            try
            {
                
                SqlConnection conn = new SqlConnection(CnnStr);

                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from Tb_Background where BackgroundUserId ='" + UserId + "'", conn);
               
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        byte[] picData = reader["BackgroundImg"] as byte[] ?? null;

                        if (picData != null)
                        {
                            using (MemoryStream Data = new MemoryStream(picData))
                            {
                                
                                
                            }
                        }
                    }
                }
                return ms;

            }
            catch (Exception ex)
            {
                return ms;
            }

 

        }

        public static byte[] ReadFile(string sPath)
        {

            byte[] data = null;

            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;


            FileStream fStream = new FileStream(sPath, FileMode.Open,
            FileAccess.Read);

            BinaryReader br = new BinaryReader(fStream);


            data = br.ReadBytes((int)numBytes);
            return data;
        }



    }
}
