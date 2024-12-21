using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnonymousMethod2Test;

// lab task 2

namespace TestProjectLambdaTask2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            var calculator = new Lab_Task2();

            Assert.AreEqual(25, calculator.CalculateSquare(5));
        }
    }
}