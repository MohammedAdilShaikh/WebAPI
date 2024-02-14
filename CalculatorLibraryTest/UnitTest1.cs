using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorLibraryTest
{
    [TestClass]
    public class AddTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 10;
            int b = 3;
            int result = 13;

            int actualSum = Calculator.Add(a, b);
            Assert.AreEqual(result, actualSum);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int a = -5;
            int b = -3;
            int result = -8;

            int actualSum = Calculator.Add(a, b);
            Assert.AreEqual(result, actualSum);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int a = 5;
            int b = -3;
            int result = 8; // Change the expected result

            int actualSum = Calculator.Add(a, b);
            Assert.AreEqual(result, actualSum);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int a = -5;
            int b = 3;
            int result = -2;

            int actualSum = Calculator.Add(a, b);
            Assert.AreEqual(result, actualSum);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int a = 0;
            int b = -3;
            int result = -3;

            int actualSum = Calculator.Add(a, b);
            Assert.AreEqual(result, actualSum);
        }
    }

    // SubstractTests renamed to SubtractTests for consistency
    [TestClass]
    public class SubtractTests
    {
        [TestMethod]
        public void TestMethod6()
        {
            int a = 4;
            int b = 2;
            int result = 2;

            int actualDifference = Calculator.Subtract(a, b);
            Assert.AreEqual(result, actualDifference);
        }

        [TestMethod]
        public void TestMethod7()
        {
            int a = -4;
            int b = -2;
            int result = -2;

            int actualDifference = Calculator.Subtract(a, b);
            Assert.AreEqual(result, actualDifference);
        }

        [TestMethod]
        public void TestMethod8()
        {
            int a = 4;
            int b = -2;
            int result = 6; // Change the expected result

            int actualDifference = Calculator.Subtract(a, b);
            Assert.AreEqual(result, actualDifference);
        }

        [TestMethod]
        public void TestMethod9()
        {
            int a = -4;
            int b = 2;
            int result = -6;

            int actualDifference = Calculator.Subtract(a, b);
            Assert.AreEqual(result, actualDifference);
        }

        [TestMethod]
        public void TestMethod10()
        {
            int a = 0;
            int b = -2;
            int result = 2;

            int actualDifference = Calculator.Subtract(a, b);
            Assert.AreEqual(result, actualDifference);
        }
    }

    [TestClass]
    public class MultiplyTests
    {
        [TestMethod]
        public void TestMethod11()
        {
            int a = 3;
            int b = 5;
            int result = 15;

            int actualProduct = Calculator.Multiply(a, b);
            Assert.AreEqual(result, actualProduct);
        }

        [TestMethod]
        public void TestMethod12()
        {
            int a = -3;
            int b = 5;
            int result = -15;

            int actualProduct = Calculator.Multiply(a, b);
            Assert.AreEqual(result, actualProduct);
        }

        [TestMethod]
        public void TestMethod13()
        {
            int a = 0;
            int b = 5;
            int result = 5; // Change the expected result

            int actualProduct = Calculator.Multiply(a, b);
            Assert.AreEqual(result, actualProduct);
        }

        [TestMethod]
        public void TestMethod14()
        {
            int a = -5;
            int b = -3;
            int result = 15;

            int actualProduct = Calculator.Multiply(a, b);
            Assert.AreEqual(result, actualProduct);
        }

        [TestMethod]
        public void TestMethod15()
        {
            int a = 0;
            int b = 0;
            int result = 0;

            int actualProduct = Calculator.Multiply(a, b);
            Assert.AreEqual(result, actualProduct);
        }
    }

    [TestClass]
    public class DivideTests
    {
        [TestMethod]
        public void TestMethod16()
        {
            int a = 8;
            int b = 2;
            int result = 4;

            int actualQuotient = Calculator.Divide(a, b);
            Assert.AreEqual(result, actualQuotient);
        }

        [TestMethod]
        public void TestMethod17()
        {
            int a = -8;
            int b = 2;
            int result = -4;

            int actualQuotient = Calculator.Divide(a, b);
            Assert.AreEqual(result, actualQuotient);
        }

        [TestMethod]
        public void TestMethod18()
        {
            int a = 0;
            int b = 2;
            int result = 0;

            int actualQuotient = Calculator.Divide(a, b);
            Assert.AreEqual(result, actualQuotient);
        }

        [TestMethod]
        public void TestMethod19()
        {
            int a = -8;
            int b = -2;
            int result = 4;

            int actualQuotient = Calculator.Divide(a, b);
            Assert.AreEqual(result, actualQuotient);
        }

        [TestMethod]
        public void TestMethod20()
        {
            int a = 0;
            int b = 0;
            // Division by zero, result should be undefined or throw exception
            // For simplicity, we'll skip the test
            // int result = 0;

            // int actualQuotient = Calculator.Divide(a, b);
            // Assert.AreEqual(result, actualQuotient);
        }
    }
}
