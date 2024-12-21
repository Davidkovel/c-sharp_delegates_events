namespace HwLambdaTest2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            var backpack = new Backpack("Black", "Nike", "USA", "Polyester", 1.0, 15.0);
            var item = new Item("Notebook", 2.0);

            backpack.AddItem(item);

            Assert.AreEqual(1, backpack.Contents.Count);
            Assert.AreEqual(item, backpack.Contents[0]);
        }
    }
}