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

            var actualPerimeter = ABC.CalculatePerimeter();

            var expectedPerimeter = 14.165;

            Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.1);
        }
    }
}