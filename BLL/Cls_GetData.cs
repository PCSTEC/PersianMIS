using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL;
using System.Data;
namespace BLL
{

  public   class Cls_GetData
    {
        DAL.Cls_GetData DAL_GetData = new DAL.Cls_GetData();

        public DataTable GetListOfInputPortTypes()
        {
            return DAL_GetData.GetListOfInputPortTypes();
        }

        public DataTable GetListOfPulsTypes()
        {
            return DAL_GetData.GetListOfPulsTypes();
        }
    }
}
