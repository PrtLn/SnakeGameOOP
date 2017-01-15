using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            // drawing lines
            HorizontalLine lineUp = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine lineDown = new HorizontalLine(0, 78, 24, '+');
            VerticalLine lineRight = new VerticalLine(0, 24, 0, '+');               
            VerticalLine lineLeft = new VerticalLine(0, 24, 78, '+');
            lineUp.Drow();
            lineRight.Drow();
            lineDown.Drow();
            lineLeft.Drow();

            // drawing points
            Point p = new Point(4, 5, '*');
            p.Draw();

            Console.ReadLine();
        }        
    }
}
