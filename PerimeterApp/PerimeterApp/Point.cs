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
            double xy = 0;
            while (true)
            {
                Console.WriteLine($"Введите {XY} координату:");
                var xyString = Console.ReadLine();
                bool isSuccess = double.TryParse(xyString, out xy);

                if(isSuccess)
                {
                    return xy;
                }

                Console.WriteLine("Вы ввели не число!");
            }
        }
    }
}
