namespace LibraryFigures
{
    /// <summary>
    /// Искатель площади
    /// </summary>
    public class SquareFinder:ISquareFinder
    {
        public double? GetSquare(IFigure figure)
        {
            return figure.GetSquare();
        }
    }
}
