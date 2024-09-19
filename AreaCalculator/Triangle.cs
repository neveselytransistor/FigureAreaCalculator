

namespace AreaCalculator
{
    public class Triangle : Figure
    {
        public double SideA { get; private set; }

        public double SideB { get; private set; }

        public double SideC { get; private set; }

        protected readonly bool _isRectangle;

        public bool IsRectangle => _isRectangle;


        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException(null, "Invalid value");
            }
            SideA = sideA; 
            SideB = sideB; 
            SideC = sideC;
            _isRectangle = IsRectangular();
        }

        protected override double CalculateArea()
        {
            var p = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        protected bool IsRectangular()
        {
            List<double> sides = new() { SideA, SideB, SideC };
            double maxValue = sides.Max<double>();
            sides.Remove(maxValue);
            double error = maxValue * maxValue - (sides[0] * sides[0] + sides[1] * sides[1]);
            return Math.Abs(error) < _delta;
        }
    }
}
