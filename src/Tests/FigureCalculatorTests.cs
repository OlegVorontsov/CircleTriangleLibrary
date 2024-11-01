using CircleTriangleLibrary;
using CircleTriangleLibrary.Figures;

namespace Tests
{
    public class FigureCalculatorTests
    {
        [Fact]
        public void TestCircleArea()
        {
            // Arrange
            var circle = new Circle(5);
            double expectedArea = Math.PI * 25;

            // Act
            double actualArea = FigureCalculator.CalculateArea(circle);

            // Assert
            Assert.Equal(expectedArea, actualArea, 6);
        }

        [Fact]
        public void TestTriangleArea()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6; // 0.5 * 3 * 4

            // Act
            double actualArea = FigureCalculator.CalculateArea(triangle);

            // Assert
            Assert.Equal(expectedArea, actualArea, 6);
        }

        [Fact]
        public void TestRightTriangle()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            bool isRight = triangle.IsRightTriangle();

            // Assert
            Assert.True(isRight);
        }

        [Fact]
        public void TestInvalidCircleRadius()
        {
            // Arrange
            Action act = () => new Circle(-1);

            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void TestInvalidTriangleSides()
        {
            // Arrange
            Action act = () => new Triangle(1, 2, 3);

            // Assert
            Assert.Throws<ArgumentException>(act);
        }
    }
}

