using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterApp
{
    public class Line
    {
        public Point Begin { get; private set; }

        public Point End { get; private set; }

        public Line(Point begin, Point end)
        {
            Begin = begin;
            End = end;
        }

        public double CalculateDistance()
        {
            return Math.Sqrt(Math.Pow(Begin.X - End.X, 2) + Math.Pow(Begin.Y - End.Y, 2));
        }
    }
}
