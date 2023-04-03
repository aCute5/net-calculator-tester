

namespace CalculatorProject
{
    using NUnit.Framework;
    using CalculatorProject;

    namespace CalculatorProjectTests
    {
        [TestFixture]
        public class CalculatorTests
        {
            public net_calculator_tester.Calculator calculator;

            [SetUp]
            public void Setup()
            {
                calculator = new  net_calculator_tester.Calculator();
            }

            [Test]
            public void TestAdd()
            {
                float result = calculator.Add(2, 3);
                Assert.AreEqual(5, result);
            }

            [Test]
            public void TestSubtract()
            {
                float result = calculator.Subtract(2, 3);
                Assert.AreEqual(-1, result);
            }

            [Test]
            public void TestDivide()
            {
                float result = calculator.Divide(6, 3);
                Assert.AreEqual(2, result);
            }

            [Test]
            public void TestDivideByZero()
            {
                Assert.Throws<System.DivideByZeroException>(() => calculator.Divide(5, 0));
            }

            [Test]
            public void TestMultiply()
            {
                float result = calculator.Multiply(2, 3);
                Assert.AreEqual(6, result);
            }
        }
    }

}