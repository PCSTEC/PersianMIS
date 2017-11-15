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
            FillDg();

        }

        private void FillDg()
        {
            Grd_ListOfStation.DataSource = Bll_Station.GetStations( );
          
        }

         
        private void Frm_CreateStation_Load(object sender, EventArgs e)
        {
             
        }

       

        private void Grd_ListOfStation_Click(object sender, EventArgs e)
        {
            
            Txt_StationName.Text = Grd_ListOfStation.CurrentRow.Cells["StationName"].Value.ToString();
        
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از بروز رسانی اطلاعات مطمن هستید ؟", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bll_Station.Update(Txt_StationName.Text, Convert.ToInt32(Grd_ListOfStation.CurrentRow.Cells["StationId"].Value.ToString()));
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

        private void Btn_EditFormula_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Form frm = new Frm_CreateNewStation(true, Grd_ListOfStation.CurrentRow.Cells["stationid"].Value.ToString());
            frm.ShowDialog();
            this.Cursor = Cursors.Arrow ;
        }
    }
}
