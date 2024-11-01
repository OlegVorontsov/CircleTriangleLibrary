using CircleTriangleLibrary.Interfaces;

namespace CircleTriangleLibrary.Figures
{
    public class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным");
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
