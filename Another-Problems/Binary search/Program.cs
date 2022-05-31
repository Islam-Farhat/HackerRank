using System;

namespace Binary_search
{
    class Program
    {
        public static int? binarySearch(int []arr,int item)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low<=high)
            {
                double mid1 = Math.Round(((low + high) / 2d));//method round get the nearst even number //return double
                int mid = (int)mid1;
                int guess = arr[mid];
                if (guess==item) //Find the item.
                {
                    return mid;
                }
                if (guess > item) //The guess was too high.
                {
                    high = mid - 1; 
                }
                else  //The guess was too low.
                    low = mid + 1;
            }
            return null;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int? position = binarySearch(array, 17);
            Console.WriteLine(position);
        }
    }
}
