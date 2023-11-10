using System;
namespace LibraryFigures
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус
        /// </summary>
        private readonly double _radius;

        /// <summary>
        /// Площадь
        /// </summary>
        private double? square;

        public Circle(double radius)
        {
            if (radius < 0)
                throw new NegativeValueException();

            _radius = radius;
        }

        public double? GetSquare()
        {
            if (square is null)
            {
                square = Math.PI * Math.Pow(_radius,2);

                return square;
            }

            return square;
        }
    }
}