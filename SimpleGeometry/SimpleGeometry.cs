using SimpleGeometry.Abstract;
using SimpleGeometry.Models;

namespace SimpleGeometry
{
    public class SimpleGeometry
    {
        public double CalculateTriangleArea(List<DotWithCoordinates> dots)
        {
            var lineA = new LineWithCoordinates(dots[0], dots[1], null);
            var lineB = new LineWithCoordinates(dots[1], dots[2], null);
            var lineC = new LineWithCoordinates(dots[2], dots[0], null);
            IFigure figure = new Triangle(lineA, lineB, lineC);

            
        }
    }
}