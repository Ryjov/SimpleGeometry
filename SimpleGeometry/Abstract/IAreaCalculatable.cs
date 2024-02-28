using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry.Abstract
{
    public interface IAreaCalculatable
    {
        public double CalculateArea(IFigure figure);
    }
}
