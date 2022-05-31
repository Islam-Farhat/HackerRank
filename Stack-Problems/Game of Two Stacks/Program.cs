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
    public static int twoStacks(int maxSum, List<int> a, List<int> b)
    {
        int sum = 0; int count = 0; int nloop;

        if (a.Count >= b.Count)
        {
            nloop = a.Count;
        }
        else
            nloop = b.Count;

        for (int i = 0; i < nloop; i++)
        {
            if (a == null && b == null)
            {
                return count;
            }
            if (a == null)
            {
                sum = sum + b[0];
                if (sum <= maxSum)
                {
                    count++;
                    b.RemoveAt(0);
                }
            }
            if (b == null)
            {
                sum = sum + a[0];
                if (sum <= maxSum)
                {
                    count++;
                    a.RemoveAt(0);
                }
            }
            if (a != null && b != null)
            {
                int item1 = a[0];
                int item2 = b[0];
                if (item1 < item2)
                {
                    sum = sum + item1;
                    if (sum <= maxSum)
                    {
                        count++;
                        a.RemoveAt(0);
                    }
                    else
                        return count;
                }
                else
                {
                    sum = sum + item2;
                    if (sum <= maxSum)
                    {
                        count++;
                        b.RemoveAt(0);
                    }
                    else
                        return count;
                }
            }
        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int g = Convert.ToInt32(Console.ReadLine().Trim());

        for (int gItr = 0; gItr < g; gItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int maxSum = Convert.ToInt32(firstMultipleInput[2]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            int result = Result.twoStacks(maxSum, a, b);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
