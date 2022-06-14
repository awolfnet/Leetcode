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




            return false;
        }
    }
}
