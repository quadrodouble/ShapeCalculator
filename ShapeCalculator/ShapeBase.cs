using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    /// <summary>
    /// базовый абстрактный класс
    /// для фигур на плоскости
    /// </summary>
    abstract class ShapeBase
    {
        /// <summary>
        /// название фигуры - поле
        /// </summary>
        protected string _name;

        /// <summary>
        /// название фигуры - свойство
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// функция вычисления периметра
        /// </summary>
        /// <returns>периметр фигуры</returns>
        public abstract double GetPerimeter();

        /// <summary>
        /// функция вычисления площади
        /// </summary>
        /// <returns>площать фигуры</returns>
        public abstract double GetSquare();

        public abstract override string ToString();

    }
}