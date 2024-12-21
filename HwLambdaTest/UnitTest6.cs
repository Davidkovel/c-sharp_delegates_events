namespace HwLambdaTest6
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestMethod6()
        {
            var task = new Hw_Task6();
            string text = "This is text"; 
            string word = "text"; 
            bool expectedResult = true; 
            
            bool result = task.ContainsWord(text, word); 
            
            Assert.AreEqual(expectedResult, result);
        }
    }
}