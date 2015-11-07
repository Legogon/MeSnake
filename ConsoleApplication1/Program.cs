using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 1, '*');
            p1.Draw();

            Point p2 = new Point(1, 2, '*');
            p2.Draw();

            Point p3 = new Point(1, 3, '*');
            p3.Draw();

            Point p4 = new Point(1, 4, '#');
            p4.Draw();

            List<Point> numList = new List<Point>();
            numList.Add(p1);
            numList.Add(p2);
            numList.Add(p3);
            numList.Add(p4);

            Console.ReadLine();
        }
    }
}
