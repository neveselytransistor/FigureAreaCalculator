

namespace AreaCalculator
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException(null, "Invalid value");
            }
        }

        protected override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
