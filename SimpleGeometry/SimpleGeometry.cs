using SimpleGeometry.Abstract;
using SimpleGeometry.Abstract.Creator;
using SimpleGeometry.Abstract.Product;
using SimpleGeometry.Calculations;
using SimpleGeometry.Models;

namespace SimpleGeometry
{
    public class SimpleGeometry
    {
        // Input dot coordinates in a Tuple<double,double> as parameters to receive an area of a resulting figure
        public double CalculateArea(List<Tuple<double, double>> dotCoordinates)
        {
            FigureCreator creator;
            switch (dotCoordinates.Count)
            {
                case 2:
                    creator = new CircleCreator();
                    break;
                case 3:
                    creator = new TriangleCreator();
                    break;
                default:
                    throw new ArgumentException($"Incorrect set of coordinates sent for calculating a shape's area. Valid number of coordinates: 2-3. Number of coordinates sent: ${dotCoordinates.Count}");
            }

            var dots = new List<DotWithCoordinates>();
            foreach (var d in dotCoordinates)
            {
                dots.Add(new DotWithCoordinates(d.Item1, d.Item2));
            }

            var lines = new List<LineWithCoordinates>();
            for (int i=0; i<dots.Count;i++)
            {
                if ((dots[i + 1].X != dots[0].X && dots[i + 1].Y != dots[0].Y) || (i + 1 >= dots.Count)) // check
                {
                    lines.Add(new LineWithCoordinates(dots[i], dots[0]));
                }
                else
                {
                    lines.Add(new LineWithCoordinates(dots[i], dots[i + 1]));
                }
            }

            var figure = creator.CreateFigure(lines);
            return (double)figure.Area;
        }
    }
}