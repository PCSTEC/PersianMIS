using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PersianMIS.Process
{
    public partial class Frm_MainProcess : Telerik.WinControls.UI.RadForm
    {
        public Frm_MainProcess()
        {
            InitializeComponent();
            DataTable tasksTable = new DataTable("Tasks");
            tasksTable.Columns.Add("Id");
            tasksTable.Columns.Add("Text");
            tasksTable.Columns.Add("Type");
            tasksTable.Columns.Add("X");
            tasksTable.Columns.Add("Y");
            tasksTable.Columns.Add("Width");
            tasksTable.Columns.Add("Height");
            tasksTable.Rows.Add("Task1", "Task 1", "circle", 100, 300, 50, 50);
            tasksTable.Rows.Add("Task2", "Task 2", "rectangle", 200, 100, 100, 100);
            tasksTable.Rows.Add("Task3", "Task 3", "circle", 300, 300, 50, 50);
            tasksTable.Rows.Add("Task4", "Task 4", "rectangle", 400, 100, 100, 100);
            tasksTable.Rows.Add("Task5", "Task 5", "circle", 500, 300, 50, 50);

            DataTable relationsTable = new DataTable("Relations");
            relationsTable.Columns.Add("SourceTaskId");
            relationsTable.Columns.Add("SourceConnector");
            relationsTable.Columns.Add("TargetTaskId");
            relationsTable.Columns.Add("TargetConnector");
            relationsTable.Columns.Add("StartCapField");
            relationsTable.Columns.Add("EndCapField");
            relationsTable.Rows.Add("Task2", "Left", "Task1", "Auto", "Arrow5Filled", "Arrow1");
            relationsTable.Rows.Add("Task2", "Auto", "Task3", "Auto", "Arrow4Filled", "Arrow1Filled");
            relationsTable.Rows.Add("Task4", "Auto", "Task5", "Auto", "Arrow2Filled", "Arrow2");

            DataSet ds = new DataSet();
            ds.Tables.Add(tasksTable);
            ds.Tables.Add(relationsTable);

            this.RdMainDiagram.DataSource = ds;

            this.RdMainDiagram.ConnectionDataMember = "Relations";
            this.RdMainDiagram.ShapeDataMember = "Tasks";
            this.RdMainDiagram.ShapeIdMember = "Id";
            this.RdMainDiagram.ShapeTextMember = "Text";
            this.RdMainDiagram.ShapeTypeMember = "Type";
            this.RdMainDiagram.ShapeXMember = "X";
            this.RdMainDiagram.ShapeYMember = "Y";
            this.RdMainDiagram.ShapeWidthMember = "Width";
            this.RdMainDiagram.ShapeHeightMember = "Height";

            this.RdMainDiagram.ConnectionSourceShapeIdMember = "SourceTaskId";
            this.RdMainDiagram.ConnectionTargetShapeIdMember = "TargetTaskId";
            this.RdMainDiagram.ConnectionSourceCapTypeMember = "StartCapField";
            this.RdMainDiagram.ConnectionTargetCapTypeMember = "EndCapField";

            this.RdMainDiagram.ConnectionSourceConnectorMember = "SourceConnector";
            this.RdMainDiagram.ConnectionTargetConnectorMember = "TargetConnector";



            RdMainDiagram.DiagramElement.SettingsPane.RadPageView.Pages.Remove(this.RdMainDiagram.DiagramElement.SettingsPane.RadPageViewPageHome);
            RadPageViewPage toolsPage = new RadPageViewPage();
            toolsPage.Text = "تست";
            this.RdMainDiagram.DiagramElement.SettingsPane.RadPageView.Pages.Add(toolsPage);
            Label x = new Label() ;
            x.Text = "کد";
            TextBox n = new TextBox();
            n.Name = "txttest";
            n.Width = 100;
            n.Height = 80;

           
            this.RdMainDiagram.DiagramElement.SettingsPane.RadPageView.Pages[0].Controls.Add(n);

        }
    }
}
