using Tyuiu.ShakirovSA.Sprint6.Task2.V29.Lib;
namespace Tyuiu.ShakirovSA.Sprint6.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int wait = 0;
            double[] res = ds.GetMassFunction(-1, 1);
            Assert.AreEqual(wait, res[1]);
        }
    }
}
