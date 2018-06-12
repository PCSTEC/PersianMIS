using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
        public PCSTECSMSSender()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            MainTimer = new System.Timers.Timer(1000);
            MainTimer.Elapsed += new ElapsedEventHandler(MainTimer_Tick);
            MainTimer.Interval = 1000;
            MainTimer.Enabled = true;
        }
        private void MainTimer_Tick(object source, ElapsedEventArgs e)
        {
             DateTime thisDate = DateTime.Now;
            CurShamsiDate = string.Format("{0}/{1}/{2}", pc.GetYear(thisDate), pc.GetMonth(thisDate).ToString("00"), pc.GetDayOfMonth(thisDate).ToString("00"));
            BLL.Cls_PublicOperations.Dt = Cls_Message.GetAllMessageThemplates();
            string MessageBody = "";
            for (int i = 0; i <= BLL.Cls_PublicOperations.Dt.Rows.Count - 1; i++)
            {
                Dt = Cls_Message.GetSendMessagesByMessageThemplateID(Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MessageThemplateID"].ToString()));
                if (Dt.Rows.Count > 0)
                {
                   
                    // Check to How Delay To Last Send This Themplate Message To Person 
                    DateTime startTime = Convert.ToDateTime(Dt.DefaultView[0]["SendDateTime"].ToString());
                    DateTime endTime = DateTime.Now;
                    TimeSpan span = endTime.Subtract(startTime);
                    if (span.TotalMinutes >= Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[0]["RepeatMessageAtTime"].ToString()))
                    {
                        MessageBody = BLL.Cls_PublicOperations.Dt.DefaultView[0]["MssagePrefixTitle"].ToString() + Environment.NewLine  + BLL.Cls_PublicOperations.Dt.DefaultView[0]["Name"].ToString() + Environment.NewLine;
                        Dt = Cls_Message.GetListOfMessageBodyItems();
                        Dt = Dt.DefaultView.Table.Select("MessageBodyItemId in (" + BLL.Cls_PublicOperations.Dt.DefaultView[0]["MessageBodyFormat"].ToString() + ")").CopyToDataTable();
                        for(int n = 0; n <= Dt.Rows.Count - 1; n++)
                        {
                         
                           
                        }

                    }


                }
                else
                {
                    // Send Message 


                }

            }

            Thread.Sleep(30000);
        }

        private void SendMessage(int MobileNo,string MessageBodyFormat , string MssagePrefixTitle)
        {

        }
        protected override void OnStop()
        {

        }
    }
}
