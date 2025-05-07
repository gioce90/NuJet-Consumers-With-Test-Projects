using Xunit;
using ExeNuJetConsumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeNuJetConsumer.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator calculator;
        public CalculatorTests()
        {
            calculator = new Calculator();
        }

        [Fact()]
        public void AddTest()
        {
            Assert.True(calculator.Add(2, 3) == 5);
            Assert.True(calculator.Add(2, 4) == 6);
        }
    }
}