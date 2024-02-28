using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry.Abstract
{
    public interface IAreaCalculationStrategy
    {
        public double CalculateArea(IFigure figure);
    }
}
