using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.ServiceProcess;
using System.Threading;
using System.Timers;
  
namespace PCSTECSMSSender
{
    public partial class PCSTECSMSSender : ServiceBase
    {
        private static System.Timers.Timer MainTimer;
        PersianCalendar pc = new PersianCalendar();
        string CurShamsiDate = "";
        BLL.CLS_Message Cls_Message = new BLL.CLS_Message();
        BLL.Cls_PublicOperations Cls_Public = new BLL.Cls_PublicOperations();
        DataTable Dt = new DataTable();
        int CurMessageThemplateID = 0;
        public PCSTECSMSSender()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
           System.Diagnostics.Debugger.Launch();

            MainTimer = new System.Timers.Timer(1000);
            MainTimer.Elapsed += new ElapsedEventHandler(MainTimer_Tick);
            MainTimer.Interval = 10000;
            MainTimer.Enabled = true;

        }
        private void MainTimer_Tick(object source, ElapsedEventArgs e)
        {

            DateTime thisDate = DateTime.Now;
            CurShamsiDate = string.Format("{0}/{1}/{2}", pc.GetYear(thisDate), pc.GetMonth(thisDate).ToString("00"), pc.GetDayOfMonth(thisDate).ToString("00"));
            BLL.Cls_PublicOperations.Dt = Cls_Message.GetEmergancyMessageList();
            string MessageBody = "";
            for (int i = 0; i <= BLL.Cls_PublicOperations.Dt.Rows.Count - 1; i++)
            {
                MessageBody = "";
                CurMessageThemplateID = Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MessageThemplateID"].ToString());
                Dt = Cls_Message.GetSendMessagesByMessageThemplateID(CurMessageThemplateID);

                if (Dt.Rows.Count > 0)
                {

                    // Check to How Delay To Last Send This Themplate Message To Person 
                    DateTime startTime = Convert.ToDateTime(Dt.DefaultView[0]["SendDateTime"].ToString());
                    DateTime endTime = DateTime.Now;
                    TimeSpan span = endTime.Subtract(startTime);
                    if (span.TotalMinutes >= Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["RepeatMessageAtTime"].ToString()))
                    {
                        MessageBody = BLL.Cls_PublicOperations.Dt.DefaultView[i]["MssagePrefixTitle"].ToString() + ": " + BLL.Cls_PublicOperations.Dt.DefaultView[i]["Name"].ToString() + Environment.NewLine;
                        Dt = Cls_Message.GetListOfMessageBodyItems();
                        Dt = Dt.DefaultView.Table.Select("MessageBodyItemId in (" + BLL.Cls_PublicOperations.Dt.DefaultView[i]["MessageBodyFormat"].ToString() + ")").CopyToDataTable();
                        for (int n = 0; n <= Dt.Rows.Count - 1; n++)
                        {
                            // fill Message Body
                            MessageBody = MessageBody + Dt.DefaultView[n]["MessageBodyItemText"].ToString() + ": " + BLL.Cls_PublicOperations.Dt.DefaultView[i][Dt.DefaultView[n]["MessageBodyItem"].ToString()].ToString() + Environment.NewLine;
                        }


                        // Send Message 
                        SendSms(MessageBody, Convert.ToInt64(BLL.Cls_PublicOperations.Dt.DefaultView[i]["Mobile"].ToString()));


                    }


                }
                else
                {
                    // fill Message Body

                    MessageBody = BLL.Cls_PublicOperations.Dt.DefaultView[i]["MssagePrefixTitle"].ToString() + ": " + BLL.Cls_PublicOperations.Dt.DefaultView[i]["Name"].ToString() + Environment.NewLine;
                    Dt = Cls_Message.GetListOfMessageBodyItems();
                    Dt = Dt.DefaultView.Table.Select("MessageBodyItemId in (" + BLL.Cls_PublicOperations.Dt.DefaultView[i]["MessageBodyFormat"].ToString() + ")").CopyToDataTable();
                    for (int n = 0; n <= Dt.Rows.Count - 1; n++)
                    {
                        // Send Message 
                        MessageBody = MessageBody + Dt.DefaultView[n]["MessageBodyItemText"].ToString() + ": " + BLL.Cls_PublicOperations.Dt.DefaultView[i][Dt.DefaultView[n]["MessageBodyItem"].ToString()].ToString() + Environment.NewLine;
                    }

                    // Send Message 
                    SendSms(MessageBody, Convert.ToInt64(BLL.Cls_PublicOperations.Dt.DefaultView[i]["Mobile"].ToString()));

                }

                Thread.Sleep(30000);
            }
        }

         private void SendSms(string MessageBodys, long MobileNumber)
        {

            int smsLineID = 0;
            List<ir.sms.ip.WebServiceSmsSend> sendDetails = new List<ir.sms.ip.WebServiceSmsSend>();

            BLL.CLS_Message BllMessage = new BLL.CLS_Message();
            Dt = BllMessage.Get_AllMessageServerSettings();
            string messageBody = string.Empty;
            long mobileNo = 0;
            bool isFlash = Convert.ToBoolean(Dt.DefaultView[0]["isFlash"]);
            messageBody = MessageBodys;
            mobileNo = MobileNumber;


            sendDetails.Add(new ir.sms.ip.WebServiceSmsSend()
            {
                IsFlash = isFlash,
                MessageBody = messageBody,
                MobileNo = mobileNo
            });


            ir.sms.ip.SendReceive ws = new ir.sms.ip.SendReceive();

            if (!int.TryParse(Dt.DefaultView[0]["MessageServerNumber"].ToString(), out smsLineID)) throw new Exception("smsLineID is missing");

            //         DateTime sendSince = this.dtmSendSince.Value.Date.AddHours(this.tmSendSince.Value.Hour).AddMinutes(this.tmSendSince.Value.Minute).AddSeconds(this.tmSendSince.Value.Second);

            string message = string.Empty;

            long[] result = ws.SendMessage(Dt.DefaultView[0]["UserName"].ToString(), Dt.DefaultView[0]["Password"].ToString(), sendDetails.ToArray(), smsLineID, null, ref message);
            BllMessage.InsertSendMessages(CurMessageThemplateID, DateTime.Now);
        }
        protected override void OnStop()
        {

        }
    }
}
