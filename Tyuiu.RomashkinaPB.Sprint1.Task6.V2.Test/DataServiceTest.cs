using Tyuiu.RomashkinaPB.Sprint1.Task6.V2.Lib;

namespace Tyuiu.RomashkinaPB.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Привет, Hello мир!";
            DataService ds = new DataService();
            bool res = ds.CheckHello(strTest);
            Assert.IsTrue(res);
        }
    }
}
