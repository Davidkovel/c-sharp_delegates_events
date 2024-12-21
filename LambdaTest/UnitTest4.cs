using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnonymousMethod4Test;

// lab task 4

namespace TestProjectLambdaTask4
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod4()
        {
            var calculatorIsComputureDay = new Lab_Task4();

            Assert.IsTrue(calculatorIsComputureDay.IsProgrammersDay(256));
            Assert.IsFalse(calculatorIsComputureDay.IsProgrammersDay(222));
        }
    }
}