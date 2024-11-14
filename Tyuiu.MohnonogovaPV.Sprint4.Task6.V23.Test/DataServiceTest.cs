using Tyuiu.MohnonogovaPV.Sprint4.Task6.V23.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint4.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            var w = new string[] { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };
            int res = ds.Calculate(w);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}