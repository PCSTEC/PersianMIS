using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersianMIS.StationControl
{
    public partial class CreatePulsParameterUserControl : UserControl
    {
        private CreateNewParameterFromulaWithReturnTSQLUserControl Uc = new CreateNewParameterFromulaWithReturnTSQLUserControl();
        BLL.Cls_PublicOperations Bll_Public = new BLL.Cls_PublicOperations();
        BLL.Cls_Station Bll_Station = new BLL.Cls_Station();
        private Boolean ISEditdatable = false;
        string parameterid;
        public CreatePulsParameterUserControl(Boolean IsEdit)
        {
            InitializeComponent();
            ISEditdatable = IsEdit;

        }



        private int parameterStationId;
        public int ParameterStationId
        {
            get { return parameterStationId; }
            set { parameterStationId = value; }
        }

        private int stationId;
        public int StationId
        {
            get { return stationId; }
            set { stationId = value; }
        }



        public Label ParameterID
        {
            get { return lbl_PulsNumber; }


        }

        public Telerik.WinControls.UI.RadTextBox TxtParameterCaptions
        {
            get { return Txt_ParamteterCaption; }


        }

        public Telerik.WinControls.UI.RadButton Btn_CreateTSQl
        {
            get
            {
                return Btn_CreateTSQL;
            }
        }

        private Panel NewStepPanel(String ID)
        {

            DevComponents.Editors.ComboItem comboItem1 = new DevComponents.Editors.ComboItem();
            DevComponents.Editors.ComboItem comboItem2 = new DevComponents.Editors.ComboItem();
            DevComponents.Editors.ComboItem comboItem3 = new DevComponents.Editors.ComboItem();
            DevComponents.Editors.ComboItem comboItem4 = new DevComponents.Editors.ComboItem();
            DevComponents.Editors.ComboItem comboItem5 = new DevComponents.Editors.ComboItem();


            Panel newPnl = new Panel();
            //  newPnl.Width = 438;
            //  newPnl.Height = 200;

            PictureBox Btn_Steps = new PictureBox();
            Btn_Steps.BackColor = System.Drawing.Color.Transparent;
            Btn_Steps.Image = global::PersianMIS.Properties.Resources.Step0;
            Btn_Steps.Cursor = Cursors.Hand;
            Btn_Steps.Location = new System.Drawing.Point(4, 3);
            Btn_Steps.Name = ID;

            Btn_Steps.Size = new System.Drawing.Size(431, 80);
            Btn_Steps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            Btn_Steps.Click += new System.EventHandler(this.ShowSetParameterForm);


            DevComponents.DotNetBar.Controls.ComboBoxEx Cmb_SelectOperations = new DevComponents.DotNetBar.Controls.ComboBoxEx();

            if (Convert.ToInt32(ID) != (int)Txt_ParameterCount.Value)
            {
                Cmb_SelectOperations.DisplayMember = "Text";
                Cmb_SelectOperations.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
                Cmb_SelectOperations.FormattingEnabled = true;
                Cmb_SelectOperations.ItemHeight = 22;
                Cmb_SelectOperations.Font = new System.Drawing.Font("B zar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));

                Cmb_SelectOperations.Items.AddRange(new object[] {
        comboItem1,
            comboItem2,
           comboItem3,
            comboItem4
    });
                Cmb_SelectOperations.Location = new System.Drawing.Point(138, 95);
                //     Cmb_SelectOperations.Top = Btn_Steps.Top + Btn_Steps.Height;

                Cmb_SelectOperations.Name = "Cmb_SelectOperation" + ID;
                Cmb_SelectOperations.Size = new System.Drawing.Size(159, 28);
                Cmb_SelectOperations.TabIndex = 45;
                Cmb_SelectOperations.Text = "عملیات را انتخاب کنید";
                // 
                // comboItem1
                // 
                comboItem1.Text = "*";
                // 
                // comboItem2
                // 
                comboItem2.Text = "/";
                // 
                // comboItem3
                // 
                comboItem3.Text = "+";
                // 
                // comboItem4
                // 
                comboItem4.Text = "-";
                // 
                newPnl.Controls.Add(Cmb_SelectOperations);

            }


            Label Lbl_ParameterNumbers = new Label();
            Lbl_ParameterNumbers.AutoSize = true;
            Lbl_ParameterNumbers.BackColor = System.Drawing.Color.White;
            Lbl_ParameterNumbers.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            Lbl_ParameterNumbers.Location = new System.Drawing.Point(41, 22);
            Lbl_ParameterNumbers.Name = "Lbl_ParameterNumber" + ID;
            Lbl_ParameterNumbers.Tag = ID;
            Lbl_ParameterNumbers.Size = new System.Drawing.Size(28, 43);
            Lbl_ParameterNumbers.TabIndex = 3;
            Lbl_ParameterNumbers.Text = ID;


            newPnl.Controls.Add(Lbl_ParameterNumbers);
            newPnl.Controls.Add(Btn_Steps);


            newPnl.Location = new System.Drawing.Point(459, 78);
            newPnl.Name = "Pnl_Step" + ID;
            newPnl.Tag = ID;
            newPnl.Size = new System.Drawing.Size(438, 125);
            newPnl.TabIndex = 3;






            return newPnl;
        }


        private void ShowSetParameterForm(object sender, EventArgs e)
        {

            PictureBox SelectedValue = (PictureBox)sender;


            if (SelectedValue.Name != null)
            {
                Telerik.WinControls.UI.RadForm frm = new Telerik.WinControls.UI.RadForm();
                frm.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                frm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                frm.ClientSize = new System.Drawing.Size(302, 270);

                frm.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
                frm.MaximizeBox = false;
                frm.Name = "Frm_CreateStation";
                frm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;


                frm.Text = "ایجاد پارامتر همراه با فرمول";
                var panel = new DevComponents.DotNetBar.Controls.GroupPanel();
                panel.Dock = DockStyle.Fill;

                Uc.Location = new System.Drawing.Point(4, 3);
                Uc.Name = "UC_CreateParameterFormula";

                Uc.Size = new System.Drawing.Size(431, 80);

                Uc.Dock = DockStyle.Fill;


                frm.StartPosition = FormStartPosition.CenterScreen;

                frm.Controls.Add(Uc);
                frm.ShowDialog();
                if (frm.Tag != null)
                {



                    SelectedValue.Image = global::PersianMIS.Properties.Resources.Step;
                    SelectedValue.Tag = frm.Tag;
                }
            }

            //DevComponents.DotNetBar.BubbleButton SelectedValue = (DevComponents.DotNetBar.BubbleButton)sender;
            //foreach (Control item in Pnl_Main.Controls)
            //{
            //    if (item.Tag.ToString() == SelectedValue.Tag.ToString())
            //    {
            //        Pnl_Main.Controls.Remove(item);
            //        break; //important step
            //    }
            //}


        }


        private void Btn_ShowStation_Click(object sender, EventArgs e)
        {
            MainPnl.Controls.Clear();
            for (int i = 0; i < Txt_ParameterCount.Value; i++)
            {




                MainPnl.Controls.Add(NewStepPanel(Convert.ToString(i + 1)));


            }
        }

        private void Pnl_Step_Paint(object sender, PaintEventArgs e)
        {

        }



        private string GenerateTSQL()
        {

            string EndTSQL = "(select  ";


            foreach (Control x in MainPnl.Controls.OfType<Panel>())
            {
                foreach (Control y in x.Controls.OfType<PictureBox>())
                {
                    if (y.Tag != null)
                    {
                        EndTSQL += y.Tag;
                    }
                    else
                    {
                        EndTSQL += " as Value)  ";
                        return EndTSQL;
                    }
                }

                foreach (Control z in x.Controls.OfType<ComboBox>())
                {
                    if (z.Text.Length <= 1)
                    {
                        EndTSQL += z.Text;
                    }
                }
            }
            EndTSQL += " as Value)  ";
            return EndTSQL;
        }

        private void Btn_CreateTSQL_Click(object sender, EventArgs e)
        {

            if (ISEditdatable)
            {
                if (MessageBox.Show("آیا از ویرایش کد ایجاد شده مطمن هستید؟", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            try
            {
                if (Txt_ParamteterCaption.Text == "")
                {
                    MessageBox.Show("لطفاعنوان پارامتر را وارد نمایید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string TSQL = GenerateTSQL();
                Bll_Public.GetDataTableFromTSQL(TSQL);
                ParameterID.Tag = TSQL;
                if (ISEditdatable)
                {


                    Bll_Station.UpdateStationParameters(Txt_ParamteterCaption.Text, TSQL, parameterStationId);

                } else
                {
                    if (parameterStationId < 1)
                    {
                        Bll_Station.InsertStationParameters(Txt_ParamteterCaption.Text, TSQL, stationId);
                    } }
                 
                    MessageBox.Show("عملیات با موفقیت انجام گردید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception E)
            {
                var dialogTypeName = "System.Windows.Forms.PropertyGridInternal.GridErrorDlg";
                var dialogType = typeof(Form).Assembly.GetType(dialogTypeName);


                var dialog = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());

                dialog.Text = Properties.Settings.Default.AppName;
                dialogType.GetProperty("Details").SetValue(dialog, E.Message, null);
                dialogType.GetProperty("Message").SetValue(dialog, "رشته دستوری ایجاد شده دارای خطا می باشد", null);

                var result = dialog.ShowDialog();
            }

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف پارامتر ایجاد شده مطمن هستید؟", Properties.Settings.Default.AppName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bll_Public.DeleteRecord("SP_DeleteStationParameters", "StationParameterId", parameterStationId.ToString());
                MessageBox.Show("عملیات با موفقیت انجام گردید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
