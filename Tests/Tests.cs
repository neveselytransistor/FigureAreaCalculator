using AreaCalculator;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsRadiusNegative()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
            Assert.That(ex.Message, Is.EqualTo("Invalid value"));
        }

        [Test]
        public void IsTriangleSideNegative()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-3, 4, 5));
            Assert.That(ex.Message, Is.EqualTo("Invalid value"));
        }

        [Test]
        public void IsTriangleRectangle()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRectangle);
        }
        [Test]
        public void IsTriangleNotRectangle()
        {
            var triangle = new Triangle(1, 2, 3);
            Assert.IsFalse(triangle.IsRectangle);
        }

        [Test]
        public void CheckTriangleAreaCalculation()
        {
            var triangle = new Triangle(3, 4, 5);
            var p = (3 + 4 + 5) / 2;
            var expectedValue = Math.Sqrt(p * (p - 3) * (p - 4) * (p - 5));
            Assert.That(triangle.Area, Is.EqualTo(expectedValue).Within(Constants.Delta));
        }

        [Test]
        public void CheckCircleAreaCalculation()
        {
            var triangle = new Circle(1.5);
            var expectedValue = Math.PI * 1.5 * 1.5;
            Assert.That(triangle.Area, Is.EqualTo(expectedValue).Within(Constants.Delta));
        }
    }
}