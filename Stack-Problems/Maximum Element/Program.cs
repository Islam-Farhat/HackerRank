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
    public static void getMax(List<string> operations)
    {
        Stack<int> stack = new Stack<int>();
        Stack<int> maxSt = new Stack<int>();maxSt.Push(1);
        foreach (var item in operations)
        {
            string[] numbers = item.Split(' ');
            switch (numbers[0])
            {
                case "1":
                    int data = Convert.ToInt32(numbers[1]);
                    int max = data;
                    if (max<maxSt.Peek())
                    {
                        max = maxSt.Peek();
                    }
                    stack.Push(data);
                    maxSt.Push(max);
                    break;

                case "2":
                    stack.Pop();
                    maxSt.Pop();
                    break;

                case "3":
                    Console.WriteLine(maxSt.Peek());
                    break;

                default:
                    break;
            }

        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> ops = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string opsItem = Console.ReadLine();
            ops.Add(opsItem);
        }
        Result.getMax(ops);
    }
}
