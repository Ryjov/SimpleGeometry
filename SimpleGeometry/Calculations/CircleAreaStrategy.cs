using SimpleGeometry.Abstract;
using SimpleGeometry.Abstract.Product;
using SimpleGeometry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry.Calculations
{
    class CircleAreaStrategy : IAreaCalculationStrategy
    {
        public double CalculateArea(IFigure figure)
        {
            var circle = figure as Circle;
            return Math.Round(Math.Round(Math.PI, 2) * Math.Pow((double)circle.Radius.Length, 2), 2);
        }
    }
}
