using SimpleGeometry.Abstract.Product;
using SimpleGeometry.Calculations;
using SimpleGeometry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry.Abstract.Creator
{
    public class CircleCreator : FigureCreator
    {
        public override IFigure CreateFigure(List<LineWithCoordinates> lines)
        {
            var result = new Circle();
            result.CenterDot = lines[0].Beginning;
            result.Radius = lines[0];

            var context = new FigureAreaContext();
            context.SetStrategy(new CircleAreaStrategy());
            result.Area = context.GetArea(result);

            return result;
        }
    }
}
