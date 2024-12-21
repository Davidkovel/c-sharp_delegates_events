using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnonymousMethod4Test;
using AnonymousMethod5Test;

// lab task 5

namespace TestProjectLambdaTask5
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod4()
        {
            var maxArray = new Lab_Task5();

            int[] CustomArray = {1,2,3,4,5,6,7};
            Assert.AreEqual(7, maxArray.findMaxInArray(CustomArray));
        }
    }
}