using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using BLL;
using Telerik.WinControls.UI;

namespace PersianMIS.Production.Chart
{


    public partial class Frm_SelectChartOptions : Telerik.WinControls.UI.RadForm
    {
        BLL.CLS_DeviceLine Bll_DeviceLine = new CLS_DeviceLine();
        BLL.CLS_Chart bll_Chart = new CLS_Chart();
        BLL.CLS_Device Bll_device = new CLS_Device();
        BLL.Cls_ProductLines Bll_ProductLine = new Cls_ProductLines();
        string SQLStrMainThemplate, SQLStrThemplate;
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


            bll_Chart.Insert("all",false , SQLStrThemplate, Txt_ChartTitle.Text, Cmb_ChartType.Text, Convert.ToInt32( Cmb_FieldShowType.SelectedItem.Tag.ToString()) );
            MessageBox.Show("ساختار نمودار جدیدی برای شما ثبت گردید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information );
            this.Close();

        }

        private void SyncThreeLevel(RadTreeViewEventArgs e)
        {
            

            String DeviceIdStr = ((DataRowView)e.Node.Parent.Parent.Parent.DataBoundItem)["DeviceId"].ToString();
            String DeviceLineIdStr = ((DataRowView)e.Node.Parent.DataBoundItem)["lineid"].ToString();
            String StateIdStr = ((DataRowView)e.Node.DataBoundItem)["stateid"].ToString();

            if (e.Node.Checked == true)
            {
                string TempSQLStr = SQLStrMainThemplate;
                TempSQLStr= TempSQLStr.Replace("DeviceIdStr", DeviceIdStr);
                TempSQLStr= TempSQLStr.Replace("DeviceLineIdStr", DeviceLineIdStr);
                TempSQLStr= TempSQLStr.Replace("StateIdStr", StateIdStr);
                e.Node.Tag = TempSQLStr;
            }
            else
            {
                e.Node.Tag = "";
            }


        }
    }
}
