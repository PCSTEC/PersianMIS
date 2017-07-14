using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
   public  class CLS_Client
    {
        DAL.CLS_Client Dal_Client= new DAL.CLS_Client();

        public DataTable GetAllCientWithOutDiuratiion()
        {
            return Dal_Client.GetAllCientWithOutDiuratiion();
        }



        public void UpdateClientDuratuin(string DeviceStateID, string Duration)
        {
            Dal_Client.UpdateClientDuratuin(DeviceStateID, Duration);


        }
    }
}
