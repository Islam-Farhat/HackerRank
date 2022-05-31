using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    public static int equalStacks(List<int> h1, List<int> h2, List<int> h3)
    {
        int small;
        int sum1 = h1.Sum();
        int sum2 = h2.Sum();
        int sum3 = h3.Sum();
        while (h1 != null || h2 != null || h3 != null)
        {
            if (sum1 <= sum2 && sum1 <= sum3)
            {
                small = sum1;
            }
            else if (sum2 <= sum1 && sum2 <= sum3)
            {
                small = sum2;
            }
            else small = sum3;

            if (sum1==sum2&&sum1==sum3)
            {
                return sum1;
            }
            else
            {
                if (sum1!=small)
                {
                    int x = h1[0];
                    sum1 = sum1 - x;
                    h1.RemoveAt(0);
                    
                }
                if (sum2 != small)
                {
                    int x = h2[0];
                    sum2 = sum2 - x;
                    h2.RemoveAt(0);
                }
                if (sum3 != small)
                {
                    int x = h3[0];
                    sum3 = sum3 - x;
                    h3.RemoveAt(0);
                }
            }
        }
        return 0;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n1 = Convert.ToInt32(firstMultipleInput[0]);

        int n2 = Convert.ToInt32(firstMultipleInput[1]);

        int n3 = Convert.ToInt32(firstMultipleInput[2]);

        List<int> h1 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h1Temp => Convert.ToInt32(h1Temp)).ToList();

        List<int> h2 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h2Temp => Convert.ToInt32(h2Temp)).ToList();

        List<int> h3 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h3Temp => Convert.ToInt32(h3Temp)).ToList();

        int result = Result.equalStacks(h1, h2, h3);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
