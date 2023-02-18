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
        public double CalculatePerimeter()
        {
            return AB.CalculateDistance() + BC.CalculateDistance() + CA.CalculateDistance();
        }
    }
}
