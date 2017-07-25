using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using Persistent.DataAccess;
namespace DAL
{
  public static   class Cls_Public
    {
        public static Persistent.DataAccess.DataAccess Pers = new DataAccess();
           public static  string CnnStr= "Data Source=.;Initial Catalog=pcstec;Integrated Security=True";
       // public static string CnnStr = "packet size=4096;user id=sa;Password=afarinesh;data source=SQLSRV;persist security info=False;initial catalog=PCSTEC2";

        public static string SqlStr = "";
        public static DataTable PublicDT = new DataTable();
    }
}
