using SimpleGeometry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry.Abstract.Product
{
    public class Triangle : IFigure
    {
        public Triangle() { }

        public DotWithCoordinates DotA { get; set; }
        public DotWithCoordinates DotB { get; set; }
        public DotWithCoordinates DotC { get; set; }

        public LineWithCoordinates SideAB { get; set; }
        public LineWithCoordinates SideBC { get; set; }
        public LineWithCoordinates SideCA { get; set; }
    }
}
