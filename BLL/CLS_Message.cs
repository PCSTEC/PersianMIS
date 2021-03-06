﻿using System;
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

        public void Insert ( int PersonCode  , int DeviceLinePrimaryId , int StateId , int DurationTime, string MssagePrefixTitle , string MessageBodyFormat,int RepeatMessageAtTime)
        {
            DAL_Message.Insert(PersonCode, DeviceLinePrimaryId, StateId, DurationTime, MssagePrefixTitle, MessageBodyFormat, RepeatMessageAtTime);
        }

        public void InsertMessageServerSettings(int MessageServerNumber, Boolean IsFlash, string UserName, string Password)
        {
            DAL_Message.InsertMessageServerSettings(MessageServerNumber, IsFlash, UserName, Password);
        }

        public void InsertSendMessages(int MessageThemplateID, DateTime SendDateTime)
        {
            DAL_Message.InsertSendMessages(MessageThemplateID, SendDateTime );
        }



        public void Update(int PersonCode, int DeviceLinePrimaryId, int StateId, int DurationTime, string MssagePrefixTitle, string MessageBodyFormat, int MessageThemplateID, int RepeatMessageAtTime)
        {
            DAL_Message.Update (PersonCode, DeviceLinePrimaryId, StateId, DurationTime, MssagePrefixTitle, MessageBodyFormat, MessageThemplateID, RepeatMessageAtTime);
        }

        public DataTable GetListOfMessageBodyItems()
        {
            return DAL_Message.GetListOfMessageBodyItems();
        }


        public DataTable Get_AllMessageServerSettings()
        {
            return DAL_Message.Get_AllMessageServerSettings();
        }

        public DataTable GetAllMessageThemplates()
        {
            return DAL_Message.GetAllMessageThemplates();
        }

        public DataTable GetSpecialMessageThemplateById(int MessageThemplateID)
        {
            
            return     DAL_Message.GetSpecialMessageThemplateById(MessageThemplateID);
        }


        public DataTable GetEmergancyMessageList()
        {
            return DAL_Message.GetEmergancyMessageList();
       
        }


        public DataTable GetSendMessagesByMessageThemplateID(int MessageThemplateID)
        {
            return DAL_Message.GetSendMessagesByMessageThemplateID(MessageThemplateID);
         
        }
    }
}
