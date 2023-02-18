using System.Xml;

namespace PerimeterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вершину A");
            Point a = Point.EnterPoint();
            Console.WriteLine("Введите вершину B");
            Point b = Point.EnterPoint();
            Console.WriteLine("Введите вершину C");
            Point c = Point.EnterPoint();

            Line AB = new Line(a, b);
            Line BC = new Line(b, c);
            Line CA = new Line(c, a);

            Triangle ABC = new Triangle(AB, BC, CA);

            Console.WriteLine($"Периметар = {ABC.CalculatePerimeter()}");



            Console.ReadLine();
        }
    }
}