using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using BLL;
namespace PersianMIS.Production.Chart
{
    
    
    public partial class Frm_SelectChartOptions : Telerik.WinControls.UI.RadForm
    {
        BLL.CLS_DeviceLine Bll_DeviceLine = new CLS_DeviceLine();

        BLL.CLS_Device Bll_device = new CLS_Device();
        BLL.Cls_ProductLines Bll_ProductLine = new Cls_ProductLines();
        public Frm_SelectChartOptions()
        {
            InitializeComponent();
        }

        private void Frm_SelectChartOptions_Load(object sender, EventArgs e)
        {
           // MainTree.DataSource = Bll_DeviceLine.GetAllDeviceWithInformation();
           //// MainTree.DataMember = "Vw_LineInfo";
           // MainTree.DisplayMember = "DeviceDesc";
           // MainTree.ParentMember = "LineCaptionWithProductLine";
           // MainTree.ChildMember = "ActiveStateDesc";
           // MainTree.ValueMember = "ActiveStateDesc";
            using (this.MainTree.DeferRefresh())
            {
                 this.MainTree.RelationBindings.Add(Bll_ProductLine .GetProductLineToHowDeviceSet(), "ProductLineDesc", "DeviceId");

                this.MainTree.RelationBindings.Add(Bll_DeviceLine.GetAllDeviceWithInformation (), "LineDesc", "ProductLineId");
                this.MainTree.MultiSelect = true;
                this.MainTree.DisplayMember = "DeviceDesc";
                this.MainTree.DataSource = (Bll_device.GetListOfDevice());
                
            }

        }
    }
}
