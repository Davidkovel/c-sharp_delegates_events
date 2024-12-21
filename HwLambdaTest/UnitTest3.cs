namespace HwLambdaTest3
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            var task = new Hw_Task3();
            int[] numbers = { 1, 7, 7, 8, 14 };
            int expected = 3;

            int result = task.ArrayCalculation(numbers);

            Assert.AreEqual(expected, result);
        }
    }
}