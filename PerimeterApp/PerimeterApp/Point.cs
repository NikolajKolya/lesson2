namespace PerimeterApp
{
    /// <summary>
    /// Вершина треугольника
    /// </summary>
    public class Point
    {
        /// <summary>
        /// X-координата
        /// </summary>
        public double X { get; private set; }

        /// <summary>
        /// Y-координата
        /// </summary>
        public double Y { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Методо - Ввод точки с клавиатуры
        /// </summary>
        public static Point EnterPoint()
        {
            return new Point(EnterXY("x"), EnterXY("y"));
        }

        public static double EnterXY(string XY)
        {
            Console.WriteLine($"Введите {XY} координату:");
            var xyString = Console.ReadLine();
            var xy = double.Parse(xyString);
            return xy;
        }
    }
}
