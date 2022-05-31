﻿using System.CodeDom.Compiler;
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
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY strings
     *  2. STRING_ARRAY queries
     */

    public static List<int> matchingStrings( List<string> strings, List<string> queries)
    {
        int count;
        int sizeOfString = strings.Count;
        int sizeOfQueries = queries.Count;
        List<int> arraycount = new List<int>();
        for (int i = 0; i < sizeOfQueries; i++)
        {
            count = 0;
            string temp = queries[i];
            for (int j = 0; j < sizeOfString; j++)
            {
                if (temp == strings[j])
                    count++;
            }
            Console.WriteLine(count);
            arraycount.Add(count);
        }
        return arraycount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> strings = new List<string>();

        for (int i = 0; i < stringsCount; i++)
        {
            string stringsItem = Console.ReadLine();
            strings.Add(stringsItem);
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> queries = new List<string>();

        for (int i = 0; i < queriesCount; i++)
        {
            string queriesItem = Console.ReadLine();
            queries.Add(queriesItem);
        }

        List<int> res = Result.matchingStrings(strings, queries);

        //textWriter.WriteLine(String.Join("\n", res));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
