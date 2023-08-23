namespace Labb7_XUnit_Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartUp();
        }

        static void StartUp()
        {
            Calculator calculator = new Calculator();
            CalculatorConsoleUI calculatorConsoleUI = new CalculatorConsoleUI(calculator);
            calculatorConsoleUI.Run();
        }
    }
}