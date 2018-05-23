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
       


        public String DeviceIdStr { get; set; }
        public  String DeviceLineIdStr { get; set; }
        public  String StateIdStr { get; set; }




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
            DeviceIdStr = ((DataRowView)e.Node.Parent.Parent.Parent.DataBoundItem)["DeviceId"].ToString();
            DeviceLineIdStr = ((DataRowView)e.Node.Parent.DataBoundItem)["lineid"].ToString();
            StateIdStr = ((DataRowView)e.Node.DataBoundItem)["stateid"].ToString();

        }
    }
}


