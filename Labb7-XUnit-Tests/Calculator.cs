using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_XUnit_Tests
{
    public class Calculator
    {
        private List<string> calculationHistory;

        public Calculator()
        {
            calculationHistory = new List<string>();
        }

        public decimal Addition(decimal num1, decimal num2)
        {
            decimal result = num1 + num2;
            StoreCalculation(num1, num2, "+", result);
            return result;
        }

        public decimal Subtraction(decimal num1, decimal num2)
        {
            decimal result = num1 - num2;
            StoreCalculation(num1, num2, "-", result);
            return result;
        }

        public decimal Multiplication(decimal num1, decimal num2)
        {
            decimal result = num1 * num2;
            StoreCalculation(num1, num2, "*", result);
            return result;
        }

        public decimal Division(decimal num1, decimal num2)
        {
            if (num2 == 0)
                throw new ArgumentException("Cannot divide by zero.");

            decimal result = num1 / num2;
            StoreCalculation(num1, num2, "/", result);
            return result;
        }

        public List<string> GetCalculationHistory()
        {
            return calculationHistory;
        }

        private void StoreCalculation(decimal num1, decimal num2, string operation, decimal result)
        {
            string calculationString = $"{num1} {operation} {num2} = {result}";
            calculationHistory.Add(calculationString);
        }
    }

}
