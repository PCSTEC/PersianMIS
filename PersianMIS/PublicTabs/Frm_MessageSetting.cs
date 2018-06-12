using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.WinControls;

namespace PersianMIS.PublicTabs
{
    public partial class Frm_MessageSetting : Telerik.WinControls.UI.RadForm
    {
        BLL.CSL_Personely Bll_Personely = new BLL.CSL_Personely();
        BLL.CLS_Message Bll_Message = new BLL.CLS_Message();
        int DeviceLinePrimaryId = 0;
        int StateId, MessageThemplateID = 0;
        BLL.Cls_PublicOperations Bll_Public = new BLL.Cls_PublicOperations();

        Boolean IsEditMode = false;
        public Frm_MessageSetting()
        {
            InitializeComponent();
        }

        private void Frm_MessageSetting_Load(object sender, EventArgs e)
        {
            FillCmb();
            FillLst();
            fillGrd();
        }

        private void fillGrd()
        {
            Grd_ListOfDevice.DataSource = Bll_Message.GetAllMessageThemplates();

        }

        private void FillLst()
        {
            LstOfMessageBodyItems.DataSource = Bll_Message.GetListOfMessageBodyItems();

            LstOfMessageBodyItems.DisplayMember = "MessageBodyItemText";
            LstOfMessageBodyItems.ValueMember = "MessageBodyItemId";

        }

        private void FillCmb()
        {
            Cmb_ListOfPersons.DataSource = Bll_Personely.GetListOfActivePersonels();
            Cmb_ListOfPersons.ValueMember = "personcode";
            Cmb_ListOfPersons.DisplayMember = "name";
            Cmb_ListOfPersons.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void Btn_SelectPuls_Click(object sender, EventArgs e)
        {
            using (var frms = new Frm_SelectPuls())
            {
                frms.ShowDialog();
                DeviceLinePrimaryId = frms.DeviceLinePrimaryId;

            }
        }

        private void Btn_CreateNewLine_Click(object sender, EventArgs e)
        {
            if (DeviceLinePrimaryId == 0 || LstOfSelectedMessageBodyItems.Items.Count < 1 || Txt_PrefixCaption.Text == "")
            {
                MessageBox.Show("لطفاً تمامی اطلاعات را تکمیل فرمایید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {
                string MessageBodyItems = "0";
                for (int i = 0; i <= LstOfSelectedMessageBodyItems.Items.Count - 1; i++)
                {

                    MessageBodyItems = MessageBodyItems + "," + LstOfSelectedMessageBodyItems.Items[i].Value;
                }
                if (IsEditMode)
                {
                    if (MessageBox.Show("آیا مطمن هستید از ویرایش رکورد انتخابی ؟ ", Properties.Settings.Default.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Bll_Message.Update(Convert.ToInt32(Cmb_ListOfPersons.SelectedValue), DeviceLinePrimaryId, StateId, Convert.ToInt32(TxtDurationTime.Value), Txt_PrefixCaption.Text, MessageBodyItems, MessageThemplateID, Convert.ToInt32(TxtRepeatMessageAtTimeDuration .Value));
                    }
                    else
                    {
                        MessageBox.Show("عملیات لغو گردید ", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearObjects();
                        return;
                    }
                }
                else
                {

                    Bll_Message.Insert(Convert.ToInt32(Cmb_ListOfPersons.SelectedValue), DeviceLinePrimaryId, StateId, Convert.ToInt32(TxtDurationTime.Value), Txt_PrefixCaption.Text, MessageBodyItems, Convert.ToInt32(TxtRepeatMessageAtTimeDuration.Value));

                }

                    MessageBox.Show("اطلاعات با موفقیت ثبت گردید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearObjects();
                }
            }



        private void ClearObjects()
        {
            FillCmb();
            if (LstOfSelectedMessageBodyItems.Items.Count > 0)
            {
                LstOfSelectedMessageBodyItems.Items.Clear();
            }
            if (LstOfMessageBodyItems.Items.Count > 0)
            {
                LstOfMessageBodyItems.Items.Clear();
            }
            fillGrd();
            FillLst();
            TxtDurationTime.Value = 1;
            TxtRepeatMessageAtTimeDuration.Value = 1;
            Txt_PrefixCaption.Text = "";
            StateId = 0;
            DeviceLinePrimaryId = 0;
            Main_Page.SelectedPage = Tab_ListOfAssignedSMS;
        }

        private void Btn_RemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                LstOfMessageBodyItems.Items.Add(new Telerik.WinControls.UI.RadListDataItem(LstOfSelectedMessageBodyItems.SelectedItem.Text, LstOfSelectedMessageBodyItems.SelectedItem.Value));

                LstOfSelectedMessageBodyItems.Items.Remove(LstOfSelectedMessageBodyItems.SelectedItem);
            }
            catch
            {

            }
        }

        private void Btn_AddItem_Click(object sender, EventArgs e)
        {
            try
            {
                LstOfSelectedMessageBodyItems.Items.Add(new Telerik.WinControls.UI.RadListDataItem(LstOfMessageBodyItems.SelectedItem.Text, LstOfMessageBodyItems.SelectedItem.Value));

                LstOfMessageBodyItems.Items.Remove(LstOfMessageBodyItems.SelectedItem);
            }

            catch { }
        }


        private void Mnu_Edit_Click(object sender, EventArgs e)
        {

            BLL.Cls_PublicOperations.Dt = Bll_Message.GetSpecialMessageThemplateById(Convert.ToInt32(Grd_ListOfDevice.CurrentRow.Cells["MessageThemplateID"].Value.ToString()));

            Cmb_ListOfPersons.SelectedValue = Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[0]["personcode"].ToString());




            int countOfMessageBodyItems = BLL.Cls_PublicOperations.Dt.DefaultView[0]["MessageBodyFormat"].ToString().Split(',').Length - 1;

            MatchCollection allMatchResults = null;
            var regexObj = new Regex(@",\w*");
            allMatchResults = regexObj.Matches(BLL.Cls_PublicOperations.Dt.DefaultView[0]["MessageBodyFormat"].ToString());
            foreach (var Item in allMatchResults)
            {
                string str = Item.ToString().Replace(",", "");
                for (int i = 0; i <= LstOfMessageBodyItems.Items.Count - 1; i++)
                {
                    LstOfMessageBodyItems.SelectedIndex = i;
                    if (LstOfMessageBodyItems.SelectedItem.Value.ToString() == str)
                    {
                        LstOfSelectedMessageBodyItems.Items.Add(new Telerik.WinControls.UI.RadListDataItem(LstOfMessageBodyItems.SelectedItem.Text, LstOfMessageBodyItems.SelectedItem.Value));
                        LstOfMessageBodyItems.Items.Remove(LstOfMessageBodyItems.SelectedItem);
                    }
                }
            }
            DeviceLinePrimaryId= Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[0]["DeviceLinePrimaryId"].ToString());
            StateId= Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[0]["stateid"].ToString());

            Txt_PrefixCaption.Text = BLL.Cls_PublicOperations.Dt.DefaultView[0]["MssagePrefixTitle"].ToString();

            TxtDurationTime.Value = Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[0]["durationtime"].ToString());
            TxtRepeatMessageAtTimeDuration.Value = Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[0]["RepeatMessageAtTime"].ToString());

            IsEditMode = true;
            Main_Page.SelectedPage = Tab_NewAssignSMS;
            MessageThemplateID = Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[0]["MessageThemplateID"].ToString());
        }
    }
}
