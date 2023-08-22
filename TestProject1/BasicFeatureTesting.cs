namespace TestProject1
{
    public class BasicFeatureTesting
    {
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 4, 1)]
        public void CalcAddition_(decimal expected, decimal num1, decimal num2)
        {
            decimal sum1 = Calculator.AdditionOfTwoNumbers(num1, num2);

            Assert.Equal(expected, sum1);
        }
        
        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(1, 5, 4)]
        public void CalcSubtraction_(decimal expected, decimal num1, decimal num2)
        {
            decimal sum1 = Calculator.SubtraktionOfTwoNumbers(num1, num2);

            Assert.Equal(expected, sum1);
        }
        
        [Theory]
        [InlineData(56, 8, 7)]
        [InlineData(21504, 256, 84)]
        public void CalcMultiplication_(decimal expected, decimal num1, decimal num2)
        {
            decimal sum1 = Calculator.MultiplicationOfTwoNumbers(num1, num2);

            Assert.Equal(expected, sum1);
        }
        
        [Theory]
        [InlineData(1.5, 9, 6)]
        [InlineData(2, 6, 3)]
        public void CalcDivision_(decimal expected, decimal num1, decimal num2)
        {
            decimal sum1 = Calculator.DivisionOfTwoNumbers(num1, num2);

            Assert.Equal(expected, sum1);
        }

    }
}