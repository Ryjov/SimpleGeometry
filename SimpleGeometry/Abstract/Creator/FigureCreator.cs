using SimpleGeometry.Abstract.Product;
using SimpleGeometry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry.Abstract.Creator
{
    public abstract class FigureCreator
    {
        public abstract IFigure CreateFigure(List<LineWithCoordinates> lines);
    }
}
