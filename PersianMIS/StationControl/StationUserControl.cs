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
        BLL.Cls_Station Bll_Station = new Cls_Station();

        BLL.Cls_PublicOperations Bll_Public = new BLL.Cls_PublicOperations();
     public    DateTime StartDate, EndDate = new DateTime();
        private void Pnl_State_Paint(object sender, PaintEventArgs e)
        {

        }


        IKIDUtility.IKIDUtility.Formating Utility = new IKIDUtility.IKIDUtility.Formating();
        private void TimerState_Tick(object sender, EventArgs e)
        {
            FillData();


        }

        DataTable Dt = new DataTable();
        BLL.CLS_DeviceLine Bll_DeviceLine = new CLS_DeviceLine();
        public DevComponents.DotNetBar.PanelEx TitleBar
        {
            get { return TopPnl; }
            set { TopPnl = TitleBar; }
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



        public Panel MainPnl
        {
            get { return Pnl_Main; }

        }

        private void FillData()
        {
            BLL.Cls_PublicOperations.Dt = Bll_Station.GetClientData(this.Tag.ToString());
            Pnl_Main.Controls.Clear();
          
            for (int i = 0; i < BLL.Cls_PublicOperations.Dt.Rows.Count; i++)
            {
                Panel Pnl_State = new Panel();
                // Pnl_State.Location = new System.Drawing.Point(368, 101);

                Pnl_State.Name = "Pnl_State";
                Pnl_State.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                Pnl_State.Size = new System.Drawing.Size(348, 42);
                Pnl_State.TabIndex = 5;

                Label Lbl_ParameterCaption = new Label();
                Label Lbl_ParameterDesc = new Label();


                Lbl_ParameterCaption.AutoSize = true;
                Lbl_ParameterCaption.ForeColor = System.Drawing.Color.White;
                Lbl_ParameterCaption.Location = new System.Drawing.Point(195, 7);
                Lbl_ParameterCaption.Name = "Lbl_ParameterCaption";
                Lbl_ParameterCaption.Size = new System.Drawing.Size(120, 26);
                Lbl_ParameterCaption.TabIndex = 9;
                Lbl_ParameterCaption.Text = BLL.Cls_PublicOperations.Dt.DefaultView[i]["ParameterName"].ToString() + ":";
                Lbl_ParameterCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;



                Dt = Bll_Public.GetDataTableFromTSQL(BLL.Cls_PublicOperations.Dt.DefaultView[i]["ParamaterTSQL"].ToString());



                Lbl_ParameterDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                Lbl_ParameterDesc.Location = new System.Drawing.Point(8, 7);
                Lbl_ParameterDesc.Name = "Lbl_ParameterDesc";
                Lbl_ParameterDesc.Size = new System.Drawing.Size(148, 26);
                Lbl_ParameterDesc.TabIndex = 6;

                Lbl_ParameterDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;



                if (Dt.Rows.Count > 0)
                {
                    Lbl_ParameterDesc.Text = Dt.DefaultView[0][0].ToString();
                }
                else
                {
                    Lbl_ParameterDesc.Text = "عدم خروجی دستور ایجاد شده";
                }

                Lbl_ParameterDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;


                //    Pnl_State.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_State_Paint);


                //Pnl_Main.Controls.Add(Lbl_ParameterCaption);
                //Pnl_Main.Controls.Add(Lbl_ParameterDesc);
                Pnl_State.Controls.Add(Lbl_ParameterCaption);
                Pnl_State.Controls.Add(Lbl_ParameterDesc);

                Pnl_Main.Controls.Add(Pnl_State);
                //   Pnl_Main.Controls[i].Left  = 0;
            }
        }


        private void StationUserControl_Load(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
