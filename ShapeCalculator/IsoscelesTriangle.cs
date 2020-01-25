using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double side, double baseSide)
            : base(side, side, baseSide)
        {
            _name = "равнобедренный треугольник";
        }



    }
}
