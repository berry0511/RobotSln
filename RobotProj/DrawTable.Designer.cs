namespace RobotProj
{
    partial class DrawTable
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
            this.SuspendLayout();
            // 
            // DrawTable
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(457, 382);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.ControlBox = false;
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "DrawTable";
            this.ShowIcon = false;
            this.Text = "Table";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DrawTable_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DrawTable_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawTable_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawTable_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}