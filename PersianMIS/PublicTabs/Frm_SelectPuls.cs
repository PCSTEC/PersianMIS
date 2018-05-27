using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace PersianMIS.PublicTabs
{
      
    public partial class Frm_SelectPuls : Telerik.WinControls.UI.RadForm
    {
       


        public int  DeviceId  { get; set; }

        public  int  DeviceLineId  { get; set; }

        public  int  StateId  { get; set; }

        public int  DeviceLinePrimaryId { get; set; }
         


        BLL.Cls_ProductLines Bll_ProductLine = new Cls_ProductLines();
        BLL.CLS_DeviceLine Bll_DeviceLine = new CLS_DeviceLine();
        BLL.CLS_Device Bll_device = new CLS_Device();

        public Frm_SelectPuls()
        {
            InitializeComponent();
        }

        private void Frm_SelectPuls_Load(object sender, EventArgs e)
        {
            using (this.MainTree.DeferRefresh())
            {
                this.MainTree.RelationBindings.Add(Bll_ProductLine.GetProductLineToHowDeviceSet(), "ProductLineDesc", "DeviceId");
                this.MainTree.RelationBindings.Add(Bll_DeviceLine.GetAllDeviceWithInformation(), "LineDesc", "ProductLineId");
                this.MainTree.RelationBindings.Add(Bll_DeviceLine.GetAllDeviceLineStates(), "statecaption", "lineid");

                this.MainTree.DisplayMember = "DeviceDesc";
                this.MainTree.DataSource = (Bll_device.GetListOfDevice());


            }
        }

        private void  Btn_Ok_Click(object sender, EventArgs e)
        {
          
        }

        private void MainTree_NodeMouseClick(object sender, RadTreeViewEventArgs e)
        {
            try
            {
                DeviceId = Convert.ToInt32(((DataRowView)e.Node.Parent.Parent.Parent.DataBoundItem)["DeviceId"].ToString());
                DeviceLineId = Convert.ToInt32(((DataRowView)e.Node.Parent.DataBoundItem)["lineid"].ToString());
                StateId = Convert.ToInt32(((DataRowView)e.Node.DataBoundItem)["stateid"].ToString());

                DeviceLinePrimaryId = Convert.ToInt32(Bll_DeviceLine.GetDeviceLineById(DeviceId.ToString(), DeviceLineId.ToString()).DefaultView[0]["id"].ToString());
            }
            catch { }
        }
    }
}


