using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using DAL;
using System.Data;
namespace BLL
{
   public  class CLS_Client
    {
        DAL.CLS_Client Dal_Client= new DAL.CLS_Client();

      

        public DataTable GetAllClientData(string StartDate, string EndDate, string ListOfProductionLines)
        {
            return Dal_Client.GetAllClientData(StartDate, EndDate, ListOfProductionLines);
        }


    }
}
