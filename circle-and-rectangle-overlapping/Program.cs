using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle_and_rectangle_overlapping
{
    public class Program
    {
        public class Point
        {
            public int x { set; get; }
            public int y { set; get; }

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }


        }
        public void Main(string[] args)
        {
            bool r = CheckOverlap(1, 0, 0, 1, -1, 3, 1);

        }

        public bool CheckOverlap(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2)
        {
            Point pc = new Point(xCenter, yCenter);

            //left
            Point pc1 = new Point(xCenter - radius, yCenter);

            //right
            Point pc2 = new Point(xCenter + radius, yCenter);

            //bottom
            Point pc3 = new Point(xCenter, yCenter - radius);

            //top
            Point pc4 = new Point(xCenter, yCenter + radius);

            //bottom-left
            Point p1 = new Point(x1, y1);

            //top-right
            Point p2 = new Point(x2, y2);

            //top-left
            Point p1a = new Point(x1, y2);

            //bottom-right
            Point p2a = new Point(x2, y1);






            return false;
        }
    }
}
