using CircleTriangleLibrary.Interfaces;

namespace CircleTriangleLibrary
{
    public static class FigureCalculator
    {
        public static double CalculateArea(IFigure figure)
        {
            if (figure == null)
                throw new ArgumentNullException(nameof(figure));
            return figure.Area();
        }
    }
}
