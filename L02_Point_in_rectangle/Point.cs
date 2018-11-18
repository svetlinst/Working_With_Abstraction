using System;
using System.Collections.Generic;
using System.Text;

namespace L02_Point_in_rectangle
{
    public class Point
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }

        public Point(int x, int y)
        {
            this.CoordX = x;
            this.CoordY = y;
        }
    }
}
