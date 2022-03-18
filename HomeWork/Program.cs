using System;

namespace ConsoleApp2
{
    class Program
    {

        static void ChangeMinMaxValues(int[] Array)
        {
            int minElementValue = Array[0];
            int minElementIndex = 0;
            int maxElementValue = Array[0];
            int maxElementIndex = 0;

            for (int index = 0; index < Array.Length; index++)
            {
                int temp = Array[index];
                if (temp > maxElementValue)
                {
                    maxElementValue = temp;
                    maxElementIndex = index;
                }

                if (temp < minElementValue)
                {
                    minElementValue = temp;
                    minElementIndex = index;
                }
            }

            Console.WriteLine("Min Element Value: {0}, Max Element Value: {1} ", minElementValue, maxElementValue);

            Array[minElementIndex] = maxElementValue;
            Array[maxElementIndex] = minElementValue;

        }



        static void Main(string[] args)
        {
            int[] Array1 = { 2, 5, 90, 45, -1, 77 };
            int[] Array2 = { 77, -5, 45, 0, 99, 5, 2 };


            ChangeMinMaxValues(Array1);
            ChangeMinMaxValues(Array2);

        }
    }
}


// Создать два произвольных массива, подсчитать максимальное и минимальное значение их элементов. Вывести на экран
// Поменять в каждом массиве максимальные и минимальные значения местами

