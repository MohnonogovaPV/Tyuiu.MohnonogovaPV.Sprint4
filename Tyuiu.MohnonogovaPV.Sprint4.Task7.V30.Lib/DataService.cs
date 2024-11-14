using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MohnonogovaPV.Sprint4.Task7.V30.Lib
{
    public class DataService : ISprint4Task7V30
    {
        public int Calculate(int n, int m, string value)
        {
            int[] digits = new int[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                digits[i] = int.Parse(value[i].ToString());
            }

            int[,] matrix = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = digits[index++];
                }
            }

            int p = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        p *= matrix[i, j];
                    }
                }
            }

            return p;
        }
    }
}
