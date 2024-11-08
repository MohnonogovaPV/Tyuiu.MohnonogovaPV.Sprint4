using Tyuiu.MohnonogovaPV.Sprint4.Task0.V22.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint4.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                              *");
            Console.WriteLine("* Задание #0                                                                               *");
            Console.WriteLine("* Вариант #22                                                                              *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                 *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими             *");
            Console.WriteLine("* значениями в диапазоне от 0 до 9 подсчитать сумму нечетных элементов массива.            *");
            Console.WriteLine("*                                                                                          *");

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            int[] numsArray = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("Сумма нечетных элементов = " + ds.GetSumOddArrEl(numsArray));

            Console.ReadKey();
        }
    }
}
