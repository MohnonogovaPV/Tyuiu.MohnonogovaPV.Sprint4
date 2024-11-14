using Tyuiu.MohnonogovaPV.Sprint4.Task7.V30.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint4.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "684259137159648";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 73728;
            Assert.AreEqual(wait, res);
        }
    }
}