using Tyuiu.ShakirovSA.Sprint6.Task6.V23.Lib;
namespace Tyuiu.ShakirovSA.Sprint6.Task6.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds =  new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask6V23.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
