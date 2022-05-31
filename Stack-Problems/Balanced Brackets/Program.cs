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
    public static string isBalanced(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (var item in s)
        {
            if (item=='['||item=='{'||item=='(')
            {
                stack.Push(item);
            }
            else
            {
                if (stack.Count==0)
                {
                    return "NO";
                }
                else
                {
                    if (stack.Peek() == '(' && item == ')' || stack.Peek() == '{' && item == '}' || stack.Peek() == '[' && item == ']')
                    {
                        stack.Pop();
                    }
                    else
                        return "NO";
                }
            }
        }
        return stack.Count == 0 ? "YES" : "NO"; //ternary operator
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            string result = Result.isBalanced(s);

            Console.WriteLine(result);
        }


    }
}
