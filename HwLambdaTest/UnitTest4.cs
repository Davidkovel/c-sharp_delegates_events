namespace HwLambdaTest4
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod4()
        {
            var positiveNumber = new Hw_Task4();
            int[] arr = { 1, 2, 3 };

            Assert.AreEqual(3, positiveNumber.CountPositiveNumbers(arr));
        }
    }
}