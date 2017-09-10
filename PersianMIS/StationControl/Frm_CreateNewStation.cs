using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersianMIS.StationControl
{
    public partial class Frm_CreateNewStation : Telerik.WinControls.UI.RadForm
    {
        BLL.Cls_Station Bll_Station = new BLL.Cls_Station();
        public Frm_CreateNewStation()
        {
            InitializeComponent();
        }

        private void Txt_StationPulsCount_ValueChanged(object sender, EventArgs e)
        {

            if (Cmb_SelectStation.Items.Count > Txt_StationPulsCount.Value)
            {
                for (int i = Cmb_SelectStation.Items.Count; i > Txt_StationPulsCount.Value; i--)
                {
                    Cmb_SelectStation.Items.Remove(i);
                }
            }


            if (Cmb_SelectStation.Items.Count < Txt_StationPulsCount.Value)
            {
                for (int i = Cmb_SelectStation.Items.Count; i < Txt_StationPulsCount.Value; i++)
                {
                    Cmb_SelectStation.Items.Add(i + 1);
                }
            }

        }



        private void Cmb_SelectStation_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (Control x in MainPnl.Controls)
            {
                x.Visible = false;
            }

            MainPnl.Controls[(int)Cmb_SelectStation.SelectedItem - 1].Visible = true;

        }

        private void Btn_CreateStep1_Click(object sender, EventArgs e)
        {
            if (Txt_StationCaption.Text == "" || Txt_StationPulsCount.Value < 1)
            {
                MessageBox.Show("لطفاً اطلاعات درخواستی را تکمیل نمایید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            MainPnl.Controls.Clear();

            for (int i = 1; i <= Txt_StationPulsCount.Value; i++)
            {
                CreatePulsParameterUserControl NewPulsParameterUC = new CreatePulsParameterUserControl();

                NewPulsParameterUC.Tag = i;
                NewPulsParameterUC.Name = i.ToString();
                NewPulsParameterUC.Visible = false;
                NewPulsParameterUC.ParameterID.Text = i.ToString();
                MainPnl.Controls.Add(NewPulsParameterUC);

            }
            Btn_Step2.Image = global::PersianMIS.Properties.Resources.Step2Ok;
            Pnl_Step2.Visible = true;
            Pnl_Step3.Visible = false;
            PnlStep1.Visible = false;
            Pnl_Step4.Visible = false;

            this.Cursor = Cursors.Default;
        }

        private void Btn_Step1_Click(object sender, EventArgs e)
        {
            PnlStep1.Visible = true;
            Pnl_Step2.Visible = false;
            Pnl_Step3.Visible = false;
            Pnl_Step4.Visible = false;
        }

        private void Btn_Step2_Click(object sender, EventArgs e)
        {
            PnlStep1.Visible = false;
            Pnl_Step3.Visible = false;
            Pnl_Step2.Visible = true;
            Pnl_Step4.Visible = false;
        }

        private void Btn_GotoStpe4_Click(object sender, EventArgs e)
        {
          int LastNewStationId=  Bll_Station.Insert(Txt_StationCaption.Text, (int)Txt_StationPulsCount.Value);



            PnlStep1.Visible = false;
            Pnl_Step2.Visible = false;
            Pnl_Step3.Visible = false;
            Pnl_Step4.Visible = true;
            Btn_Step4.Image = global::PersianMIS.Properties.Resources.Step4Ok;

        }

        private void Btn_GotoStep3_Click(object sender, EventArgs e)
        {
            Btn_Step3.Image = global::PersianMIS.Properties.Resources.Step3Ok;
            PnlStep1.Visible = false;
            Pnl_Step2.Visible = false;
            Pnl_Step3.Visible = true;
            FlowPnl_Step3.Controls.Clear();
            foreach (Control x in MainPnl.Controls)
            {

                int i = 0;
                if (x.Controls[1].Text != "" && x.Controls[6].Tag != null)
                {
                    i = i + 1;
                    Pnl_Step3.Text = Txt_StationCaption.Text;
                    Label Lbl_ParametersExecutaion = new Label();
                    Lbl_ParametersExecutaion.BackColor = System.Drawing.Color.Transparent;
                    Lbl_ParametersExecutaion.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                    Lbl_ParametersExecutaion.ForeColor = Color.Green;
                    Lbl_ParametersExecutaion.AutoSize = true;
                    Lbl_ParametersExecutaion.TextAlign = System.Drawing.ContentAlignment.TopRight;

                    Lbl_ParametersExecutaion.Text = i + "-" + x.Controls[1].Text;
                    FlowPnl_Step3.Controls.Add(Lbl_ParametersExecutaion);
                }


            }
            Telerik.WinControls.UI.RadButton Btn_ContinueStep3 = new Telerik.WinControls.UI.RadButton();

            Btn_ContinueStep3.Image = global::PersianMIS.Properties.Resources.nextButton;

            Btn_ContinueStep3.Cursor = System.Windows.Forms.Cursors.Hand;
            Btn_ContinueStep3.Text = "ادامه";
            Btn_ContinueStep3.Size = new System.Drawing.Size(103, 36);

            Btn_ContinueStep3.Click += new System.EventHandler(Btn_GotoStpe4_Click);

            FlowPnl_Step3.Controls.Add(Btn_ContinueStep3);

        }

        private void Btn_Step3_Click(object sender, EventArgs e)
        {
            PnlStep1.Visible = false;
            Pnl_Step2.Visible = false;
            Pnl_Step3.Visible = true;
            Pnl_Step4.Visible = false;

        }

        private void Btn_Finished_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
