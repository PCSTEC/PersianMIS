using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace PCSTECWindowsService
{
    public partial class Frm_Main : Form
    {
        bool IsFormHide = true;
        BLL.CLS_Client Bll_Client = new BLL.CLS_Client();

        double totalHours;
        Persistent.DataAccess.DataAccess Pers = new Persistent.DataAccess.DataAccess();
        string stresive1;
        IraniDate.IraniDate.IraniDate IRdate = new IraniDate.IraniDate.IraniDate();
        Boolean isNextDay = false;
        PersianCalendar pc = new PersianCalendar();
        string sqlstr = "";

        int DeviceStateID1 = 0;
        int DeviceStateID2 = 0;
        int DeviceStateID3 = 0;
        int DeviceStateID4 = 0;
        int DeviceStateID5 = 0;
        int DeviceStateID6 = 0;
        int DeviceStateID7 = 0;
        int DeviceStateID8 = 0;
        int DeviceStateID9 = 0;
        int DeviceStateID10 = 0;
        int DeviceStateID11 = 0;
        int DeviceStateID12 = 0;
        int DeviceStateID13 = 0;
        int DeviceStateID14 = 0;
        int DeviceStateID15 = 0;
        int DeviceStateID16 = 0;
        int DeviceStateID17 = 0;
        int DeviceStateID18 = 0;
        int DeviceStateID19 = 0;
        int DeviceStateID20 = 0;
        int DeviceStateID21 = 0;
        int DeviceStateID22 = 0;
        int DeviceStateID23 = 0;
        int DeviceStateID24 = 0;

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
        string CurShamsiDate = "";

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
        IraniDate.IraniDate.IraniDate CurrentDate = new IraniDate.IraniDate.IraniDate();

        string stresive;
        public Frm_Main()
        {

            InitializeComponent();

        }


        private void Frm_Main_Load(object sender, EventArgs e)
        {
            var x = DateTime.Now.ToString();

            serialPort1.Close();
            try
            {
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.BaudRate = int.Parse("9600");
                serialPort1.PortName = "COM3";
                serialPort1.Open();
                serialPort1.DiscardInBuffer();
                label1.Text = "CONNECT";
                label1.BackColor = Color.Green;
            }
            catch
            {
                label1.Text = "DISCONNECT";
                label1.BackColor = Color.Red;
                MessageBox.Show("Can't Access ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void display(object sender, EventArgs e)
        {


            try
            {
                String strcode;
                string val;
                int num;

                strcode = stresive.Substring(0, 9);
                val = stresive.Substring(10, 3);
                num = int.Parse(val);
                val = Convert.ToString(num, 2);
                val = val.PadLeft(8, '0');



                if (strcode == "INPUT= 65")
                {

                    if (val.Substring(0, 1) == "1") { INPUT17.Checked = true; INPUT17.BackColor = Color.LawnGreen; } else { INPUT17.Checked = false; INPUT17.BackColor = Color.Red; }
                    if (val.Substring(1, 1) == "1") { INPUT18.Checked = true; INPUT18.BackColor = Color.LawnGreen; } else { INPUT18.Checked = false; INPUT18.BackColor = Color.Red; }
                    if (val.Substring(2, 1) == "1") { INPUT19.Checked = true; INPUT19.BackColor = Color.LawnGreen; } else { INPUT19.Checked = false; INPUT19.BackColor = Color.Red; }
                    if (val.Substring(3, 1) == "1") { INPUT20.Checked = true; INPUT20.BackColor = Color.LawnGreen; } else { INPUT20.Checked = false; INPUT20.BackColor = Color.Red; }
                    if (val.Substring(4, 1) == "1") { INPUT21.Checked = true; INPUT21.BackColor = Color.LawnGreen; } else { INPUT21.Checked = false; INPUT21.BackColor = Color.Red; }
                    if (val.Substring(5, 1) == "1") { INPUT22.Checked = true; INPUT22.BackColor = Color.LawnGreen; } else { INPUT22.Checked = false; INPUT22.BackColor = Color.Red; }
                    if (val.Substring(6, 1) == "1") { INPUT23.Checked = true; INPUT23.BackColor = Color.LawnGreen; } else { INPUT23.Checked = false; INPUT23.BackColor = Color.Red; }
                    if (val.Substring(7, 1) == "1") { INPUT24.Checked = true; INPUT24.BackColor = Color.LawnGreen; } else { INPUT24.Checked = false; INPUT24.BackColor = Color.Red; }
                }

                if (strcode == "INPUT= 66")
                {


                    if (val.Substring(0, 1) == "1") { INPUT9.Checked = true; INPUT9.BackColor = Color.LawnGreen; } else { INPUT9.Checked = false; INPUT9.BackColor = Color.Red; }
                    if (val.Substring(1, 1) == "1") { INPUT10.Checked = true; INPUT10.BackColor = Color.LawnGreen; } else { INPUT10.Checked = false; INPUT10.BackColor = Color.Red; }
                    if (val.Substring(2, 1) == "1") { INPUT11.Checked = true; INPUT11.BackColor = Color.LawnGreen; } else { INPUT11.Checked = false; INPUT11.BackColor = Color.Red; }
                    if (val.Substring(3, 1) == "1") { INPUT12.Checked = true; INPUT12.BackColor = Color.LawnGreen; } else { INPUT12.Checked = false; INPUT12.BackColor = Color.Red; }
                    if (val.Substring(4, 1) == "1") { INPUT13.Checked = true; INPUT13.BackColor = Color.LawnGreen; } else { INPUT13.Checked = false; INPUT13.BackColor = Color.Red; }
                    if (val.Substring(5, 1) == "1") { INPUT14.Checked = true; INPUT14.BackColor = Color.LawnGreen; } else { INPUT14.Checked = false; INPUT14.BackColor = Color.Red; }
                    if (val.Substring(6, 1) == "1") { INPUT15.Checked = true; INPUT15.BackColor = Color.LawnGreen; } else { INPUT15.Checked = false; INPUT15.BackColor = Color.Red; }
                    if (val.Substring(7, 1) == "1") { INPUT16.Checked = true; INPUT16.BackColor = Color.LawnGreen; } else { INPUT16.Checked = false; INPUT16.BackColor = Color.Red; }




                }
                if (strcode == "INPUT= 67")
                {

                    if (val.Substring(7, 1) == "1") { INPUT1.Checked = true; INPUT1.BackColor = Color.LawnGreen; } else { INPUT1.Checked = false; INPUT1.BackColor = Color.Red; }
                    if (val.Substring(6, 1) == "1") { INPUT2.Checked = true; INPUT2.BackColor = Color.LawnGreen; } else { INPUT2.Checked = false; INPUT2.BackColor = Color.Red; }
                    if (val.Substring(5, 1) == "1") { INPUT3.Checked = true; INPUT3.BackColor = Color.LawnGreen; } else { INPUT3.Checked = false; INPUT3.BackColor = Color.Red; }
                    if (val.Substring(4, 1) == "1") { INPUT4.Checked = true; INPUT4.BackColor = Color.LawnGreen; } else { INPUT4.Checked = false; INPUT4.BackColor = Color.Red; }
                    if (val.Substring(3, 1) == "1") { INPUT5.Checked = true; INPUT5.BackColor = Color.LawnGreen; } else { INPUT5.Checked = false; INPUT5.BackColor = Color.Red; }
                    if (val.Substring(2, 1) == "1") { INPUT6.Checked = true; INPUT6.BackColor = Color.LawnGreen; } else { INPUT6.Checked = false; INPUT6.BackColor = Color.Red; }
                    if (val.Substring(1, 1) == "1") { INPUT7.Checked = true; INPUT7.BackColor = Color.LawnGreen; } else { INPUT7.Checked = false; INPUT7.BackColor = Color.Red; }
                    if (val.Substring(0, 1) == "1") { INPUT8.Checked = true; INPUT8.BackColor = Color.LawnGreen; } else { INPUT8.Checked = false; INPUT8.BackColor = Color.Red; }

                }






            }
            catch (Exception error)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'DISPLAY METHOD ERROR : UnSuccess Insert Data With Method InsertData in db!!!" + error.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


            }


        }





        private void InsertData1(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt1)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls1 + ", (SELECT GETDATE() AS CurrentDateTime) )";
 
                        LstState1 = Convert.ToBoolean(StateID);
                        ISStartInt1 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);

                    if (Cls_Public.PublicDT.Rows.Count > 0)
                    {
                        DeviceStateID1 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());
                    }
                    return;


                }
                else
                {
                    if (LstState1 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls1 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls1 + " where  DevicestateID='" + DeviceStateID1 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID1 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls1 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls1 + " where DevicestateID='" + DeviceStateID1 + "'";

                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        LstState1 = Convert.ToBoolean(StateID);
                        ISStartInt1 = false;
                        CountOfPuls1 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                ISStartInt1 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls1 + " where  DevicestateID= '" + DeviceStateID1 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }
        private void InsertData2(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {

                if (!ISStartInt2)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls2 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState2 = Convert.ToBoolean(StateID);
                    ISStartInt2 = true;

                }
                else
                {
                    if (LstState2 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls2 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls2 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState2 = Convert.ToBoolean(StateID);
                        ISStartInt2 = false;
                        CountOfPuls2 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                ISStartInt2 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls2 + " where  DevicestateID= '" + DeviceStateID2 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }
        private void InsertData3(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {

                if (!ISStartInt3)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls3 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState3 = Convert.ToBoolean(StateID);
                    ISStartInt3 = true;

                }
                else
                {
                    if (LstState3 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls3 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls3 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState3 = Convert.ToBoolean(StateID);
                        ISStartInt3 = false;
                        CountOfPuls3 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


            }
            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }

        private void InsertData4(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {
                if (!ISStartInt4)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls4 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState4 = Convert.ToBoolean(StateID);
                    ISStartInt4 = true;

                }
                else
                {
                    if (LstState4 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls4 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls4 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState4 = Convert.ToBoolean(StateID);
                        ISStartInt4 = false;
                        CountOfPuls4 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


            }
            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }
        private void InsertData5(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {


                if (!ISStartInt5)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls5 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState5 = Convert.ToBoolean(StateID);
                    ISStartInt5 = true;

                }
                else
                {
                    if (LstState5 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls5 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls5 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState5 = Convert.ToBoolean(StateID);
                        ISStartInt5 = false;
                        CountOfPuls5 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }

        private void InsertData6(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {

                if (!ISStartInt6)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls6 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState6 = Convert.ToBoolean(StateID);
                    ISStartInt6 = true;

                }
                else
                {
                    if (LstState6 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls6 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls6 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState6 = Convert.ToBoolean(StateID);
                        ISStartInt6 = false;
                        CountOfPuls6 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }
        private void InsertData7(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {
                if (!ISStartInt7)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls7 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState7 = Convert.ToBoolean(StateID);
                    ISStartInt7 = true;

                }
                else
                {
                    if (LstState7 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls7 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls7 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState7 = Convert.ToBoolean(StateID);
                        ISStartInt7 = false;
                        CountOfPuls7 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }

        private void InsertData8(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {
                if (!ISStartInt8)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls8 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState8 = Convert.ToBoolean(StateID);
                    ISStartInt8 = true;

                }
                else
                {
                    if (LstState8 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls8 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls8 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState8 = Convert.ToBoolean(StateID);
                        ISStartInt8 = false;
                        CountOfPuls8 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }
        private void InsertData9(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {

                if (!ISStartInt9)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls9 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState9 = Convert.ToBoolean(StateID);
                    ISStartInt9 = true;

                }
                else
                {
                    if (LstState9 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls9 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls9 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState9 = Convert.ToBoolean(StateID);
                        ISStartInt9 = false;
                        CountOfPuls9 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }

        private void InsertData10(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {
                if (!ISStartInt10)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls10 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState10 = Convert.ToBoolean(StateID);
                    ISStartInt10 = true;

                }
                else
                {
                    if (LstState10 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls10 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls10 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState10 = Convert.ToBoolean(StateID);
                        ISStartInt10 = false;
                        CountOfPuls10 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }

            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }

        private void InsertData11(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {
                if (!ISStartInt11)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls11 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState11 = Convert.ToBoolean(StateID);
                    ISStartInt11 = true;

                }
                else
                {
                    if (LstState11 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls11 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls11 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState11 = Convert.ToBoolean(StateID);
                        ISStartInt11 = false;
                        CountOfPuls11 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }

            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }

        private void InsertData12(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {
                if (!ISStartInt12)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls12 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState12 = Convert.ToBoolean(StateID);
                    ISStartInt12 = true;

                }
                else
                {
                    if (LstState12 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls12 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls12 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState12 = Convert.ToBoolean(StateID);
                        ISStartInt12 = false;
                        CountOfPuls12 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


            }

            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }
        private void InsertData13(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {

                if (!ISStartInt13)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls13 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState13 = Convert.ToBoolean(StateID);
                    ISStartInt13 = true;

                }
                else
                {
                    if (LstState13 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls13 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls13 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState13 = Convert.ToBoolean(StateID);
                        ISStartInt13 = false;
                        CountOfPuls13 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }

        private void InsertData14(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {

                if (!ISStartInt14)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls14 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState14 = Convert.ToBoolean(StateID);
                    ISStartInt14 = true;

                }
                else
                {
                    if (LstState14 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls14 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls14 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState14 = Convert.ToBoolean(StateID);
                        ISStartInt14 = false;
                        CountOfPuls14 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }

            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }


        private void InsertData15(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {

                if (!ISStartInt15)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls15 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState15 = Convert.ToBoolean(StateID);
                    ISStartInt15 = true;

                }
                else
                {
                    if (LstState15 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls15 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls15 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState15 = Convert.ToBoolean(StateID);
                        ISStartInt15 = false;
                        CountOfPuls15 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }

            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }

        //private void InsertData16(int DeviceId, int DeviceLineId, int StateID)
        //{
        //    try
        //    {
        //        if (!ISStartInt16)
        //        {

        //            sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls16 + ", (SELECT GETDATE() AS CurrentDateTime) )";
        //            LstState16 = Convert.ToBoolean(StateID);
        //            ISStartInt16 = true;

        //        }
        //        else
        //        {
        //            if (LstState16 == Convert.ToBoolean(StateID))
        //            {

        //                sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls16 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

        //            }
        //            else
        //            {

        //                sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
        //                Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
        //                DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
        //                DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


        //                totalHours = (EndDate - FirstDate).TotalSeconds;
        //                sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls16 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
        //                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


        //                LstState16 = Convert.ToBoolean(StateID);
        //                ISStartInt16 = false;
        //                CountOfPuls16 = 0;
        //            }

        //        }

        //        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

        //    }

        //    catch (Exception e)
        //    {
        //        EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message, EventLogEntryType.Information);
        //    }
        //}



        private void InsertData16(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {
                if (!ISStartInt16)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls16 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState16 = Convert.ToBoolean(StateID);
                    ISStartInt16 = true;

                }
                else
                {
                    if (LstState16 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls16 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls16 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState16 = Convert.ToBoolean(StateID);
                        ISStartInt16 = false;
                        CountOfPuls16 = 0;
                    }

                }


                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }

            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }




        private void InsertData17(int DeviceId, int DeviceLineId, int StateID)
        {

            try
            {
                if (!ISStartInt17)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls17 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState17 = Convert.ToBoolean(StateID);
                    ISStartInt17 = true;

                }
                else
                {
                    if (LstState17 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls17 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls17 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState17 = Convert.ToBoolean(StateID);
                        ISStartInt17 = false;
                        CountOfPuls17 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }

            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }

        private void InsertData18(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {

                if (!ISStartInt18)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls18 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState18 = Convert.ToBoolean(StateID);
                    ISStartInt18 = true;

                }
                else
                {
                    if (LstState18 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls18 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls18 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState18 = Convert.ToBoolean(StateID);
                        ISStartInt18 = false;
                        CountOfPuls18 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }

            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }



        private void InsertData19(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {

                if (!ISStartInt19)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls19 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState19 = Convert.ToBoolean(StateID);
                    ISStartInt19 = true;

                }
                else
                {
                    if (LstState19 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls19 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls19 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState19 = Convert.ToBoolean(StateID);
                        ISStartInt19 = false;
                        CountOfPuls19 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }

            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }




        private void InsertData20(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {

                if (!ISStartInt20)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls20 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState20 = Convert.ToBoolean(StateID);
                    ISStartInt20 = true;

                }
                else
                {
                    if (LstState20 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls20 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls20 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState20 = Convert.ToBoolean(StateID);
                        ISStartInt20 = false;
                        CountOfPuls20 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }

            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }


        private void InsertData21(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {

                if (!ISStartInt21)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls21 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState21 = Convert.ToBoolean(StateID);
                    ISStartInt21 = true;

                }
                else
                {
                    if (LstState21 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls21 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls21 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState21 = Convert.ToBoolean(StateID);
                        ISStartInt21 = false;
                        CountOfPuls21 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }

            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }


        private void InsertData22(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {

                if (!ISStartInt22)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls22 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState22 = Convert.ToBoolean(StateID);
                    ISStartInt22 = true;

                }
                else
                {
                    if (LstState22 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls22 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls22 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState22 = Convert.ToBoolean(StateID);
                        ISStartInt22 = false;
                        CountOfPuls22 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }

            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }

        private void InsertData23(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {

                if (!ISStartInt23)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls23 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState23 = Convert.ToBoolean(StateID);
                    ISStartInt23 = true;

                }
                else
                {
                    if (LstState23 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls23 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls23 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState23 = Convert.ToBoolean(StateID);
                        ISStartInt23 = false;
                        CountOfPuls23 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }

            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
            }
        }

        private void InsertData24(int DeviceId, int DeviceLineId, int StateID)
        {
            try
            {


                if (!ISStartInt24)
                {

                    sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls24 + ", (SELECT GETDATE() AS CurrentDateTime) )";
                    LstState24 = Convert.ToBoolean(StateID);
                    ISStartInt24 = true;

                }
                else
                {
                    if (LstState24 == Convert.ToBoolean(StateID))
                    {

                        sqlstr = "update    Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls24 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                    }
                    else
                    {

                        sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


                        totalHours = (EndDate - FirstDate).TotalSeconds;
                        sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=(SELECT GETDATE() AS CurrentDateTime)  , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls24 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);


                        LstState24 = Convert.ToBoolean(StateID);
                        ISStartInt24 = false;
                        CountOfPuls24 = 0;
                    }

                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }

            catch (Exception e)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }




        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {


                CurShamsiDate = IRdate.GetIrani8DateStr_CurDate();
                stresive = serialPort1.ReadLine();
                this.Invoke(new EventHandler(display));

            }

            catch (Exception error)
            {
                sqlstr = "insert into Tb_ClientLog ([ComputerCode],[Date],[LogMsg])values ('" + System.Environment.MachineName + ", (SELECT GETDATE() AS CurrentDateTime)  , 'ERROR DATA RECIVED serialPort1_DataReceived : UnSuccess Insert Data With Method InsertData in db!!!" + error.Message + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }


        private void MainIcon_DoubleClick(object sender, EventArgs e)
        {
            IsFormHide = false;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_Main_Activated(object sender, EventArgs e)
        {
            if (IsFormHide == true)
            {
                this.Hide();
                this.Visible = false;

            }
            else
            {
                this.Show();
                this.Visible = true;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {



            if (DateTime.Now.Hour == 00 && isNextDay == false)
            {
                InsertData1(1048, 17, Convert.ToInt32(!LstState1));
                InsertData2(1048, 17, Convert.ToInt32(!LstState2));
                InsertData3(1048, 17, Convert.ToInt32(!LstState3));
                InsertData4(1048, 17, Convert.ToInt32(!LstState4));
                InsertData5(1048, 17, Convert.ToInt32(!LstState5));
                InsertData6(1048, 17, Convert.ToInt32(!LstState6));
                InsertData7(1048, 17, Convert.ToInt32(!LstState7));
                InsertData8(1048, 17, Convert.ToInt32(!LstState8));
                InsertData9(1048, 17, Convert.ToInt32(!LstState9));
                InsertData10(1048, 17, Convert.ToInt32(!LstState10));
                InsertData11(1048, 17, Convert.ToInt32(!LstState11));
                InsertData12(1048, 17, Convert.ToInt32(!LstState12));
                InsertData13(1048, 17, Convert.ToInt32(!LstState13));
                InsertData14(1048, 17, Convert.ToInt32(!LstState14));
                InsertData15(1048, 17, Convert.ToInt32(!LstState15));
                InsertData16(1048, 17, Convert.ToInt32(!LstState16));
                InsertData17(1048, 17, Convert.ToInt32(!LstState17));
                InsertData18(1048, 17, Convert.ToInt32(!LstState18));
                InsertData19(1048, 17, Convert.ToInt32(!LstState19));
                InsertData20(1048, 17, Convert.ToInt32(!LstState20));
                InsertData21(1048, 17, Convert.ToInt32(!LstState21));
                InsertData22(1048, 17, Convert.ToInt32(!LstState22));
                InsertData23(1048, 17, Convert.ToInt32(!LstState23));
                InsertData24(1048, 17, Convert.ToInt32(!LstState24));
                isNextDay = true;
            }
            else
            {


                if (INPUT17.BackColor == Color.LawnGreen) { InsertData17(1048, 17, 1); } else { InsertData17(1048, 17, 0); }
                if (INPUT18.BackColor == Color.LawnGreen) { InsertData18(1048, 18, 1); } else { InsertData18(1048, 18, 0); }
                if (INPUT19.BackColor == Color.LawnGreen) { InsertData19(1048, 19, 1); } else { InsertData19(1048, 19, 0); }
                if (INPUT20.BackColor == Color.LawnGreen) { InsertData20(1048, 20, 1); } else { InsertData20(1048, 20, 0); }
                if (INPUT21.BackColor == Color.LawnGreen) { InsertData21(1048, 21, 1); } else { InsertData21(1048, 21, 0); }
                if (INPUT22.BackColor == Color.LawnGreen) { InsertData22(1048, 22, 1); } else { InsertData22(1048, 22, 0); }
                if (INPUT23.BackColor == Color.LawnGreen) { InsertData23(1048, 23, 1); } else { InsertData23(1048, 23, 0); }
                if (INPUT24.BackColor == Color.LawnGreen) { InsertData24(1048, 24, 1); } else { InsertData24(1048, 24, 0); }




                if (INPUT9.BackColor == Color.LawnGreen) { InsertData9(1048, 9, 1); } else { InsertData9(1048, 9, 0); }
                if (INPUT10.BackColor == Color.LawnGreen) { InsertData10(1048, 10, 1); } else { InsertData10(1048, 10, 0); }
                if (INPUT11.BackColor == Color.LawnGreen) { InsertData11(1048, 11, 1); } else { InsertData11(1048, 11, 0); }
                if (INPUT12.BackColor == Color.LawnGreen) { InsertData12(1048, 12, 1); } else { InsertData12(1048, 12, 0); }
                if (INPUT13.BackColor == Color.LawnGreen) { InsertData13(1048, 13, 1); } else { InsertData13(1048, 13, 0); }
                if (INPUT14.BackColor == Color.LawnGreen) { InsertData14(1048, 14, 1); } else { InsertData14(1048, 14, 0); }
                if (INPUT15.BackColor == Color.LawnGreen) { InsertData15(1048, 15, 1); } else { InsertData15(1048, 15, 0); }
                if (INPUT16.BackColor == Color.LawnGreen) { InsertData16(1048, 16, 1); } else { InsertData16(1048, 16, 0); }


                if (INPUT1.BackColor == Color.LawnGreen) { InsertData1(1048, 1, 1); } else { InsertData1(1048, 1, 0); }
                if (INPUT2.BackColor == Color.LawnGreen) { InsertData2(1048, 2, 1); } else { InsertData2(1048, 2, 0); }
                if (INPUT3.BackColor == Color.LawnGreen) { InsertData3(1048, 3, 1); } else { InsertData3(1048, 3, 0); }
                if (INPUT4.BackColor == Color.LawnGreen) { InsertData4(1048, 4, 1); } else { InsertData4(1048, 4, 0); }
                if (INPUT5.BackColor == Color.LawnGreen) { InsertData5(1048, 5, 1); } else { InsertData5(1048, 5, 0); }
                if (INPUT6.BackColor == Color.LawnGreen) { InsertData6(1048, 6, 1); } else { InsertData6(1048, 6, 0); }
                if (INPUT7.BackColor == Color.LawnGreen) { InsertData7(1048, 7, 1); } else { InsertData7(1048, 7, 0); }
                if (INPUT8.BackColor == Color.LawnGreen) { InsertData8(1048, 8, 1); } else { InsertData8(1048, 8, 0); }
                if (DateTime.Now.Hour == 01) { isNextDay = false; }
            }
        }
    }
}
