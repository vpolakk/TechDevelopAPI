using TechDevelopAPI.Properties;

namespace TechDevelopAPI.Models
{
    internal class Triangle : ISquareble
    {
        /// <summary>
        /// Стороны треугольника.
        /// </summary>
        private List<double> Sides { get; set; }

        /// <summary>
        /// Признак прямоугольности треугольника.
        /// </summary>
        private readonly bool IsRight;

        public Triangle(List<double> sides)
        {
            if (sides.Count != 3)
                throw new ArgumentException(Resources.WrongArguments);

            if (sides.Any(o => o != sides[0]) && sides.Max() >= sides.Where(_ => _ < sides.Max()).Sum())
            {
                throw new ArgumentException(Resources.Triangle_WrongedArgs);
            }

            Sides = sides;

            // проверка на прямоугольность треугольника c^2 = a^2 + b^2 где c - гипотенуза
            IsRight = (Math.Pow(sides.Max(), 2) == sides.Where(_ => _ < sides.Max()).Select(_ => Math.Pow(_, 2)).Sum());
        }


        /// <inheritdoc/>
        public double Square()
        {
            if (IsRight)
            {
                // получим катеты
                var catets = Sides.Where(_ => _ < Sides.Max()).ToList();
                return (catets[0] * catets[1]) / 2;
            }

            var p = Sides.Sum() / 2;
            var result = p;

            foreach (var x in Sides)
            {
                result *= p - x;
            }

            return Math.Sqrt(result);
        }
    }
}
