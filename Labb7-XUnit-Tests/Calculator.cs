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

        public decimal Addition(decimal value1, decimal value2)
        {
            decimal result = value1 + value2;
            StoreCalculation(value1, value2, "+", result);
            return result;
        }

        public decimal Subtraction(decimal value1, decimal value2)
        {
            decimal result = value1 - value2;
            StoreCalculation(value1, value2, "-", result);
            return result;
        }

        public decimal Multiplication(decimal value1, decimal value2)
        {
            decimal result = value1 * value2;
            StoreCalculation(value1, value2, "*", result);
            return result;
        }

        public decimal Division(decimal value1, decimal value2)
        {
            if (value2 == 0)
                throw new ArgumentException("Cannot divide by zero.");

            decimal result = value1 / value2;
            StoreCalculation(value1, value2, "/", result);
            return result;
        }

        public List<string> GetCalculationHistory()
        {
            return calculationHistory;
        }

        private void StoreCalculation(decimal value1, decimal value2, string operation, decimal result)
        {
            string calculationString = $"{value1} {operation} {value2} = {result}";
            calculationHistory.Add(calculationString);
        }
    }

}
