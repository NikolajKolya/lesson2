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
        private Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Ввод точки с клавиатуры
        /// </summary>
        public static Point EnterPoint()
        {
            Console.WriteLine("Введите X координату:");
            var xString = Console.ReadLine();
            var x = double.Parse(xString);

            Console.WriteLine("Введите Y координату:");
            var yString = Console.ReadLine();
            var y = double.Parse(yString);

            return new Point(x, y);
        }
    }
}
