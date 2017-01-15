using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine()
        {
            pList = new List<Point>();
            Point p1 = new Point(4, 4, '*');
            Point p2 = new Point(5, 4, '*');
            Point p3 = new Point(6, 4, '*');
            Point p4 = new Point(7, 4, '*');
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
        }

        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }


    }
}
