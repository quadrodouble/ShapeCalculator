using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    class Triangle : ShapeBase
    {
        protected double _firstSide;
        protected double _secondSide;
        protected double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (Validate(firstSide, secondSide, thirdSide))
            {
                _name = "треугольник";
                _firstSide = firstSide;
                _secondSide = secondSide;
                _thirdSide = thirdSide;
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    "недопустимые значения сторон треугольника"
                    );
            }
        }

        public override double GetPerimeter()
        {
            return _firstSide + _secondSide + _thirdSide;
        }

        public override double GetSquare()
        {
            double halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter
                * (halfPerimeter - _firstSide)
                * (halfPerimeter - _secondSide)
                * (halfPerimeter - _thirdSide)
                );
        }

        public override string ToString()
        {
            return String.Concat(_name, 
                "\nСтороны: ",
                _firstSide, ", ", 
                _secondSide, ", ",
                _thirdSide,
                "\nПериметр: ",
                GetPerimeter(),
                "\nПлощадь: ",
                GetSquare()
                );
        }



        private bool Validate(double firstSide,
            double secondSide, double thirdSide)
        {
            return firstSide > 0 && secondSide > 0 && thirdSide > 0
                && firstSide + secondSide > thirdSide
                && firstSide + thirdSide > secondSide
                && secondSide + thirdSide > firstSide;
        }
    }
}
