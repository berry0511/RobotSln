using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotProj
{
    public partial class DrawTable : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public DrawTable()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            bDrawLine = false;
        }

        private void DrawTable_DragEnter(object sender, DragEventArgs e)
        {
            TreeNode myNode = null;
            myNode = (TreeNode)(e.Data.GetData(typeof(TreeNode)));
            if (e.Data.GetDataPresent(typeof(TreeNode)) && myNode.Parent != null)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void DrawTable_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode myNode = null;
            Point CurPoint = new Point();
            CurPoint.X = e.X;
            CurPoint.Y = e.Y;
            CurPoint = this.PointToClient(CurPoint);

            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                myNode = (TreeNode)(e.Data.GetData(typeof(TreeNode)));


                switch (myNode.Name)
                {
                    //case "Energe":
                    //    {
                    //        EzPic easyPic = new EzPic(ComponentType.COM_ENERGE, CurPoint);
                    //        this.Controls.Add(easyPic);
                    //        easyPic.Show();
                    //        break;
                    //    }
                    //case "Light":
                    //    {
                    //        EzPic easyPic = new EzPic(ComponentType.COM_LIGHT, CurPoint);
                    //        this.Controls.Add(easyPic);
                    //        easyPic.Show();
                    //        break;
                    //    }
                    case "If":
                        {
                            picBoxIf ifPic = new picBoxIf(CurPoint);
                            picBoxEnd endPic = new picBoxEnd(new Point(CurPoint.X + 100, CurPoint.Y));
                            this.Controls.Add(ifPic);
                            ifPic.BringToFront();
                            ifPic.Show();

                            this.Controls.Add(endPic);
                            endPic.BringToFront();
                            endPic.Show();
                            break;
                        }
                    default:
                        return;
                }
            }
        }

        public void initDrawPen(Point p, PictureBox box)
        {
            drawingLine = new Line(p);
            drawingLine.startBox = box;
            lines.Add(drawingLine);
            bDrawLine = true;
        }

        public void endDrawing(Point p, PictureBox box)
        {
            if (drawingLine == null) return;
            drawingLine.EndPoint = p;
            drawingLine.EndBox = box;
            drawingLine = null;
        }

        public void onPicturboxMove(Point p, PictureBox box)
        {
            foreach (Line l in lines)
            {
                if (l.startBox == box)
                {
                    l.StartPoint.X += p.X;
                    l.StartPoint.Y += p.Y;
                }

                if (l.EndBox == box)
                {
                    l.EndPoint.X += p.X;
                    l.EndPoint.Y += p.Y;
                }
            }
            this.Invalidate();
        }

        public void uponPicturBoxMove(Point p)
        {
            if (drawingLine != null)
            {
                drawingLine.EndPoint = p;
                this.Invalidate();
            }
        }

        private bool bDrawLine { get; set; }
        private List<Line> lines = new List<Line>();
        private Line drawingLine = null;

        private void DrawTable_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bp = new Bitmap(this.Width, this.Height); // 用于缓冲输出的位图对象
            Graphics g = Graphics.FromImage(bp);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // 消锯齿（可选项）
            AdjustableArrowCap lineCap = new AdjustableArrowCap(6, 6, true);
            Pen p = new Pen(Color.Black, (float)2.2);
            p.EndCap = LineCap.ArrowAnchor;
            p.CustomEndCap = lineCap;
            foreach (Line line in lines)
            {
                if (line == drawingLine)
                {
                    // 当前绘制的线条是正在鼠标定位的线条
                    p.Color = Color.Blue;
                }
                else
                {
                    p.Color = Color.Black;
                }
                g.DrawLine(p, line.StartPoint, line.EndPoint);
            }
            // 将缓冲位图绘制到输出
            e.Graphics.DrawImage(bp, Point.Empty);
            //drawPanel.Invalidate();
        }

        private void DrawTable_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingLine != null)
            {
                drawingLine.EndPoint = e.Location;
                this.Invalidate();
            }
        }
    }
}
