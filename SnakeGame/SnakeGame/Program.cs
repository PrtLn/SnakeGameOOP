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
            // primitive variables
            Console.WriteLine("primitive variables:");
            int a = 1;
            Func1(a);
            Console.WriteLine("Call Func1() a = " + a); // a = 1

            a = 1;
            Func2(a);
            Console.WriteLine("Call Func2() a = " + a); // a = 1

            a = 1;
            Func3(a);
            Console.WriteLine("Call Func3() a = " + a); // a = 1
            Console.WriteLine();

            // reference variables
            Console.WriteLine("reference variables");
            Point p1 = new Point(1, 3, '*');
            Move(p1, 10, 10);
            Console.WriteLine("Call Move() p1.x = " + p1.x + ", p1.y = " + p1.y); // p1.x = 11 (1 + 10); p1.y = 13 (3 + 10)

            Point p2 = new Point(4, 5, '#');
            p1 = p2;
            Console.WriteLine("p1 = p2 -> p1.x = " + p1.x + ", p1.y = " + p1.y + ", p1.sym = " + p1.sym); // 4 5 #
            p2.x = 8;
            p2.y = 8; 
            Console.WriteLine("p1.x = " + p1.x + ", p1.y = " + p1.y); // p1.x = 8, p1.y = 8
            Console.WriteLine("p2.x = " + p2.x + ", p2.y = " + p2.y); // p2.x = 8, p2.y = 8

            p1 = new Point(1, 3, '*');
            Update(p1);                                                             // p = new Point() -> "* empty new point"
            Console.WriteLine("Call Update() p1.x = " + p1.x + ", p1.y = " + p1.y); // p1.x = 1, p1.y = 3

            Console.ReadLine();
        }

        public static void Func1(int value)
           {
           }

        public static void Func2(int value)
        {
            value = value + 1;
        }

        public static void Func3(int x)
        {
            x = x + 1;
        }


        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

        public static void Update(Point p)
        {
            p = new Point();
        }

    
    }
}
