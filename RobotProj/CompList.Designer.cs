namespace RobotProj
{
    partial class CompList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Energe", 15, 15);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Light", 22, 22);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("执行控件", 3, 3, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("If", 45, 45);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("传感器控件", 3, 3, new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompList));
            this.CompTree = new System.Windows.Forms.TreeView();
            this.CompImage = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // CompTree
            // 
            this.CompTree.AllowDrop = true;
            this.CompTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompTree.ImageIndex = 4;
            this.CompTree.ImageList = this.CompImage;
            this.CompTree.Location = new System.Drawing.Point(0, 0);
            this.CompTree.Name = "CompTree";
            treeNode1.ImageIndex = 15;
            treeNode1.Name = "Energe";
            treeNode1.SelectedImageIndex = 15;
            treeNode1.Text = "Energe";
            treeNode2.ImageIndex = 22;
            treeNode2.Name = "Light";
            treeNode2.SelectedImageIndex = 22;
            treeNode2.Text = "Light";
            treeNode3.ImageIndex = 3;
            treeNode3.Name = "Dev";
            treeNode3.SelectedImageIndex = 3;
            treeNode3.Text = "执行控件";
            treeNode4.ImageIndex = 45;
            treeNode4.Name = "If";
            treeNode4.SelectedImageIndex = 45;
            treeNode4.Text = "If";
            treeNode5.ImageIndex = 3;
            treeNode5.Name = "Condition";
            treeNode5.SelectedImageIndex = 3;
            treeNode5.Text = "传感器控件";
            this.CompTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5});
            this.CompTree.SelectedImageIndex = 0;
            this.CompTree.Size = new System.Drawing.Size(378, 467);
            this.CompTree.TabIndex = 0;
            this.CompTree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.CompTree_ItemDrag);
            this.CompTree.DragEnter += new System.Windows.Forms.DragEventHandler(this.CompTree_DragEnter);
            // 
            // CompImage
            // 
            this.CompImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("CompImage.ImageStream")));
            this.CompImage.TransparentColor = System.Drawing.Color.Transparent;
            this.CompImage.Images.SetKeyName(0, "In.png");
            this.CompImage.Images.SetKeyName(1, "Out.png");
            this.CompImage.Images.SetKeyName(2, "Usual.png");
            this.CompImage.Images.SetKeyName(3, "CustomSensor.png");
            this.CompImage.Images.SetKeyName(4, "GraySensor.png");
            this.CompImage.Images.SetKeyName(5, "InfraredSensor.png");
            this.CompImage.Images.SetKeyName(6, "TemperatureSensor.png");
            this.CompImage.Images.SetKeyName(7, "Beep1.png");
            this.CompImage.Images.SetKeyName(8, "Beep2.png");
            this.CompImage.Images.SetKeyName(9, "break1.png");
            this.CompImage.Images.SetKeyName(10, "break2.png");
            this.CompImage.Images.SetKeyName(11, "Calculate1.png");
            this.CompImage.Images.SetKeyName(12, "Calculate2.png");
            this.CompImage.Images.SetKeyName(13, "Continue1.png");
            this.CompImage.Images.SetKeyName(14, "Continue2.png");
            this.CompImage.Images.SetKeyName(15, "DCMotor1.png");
            this.CompImage.Images.SetKeyName(16, "DCMotor2.png");
            this.CompImage.Images.SetKeyName(17, "Delay1.png");
            this.CompImage.Images.SetKeyName(18, "Delay2.png");
            this.CompImage.Images.SetKeyName(19, "ExecuteRoot.jpg");
            this.CompImage.Images.SetKeyName(20, "LCD1.png");
            this.CompImage.Images.SetKeyName(21, "LCD2.png");
            this.CompImage.Images.SetKeyName(22, "Light1.png");
            this.CompImage.Images.SetKeyName(23, "Light2.png");
            this.CompImage.Images.SetKeyName(24, "ReadIO1.png");
            this.CompImage.Images.SetKeyName(25, "ReadIO2.png");
            this.CompImage.Images.SetKeyName(26, "SCIRev1.png");
            this.CompImage.Images.SetKeyName(27, "SCIRev2.png");
            this.CompImage.Images.SetKeyName(28, "SCISend1.png");
            this.CompImage.Images.SetKeyName(29, "SCISend2.png");
            this.CompImage.Images.SetKeyName(30, "SMotor1.png");
            this.CompImage.Images.SetKeyName(31, "SMotor2.png");
            this.CompImage.Images.SetKeyName(32, "Start1.png");
            this.CompImage.Images.SetKeyName(33, "Start2.png");
            this.CompImage.Images.SetKeyName(34, "SubFun1.png");
            this.CompImage.Images.SetKeyName(35, "SubFun2.png");
            this.CompImage.Images.SetKeyName(36, "timer1.png");
            this.CompImage.Images.SetKeyName(37, "timer2.png");
            this.CompImage.Images.SetKeyName(38, "WriteIO1.png");
            this.CompImage.Images.SetKeyName(39, "WriteIO2.png");
            this.CompImage.Images.SetKeyName(40, "End1.png");
            this.CompImage.Images.SetKeyName(41, "End2.png");
            this.CompImage.Images.SetKeyName(42, "FlowRoot.jpg");
            this.CompImage.Images.SetKeyName(43, "For1.png");
            this.CompImage.Images.SetKeyName(44, "For2.png");
            this.CompImage.Images.SetKeyName(45, "If1.png");
            this.CompImage.Images.SetKeyName(46, "If2.png");
            this.CompImage.Images.SetKeyName(47, "Switch1.png");
            this.CompImage.Images.SetKeyName(48, "Switch2.png");
            this.CompImage.Images.SetKeyName(49, "SwitchEnd1.png");
            this.CompImage.Images.SetKeyName(50, "SwitchEnd2.png");
            this.CompImage.Images.SetKeyName(51, "While1.png");
            this.CompImage.Images.SetKeyName(52, "While2.png");
            this.CompImage.Images.SetKeyName(53, "CompassSensor1.png");
            this.CompImage.Images.SetKeyName(54, "CompassSensor2.png");
            this.CompImage.Images.SetKeyName(55, "CustomSensor1.png");
            this.CompImage.Images.SetKeyName(56, "CustomSensor2.png");
            this.CompImage.Images.SetKeyName(57, "GraySensor1.png");
            this.CompImage.Images.SetKeyName(58, "GraySensor2.png");
            this.CompImage.Images.SetKeyName(59, "InfraredSensor1.png");
            this.CompImage.Images.SetKeyName(60, "InfraredSensor2.png");

            // 
            // CompList
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(378, 467);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.ControlBox = false;
            this.Controls.Add(this.CompTree);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop)
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)
            | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "CompList";
            this.Load += new System.EventHandler(this.CompList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView CompTree;
        private System.Windows.Forms.ImageList CompImage;
    }
}