using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Figure
    {
        protected List<Point> pLine;

        public void Drow()
        {
            foreach (Point p in pLine)
            {
                p.Draw();
            }
        }
    }
}
