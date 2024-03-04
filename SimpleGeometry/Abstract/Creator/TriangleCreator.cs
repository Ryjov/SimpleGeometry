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
    public class TriangleCreator : FigureCreator
    {
        public override IFigure CreateFigure(List<LineWithCoordinates> lines)
        {
            var result = new Triangle();
            result.SideAB = lines[0];
            result.SideBC = lines[1];
            result.SideCA = lines[2];
            result.DotA = result.SideAB.Beginning;
            result.DotB = result.SideBC.Beginning;
            result.DotC = result.SideCA.Beginning;

            var context = new FigureAreaContext();
            context.SetStrategy(new TriangleAreaStrategy());
            result.Area = context.GetArea(result);

            result.IsRight = IsTriangleRight(result);

            return result;
        }

        public bool IsTriangleRight(Triangle triangle)
        {
            if ((Math.Pow((double)triangle.SideAB.Length, 2) + Math.Pow((double)triangle.SideBC.Length, 2) == Math.Pow((double)triangle.SideCA.Length, 2)) ||
                    (Math.Pow((double)triangle.SideBC.Length, 2) + Math.Pow((double)triangle.SideCA.Length, 2) == Math.Pow((double)triangle.SideAB.Length, 2)) ||
                    (Math.Pow((double)triangle.SideAB.Length, 2) + Math.Pow((double)triangle.SideCA.Length, 2) == Math.Pow((double)triangle.SideBC.Length, 2)))
            {
                return true;
            }

            return false;
        }
    }
}
