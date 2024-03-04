using SimpleGeometry.Abstract;
using SimpleGeometry.Abstract.Product;
using SimpleGeometry.Models;

namespace SimpleGeometry.Calculations
{
    class TriangleAreaStrategy : IAreaCalculationStrategy
    {
        public double CalculateArea(IFigure figure)
        {
            var triangle = figure as Triangle;
            var sidelengths = new List<double>() { (double)triangle.SideAB.Length, (double)triangle.SideBC.Length, (double)triangle.SideCA.Length };
            double halfPerimiter = (double)sidelengths.Sum() / 2;
            double halfPerimiterMinusAB = halfPerimiter - (double)triangle.SideAB.Length;
            double halfPerimiterMinusBC = halfPerimiter - (double)triangle.SideBC.Length;
            double halfPerimiterMinusCA = halfPerimiter - (double)triangle.SideCA.Length;

            var area = Math.Sqrt(halfPerimiter * halfPerimiterMinusAB * halfPerimiterMinusBC * halfPerimiterMinusCA);

            return Math.Sqrt(halfPerimiter * (halfPerimiter - (double)sidelengths[0]) * (halfPerimiter - (double)sidelengths[1]) * (halfPerimiter - (double)sidelengths[2]));
        }
    }
}
