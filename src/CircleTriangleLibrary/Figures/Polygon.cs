using CircleTriangleLibrary.Interfaces;

namespace CircleTriangleLibrary.Figures
{
    public class Polygon : IFigure
    {
        private double[] sides;

        public Polygon(double[] sides)
        {
            if (sides.Length < 3)
                throw new ArgumentException("Многоугольник должен иметь по крайней мере 3 стороны");

            this.sides = sides;
        }

        public double Area()
        {
            double area = 0;
            int n = sides.Length;

            // Для многоугольников с n сторонами разбиваем на n-2 треугольника
            for (int i = 1; i < n - 1; i++)
            {
                double a = sides[0];
                double b = sides[i];
                double c = sides[i + 1];

                area += TriangleArea(a, b, c);
            }

            return area;
        }

        private double TriangleArea(double a, double b, double c)
        {
            // Используем формулу Герона
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
