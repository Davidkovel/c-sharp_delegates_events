using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnonymousMethod7Test;

// lab task 7

namespace TestProjectLambdaTask6
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void TestMethod7()
        {
            var oddNumberInArray = new Lab_Task7();

            int[] inputArray = { 1, 2, 3};
            int[] expectedOutput = { 1, 3};

            int[] result = oddNumberInArray.FindOddNumbers(inputArray);
            CollectionAssert.AreEqual(expectedOutput, result);
        }
    }
}