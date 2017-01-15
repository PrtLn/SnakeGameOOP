using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            // drawing frame
            HorizontalLine lineUp = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine lineDown = new HorizontalLine(0, 78, 24, '+');
            VerticalLine lineRight = new VerticalLine(0, 24, 0, '+');               
            VerticalLine lineLeft = new VerticalLine(0, 24, 78, '+');
            lineUp.Drow();
            lineRight.Drow();
            lineDown.Drow();
            lineLeft.Drow();

            // drawing snake
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Drow();

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);                  
                }
                Thread.Sleep(150);
                snake.Move();
            }
        }        
    }
}
