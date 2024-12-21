namespace HwLambdaTest5
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod5()
        {
            var task5 = new Hw_Task5();

            int[] arr = { 1, 2, 3, -2, -3, -3, -1 }; 
            int[] arr_result = task5.GetUniqueNegativeNumbers(arr); 
            int[] arr_awaiting = { -2, -3, -1 };

            CollectionAssert.AreEqual(arr_awaiting, arr_result);
        }
    }
}