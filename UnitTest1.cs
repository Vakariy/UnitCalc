using System;
using System.Runtime.Remoting.Messaging;
using Calc_Framework;
using NUnit.Framework;

namespace Test_1
{
    



    [TestFixture]
    public class UnitTest1
    {
        //время начала прохождения тестов
        public DateTime TimeOfTest;
        [OneTimeSetUp]
        public void Hook()
        {
            TimeOfTest = DateTime.Today;
        }

        [TestCase(1, 2, 3, Description = "Positive Test with pisitive numbers")]
        [TestCase(-10, -20, -30, Description = "Positive Test with negative numbers")]
        [TestCase(-10, 1, -9, Description = "Positive Test with negative and posutive numbers")]
        [TestCase(0, 0, 0, Description = "Positive Test with negative and posutive numbers")]
        public void AddTwoNumbersTest(double a, double b, double expectedResult)
        {
            double actResult = new Calculate().Add(a, b);
            Assert.AreEqual(expectedResult, actResult);
        }

        [TestCase(0, 0, 0, Description = "Positive Test with zero numbers")]
        [TestCase(10, 2, 20, Description = "Positive Test with positive numbers")]
        [TestCase(-4, -20, 80, Description = "Positive Test with negative numbers")]
        [TestCase(-2, 5, -10, Description = "Positive Test with positive and negative numbers")]
        public void SubstractTwoNumbersTest(double a, double b, double expectedResult)
        {
            double actResult = new Calculate().Multiply(a, b);
            Assert.AreEqual(expectedResult, actResult);
        }

        
        [TestCase(10, 10, 1, Description = "Positive Test with posotive numbers")]
        [TestCase(-1000, 100, -10, Description = "Positive Test with negative and positive numbers")]
        [TestCase(500, -10, -50, Description = "Positive Test with negative and positive numbers")]
        public void DivideTwoNumbersTest(double a, double b, double expectedResult)
        {
            double actResult = new Calculate().Divide(a, b);
            Assert.AreEqual(expectedResult, actResult);
        }

        [TestCase(10, 0, 0, Description = "Positive Test with posotive numbers and zero")]
        [TestCase(25, 4, 100, Description = "Positive Test with posotive numbers")]
        [TestCase(-11, -2, 22, Description = "Positive Test with negative numbers")]
        [TestCase(-9, 9, -81, Description = "Positive Test with negative and positive numbers")]
        [TestCase(7, -7, -49, Description = "Positive Test with negative and positive numbers")]
        public void MultiplyTwoNumbersTest(double a, double b, double expectedResult)
        {
            double actResult = new Calculate().Multiply(a, b);
            Assert.AreEqual(expectedResult, actResult);
        }

        [TestCase(10, 2, 0, Description = "Positive Test with positive numbers")]
        [TestCase(0, 0, 0, Description = "Positive Test with positive numbers")]
        [TestCase(-10, 3, -1, Description = "Positive Test with positive numbers")]
        public void RemainderOfDivisionTest(double a, double b, double expectedResult)
        {
            double actResult = new Calculate().RemainderOfDivision(a, b);
            Assert.AreEqual(expectedResult, actResult);
        }
    }
}
