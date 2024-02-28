using SimpleGeometry.Abstract;
using SimpleGeometry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry.Calculations
{
    public class CircleAreaStrategy : IAreaCalculatable
    {
        public double CalculateArea(IFigure figure)
        {
            return Math.PI * Math.Pow(figure.Lines[0], 2);
        }
    }
}
