using System;


namespace Task_4
{
    class Program
    {

        public Array GetMinMaxValues(int[] array)
        {
            int MinValue = array[0];
            int MaxValue = array[0];
            int[] Array = { MinValue, MaxValue };


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < MinValue) MinValue = array[i];
                if (array[i] > MaxValue) MaxValue = array[i];
            }

            return Array;
        }


        static void ChangeMinMaxValues(int[] Array)
        {
            int MaxValue = Array[0]; int MaxValueIndex = 0;
            int MinValue = Array[0]; int MinValueIndex = 0;

            for (int index = 0; index < Array.Length; index++)
            {
                if (Array[index] > MaxValue)
                {
                    MaxValue = Array[index];
                    MaxValueIndex = index;
                }
                if (Array[index] < MinValue)
                {
                    MinValue = Array[index];
                    MinValueIndex = index;
                }
            }

            Array[MinValueIndex] = MaxValue;
            Array[MaxValueIndex] = MinValue;

        }

        static void Main(string[] args)
        {

            Program array = new Program();

            int[] Array1 = { 2, 5, 90, 45, -1, 77 };
            int[] Array2 = { 77, -5, 45, 0, 99, 5, 2 };


            Console.WriteLine(array.GetMinMaxValues(Array1));
            Console.WriteLine(array.GetMinMaxValues(Array2));


            ChangeMinMaxValues(Array1);
            ChangeMinMaxValues(Array2);


            //Console.WriteLine("Numbers in Array: \n{0}", string.Join("\n", Array1));
            //Console.WriteLine("Numbers in Array: \n{0}", string.Join("\n", Array2));

        }
    }
}
