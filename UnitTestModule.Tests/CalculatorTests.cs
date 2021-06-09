using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestModule.Tests
{
    [TestFixture]
    public class CalculatorTests 
    {
        private readonly ICalculator calculator;

        public CalculatorTests()
        {
            this.calculator = new Calculator();
        }

        [Test]
        public void AdditionalShouldTrue()
        {
            var result = calculator.Additional(3, 2);
            Assert.AreEqual(5, result);
            Assert.AreNotEqual(6, result);
        }

        [Test]
        public void SubtractionShouldTrue()
        {
            var result = calculator.Subtraction(3, 2);
            Assert.AreEqual(1, result);
            Assert.AreNotEqual(2, result);
        }

        [Test]
        public void MiltiplicationShouldTrue()
        {
            var result = calculator.Miltiplication(3, 2);
            Assert.AreEqual(6, result);
            Assert.AreNotEqual(5, result);
        }

        [Test]
        public void DivisionShouldTrue()
        {
            var result = calculator.Division(6, 2);
            Assert.AreEqual(3, result);
            Assert.AreNotEqual(5, result);
        }

        [Test]
        public void DivisionDivideByZeroShouldThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Division(6, 0));
        }
    }
}
