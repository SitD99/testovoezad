using ShapeLibrary;

namespace TestShape
{
    public class Tests
    {
        [Test]
        public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
        {
            double radius = 1.0;
            IShape circle = new Circle(radius);
            double expectedArea = Math.PI;

            double actualArea = circle.CalcArea();

            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [Test]
        public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
        {
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            IShape triangle = new Triangle(sideA, sideB, sideC);
            double expectedArea = 6.0;

            double actualArea = triangle.CalcArea();

            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [Test]
        public void IsRightAngledTriangle_RightAngledTriangle_ReturnsTrue()
        {
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            IShape triangle = new Triangle(sideA, sideB, sideC);

            bool isRightAngled = (triangle as Triangle)?.IsRightTriangle() ?? false;

            Assert.IsTrue(isRightAngled);
        }
    }
}