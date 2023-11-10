namespace LibraryFigures
{
    /// <summary>
    /// Интерфейс-контракт для работы с фигурами
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Возвращает площадь данной фигуры
        /// </summary>
        /// <returns>Площадь данной фигуры</returns>
        public double? GetSquare();
    }
}
