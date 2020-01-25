using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(4, 5, 6);
            IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(4, 6);
            Console.WriteLine(triangle.ToString());
            Console.WriteLine(isoscelesTriangle.ToString());
            Console.ReadKey();
        }
    }
}