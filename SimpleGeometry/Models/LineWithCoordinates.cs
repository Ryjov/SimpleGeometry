﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometry.Models
{
    public class LineWithCoordinates
    {
        public LineWithCoordinates(DotWithCoordinates beginning, DotWithCoordinates end, double? length = null)
        {
            Beginning = beginning;
            End = end;
            Length = length ?? CalculateLineLength();
        }


        public LineWithCoordinates(double length)
        {
            Beginning = new DotWithCoordinates(0, 0);
            End = new DotWithCoordinates(length, length);
            Length = length;
        }

        public DotWithCoordinates Beginning { get; }
        public DotWithCoordinates End { get; }
        public double? Length { get; }

        private double CalculateLineLength()
        {
            return Math.Sqrt(Math.Pow((End.X - Beginning.X), 2) + Math.Pow((End.Y - Beginning.Y), 2));
        }
    }
}
