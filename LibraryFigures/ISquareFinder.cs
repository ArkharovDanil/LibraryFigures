namespace LibraryFigures
{
    /// <summary>
    /// Интерфейс-контракт для работы с искателем площадей
    /// </summary>
    public interface ISquareFinder
    {
        /// <summary>
        /// Возвращает площадь фигуры
        /// </summary>
        /// <param name="figure"><see cref="IFigure"/></param>
        /// <returns>Площадь фигуры</returns>
        public double? GetSquare(IFigure figure);
    }
}