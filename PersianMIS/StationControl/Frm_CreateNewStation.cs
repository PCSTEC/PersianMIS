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
            foreach(Control  x in MainPnl.Controls)
            {
                x.Visible = false;
            }

                MainPnl.Controls[(int)Cmb_SelectStation.SelectedItem-1 ].Visible = true;
            
        }

        private void Btn_CreateStep1_Click(object sender, EventArgs e)
        {
            MainPnl.Controls.Clear();

            for (int i = 1; i <= Txt_StationPulsCount.Value; i++)
            {
                CreatePulsParameterUserControl NewPulsParameterUC = new CreatePulsParameterUserControl();

                NewPulsParameterUC.Tag = i;
                NewPulsParameterUC.Name = i.ToString();
                NewPulsParameterUC.Visible = false;
                NewPulsParameterUC.ParameterID.Text = "پالس شماره :" + i.ToString();
                MainPnl.Controls.Add(NewPulsParameterUC);

            }
            Btn_Step2.Image = global::PersianMIS.Properties.Resources.Step2Ok;
            Pnl_Step2.Visible = true;
            PnlStep1.Visible = false;
        }

        private void Btn_Step1_Click(object sender, EventArgs e)
        {
            Pnl_Step2.Visible = false;
            PnlStep1.Visible = true;

        }

        private void Btn_Step2_Click(object sender, EventArgs e)
        {
            Pnl_Step2.Visible = true ;
            PnlStep1.Visible = false;
        }
    }
}
