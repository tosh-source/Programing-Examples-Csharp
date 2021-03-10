using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Shape.Models
{
    class Square : IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }  //this property is need to be implemented because of interface, but never used

        public Square(double height)
        {
            this.Height = height;
        }

        public double CalculateSurface()
        {
            return Height * Height;
        }
    }
}
