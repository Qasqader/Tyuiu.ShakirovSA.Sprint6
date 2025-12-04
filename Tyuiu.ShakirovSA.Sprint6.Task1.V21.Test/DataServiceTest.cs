using Tyuiu.ShakirovSA.Sprint6.Task1.V21.Lib;
namespace Tyuiu.ShakirovSA.Sprint6.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int wait = 1;
            double[] res = ds.GetMassFunction(-1, 1);
            Assert.AreEqual(res[1], wait);
        }
    }
}
