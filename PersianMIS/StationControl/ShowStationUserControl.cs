using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PersianMIS.Public_Class;
using System.Globalization;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.UI.Localization;

namespace PersianMIS.StationControl
{
    public partial class ShowStationUserControl : UserControl
    {
        string SelectedStation = "0";
        Font HeaderFont = new Font("b titr", 10f, FontStyle.Bold);
        public Boolean IsFirstLoad = false;
        IraniDate.IraniDate.IraniDate IrDate = new IraniDate.IraniDate.IraniDate();
        Persistent.DataAccess.DataAccess pers = new Persistent.DataAccess.DataAccess();
        DateTime CurDate = DateTime.Now;
        string startdate, enddate;
        PersianCulture persianCulture = new PersianCulture();
        BLL.Cls_Station Bll_Stations = new BLL.Cls_Station();

        public ShowStationUserControl()
        {
            InitializeComponent();
        }


        private void FillLstStation()
        {
            LSTStations.DataSource = Bll_Stations.GetStations();
            LSTStations.DisplayMember = "StationName";
            LSTStations.ValueMember = "StationId";
        }


        private void FillData( string ListOfStations)
        {
            MainPnl.Controls.Clear();


            foreach (var x in LSTStations.CheckedItems)
            {
                StationControl.StationUserControl UcShowStation = new StationUserControl();
                UcShowStation.Tag = x.Value.ToString();
                UcShowStation.TitleBar.Text = x.Text;
                MskStartDate.Culture=    new CultureInfo("en-GB");
                UcShowStation.StartDate =(DateTime) MskStartDate.Value;
                MskStartDate.Culture = new CultureInfo("fa-IR");

                MskEndDate.Culture = new CultureInfo("en-GB");
                UcShowStation.EndDate = (DateTime)MskEndDate.Value;
                MskEndDate.Culture = new CultureInfo("fa-IR");
             
                MainPnl.Controls.Add(UcShowStation);

            }
            MskEndDate.Culture = persianCulture;
            MskStartDate.Culture = persianCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;




        }




        private void radButtonElementWeek_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            MskStartDate.Value = CurDate.AddDays(-7);
            MskEndDate.Value = CurDate;
        //    String CurrentDate = CurDate.ToString("yyyy/mm/dd HH:mm:ss", new CultureInfo("en-US"));
            FillData(   SelectedStation);
            this.Cursor = Cursors.Default;
        }

        private void Btn_Month_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            MskStartDate.Value = CurDate.AddDays(-30);
            MskEndDate.Value = CurDate;
         //   String CurrentDate = CurDate.ToString("yyyy/mm/dd HH:mm:ss", new CultureInfo("en-US"));
            FillData(  SelectedStation);
            this.Cursor = Cursors.Default;
        }

        private void Btn_Year_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            MskStartDate.Value = CurDate.AddDays(-365);
            MskEndDate.Value = CurDate;
      //      String CurrentDate = CurDate.ToString("yyyy/mm/dd HH:mm:ss", new CultureInfo("en-US"));
            FillData(    "");
            this.Cursor = Cursors.Default;
        }



        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printablePanel.PrintPreview();
        }



  

 

        private void radDateTimePickerElementEnd_Click(object sender, EventArgs e)
        {
            IsFirstLoad = false;
        }

        private void radDateTimePickerElementStart_Click(object sender, EventArgs e)
        {
            IsFirstLoad = false;
        }



        private void ShowStationUserControl_Load(object sender, EventArgs e)
        {


            enddate = CurDate.ToString("yyyy/mm/dd HH:mm:ss", new CultureInfo("en-US"));
            MskStartDate.Value = CurDate.AddDays(-1);
            MskEndDate.Value = CurDate;

            String CurrentDate = CurDate.ToString("yyyy/mm/dd HH:mm:ss", new CultureInfo("en-US"));
            startdate = CurDate.AddDays(-1).ToString("yyyy/mm/dd HH:mm:ss", new CultureInfo("en-US"));
            enddate = CurrentDate;
            FillLstStation();



            System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;



        }

        private void radDateTimePickerElementEnd_ValueChanged(object sender, ValueChangingEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;

        }

        private void LSTStations_ItemCheckedChanged(object sender, ListViewItemEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SelectedStation = "0";

            foreach (var CheckedItem in LSTStations.CheckedItems)
            {
                SelectedStation = SelectedStation + "," + CheckedItem.Value.ToString() + "";

            }
            SelectedStation = "'" + SelectedStation + "'";
            FillData(  SelectedStation);
            this.Cursor = Cursors.Default;

        }

        private void Btn_Week_Click(object sender, EventArgs e)
        {
        
            this.Cursor = Cursors.WaitCursor;
            MskStartDate.Value = CurDate.AddDays(-7);
            MskEndDate.Value = CurDate;
            //String CurrentDate = CurDate.ToString("yyyy/MM/dd", new CultureInfo("en-US"));
           FillData(  SelectedStation);
            this.Cursor = Cursors.Default;
      
    }
 

        private void radDateTimePickerElementStart_ValueChanged(object sender, ValueChangingEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;

        }


    }
}




