using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Persistent.DataAccess;
using DAL;
using System.Windows;
using FarsiLibrary.Utils;
using System.Threading;
using System.IO.Ports;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using IraniDate.IraniDate;
namespace PIASService
{
    public partial class PIASService : ServiceBase
    {
        double totalHours;
        Persistent.DataAccess.DataAccess Pers = new Persistent.DataAccess.DataAccess();
        string stresive1;
       

        string sqlstr = "";

        Boolean ISStartInt1 = false;
        Boolean ISStartInt2 = false;
        Boolean ISStartInt3 = false;
        Boolean ISStartInt4 = false;
        Boolean ISStartInt5 = false;
        Boolean ISStartInt6 = false;
        Boolean ISStartInt7 = false;
        Boolean ISStartInt8 = false;
        Boolean ISStartInt9 = false;
        Boolean ISStartInt10 = false;
        Boolean ISStartInt11 = false;
        Boolean ISStartInt12 = false;
        Boolean ISStartInt13 = false;
        Boolean ISStartInt14 = false;
        Boolean ISStartInt15 = false;
        Boolean ISStartInt16 = false;
        Boolean ISStartInt17 = false;
        Boolean ISStartInt18 = false;
        Boolean ISStartInt19 = false;
        Boolean ISStartInt20 = false;
        Boolean ISStartInt21 = false;
        Boolean ISStartInt22 = false;
        Boolean ISStartInt23 = false;
        Boolean ISStartInt24 = false;

        int CountOfPuls1 = 0;
        int CountOfPuls2 = 0;
        int CountOfPuls3 = 0;
        int CountOfPuls4 = 0;
        int CountOfPuls5 = 0;
        int CountOfPuls6 = 0;
        int CountOfPuls7 = 0;
        int CountOfPuls8 = 0;
        int CountOfPuls9 = 0;
        int CountOfPuls10 = 0;
        int CountOfPuls11 = 0;
        int CountOfPuls12 = 0;
        int CountOfPuls13 = 0;
        int CountOfPuls14 = 0;
        int CountOfPuls15 = 0;
        int CountOfPuls16 = 0;
        int CountOfPuls17 = 0;
        int CountOfPuls18 = 0;
        int CountOfPuls19 = 0;
        int CountOfPuls20 = 0;
        int CountOfPuls21 = 0;
        int CountOfPuls22 = 0;
        int CountOfPuls23 = 0;
        int CountOfPuls24 = 0;


        Boolean LstState1 = false;
        Boolean LstState2 = false;
        Boolean LstState3 = false;
        Boolean LstState4 = false;
        Boolean LstState5 = false;
        Boolean LstState6 = false;
        Boolean LstState7 = false;
        Boolean LstState8 = false;
        Boolean LstState9 = false;
        Boolean LstState10 = false;
        Boolean LstState11 = false;
        Boolean LstState12 = false;
        Boolean LstState13 = false;
        Boolean LstState14 = false;
        Boolean LstState15 = false;
        Boolean LstState16 = false;
        Boolean LstState17 = false;
        Boolean LstState18 = false;
        Boolean LstState19 = false;
        Boolean LstState20 = false;
        Boolean LstState21 = false;
        Boolean LstState22 = false;
        Boolean LstState23 = false;
        Boolean LstState24 = false;

        public PIASService()
        {
            InitializeComponent();

        }
        IraniDate.IraniDate.IraniDate CurrentDate = new IraniDate.IraniDate.IraniDate();
 



        protected override void OnStart (string[] args)
        {
            System.Diagnostics.Debugger.Launch();
            EventLog.WriteEntry("Start Mohsen Event", EventLogEntryType.Information);
            serialPort1.Close();
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.BaudRate = int.Parse("9600");
            serialPort1.PortName = "COM3";
            serialPort1.Open();
            serialPort1.DiscardInBuffer();
            EventLog.WriteEntry("Start serialPort1 Event", EventLogEntryType.Information);





        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("Start Mohsen Stop", EventLogEntryType.Information);

        }

  //      protected override void OnShutdown()
  //      {
  //          base.OnShutdown();
  //          for(int i = 1; i <= 24; i++)
  //          {

  //sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + 1048 + "') AND (DeviceLineId = '" + i + "')  ORDER BY DeviceStateID DESC)";
  //          Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
  //              if (string.IsNullOrEmpty(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString()))
  //              {

  //          DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
  //          DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


  //          totalHours = (EndDate - FirstDate).TotalMinutes;
  //          sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls1 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + i + "') AND (DeviceLineId = '" + 1048 + "')  ORDER BY DeviceStateID DESC)";
  //          Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

  //              }

  //          }
          
  //      }
        

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                EventLog.WriteEntry("serialPort1_DataReceived", EventLogEntryType.Information);

                stresive1 = serialPort1.ReadLine();
                Thread thread1 = new Thread(new ThreadStart(display1));
                thread1.Start();
                thread1.Join();


            }

            catch { }
        }


        private void display1()
        {
            EventLog.WriteEntry("Start display1", EventLogEntryType.Information);

            try
            {
                String strcode;
                string val;
                int num;

                strcode = stresive1.Substring(0, 9);
                val = stresive1.Substring(10, 3);
                num = int.Parse(val);
                val = Convert.ToString(num, 2);
                val = val.PadLeft(8, '0');

               
               
                if (strcode == "INPUT= 65")
                {
                    if (val.Substring(0, 1) == "1") { InsertData(1048, 17, 1); } else { InsertData(1048, 17, 0); }
                    if (val.Substring(1, 1) == "1") { InsertData(1048, 18, 1); } else { InsertData(1048, 18, 0); }
                    if (val.Substring(2, 1) == "1") { InsertData(1048, 19, 1); } else { InsertData(1048, 19, 0); }
                    if (val.Substring(3, 1) == "1") { InsertData(1048, 20, 1); } else { InsertData(1048, 20, 0); }
                    if (val.Substring(4, 1) == "1") { InsertData(1048, 21, 1); } else { InsertData(1048, 21, 0); }
                    if (val.Substring(5, 1) == "1") { InsertData(1048, 22, 1); } else { InsertData(1048, 22, 0); }
                    if (val.Substring(6, 1) == "1") { InsertData(1048, 23, 1); } else { InsertData(1048, 23, 0); }
                    if (val.Substring(7, 1) == "1") { InsertData(1048, 24, 1); } else { InsertData(1048, 24, 0); }

                }

                if (strcode == "INPUT= 66")
                {


                    if (val.Substring(0, 1) == "1") { InsertData(1048, 9, 1); } else { InsertData(1048, 9, 0); }
                    if (val.Substring(1, 1) == "1") { InsertData(1048, 10, 1); } else { InsertData(1048, 10, 0); }
                    if (val.Substring(2, 1) == "1") { InsertData(1048, 11, 1); } else { InsertData(1048, 11, 0); }
                    if (val.Substring(3, 1) == "1") { InsertData(1048, 12, 1); } else { InsertData(1048, 12, 0); }
                    if (val.Substring(4, 1) == "1") { InsertData(1048, 13, 1); } else { InsertData(1048, 13, 0); }
                    if (val.Substring(5, 1) == "1") { InsertData(1048, 14, 1); } else { InsertData(1048, 14, 0); }
                    if (val.Substring(6, 1) == "1") { InsertData(1048, 15, 1); } else { InsertData(1048, 15, 0); }
                    if (val.Substring(7, 1) == "1") { InsertData(1048, 16, 1); } else { InsertData(1048, 16, 0); }

                }
                if (strcode == "INPUT= 67")
                {

                    if (val.Substring(7, 1) == "1") { InsertData(1048, 1, 1); } else { InsertData(1048, 1, 0); }
                    if (val.Substring(6, 1) == "1") { InsertData(1048, 2, 1); } else { InsertData(1048, 2, 0); }
                    if (val.Substring(5, 1) == "1") { InsertData(1048, 3, 1); } else { InsertData(1048, 3, 0); }
                    if (val.Substring(4, 1) == "1") { InsertData(1048, 4, 1); } else { InsertData(1048, 4, 0); }
                    if (val.Substring(3, 1) == "1") { InsertData(1048, 5, 1); } else { InsertData(1048, 5, 0); }
                    if (val.Substring(2, 1) == "1") { InsertData(1048, 6, 1); } else { InsertData(1048, 6, 0); }
                    if (val.Substring(1, 1) == "1") { InsertData(1048, 7, 1); } else { InsertData(1048, 7, 0); }
                    if (val.Substring(0, 1) == "1") { InsertData(1048, 8, 1); } else { InsertData(1048, 8, 0); }

                }
            }
            catch { }



        }


        private void InsertData(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {
                switch (DeviceLineId)
                {
                    #region "01"
                    case 1:
                        {
                            if (ISStartInt1 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls1 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState1 = Convert.ToBoolean(StateID);
                                ISStartInt1 = true;

                            }
                            else
                            {
                                if (LstState1 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls1 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls1 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState1 = Convert.ToBoolean(StateID);
                                    ISStartInt1 = false;
                                    CountOfPuls1 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                             break;
                        }
                    #endregion
                    #region "02"
                    case 2:
                        {
                            if (ISStartInt2 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls2 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState2 = Convert.ToBoolean(StateID);
                                ISStartInt2 = true;

                            }
                            else
                            {
                                if (LstState2 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls2 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls2 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState2 = Convert.ToBoolean(StateID);
                                    ISStartInt2 = false;
                                    CountOfPuls2 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "03"
                    case 3:
                        {
                            if (ISStartInt3 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls3 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState3 = Convert.ToBoolean(StateID);
                                ISStartInt3 = true;

                            }
                            else
                            {
                                if (LstState3 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls3 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls3 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState3 = Convert.ToBoolean(StateID);
                                    ISStartInt3 = false;
                                    CountOfPuls3 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "04"
                    case 4:
                        {
                            if (ISStartInt4 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls4 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState4 = Convert.ToBoolean(StateID);
                                ISStartInt4 = true;

                            }
                            else
                            {
                                if (LstState4 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls4 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls4 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState4 = Convert.ToBoolean(StateID);
                                    ISStartInt4 = false;
                                    CountOfPuls4 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "05"
                    case 5:
                        {
                            if (ISStartInt5 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls5 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState5 = Convert.ToBoolean(StateID);
                                ISStartInt5 = true;

                            }
                            else
                            {
                                if (LstState5 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls5 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls5 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState5 = Convert.ToBoolean(StateID);
                                    ISStartInt5 = false;
                                    CountOfPuls5 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "06"
                    case 6:
                        {
                            if (ISStartInt6 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls6 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState6 = Convert.ToBoolean(StateID);
                                ISStartInt6 = true;

                            }
                            else
                            {
                                if (LstState6 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls6 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls6 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState6 = Convert.ToBoolean(StateID);
                                    ISStartInt6 = false;
                                    CountOfPuls6 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "07"
                    case 7:
                        {
                            if (ISStartInt7 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls7 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState7 = Convert.ToBoolean(StateID);
                                ISStartInt7 = true;

                            }
                            else
                            {
                                if (LstState7 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls7 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls7 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState7 = Convert.ToBoolean(StateID);
                                    ISStartInt7 = false;
                                    CountOfPuls7 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "08"
                    case 8:
                        {
                            if (ISStartInt8 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls8 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState8 = Convert.ToBoolean(StateID);
                                ISStartInt8 = true;

                            }
                            else
                            {
                                if (LstState8 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls8 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls8 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState8 = Convert.ToBoolean(StateID);
                                    ISStartInt8 = false;
                                    CountOfPuls8 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "09"
                    case 9:
                        {
                            if (ISStartInt9 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls9 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState9 = Convert.ToBoolean(StateID);
                                ISStartInt9 = true;

                            }
                            else
                            {
                                if (LstState9 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls9 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls9 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState9 = Convert.ToBoolean(StateID);
                                    ISStartInt9 = false;
                                    CountOfPuls9 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "10"
                    case 10:
                        {
                            if (ISStartInt10 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls10 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState10 = Convert.ToBoolean(StateID);
                                ISStartInt10 = true;

                            }
                            else
                            {
                                if (LstState10 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls10 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls10 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState10 = Convert.ToBoolean(StateID);
                                    ISStartInt10 = false;
                                    CountOfPuls10 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "11"
                    case 11:
                        {
                            if (ISStartInt11 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls11 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState11 = Convert.ToBoolean(StateID);
                                ISStartInt11 = true;

                            }
                            else
                            {
                                if (LstState11 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls11 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls11 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState11 = Convert.ToBoolean(StateID);
                                    ISStartInt11 = false;
                                    CountOfPuls11 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "12"
                    case 12:
                        {
                            if (ISStartInt12 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls12 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState12 = Convert.ToBoolean(StateID);
                                ISStartInt12 = true;

                            }
                            else
                            {
                                if (LstState12 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls12 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls12 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState12 = Convert.ToBoolean(StateID);
                                    ISStartInt12 = false;
                                    CountOfPuls12 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "13"
                    case 13:
                        {
                            if (ISStartInt13 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls13 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState13 = Convert.ToBoolean(StateID);
                                ISStartInt13 = true;

                            }
                            else
                            {
                                if (LstState13 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls13 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls13 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState13 = Convert.ToBoolean(StateID);
                                    ISStartInt13 = false;
                                    CountOfPuls13 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "14"
                    case 14:
                        {
                            if (ISStartInt14 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls14 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState14 = Convert.ToBoolean(StateID);
                                ISStartInt14 = true;

                            }
                            else
                            {
                                if (LstState14 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls14 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls14 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState14 = Convert.ToBoolean(StateID);
                                    ISStartInt14 = false;
                                    CountOfPuls14 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "15"
                    case 15:
                        {
                            if (ISStartInt15 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls15 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState15 = Convert.ToBoolean(StateID);
                                ISStartInt15 = true;

                            }
                            else
                            {
                                if (LstState15 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls15 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls15 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState15 = Convert.ToBoolean(StateID);
                                    ISStartInt15 = false;
                                    CountOfPuls15 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "16"
                    case 16:
                        {
                            if (ISStartInt16 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls16 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState16 = Convert.ToBoolean(StateID);
                                ISStartInt16 = true;

                            }
                            else
                            {
                                if (LstState16 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls16 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls16 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState16 = Convert.ToBoolean(StateID);
                                    ISStartInt16 = false;
                                    CountOfPuls16 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "17"
                    case 17:
                        {
                            if (ISStartInt17 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls17 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState17 = Convert.ToBoolean(StateID);
                                ISStartInt17 = true;

                            }
                            else
                            {
                                if (LstState17 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls17 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls17 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState17 = Convert.ToBoolean(StateID);
                                    ISStartInt17 = false;
                                    CountOfPuls17 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "18"
                    case 18:
                        {
                            if (ISStartInt18 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls18 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState18 = Convert.ToBoolean(StateID);
                                ISStartInt18 = true;

                            }
                            else
                            {
                                if (LstState18 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls18 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls18 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState18 = Convert.ToBoolean(StateID);
                                    ISStartInt18 = false;
                                    CountOfPuls18 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "19"
                    case 19:
                        {
                            if (ISStartInt19 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls19 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState19 = Convert.ToBoolean(StateID);
                                ISStartInt19 = true;

                            }
                            else
                            {
                                if (LstState19 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls19 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls19 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState19 = Convert.ToBoolean(StateID);
                                    ISStartInt19 = false;
                                    CountOfPuls19 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "20"
                    case 20:
                        {
                            if (ISStartInt20 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls20 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState20 = Convert.ToBoolean(StateID);
                                ISStartInt20 = true;

                            }
                            else
                            {
                                if (LstState20 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls20 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls20 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState20 = Convert.ToBoolean(StateID);
                                    ISStartInt20 = false;
                                    CountOfPuls20 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "21"
                    case 21:
                        {
                            if (ISStartInt21 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls21 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState21 = Convert.ToBoolean(StateID);
                                ISStartInt21 = true;

                            }
                            else
                            {
                                if (LstState21 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls21 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls21 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState21 = Convert.ToBoolean(StateID);
                                    ISStartInt21 = false;
                                    CountOfPuls21 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "22"
                    case 22:
                        {
                            if (ISStartInt22 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls22 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState22 = Convert.ToBoolean(StateID);
                                ISStartInt22 = true;

                            }
                            else
                            {
                                if (LstState22 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls22 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls22 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState22 = Convert.ToBoolean(StateID);
                                    ISStartInt22 = false;
                                    CountOfPuls22 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "23"
                    case 23:
                        {
                            if (ISStartInt23 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls23 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState23 = Convert.ToBoolean(StateID);
                                ISStartInt23 = true;

                            }
                            else
                            {
                                if (LstState23 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls23 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls23 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState23 = Convert.ToBoolean(StateID);
                                    ISStartInt23 = false;
                                    CountOfPuls23 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                    #endregion
                    #region "24"
                    case 24:
                        {
                            if (ISStartInt24 == false)
                            {

                                sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurrentDate.GetIrani8DateStr_CurDate() + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "'," + StateID + "," + ++CountOfPuls24 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                                LstState24 = Convert.ToBoolean(StateID);
                                ISStartInt24 = true;

                            }
                            else
                            {
                                if (LstState24 == Convert.ToBoolean(StateID))
                                {

                                    sqlstr = "update    Tb_Client  set  enddate='" + CurrentDate.GetIrani8DateStr_CurDate() + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls24 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                                }
                                else
                                {

                                    sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                                    DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                                    DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                                    totalHours = (EndDate - FirstDate).TotalMinutes;
                                    sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurrentDate.GetIrani8DateStr_CurDate() + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ":" + DateTime.Now.Millisecond + "',[Count]=" + ++CountOfPuls24 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                                    Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                                    LstState24 = Convert.ToBoolean(StateID);
                                    ISStartInt24 = false;
                                    CountOfPuls24 = 0;
                                }

                            }

                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                            break;
                        }
                        #endregion


                }
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message, EventLogEntryType.Information);
            }
        }


        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void serialPort3_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void serialPort4_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void serialPort5_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void serialPort6_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void serialPort7_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void serialPort8_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void serialPort9_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void serialPort10_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }
    }
}
