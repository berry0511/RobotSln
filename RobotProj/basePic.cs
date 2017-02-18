using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using WeifenLuo.WinFormsUI.Docking;

namespace RobotProj
{
    class Line
    {
        /// <summary>
        /// 建立线条对象，并设置起点
        /// </summary>
        /// <param name="startPoint">此线条的起点</param>
        public Line(Point startPoint)
        {
            StartPoint = startPoint;
            EndPoint = startPoint;
            startBox = null;
            EndBox = null;
            startBasePic = null;
            endBasePic = null;
        }
        public Point StartPoint = Point.Empty;
        public Point EndPoint = Point.Empty;
        public basePic startBasePic;
        public basePic endBasePic;
        public PictureBox startBox;
        public PictureBox EndBox;
    }

    class basePic : UserControl
    {
        public basePic()
        {
            MoveFlag = false;
            MovePoint = new Point(0, 0);
            basePicture = new PictureBox();
            inputBoxes = new List<PictureBox>();
            outputBoxes = new List<PictureBox>();
            inOriginImage = Image.FromFile(@".\export\Image\ConnectImage\In.png");
            inSmallImage = inOriginImage.GetThumbnailImage(10, 10, null, new IntPtr());
            outOriginImage = Image.FromFile(@".\export\Image\ConnectImage\Out.png");
            outSmallImage = outOriginImage.GetThumbnailImage(10, 10, null, new IntPtr());

        }

        public void loadBasePic(string name, Point p)
        {
            this.Size = new Size(70, 70);
            this.Location = p;
            this.Show();
            baseImage = Image.FromFile(@".\export\Image\IconImage\FlowControl\" + name + @"1.png");
            baseLightImage = Image.FromFile(@".\export\Image\IconImage\FlowControl\" + name + @"2.png");
            basePicture.Image = baseImage;
            basePicture.Location = new Point(0, 0);
            basePicture.Name = name;
            basePicture.Size = new Size(70, 70);
            basePicture.TabStop = false;
            this.Controls.Add(basePicture);
            basePicture.SendToBack();
            basePicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.baseMouseDown);
            basePicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.baseMouseMove);
            basePicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.baseMouseUp);
            basePicture.MouseEnter += new System.EventHandler(this.baseMouseEnter);
            basePicture.MouseLeave += new System.EventHandler(this.baseMouseLeave);
            basePicture.Show();
        }

        public void createInputPic(object sender, Point p)
        {
            PictureBox input = new PictureBox();
            input.Location = p;
            input.Tag = p;
            input.Image = inSmallImage;
            input.Name = "Point";
            input.Size = new Size(10, 10);
            input.TabStop = false;
            input.MouseDown += new System.Windows.Forms.MouseEventHandler(this.inputMouseDown);
            input.MouseUp += new System.Windows.Forms.MouseEventHandler(this.inputMouseUp);
            input.MouseHover += new System.EventHandler(this.inputMouseEnter);
            input.MouseLeave += new System.EventHandler(this.inputMouseLeave);
            this.Controls.Add(input);
            input.BringToFront();
            input.Show();
            inputBoxes.Add(input);
        }

        public void createOutputPic(object sender, Point p)
        {
            PictureBox output = new PictureBox();
            output.Location = p;
            output.Tag = p;
            output.Image = outSmallImage;
            output.Name = "Point";
            output.Size = new System.Drawing.Size(10, 10);
            output.TabStop = false;
            output.MouseDown += new System.Windows.Forms.MouseEventHandler(this.outputMouseDown);
            output.MouseUp += new System.Windows.Forms.MouseEventHandler(this.outputMouseUp);
            output.MouseEnter += new System.EventHandler(this.outputMouseEnter);
            output.MouseLeave += new System.EventHandler(this.outputMouseLeave);
            this.Controls.Add(output);
            output.BringToFront();
            output.Show();
            outputBoxes.Add(output);
        }

        public void baseMouseMove(object sender, MouseEventArgs e)
        {
            DrawTable form = this.Parent as DrawTable;
            
            if (MoveFlag)
            {
                Point p = new Point(e.X - MovePoint.X, e.Y - MovePoint.Y);
                form.onPicturboxMove(p, (object)this);
                this.Left += Convert.ToInt16(p.X);
                this.Top += Convert.ToInt16(p.Y);
            }
            Point newLoc = new Point(e.Location.X + this.Location.X, e.Location.Y + this.Location.Y);
            form.uponPicturBoxMove(newLoc);
        }

        public void baseMouseEnter(object sender, EventArgs e)
        {
            basePicture.Image = baseLightImage;
        }

        public void baseMouseLeave(object sender, EventArgs e)
        {
            basePicture.Image = baseImage;
        }

        public void baseMouseUp(object sender, MouseEventArgs e)
        {
            MoveFlag = false;
        }

        public void baseMouseDown(object sender, MouseEventArgs e)
        {
            this.BringToFront();
            MoveFlag = true;
            MovePoint = e.Location;
        }

        public void inputMouseEnter(object sender, EventArgs e)
        {
            PictureBox box = sender as PictureBox;
            Point p = new Point();
            p.X = box.Location.X;
            p.Y = box.Location.Y - 5;
            box.Location = p;
            box.Image = inOriginImage;
            box.Size = new System.Drawing.Size(20, 20);
            this.basePicture.Image = baseLightImage;
            box.BringToFront();
            box.Show();
        }

        public void inputMouseLeave(object sender, EventArgs e)
        {
            PictureBox box = sender as PictureBox;
            box.Location = (Point)box.Tag;
            box.Image = inSmallImage;
            box.Size = new System.Drawing.Size(10, 10);
            this.basePicture.Image = baseImage;
            box.BringToFront();
            box.Show();
        }

        public void inputMouseDown(object sender, MouseEventArgs e)
        {
            PictureBox input = sender as PictureBox;
            DrawTable form = this.Parent as DrawTable;
            Point p = new Point();
            p.X = this.Location.X + ((Point)input.Tag).X;
            p.Y = this.Location.Y + ((Point)input.Tag).Y + 5;
            form.endDrawing(p, (object)this, input);
        }

        public void inputMouseUp(object sender, MouseEventArgs e)
        {

        }

        public void outputMouseEnter(object sender, EventArgs e)
        {
            PictureBox box = sender as PictureBox;
            Point p = new Point();
            p.X = box.Location.X - 10;
            p.Y = box.Location.Y - 5;
            box.Location = p;
            box.Image = outOriginImage;
            box.Size = new System.Drawing.Size(20, 20);
            this.basePicture.Image = baseLightImage;
            box.BringToFront();
            box.Show();
        }

        public void outputMouseLeave(object sender, EventArgs e)
        {
            PictureBox box = sender as PictureBox;
            box.Location = (Point)box.Tag;
            box.Image = outSmallImage;
            box.Size = new System.Drawing.Size(10, 10);
            this.basePicture.Image = baseImage;
            box.BringToFront();
            box.Show();
        }

        public void outputMouseDown(object sender, MouseEventArgs e)
        {
            PictureBox output = sender as PictureBox;
            DrawTable form = this.Parent as DrawTable;
            Point p = new Point();
            p.X = this.Location.X + ((Point)output.Tag).X + 10;
            p.Y = this.Location.Y + ((Point)output.Tag).Y + 5;
            form.initDrawPen(p, (object)this, output);
        }

        public void outputMouseUp(object sender, MouseEventArgs e)
        {
            //Form1 form = sender as Form1;
            //form.ifDraw = false;
            //Point p = new Point();
            //p = this.PointToScreen(e.Location);
            //if (drawingLine == null) return;
            //drawingLine.EndPoint = p;
            //drawingLine = null;
        }

        public List<PictureBox> getInputBox()
        {
            return inputBoxes;
        }

        public List<PictureBox> getOutputBox()
        {
            return outputBoxes;
        }

        private bool MoveFlag { get; set; }
        private Point MovePoint { get; set; }
        private PictureBox basePicture;
        private List<PictureBox> inputBoxes;
        private List<PictureBox> outputBoxes;
        private Image baseImage;
        private Image baseLightImage;
        private Image inOriginImage;
        private Image outOriginImage;
        private Image inSmallImage;
        private Image outSmallImage;

    }
}
