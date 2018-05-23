using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace PersianMIS.PublicTabs
{
    public partial class Frm_MessageSetting : Telerik.WinControls.UI.RadForm
    {
        BLL.CSL_Personely Bll_Personely = new BLL.CSL_Personely();
        public Frm_MessageSetting()
        {
            InitializeComponent();
        }

        private void Frm_MessageSetting_Load(object sender, EventArgs e)
        {
            FillCmb();
        }

        private void FillCmb()
        {
            Cmb_ListOfPersons .DataSource = Bll_Personely.GetListOfActivePersonels();
            Cmb_ListOfPersons.ValueMember = "personcode";
            Cmb_ListOfPersons.DisplayMember = "name";
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
             using (var frms = new Frm_SelectPuls())  
            {
                frms.ShowDialog();
               //  frms.Test 
            }
        }
    }
}
