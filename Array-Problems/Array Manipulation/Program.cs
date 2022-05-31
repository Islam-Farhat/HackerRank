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

    /*
     * Complete the 'arrayManipulation' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static long arrayManipulation(int n, List<List<int>> queries)
    {
        long[] outarray = new long[n];
        for (int i = 0; i < queries.Count; i++)
        {
            outarray[queries[i][0] - 1] = outarray[queries[i][0] - 1] + queries[i][2];
            if (queries[i][1]<n)
            {
                outarray[queries[i][1]] = outarray[queries[i][1]] - queries[i][2];
            }
        }
        long temp = 0, max = 0;
        for (int i = 0; i < n; i++)
        {
            temp = temp + outarray[i];
            if (temp > max)
                max = temp;
        }
        return max;


        //**********************************************************
        //solution one but time limit

        //long[] array = new long[n];    //queries[0][0] = 20;     note
        //foreach (var item in queries)
        //{
        //    for (long i = (item[0] - 1); i <= (item[1] - 1); i++)
        //    {
        //        array[i] = array[i] + item[2];
        //    }
        //}
        //return array.Max();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < m; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        long result = Result.arrayManipulation(n, queries);
        Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
