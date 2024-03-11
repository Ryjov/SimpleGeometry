using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry.Models
{
    public class DotWithCoordinates
    {
        public DotWithCoordinates(double x, double y)
        {
            X = x;
            Y = y;
        }

        internal double X { get; set; }
        internal double Y { get; set; }
    }
}
