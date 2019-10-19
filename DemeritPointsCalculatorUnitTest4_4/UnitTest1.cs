using System;
using NUnit.Framework;

namespace DemeritPointsCalculatorUnitTest4_4
{
    [TestFixture]
    public class DemeritPointsCalculator
    {
        [Test]
        [TestCase(-1)]
        [TestCase(30)]

        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException()
        {
            var calculator = new DemeritPointsCalculator();

            Assert.That(()=>calculator.CalculateDemeritPoints(-1),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
   
        [Test]
        [TestCase(0,0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed)
        {
            var calculator = new DemeritPointsCalculator();

            var points = calculator.CalculateDemeritPoints(speed);

            Assert.That(points, Is.EqualTo(expectedResult));
        }
    }
}
