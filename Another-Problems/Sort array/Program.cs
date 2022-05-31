using System;

namespace Sort_array
{
    class Program 
    {
        public static void Main()
        {
            int[] array = { 3, 5, 2, 4, 7, 9, 33, 4, -1, 11 };
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}
