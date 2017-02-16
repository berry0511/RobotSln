using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RobotProj
{
    class picBoxEnd : basePic
    {
        public picBoxEnd()
        {
            loadBasePic("End", new Point(0, 0));
            loadInputOutputPic();
        }

        public picBoxEnd(Point p)
        {
            loadBasePic("End", p);
            loadInputOutputPic();
        }

        public void loadInputOutputPic()
        {
            createInputPic(this, new Point(0, 15));
            createInputPic(this, new Point(0, 45));
            createOutputPic(this, new Point(60, 30));
        }
    }
}
