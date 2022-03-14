using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[10];
            for (int index = 0; index < Array.Length; index++)
            {
                Array[index] = index * index;
            }

            Console.WriteLine(string.Join("\n", Array));

            //Создать массив размером 10 элементов, заполнить его квадратами индексов (в цикле), и вывести его содержимое на экран
        }
    }
}
