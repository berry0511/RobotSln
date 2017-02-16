namespace RobotProj
{
    partial class CodeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeWindow));
            this.CodeEditor = new ICSharpCode.TextEditor.TextEditorControl();
            this.SuspendLayout();
            // 
            // CodeEditor
            // 
            this.CodeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeEditor.Enabled = false;
            this.CodeEditor.Encoding = ((System.Text.Encoding)(resources.GetObject("CodeEditor.Encoding")));
            this.CodeEditor.IsIconBarVisible = false;
            this.CodeEditor.Location = new System.Drawing.Point(0, 0);
            this.CodeEditor.Name = "CodeEditor";
            this.CodeEditor.ShowEOLMarkers = true;
            this.CodeEditor.ShowSpaces = true;
            this.CodeEditor.ShowTabs = true;
            this.CodeEditor.ShowVRuler = true;
            this.CodeEditor.Size = new System.Drawing.Size(284, 261);
            this.CodeEditor.TabIndex = 0;
            // 
            // CodeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.ControlBox = false;
            this.Controls.Add(this.CodeEditor);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "CodeWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl CodeEditor;
    }
}