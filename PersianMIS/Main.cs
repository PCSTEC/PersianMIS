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
using Calendars;
using System.Diagnostics;
using System.IO;
using Calendars;
namespace PersianMIS
{
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        #region "Public Variable"
        BLL.Cls_PublicOperations Bll_PublicOperations = new BLL.Cls_PublicOperations();
        IraniDate.IraniDate.IraniDate CurrentDate = new IraniDate.IraniDate.IraniDate();
        BLL.Cls_Station Bll_Station = new BLL.Cls_Station();
        BLL.Cls_GetData Bll_GetData = new BLL.Cls_GetData();
        BLL.CLS_Client Bll_Client = new BLL.CLS_Client();
        BLL.Cls_Logs Bll_Log = new BLL.Cls_Logs();
        int CurrentStationId;




        PersianCalendar pc = new PersianCalendar();
        string CurShamsiDate = "";
        BLL.CLS_Message Cls_Message = new BLL.CLS_Message();
        BLL.Cls_PublicOperations Cls_Public = new BLL.Cls_PublicOperations();
        DataTable Dt = new DataTable();
        # endregion

        public Main()
        {
            InitializeComponent();


            //MainDesctopAlert.CaptionText = "نرم افزار PCSTEC";
            //MainDesctopAlert.ContentText = @"کاربر گرامی!
            // آخرین امکانات اضافه شده به نرم افزار عبارتست از :
            //1:امکان ایجاد نمودار جدید
            //2: امکان تعیین نحوه نمایش نمودار ها در صفحه 
            //3:امکان نمایش مدت زمان در دسترسی هر ماشین به عنوان هدف در نمودار ها 
            //4:برخی از باگ ها در بخش نمودار رفع گردیده است 
            //***** در صورت سوال و پیشنهاد میتوانید با داخلی 231-آزادفلاح تماس بگیرید **** ";
            //MainDesctopAlert.ScreenPosition = AlertScreenPosition.Manual;
            //MainDesctopAlert.Popup.AlertElement.ContentElement.Font = new Font("b nazanin", 11f, FontStyle.Regular);

            //MainDesctopAlert.AutoSize = true;
            //MainDesctopAlert.ScreenPosition = AlertScreenPosition.BottomLeft;
            //MainDesctopAlert.Show();

            Bll_Log.InsertLoginsLog(DateTime.Now, Environment.MachineName, Environment.UserName);


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

                    if (Bll_PublicOperations.InsertBackgroundImage(Dlg.FileName, "All"))
                    {
                        MessageBox.Show("تصویر مورد نظر با موفقیت ثبت گردید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (Control c in Pnl_Main.Controls)
                            c.Dispose();
                        Pnl_Main.Controls.Clear();
                        GetbackgroundImage("All");

                    }
                    else
                    {
                        MessageBox.Show("در ثبت تصویر مشکلی وجود دارد ، لطفا مجدد تلاش نمایید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }




                }
            }
        }

        private void GetbackgroundImage(string UserId)
        {


            DataTable dt = new DataTable();

            byte[] picData = Bll_PublicOperations.GetBackgroundImagesFromDatabase(UserId).DefaultView[0]["BackgroundImg"] as byte[] ?? null;

            if (picData != null)
            {
                using (MemoryStream ms = new MemoryStream(picData))
                {
                    // Load the image from the memory stream. How you do it depends
                    // on whether you're using Windows Forms or WPF.
                    // For Windows Forms you could write:
                    System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(ms);





                    //  var  img = Bitmap.FromStream( x );
                    Pnl_Main.BackgroundImage = bmp;
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
            GetbackgroundImage("All");
            foreach (Control c in Pnl_Main.Controls)
                c.Dispose();
            Pnl_Main.Controls.Clear();
            RadForm Frm = new System_Settings.Frm_DeviceSetting();
            Frm.ShowDialog();
        }

        private void Btn_defineProductLines_Click(object sender, EventArgs e)
        {
            GetbackgroundImage("All");
            foreach (Control c in Pnl_Main.Controls)
                c.Dispose();
            Pnl_Main.Controls.Clear();
            RadForm Frm = new System_Settings.Frm_ProductLine();
            Frm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            GetbackgroundImage("All");
            MoveGroupButtons(Tab_RunTime);



        }

        private void Btn_AllStation_Click(object sender, EventArgs e)
        {
            GetbackgroundImage("All");

            this.Cursor = Cursors.WaitCursor;
            var Pnl = new StationControl.ShowStationUserControl();
            Pnl_Main.Controls.Clear();
            Pnl.Width = Pnl_Main.Width - 18;
            Pnl.Height = Pnl_Main.Height - 14;
            Pnl_Main.Controls.Add(Pnl);

            this.Cursor = Cursors.Default;
        }


        private void CloseStation(object sender, EventArgs e)
        {
            GetbackgroundImage("All");

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

            GetbackgroundImage("All");

            foreach (Control c in Pnl_Main.Controls)
                c.Dispose();
            Pnl_Main.Controls.Clear();

            RadForm Frm = new StationControl.Frm_CreateNewStation(false, "");

            Frm.ShowDialog();


        }

        private void Btn_EditStationInfo_Click(object sender, EventArgs e)
        {
            GetbackgroundImage("All");

            foreach (Control c in Pnl_Main.Controls)
                c.Dispose();
            Pnl_Main.Controls.Clear();

            RadForm Frm = new StationControl.Frm_CreateStation(true);

            Frm.ShowDialog();

        }

        private void Btn_ShowALlStationOnSpecialLine_Click(object sender, EventArgs e)
        {
            Pnl_Main.BackgroundImage = null;
            //Pnl_Main.Controls.Clear();
            // Pnl_Main.Dispose();


            //   List<Control> ctrls = new List<Control>(Pnl_Main.Controls );

            foreach (Control c in Pnl_Main.Controls)
                c.Dispose();
            Pnl_Main.Controls.Clear();

            this.Cursor = Cursors.WaitCursor;
            var Pnl = new StationControl.ShowStationUserControl();

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
            Pnl_Main.BackgroundImage = null;

            this.Cursor = Cursors.WaitCursor;
            var Pnl = new CurrentState.UCShowCurrentState();
            foreach (Control c in Pnl_Main.Controls)
                c.Dispose();
            Pnl_Main.Controls.Clear();

            Pnl.Width = Pnl_Main.Width - 18;
            Pnl.Height = Pnl_Main.Height - 14;

            Pnl.IsFirstLoad = true;
            Pnl_Main.Controls.Add(Pnl);

            this.Cursor = Cursors.Default;

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

        private void BtnPersonelyManage_Click(object sender, EventArgs e)
        {
            GetbackgroundImage("All");

            System.Diagnostics.Process proc = new System.Diagnostics.Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\personely\\wappPersonely.exe",

                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }

            };
            proc.Start();

        }

        private void Btn_Calendar_Click(object sender, EventArgs e)
        {
            GetbackgroundImage("All");
            foreach (Control c in Pnl_Main.Controls)
                c.Dispose();
            Pnl_Main.Controls.Clear();


            Calendars.Frm_MainCalendar frm = new Calendars.Frm_MainCalendar();
            frm.ShowDialog();
        }


        private void Btn_DefineShift_Click(object sender, EventArgs e)
        {
            Calendars.Frm_MainShift Frm_Shift = new Frm_MainShift();
            Frm_Shift.ShowDialog();
        }

        private void Btn_ManageProcess_Click(object sender, EventArgs e)
        {
            Process.Frm_MainProcess Frm_Process = new Process.Frm_MainProcess();
            Frm_Process.ShowDialog();

        }

        private void Btn_ProductChart_Click(object sender, EventArgs e)
        {
            Pnl_Main.BackgroundImage = null;
            foreach (Control c in Pnl_Main.Controls)
                c.Dispose();
            Pnl_Main.Controls.Clear();

            this.Cursor = Cursors.WaitCursor;
            var Pnl = new Production.Chart.UCShowProductionChart();

            Pnl.Width = Pnl_Main.Width - 18;
            Pnl.Height = Pnl_Main.Height - 14;
            Pnl_Main.Controls.Add(Pnl);

            this.Cursor = Cursors.Default;




        }

        private void Btn_AllLineState_Click(object sender, EventArgs e)
        {
            DateTime thisDate = DateTime.Now;
            CurShamsiDate = string.Format("{0}/{1}/{2}", pc.GetYear(thisDate), pc.GetMonth(thisDate).ToString("00"), pc.GetDayOfMonth(thisDate).ToString("00"));
            BLL.Cls_PublicOperations.Dt = Cls_Message.GetEmergancyMessageList();
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

                }



            }
        }
        private void Main_Activated(object sender, EventArgs e)
        {
            // MainDesctopAlert.ContentImage  = global::PersianMIS.Properties.Resources.EndLogo1;

        }

        private void Btn_SendSms_Click(object sender, EventArgs e)
        {
            Form Frm = new PublicTabs.Frm_MessageSetting();
            Frm.ShowDialog();
        }
    }
}
