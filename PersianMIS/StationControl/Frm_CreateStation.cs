using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using BLL;
using Persistent;
namespace PersianMIS.StationControl
{

    public partial class Frm_CreateStation : Telerik.WinControls.UI.RadForm
    {
       

        BLL.Cls_ProductLines Bll_PrdLine = new Cls_ProductLines();
        Persistent.DataAccess.DataAccess pers = new Persistent.DataAccess.DataAccess();
        BLL.CLS_DeviceLine Bll_DeviceLine = new CLS_DeviceLine();
        BLL.CLS_Device bll_Device = new CLS_Device();

        BLL.Cls_Station Bll_Station = new Cls_Station();
        DataTable Dt = new DataTable();
        public Frm_CreateStation( Boolean IsEdit)
        {
            InitializeComponent();
            if (IsEdit == true)
            {
                Btn_Update.Visible = true;
                Btn_Save.Visible = false;
            }
            else
            {
                Btn_Update.Visible = false;
                Btn_Save.Visible = true ;
            }

            FillDg();

        }

        private void FillDg()
        {
            Grd_ListOfStation.DataSource = Bll_Station.GetStations(0);
          
        }



        private void FillCmb()
        {

            pers.FillCmb(Bll_PrdLine.GetProductLines(), Cmb_ProductLine, "ID", "ProductLineDesc");



        }

        private void Frm_CreateStation_Load(object sender, EventArgs e)
        {
            FillCmb();
        }

        private void Cmb_ProductLine_SelectedValueChanged(object sender, EventArgs e)
        {

            int x;
            if (int.TryParse(Cmb_ProductLine.SelectedValue.ToString(), out x) == true)
                pers.FillCmb(bll_Device.GetListOfDeviceByProductLine(Cmb_ProductLine.SelectedValue.ToString()), Cmb_Device, "DeviceId", "DeviceDesc");
        }

        private void Cmb_Device_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int x;
                if (int.TryParse(Cmb_Device.SelectedValue.ToString(), out x) == true)
                    pers.FillCmb(Bll_DeviceLine.GetDeviceLineById(Cmb_Device.SelectedValue.ToString(), "0"), Cmb_InputLine, "ID", "LineDesc");
            }catch { }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Cmb_Device.Text == "" || Cmb_InputLine.Text == "" || Cmb_ProductLine.Text == "" || Txt_Description.Text == "" || Txt_LineCode.Text == "")
            {
                MessageBox.Show("لطفاً اطلاعات را تکمیل نمائید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Bll_Station.Insert(Convert.ToInt32(Cmb_ProductLine.SelectedValue.ToString()), Convert.ToInt32(Cmb_Device.SelectedValue.ToString()), Convert.ToInt32(Cmb_InputLine.SelectedValue.ToString()), Txt_LineCode.Text, Txt_Description.Text);

            MessageBox.Show("ایستگاه مورد نظر با موفقیت ایجاد گردید", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);

            FillDg();
        }

        private void Grd_ListOfStation_Click(object sender, EventArgs e)
        {
            Cmb_ProductLine.Text= Grd_ListOfStation.CurrentRow.Cells["ProductLineDesc"].Value.ToString();
            Cmb_Device.Text =Grd_ListOfStation.CurrentRow.Cells["DeviceDesc"].Value.ToString();
            Cmb_InputLine.Text = Grd_ListOfStation.CurrentRow.Cells["LineDesc"].Value.ToString();
            Txt_LineCode.Text = Grd_ListOfStation.CurrentRow.Cells["StationDesc"].Value.ToString();
            Txt_Description.Text = Grd_ListOfStation.CurrentRow.Cells["Description"].Value.ToString();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از بروز رسانی اطلاعات مطمن هستید ؟", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bll_Station.Update(Convert.ToInt32(Cmb_ProductLine.SelectedValue.ToString()), Convert.ToInt32(Cmb_Device.SelectedValue.ToString()), Convert.ToInt32(Cmb_InputLine.SelectedValue.ToString()), Txt_LineCode.Text, Txt_Description.Text, Convert.ToInt32(Grd_ListOfStation.CurrentRow.Cells["StationId"].Value.ToString()));
                MessageBox.Show("اطلاعات با موفقیت ثبت گردید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDg();
            }

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمن هستید از حذف اطلاعات رکورد انتخابی؟", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bll_Station.Delete (Convert.ToInt32( Grd_ListOfStation.CurrentRow.Cells["stationid"].Value.ToString()));
                MessageBox.Show("اطلاعات رکورد مورد نظر حذف گردید", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDg();
            }
        }
    }
}
