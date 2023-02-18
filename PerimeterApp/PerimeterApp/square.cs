using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterApp
{
    public class square
    {

        public double AB { get; private set; }

        public double BC{ get; private set; }

        public double CA { get; private set; }
        public square(double aB, double bC, double cA) {
            AB = aB;
            BC = bC;
            CA = cA;
        }

        public double CalculateSquare()
        {
            double p = (AB + BC + CA) / 2;
            double square = Math.Sqrt(p*(p - AB )*(p - BC)*(p - CA));
            return square;
        }

    }
}
