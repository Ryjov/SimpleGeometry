using SimpleGeometry.Abstract.Creator;
using SimpleGeometry.Abstract.Product;
using SimpleGeometry.Models;

namespace SimpleGeometry
{
    public class AreaCalculation
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
                    throw new ArgumentException($"Incorrect set of coordinates sent for calculating a shape's area. " +
                        $"Valid number of coordinates: 2-3. Number of coordinates sent: {dotCoordinates.Count}");
            }

            var lines = CreateLines(creator, dotCoordinates);

            var figure = creator.CreateFigure(lines);
            return (double)figure.Area;
        }

        public bool IsTriangleRight(List<Tuple<double, double>> dotCoordinates)
        {
            FigureCreator creator = new TriangleCreator();
            var lines = CreateLines(creator, dotCoordinates);
            var figure = creator.CreateFigure(lines) as Triangle;

            return figure.IsRight;
        }

        private List<LineWithCoordinates> CreateLines(FigureCreator creator, List<Tuple<double, double>> dotCoordinates)
        {
            var dots = new List<DotWithCoordinates>();
            foreach (var d in dotCoordinates)
            {
                dots.Add(new DotWithCoordinates(d.Item1, d.Item2));
            }

            var lines = new List<LineWithCoordinates>();
            for (int i = 0; i < dots.Count; i++)
            {
                if (i + 1 < dots.Count)
                {
                    lines.Add(new LineWithCoordinates(dots[i], dots[i + 1]));
                }
                else if (!(creator is CircleCreator))
                {
                    lines.Add(new LineWithCoordinates(dots[i], dots[0]));
                }
            }

            return lines;
        }
    }
}