using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnonymousMethodTest;

// lab task 1

namespace TestProjectLambda
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var checker = new NumberChecker();

            Assert.IsTrue(checker.IsEven(4));
            Assert.IsFalse(checker.IsEven(5));
        }
    }
}