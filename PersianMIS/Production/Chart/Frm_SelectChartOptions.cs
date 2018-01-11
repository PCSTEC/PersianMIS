﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using BLL;
using Telerik.WinControls.UI;
using System.Windows.Forms.DataVisualization.Charting;
using Telerik.Windows.Diagrams.Core;
using System.Collections;

namespace PersianMIS.Production.Chart
{


    public partial class Frm_SelectChartOptions : Telerik.WinControls.UI.RadForm
    {
        BLL.CLS_DeviceLine Bll_DeviceLine = new CLS_DeviceLine();
        BLL.CLS_Chart bll_Chart = new CLS_Chart();
        BLL.CLS_Device Bll_device = new CLS_Device();
        BLL.Cls_ProductLines Bll_ProductLine = new Cls_ProductLines();
        string SQLStrMainThemplate, SQLStrThemplate;
        Legend Themlegend = new Legend();
        public Frm_SelectChartOptions()
        {
            InitializeComponent();
        }

        private void Frm_SelectChartOptions_Load(object sender, EventArgs e)
        {

            using (this.MainTree.DeferRefresh())
            {
                this.MainTree.RelationBindings.Add(Bll_ProductLine.GetProductLineToHowDeviceSet(), "ProductLineDesc", "DeviceId");
                this.MainTree.RelationBindings.Add(Bll_DeviceLine.GetAllDeviceWithInformation(), "LineDesc", "ProductLineId");
                this.MainTree.RelationBindings.Add(Bll_DeviceLine.GetAllDeviceLineStates(), "statecaption", "lineid");
                this.MainTree.MultiSelect = true;
                this.MainTree.DisplayMember = "DeviceDesc";
                this.MainTree.DataSource = (Bll_device.GetListOfDevice());
                this.MainTree.CheckBoxes = true;
                this.MainTree.TriStateMode = true;
                this.MainTree.AutoCheckChildNodes = true;
            }
            SQLStrMainThemplate = bll_Chart.GetActiveChartThemplate().DefaultView[0]["TSQL"].ToString();
            //SeriesChartType n = new   SeriesChartType();
            //foreach (var x in Enum.GetNames(typeof(SeriesChartType)))
            //{
            //    Cmb_ChartType.Items.Add(x.ToString());

            //}
            // Cmb_ChartType.Items.AddRange(IEnumerable < SeriesChartType > Enum.GetNames(typeof(SeriesChartType)))  ;
            Cmb_ChartType.Items.AddRange(Enum.GetNames(typeof(SeriesChartType)));
            Cmb_ChartType.Items[0].Text = "Pie";

        }

        private void FillThemplateChart()
        {


         ThemplateChart.Legends.Clear();
            ThemplateChart.Series.Clear();
            ThemplateChart.ChartAreas.Clear();
            double[] yValue = { 100, 200, 150, 300 };
            string[] XValue = { "داده1", "داده2", "داده3", "داده4" };
 

            ThemplateChart.Series.Add("Default");
            ThemplateChart.Series[0].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), Cmb_ChartType.Text);// Enum.GetValues (typeof(SeriesChartType), "RangeBar");// System.Windows.Forms.DataVisualization.Charting.SeriesChartType( "System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar") ;
                                                                                                                          //   ThemplateChart.Legends.Add("Default");
           //  ThemplateChart.Series[0].XValueMember = "StateCaption";
        //    ThemplateChart.Series[0].LegendText = "StateCaption";
       //  ThemplateChart.Series[0].YValueMembers = "Duration";

      //      ThemplateChart.Series[0].Legen  = XValue;

            ThemplateChart.ChartAreas.Add("Main Area");
            // ThemplateChart.ChartAreas[0].Area3DStyle.Enable3D = true;
            ThemplateChart.Series[0].Points.DataBindXY(XValue, yValue);
            ThemplateChart.Titles[0].Text = Txt_ChartTitle.Text;
          //  ThemplateChart.Legends[0].BackColor = Color.Transparent;
            ThemplateChart.Series["Default"]["PyramidLabelStyle"] = "Inside";
            ThemplateChart.Series[0].IsValueShownAsLabel = true;
            ThemplateChart.ChartAreas[0].Area3DStyle.Enable3D = Ch_3d.Checked;
            ThemplateChart.Titles[0].Visible = Ch_ShowTitleOption.Checked;
            //درصدی کردن
            // ThemplateChart.Series["Default"].IsValueShownAsLabel = true;
            //   ThemplateChart.Series["Default"].Label = "#PERCENT";

            ThemplateChart.Legends.Add(new Legend("Expenses"));
              ThemplateChart.Series[0].Legend = "Expenses";
            ThemplateChart.Series[0].LegendText = "#VALX";
            ThemplateChart.Legends["Expenses"].BackColor = Color.Transparent;
            ThemplateChart.Legends["Expenses"].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            //  ThemplateChart.Series[0].Color = Color.Transparent;
            ThemplateChart.ChartAreas[0].BackColor = Color.Transparent;
            try
            {
                if (Cmb_DataTypeShow.SelectedItem.Index == 0)
                {
                    ThemplateChart.Series["Default"].IsValueShownAsLabel = true;
                    ThemplateChart.Series["Default"].Label = "#PERCENT";

                }
                else
                {
                    ThemplateChart.Series["Default"].IsValueShownAsLabel = false;
                    ThemplateChart.Series["Default"].Label = "#VAL";
                    ThemplateChart.Series[0].IsValueShownAsLabel = true;

                }
            }
            catch
            {

            }



        }


        private void MainTree_NodeCheckedChanged(object sender, Telerik.WinControls.UI.TreeNodeCheckedEventArgs e)
        {
            if (e.Node.Level == 3)
            {
                SyncThreeLevel(e);
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            SQLStrThemplate = " ";
            foreach (var Node in MainTree.CheckedNodes)
            {
                try
                {
                    if (!Node.Tag.Equals(null))
                    {

                        SQLStrThemplate += SQLStrThemplate.Length > 2 ? " union " + Node.Tag.ToString() : Node.Tag.ToString();

                    }
                    else
                    {
                        ThemplateChart.Series["Default"].IsValueShownAsLabel = false;
                    }

                }
                catch
                {

                }


            }


            if (Txt_ChartTitle.Text == "")
            {
                MessageBox.Show("لطفاً اطلاعات درخواستی را تکمیل نمایید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            bll_Chart.Insert("all", false, SQLStrThemplate, Txt_ChartTitle.Text, Cmb_ChartType.Text, Convert.ToInt32(Cmb_FieldShowType.SelectedItem.Tag.ToString()));
            MessageBox.Show("ساختار نمودار جدیدی برای شما ثبت گردید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void Cmb_ChartType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            FillThemplateChart();
        }

        private void Ch_ShowTitleOption_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                ThemplateChart.Titles[0].Visible = Ch_ShowTitleOption.Checked;
            }
            catch { }
        }

        private void Ch_3d_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                ThemplateChart.ChartAreas[0].Area3DStyle.Enable3D = Ch_3d.Checked;
            }
            catch { }
        }

        private void Cmb_DataTypeShow_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
  if (e.Position == 0)
            {
                ThemplateChart.Series["Default"].IsValueShownAsLabel = true;
                ThemplateChart.Series["Default"].Label = "#PERCENT";
            }
            else
            {
                ThemplateChart.Series["Default"].IsValueShownAsLabel = false;
                ThemplateChart.Series["Default"].Label = "#VAL";
                ThemplateChart.Series[0].IsValueShownAsLabel = true;
            }
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Themlegend = ThemplateChart.Legends[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemplateChart.Legends[0] = Themlegend;
        }

        private void SyncThreeLevel(RadTreeViewEventArgs e)
        {


            String DeviceIdStr = ((DataRowView)e.Node.Parent.Parent.Parent.DataBoundItem)["DeviceId"].ToString();
            String DeviceLineIdStr = ((DataRowView)e.Node.Parent.DataBoundItem)["lineid"].ToString();
            String StateIdStr = ((DataRowView)e.Node.DataBoundItem)["stateid"].ToString();

            if (e.Node.Checked == true)
            {
                string TempSQLStr = SQLStrMainThemplate;
                TempSQLStr = TempSQLStr.Replace("DeviceIdStr", DeviceIdStr);
                TempSQLStr = TempSQLStr.Replace("DeviceLineIdStr", DeviceLineIdStr);
                TempSQLStr = TempSQLStr.Replace("StateIdStr", StateIdStr);
                e.Node.Tag = TempSQLStr;
            }
            else
            {
                e.Node.Tag = "";
            }


        }
    }
}
