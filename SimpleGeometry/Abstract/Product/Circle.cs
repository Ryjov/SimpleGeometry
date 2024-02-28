using SimpleGeometry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry.Abstract.Product
{
    public class Circle : IFigure
    {
        public Circle() { }

        public DotWithCoordinates CenterDot { get; set; }

        public LineWithCoordinates Radius { get; set; }
    }
}
