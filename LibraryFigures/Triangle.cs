using System;

namespace LibraryFigures
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// Сторона А
        /// </summary>
        private readonly double _sideA;

        /// <summary>
        /// Сторона B
        /// </summary>
        private readonly double _sideB;

        /// <summary>
        /// Сторона C
        /// </summary>
        private readonly double _sideC;

        /// <summary>
        /// Площадь
        /// </summary>
        private double? square;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new NegativeValueException();
            
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double? GetSquare()
        {
            if (square is { })
            {
                return square;
            }

            square = Math.Sqrt(HalfPerimeter() * (HalfPerimeter() - _sideA) * (HalfPerimeter() - _sideB) * (HalfPerimeter() - _sideC));

            return square;
        }

        /// <summary>
        /// Проверяет наличие прямого угла в треугольнике
        /// </summary>
        /// <returns>Наличие прямого угла</returns>
        public bool HasRightAngle()
        {
            return Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) == Math.Pow(_sideC, 2)
                || Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2) == Math.Pow(_sideB, 2)
                || Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2) == Math.Pow(_sideA, 2);
        }

        /// <summary>
        /// Вычисляет половину периметра треугольника
        /// </summary>
        /// <returns>Половина периметра треугольника</returns>
        private double HalfPerimeter() => (_sideA + _sideB + _sideC) / 2;
    }
}
