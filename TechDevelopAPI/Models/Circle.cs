using TechDevelopAPI.Properties;

namespace TechDevelopAPI.Models
{
    //Метод объявлен вирутальным для возможного расширения в случае добавления элипсов.
    internal class Circle : ISquareble
    {
        /// <summary>
        /// Радиус окружности.
        /// </summary>
        private double Radius { get; set; }

        public Circle(List<double> sides)
        {
            if (sides.Count != 1)
                throw new ArgumentException(Resources.WrongArguments);
            Radius = sides.FirstOrDefault();
        }

        /// <inheritdoc/>
        public virtual double Square()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
    }
}
