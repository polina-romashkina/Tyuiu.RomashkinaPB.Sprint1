using Tyuiu.RomashkinaPB.Sprint1.Task5.V4.Lib;

namespace Tyuiu.RomashkinaPB.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int time = 13257;

            int res = ds.SecondsToHours(time);

            int wait = 3;
                Assert.AreEqual(wait, res);
        }
    }
}
