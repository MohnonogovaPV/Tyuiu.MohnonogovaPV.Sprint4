using Tyuiu.MohnonogovaPV.Sprint4.Task7.V30.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint4.Task7.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                  *");
            Console.WriteLine("* Задание #7                                                                               *");
            Console.WriteLine("* Вариант #30                                                                              *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                 *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"684259137159648\". Преобразуйте ее в матрицу 5 на 3  *");
            Console.WriteLine("* подсчитайте произведение четных чисел.                                                   *");
            Console.WriteLine("*                                                                                          *");

            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];

            string str = "684259137159648";

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            int res = ds.Calculate(n, m, str);

            Console.WriteLine("Произведение четных элементов = " + res);
            Console.ReadKey();
        }
    }
}
