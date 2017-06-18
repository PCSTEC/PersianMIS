using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using BLL;
using Telerik.WinControls.UI;

namespace PersianMIS.System_Settings
{
    public partial class Frm_DeviceSetting : Telerik.WinControls.UI.RadForm
    {
        BLL.Cls_GetData BLL_GetData = new Cls_GetData();
        BLL.Cls_PublicOperations BLL_PublicOperation = new Cls_PublicOperations();
        BLL.CLS_DeviceLine BLL_DeviceLine = new CLS_DeviceLine();
        BLL.Cls_ProductLines Bll_ProductLines = new Cls_ProductLines();
        BLL.CLS_Device BLL_Device = new CLS_Device();
        DataTable PublicDt = new DataTable();
        int Deviceid = 0;
        Telerik.WinControls.UI.RadPageViewPage Tab_Update = new RadPageViewPage();

        Boolean IsEdit = false;

        public Frm_DeviceSetting()
        {
            InitializeComponent();
        }


        private void TreeViewDevice2_NodeMouseMove(object sender, Telerik.WinControls.UI.RadTreeViewMouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void GetPorts()
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                Cmb_Dargah.Items.Add(s);
            }
        }

        private void Frm_DeviceSetting_Load(object sender, EventArgs e)
        {
            FillData();
        }



        private void Btn_RefreshPorts_Click(object sender, EventArgs e)
        {
            GetPorts();
        }


        private void FillData()
        {
            Grd_ListOfDevice.DataSource = BLL_Device.GetListOfDevice();

            GetPorts();
            FillCmbProductLine();
            Txt_PCName.Text = System.Net.Dns.GetHostName();

            //Fill Cmb_Zarib Type for Show List Of ZaribType
            Cmb_ZaribType.DataSource = BLL_GetData.GetListOfInputPortTypes();
            Cmb_ZaribType.DisplayMember = "InputPortType";
            Cmb_ZaribType.ValueMember = "InputPortTypeId";
            FillCmbPulsType();

        }

        private void FillCmbPulsType()
        {
            //Fill Cmb_PulsType Type for Show List Of Puls Types .
            Cmb_PulsType.DataSource = BLL_GetData.GetListOfPulsTypes();
            Cmb_PulsType.DisplayMember = "PulsTypeDesc";
            Cmb_PulsType.ValueMember = "PulsTypeId";
        }

        private void Btn_InsertPuls_Click(object sender, EventArgs e)
        {
            BLL_PublicOperation.InsertRecord("Sp_InsertPulsType", "PulsTypeDesc", Cmb_PulsType.Text);
            FillCmbPulsType();
        }


        private void FillCmbProductLine()
        {
            Cmb_ProductionLine.DataSource = Bll_ProductLines.GetProductLines();
            Cmb_ProductionLine.ValueMember = "ID";
            Cmb_ProductionLine.DisplayMember = "ProductLineId";

        }

        private void Btn_CreateNewLine_Click(object sender, EventArgs e)
        {


            BLL_DeviceLine.Insert("SP_insertDevicesLine", Convert.ToInt32(Cmb_InputId.Text), Txt_InputCaption.Text, Deviceid, Convert.ToInt32(Cmb_PulsType.SelectedValue), Convert.ToInt32(Cmb_ZaribType.SelectedValue), Convert.ToInt32(Cmb_ProductionLine.SelectedValue), CPE_SelectActiveLineColor.Color.ToArgb().ToString(), CPE_SelectDeActiveLineColor.Color.ToArgb().ToString(), false,Txt_ActiveStateDesc.Text , Txt_DeActiveDesc.Text );
            CrateNewLine(Txt_InputCaption.Text, Convert.ToInt32(Cmb_InputId.Text));

        }




        private void CrateNewLine(string LineCaption, int lineId)
        {

            RadTreeNode NewLine = new RadTreeNode();
            NewLine.Expanded = true;
            NewLine.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            NewLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(189)))), ((int)(((byte)(7)))));
            NewLine.Name = lineId.ToString();
            NewLine.Tag = lineId;
            NewLine.Text = "ورودی شماره" + lineId.ToString() + ":  " + LineCaption;

            if (lineId <= 12)
            {
                TreeViewDevice1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] { NewLine });
            }
            else
            {

                TreeViewDevice2.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] { NewLine });


            }
        }

        private void Btn_CreateNewDevice_Click(object sender, EventArgs e)
        {
            if (Txt_DeviceCaption.Text == "" || Txt_PCName.Text == "" || Cmb_Dargah.Text == "")
            {
                MessageBox.Show("لطفاً اطلاعات را تکمیل نمائید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsEdit == true)
            {

               
                
                    BLL_Device.Update (Txt_DeviceCaption.Text, Txt_PCName.Text, Cmb_Dargah.Text,Deviceid);
                  
                
            }
            else
            {

                
                    Deviceid = BLL_Device.Insert(Txt_DeviceCaption.Text, Txt_PCName.Text, Cmb_Dargah.Text);
                   
                 
             
            }
            Img_Device.Visible = true;
            TreeViewDevice1.Visible = true;
            TreeViewDevice2.Visible = true;
            Gp_CreateDeviceLine.Visible = true;
            Gp_Device.Enabled = false;
        }

        private void TreeViewDevice1_NodeMouseClick(object sender, RadTreeViewEventArgs e)
        {
            try
            {
                PublicDt = BLL_DeviceLine.GetDeviceLineById(Deviceid.ToString(), e.Node.Tag.ToString());
                Fill_CreateDeviceLineItems(PublicDt);
            }
            catch
            {

            }
        }



        private void Fill_CreateDeviceLineItems(DataTable Dt)
        {
            Cmb_InputId.Text = Dt.DefaultView[0]["LineId"].ToString();
            Txt_InputCaption.Text = Dt.DefaultView[0]["LineDesc"].ToString();
            Cmb_PulsType.SelectedValue = Convert.ToInt32(Dt.DefaultView[0]["PulsID"].ToString());
            Cmb_ZaribType.SelectedValue = Convert.ToInt32(Dt.DefaultView[0]["InputPortTypeId"].ToString());
            Cmb_ProductionLine.SelectedValue = Convert.ToInt32(Dt.DefaultView[0]["ProductLineId"].ToString());
            CPE_SelectActiveLineColor.Color = Color.FromArgb(Convert.ToInt32(Dt.DefaultView[0]["ActiveColor"].ToString()));
            CPE_SelectDeActiveLineColor.Color = Color.FromArgb(Convert.ToInt32(Dt.DefaultView[0]["DeActiveColor"].ToString()));
            Txt_ActiveStateDesc.Text = Dt.DefaultView[0]["ActiveStateDesc"].ToString();
            Txt_DeActiveDesc.Text= Dt.DefaultView[0]["DeActiveStateDesc"].ToString();
        }

        private void Btn_UpdateInputLine_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمن هستید از ویرایش اطلاعات خط ورودی", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {

                BLL_DeviceLine.Update("SP_UpdateDevicesLine", Convert.ToInt32(Cmb_InputId.Text), Txt_InputCaption.Text, Deviceid, Convert.ToInt32(Cmb_PulsType.SelectedValue), Convert.ToInt32(Cmb_ZaribType.SelectedValue), Convert.ToInt32(Cmb_ProductionLine.SelectedValue), CPE_SelectActiveLineColor.Color.ToArgb().ToString(), CPE_SelectDeActiveLineColor.Color.ToArgb().ToString(), false,Txt_ActiveStateDesc.Text,Txt_DeActiveDesc.Text );
                MessageBox.Show("اطلاعات مورد نظر با موفقیت بروز رسانی گردید", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Convert.ToInt32(Cmb_InputId.Text) <= 12)
                {
                    TreeViewDevice1.SelectedNode.Text = "ورودی شماره" + Convert.ToInt32(Cmb_InputId.Text) + ":  " + Txt_InputCaption.Text;
                }
                else
                {

                    TreeViewDevice2.SelectedNode.Text = "ورودی شماره" + Convert.ToInt32(Cmb_InputId.Text) + ":  " + Txt_InputCaption.Text;


                }

            }
        }

        private void Mnu_DeleteNewLine_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمن هستید از حذف اطلاعات خط ورودی", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                BLL_DeviceLine.Delete("Sp_DeleteDeviceLine", Deviceid.ToString(), Cmb_InputId.Text);

                if (Convert.ToInt32(Cmb_InputId.Text) > 12)
                {
                    TreeViewDevice2.Nodes.Remove(TreeViewDevice2.SelectedNode);
                }
                else
                {
                    TreeViewDevice1.Nodes.Remove(TreeViewDevice1.SelectedNode);
                }
                MessageBox.Show("ورودی مورد نظر حذف گردید", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }



        private void DeleteNewLine(int DeviceId, int lineId)
        {


        }

        private void Mnu_Active_Click(object sender, EventArgs e)
        {
            BLL_Device.ChangeDeviceState(Convert.ToInt32(Grd_ListOfDevice.CurrentRow.Cells["DeviceId"].Value.ToString()), true);
            MessageBox.Show("دستگاه مورد نظر   فعال گردید", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);

            Grd_ListOfDevice.DataSource = BLL_Device.GetListOfDevice();

        }



        private void Mnu_DeActive_Click(object sender, EventArgs e)
        {
            BLL_Device.ChangeDeviceState(Convert.ToInt32(Grd_ListOfDevice.CurrentRow.Cells["DeviceId"].Value.ToString()), false);
            MessageBox.Show("دستگاه مورد نظر  غیر فعال گردید", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            Grd_ListOfDevice.DataSource = BLL_Device.GetListOfDevice();

        }

        private void Grd_ListOfDevice_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grd_ListOfDevice.CurrentRow.Cells["active"].Value.ToString().Equals("فعال"))
                {
                    Mnu_DeActive.Visible = true;
                    Mnu_Active.Visible = false;
                }
                else
                {
                    Mnu_Active.Visible = true;
                    Mnu_DeActive.Visible = false;
                }
            }
            catch { }
        }

        private void Mnu_DeleteDevice_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grd_ListOfDevice.CurrentRow.Cells["active"].Value.ToString().Equals("فعال"))
                {
                    MessageBox.Show("دستگاه مورد در حالت فعال می باشد این امکان وجود ندارد", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (MessageBox.Show("آیا مطمن هستید از اطلاعات دستگاه ورودی", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BLL_Device.DeleteDevice(Convert.ToInt32(Grd_ListOfDevice.CurrentRow.Cells["DeviceId"].Value.ToString()));
                        MessageBox.Show("دستگاه مورد نظر حذف گردید", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Grd_ListOfDevice.DataSource = BLL_Device.GetListOfDevice();
                    }
                }
            }
            catch { }
        }

        private void Mnu_EditDevice_Click(object sender, EventArgs e)
        {
            IsEdit = true;
            Deviceid = Convert.ToInt32(Grd_ListOfDevice.CurrentRow.Cells["DeviceId"].Value.ToString());
            FillEditDeviceInfo(BLL_DeviceLine.GetDeviceLineById(Deviceid.ToString(), "0"));
          
            Tab_Update.Controls.Add(radScrollablePanel1);
            Tab_Update.ItemSize = new System.Drawing.SizeF(112F, 34F);
            Tab_Update.Location = new System.Drawing.Point(10, 43);
            Tab_Update.Name = "Tab_NewDevice";
            Tab_Update.Size = new System.Drawing.Size(1085, 544);
            Tab_Update.Text = "ویرایش اطلاعات";
            Main_Page.Pages.Add(Tab_Update);
            Tab_Update.Controls.Add(this.radScrollablePanel1);
            Main_Page.SelectedPage = Tab_Update;
            Btn_CreateNewDevice.Text = "ویرایش دستگاه";
        }

        private void FillEditDeviceInfo(DataTable DT)
        {
            try
            {
                Txt_DeviceCaption.Text = DT.DefaultView[0]["DeviceDesc"].ToString();
                Txt_PCName.Text = DT.DefaultView[0]["ComputerName"].ToString();
                Cmb_Dargah.SelectedText = DT.DefaultView[0]["PortName"].ToString();
                Gp_CreateDeviceLine.Visible = true;
                Img_Device.Visible = true;
                TreeViewDevice1.Visible = true;
                TreeViewDevice2.Visible = true;


                try
                {
                    if (TreeViewDevice1.Nodes.Count > 1)
                    {
                        for (int i = TreeViewDevice1.Nodes.Count - 1; i >= 1; i--)
                        {
                            TreeViewDevice1.Nodes[i].Remove();
                        }
                    }
                }
                catch { }


                try
                {
                    if (TreeViewDevice2.Nodes.Count > 1)
                    {
                        for (int i = TreeViewDevice2.Nodes.Count - 1; i >= 1; i--)
                        {
                            TreeViewDevice2.Nodes[i].Remove();
                        }
                    }
                }
                catch { }


                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    CrateNewLine(DT.DefaultView[i]["LineDesc"].ToString(), Convert.ToInt32(DT.DefaultView[i]["LineId"].ToString()));
                }

            }catch { }
        }

        private void Btn_CommiteNewDevice_Click(object sender, EventArgs e)
        {
            try
            {
                if (TreeViewDevice1.Nodes.Count > 1)
                {
                    for (int i = TreeViewDevice1.Nodes.Count - 1; i >= 1; i--)
                    {
                        TreeViewDevice1.Nodes[i].Remove();
                    }
                }
            }
            catch { }


            try
            {
                if (TreeViewDevice2.Nodes.Count > 1)
                {
                    for (int i = TreeViewDevice2.Nodes.Count - 1; i >= 1; i--)
                    {
                        TreeViewDevice2.Nodes[i].Remove();
                    }
                }
            }
            catch { }

            Txt_DeviceCaption.Text = "";
            Txt_InputCaption.Text = "";
            Txt_PCName.Text = System.Net.Dns.GetHostName();
            Gp_Device.Enabled = true;
            Gp_CreateDeviceLine.Visible = false;
            Img_Device.Visible = false;
            TreeViewDevice1.Visible = false;
            TreeViewDevice2.Visible = false;
            Mnu_Refresh_Click(e, e);
            if(IsEdit==true)
            {
                IsEdit = false;
                Main_Page.Pages.Remove(Main_Page.SelectedPage);

            }
        }

        private void Mnu_Refresh_Click(object sender, EventArgs e)
        {
            Grd_ListOfDevice.DataSource = BLL_Device.GetListOfDevice();
        }



        private void Main_Page_SelectedPageChanged(object sender, EventArgs e)

        {
            try
            {

                var NewTab = (RadPageView)sender;
                if (NewTab.SelectedPage.Text == "تعریف دستگاه جدید")
                {
                    Tab_NewDevice.Controls.Add(radScrollablePanel1);
                    Btn_CommiteNewDevice_Click(e, e);
                    Btn_CreateNewDevice.Text = "ایجاد دستگاه جدید";
                    IsEdit = false;
                }
                if (NewTab.SelectedPage.Text == "ویرایش اطلاعات")
                {
                    Tab_Update.Controls.Add(radScrollablePanel1);
                }
             
            }
            catch
            {
                 
            }
        }

        private void MNU_Grd_Opening(object sender, CancelEventArgs e)
        {

        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            RadForm Frm = new System_Settings.Frm_ProductLine();
            Frm.ShowDialog();
            FillCmbProductLine();
        }
    }
}
