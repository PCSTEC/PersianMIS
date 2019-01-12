using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.PictureBox Img;
        private System.Windows.Forms.Button Btn_OpenImg;
        private Telerik.WinControls.UI.RadTextBox Txt_ImagePath;
        private System.Windows.Forms.Label Lbl_imagePath;
        public Frm_MainProcess()
        {
            InitializeComponent();
            DiagramRibbonBarLocalizationProvider.CurrentProvider = new PersianDiagramRibbonBarLocalizationProvider();

         


            //foreach (var Item in Rd_Toolbars.Items.ToList())
            //{
            //    Item.Key = "";
            //}
            //        this.Rd_Toolbars.ListViewElement.DragDropService.PreviewDragDrop
            //    += DragDropService_PreviewDragDrop;

            //        this.Rd_Toolbars.VisualItemFormatting += radDiagramToolbox1_VisualItemFormatting;
            //        DiagramListViewDataItem item = new DiagramListViewDataItem();
            //        item.Key = "Image";
            //        item.Text = "";


            //// item.Shape = new AShape();
            //        item.Group = Rd_Toolbars.Groups[0];
            //        this.Rd_Toolbars.Items.Add(item);



            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.Img = new System.Windows.Forms.PictureBox();
            this.Btn_OpenImg = new System.Windows.Forms.Button();
            this.Txt_ImagePath = new Telerik.WinControls.UI.RadTextBox();
            this.Lbl_imagePath = new System.Windows.Forms.Label();

            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.Img);
            this.radPanel1.Controls.Add(this.Btn_OpenImg);
            this.radPanel1.Controls.Add(this.Txt_ImagePath);
            this.radPanel1.Controls.Add(this.Lbl_imagePath);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(258, 197);
            this.radPanel1.TabIndex = 1;
            // 
            // Img
            // 
            this.Img.Location = new System.Drawing.Point(8, 33);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(250, 190);
            this.Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img.TabIndex = 3;
            this.Img.TabStop = false;
            // 
            // Btn_OpenImg
            // 
            this.Btn_OpenImg.Location = new System.Drawing.Point(213, 7);
            this.Btn_OpenImg.Name = "Btn_OpenImg";
            this.Btn_OpenImg.Size = new System.Drawing.Size(38, 20);
            this.Btn_OpenImg.TabIndex = 2;
            this.Btn_OpenImg.Text = "...";
            this.Btn_OpenImg.UseVisualStyleBackColor = true;
            this.Btn_OpenImg.Click += new System.EventHandler(this.Btn_OpenImg_Click);
            // 
            // Txt_ImagePath
            // 
            this.Txt_ImagePath.Enabled = false;
            this.Txt_ImagePath.Location = new System.Drawing.Point(70, 7);
            this.Txt_ImagePath.Name = "Txt_ImagePath";
            this.Txt_ImagePath.Size = new System.Drawing.Size(143, 20);
            this.Txt_ImagePath.TabIndex = 1;
            // 
            // Lbl_imagePath
            // 
            this.Lbl_imagePath.AutoSize = true;
            this.Lbl_imagePath.Location = new System.Drawing.Point(3, 9);
            this.Lbl_imagePath.Name = "Lbl_imagePath";
            this.Lbl_imagePath.Size = new System.Drawing.Size(70, 13);
            this.Lbl_imagePath.TabIndex = 0;
            this.Lbl_imagePath.Text = "Image Path :";

            RadPageViewPage toolsPage = new RadPageViewPage();
            toolsPage.Text = "image";
            toolsPage.Controls.Add(radPanel1);

            this.RdMainDiagram.DiagramElement.SettingsPane.RadPageView.Pages.Add(toolsPage);

        }

        private void Btn_OpenImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Img.Image = new Bitmap(dlg.FileName);
                    Txt_ImagePath.Text = dlg.FileName;
                    (this.RdMainDiagram.SelectedItem as RadDiagramShape).DiagramShapeElement.Image = Img.Image;
                    (this.RdMainDiagram.SelectedItem as RadDiagramShape).DiagramShapeElement.ImageLayout = ImageLayout.Stretch;
                }
            }



        }

        private void DragDropService_PreviewDragDrop(object sender, RadDropEventArgs e)
        {
            DiagramListViewVisualItem dragItem = e.DragInstance as DiagramListViewVisualItem;
            RadDiagramElement dropTarget = e.HitTarget as RadDiagramElement;
            if (dragItem != null && dropTarget != null && dragItem.Data.Key == "Image")
            {
                e.Handled = true;

                RadDiagramShape shape = dropTarget.Shapes.Last() as RadDiagramShape;
                shape.DiagramShapeElement.Shape = null;
                shape.BackColor = Color.Transparent;


                try
                {
                    OpenFileDialog open = new OpenFileDialog();
                    open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        Bitmap bit = new Bitmap(open.FileName);
                        shape.DiagramShapeElement.Image = bit;
                    }
                }
                catch (Exception)
                {
                    throw new ApplicationException("Failed loading image");
                }


                shape.DiagramShapeElement.ImageLayout = dragItem.ImageLayout;

            };
        }

        //public class AShape : ElementShape
        //{
        //    //public override GraphicsPath CreatePath(Rectangle bounds)
        //    //{
        //    //    GraphicsPath path = new GraphicsPath();
        //    //    path.AddString("PcsTec", new FontFamily("Arial"), 0, 50, Point.Empty, StringFormat.GenericTypographic);
        //    //    return path;
        //    //}
        //}

        private void radDiagramToolbox1_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            DiagramListViewDataItem dataItem = e.VisualItem.Data as DiagramListViewDataItem;
            if (dataItem != null)
            {
                if (dataItem.Key == "Image")
                {
                    DiagramListViewVisualItem visual = e.VisualItem as DiagramListViewVisualItem;
                    visual.Image = Properties.Resources.background_ok;
                    visual.ImageLayout = ImageLayout.Zoom;
                    visual.ShapeElement.Opacity = 0;



                }
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
                    Telerik.WinControls.UI.RadDiagramShape SelectedObject = (Telerik.WinControls.UI.RadDiagramShape)SelectedItem.SelectedItem;

                    Form Frm = new Frm_ManageSubProcessItems();
                    Frm.Text = SelectedObject.Tag.ToString();
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

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            foreach (RadDiagramShape Shape in RdMainDiagram.Shapes)
            {
                (Shape as RadDiagramShape).DiagramShapeElement.ImageLayout = ImageLayout.Stretch;

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