using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb7_XUnit_Tests;
using Xunit;
using Xunit.Abstractions;

namespace TestProject1
{

    public class CalculatorTestFixture : IDisposable
    {
        public Calculator CalculatorInstance { get; private set; }

        public CalculatorTestFixture()
        {
            CalculatorInstance = new Calculator();
            // Perform any additional setup if needed
        }

        public void Dispose()
        {
            // Perform cleanup logic, if needed
        }
    }

}
