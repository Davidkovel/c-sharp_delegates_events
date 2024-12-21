using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnonymousMethod6Test;

// lab task 6

namespace TestProjectLambdaTask6
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestMethod6()
        {
            var maxArray = new Lab_Task6();

            int[] CustomArray = { 1, 2, 3, 4, 5, 6, 7 };
            Assert.AreEqual(1, maxArray.findMinInArray(CustomArray));
        }
    }
}