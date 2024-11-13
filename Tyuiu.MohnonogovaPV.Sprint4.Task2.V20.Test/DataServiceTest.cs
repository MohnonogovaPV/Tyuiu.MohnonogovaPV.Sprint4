using Tyuiu.MohnonogovaPV.Sprint4.Task2.V20.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint4.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();


            int[] numsArray = { 2, 3, 3, 7, 6, 5, 5, 3, 2, 4, 6, 5, 6, 5, 3, 7 };
            int res = ds.Calculate(numsArray);
            int numsWaitArray = 26;
            Assert.AreEqual(numsWaitArray, res);

        }
    }
}