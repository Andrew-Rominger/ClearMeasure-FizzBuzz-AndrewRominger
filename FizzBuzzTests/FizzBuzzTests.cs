using System;
using System.Linq;
using FizzBuzzLib;
using FizzBuzzTests.TestImplementations;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private TestMatchedWordNumberPrinter _printer;

        [SetUp]
        public void Setup()
        {
            _printer = new TestMatchedWordNumberPrinter();
        }

        [Test, TestCase(15), TestCase(100), TestCase(1)]
        public void Test_GetFizzBuzz_ValidUpperBound(int bound)
        {
            var fizzBuzzGenerator = new FizzBuzzGenerator(_printer);
            fizzBuzzGenerator.GenerateMatchedString( bound);
            var lines = _printer.CurrentPrintValue;
            Assert.AreEqual(lines.Count, bound);
        }

        [Test, TestCase(15,-15), TestCase(-15, -20), TestCase(100, 50)]
        public void Test_GetFizzBuzz_ValidUpperAndLowerBound(int upperBound, int lowerBound)
        {
            var fizzBuzzGenerator = new FizzBuzzGenerator(_printer);
            fizzBuzzGenerator.GenerateMatchedString( upperBound, lowerBound);
            var lines = _printer.CurrentPrintValue;
            Assert.AreEqual(Math.Abs(upperBound - lowerBound)+1, lines.Count);
        }
        
        [Test]
        public void Test_GetFizzBuzz_KnownValue_15()
        {
            var fizzBuzzGenerator = new FizzBuzzGenerator(_printer);
            fizzBuzzGenerator.GenerateMatchedString( 15);
            var lines = _printer.CurrentPrintValue;
            Assert.AreEqual("FizzBuzz", lines.Last());
        }
        
        [Test]
        public void Test_GetFizzBuzz_KnownValue_3()
        {
            var fizzBuzzGenerator = new FizzBuzzGenerator(_printer);
            fizzBuzzGenerator.GenerateMatchedString( 3);
            var lines = _printer.CurrentPrintValue;
            Assert.AreEqual("Fizz", lines.Last());
        }

        [Test]
        public void Test_GetFizzBuzz_KnownValue_5()
        {
            var fizzBuzzGenerator = new FizzBuzzGenerator(_printer);
            fizzBuzzGenerator.GenerateMatchedString( 5);
            var lines = _printer.CurrentPrintValue;
            Assert.AreEqual("Buzz", lines.Last());
        }

        [Test, TestCase(-15,1)]
        public void Test_GetFizzBuzz_InvalidValue(int upperBound, int lowerBound)
        {
            var fizzBuzzGenerator = new FizzBuzzGenerator(_printer);
            Assert.Throws<ArgumentException>(() => fizzBuzzGenerator.GenerateMatchedString( upperBound, lowerBound));
        }
    }
}