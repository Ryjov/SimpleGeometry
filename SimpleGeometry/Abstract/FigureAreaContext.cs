using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleGeometry.Abstract.Product;

namespace SimpleGeometry.Abstract
{
    public class FigureAreaContext
    {
        private IAreaCalculationStrategy _strategy;

        public FigureAreaContext()
        { }

        public void SetStrategy(IAreaCalculationStrategy strategy)
        {
            _strategy = strategy;
        }

        public double GetArea(IFigure figure)
        {
            return _strategy.CalculateArea(figure);
        }
    }
}
