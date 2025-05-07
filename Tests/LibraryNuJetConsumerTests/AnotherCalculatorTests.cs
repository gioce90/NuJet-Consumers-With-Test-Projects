using Xunit;
using LibraryNuJetConsumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryNuJetConsumer.Tests
{
    public class AnotherCalculatorTests
    {
        private readonly AnotherCalculator calculator;
        public AnotherCalculatorTests()
        {
            calculator = new AnotherCalculator();
        }

        [Fact()]
        public void AddTest()
        {
            Assert.True(calculator.Add(2, 3) == 5);
        }
    }
}