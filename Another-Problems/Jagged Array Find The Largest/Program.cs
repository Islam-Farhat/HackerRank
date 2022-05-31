using static System.Console;
using System;
using System.Linq;

namespace Jagged_Array_Find_The_Largest
{
    class Program
    {
        public static double[] FindLargest(double[][] values)
        {
            //Solution 1
            return values.Select(v => v.Max()).ToArray();

            #region Another Solution 
            ////gat max for first array
            //double max1 = values[0][0];
            //for (int i = 0; i < values[0].Length; i++)
            //{
            //    if (max1 < values[0][i])
            //    {
            //        max1 = values[0][i];
            //    }
            //}

            ////gat max for second array
            //double max2 = values[1][0];
            //for (int i = 0; i < values[1].Length; i++)
            //{
            //    if (max2 < values[1][i])
            //    {
            //        max2 = values[1][i];
            //    }
            //}

            ////gat max for third array
            //double max3 = values[2][0];
            //for (int i = 0; i < values[2].Length; i++)
            //{
            //    if (max3 < values[2][i])
            //    {
            //        max3 = values[2][i];
            //    }
            //}


            //double[] finalarray = { max1, max2, max3 };
            //return finalarray;
            #endregion

        }
        public static void Main(string[] args)
        {
            double[][] jaggedArray = new double[3][];
            jaggedArray[0] = new double[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new double[] { 0, 2, 4, 6 };
            jaggedArray[2] = new double[] { 11, 22 };
            double[] laregest= FindLargest(jaggedArray);
            foreach (var item in laregest)
            {
                Console.WriteLine($"{item}\t");
            }
        }
    }

}