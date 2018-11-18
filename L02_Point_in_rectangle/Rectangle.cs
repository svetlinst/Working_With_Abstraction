using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace L02_Point_in_rectangle
{
    public class Rectangle
    {
        public Point TopLeftPoint { get; set; }
        public Point BottomRightPoint { get; set; }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.TopLeftPoint = topLeft;
            this.BottomRightPoint = bottomRight;
        }

        public bool Contains(Point point)
        {
            bool isHorizontal = point.CoordX >= TopLeftPoint.CoordX
                                && point.CoordX <= BottomRightPoint.CoordX;
            bool isVertical = point.CoordY>=TopLeftPoint.CoordY
                && point.CoordY<=BottomRightPoint.CoordY;
            return isHorizontal && isVertical;
        }
    }
}
