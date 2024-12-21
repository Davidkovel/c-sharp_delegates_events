namespace HwLambdaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var function = new Hw_Task1();
            string s = "Red";
            var expected = (255, 0, 0);

            var result = function.GetRgb(s); 
            Assert.AreEqual(expected, result);

        }
    }
}