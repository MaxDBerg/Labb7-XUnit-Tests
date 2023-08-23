using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_XUnit_Tests
{
    public class CalculatorConsoleUI
    {
        private Calculator _calculator;

        public CalculatorConsoleUI(Calculator calculator)
        {
            _calculator = calculator;
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the Calculator App!");

            while (true)
            {
                DisplayMenu();
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        SettingParametersForCalculation(choice);
                        break;
                    case 5:
                        ShowHistory();
                        break;
                    case 6:
                        Console.WriteLine("Exiting the Calculator App.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

        private decimal GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return decimal.Parse(Console.ReadLine());
        }

        private void SettingParametersForCalculation(int operationChoice)
        {
            decimal num1 = GetUserInput("Enter the first value: ");
            decimal num2 = GetUserInput("Enter the second value: ");
            PerformCalculation(operationChoice, num1, num2);
        }

        private void PerformCalculation(int operationChoice, decimal num1, decimal num2)
        {
            decimal result = 0;

            switch (operationChoice)
            {
                case 1:
                    Console.WriteLine($"Performing addition of {num1} and {num2}");
                    result = _calculator.Addition(num1, num2);
                    break;
                case 2:
                    Console.WriteLine($"Performing subtraction of {num1} and {num2}");
                    result = _calculator.Subtraction(num1, num2);
                    break;
                case 3:
                    Console.WriteLine($"Performing multiplication of {num1} and {num2}");
                    result = _calculator.Multiplication(num1, num2);
                    break;
                case 4:
                    Console.WriteLine($"Performing division of {num1} and {num2}");
                    result = _calculator.Division(num1, num2);
                    break;
                default:
                    break;
            }

            ShowCalculationResult(operationChoice, num1, num2, result);
        }

        private void ShowCalculationResult(int operationIndex, decimal num1, decimal num2, decimal result)
        {
            Console.WriteLine($"Result: {num1} {GetOperationSymbol(operationIndex)} {num2} = {result}");
        }

        private void DisplayMenu()
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Show History");
            Console.WriteLine("6. Exit");
        }
        
        private void ShowHistory()
        {
            var history = _calculator.GetCalculationHistory();
            Console.WriteLine("Calculation History:");
            foreach (var calculation in history)
            {
                Console.WriteLine(calculation);
            }
        }

        private string GetOperationSymbol(int operationIndex)
        {
            switch (operationIndex)
            {
                case 1:
                    return "+";
                case 2:
                    return "-";
                case 3:
                    return "*";
                case 4:
                    return "/";
                default:
                    return "";
            }
        }
        
    }

}
