using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace PersianMIS.System_Settings
{
    public partial class Frm_ProductLine : Telerik.WinControls.UI.RadForm
    {
        BLL.Cls_ProductLines Bll_ProductLines = new BLL.Cls_ProductLines();
        BLL.Cls_PublicOperations Bll_publicOperations = new BLL.Cls_PublicOperations();

        public Frm_ProductLine()
        {
            InitializeComponent();
            FillDg();
            fillcmb();

        }

        private void fillcmb()
        {
            Cmb_NatureType .DataSource = Bll_ProductLines.GetNatureType ();
            Cmb_NatureType.ValueMember = "NatureId";
            Cmb_NatureType.DisplayMember = "NatureDesc";

            Cmb_PerformanceType.DataSource = Bll_ProductLines.GetPerformanceType();
            Cmb_PerformanceType.ValueMember = "PerformanceTypeID";
            Cmb_PerformanceType.DisplayMember = "PerformanceTypeDesc";

         }


        private void Btn_Save_Click(object sender, EventArgs e)
        {


            if (Txt_LineCode.Text == "" || Txt_Description.Text == "" || Cmb_NatureType.Text  == "" || Cmb_PerformanceType.Text=="" || Txt_ProductionLine.Text == "" || Txt_Salon.Text == "")
            {
                MessageBox.Show("لطفاً اطلاعات را تکمیل نمائید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Bll_ProductLines.Insert(Txt_LineCode.Text, Txt_ProductionLine.Text, Txt_Description.Text, Txt_Salon.Text ,(int)Cmb_NatureType.SelectedValue,(int)Cmb_PerformanceType.SelectedValue );
                MessageBox.Show("اطلاعات با موفقیت ثبت گردید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDg();
            }
        }

        private void FillDg()
        {
            Grd_ListOfProductLines.DataSource = Bll_ProductLines.GetProductLines();
        }

        private void Grd_ListOfProductLines_RowsChanged(object sender, Telerik.WinControls.UI.GridViewCollectionChangedEventArgs e)
        {
         

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از بروز رسانی اطلاعات مطمن هستید ؟", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bll_ProductLines.Update(Txt_LineCode.Text, Txt_ProductionLine.Text, Txt_Description.Text , Txt_Salon.Text, Convert.ToInt32(Grd_ListOfProductLines.CurrentRow.Cells["id"].Value.ToString()), (int)Cmb_NatureType.SelectedValue, (int)Cmb_PerformanceType.SelectedValue);
                MessageBox.Show("اطلاعات با موفقیت ثبت گردید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDg();
            }

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمن هستید از حذف اطلاعات رکورد انتخابی؟", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bll_publicOperations.DeleteRecord("SP_DeleteProductLines", "id", Grd_ListOfProductLines.CurrentRow.Cells["id"].Value.ToString());
                MessageBox.Show("اطلاعات رکورد مورد نظر حذف گردید", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDg();
            }
        }

        private void Grd_ListOfProductLines_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_Description.Text = Grd_ListOfProductLines.CurrentRow.Cells["Description"].Value.ToString();
                Txt_LineCode.Text = Grd_ListOfProductLines.CurrentRow.Cells["ProductLineId"].Value.ToString();
                Cmb_NatureType.Text = Grd_ListOfProductLines.CurrentRow.Cells["NatureDesc"].Value.ToString();
                Cmb_PerformanceType.Text = Grd_ListOfProductLines.CurrentRow.Cells["PerformanceTypeDesc"].Value.ToString();

                Txt_ProductionLine.Text = Grd_ListOfProductLines.CurrentRow.Cells["ProductLineDesc"].Value.ToString();
                Txt_Salon.Text = Grd_ListOfProductLines.CurrentRow.Cells["SalonDesc"].Value.ToString();
            }
            catch { }
        }
    }
}
