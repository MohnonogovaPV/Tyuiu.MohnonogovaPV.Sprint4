using Tyuiu.MohnonogovaPV.Sprint4.Task5.V8.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint4.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();

            int[,] nums = new int[3, 3] { { -3, -1, 4 },
                                          { 2, -1, 4 },
                                          { 1, -2, -3 },};

            int[,] res = ds.Calculate(nums);
            int[,] wait = new int[3, 3] { { 0, 0, 4 },{ 2, 0, 4 },{ 1, 0, 0 },}; 
            Assert.AreEqual(wait, res);
        }
    }
}