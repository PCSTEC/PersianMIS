using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace PersianMIS.StationControl
{


    public partial class CreateNewParameterFromulaWithReturnTSQLUserControl : UserControl
    {


        BLL.Cls_PublicOperations Bll_Public = new BLL.Cls_PublicOperations();

        public string TSQL = "";
        DataTable Dt = new DataTable();
        BLL.CLS_Device BllDevice = new CLS_Device();
        BLL.CLS_DeviceLine BllDeviceLine = new CLS_DeviceLine();
        Persistent.DataAccess.DataAccess Pers = new Persistent.DataAccess.DataAccess();

        public CreateNewParameterFromulaWithReturnTSQLUserControl()
        {
            InitializeComponent();
            FillCmbDevice();
        }


        private void FillCmbDevice()
        {
            try
            {
                Pers.FillCmb(BllDevice.GetListOfDevice(), Cmb_SelectDevice, "DeviceId", "DeviceDesc");

            }
            catch
            {

            }
        }

        private void Cmb_SelectDevice_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Pers.FillCmb(BllDeviceLine.GetDeviceLineByDeviceId(Cmb_SelectDevice.SelectedValue.ToString()), Cmb_SelectPuls, "ID", "LineDesc");
            }
            catch
            {

            }
        }

        private void Cmb_SelectPuls_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Dt.Rows.Clear();
                Dt.Columns.Clear();
                DataTable Dt2 = new DataTable();
                Dt2 = BllDeviceLine.GetDeviceLineById(Cmb_SelectPuls.SelectedValue.ToString());
                Dt.Columns.Add("id");
                Dt.Columns.Add("Value");

                Dt.Rows.Add();

                Dt.Rows[0][0] = "0";
                Dt.Rows[0][1] = Dt2.DefaultView[0]["DeActiveStateDesc"].ToString();
                Dt.Rows.Add();
                Dt.Rows[1][0] = "1";
                Dt.Rows[1][1] = Dt2.DefaultView[0]["ActiveStateDesc"].ToString();
                Pers.FillCmb(Dt, Cmb_SelectStatus, "id", "value");
            }
            catch
            {

            }


        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (RdBtn_Parameter.Checked)
                {
                    TSQL = @"  (SELECT        " + Cmb_SelectOperation.Text + @"(dbo.Tb_Client.Duration) AS Duration
                            FROM            dbo.Tb_Client INNER JOIN
                                                     dbo.Tb_DevicesLine ON dbo.Tb_Client.DeviceLineId = dbo.Tb_DevicesLine.LineId AND dbo.Tb_Client.DeviceID = dbo.Tb_DevicesLine.DeviceId
                           where         (dbo.Tb_Client.DeviceID = " + Cmb_SelectDevice.SelectedValue + @") AND (dbo.Tb_Client.StateId = " + Cmb_SelectStatus.SelectedValue + @") AND (dbo.Tb_DevicesLine.ID = " + Cmb_SelectPuls.SelectedValue + @")  AND (dbo.Tb_Client.MiladiStartDateTime >= CAST('01/01/2015 00:00:00' AS datetime)) AND (dbo.Tb_Client.MiladiFinishDateTime <= CAST('01/01/2016 00:00:00' AS datetime)))";
                }
                else
                {
                    TSQL = "(SELECT        " + Txt_Number.Value + " AS x)";
                }
                    Bll_Public.GetDataTableFromTSQL(TSQL);


                Btn_Save.DialogResult = DialogResult.OK;
                ((Form)this.TopLevelControl).Tag = TSQL;
                    ((Form)this.TopLevelControl).Close();
            }
            catch(Exception E)
            {
                var dialogTypeName = "System.Windows.Forms.PropertyGridInternal.GridErrorDlg";
                var dialogType = typeof(Form).Assembly.GetType(dialogTypeName);

                // Create dialog instance.
                var dialog = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());

                // Populate relevant properties on the dialog instance.
                dialog.Text = Properties.Settings.Default.AppName;
                dialogType.GetProperty("Details").SetValue(dialog, E.Message , null);
                dialogType.GetProperty("Message").SetValue(dialog, "رشته دستوری ایجاد شده دارای خطا می باشد", null);

                // Display dialog.
                var result = dialog.ShowDialog();
            }
        }

        private void RdBtn_Number_CheckedChanged(object sender, EventArgs e)
        {

            Txt_Number.Visible = RdBtn_Number.Checked;
        }

        private void RdBtn_Parameter_CheckedChanged(object sender, EventArgs e)
        {
            Pnl_Database.Visible = RdBtn_Parameter.Checked;
        }
    }
  
}
