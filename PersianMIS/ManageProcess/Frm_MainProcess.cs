using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PersianMIS.ManageProcess;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace PersianMIS.Process
{
    public partial class Frm_MainProcess : Telerik.WinControls.UI.RadForm
    {
        int MaxTag = 0;
        public Frm_MainProcess()
        {
            InitializeComponent();
            DiagramRibbonBarLocalizationProvider.CurrentProvider = new PersianDiagramRibbonBarLocalizationProvider();


            foreach (var Item in Rd_Toolbars.Items.ToList())
            {
                Item.Key = "";
            }

            
        }



        private void SampleFillData()
        {

            //DataTable tasksTable = new DataTable("Tasks");
            //tasksTable.Columns.Add("Id");
            //tasksTable.Columns.Add("Text");
            //tasksTable.Columns.Add("Type");
            //tasksTable.Columns.Add("X");
            //tasksTable.Columns.Add("Y");
            //tasksTable.Columns.Add("Width");
            //tasksTable.Columns.Add("Height");
            //tasksTable.Rows.Add("Task1", "Task 1", "circle", 100, 300, 50, 50);
            //tasksTable.Rows.Add("Task2", "Task 2", "rectangle", 200, 100, 100, 100);
            //tasksTable.Rows.Add("Task3", "Task 3", "circle", 300, 300, 50, 50);
            //tasksTable.Rows.Add("Task4", "Task 4", "rectangle", 400, 100, 100, 100);
            //tasksTable.Rows.Add("Task5", "Task 5", "circle", 500, 300, 50, 50);

            //DataTable relationsTable = new DataTable("Relations");
            //relationsTable.Columns.Add("SourceTaskId");
            //relationsTable.Columns.Add("SourceConnector");
            //relationsTable.Columns.Add("TargetTaskId");
            //relationsTable.Columns.Add("TargetConnector");
            //relationsTable.Columns.Add("StartCapField");
            //relationsTable.Columns.Add("EndCapField");
            //relationsTable.Rows.Add("Task2", "Left", "Task1", "Auto", "Arrow5Filled", "Arrow1");
            //relationsTable.Rows.Add("Task2", "Auto", "Task3", "Auto", "Arrow4Filled", "Arrow1Filled");
            //relationsTable.Rows.Add("Task4", "Auto", "Task5", "Auto", "Arrow2Filled", "Arrow2");

            //DataSet ds = new DataSet();
            //ds.Tables.Add(tasksTable);
            //ds.Tables.Add(relationsTable);

            //this.RdMainDiagram.DataSource = ds;

            //this.RdMainDiagram.ConnectionDataMember = "Relations";
            //this.RdMainDiagram.ShapeDataMember = "Tasks";
            //this.RdMainDiagram.ShapeIdMember = "Id";
            //this.RdMainDiagram.ShapeTextMember = "Text";
            //this.RdMainDiagram.ShapeTypeMember = "Type";
            //this.RdMainDiagram.ShapeXMember = "X";
            //this.RdMainDiagram.ShapeYMember = "Y";
            //this.RdMainDiagram.ShapeWidthMember = "Width";
            //this.RdMainDiagram.ShapeHeightMember = "Height";

            //this.RdMainDiagram.ConnectionSourceShapeIdMember = "SourceTaskId";
            //this.RdMainDiagram.ConnectionTargetShapeIdMember = "TargetTaskId";
            //this.RdMainDiagram.ConnectionSourceCapTypeMember = "StartCapField";
            //this.RdMainDiagram.ConnectionTargetCapTypeMember = "EndCapField";

            //this.RdMainDiagram.ConnectionSourceConnectorMember = "SourceConnector";
            //this.RdMainDiagram.ConnectionTargetConnectorMember = "TargetConnector";



            //RdMainDiagram.DiagramElement.SettingsPane.RadPageView.Pages.Remove(this.RdMainDiagram.DiagramElement.SettingsPane.RadPageViewPageHome);
            //RadPageViewPage toolsPage = new RadPageViewPage();
            //toolsPage.Text = "تست";
            //this.RdMainDiagram.DiagramElement.SettingsPane.RadPageView.Pages.Add(toolsPage);
            //Label x = new Label() ;
            //x.Text = "کد";
            //TextBox n = new TextBox();
            //n.Name = "txttest";
            //n.Width = 100;
            //n.Height = 80;


            //this.RdMainDiagram.DiagramElement.SettingsPane.RadPageView.Pages[0].Controls.Add(n);
        }

        private void Rd_Menu_Click(object sender, EventArgs e)
        {

        }


        public class X
        {

        }
        private void RdMainDiagram_DoubleClick(object sender, EventArgs e)
        {
            try
            {


                for (int i = 0; i <= RdMainDiagram.Items.Count - 1; i++)
                {
                    if (RdMainDiagram.Items[i].Tag == null)
                    {
                        RdMainDiagram.Items[i].Tag = ++MaxTag;
                        RdMainDiagram.Items[i].Name = "Obj" + MaxTag;
                    }

                }


                Telerik.WinControls.UI.RadDiagram SelectedItem = (Telerik.WinControls.UI.RadDiagram)sender;
                if (SelectedItem.Items.Count > 0)
                {

                    Telerik.WinControls.UI.RadDiagramShape X = (Telerik.WinControls.UI.RadDiagramShape)SelectedItem.Items[0];
                    Telerik.WinControls.UI.RadDiagramShape SelectedObject =(Telerik.WinControls.UI.RadDiagramShape)SelectedItem.SelectedItem ;

                    Form Frm = new Frm_ManageSubProcessItems();
                    Frm.Text = SelectedObject.Tag .ToString();
                    Frm.ShowDialog();
                        



                }


            }
            catch
            {

            }
        }







        private void RdMainDiagram_CommandExecuted(object sender, Telerik.Windows.Diagrams.Core.CommandEventArgs e)
        {

            //try
            //{
            //    foreach (var x in RdMainDiagram.Items)
            //    {
            //        if (x.Tag != null)
            //        {
            //            x.Tag = ++MaxTag;
            //        }

            //    }
            //}
            //catch
            //{

            //}

            //RadDiagramElement X = (RadDiagramElement)sender;
            //X.Tag = ++MaxTag;
            //X.Name = "test" + X;

        }

        private void RdMainDiagram_DiagramLayoutComplete(object sender, Telerik.Windows.Diagrams.Core.DiagramLayoutEventArgs e)
        {

        }

        private void Rd_Toolbars_ItemCreating(object sender, ListViewItemCreatingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RdMainDiagram_Click(object sender, EventArgs e)
        {
            try
            {
 Telerik.WinControls.UI.RadDiagram SelectedItem = (Telerik.WinControls.UI.RadDiagram)sender;
            if (SelectedItem.Items.Count > 0)
            {

                Telerik.WinControls.UI.RadDiagramShape X = (Telerik.WinControls.UI.RadDiagramShape)SelectedItem.Items[0];
                X.IsEditable = false;
            }
            }
            catch
            {

            }
           
        }
    }
}
class MyItemInformationAdorner : Telerik.WinControls.UI.Diagrams.Primitives.ItemInformationAdorner
{
    public MyItemInformationAdorner(RadDiagramElement diagram)
    {
        this.Diagram = diagram;
    }

    protected override void CreateChildElements()
    {
        base.CreateChildElements();
        RadButtonElement button = new RadButtonElement() { Text = "Click me!", AutoSize = true, TextAlignment = ContentAlignment.MiddleRight };
        this.InformationTipPanel.Children.First().Visibility = ElementVisibility.Collapsed;
        this.InformationTipPanel.Children.Add(button);
        button.ButtonFillElement.BackColor = System.Drawing.Color.Red;
        button.ButtonFillElement.GradientStyle = GradientStyles.Solid;
        button.Click += button_Click;
    }
    void button_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hello");
    }
}