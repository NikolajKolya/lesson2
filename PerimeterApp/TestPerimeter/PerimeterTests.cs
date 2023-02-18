using PerimeterApp;

namespace TestPerimeter
{
    [TestClass]
    public class PerimeterTests
    {
        [TestMethod]
        public void TestPerimeter()
        {
            Point A = new Point(-1, 4);
            Point B = new Point(-1, 2);
            Point C = new Point(-7, 3);

            Line AB = new Line(A, B);
            Line BC = new Line(B, C);
            Line CA = new Line(C, A);

            Triangle ABC = new Triangle(AB, BC, CA);
            square abc = new square(AB.CalculateDistance(), BC.CalculateDistance(), CA.CalculateDistance());

            var actualPerimeter = ABC.CalculatePerimeter();
            var actualSquare = abc.CalculateSquare();

            var expectedPerimeter = 14.165;
            var expectedSquare = 6;

            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.01);
            Assert.AreEqual(expectedSquare, actualSquare, 0.01);
        }
    }
}