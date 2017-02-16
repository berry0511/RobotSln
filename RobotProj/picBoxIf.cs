using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProj
{
    class picBoxIf : basePic
    {
        public picBoxIf()
        {
            loadBasePic("If", new Point(0, 0));
            loadInputOutputPic();
        }

        public picBoxIf(Point p)
        {
            loadBasePic("If", p);
            loadInputOutputPic();
        }

        public void loadInputOutputPic()
        {
            createInputPic(this, new Point(0, 30));
            createOutputPic(this, new Point(60, 15));
            createOutputPic(this, new Point(60, 45));

        }
    }
}
