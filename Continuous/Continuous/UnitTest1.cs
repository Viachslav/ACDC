using Xunit;
using System;

namespace Continuous
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10, 2, 0.5, 25)]
        [InlineData(10.0001, 1.00, 0.01, 10.100101)]
        [InlineData(10, 1, 0.01, 10.1)]
        [InlineData(10, 2, 0.1, 21)]
        [InlineData(10, 1.001, 0.1, 11.01)]
        [InlineData(10, 2, 0.02, 20.2)]
        [InlineData(100, 2, 0.99, 299)]
        [InlineData(100, 2, 1, 300)]
        [InlineData(1000, 10, 0.12, 10120)]

        public void TestCompoundInterestPositive(double a, double b, double c, double expected)
        {
            double actual = WorkingMethod.CheckCompoundInterest(a, b, c);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 0.01)]
        [InlineData(-0.001, 1, 0)]
        [InlineData(0.001, 1, 0)]
        [InlineData(9.999, 1, 0)]
        [InlineData(10, 0, 0.01)]
        [InlineData(10, -1, 0.01)]
        [InlineData(10, -0.001, 0.01)]
        [InlineData(10, 1, 0)]
        [InlineData(10, 1, -0.010)]
        [InlineData(100, 2, 1.01)]
        public void TestCompoundInterestNegative(double a, int b, double c)
        {
            Action action = () => WorkingMethod.CheckCompoundInterest(a, b, c);
            Assert.Throws<ArgumentOutOfRangeException>(action);
        }
        // For test TeamCity
    }
}