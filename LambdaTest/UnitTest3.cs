using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnonymousMethod3Test;

// lab task 3

namespace TestProjectLambdaTask3
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            var calculatorCube = new Lab_Task3();

            Assert.AreEqual(64, calculatorCube.CalculateCube(4));
        }
    }
}