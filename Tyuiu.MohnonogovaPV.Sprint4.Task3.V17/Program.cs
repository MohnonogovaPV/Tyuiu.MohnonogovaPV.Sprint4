using Tyuiu.MohnonogovaPV.Sprint4.Task3.V17.Lib;
namespace Tyuiu.MohnonogovaPV.Sprint4.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Мохноногова П. В. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                                               *");
            Console.WriteLine("* Задание #3                                                                               *");
            Console.WriteLine("* Вариант #17                                                                              *");
            Console.WriteLine("* Выполнила: Мохноногова Полина Викторовна | АСОиУБ - 24-1                                 *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими            *");
            Console.WriteLine("* значениями в диапазоне от 1 до 8. Найдите сумму элементов в четвертом столбце массива.   *");
            Console.WriteLine("*                                                                                          *");

            int[,] array = new int[5, 5] { { 6, 4, 2, 2, 1 },
                                          { 3, 6, 5, 4, 1 },
                                          { 5, 2, 3, 1, 6 },
                                          { 8, 8, 4, 5, 3 },
                                          { 7, 4, 5, 1, 6 } };

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }

                Console.WriteLine();

            }

            Console.WriteLine();
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            int res = ds.Calculate(array);

            Console.WriteLine("Сумма элементов в четвертом столбце массива = " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
        
    

