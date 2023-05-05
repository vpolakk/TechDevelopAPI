using TechDevelopAPI.Models;
using TechDevelopAPI.Properties;

namespace TechDevelopAPI.Services
{
    /// <summary>
    /// Фабрика для вычисления площади фигуры
    /// </summary>
    public static class SquarableFactory
    {
        public static double GetSquare(List<double> sides)
        {
            return GetSquareble(sides).Square();
        }

        private static ISquareble GetSquareble(List<double> sides)
        {
            switch (sides.Count)
            {
                case 1: return new Circle(sides);
                case 3: return new Triangle(sides);
                default: throw new ArgumentException(Resources.SquarableFactory_WrongedArgs);
            }
        }
    }
}
