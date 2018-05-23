using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
 
namespace BLL
{
   public  class CSL_Personely
    {
        DAL.CLS_Personely Dal_Personely = new DAL.CLS_Personely();

        public DataTable  GetListOfActivePersonels()
        {
            return Dal_Personely.GetListOfActivePersonels();
        }
    }
}
