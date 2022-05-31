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
    public static int truckTour(List<List<int>> petrolpumps, int n)
    {
        int litre = 0; int count = 0;
        for (int i = 0; i < n; i++)
        {
            List<int> item = petrolpumps[i];
            if (litre + item[0] > item[1])
            {
                litre = litre + item[0];
                litre = litre - item[1];
                count++;
                if (count == n)
                {
                    return i+1;
                }
            }
            else
            {
                //begain again from next point
                count = 0;
                litre = 0;
            }
            if (i == n - 1 && count != n)
            {
                i = -1;
            }
        }

        return 0;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> petrolpumps = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            petrolpumps.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(petrolpumpsTemp => Convert.ToInt32(petrolpumpsTemp)).ToList());
        }

        int result = Result.truckTour(petrolpumps, n);

        Console.WriteLine(result);
    }
}
