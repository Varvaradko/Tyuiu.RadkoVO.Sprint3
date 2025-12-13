using Tyuiu.RadkoVO.Sprint3.Task6.V21.Lib;

namespace Tyuiu.RadkoVO.Sprint3.Task6.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 19;
            int stopValue = 30;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 485;
            Assert.AreEqual(wait, res);
        }
    }
}
