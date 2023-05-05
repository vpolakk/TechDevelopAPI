namespace TechDevelopAPI.Models
{
    /// <summary>
    /// Интерфейс для всех фигур чью площадь мы можем взять.
    /// </summary>
    public interface ISquareble
    {
        /// <summary>
        /// Метод для вычисления площади фигуры.
        /// </summary>
        /// <returns>
        /// Площадь фигуры.
        /// </returns>
        public double Square();
    }
}
