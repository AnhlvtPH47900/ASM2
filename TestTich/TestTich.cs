﻿namespace TestTich
{
    public class NumberCalculator
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public bool IsInteger(string input)
        {
            return int.TryParse(input, out _);
        }
    }

    [TestFixture]
    public class NumberCalculatorTests
    {
        private NumberCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new NumberCalculator();
        }

        [Test]
        [TestCase("5", "10", ExpectedResult = 50)]
        [TestCase("-5", "-10", ExpectedResult = 50)]
        [TestCase("0", "10", ExpectedResult = 0)]
        [TestCase("123", "456", ExpectedResult = 56088)]
        [TestCase("50", "10", ExpectedResult = 500)]
        [TestCase("15", "10", ExpectedResult = 150)]
        [TestCase("0", "sssa", ExpectedResult = 0)]
        [TestCase("123", "zxa", ExpectedResult = 56088)]
        [TestCase("abc", "456", ExpectedResult = 56088)]
        [TestCase("abc", "ssaw", ExpectedResult = 56088)]
     

        public int Test_Multiply_ValidIntegers(string a, string b)
        {
            if (_calculator.IsInteger(a) && _calculator.IsInteger(b))
            {
                int numA = int.Parse(a);
                int numB = int.Parse(b);
                return _calculator.Multiply(numA, numB);
            }
            else
            {
                Assert.Fail("Không phải số nguyên.");
                return 0; // Giá trị không quan trọng vì đã fail ở trên
            }
        }

    }
}
