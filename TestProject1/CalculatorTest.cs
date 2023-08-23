using Labb7_XUnit_Tests;
using Xunit;
using Xunit.Abstractions;

namespace TestProject1
{
    public class CalculatorTest : IClassFixture<CalculatorTestFixture>
    {
        private readonly CalculatorTestFixture _fixture;

        private readonly ITestOutputHelper _output;

        public CalculatorTest(CalculatorTestFixture fixture, ITestOutputHelper output)
        {
            _fixture = fixture;
            _output = output;
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 4, 1)]
        public void CalcAddition_(decimal expected, decimal num1, decimal num2)
        {
            _output.WriteLine($"Testing addition {expected} {num1} {num2}");
            decimal sum1 = _fixture.CalculatorInstance.Addition(num1, num2);

            Assert.Equal(expected, sum1);
        }
        
        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(1, 5, 4)]
        public void CalcSubtraction_(decimal expected, decimal num1, decimal num2)
        {
            _output.WriteLine($"Testing subtraction {expected} {num1} {num2}");

            decimal sum1 = _fixture.CalculatorInstance.Subtraction(num1, num2);

            Assert.Equal(expected, sum1);
        }
        
        [Theory]
        [InlineData(56, 8, 7)]
        [InlineData(21504, 256, 84)]
        public void CalcMultiplication_(decimal expected, decimal num1, decimal num2)
        {
            _output.WriteLine($"Testing multiplication {expected} {num1} {num2}");

            decimal sum1 = _fixture.CalculatorInstance.Multiplication(num1, num2);

            Assert.Equal(expected, sum1);
        }
        
        [Theory]
        [InlineData(1.5, 9, 6)]
        [InlineData(2, 6, 3)]
        public void CalcDivision_(decimal expected, decimal num1, decimal num2)
        {
            _output.WriteLine($"Testing division {expected} {num1} {num2}");

            decimal sum1 = _fixture.CalculatorInstance.Division(num1, num2);

            Assert.Equal(expected, sum1);
        }

        [Fact]
        public void TestHistory()
        {
            Calculator calculator = new Calculator();
            calculator.Addition(1, 2);
            calculator.Subtraction(8, 5);

            var history = calculator.GetCalculationHistory();
            Assert.Equal(2, history.Count);
            Assert.Equal("1 + 2 = 3", history[0]);
            Assert.Equal("8 - 5 = 3", history[1]);
        }

        [Fact]
        public void TestDivisionByZero()
        {
            Assert.Throws<ArgumentException>(() => _fixture.CalculatorInstance.Division(10, 0));
        }

    }
}