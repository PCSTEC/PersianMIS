﻿using System;
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
        public CreatePulsParameterUserControl()
        {
            InitializeComponent();
        }


        public Label ParameterID
        {
            get { return lbl_PulsNumber; }


        }

      

        private Panel NewStepPanel(String ID)
        {
            DevComponents.Editors.ComboItem    comboItem1 = new DevComponents.Editors.ComboItem();
            DevComponents.Editors.ComboItem comboItem2 = new DevComponents.Editors.ComboItem();
            DevComponents.Editors.ComboItem comboItem3 = new DevComponents.Editors.ComboItem();
            DevComponents.Editors.ComboItem comboItem4 = new DevComponents.Editors.ComboItem();
            DevComponents.Editors.ComboItem comboItem5 = new DevComponents.Editors.ComboItem();


            Panel newPnl = new Panel();
          //  newPnl.Width = 438;
          //  newPnl.Height = 200;
           
            PictureBox Btn_Steps = new  PictureBox();
            Btn_Steps.BackColor = System.Drawing.Color.Transparent;
            Btn_Steps.Image = global::PersianMIS.Properties.Resources.Step0;
            Btn_Steps.Cursor = Cursors.Hand;
            Btn_Steps.Location = new System.Drawing.Point(4, 3);
            Btn_Steps.Name = "btn_Step" + ID;
            Btn_Steps.Tag = ID;
            Btn_Steps.Size = new System.Drawing.Size(431, 80);
            Btn_Steps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;


 

            DevComponents.DotNetBar.Controls.ComboBoxEx Cmb_SelectOperations = new DevComponents.DotNetBar.Controls.ComboBoxEx();
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

            Cmb_SelectOperations.Name = "Cmb_SelectOperation" + ID ;
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
           

            Label Lbl_ParameterNumbers = new Label();
            Lbl_ParameterNumbers.AutoSize = true;
             Lbl_ParameterNumbers.BackColor = System.Drawing.Color.White;
             Lbl_ParameterNumbers.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
             Lbl_ParameterNumbers.Location = new System.Drawing.Point(41, 22);
           Lbl_ParameterNumbers.Name = "Lbl_ParameterNumber"+ ID;
            Lbl_ParameterNumbers.Tag = ID;
            Lbl_ParameterNumbers.Size = new System.Drawing.Size(28, 43);
             Lbl_ParameterNumbers.TabIndex = 3;
             Lbl_ParameterNumbers.Text = ID ;

            newPnl.Controls.Add(Cmb_SelectOperations);

            newPnl.Controls.Add(Lbl_ParameterNumbers);
            newPnl.Controls.Add(Btn_Steps);
            

            newPnl.Location = new System.Drawing.Point(459, 78);
            newPnl.Name = "Pnl_Step" + ID;
            newPnl.Tag = ID;
            newPnl.Size = new System.Drawing.Size(438, 125);
            newPnl.TabIndex = 3;



 


            return newPnl;
        }

        private void Btn_ShowStation_Click(object sender, EventArgs e)
        {
            MainPnl.Controls.Clear();
            for (int i = 0; i < Txt_ParameterCount.Value; i++)
            {
                
               
                

                MainPnl.Controls.Add(NewStepPanel(Convert.ToString( i+1)));
                

            }
        }

        private void Pnl_Step_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}