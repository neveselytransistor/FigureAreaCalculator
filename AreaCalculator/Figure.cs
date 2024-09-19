namespace AreaCalculator
{
    public abstract class Figure
    {
        protected abstract double CalculateArea();

        protected readonly Lazy<double> _area;
        protected const double _delta = 1e-5;

        protected Figure()
        {
            _area = new Lazy<double>(CalculateArea);
        }

        public double Area
        {
            get
            {
                return _area.Value;
            }
        }
    }
}