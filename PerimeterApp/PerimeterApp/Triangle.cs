using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterApp
{
    public class Triangle
    {
        public Line AB { get; private set; }

        public Line BC { get; private set; }

        public Line CA { get; private set; }

        public Triangle(Line aB, Line bC, Line cA)
        {
            AB = aB;
            BC = bC;
            CA = cA;
        }
        public double Perimeter()
        {
            return AB.CalculateDistance() + BC.CalculateDistance() + CA.CalculateDistance();
        }
    }
}
