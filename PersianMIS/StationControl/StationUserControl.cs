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
using System.Globalization;

namespace PersianMIS.StationControl
{
    public partial class StationUserControl : UserControl
    {
        BLL.Cls_Station Bll_Station = new Cls_Station();

        BLL.Cls_PublicOperations Bll_Public = new BLL.Cls_PublicOperations();
        public DateTime StartDate, EndDate, ShiftDate, Shift3beginDate, Shift3Enddate = new DateTime();
        public Boolean IsSHift3 = false;
        public Boolean ISAccumulative = false;
        public string Times, Shift3beginTime, Shift3EndTime = "";


        IKIDUtility.IKIDUtility.Formating Utility = new IKIDUtility.IKIDUtility.Formating();


        DataTable Dt = new DataTable();
        BLL.CLS_DeviceLine Bll_DeviceLine = new CLS_DeviceLine();
        public DevComponents.DotNetBar.PanelEx TitleBar
        {
            get { return TopPnl; }
            set { TopPnl = TitleBar; }
        }


        public Timer Maintimer
        {
            get { return MainTimer; }
            set { MainTimer = Maintimer; }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            FillData();
        }

        public DevComponents.DotNetBar.BubbleButton BtnColse
        {
            get { return BtnClosed; }
        }




        public StationUserControl()
        {
            InitializeComponent();


        }

        public Panel MainPnl
        {
            get { return Pnl_Main; }

        }

        private void FillData()
        {
            BLL.Cls_PublicOperations.Dt = Bll_Station.GetClientData(this.Tag.ToString());

            Pnl_Main.Controls.Clear();




            if (ISAccumulative)
            {


                for (int i = 0; i < BLL.Cls_PublicOperations.Dt.Rows.Count; i++)
                {
                    Panel Pnl_State = new Panel();

                    Boolean IsNewItem = true;
                    Pnl_State.Name = "Pnl_State";
                    Pnl_State.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                    Pnl_State.Size = new System.Drawing.Size(348, 27);
                    Pnl_State.TabIndex = 5;
                    Pnl_State.Tag = "";
                    Label Lbl_ParameterCaption = new Label();
                    Label Lbl_ParameterDesc = new Label();

                    Lbl_ParameterCaption.ForeColor = System.Drawing.Color.White;
                    Lbl_ParameterCaption.Location = new System.Drawing.Point(97, 7);
                    Lbl_ParameterCaption.Name = "Lbl_ParameterCaption";
                    Lbl_ParameterCaption.Size = new System.Drawing.Size(240, 26);
                    Lbl_ParameterCaption.TabIndex = 9;
                    Lbl_ParameterCaption.Tag = "";
                    Lbl_ParameterCaption.Text = BLL.Cls_PublicOperations.Dt.DefaultView[i]["ParameterName"].ToString();
                    Lbl_ParameterCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    Lbl_ParameterCaption.RightToLeft = System.Windows.Forms.RightToLeft.No;
                    System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
                    string TSql = BLL.Cls_PublicOperations.Dt.DefaultView[i]["ParamaterTSQL"].ToString();
                    TSql = TSql.Replace("01/01/2015 00:00:00", StartDate.ToString("MM/dd/yyyy"));

                    TSql = TSql.Replace("01/01/2016 00:00:00", EndDate.ToString("MM/dd/yyyy"));
                    if (IsSHift3)
                    {
                        TSql = TSql.Replace("'12/12/2005'", "'" + Shift3beginDate.ToString("MM/dd/yyyy") + "'");
                        TSql = TSql.Replace("'12/13/2005'", "'" + Shift3Enddate.ToString("MM/dd/yyyy") + "'");
                        TSql = TSql.Replace("01:00:00", Shift3beginTime);
                        TSql = TSql.Replace("06:00:00", Shift3EndTime);
                        if (IsSHift3 && Times.Length < 5)
                        {
                            TSql = TSql.Replace("strtime", "AND (CAST(dbo.Tb_Client.StartTime AS time) BETWEEN '00:00:00' AND  '00:00:00' ");
                        }



                    }


                    TSql = TSql.Replace(" 60 ", " 1 ");
                    TSql = TSql.Replace(" 3600 ", " 1 ");



                    TSql = TSql.Replace("strtime", Times);

                    Dt = Bll_Public.GetDataTableFromTSQL(TSql);
                    Lbl_ParameterDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    Lbl_ParameterDesc.Location = new System.Drawing.Point(8, 7);
                    Lbl_ParameterDesc.Name = "Lbl_ParameterDesc";
                    Lbl_ParameterDesc.Size = new System.Drawing.Size(91, 26);
                    Lbl_ParameterDesc.TabIndex = 6;
                    Lbl_ParameterDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    Lbl_ParameterDesc.Tag = BLL.Cls_PublicOperations.Dt.DefaultView[i]["ParameterName"].ToString();

                    decimal Data = 0;
                    if (Dt.Rows.Count > 0)
                    {
                      
                        // Lbl_ParameterDesc.Text = Decimal.Round(Data, 2).ToString();
                        //   Lbl_ParameterDesc.Text =  Data.ToString()  ;
 Data = Decimal.Parse(Utility.NZ(Dt.DefaultView[0][0].ToString(), 0).ToString());


                        if (BLL.Cls_PublicOperations.Dt.DefaultView[i]["ParameterName"].ToString().ToString().Trim().Contains("(%)"))
                        {
                            Lbl_ParameterDesc.Text = Decimal.Round(Data, 2).ToString();
                        }
                        else
                        {
 
                            TimeSpan span = TimeSpan.FromSeconds(Convert.ToDouble(Data));
                            string label = span.ToString(@"hh\:mm\:ss");
                            Lbl_ParameterDesc.Text = label;
                        }




                    }
                    else
                    {
                        Lbl_ParameterDesc.Text = "عدم خروجی دستور ایجاد شده";
                    }

                    Lbl_ParameterDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                    foreach (Control x in Pnl_Main.Controls)
                    {
                        if (x.Tag.ToString().Trim().Contains(Lbl_ParameterCaption.Text.Trim()))
                        {

                            if (BLL.Cls_PublicOperations.Dt.DefaultView[i]["ParameterName"].ToString().Trim().Contains("(%)"))
                            {
                                x.Text = (decimal.Parse(x.Text) + decimal.Parse(Lbl_ParameterDesc.Text)).ToString();

                            }
                            else
                            {
                                
                                    TimeSpan t1 = TimeSpan.Parse(x.Text);
                                    TimeSpan t2 = TimeSpan.Parse(Lbl_ParameterDesc.Text);
                                    TimeSpan t3 = t1.Add(t2);


                                    //  TimeSpan span = TimeSpan.FromSeconds(Convert.ToDouble(Data));


                                    x.Text = t3.ToString();
                              

                            }

                            //  x.Text = x.Text + Lbl_ParameterDesc.Text;
                            IsNewItem = false;
                        }
                    }

                    ////foreach (Control x in ((Panel)Pnl_Main.Controls["Pnl_State"]).Controls)
                    ////{
                    ////    if (x.Tag.ToString().Trim().Contains(Lbl_ParameterCaption.Text.Trim()))
                    ////    {
                    ////        x.Text = (decimal.Parse(x.Text) + decimal.Parse(Lbl_ParameterDesc.Text)).ToString();
                    ////        x.Text = x.Text + Lbl_ParameterDesc.Text;
                    ////        IsNewItem = false;
                    ////    }
                    ////}


                    //foreach (Control x in ((Panel)Pnl_Main.Controls["Pnl_State"]).Controls)
                    //{

                    //    if (x.Name == "Lbl_ParameterDesc")

                    //    {
                    //        if (x.Tag.ToString() == Lbl_ParameterCaption.Text)
                    //        {
                    //            x.Text = x.Text + Lbl_ParameterDesc.Text;
                    //            IsNewItem = false;
                    //        }

                    //    }
                    //}
                    if (IsNewItem)
                    {
                        // Pnl_State.Controls.Add(Lbl_ParameterCaption);
                        // Pnl_State.Controls.Add(Lbl_ParameterDesc);

                        Pnl_Main.Controls.Add(Lbl_ParameterCaption);



                        Pnl_Main.Controls.Add(Lbl_ParameterDesc);
                        Pnl_Main.Controls.Add(Pnl_State);
                        //Pnl_Main.Controls.Add(Pnl_State);
                    }
                }
                foreach (Control x in Pnl_Main.Controls)
                {
                    if (x.Tag.ToString().Trim().Contains("%") || x.Text.ToString().Trim().Contains("%"))
                    {
                        x.Visible = false;
                    }
                }


            }
            else
            {


                for (int i = 0; i < BLL.Cls_PublicOperations.Dt.Rows.Count; i++)
                {

                    Panel Pnl_State = new Panel();

                    Pnl_State.Name = "Pnl_State";
                    Pnl_State.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                    Pnl_State.Size = new System.Drawing.Size(348, 42);
                    Pnl_State.TabIndex = 5;

                    Label Lbl_ParameterCaption = new Label();
                    Label Lbl_ParameterDesc = new Label();

                    Lbl_ParameterCaption.ForeColor = System.Drawing.Color.White;
                    Lbl_ParameterCaption.Location = new System.Drawing.Point(97, 7);
                    Lbl_ParameterCaption.Name = "Lbl_ParameterCaption";
                    Lbl_ParameterCaption.Size = new System.Drawing.Size(240, 26);
                    Lbl_ParameterCaption.TabIndex = 9;
                    Lbl_ParameterCaption.Text = BLL.Cls_PublicOperations.Dt.DefaultView[i]["ParameterName"].ToString();
                    Lbl_ParameterCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    Lbl_ParameterCaption.RightToLeft = System.Windows.Forms.RightToLeft.No;
                    System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
                    string TSql = BLL.Cls_PublicOperations.Dt.DefaultView[i]["ParamaterTSQL"].ToString();
                    TSql = TSql.Replace("01/01/2015 00:00:00", StartDate.ToString("MM/dd/yyyy"));

                    TSql = TSql.Replace("01/01/2016 00:00:00", EndDate.ToString("MM/dd/yyyy"));
                    if (IsSHift3)
                    {
                        TSql = TSql.Replace("'12/12/2005'", "'" + Shift3beginDate.ToString("MM/dd/yyyy") + "'");
                        TSql = TSql.Replace("'12/13/2005'", "'" + Shift3Enddate.ToString("MM/dd/yyyy") + "'");
                        TSql = TSql.Replace("01:00:00", Shift3beginTime);
                        TSql = TSql.Replace("06:00:00", Shift3EndTime);
                        if (IsSHift3 && Times.Length < 5)
                        {
                            TSql = TSql.Replace("strtime", "AND (CAST(dbo.Tb_Client.StartTime AS time) BETWEEN '00:00:00' AND  '00:00:00' ");
                        }
                    }
                    TSql = TSql.Replace(" 60 ", " 1 ");
                    TSql = TSql.Replace(" 3600 ", " 1 ");


                    TSql = TSql.Replace("strtime", Times);

                    Dt = Bll_Public.GetDataTableFromTSQL(TSql);
                    Lbl_ParameterDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    Lbl_ParameterDesc.Location = new System.Drawing.Point(8, 7);
                    Lbl_ParameterDesc.Name = "Lbl_ParameterDesc";
                    Lbl_ParameterDesc.Size = new System.Drawing.Size(91, 26);
                    Lbl_ParameterDesc.TabIndex = 6;
                    Lbl_ParameterDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;



                    if (Dt.Rows.Count > 0)
                    {
                        decimal Data = Decimal.Parse(Utility.NZ(Dt.DefaultView[0][0].ToString(), 0).ToString());

                        // Lbl_ParameterDesc.Text = Decimal.Round(Data, 2).ToString();

                        if (BLL.Cls_PublicOperations.Dt.DefaultView[i]["ParameterName"].ToString().Trim().Contains("(%)"))
                        {
                            Lbl_ParameterDesc.Text = Decimal.Round(Data, 2).ToString();
                        }
                        else
                        {
                            TimeSpan span = TimeSpan.FromSeconds(Convert.ToDouble(Data));

                            string label = span.ToString(@"hh\:mm\:ss");
                            Lbl_ParameterDesc.Text = label;
                        }



                    }
                    else
                    {
                        Lbl_ParameterDesc.Text = "عدم خروجی دستور ایجاد شده";
                    }

                    Lbl_ParameterDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    Pnl_State.Controls.Add(Lbl_ParameterCaption);
                    Pnl_State.Controls.Add(Lbl_ParameterDesc);

                    Pnl_Main.Controls.Add(Pnl_State);
                }
            }
        }

        private void BtnClosed_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Hide();

        }

        private void StationUserControl_Load(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
