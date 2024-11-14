using Tyuiu.MohnonogovaPV.Sprint4.Task6.V23.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint4.Task6.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Мохнонгова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                *");
            Console.WriteLine("* Тема: Класс Array                                                                        *");
            Console.WriteLine("* Задание #6                                                                               *");
            Console.WriteLine("* Вариант #23                                                                              *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                 *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Дан строковый массив данных. Используя класс Array подсчитайте количество элементов,     *");
            Console.WriteLine("* длина которых равна 6.                                                                   *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            var x = new string[] { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= x.Length - 1; i++)
            {
                Console.WriteLine(x[i]);
            }

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            int nums = ds.Calculate(x);
            Console.WriteLine("Количество элементов, длина которых равна 6 = " + nums);

            Console.ReadKey();

        }
    }
}
