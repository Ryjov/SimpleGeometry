﻿using SimpleGeometry.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry.Models
{
    internal class Circle : IFigure
    {
        public Circle(LineWithCoordinates radius)
        {
            Radius = radius;
        }

        protected LineWithCoordinates Radius { get; set; }
    }
}
