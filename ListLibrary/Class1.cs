
namespace PercentageCalculations
{
    public class PercentageCalculator
    {
        /// <summary>
        /// Вычисляет процент от заданного числа.
        /// </summary>
        /// <param name="number">Число, от которого нужно вычислить процент.</param>
        /// <param name="percentage">Процент, который нужно вычислить.</param>
        /// <returns>Процент от числа.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если percentage является отрицательным.</exception>
        public double CalculatePercentage(double number, double percentage)
        {
            if (percentage < 0)
            {
                throw new ArgumentException("Percentage cannot be negative");
            }
            return (percentage / 100) * number;
        }

        /// <summary>
        /// Вычисляет исходное число по заданному проценту и результату.
        /// </summary>
        /// <param name="percentage">Процент от исходного числа.</param>
        /// <param name="result">Результат вычисления процента от исходного числа.</param>
        /// <returns>Исходное число.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если percentage является нулем или отрицательным.</exception>
        public double CalculateOriginalNumber(double percentage, double result)
        {
            if (percentage <= 0)
            {
                throw new ArgumentException("Percentage must be greater than zero.");
            }
            return (result / percentage) * 100;
        }
    }
}