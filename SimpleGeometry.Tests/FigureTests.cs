using SimpleGeometry.Abstract.Creator;
using SimpleGeometry.Abstract.Product;
using SimpleGeometry.Models;
using Xunit;

namespace SimpleGeometry.Tests
{
    public class FigureTests
    {
        [Fact]
        public void TestRadiusLength()
        {
            FigureCreator creator = new CircleCreator();
            var dotA = new DotWithCoordinates(0, 0);
            var dotB = new DotWithCoordinates(0, 4);
            var radius = new LineWithCoordinates(dotA, dotB);

            var result = creator.CreateFigure(new List<LineWithCoordinates>() { radius });

            Assert.Equal(4, radius.Length);
        }

        [Fact]
        public void TestCircleArea()
        {
            FigureCreator creator = new CircleCreator();
            var dotA = new DotWithCoordinates(0, 0);
            var dotB = new DotWithCoordinates(0, 4);
            var radius = new LineWithCoordinates(dotA, dotB);

            var result = creator.CreateFigure(new List<LineWithCoordinates>() { radius });

            Assert.Equal(50.24, result?.Area);
        }

        [Fact]
        public void TestTriangleAreaCalculation()
        {
            var dotA = new DotWithCoordinates(0, 12);
            var dotB = new DotWithCoordinates(0, 0);
            var dotС = new DotWithCoordinates(16, 0);
            var lineAB = new LineWithCoordinates(dotA, dotB);
            var lineBC = new LineWithCoordinates(dotB, dotС);
            var lineCA = new LineWithCoordinates(dotС, dotA);
            List<LineWithCoordinates> lines = new List<LineWithCoordinates>() { lineAB, lineBC, lineCA };
            double halfPerimiter = (double)lines.Select(l => l.Length).Sum() / 2;
            double halfPerimiterMinusAB = halfPerimiter - (double)lineAB.Length;
            double halfPerimiterMinusBC = halfPerimiter - (double)lineBC.Length;
            double halfPerimiterMinusCA = halfPerimiter - (double)lineCA.Length;

            var area = Math.Sqrt(halfPerimiter * halfPerimiterMinusAB * halfPerimiterMinusBC * halfPerimiterMinusCA);

            Assert.Equal(96, area);
        }

        [Fact]
        public void TestStrategy()
        {
            FigureCreator creator = new TriangleCreator();

            var dotA = new DotWithCoordinates(0, 12);
            var dotB = new DotWithCoordinates(0, 0);
            var dotС = new DotWithCoordinates(16, 0);
            var lineAB = new LineWithCoordinates(dotA, dotB);
            var lineBC = new LineWithCoordinates(dotB, dotС);
            var lineCA = new LineWithCoordinates(dotС, dotA);
            List<LineWithCoordinates> lines = new List<LineWithCoordinates>() { lineAB, lineBC, lineCA };

            var figure = creator.CreateFigure(lines);
            Assert.Equal(96, (double)figure.Area);
        }

        [Fact]
        public void TestLengthCalculation()
        {
            FigureCreator creator = new TriangleCreator();
            var dotA = new DotWithCoordinates(0, 12);
            var dotB = new DotWithCoordinates(0, 0);
            var dotС = new DotWithCoordinates(16, 0);
            var lineAB = new LineWithCoordinates(dotA, dotB);
            var lineBC = new LineWithCoordinates(dotB, dotС);
            var lineCA = new LineWithCoordinates(dotС, dotA);

            List<LineWithCoordinates> lines = new List<LineWithCoordinates>() { lineAB, lineBC, lineCA };
            double halfPerimiter = (double)lines.Select(l => l.Length).Sum() / 2;

            Assert.Equal(24, halfPerimiter);
        }
    }
}
