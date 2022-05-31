using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    static int GetMaxArea(int pos, int[] arr)
        {
            //need to check left and right for bounds
            int k = 1;
            for (int i = pos-1; i >= 0; i--)
            {
                if (arr[i] >= arr[pos])
                {
                    k++;
                }
                else
                {
                    break;
                }
            }

            for (int i = pos + 1; i < arr.Length; i++)
            {
                if (arr[i] >= arr[pos])
                    k++;
                else
                    break;
            }

            return arr[pos] * k;
        }
    
    static void Main(String[] args) 
    {
        int largestArea = 0;
            Console.ReadLine();
            int[] heights = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            for (int i = 0; i < heights.Length; i++)
            {
                int h = heights[i];
                int area = GetMaxArea(i,heights);

                if (area > largestArea)
                {
                    largestArea = area;
                }
            }
            Console.WriteLine(largestArea);
    }
}