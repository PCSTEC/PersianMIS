using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Persistent.DataAccess;
namespace DAL
{
  public static   class Cls_Public
    {
        public static Persistent.DataAccess.DataAccess Pers = new DataAccess();
         public static  string CnnStr= "Data Source=.;Initial Catalog=pcstec;Integrated Security=True";
   // public static string CnnStr = "Data Source=s1002\\mssqlserver2014;Initial Catalog=PCSTEC;Integrated Security=True";

        public static string SqlStr = "";
        public static DataTable PublicDT = new DataTable();
    }
}
