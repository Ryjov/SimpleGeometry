using SimpleGeometry.Abstract;
using SimpleGeometry.Calculations;
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

            return CreateFigureAndGetArea(new Triangle(lineA, lineB, lineC));
        }

        public double CalculateCircleArea(double centerX, double centerY, double endX, double endY)
        {
            var centerDot = new DotWithCoordinates(centerX, centerY);
            var endDot = new DotWithCoordinates(endX, endY);
            var radiusLine = new LineWithCoordinates(centerDot, endDot, null);

            return CreateFigureAndGetArea(new Circle(radiusLine));
        }

        public double CalculateCircleArea(double radius)
        {
            var radiusLine = new LineWithCoordinates(radius);

            return CreateFigureAndGetArea(new Circle(radiusLine));
        }

        private double CreateFigureAndGetArea(Circle circle)
        {
            var context = new FigureAreaContext();
            context.SetStrategy(new CircleAreaStrategy());
            return context.GetArea(circle);
        }

        private double CreateFigureAndGetArea(Triangle triangle)
        {
            var context = new FigureAreaContext();
            context.SetStrategy(new TriangleAreaStrategy());
            return context.GetArea(triangle);
        }
    }
}