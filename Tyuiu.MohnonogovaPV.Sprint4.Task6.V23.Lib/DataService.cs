﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MohnonogovaPV.Sprint4.Task6.V23.Lib
{
    public class DataService : ISprint4Task6V23
    {
        public int Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length == 6);
            return mas.Length;
        }
    }
}