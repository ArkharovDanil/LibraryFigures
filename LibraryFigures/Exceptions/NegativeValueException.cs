using System;

namespace LibraryFigures
{
    /// <summary>
    /// Исключение при невалидных значениях для <see cref="IFigure"/>
    /// </summary>
    public class NegativeValueException : Exception
    {
        public NegativeValueException() : base() { }
        public NegativeValueException(string message) : base(message) { }
        public NegativeValueException(string message, Exception inner) : base(message, inner) { }
    }
}
