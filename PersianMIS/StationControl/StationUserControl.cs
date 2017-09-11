using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using IKIDUtility;
namespace PersianMIS.StationControl
{
    public partial class StationUserControl : UserControl
    {
        public DataTable DTLastState = new DataTable();
        public int DeviceId, LineID, DeviceTypeCode;
        public string ActiveStateDesc, DeActiveStateDesc, ProductLineDesc, deviceDesc, Linedesc, MiladiStartDate, MiladiStartTime, ShamsiStartDate, MiladiEndTime, MiladiiEndDate;

        private void Pnl_State_Paint(object sender, PaintEventArgs e)
        {

        }

        IKIDUtility.IKIDUtility.Formating Utility = new IKIDUtility.IKIDUtility.Formating();
        private void TimerState_Tick(object sender, EventArgs e)
        {
           

        }

        DataTable Dt = new DataTable();
        BLL.CLS_DeviceLine Bll_DeviceLine = new CLS_DeviceLine();
        public DevComponents.DotNetBar.PanelEx TitleBar
        {
            get { return TopPnl; }
        }
        public DevComponents.DotNetBar.BubbleButton BtnColse
        {
            get { return BtnClosed; }
        }





        public StationUserControl()
        {
            InitializeComponent();


        }

        //public void CreateObjectsForCount()
        //{
        //    int ConnectTime = 0, DisconnectedTime = 0;
        //    Lbl_ParameterDesc.Text = ProductLineDesc;
        //    Lbl_DeviceDesc.Text = deviceDesc;
        //    Lbl_LineDesc.Text = Linedesc;
        //    Lbl_ActiveName.Text = ActiveStateDesc;
        //    Lbl_DeActiveName.Text = DeActiveStateDesc;
        //    Dt = Bll_DeviceLine.GetSpecialLineStateByDate(DeviceId.ToString(), LineID.ToString(), MiladiStartDate, MiladiStartTime, MiladiiEndDate, MiladiEndTime);
        //    DTLastState = Bll_DeviceLine.GetLastStateFromSpecialLineStateByDate(DeviceId.ToString(), LineID.ToString(), MiladiStartDate, MiladiStartTime);
        //    if (Dt.Rows.Count > 0)
        //    {
        //        if (Dt.DefaultView[0]["StateId"].ToString() == "0")
        //        {
        //            Lbl_DeActiveName.Text = DeActiveStateDesc + ":";
        //            DisconnectedTime = Convert.ToInt32(Utility.NZ(Dt.DefaultView[0]["SumDuration"].ToString(), 0));
        //            Lbl_SumDisconnectTime.Text = (DisconnectedTime / 60).ToString();
        //        }

        //        if (Dt.Rows.Count > 1 || Dt.DefaultView[0]["StateId"].ToString() == "1")
        //        {

        //            Dt = Bll_DeviceLine.GetSpecialLineStateByDateDateForCount(DeviceId.ToString(), LineID.ToString(), MiladiStartDate, MiladiStartTime, "", "");
        //            if (Dt.Rows.Count > 0)
        //            {

        //                Lbl_ActiveName.Text = ActiveStateDesc + ":";
        //                Lbl_SumConnectTime.Text = Dt.DefaultView[0]["Count"].ToString();
        //            }
        //        }
        //    }



        //    if (DTLastState.Rows.Count > 0 && DTLastState.DefaultView[0]["StateId"].ToString() == "0")
        //    {
        //        double totalHours;
        //        DateTime FirstDate = DateTime.Parse(DTLastState.DefaultView[0]["MiladiStartDateTime"].ToString());
        //        DateTime EndDate = DateTime.Parse(DTLastState.DefaultView[0]["MiladiFinishDateTime"].ToString());


        //        totalHours = (EndDate - FirstDate).TotalSeconds;

        //        Lbl_SumDisconnectTime.Text = Convert.ToString(Convert.ToInt32(totalHours) + DisconnectedTime);
        //    }


        //    TimerState.Enabled = true;
        //}

        //public void CreateObjects()
        //{
        //    int ConnectTime = 0, DisconnectedTime = 0;
        //    Lbl_ParameterDesc.Text = ProductLineDesc;
        //    Lbl_DeviceDesc.Text = deviceDesc;
        //    Lbl_LineDesc.Text = Linedesc;
        //    Lbl_ActiveName.Text = ActiveStateDesc;
        //    Lbl_DeActiveName.Text = DeActiveStateDesc;
        //    Dt = Bll_DeviceLine.GetSpecialLineStateByDate(DeviceId.ToString(), LineID.ToString(), MiladiStartDate, MiladiStartTime, MiladiiEndDate, MiladiEndTime);
        //    DTLastState = Bll_DeviceLine.GetLastStateFromSpecialLineStateByDate(DeviceId.ToString(), LineID.ToString(), MiladiStartDate, MiladiStartTime);
        //    if (Dt.Rows.Count > 0)
        //    {
        //        if (Dt.DefaultView[0]["StateId"].ToString() == "0")
        //        {
        //            Lbl_DeActiveName.Text = DeActiveStateDesc + ":";
        //            DisconnectedTime = Convert.ToInt32(Utility.NZ(Dt.DefaultView[0]["SumDuration"].ToString(), 0));
        //            Lbl_SumDisconnectTime.Text = (DisconnectedTime / 60).ToString();
        //        }

        //        if (Dt.Rows.Count > 1 || Dt.DefaultView[0]["StateId"].ToString() == "1")
        //        {
        //            if (Dt.Rows.Count > 1)
        //            {
        //                ConnectTime = Convert.ToInt32(Utility.NZ(Dt.DefaultView[1]["SumDuration"].ToString(), 0));
        //            }
        //            if (Dt.DefaultView[0]["StateId"].ToString() == "1")
        //            {
        //                ConnectTime = Convert.ToInt32(Utility.NZ(Dt.DefaultView[0]["SumDuration"].ToString(), 0));
        //            }
        //            Lbl_ActiveName.Text = ActiveStateDesc + ":";
        //            Lbl_SumConnectTime.Text = (ConnectTime / 60).ToString();
        //        }
        //    }


        //    if (DTLastState.Rows.Count > 0 && DTLastState.DefaultView[0]["StateId"].ToString() == "1" && DBNull.Value.Equals(DTLastState.DefaultView[0]["Duration"].ToString()))
        //    {
        //        double totalHours;
        //        DateTime FirstDate = DateTime.Parse(DTLastState.DefaultView[0]["MiladiStartDateTime"].ToString());
        //        DateTime EndDate = DateTime.Parse(DTLastState.DefaultView[0]["MiladiFinishDateTime"].ToString());


        //        totalHours = (EndDate - FirstDate).TotalSeconds;

        //        Lbl_SumConnectTime.Text = Convert.ToString((Convert.ToInt32(totalHours) + ConnectTime) / 60);
        //    }

        //    if (DTLastState.Rows.Count > 0 && DTLastState.DefaultView[0]["StateId"].ToString() == "0" && DBNull.Value.Equals(DTLastState.DefaultView[0]["Duration"].ToString()))
        //    {
        //        double totalHours;
        //        DateTime FirstDate = DateTime.Parse(DTLastState.DefaultView[0]["MiladiStartDateTime"].ToString());
        //        DateTime EndDate = DateTime.Parse(DTLastState.DefaultView[0]["MiladiFinishDateTime"].ToString());


        //        totalHours = (EndDate - FirstDate).TotalSeconds;

        //        Lbl_SumDisconnectTime.Text = Convert.ToString((totalHours + DisconnectedTime) / 60);
        //    }


        //    TimerState.Enabled = true;
        //}



        public FlowLayoutPanel MainPnl
        {
            get { return Pnl_Main; }

        }

        private void StationUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
