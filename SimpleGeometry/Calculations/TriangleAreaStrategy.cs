using SimpleGeometry.Abstract;
using SimpleGeometry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry.Calculations
{
    class TriangleAreaStrategy : IAreaCalculationStrategy
    {
        public double CalculateArea(IFigure figure)
        {
            var sidelengths = figure.Lines.ToList();
            double perimiter = (double)sidelengths.Sum();

            return Math.Sqrt(perimiter * (perimiter - (double)sidelengths[0]) * (perimiter - (double)sidelengths[1]) * (perimiter - (double)sidelengths[2]));
        }
    }
}
