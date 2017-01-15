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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(3, 7, '^');
            p3.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int a = numList[0];
            int b = numList[1];
            int c = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            Console.WriteLine("p1: x = " +p1.x + ", y = " + p1.y + ", sym = " + p1.sym);
            pList.Add(p2);
            Console.WriteLine("p2: x = " + p2.x + ", y = " + p2.y + ", sym = " + p2.sym);
            pList.Add(p3);
            Console.WriteLine("p3: x = " + p3.x + ", y = " + p3.y + ", sym = " + p3.sym);
            
            Console.ReadLine();
        }        
    }
}
