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
 
using System.Diagnostics;

namespace PersianMIS
{
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        #region "Public Variable"

        IraniDate.IraniDate.IraniDate CurrentDate = new IraniDate.IraniDate.IraniDate();
        BLL.Cls_Station Bll_Station = new BLL.Cls_Station();
        BLL.Cls_GetData Bll_GetData = new BLL.Cls_GetData();
        BLL.CLS_Client Bll_Client = new BLL.CLS_Client();
        int CurrentStationId;
        # endregion

        public Main()
        {
            InitializeComponent();
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
                    Pnl_Main.BackgroundImage = new Bitmap(Dlg.FileName);
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
            MoveGroupButtons(Tab_RunTime);
        }

        private void Btn_AllStation_Click(object sender, EventArgs e)
        {
            //    ShowStations(false);


            this.Cursor = Cursors.WaitCursor ;
            var Pnl = new StationControl.ShowStationUserControl();
            Pnl_Main.Controls.Clear();
            Pnl.Width = Pnl_Main.Width - 18;
            Pnl.Height = Pnl_Main.Height - 14;
             Pnl_Main.Controls.Add(Pnl);

            this.Cursor = Cursors.Default;
        }

      
        private void CloseStation(object sender, EventArgs e)
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
            
            RadForm Frm = new StationControl.Frm_CreateNewStation(false,"");
            Frm.ShowDialog();
        }

        private void Btn_EditStationInfo_Click(object sender, EventArgs e)
        {
            RadForm Frm = new StationControl.Frm_CreateStation(true);

            Frm.ShowDialog();
        }

        private void Btn_ShowALlStationOnSpecialLine_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            var Pnl = new StationControl.ShowStationUserControl();
            Pnl_Main.Controls.Clear();
            Pnl.Width = Pnl_Main.Width - 18;
            Pnl.Height = Pnl_Main.Height - 14;
            Pnl_Main.Controls.Add(Pnl);

            this.Cursor = Cursors.Default;
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
            this.Cursor = Cursors.WaitCursor;
            //double totalHours;
            //BLL.Cls_PublicOperations.Dt = Bll_Client.GetAllCientWithOutDiuratiion();
            //for (int i = 0; i <= BLL.Cls_PublicOperations.Dt.Rows.Count - 1; i++)
            //{
            //    DateTime FirstDate = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"].ToString());
            //    DateTime EndDate = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiFinishDateTime"].ToString());


            //    totalHours = (EndDate - FirstDate).TotalSeconds;
            //    Bll_Client.UpdateClientDuratuin(BLL.Cls_PublicOperations.Dt.DefaultView[i]["DeviceStateID"].ToString(), totalHours.ToString());
            //}


            //BLL.Cls_PublicOperations.Dt = Bll_Client.Get1000RecordOfCientData();
            //for (int i = 0; i <= BLL.Cls_PublicOperations.Dt.Rows.Count - 1; i++)
            //{
            //    DateTime FirstDate = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"].ToString());
            //    DateTime EndDate = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiFinishDateTime"].ToString());
            //    totalHours = (EndDate - FirstDate).TotalSeconds;



            //    Bll_Client.UpdateClientDuratuin(BLL.Cls_PublicOperations.Dt.DefaultView[i]["DeviceStateID"].ToString(), totalHours.ToString());
            //}




            var Pnl = new CurrentState.UCShowCurrentState();
            Pnl_Main.Controls.Clear();
            Pnl.Width = Pnl_Main.Width - 18;
            Pnl.Height = Pnl_Main.Height - 14;

            Pnl.IsFirstLoad = true;
            Pnl_Main.Controls.Add(Pnl);

            this.Cursor = Cursors.Default;

        }

        private void Btn_CalcDurations_Click(object sender, EventArgs e)
        {
            // this.Cursor = Cursors.WaitCursor;
            // double totalHours;
            // BLL.Cls_PublicOperations.Dt = Bll_Client.GetAllCientWithOutDiuratiion();
            //for (int i=0; i<= BLL.Cls_PublicOperations.Dt.Rows.Count - 1; i++)
            // {
            //     DateTime FirstDate = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"].ToString());
            //     DateTime EndDate = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiFinishDateTime"].ToString());


            //     totalHours = (EndDate - FirstDate).TotalSeconds;
            //     Bll_Client.UpdateClientDuratuin(BLL.Cls_PublicOperations.Dt.DefaultView[i]["DeviceStateID"].ToString(), totalHours.ToString());
            // }


            // BLL.Cls_PublicOperations.Dt = Bll_Client.Get1000RecordOfCientData();
            // for (int i = 0; i <= BLL.Cls_PublicOperations.Dt.Rows.Count - 1; i++)
            // {
            //     DateTime FirstDate = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"].ToString());
            //     DateTime EndDate = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiFinishDateTime"].ToString());
            //     totalHours = (EndDate - FirstDate).TotalSeconds;



            //     Bll_Client.UpdateClientDuratuin(BLL.Cls_PublicOperations.Dt.DefaultView[i]["DeviceStateID"].ToString(), totalHours.ToString());
            // }





            // this.Cursor = Cursors.Default  ;
            // MessageBox.Show(" بانک اطلاعات کارکرد دستگاه ها بروز رسانی گردید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information );

        }

        private void Pnl_Main_Resize(object sender, EventArgs e)
        {
            if (Pnl_Main.Controls.Count == 1)
            {
                Pnl_Main.Controls[0].Width = Pnl_Main.Width - 18;
                Pnl_Main.Controls[0].Height = Pnl_Main.Height - 14;


            }
        }

        private void Btn_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Btn_AllLineState_Click(object sender, EventArgs e)
        {
         
 
        }

        private void BtnPersonelyManage_Click(object sender, EventArgs e)
        {

            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath)+ "\\personely\\wappPersonely.exe",

                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                } 
            
        };
            proc.Start();

        }

    }
}
