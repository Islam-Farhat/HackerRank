using System;

namespace Array_hourglass
{
    class Hourglass
    {
        public static int hourglassSum(int[,] matrix)
        {
            int max = -100500;
            int temp = 0;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    temp = matrix[i - 1, j - 1] +   matrix[i-1,j]      +matrix[i - 1, j + 1] +
                                                    matrix[i, j]               +
                           matrix[i + 1, j - 1] +   matrix[i + 1, j]   + matrix[i + 1, j + 1];

                    max = Math.Max(max, temp);
                }
            }
            //Console.WriteLine(max);
            return max;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[6, 6];
            for (int i = 0; i < 6; i++)
            {
                String[] line = Console.ReadLine().Split(' ');//get the first line and split it by space' '.
                for (int j = 0; j < 6; j++)
                {
                    array[i, j] = int.Parse(line[j]);
                }

            }
                int result= Hourglass.hourglassSum(array);
            Console.WriteLine(result);
        }
    }
}
