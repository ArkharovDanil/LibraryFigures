using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibraryFigures;
namespace LibraryFiguresTest
{
    [TestClass]
    public class LibraryFiguresTest
    {
        /// <summary>
        /// Проверка работы метода GetSquare класса <see cref="Circle"/>
        /// </summary>
        /// <param name="value"></param>
        [DataTestMethod]
        [DataRow(5.0)]
        [DataRow(10.0)]
        [DataRow(15.0)]
        [DataRow(20.0)]
        public void CircleGetSquare(double value)
        {
            var circle = new Circle(value);
            ISquareFinder sq = new SquareFinder();

            double? square=sq.GetSquare(circle);
            double? expectedSquare=Math.PI* value * value;

            Assert.AreEqual(square, expectedSquare);
        }

        /// <summary>
        /// Проверка работы метода GetSquare класса <see cref="Triangle"/>
        /// </summary>
        /// <param name="sizeA"></param>
        /// <param name="sizeB"></param>
        /// <param name="sizeC"></param>
        /// <param name="expectedSquare"></param>
        [DataTestMethod]
        [DataRow(5.0, 5.0, 5.0, 10.825317547305483)]
        [DataRow(6.0, 5.0, 5.0, 12.0)]
        [DataRow(3.0, 4.0, 5.0, 6.0)]
        [DataRow(4.0, 2.0, 5.0, 3.799671038392666)]
        public void TriangleGetSquare(double sizeA, double sizeB, double sizeC,double expectedSquare)
        {
            var triangle = new Triangle(sizeA, sizeB, sizeC);
            ISquareFinder sq = new SquareFinder();

            double? square = sq.GetSquare(triangle);
            
            Assert.AreEqual(square, expectedSquare);
        }

        /// <summary>
        /// Проверка работы метода HasRightAngle класса <see cref="Triangle"/>
        /// </summary>
        /// <param name="sizeA"></param>
        /// <param name="sizeB"></param>
        /// <param name="sizeC"></param>
        /// <param name="expectedAnswer"></param>
        [DataTestMethod]
        [DataRow(5.0, 5.0, 5.0, false)]
        [DataRow(6.0, 5.0, 5.0, false)]
        [DataRow(3.0, 4.0, 5.0, true)]
        [DataRow(4.0, 2.0, 5.0, false)]
        public void IsTriangleHasRightAngle(double sizeA, double sizeB, double sizeC, bool expectedAnswer)
        {
            var triangle = new Triangle(sizeA, sizeB, sizeC);

            bool hasRightAngle = triangle.HasRightAngle();

            Assert.AreEqual(hasRightAngle, expectedAnswer);
        }
    }
}