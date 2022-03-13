using System;

namespace ConsoleApp2
{
    class Program
    {

        static void InitializeArray(int[] array, int coefficient)
        {
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = Convert.ToInt32(Math.Pow(index, coefficient));
            }
        }

        static double GetAverage(int[] Array)
        {
            double sum = 0;
            for (int index = 0; index < Array.Length; index++)
            {
                sum = sum + Array[index];
            }
            double average = Array.Length != 0 ? (double)sum / Array.Length : 0;

            return sum / Array.Length;
        }


        static void Main(string[] args)
        {
            int[] Array1 = new int[10];
            InitializeArray(Array1, 1);
            double ArrayAverage1 = GetAverage(Array1);


            int[] Array2 = new int[10];
            InitializeArray(Array2, 2);
            double ArrayAverage2 = GetAverage(Array2);

            int[] Array3 = new int[10];
            InitializeArray(Array3, 3);
            double ArrayAverage3 = GetAverage(Array3);



            Console.WriteLine(ArrayAverage1);
            Console.WriteLine(ArrayAverage2);
            Console.WriteLine(ArrayAverage3);


        }
    }
}


// Cоздать три массива по 10 элементов, первый заполнить значениями индексов элементов, второй - квадратами индексов, третий-кубами, и вывести на экран средние значения элементов для всех массивов

