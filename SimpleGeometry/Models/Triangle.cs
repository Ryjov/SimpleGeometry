using SimpleGeometry.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry.Models
{
    internal class Triangle : IFigure
    {
        public Triangle(LineWithCoordinates sideA, LineWithCoordinates sideB, LineWithCoordinates sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        protected LineWithCoordinates SideA { get; set; }

        protected LineWithCoordinates SideB { get; set; }

        protected LineWithCoordinates SideC { get; set; }

        public IFigure Clone() => new Triangle(SideA, SideB, SideC);
    }
}
