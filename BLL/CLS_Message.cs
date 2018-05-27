using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;
namespace BLL
{
    
   public class CLS_Message
    {

        DAL.CLS_Message DAL_Message = new DAL.CLS_Message();

        public void Insert ( int PersonCode  , int DeviceLinePrimaryId , int StateId , int DurationTime, string MssagePrefixTitle , string MessageBodyFormat)
        {
            DAL_Message.Insert(PersonCode, DeviceLinePrimaryId, StateId, DurationTime, MssagePrefixTitle, MessageBodyFormat);
        }
        public DataTable GetListOfMessageBodyItems()
        {
            return DAL_Message.GetListOfMessageBodyItems();
        }

        public DataTable GetAllMessageThemplates()
        {
            return DAL_Message.GetAllMessageThemplates();
        }

        public DataTable GetSpecialMessageThemplateById(int MessageThemplateID)
        {
            
            return     DAL_Message.GetSpecialMessageThemplateById(MessageThemplateID);
        }
    }
}
