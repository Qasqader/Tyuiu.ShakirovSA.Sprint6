using Tyuiu.ShakirovSA.Sprint6.Task0.V15.Lib;
namespace Tyuiu.ShakirovSA.Sprint6.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1);
            Assert.AreEqual(12, res);
        }
    }
}
