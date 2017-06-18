using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using IraniDate.IraniDate;
namespace PersianMIS.StationControl
{
    public partial class Frm_FillterStation : Telerik.WinControls.UI.RadForm
    {
        IraniDate.IraniDate.IraniDate IrDate = new IraniDate.IraniDate.IraniDate();
        BLL.Cls_ProductLines Bll_ProductLine = new BLL.Cls_ProductLines();
        Persistent.DataAccess.DataAccess Pers = new Persistent.DataAccess.DataAccess();

        public Frm_FillterStation( int ProductLineID)
        {

            InitializeComponent();
            if (ProductLineID != 0)
            {
                Lbl_ProductLine.Visible = true;
                Cmb_ProductLine.Visible = true;
                Pers.FillCmb(Bll_ProductLine.GetProductLines(), Cmb_ProductLine,"id" ,"productlinedesc" );

                FillCmb();
            }
            
            FillData();
           
        }
        

        private void FillCmb()
        {
            
        }
        private void FillData()
        {
            MskDate.Text = IrDate.GetIrani8DateStr_CurDate();
            MskDate.Focus();
        }

        private void MskDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MskBeginTime.Focus();
            }
        }

        private void MskTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                
                MskEndTime.Focus();
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

 
            public string Date
            {
                get
                {
                    return MskDate.Text;
                }
            }


        public string ProductLineId
        {
            get
            {
                return Cmb_ProductLine.SelectedValue.ToString();
            }
        }



        public string BeginTime
        {
            get
            {
                return MskBeginTime.Text;
            }
        }

        public string EndTime
        {
            get
            {
                return MskEndTime.Text;
            }
        }


        public string   NumberOfNextDay
        {
            get
            {
                return TxtNextDayNumber.Value.ToString ()   ;
            }
        }

        private void MskEndTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Btn_OK_Click(sender, e);
                MskEndTime.Focus();
            }
        }
    }
}
