using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Shape.Models
{
    class Triangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Triangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double CalculateSurface()
        {
            return Width * Height / 2;
        }
    }
}
