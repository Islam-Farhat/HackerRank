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
    public static List<int> waiter(List<int> A, int q)
    {
        List<int> answers = new List<int>();
        List<int> prime = new List<int>();
        for (int i = 2; i < 10000; i++)
        {
            int count = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                prime.Add(i);
            }
        }
        //List<int> prime = new List<int> {
        //    2, 3 ,5 ,7 ,11, 13, 17, 19, 23, 29, 31, 37, 41, 43 ,47 ,53 ,59 ,61 ,67 ,71,
        //    73,   79 ,83 ,89 ,97 ,101 ,103 ,107 ,109 ,113 ,127 ,131 ,137 ,139 ,149 ,151 ,157 ,163 ,167 ,173,
        //    179, 181 ,191 ,193 ,197 ,199 ,211 ,223 ,227 ,229 ,233 ,239 ,241 ,251 ,257 ,263 ,269 ,271 ,277 ,281,
        //    283, 293 ,307 ,311 ,313 ,317 ,331 ,337 ,347 ,349 ,353 ,359 ,367 ,373 ,379 ,383 ,389 ,397 ,401 ,409,
        //    419, 421 ,431 ,433 ,439 ,443 ,449 ,457 ,461 ,463 ,467 ,479 ,487, 491 ,499 ,503 ,509 ,521 ,523 ,541,
        //    547 ,557 ,563 ,569 ,571 ,577 ,587 ,593 ,599 ,601 ,607 ,613 ,617 ,619 ,631 ,641 ,643 ,647 ,653 ,659,
        //    661 ,673 ,677 ,683 ,691 ,701 ,709 ,719 ,727 ,733 ,739 ,743 ,751 ,757 ,761 ,769 ,773, 787 ,797 ,809,
        //    811, 821 ,823 ,827 ,829 ,839 ,853 ,857 ,859 ,863 ,877 ,881 ,883 ,887 ,907 ,911 ,919 ,929 ,937 ,941,
        //    947 ,953 ,967 ,971 ,977 ,983 ,991 ,997 ,1009 ,1013 ,1019 ,1021 ,1031 ,1033 ,1039 ,1049 ,1051 ,1061 ,1063 ,1069,
        //    1087 ,1091 ,1093 ,1097 ,1103 ,1109 ,1117 ,1123 ,1129 ,1151 ,1153 ,1163 ,1171 ,1181 ,1187 ,1193
        //};
        int d = 0;
        for (int i = 0; i < q; i++)
        {
            if (d == 1)
            {
                break;
            }
            Stack<int> B = new Stack<int>();
            foreach (var item in A)
            {
                if (item%prime[i]==0)
                {
                    answers.Add(item);
                   // A.RemoveAt(0);
                }
                else
                {
                    B.Push(item);
                   // A.RemoveAt(0);
                }
            }
            if (B == null && d == 0)
            {

                d++;
            }

            A = B.ToList();
        }
        if (A!=null)
        {
            A.Reverse();
            foreach (var item in A)
            {
                answers.Add(item);
            }
        }
        return answers;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int q = Convert.ToInt32(firstMultipleInput[1]);

        List<int> number = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(numberTemp => Convert.ToInt32(numberTemp)).ToList();

        List<int> result = Result.waiter(number, q);

        Console.WriteLine(String.Join("\n", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
