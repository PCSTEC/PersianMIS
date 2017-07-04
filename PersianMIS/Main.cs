using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using FarsiLibrary;
using FarsiLibrary.Utils;
using Telerik.WinControls.UI;
using IraniDate.IraniDate;

namespace PersianMIS
{
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        #region "Public Variable"

        IraniDate.IraniDate.IraniDate CurrentDate = new IraniDate.IraniDate.IraniDate();
        BLL.Cls_Station Bll_Station = new BLL.Cls_Station();
        int CurrentStationId;
        # endregion

        public Main()
        {
            InitializeComponent();
            int y;
        }

        private void Mnu_Exit_Click(object sender, EventArgs e)
        {

            Application.Exit();


        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            Lbl_CurrentTime.Text = string.Format("تاریخ و ساعت : {0},{1}", CurrentDate.GetIrani8DateStr_CurDate(), "    " + DateTime.Now.ToLongTimeString());

        }

        private void Tab_Product_Click(object sender, EventArgs e)
        {
            MoveGroupButtons(Tab_Product);
        }



        private void MoveGroupButtons(Telerik.WinControls.UI.RibbonTab CurTab)
        {
            //Main_Panel.Dock = DockStyle.None;
            // Move Change background Buttons to Selected tab
            CurTab.Items.Add(Btn_ChangeBackgroundBorder);
            Btn_ChangeBackgroundBorder.Items.Add(Btn_ChangeBackground);

            // Move Full Screen Buttons to Selected tab
            CurTab.Items.Add(Btn_FullScreenBorder);
            Btn_FullScreenBorder.Items.Add(Btn_FullScreen);

            // Move Send Sms Buttons to Selected tab
            CurTab.Items.Add(Btn_SendSmsBorder);
            Btn_SendSmsBorder.Items.Add(Btn_SendSms);

            // Move Send Email Buttons to Selected tab
            CurTab.Items.Add(Btn_SendEmailBorder);
            Btn_SendEmailBorder.Items.Add(Btn_SendEmail);

            // Move Manual Buttons to Selected tab
            CurTab.Items.Add(Btn_HelpBorder);
            Btn_HelpBorder.Items.Add(Btn_Help);

            //  Main_Panel.Dock = DockStyle.Fill;
        }


        private void Btn_ChangeBackground_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog Dlg = new OpenFileDialog())
            {
                Dlg.Title = "انتخاب تصویر";
                Dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

                if (Dlg.ShowDialog() == DialogResult.OK)
                { 
                    Pnl_Main.BackgroundImage= new Bitmap(Dlg.FileName);
                    Pnl_Main.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }


        private void Tab_Control_Click(object sender, EventArgs e)
        {
            MoveGroupButtons(Tab_Control);
        }

        private void Tab_RunTime_Click(object sender, EventArgs e)
        {
            MoveGroupButtons(Tab_RunTime);
        }

        private void Tab_Jobs_Click(object sender, EventArgs e)
        {
            MoveGroupButtons(Tab_Jobs);
        }

        private void Tab_Setting_Click(object sender, EventArgs e)
        {
            MoveGroupButtons(Tab_Setting);
        }

        private void Btn_DefineParameter_Click(object sender, EventArgs e)
        {
            RadForm Frm = new System_Settings.Frm_DeviceSetting();
            Frm.ShowDialog();
        }

        private void Btn_defineProductLines_Click(object sender, EventArgs e)
        {
            RadForm Frm = new System_Settings.Frm_ProductLine();
            Frm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
          
        }

        private void Btn_AllStation_Click(object sender, EventArgs e)
        {
            ShowStations(false);
        }

        private void ShowStations(bool All)
        {

            string Date = "", BeginTime = "", ProductLineId = "" ,EndTime="";
            int   NumberOfDay = 0;
            if (All == false)
            {
                using (var form = new StationControl.Frm_FillterStation(0))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // exit when user dont fill form data 
                        if(form.BeginTime== "  :  :" || form.Date == "    /  /" ||  form.EndTime  == "  :  :")
                        {
                            MessageBox.Show("لطفاً اطلاعات درخواستی را تکمیل نمایید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ShowStations(false);
                            return;
                        }

                        Date = form.Date;
                        BeginTime = form.BeginTime;
                        EndTime = form.EndTime;
                        ProductLineId = "0";
                        NumberOfDay = Convert.ToInt32( form.NumberOfNextDay);
                    }
                }
            }
            if (All == true )
            {
                using (var form = new StationControl.Frm_FillterStation(1))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Date = form.Date;
                        BeginTime = form.BeginTime;
                        EndTime = form.EndTime;
                        ProductLineId = form.ProductLineId;
                        NumberOfDay = Convert.ToInt32(form.NumberOfNextDay);

                    }
                }
            }

            if(string.IsNullOrEmpty(Date))
            {
                return;
            }
            Pnl_Main.Controls.Clear();
            DataTable Dt = new DataTable();
            Dt = Bll_Station.GetStations(Convert.ToInt32(ProductLineId));

            Dictionary<string, StationControl.StationUserControl> Station = new Dictionary<string, StationControl.StationUserControl>();

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Station.Add(Dt.DefaultView[i]["StationId"].ToString(), new StationControl.StationUserControl());
                Station[Dt.DefaultView[i]["StationId"].ToString()].TitleBar.Text = Dt.DefaultView[i]["StationDesc"].ToString();
                Station[Dt.DefaultView[i]["StationId"].ToString()].BtnClosed.Tag = Dt.DefaultView[i]["StationId"].ToString();
                Station[Dt.DefaultView[i]["StationId"].ToString()].BtnClosed.Click += new DevComponents.DotNetBar.ClickEventHandler(this.CloseStation);
                Station[Dt.DefaultView[i]["StationId"].ToString()].Tag = Dt.DefaultView[i]["StationId"].ToString();
                Station[Dt.DefaultView[i]["StationId"].ToString()].DeviceId = Convert.ToInt32(Dt.DefaultView[i]["DeviceId"].ToString());
                Station[Dt.DefaultView[i]["StationId"].ToString()].LineID = Convert.ToInt32(Dt.DefaultView[i]["LineId"].ToString());
                Station[Dt.DefaultView[i]["StationId"].ToString()].DeviceTypeCode = Convert.ToInt32(Dt.DefaultView[i]["PulsTypeId"].ToString());
                Station[Dt.DefaultView[i]["StationId"].ToString()].ActiveStateDesc = Dt.DefaultView[i]["ActiveStateDesc"].ToString();
                Station[Dt.DefaultView[i]["StationId"].ToString()].DeActiveStateDesc = Dt.DefaultView[i]["DeActiveStateDesc"].ToString();
                Station[Dt.DefaultView[i]["StationId"].ToString()].ProductLineDesc = Dt.DefaultView[i]["ProductLineDesc"].ToString();
                Station[Dt.DefaultView[i]["StationId"].ToString()].deviceDesc = Dt.DefaultView[i]["DeviceDesc"].ToString();
                Station[Dt.DefaultView[i]["StationId"].ToString()].Linedesc = Dt.DefaultView[i]["LineDesc"].ToString();
                Station[Dt.DefaultView[i]["StationId"].ToString()].MiladiStartDate = CurrentDate.GetDateIntToStr_GivenDate(CurrentDate.GetLatin_FromIraniDate(CurrentDate.ConvDateStrToInt_GivenDate(Date)).ToString());
                Station[Dt.DefaultView[i]["StationId"].ToString()].MiladiStartTime = BeginTime;
                Station[Dt.DefaultView[i]["StationId"].ToString()].ShamsiStartDate = Date;
                Station[Dt.DefaultView[i]["StationId"].ToString()].MiladiiEndDate = CurrentDate.GetDateIntToStr_GivenDate(CurrentDate.GetLatin_FromIraniDate(CurrentDate.GetPlussToIraniDate(CurrentDate.ConvDateStrToInt_GivenDate(Date), NumberOfDay)).ToString());
                Station[Dt.DefaultView[i]["StationId"].ToString()].MiladiEndTime = EndTime;
                Station[Dt.DefaultView[i]["StationId"].ToString()].CreateObjects();
                Pnl_Main.Controls.Add(Station[Dt.DefaultView[i]["StationId"].ToString()]);
            }

            int x;

            Pnl_Main.ResumeLayout();

        }

        private void CloseStation(object sender, EventArgs e   )
        {
            DevComponents.DotNetBar.BubbleButton SelectedValue = (DevComponents.DotNetBar.BubbleButton)sender;
            foreach (Control item in Pnl_Main.Controls)
            {
                if (item.Tag.ToString() == SelectedValue.Tag.ToString())
                {
                    Pnl_Main.Controls.Remove(item);
                    break; //important step
                }
            }

           
        }

        private void Btn_AddStation_Click(object sender, EventArgs e)
        {
            RadForm Frm = new StationControl.Frm_CreateStation(false );
             
            Frm.ShowDialog();
        }

        private void Btn_EditStationInfo_Click(object sender, EventArgs e)
        {
            RadForm Frm = new StationControl.Frm_CreateStation(true );

            Frm.ShowDialog();
        }

        private void Btn_ShowALlStationOnSpecialLine_Click(object sender, EventArgs e)
        {
            ShowStations(true);
        }

        private void Btn_FullScreen_Click(object sender, EventArgs e)
        {
         
            
          
            MainRibbonBar.Visible = false;
       
     
        }

        private void Btn_OutOfFullScreen_Click(object sender, EventArgs e)
        {
           
            MainRibbonBar.Visible = true;
          
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                MainRibbonBar.Visible = true;
              
            }
        }

        private void Btn_LineState_Click(object sender, EventArgs e)
        {
            var Pnl = new CurrentState.UCShowCurrentState ();
            Pnl_Main.Controls.Clear();
            Pnl.Width = Pnl_Main.Width-18;
            Pnl.Height = Pnl_Main.Height-14;
            Pnl_Main.Controls.Add(Pnl);

             

        }
    }
}
