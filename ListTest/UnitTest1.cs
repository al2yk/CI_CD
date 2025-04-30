using PercentageCalculations;

namespace CICDUnit
{
    public class PercentageCalculatorTests
    {
        private readonly PercentageCalculator _calculator;

        public PercentageCalculatorTests()
        {
            _calculator = new PercentageCalculator();
        }

        [Fact]
        public void CalculatePercentage_PositiveNumberAndPercentage_ReturnsCorrectResult()
        {
            double result = _calculator.CalculatePercentage(100, 50);
            Assert.Equal(50, result);
        }

        [Fact]
        public void CalculatePercentage_ZeroNumber_ReturnsZero()
        {
            double result = _calculator.CalculatePercentage(0, 50);
            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculatePercentage_NegativePercentage_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.CalculatePercentage(100, -50));
        }

        [Fact]
        public void CalculateOriginalNumber_PositivePercentageAndResult_ReturnsCorrectResult()
        {
            double result = _calculator.CalculateOriginalNumber(50, 50);
            Assert.Equal(100, result);
        }

        [Fact]
        public void CalculateOriginalNumber_ZeroPercentage_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.CalculateOriginalNumber(0, 50));
        }

        [Fact]
        public void CalculateOriginalNumber_NegativePercentage_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.CalculateOriginalNumber(-50, 50));
        }
    }
}
