using CircleTriangleLibrary.Interfaces;

namespace CircleTriangleLibrary.Figures
{
    public class Triangle : IFigure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Стороны треугольника не могут быть отрицательными или равными нулю");
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Стороны не могут образовать треугольник");

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double Area()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public bool IsRightTriangle()
        {
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-9;
        }
    }
}
