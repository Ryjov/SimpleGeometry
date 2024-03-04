using SimpleGeometry.Abstract.Creator;
using SimpleGeometry.Models;
using Xunit;

namespace SimpleGeometry.Tests
{
    public class AreaCalculationTests
    {
        [Fact]
        public void TestCircleArea()
        {
            // Arrange
            FigureCreator creator = new CircleCreator();
            var dotA = new DotWithCoordinates(1, 1);
            var dotB = new DotWithCoordinates(5, 5);
            var radius = new LineWithCoordinates(dotA, dotB);

            // Act
            var result = creator.CreateFigure(new List<LineWithCoordinates>() { radius });

            // Assert
            Assert.Equal(50.17, result?.Area);
        }
    }
}
